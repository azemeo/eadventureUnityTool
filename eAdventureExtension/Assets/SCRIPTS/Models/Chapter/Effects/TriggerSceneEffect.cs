﻿using UnityEngine;
using System.Collections;

/**
 * An effect that triggers a scene
 */
public class TriggerSceneEffect : AbstractEffect, HasTargetId
{
    /**
     * Id of the cutscene to be played
     */
    private string targetSceneId;

    /**
     * X position of the player in the scene.
     */
    private int x;

    /**
     * Y position of the player in the scene.
     */
    private int y;

    /**
     * Creates a new TriggerSceneEffect
     * 
     * @param targetSceneId
     *            the id of the cutscene to be triggered
     * @param x
     *            X position of the player in the new scene
     * @param y
     *            Y position of the player in the new scene
     */
    public TriggerSceneEffect(string targetSceneId, int x, int y):base()
    {
        this.targetSceneId = targetSceneId;
        this.x = x;
        this.y = y;
    }

    public override EffectType getType()
    {

        return EffectType.TRIGGER_SCENE;
    }

    /**
     * Returns the targetSceneId
     * 
     * @return string containing the targetSceneId
     */
    public string getTargetId()
    {

        return targetSceneId;
    }

    /**
     * Sets the new targetSceneId
     * 
     * @param targetSceneId
     *            New targetSceneId
     */
    public void setTargetId(string targetSceneId)
    {

        this.targetSceneId = targetSceneId;
    }

    /**
     * Returns the X destiny position of the player.
     * 
     * @return X destiny position
     */
    public int getX()
    {

        return x;
    }

    /**
     * Returns the Y destiny position of the player.
     * 
     * @return Y destiny position
     */
    public int getY()
    {

        return y;
    }

    /**
     * Sets the new insertion position for the player
     * 
     * @param x
     *            X coord of the position
     * @param y
     *            Y coord of the position
     */
    public void setPosition(int x, int y)
    {

        this.x = x;
        this.y = y;
    }
    /*
    @Override
    public Object clone() throws CloneNotSupportedException
    {

        TriggerSceneEffect tse = (TriggerSceneEffect) super.clone( );
        tse.targetSceneId = ( targetSceneId != null ? new string(targetSceneId ) : null );
        tse.x = x;
        tse.y = y;
        return tse;
    }*/
}
