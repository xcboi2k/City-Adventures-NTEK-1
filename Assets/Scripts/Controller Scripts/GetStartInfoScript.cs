using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStartInfoScript : MonoBehaviour
{
    private const string selectedMode = "Selected Mode";
    private const string selectedLevel = "Selected Level";

    public Text levelText;
    public Text levelDescription;

    void Start()
    {
        int getMode = PlayerPrefs.GetInt(selectedMode);
        int getLevel = PlayerPrefs. GetInt(selectedLevel);

        if(getMode == 1){
            switch (getLevel)
            {
                case 1:
                    levelText.text = "Level 1: First day of school";
                    levelDescription.text = "Good morning world! It is my first day in class. Mom took me in school once, but I forgot how to go there. Oh oh... and it's scary outside with all those cars and people. I should navigate the streets going to my school. Inhale, exhale, chin up and march forward!";
                    break;
                case 2:
                    levelText.text = "Level 2: Mom’ sick";
                    levelDescription.text = "My mom is tired and got sick, so I need to go to the hospital today to get some medicine for her. Sigh! Hope that she will be okay soon. Cheer up! I have to buy her medicines now.";
                    break;
                case 3:
                    levelText.text = "Level 3: Playing with my friend";
                    levelDescription.text = "Hello world! Mom is okay now, she's resting in home now for a while. Her fever's gone but she needs more rest. Anyway, my friend invited me to play in his house. Vámonos!";
                    break;
                case 4:
                    levelText.text = "Level 4: Borrowing my classmate's book";
                    levelDescription.text = "What a pleasant day! I had so much fun playing together yesterday. And uh, I need to go to one of my classmate's houses to borrow a book so I could study for an upcoming test at school since I was absent the other day. Studying is good, so I will study!";
                    break;
                case 5:
                    levelText.text = "Level 5: Event at school";
                    levelDescription.text = "I'm glad that I managed to borrow a book to read. And because of that, I passed the test! Yes, yes, yes! Thank you so much! Oh, I almost forgot there will be a basketball event today at school. My friends are participating there.";
                    break;
                default:
                    levelText.text = "Null Level ";
                    levelDescription.text = "Null Description";
                    break;
            }
        }

        if(getMode == 2){
            switch (getLevel)
            {
                case 1:
                    levelText.text = "Level 1: First day of school";
                    levelDescription.text = "Good morning world! It is my first day in class. Mom took me in school once, but I forgot how to go there. Oh oh... and it's scary outside with all those cars and people. I should navigate the streets going to my school. Inhale, exhale, chin up and march forward!";
                    break;
                case 2:
                    levelText.text = "Level 2: Playing with my friend";
                    levelDescription.text = "Hello world! I’m so excited for today! My friend invited me to play in his house. Vámonos! ";
                    break;
                case 3:
                    levelText.text = "Level 3: Borrowing my classmate's book";
                    levelDescription.text = "What a pleasant day! I had so much fun playing together yesterday. And uh, I need to go to one of my classmate's house to borrow a book so I could study for an upcoming test at school since I was absent the other day. Studying is good, so I will study!";
                    break;
                case 4:
                    levelText.text = "Level 4: Hanging out";
                    levelDescription.text = "I managed to borrow a book from my friend and because of that, I passed the tests! Yehey! As a reward, I'll be going to a coffee shop to hang out with my friends, it'll definitely be fun!";
                    break;
                case 5:
                    levelText.text = "Level 5: Reporting at the Police Station";
                    levelDescription.text = "Oh my, I'm so scared! I heard a loud noise last night at our front yard. I sure hope it's just a stray cat. I'll go to the police station and tell the police what I heard just in case!";
                    break;
                default:
                    levelText.text = "Null Level ";
                    levelDescription.text = "Null Description";
                    break;
            }
        }

        if(getMode == 3){
            switch (getLevel)
            {
                case 1:
                    levelText.text = "Level 1: Playing with my friend";
                    levelDescription.text = "Hello world! I’m so excited for today! My friend invited me to play in his house. Vámonos!";
                    break;
                case 2:
                    levelText.text = "Level 2: Study with classmate ";
                    levelDescription.text = "We had so much fun playing with my friends the other day. By the way, I have an upcoming test at school, my classmate invited me to join him at his house so we could study together because studying together makes it so much easier and fun. Study! Study! Study!";
                    break;
                case 3:
                    levelText.text = "Level 3: Visiting my sick best friend";
                    levelDescription.text = "Today I will go to the hospital to visit my best friend. He's sick and I want to be at his side and take care of him. He is always helping me out. His temperature went up from normal degree, I should go visit him at the hospital.";
                    break;
                case 4:
                    levelText.text = "Level 4: Football game";
                    levelDescription.text = "My best friend’s fever went down but he still needs to rest at home. Thankfully he'll be okay. I heard the local football team will be playing later at the stadium against another team from another city! I'm a big fan of football, I will definitely watch their game!";
                    break;
                case 5:
                    levelText.text = "Level 5: Groceries at the food market";
                    levelDescription.text = "Rise and shine! I enjoyed watching the football game with my friends. I did not expect them to be there also. Anyway, isn't this day lovely? Oh, I almost forgot, my mom asked me to go to the food market to buy some groceries. I can feel that tonight's going to be a good night because my mom will cook!";
                    break;
                default:
                    levelText.text = "Null Level ";
                    levelDescription.text = "Null Description";
                    break;
            }
        }

        if(getMode == 4){
            switch (getLevel)
            {
                case 1:
                    levelText.text = "Level 1: House of Auntie";
                    levelDescription.text = "Since it's weekends, we're going to visit my Auntie today. Her house is within the city, she makes lots of delicious foods. She's a great cook! I can't wait to eat all of them!";
                    break;
                case 2:
                    levelText.text = "Level 2: Mom's work";
                    levelDescription.text = "Good morning, everyone! How are you today? I hope all of you are doing great! Auntie's foods are delicious. Now we are going to drop off my mom to her workplace. Happy work, happy life.";
                    break;
                case 3:
                    levelText.text = "Level 3: Playing with my friend";
                    levelDescription.text = "Good day my loving life! If the car did not function well, my mom would have been late for work. Anyway, one of my friends invited me to go play in their house today. There are also few of my classmates who wants to come along! Come on, I'll navigate the road of the city to get to their house.";
                    break;
                case 4:
                    levelText.text = "Level 4: Study with classmate";
                    levelDescription.text = "We had so much fun playing with my friends the other day. By the way, I have an upcoming test at school, my classmate invited me to join him at his house so we could study together because studying together makes it so much easier and fun. Study! Study! Study!";
                    break;
                case 5:
                    levelText.text = "Level 5: Visiting my sick best friend";
                    levelDescription.text = "Today I will go to the hospital to visit my best friend. He's sick and I want to be at his side and take care of him. He is always helping me out. His temperature went up from normal degree, I should go visit him at the hospital.";
                    break;
                default:
                    levelText.text = "Null Level ";
                    levelDescription.text = "Null Description";
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
