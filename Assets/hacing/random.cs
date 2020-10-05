using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour
{

    string[] programs = { "int main(int argc, char **argv)",
     "int main(int argc, char **argv)",
     "	FILE *fp1, *fp2;",
      "		char select;",
      "		int key;",
      "		char plaintext;	",
      "		char ciphertext;",
      "		if((fp1 = fopen(argv[1], r))==NULL){",
      "				exit(1);",
      "		}",
      "		if((fp2 = fopen(argv[2], w))==NULL){",
      "			scanf(%c, &select);",
      "				if(select == 'e' || select == 'd'){",
      "						break;",
      "\n",
      "if(select == 'e'){",
      "		while(fscanf(fp1, %c, &plaintext)==1){",
      "			if(plaintext >= 'a' && plaintext <= 'z'){",
      "				if(plaintext + key > 'z'){",
      "			}else {",
      "		}else if(select == 'd'){",
      "\n",
      "if(ciphertext >= 'a' && ciphertext <= 'z'){",
      "		if(ciphertext - key < 'a'){",
      "			plaintext = ciphertext - key + 26;",
      "		}else{",
      "				plaintext = ciphertext - key;",
      "		}",
      "\n",
      "while(fscanf(fp1, %c, &ciphertext)==1){",
      "		if(ciphertext - key < 'a'){",
      "			plaintext = ciphertext - key + 26;",
      "		}else{",
      "			fprintf(fp2, %c, plaintext);",
      "		}",
      "}",
      "fclose(fp1);",
      "fclose(fp2);",
     "		char select", };

    string program;
    int TextSpeedTime = 0;
    string ImputCode;
    int RandomFor;
    int TextSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x <= RandomFor; x++)
        {
            TextSpeedTime++;
            if (TextSpeedTime % TextSpeed == 0)
            {
                program = program + programs[Random.Range(1, programs.Length)];
                program = program + "\n";
                this.GetComponent<Text>().text = program;
            }
        }
    }
}
