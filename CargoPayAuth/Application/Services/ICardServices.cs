using CargoPayAuth.Application.DTOs;
using CargoPayAuth.Domain.Application.Models;

namespace CargoPayAuth.Application.Services
{
    public interface ICardServices
    {
        public Card CreateCard(CreateCardRequestDto createCardRequestDto);
        public Card GetCard(string cardNumber);
        public bool Pay(PayQueryDto payQueryDto);

    }
}
