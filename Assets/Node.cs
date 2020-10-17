using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
	OTHER,
	SPELL,
	UNIT,
	ENCHANT,
	BUILDING
}

public enum NodeSchool
{
	NECRO,
	LITH,
	DYNA,
	VITA,
	PHYTO,
	ANIM
}

[CreateAssetMenu(menuName = "Custom Node Code/New Node", order = 1)]
public class Node : ScriptableObject
{
	private bool locked = true;

	public string Name;
	public string Description;
	public Sprite Icon;
	public NodeType Type;
	public NodeSchool[] Schools;
	public List<Node> subNodes;
	public List<Node> parentNodes;

	public Node(List<Node> parentNodes)
	{
		this.parentNodes = parentNodes;
	}

	public bool isLocked()
	{
		return locked;
	}

	public void unlock()
	{
		
	}
}
