using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    public static MouseEvent Instance;

    public Ore Wood;
    public Ore Stone;
    public Ore Mental;

    public AnimManager animManager;
    public AnimManager animManager1;
    public AnimManager animManager2;

    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Update()
    {
        MouseClick();
    }
   



    void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(Pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Tree")
                {
                    PlayerUI.Instance.dataBaseManager.TreeCount += 1;
                    Instantiate(Wood,PlayerUI.Instance.Tree_Tr);
                    animManager.TreeAnim();
                    audioSource.PlayOneShot(audioClip);
                }
                if (hit.collider.gameObject.name == "Stone")
                {
                    PlayerUI.Instance.dataBaseManager.StoneCount += 1;
                    Ore ore = Instantiate(Stone,PlayerUI.Instance.Stone_Tr);
                    animManager1.StoneAnim();
                    audioSource.PlayOneShot(audioClip);
                }
                if (hit.collider.gameObject.name == "WillSonBack")
                {
                    PlayerUI.Instance.dataBaseManager.MentalCount += 1;
                    Instantiate(Mental, PlayerUI.Instance.WillSon_Tr);
                    animManager2.PlayAnim();
                    audioSource.PlayOneShot(audioClip);
                }
                if (hit.collider.gameObject.name == "Bird(Clone)")
                {
                    Debug.Log(4);
                    Bird.Instance.DestroyBird();
                    
                }

            }
        }
    }
}


