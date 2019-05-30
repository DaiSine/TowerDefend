using UnityEngine;
using UnityEngine.Events;

public enum EventEnum       //枚举类型
{
    BuildMenu, BuildTower1, BuildTower2,ShowUpdateMenu,SellTower
}
public class TowerEvent: UnityEvent<EventEnum, GameObject>
{

}
public class Global
{
    public static Global instance = null;
    private TowerEvent myEvent = new TowerEvent();
    private GameObject enemyController = null;
    private GameObject enemyController2 = null;
    public Global()
    {

    }
    public GameObject GetEnemyController()
    {
        return enemyController;
    }
    public GameObject GetEnemyController2()
    {
        return enemyController2;
    }
    public void SetEnemeyController(GameObject ctl)
    {
        enemyController = ctl;
    }

    public void SetEnemeyController2(GameObject ctl)
    {
        enemyController2 = ctl;
    }
    public TowerEvent GetEvent()
    {
        return myEvent;
    }
    public static Global GetInstance()
    {
        if (instance == null)
        {
            instance = new Global();
        }
        return instance;
    }

}
