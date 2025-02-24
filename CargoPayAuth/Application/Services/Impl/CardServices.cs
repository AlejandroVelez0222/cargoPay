using CargoPayAuth.Application.DTOs;
using CargoPayAuth.Domain.Application.Models;

namespace CargoPayAuth.Application.Services.Impl
{
    public class CardServices: ICardServices
    {

        private readonly List<Card> _cards = new();
        public CardServices() { }

        public Card CreateCard(CreateCardRequestDto createCardRequestDto)
        {
            var newCard = new Card
            {
                CardNumber = createCardRequestDto?.CardNumber ?? string.Empty,
                Balance = createCardRequestDto?.Balance ?? 0,
                CardClientName = createCardRequestDto?.CardClientName ?? string.Empty,
                CardCVV = createCardRequestDto?.CardCVV ?? string.Empty,
            };
            _cards.Add(newCard);
            return newCard;
        }

        public Card GetCard(string cardNumber)
        {
            return _cards.FirstOrDefault(c => c.CardNumber == cardNumber) ?? new Card();
        }

        public bool Pay(PayQueryDto payQueryDto)
        {
            if(payQueryDto == null || string.IsNullOrEmpty(payQueryDto.CardNumber) || payQueryDto?.Amount == null)
            {
                throw new ArgumentNullException(nameof(payQueryDto));
            }
            var card = GetCard(payQueryDto.CardNumber);
            if (card == null || card.Balance < payQueryDto?.Amount || card.CardCVV != payQueryDto?.CardCVV )
            {
                return false; 
            }

            card.Balance -= payQueryDto?.Amount?? 0 ;
            return true;
        }

        private string GenerateCardNumber()
        {
            Random random = new();
            return string.Concat(Enumerable.Range(0, 15).Select(_ => random.Next(0, 10).ToString()));
        }
    }
}
