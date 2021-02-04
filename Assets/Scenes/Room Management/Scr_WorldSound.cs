using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_WorldSound : MonoBehaviour
{
    // Start is called before the first frame update
    public bool TurnedOn = true;

    
    public bool[] UseSoundList = new bool[5];
    public List<AudioClip> SoundList0 = new List<AudioClip>();
    
    public List<AudioClip> SoundList1 = new List<AudioClip>();
    
    public List<AudioClip> SoundList2 = new List<AudioClip>();
    
    public List<AudioClip> SoundList3 = new List<AudioClip>();
    
    public List<AudioClip> SoundList4 = new List<AudioClip>();
    byte CurrentList = 7;

    public AudioSource Source;
    void Start()
    {
        Source = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    {
        if ((!Source.isPlaying) && TurnedOn)
        {
            //if the audio is not playing and it wants to play.
            //first lets see if there are multiple choices of lists.
            if (MultipleActiveLists())
            {
                //Multiple lists are active
                List<int> ActiveLists = CurrentlyActiveLists();
                if (ActiveLists.Contains((int)CurrentList))
                {
                    ActiveLists.Remove((int)CurrentList);
                }
                while (ActiveLists.Count > 1)
                {
                    ActiveLists.RemoveAt(Random.Range(0, ActiveLists.Count - 1));
                }
                CurrentList = (byte)ActiveLists[0];
                int ActiveList = ActiveLists[0];
                AudioClip InputClip = CurrentSoundList((byte)ActiveList)[Random.Range(0, CurrentSoundList((byte)ActiveList).Count - 1)];
                Source.clip = InputClip;
                Source.Play();

            } 
            else
            {
                //only one list is active
                int ActiveList = CurrentlyActiveLists()[0];
                AudioClip InputClip = CurrentSoundList((byte)ActiveList)[Random.Range(0, CurrentSoundList((byte)ActiveList).Count-1)];
                Source.clip = InputClip;
                Source.Play();
            }
           
        }
    }

    bool MultipleActiveLists()
    {
        //finds if the number of active lists is > 1
        byte ActiveLists = 0;
        for (int i = 0; i < 5; i++)
        {
            if (UseSoundList[i])
            {
                ActiveLists++;
            }
        }
        if (ActiveLists > 1)
        {
            return true;
        }
        return false;
    }

    List<int> CurrentlyActiveLists()
    {
        List<int> Numbers = new List<int>();
        //when returns all active lists
        for (int i = 0; i < 5; i++)
        {
            if (UseSoundList[i])
            {
                Numbers.Add(i);
            }
        }
        return Numbers;
    }

    List<AudioClip> CurrentSoundList(byte List)
    {
        switch (List)
        {
            case 0:
                return SoundList0;
            case 1:
                return SoundList1;
            case 2:
                return SoundList2;
            case 3:
                return SoundList3;
            case 4:
                return SoundList4;
            default:
                return null;
        }
        
    }
}
