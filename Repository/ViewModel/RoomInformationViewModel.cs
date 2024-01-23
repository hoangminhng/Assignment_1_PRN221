using BusinessObject.Models;
using BusinessObject.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Repository;

namespace Business.ViewModels
{
    public class RoomInformationViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        private readonly ErrorsViewModel _errorsViewModel;
        private readonly RoomInformation _roomInformation;
        private List<RoomType> _roomsTypes;

        public RoomInformationViewModel(RoomInformation roomInformation)
        {
            _roomInformation = roomInformation;
            _errorsViewModel = new ErrorsViewModel();
            _errorsViewModel.ErrorsChanged += ErrorsViewModel_ErrorChanged;
            IBaseRepository<RoomType> _roomTypeRepository = new RoomTypeRepository();
            _roomsTypes = _roomTypeRepository.GetAll();
        }

        public int RoomId
        {
            get => _roomInformation.RoomId;
            set
            {
                if (_roomInformation.RoomId != value)
                {
                    _roomInformation.RoomId = value;
                    OnPropertyChanged(nameof(RoomId));
                }
            }
        }

        public string RoomNumber
        {
            get => _roomInformation.RoomNumber;
            set
            {
                if (_roomInformation.RoomNumber != value)
                {
                    _errorsViewModel.ClearErrors(nameof(RoomNumber));
                    if (string.IsNullOrEmpty(value))
                    {
                        _errorsViewModel.AddError(nameof(RoomNumber), "Room number must not be null");
                    }

                    _roomInformation.RoomNumber = value;
                    OnPropertyChanged(nameof(RoomNumber));
                }
            }
        }

        public string RoomDetailDescription
        {
            get { return _roomInformation.RoomDetailDescription; }
            set
            {
                if (_roomInformation.RoomDetailDescription != value)
                {
                    _errorsViewModel.ClearErrors(nameof(RoomDetailDescription));
                    if (string.IsNullOrEmpty(value))
                    {
                        _errorsViewModel.AddError(nameof(RoomDetailDescription),
                            "Room detail description must not be null");
                    }

                    _roomInformation.RoomDetailDescription = value;
                    OnPropertyChanged(nameof(RoomDetailDescription));
                }
            }
        }

        public int? RoomMaxCapacity
        {
            get => _roomInformation.RoomMaxCapacity;
            set
            {
                if (_roomInformation.RoomMaxCapacity != value)
                {
                    _roomInformation.RoomMaxCapacity = value;
                    OnPropertyChanged(nameof(RoomMaxCapacity));
                }
            }
        }

        public int RoomTypeId
        {
            get => _roomInformation.RoomTypeId;
            set
            {
                if (_roomInformation.RoomTypeId != value)
                {
                    _roomInformation.RoomTypeId = value;
                    OnPropertyChanged(nameof(RoomTypeId));
                }
            }
        }

        public byte? RoomStatus
        {
            get => _roomInformation.RoomStatus;
            set
            {
                if (_roomInformation.RoomStatus != value)
                {
                    _roomInformation.RoomStatus = value;
                    OnPropertyChanged(nameof(RoomStatus));
                }
            }
        }

        public decimal? RoomPricePerDay
        {
            get => _roomInformation.RoomPricePerDay;
            set
            {
                if (_roomInformation.RoomPricePerDay != value)
                {
                    _roomInformation.RoomPricePerDay = value;
                    OnPropertyChanged(nameof(RoomPricePerDay));
                }
            }
        }

        public virtual RoomType RoomType
        {
            get => _roomInformation.RoomType;
            set
            {
                if (_roomInformation.RoomType != value)
                {
                    _roomInformation.RoomType = value;
                    OnPropertyChanged(nameof(RoomType));
                }
            }
        }
        
        public string RoomTypeName
        {
            get
            {
                return _roomsTypes.Find(x => x.RoomTypeId == _roomInformation.RoomTypeId).RoomTypeName;
            }
            set
            {
                if (_roomInformation.RoomType != null)
                {
                    _roomInformation.RoomType.RoomTypeName = value;
                    OnPropertyChanged(nameof(RoomTypeName));
                }
            }
        }

        public virtual ICollection<BookingDetail> BookingDetails
        {
            get => _roomInformation.BookingDetails;
            set
            {
                if (_roomInformation.BookingDetails != value)
                {
                    _roomInformation.BookingDetails = value;
                    OnPropertyChanged(nameof(BookingDetails));
                }
            }
        }

        public bool CanCreate => !HasErrors;

        public bool HasErrors => _errorsViewModel.HasErrors;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsViewModel.GetErrors(propertyName);
        }

        public IEnumerable GetErrors()
        {
            return _errorsViewModel.GetAllErrors();
        }

        private void ErrorsViewModel_ErrorChanged(object? sender, DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged(nameof(CanCreate));
        }
    }
}