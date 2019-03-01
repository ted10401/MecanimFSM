﻿using UnityEngine;

public abstract class BaseStateMachineBehaviour : StateMachineBehaviour
{
    private Animator m_animator;
    private AnimatorStateInfo m_stateInfo;
    private int m_layerIndex;
    private bool m_active;
    private float m_deltaTime;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_animator = animator;
        m_stateInfo = stateInfo;
        m_layerIndex = layerIndex;
        m_active = true;

        OnStateEnter();
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_animator = animator;
        m_stateInfo = stateInfo;
        m_layerIndex = layerIndex;
        m_active = false;

        OnStateExit();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_animator = animator;
        m_stateInfo = stateInfo;
        m_layerIndex = layerIndex;

        switch(m_animator.updateMode)
        {
            case AnimatorUpdateMode.AnimatePhysics:
                m_deltaTime = Time.fixedDeltaTime;
                break;
            case AnimatorUpdateMode.Normal:
                m_deltaTime = Time.deltaTime;
                break;
            case AnimatorUpdateMode.UnscaledTime:
                m_deltaTime = Time.unscaledDeltaTime;
                break;
            default:
                m_deltaTime = 0f;
                break;
        }

        OnStateUpdate();
    }

    private void OnDisable()
    {
        if(m_active)
        {
            OnStateExit();
        }
    }

    protected virtual void OnStateEnter() { }
    protected virtual void OnStateExit() { }
    protected virtual void OnStateUpdate() { }
}
