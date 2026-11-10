using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    private bool _is_chase;
    /*
    private void Start(){
        _is_chase=true;
    }*/
    private void Update(){
        if(_is_chase){
            transform.position=Vector3.MoveTowards(transform.position,_playerTransform.position,_speed*Time.deltaTime);
        }
    }
    public void StartChase(){
        _is_chase=true;
    }
    public void StopChase(){
        _is_chase=false;
    }
}
