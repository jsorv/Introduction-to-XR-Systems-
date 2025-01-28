using UnityEngine;

public class PlayerSwitchPosition : MonoBehaviour
{
    public Transform roomPosition;       // Viite pelaajan alkuperäiseen sijaintiin huoneessa
    public Transform externalPosition;   // Viite ulkoisen katselupisteen sijaintiin
    private bool isAtExternalPosition = false; // Lippu, joka seuraa pelaajan sijaintia

    public KeyCode switchKey = KeyCode.Space; // Näppäin, jolla vaihdetaan sijaintia (väliasettelu Space-näppäin)

    void Update()
    {
        // Tarkista, jos käyttäjä painaa vaihtopainiketta
        if (Input.GetKeyDown(switchKey))
        {
            SwitchPosition();
        }
    }

    void SwitchPosition()
    {
        // Vaihda huoneen ja ulkoisen katselupisteen välillä
        if (isAtExternalPosition)
        {
            // Siirrä pelaaja takaisin huoneeseen
            transform.position = roomPosition.position;
            transform.rotation = roomPosition.rotation;
        }
        else
        {
            // Siirrä pelaaja ulkoiseen katselupisteeseen
            transform.position = externalPosition.position;
            transform.rotation = externalPosition.rotation;
        }

        // Vaihda lippu seuraavaa sijaintia varten
        isAtExternalPosition = !isAtExternalPosition;
    }
}
