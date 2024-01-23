using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Business.ViewModels;
using BusinessObject.Models;
using Repository;

namespace WpfHotelManagement
{
    public partial class AdminManageRoom : UserControl
    {
        private readonly IBaseRepository<RoomInformation> _roomInformationRepository;
        private readonly IBaseRepository<BookingDetail> _bookingDetailRepository;
        private readonly IBaseRepository<RoomType> _roomTypeRepository;
        private string originalRoomNumber;

        public AdminManageRoom()
        {
            InitializeComponent();
            _roomInformationRepository = new RoomInformationRepository();
            _bookingDetailRepository = new BookingDetailRepository();
            _roomTypeRepository = new RoomTypeRepository();
            LoadRoomInformation();
            LoadRoomTypes();
        }

        private void LoadRoomInformation()
        {
            var roomInformation = _roomInformationRepository.GetAll().Select(room => new RoomInformationViewModel(room))
                .ToList();
            dgRooms.ItemsSource = roomInformation;
            ResetTexBox();
        }

        private void LoadRoomTypes()
        {
            var roomTypes = _roomTypeRepository.GetAll();
            cbRoomType.ItemsSource = roomTypes;
            cbRoomType.DisplayMemberPath = "RoomTypeName";
            cbRoomType.SelectedValuePath = "RoomTypeId";
            cbRoomType.SelectedItem = roomTypes[0];
        }

