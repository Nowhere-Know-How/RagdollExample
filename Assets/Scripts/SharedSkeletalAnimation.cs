using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedSkeletalAnimation : MonoBehaviour
{
    public GameObject m_attached;

    void Start()
    {
        TransferBones();
    }

    public void TransferBones()
    {
        Debug.Log("Transfer bones");
        
        Dictionary<string, Transform> boneMap = new Dictionary<string, Transform>();
        GetAllSkinnedMeshRenderers(ref boneMap);

        SkinnedMeshRenderer myRenderer = GetComponent<SkinnedMeshRenderer>();
        if (myRenderer.bones == null)
        {
            Invoke("TransferBones", 0.1f);
            return;
        }

        Transform[] newBones = new Transform[myRenderer.bones.Length];

        for (int i = 0; i < myRenderer.bones.Length; ++i)
        {
            if (myRenderer.bones[i] == null)
                continue;

            GameObject bone = myRenderer.bones[i].gameObject;
            if (!boneMap.TryGetValue(bone.name, out newBones[i]))
            {
                //Debug.Log("Unable to map bone \"" + bone.name + "\" to target skeleton.");
            }
        }

        myRenderer.bones = newBones;
    }

    void GetAllSkinnedMeshRenderers(ref Dictionary<string, Transform> map)
    {
        SkinnedMeshRenderer[] renderers = m_attached.GetComponentsInChildren<SkinnedMeshRenderer>();
        Dictionary<string, Transform> boneMap = new Dictionary<string, Transform>();

        foreach (SkinnedMeshRenderer smr in renderers)
        {
            foreach (Transform bone in smr.bones)
            {
                if (!boneMap.ContainsKey(bone.gameObject.name)) boneMap[bone.gameObject.name] = bone;
            }

        }

        map = boneMap;
    }
}
