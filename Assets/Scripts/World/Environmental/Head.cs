﻿using Objects;
using UnityEngine;

namespace World.Environmental
{
    [RequireComponent(typeof(AudioSource), typeof(BoxCollider))]
    public class Head : MonoBehaviour
    {
        [SerializeField] private AudioData _dropSound;
        
        private AudioSource _audioSource;
        private bool _didDrop;
        
        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (_didDrop || !other.gameObject.CompareLayer("Ground")) return;
            
            _audioSource.PlayOneShot(_dropSound);
            _didDrop = true;
        }
    }
}