﻿using System;

namespace estates
{
    class Client
    {
        string _name;
        string _surname;
        string _phoneNumber;
        DateTime _dateOfBirth;

        public Client(string name, string surname, string phone_number, string date)
        {
            _name = name;
            _surname = surname;
            _phoneNumber = phone_number;
            DateTime.TryParseExact(date, new[]{"dd/MM/yyyy", "dd.mm.yyyy"}, null, System.Globalization.DateTimeStyles.None, out DateTime _dateOfBirth);
        }
    }
}
