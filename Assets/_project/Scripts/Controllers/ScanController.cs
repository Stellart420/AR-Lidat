using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ScanController : Singleton<ScanController>
{
    [SerializeField] private ARPlaneManager _planeManager;
    [SerializeField] private ScanMesh _scanMesh;
    [SerializeField] private ARMeshManager _arMeshManager;

    private bool _isScanning;

    protected override void Awake()
    {
        base.Awake();
        _arMeshManager.enabled = false;
        //_planeManager. enabled = false;
    }

    public void ScanStart()
    {
        _scanMesh.Click();
        //if (!_isScanning)
        //{
        //    _arMeshManager.enabled = true; // �������� ARMeshManager ��� ������������ �����

        //    XRMeshSubsystem arMeshSubsystem = (XRMeshSubsystem)_arMeshManager.subsystem; // �������� ������ � ���������� ARKitMeshSubsystem

        //    if (arMeshSubsystem != null)
        //    {
        //        arMeshSubsystem.Start();
        //        _isScanning = true;
        //    }
        //}
    }

    public void ScanStop()
    {
        _scanMesh.Click();
        //if (_isScanning)
        //{
        //    _arMeshManager.enabled = false; // ��������� ARMeshManager

        //    XRMeshSubsystem arMeshSubsystem = (XRMeshSubsystem)_arMeshManager.subsystem;

        //    if (arMeshSubsystem != null)
        //    {
        //        arMeshSubsystem.Stop();
        //        _isScanning = false;
        //    }
        //}
    }
}
