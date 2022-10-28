using System.Collections;
using UnityEngine;

public class VFXManager : SingletonMonobehaviour<VFXManager>
{

    private WaitForSeconds twoSeconds;
    [SerializeField] private GameObject reapingPrefab = null;
    [SerializeField] private GameObject leavesFallingPrefab = null;
    [SerializeField] private GameObject choppingPrefab = null;
    [SerializeField] private GameObject pineFallingPrefab = null;
    [SerializeField] private GameObject stoneShatteringPrefab = null;


    protected override void Awake()
    {
        base.Awake();

        twoSeconds = new WaitForSeconds(2f);

    }

    private void OnDisable()
    {
        EventHandler.HarvestActionEffectEvent -= displayHarvestActionEffect;
    }

    private void OnEnable()
    {
        EventHandler.HarvestActionEffectEvent += displayHarvestActionEffect;
    }

    private IEnumerator DisableHarvestActionEffect(GameObject effectGameObject, WaitForSeconds secondsToWait)
    {
        yield return secondsToWait;
        effectGameObject.SetActive(false);
    }

    private void displayHarvestActionEffect(Vector3 effectPosition, HarvestActionEffect harvestActionEffect)
    {
        switch (harvestActionEffect)
        {

            case HarvestActionEffect.reaping:
                GameObject reaping = PoolManager.Instance.ReuseObject(reapingPrefab, effectPosition, Quaternion.identity);
                reaping.SetActive(true);
                StartCoroutine(DisableHarvestActionEffect(reaping, twoSeconds));
                break;

            case HarvestActionEffect.deciduousLeavesFalling:
                GameObject leaveFalling = PoolManager.Instance.ReuseObject(leavesFallingPrefab, effectPosition, Quaternion.identity);
                leaveFalling.SetActive(true);
                StartCoroutine(DisableHarvestActionEffect(leaveFalling, twoSeconds));
                break;

            case HarvestActionEffect.choppingTreeTrunk:
                GameObject choppingTreeTrunk = PoolManager.Instance.ReuseObject(choppingPrefab, effectPosition, Quaternion.identity);
                choppingTreeTrunk.SetActive(true);
                StartCoroutine(DisableHarvestActionEffect(choppingTreeTrunk, twoSeconds));
                break;

            case HarvestActionEffect.pineConesFalling:
                GameObject pineConesFalling = PoolManager.Instance.ReuseObject(pineFallingPrefab, effectPosition, Quaternion.identity);
                pineConesFalling.SetActive(true);
                StartCoroutine(DisableHarvestActionEffect(pineConesFalling, twoSeconds));
                break;

            case HarvestActionEffect.breakingStone:
                GameObject breakingStone = PoolManager.Instance.ReuseObject(stoneShatteringPrefab, effectPosition, Quaternion.identity);
                breakingStone.SetActive(true);
                StartCoroutine(DisableHarvestActionEffect(breakingStone, twoSeconds));
                break;

            case HarvestActionEffect.none:
                break;

            default:
                break;
        }
    }


}