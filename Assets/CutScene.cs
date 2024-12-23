using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private string _sceneName;

    private Animator _animator;

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("CutScene");
        StartCoroutine(enumerator());
    }

    private IEnumerator enumerator()
    {
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(_sceneName);
    }
}
