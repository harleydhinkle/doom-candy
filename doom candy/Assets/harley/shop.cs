using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shop : MonoBehaviour
{
    public gun gun;
    public bashballbat bat;
    public int add;
    public int addrange;
    public int addbashballbat;
    public int maxdamige;
    public int maxdamigebashbballbat;
    public int maxrange;
    public player_movment player;
    public int change;
    public int gundamigepriceprice;
    public int price2;
    public int price3;
    public int change2;
    public int change3;
    public int change4;
    public void damige_for_gun()
    {

        gun.damige += add;
        change2 = player.points -= price;
        player.points = change2;
        player.play.score2();
        gun.damige = Mathf.Clamp(gun.damige, 0, maxdamige);
        change2 = player.points -= price;
        player.points = change2;
        player.play.score2();
    }
    public void range_for_gun()
    {
        gun.range += addrange;
        gun.range = Mathf.Clamp(gun.range, 0, maxrange);
        change3 = player.points -= price2;
        player.points = change3;
        player.play.score2();
    }
    public void damige_for_bashballbat()
    {
        bat.damige += addbashballbat;
        bat.damige = Mathf.Clamp(bat.damige, 0, maxdamigebashbballbat);
        change4 = player.points -= price3;
        player.points = change4;
        player.play.score2();
    }
}
