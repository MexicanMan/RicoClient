﻿using RicoClient.Scripts.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace RicoClient.Scripts.Menu.Collection
{
    public class ModalCardScript : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bigCardHolder = null;
        [SerializeField]
        private TMP_Text _price = null;

        private GameObject _bigCard;

        public void OnDisable()
        {
            Destroy(_bigCard);
        }

        public void SetModalCard(BaseCardScript card, int price)
        {
            _bigCard = Instantiate(card.gameObject, _bigCardHolder.transform);
            _price.text = price.ToString();

            gameObject.SetActive(true);
        }

        public void OnBuyClick()
        {
            // Buy logic
        }
    }
}
