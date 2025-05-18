using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitPlatformSpawner : PlatformSpawner
{
  private Transform playerTransform;
  private List<GameObject> spawnedPlatforms = new();

  private void Start()
  {
    playerTransform = FindObjectOfType<PlayerMover>().transform;
    GeneratePlatform();
  }

  protected override void SpawnPlatform(Platform spawnPlatform)
  {
    GameObject newPlatform = Instantiate(spawnPlatform, transform.forward * spawnDirection, transform.rotation).gameObject;
    spawnedPlatforms.Add(newPlatform);
    spawnDirection += platformLength;
  }
  private void RemovePlatform()
  {
    GameObject lost = spawnedPlatforms[0];
    spawnedPlatforms.RemoveAt(0);
    Destroy(lost);
  }
  private void Update()
  {
    if (playerTransform.position.z > spawnDirection - (maxPlatformCount * platformLength))
    {
      SpawnPlatform(GetRandomPlatform());
      RemovePlatform();
    }
  }
}
