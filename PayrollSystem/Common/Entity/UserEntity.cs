using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Interface;
using Common.Message;

namespace Common.Entity
{
    public class UserEntity : IUserEntity
    {
        #region Variables

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private byte _positionType;
        private string _errorMessage;
        private Guid _userID;
        #endregion

        public UserEntity()
        {
        }

        public UserEntity(Guid userID,
            byte positionType,
            string firstName,
            string middleName,
            string lastName)
        {
            _userID = userID;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _positionType = positionType;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                _errorMessage = ErrorMessage.FIRSTNAME_REQUIRED;
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                _errorMessage = ErrorMessage.LASTNAME_REQUIRED;
                return false;
            }

            if (PositionType == 0)
            {
                _errorMessage = ErrorMessage.POSITION_TYPE;
                return false;
            }
            return true;
        }

        public string GetErrorMessage()
        {
            return _errorMessage;
        }

        #region Properties

        public Guid UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public byte PositionType
        {
            get
            {
                return _positionType;
            }
            set
            {
                _positionType = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        #endregion

        #region MaxLength

        public int FirstNameMaxLength
        {
            get
            {
                return 50;
            }
        }

        public int LastNameMaxLength
        {
            get
            {
                return 50;
            }
        }

        public int MiddleNameMaxLength
        {
            get
            {
                return 50;
            }
        }

        #endregion

    }
}
