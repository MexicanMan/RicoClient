﻿using RicoClient.Scripts.Exceptions;
using RicoClient.Scripts.Network.Controllers;
using RicoClient.Scripts.User;
using RicoClient.Scripts.User.Storage;
using UniRx.Async;
using UnityEngine;

namespace RicoClient.Scripts.Network
{
    public class NetworkManager
    {
        private readonly UserManager _userManager;

        private readonly AuthController _authController;
        private readonly CardsController _cardsController;

        public NetworkManager(UserManager userManager, AuthController authController, CardsController cardsController)
        {
            _userManager = userManager;

            _authController = authController;
            _cardsController = cardsController;
        }

        public async UniTask<bool> OAuth()
        {
            try
            {
                TokenInfo tokens = await _authController.OAuthRequest();
                if (tokens.AccessToken != null && tokens.AccessToken.Length > 0)
                    _userManager.AuthorizeUser(tokens);
            }
            catch (ApplicationException e)
            {
                Debug.LogError(e.Message);
                return false;
            }

            return true;
        }
    }
}
