﻿using simple.cqrs.commands.Interfaces;

namespace simple.cqrs.commands.Implementation.Address
{
    public class InsertAddressCommand : ICommand
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int ZipCode { get; set; }
    }
}
