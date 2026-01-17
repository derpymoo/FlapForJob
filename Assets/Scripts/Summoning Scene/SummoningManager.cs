using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SummoningManager : MonoBehaviour
{
    [Header("Egg")]
    public Animator eggAnimator; // Animator for the egg
    public Image eggImage;       // UI Image for egg

    [Header("Result")]
    public Image animalImage;    // UI Image for animal

    [Header("UI")]
    public Text rarityText;
    public Text animalNameText;
    public Button returnButton;
    public GameObject textBackground;

    [Header("Animal Pools")]
    public Sprite[] rareAnimals;
    public Sprite[] epicAnimals;
    public Sprite[] legendaryAnimals;

    [Header("Animation Timing")]
    public float eggAnimationLength = 1.5f; // Set this to your actual animation duration

    private string rolledRarity;

    void Start()
    {
        // Hide animal and button and text button at start
        animalImage.gameObject.SetActive(false);
        returnButton.gameObject.SetActive(false);
        textBackground.SetActive(false);

        // Start the summon process
        StartCoroutine(SummonFlow());
    }

    IEnumerator SummonFlow()
    {
        RollRarity();          // Decide the egg rarity
        PlayEggAnimation();    // Play the correct egg animation

        // Wait for the animation to finish
        yield return new WaitForSeconds(eggAnimationLength);

        // Show the animal and text
        ShowResult();
    }

    void RollRarity()
    {
        int roll = Random.Range(1, 101); // 1 to 100

        if (roll <= 80) rolledRarity = "RARE";
        else if (roll <= 98) rolledRarity = "EPIC";
        else rolledRarity = "LEGENDARY";
    }

    void PlayEggAnimation()
    {
        // Play the egg animation from the start
        if (rolledRarity == "RARE")
            eggAnimator.Play("BlueEggHatching", 0, 0f);
        else if (rolledRarity == "EPIC")
            eggAnimator.Play("EpicEggHatching", 0, 0f);
        else
            eggAnimator.Play("GoldenEggHatching", 0, 0f);
    }

    public void ShowResult()
    {
        // Pick a random animal from the correct rarity
        Sprite chosen = null;
        if (rolledRarity == "RARE" && rareAnimals.Length > 0)
            chosen = rareAnimals[Random.Range(0, rareAnimals.Length)];
        else if (rolledRarity == "EPIC" && epicAnimals.Length > 0)
            chosen = epicAnimals[Random.Range(0, epicAnimals.Length)];
        else if (rolledRarity == "LEGENDARY" && legendaryAnimals.Length > 0)
            chosen = legendaryAnimals[Random.Range(0, legendaryAnimals.Length)];

        if (chosen != null)
        {
            // Show the animal
            animalImage.sprite = chosen;
            animalImage.gameObject.SetActive(true);

            // Set rarity and name text, and background to visible
            textBackground.SetActive(true);
            rarityText.text = rolledRarity;
            animalNameText.text = chosen.name;

            // Ensure text is visible and on top
            rarityText.gameObject.SetActive(true);
            animalNameText.gameObject.SetActive(true);
            rarityText.transform.SetAsLastSibling();
            animalNameText.transform.SetAsLastSibling();

            // Show return button
            returnButton.gameObject.SetActive(true);
        }
    }


    public void ReturnToGacha()
    {
        SceneManager.LoadScene("GachaScene");
    }
}
