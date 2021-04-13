using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CardFacade
    {
        private AddCardMechanism addCard;
        private AddMoneyMechanism addMoney;
        private TransferMoneyMechanism transferMoney;
        private RetrieveMoneyMechanism retrieveMoney;

        public CardFacade()
        {
            addCard = new AddCardMechanism();
            addMoney = new AddMoneyMechanism();
            transferMoney = new TransferMoneyMechanism();
            retrieveMoney = new RetrieveMoneyMechanism();
        }

        public string getCardResults(string card)
        {
            addCard.Card = card;
            addCard.addCardDetails("Vanessa", 22);
            addMoney.addMoney(card, 400, 450);
            retrieveMoney.retrieve(800,200);
            transferMoney.tranfer(card, "67764345");
            return $"The results for {card}";
        }
    }
}
