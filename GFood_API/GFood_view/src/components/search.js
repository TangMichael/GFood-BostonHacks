import React, { Component } from "react";


export const Search = props => (
  <div className="ui input">
    <input onChange={props.handleChange} type="text" placeholder="Search..." />
    <button className="ui button" onClick={props.search}>
      Search
        </button>
  </div>
);

