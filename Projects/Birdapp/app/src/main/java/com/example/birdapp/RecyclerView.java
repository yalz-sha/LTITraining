package com.example.birdapp;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;

import com.firebase.ui.database.FirebaseRecyclerOptions;
import com.google.firebase.database.FirebaseDatabase;

public class RecyclerView extends AppCompatActivity {

    private androidx.recyclerview.widget.RecyclerView recyclerView;
    private PostAdapter adapter;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_recycler_view);
        




      recyclerView=findViewById(R.id.rview);
      recyclerView.setLayoutManager(new LinearLayoutManager(this));

        FirebaseRecyclerOptions<Post> options =
                new FirebaseRecyclerOptions.Builder<Post>()
                        .setQuery(FirebaseDatabase.getInstance().getReference().child("Post"), Post.class)
                        .build();
        adapter=new PostAdapter(RecyclerView.this,options);
        recyclerView.setAdapter(adapter);

      /*  adapter.setOnItemClickListener(new PostAdapter.onItemClick() {
            @Override
            public void onIClick(DataSnapshot dataSnapshot, int position) {
                String key=dataSnapshot.getKey();
                Toast.makeText(getApplicationContext(),"Clicker",Toast.LENGTH_SHORT).show();
            }
        });*/




    }

    @Override
    protected void onStart() {
        super.onStart();
        adapter.startListening();
    }

    @Override
    protected void onStop() {
        super.onStop();
        adapter.stopListening();
    }




}
