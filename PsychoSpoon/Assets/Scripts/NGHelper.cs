using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NGHelper : MonoBehaviour
{

    public io.newgrounds.core ngio_core;

    // Start is called before the first frame update
    void Start()
    {
        ngio_core.onReady(() => {
                ngio_core.checkLogin((bool logged_in) => {
                    if(logged_in)
                    {
                        onLoggedIn();
                    }
                    else
                    {
                        requestLogin();
                    }
                });
        });
    }

    void onLoggedIn()
    {
        //Do something
    }

    void requestLogin()
    {
        ngio_core.requestLogin(onLoggedIn, onLoginFailed, onLoginCancelled);
    }

    void onLoginFailed()
    {
        io.newgrounds.objects.error error = ngio_core.login_error;
    }

    void onLoginCancelled()
    {
        //Do something
    }

    public void unlockMedal(int medal_id)
    {
        io.newgrounds.components.Medal.unlock medal_unlock = new io.newgrounds.components.Medal.unlock();

        medal_unlock.id = medal_id;

        medal_unlock.callWith(ngio_core);
        Debug.Log("Medal unlocked");
    }
}
