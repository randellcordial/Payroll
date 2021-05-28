using Common.Interface;
using Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entity
{
    public class PositionEntity : IPosition
    {
        #region Variables

        private string _positionName;
        private decimal _rate;
        private string _errorMessage;

        #endregion

        public PositionEntity()
        { 
        
        }

        public PositionEntity(string positionName,
            decimal rate)
        {
            _positionName = positionName;
            _rate = rate;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(PositionName))
            {
                _errorMessage = ErrorMessage.POSITION_NAME_REQUIRED;
                return false;
            }

            if (PositionName.Length > PositionNameMaxLength)
            {
                _errorMessage = ErrorMessage.POSITION_EXCEED_MAX_LENGTH;
                return false;
            }

            if (_rate < 1)
            {
                _errorMessage = ErrorMessage.RATE_REQUIRED;
                return false;
            }

            return true;
        }

        public string PositionName
        {
            get
            {
                return _positionName;
            }

            set {
                _positionName = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }

        public int PositionNameMaxLength
        {
            get
            {
                return 25;
            }
        }

        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }
}