        private void ResetTexBox()
        {
            txtRoomId.Text = "";
            txtDetailDescription.Text = "";
            txtMaxCapacity.Text = "";
            txtRoomNumber.Text = "";
            txtDetailDescription.Text = "";
            txtPricePerDay.Text = "";
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private bool checkNullOrEmpty()
        {
            bool nullOrEmpty = true;
            if (string.IsNullOrEmpty(txtRoomNumber.Text) ||
                string.IsNullOrEmpty(txtDetailDescription.Text) || string.IsNullOrEmpty(txtDetailDescription.Text) ||
                string.IsNullOrEmpty(txtRoomNumber.Text) || string.IsNullOrEmpty(cbRoomStatus.Text) ||
                string.IsNullOrEmpty(txtPricePerDay.Text) || string.IsNullOrEmpty(cbRoomType.Text))
            {
                nullOrEmpty = true;
            }
            else
            {
                nullOrEmpty = false;
            }

            return nullOrEmpty;
        }

        private byte getRoomStatus()
        {
            byte roomStatus = 0;
            roomStatus = (byte)(cbRoomStatus.Text == "Available" ? 1 : 0);
            return roomStatus;
        }

        private string getRoomStatusText(byte status)
        {
            string roomStatus = "Available";
            roomStatus = (status == 1 ? "Available" : "Unavailable");
            return roomStatus;
        }

        private bool IsDuplicateRoomNumber(string roomNumber)
        {
            return originalRoomNumber != roomNumber &&
                   _roomInformationRepository.GetAll().Any(x => x.RoomNumber == roomNumber);
        }

        private int GetRoomTypeId(string roomType)
        {
            int roomTypeId = 0;
            var roomTypeInformation = _roomTypeRepository.GetAll().ToList();
            foreach (var type in roomTypeInformation)
            {
                if (type.RoomTypeName == roomType)
                {
                    roomTypeId = type.RoomTypeId;
                }
            }

            return roomTypeId;
        }

        private void BtnCreate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                bool nullOrEmpty = checkNullOrEmpty();
                string roomNumber = txtRoomNumber.Text;
                if (nullOrEmpty == true)
                {
                    MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButton.OK);
                }
                else if (IsDuplicateRoomNumber(roomNumber))
                {
                    MessageBox.Show("Duplicate room number", roomNumber, MessageBoxButton.OK);
                }
                else
                {
                    RoomInformation room = new RoomInformation
                    {
                        RoomNumber = txtRoomNumber.Text,
                        RoomDetailDescription = txtDetailDescription.Text,
                        RoomMaxCapacity = Int32.Parse(txtMaxCapacity.Text),
                        RoomTypeId = GetRoomTypeId(cbRoomType.Text),
                        RoomStatus = getRoomStatus(),
                        RoomPricePerDay = Int32.Parse(txtPricePerDay.Text),
                    };
                    bool created = _roomInformationRepository.Create(room);
                    if (created)
                    {
                        LoadRoomInformation();
                        MessageBox.Show("Room has been created", "Success", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fail to create", "Warning", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                bool nullOrEmpty = checkNullOrEmpty();
                string roomNumber = txtRoomNumber.Text;

                if (nullOrEmpty == true)
                {
                    MessageBox.Show("Please fill all required fields", "Warning", MessageBoxButton.OK);
                }
                else if (IsDuplicateRoomNumber(roomNumber))
                {
                    MessageBox.Show("Duplicate room number", roomNumber, MessageBoxButton.OK);
                }
                else
                {
                    var roomInfo = dgRooms.SelectedItem as RoomInformationViewModel;
                    RoomInformation existingRoom = _roomInformationRepository.GetById(roomInfo.RoomId);
                    bool updated = false;

                    if (existingRoom != null)
                    {
                        existingRoom.RoomNumber = txtRoomNumber.Text;
                        existingRoom.RoomDetailDescription = txtDetailDescription.Text;
                        existingRoom.RoomMaxCapacity = Int32.Parse(txtMaxCapacity.Text);
                        existingRoom.RoomTypeId = GetRoomTypeId(cbRoomType.Text);
                        existingRoom.RoomStatus = getRoomStatus();
                        existingRoom.RoomPricePerDay = Decimal.Parse(txtPricePerDay.Text);

                        updated = _roomInformationRepository.Update(existingRoom);
                    }

                    if (updated)
                    {
                        LoadRoomInformation();
                        MessageBox.Show("Room has been updated", "Success", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fail to update", "Warning", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRoomId.Text))
                {
                    MessageBox.Show("Please select a room to delete", "Warning", MessageBoxButton.OK);
                }
                else
                {
                    RoomInformation roomInformation = _roomInformationRepository.GetById(int.Parse(txtRoomId.Text));
                    if (roomInformation != null)
                    {
                        bool isContained = _bookingDetailRepository.GetAll().Any(x => x.RoomId == roomInformation.RoomId);
                        if (isContained == true)
                        {
                            MessageBox.Show("Room has booking reservation, status change to 0", "Warning",
                                MessageBoxButton.OK);
                            roomInformation.RoomStatus = 0;
                            _roomInformationRepository.Update(roomInformation);
                            LoadRoomInformation();
                        }
                        else
                        {
                            MessageBoxResult confirm =
                                MessageBox.Show("Are you sure want to delete?", "Warning", MessageBoxButton.YesNo);
                            if (confirm == MessageBoxResult.Yes)
                            {
                                bool deleted = _roomInformationRepository.Delete(roomInformation);
                                if (deleted == true)
                                {
                                    MessageBox.Show("Success to delete", "Success", MessageBoxButton.OK);
                                    LoadRoomInformation();
                                }
                                else
                                {
                                    MessageBox.Show("Fail to delete", "Waring", MessageBoxButton.OK);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void DgCustomers_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgRooms.SelectedItem is RoomInformationViewModel roomInformation)
            {
                originalRoomNumber = roomInformation.RoomNumber;
                txtRoomId.Text = roomInformation.RoomId.ToString();
                txtRoomNumber.Text = roomInformation.RoomNumber;
                txtDetailDescription.Text = roomInformation.RoomDetailDescription;
                txtMaxCapacity.Text = roomInformation.RoomMaxCapacity.ToString();
                cbRoomStatus.Text = getRoomStatusText(roomInformation.RoomStatus.Value);
                txtPricePerDay.Text = roomInformation.RoomPricePerDay.ToString();
                cbRoomType.Text = roomInformation.RoomTypeName;
            }
        }
    }
}