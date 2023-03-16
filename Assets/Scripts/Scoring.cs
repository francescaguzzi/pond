using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Scoring : MonoBehaviour {

    public EventTrigger.TriggerEvent onScored;

     // script per gestire il punteggio e la vittoria
    private void OnTriggerEnter2D(Collider2D collision) {

        Pebble pebble = collision.gameObject.GetComponent<Pebble>();

        if (pebble != null) {

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.onScored.Invoke(eventData);
        }
    }
}
