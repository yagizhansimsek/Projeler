package com.example.yazlab;

import androidx.fragment.app.FragmentActivity;

import android.content.ActivityNotFoundException;
import android.content.Intent;
import android.location.Address;
import android.location.Geocoder;
import android.net.Uri;
import android.os.Bundle;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;

import java.io.IOException;
import java.util.List;
import java.util.Locale;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    MarkerOptions markerOptions;
    MarkerOptions markerOptions2;
    String name1;
    String name2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_maps);
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);
        Intent intent = getIntent();
         name1 = intent.getStringExtra("name1");
         name2 = intent.getStringExtra("name2");
    }

    /**
     * Manipulates the map once available.
     * This callback is triggered when the map is ready to be used.
     * This is where we can add markers or lines, add listeners or move the camera. In this case,
     * we just add a marker near Sydney, Australia.
     * If Google Play services is not installed on the device, the user will be prompted to install
     * it inside the SupportMapFragment. This method will only be triggered once the user has
     * installed Google Play services and returned to the app.
     */
    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;


        Geocoder geocoder = new Geocoder(MapsActivity.this,Locale.getDefault());
        try {
            List adreslist= geocoder.getFromLocationName(name1,1);
            Address adres = (Address) adreslist.get(0);
            LatLng ilk_Adres = new LatLng(adres.getLatitude(),adres.getLongitude());
            markerOptions = new MarkerOptions().position(ilk_Adres).title(adres.getLocality());
            mMap.addMarker(markerOptions);
            mMap.moveCamera(CameraUpdateFactory.newLatLngZoom(ilk_Adres,16));



        } catch (IOException e) {
            e.printStackTrace();
            System.out.println(e.getLocalizedMessage());
        }
        geocoder = new Geocoder(MapsActivity.this, Locale.getDefault());
        try {
            List adreslist= geocoder.getFromLocationName(name2,1);
            Address adres = (Address) adreslist.get(0);
            LatLng ikinci_Adres = new LatLng(adres.getLatitude(),adres.getLongitude());
            markerOptions2 = new MarkerOptions().position(ikinci_Adres).title(adres.getLocality());
            mMap.addMarker(markerOptions2);
            mMap.moveCamera(CameraUpdateFactory.newLatLngZoom(ikinci_Adres,1));

        } catch (IOException e) {
            e.printStackTrace();
            System.out.println(e.getLocalizedMessage());
        }
        try {
            Uri uri = Uri.parse("https://www.google.co.in/maps/dir/"+name1+"/"+name2);
            Intent intent = new Intent(Intent.ACTION_VIEW,uri);
            intent.setPackage("com.google.android.apps.maps");
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            startActivity(intent);
        }
        catch (ActivityNotFoundException e) {

            Uri uri = Uri.parse("https://play.google.com/store/details?id=com.google.android.apps.maps");
            Intent intent = new Intent(Intent.ACTION_VIEW,uri);
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            startActivity(intent);
        }
    }
}