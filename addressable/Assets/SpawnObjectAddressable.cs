using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SpawnObjectAddressable : MonoBehaviour
{

    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
           AsyncOperationHandle<GameObject> asyncOperationHandle= 
            Addressables.LoadAssetAsync<GameObject>("Assets/RoofTop_SafeHouse/Prefab/Full/SafeHouse.prefab");
            asyncOperationHandle.Completed+=AsyncOperationHandle_completed;

        }
    }

    private void AsyncOperationHandle_completed(AsyncOperationHandle<GameObject> asyncOperationHandle){
        if (asyncOperationHandle.Status==AsyncOperationStatus.Succeeded){
            Instantiate(asyncOperationHandle.Result);

        }
        else{
            Debug.Log("failed to load");
        }
    }
}