using UnityEngine;
using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine.VFX;

public class SpawnProxy : MonoBehaviour, IDeclareReferencedPrefabs,IConvertGameObjectToEntity
{
    public GameObject cube;
    public int rows;
    public int cols;
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        var spawnerData = new Spawner
        {
            Prefab = conversionSystem.GetPrimaryEntity(cube),
            Erows = rows,
            Ecols = cols
        };
        dstManager.AddComponentData(entity, spawnerData);
    }

    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(cube);
    }
}
