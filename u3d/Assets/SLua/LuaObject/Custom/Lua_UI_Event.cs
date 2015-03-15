﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UI_Event : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UI_Event o;
		o=new UI_Event();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDeselect(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnDeselect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrop(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrop(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnMove(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.AxisEventData a1;
			checkType(l,2,out a1);
			self.OnMove(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerClick(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerEnter(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerEnter(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerExit(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerExit(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerUp(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerUp(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScroll(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnScroll(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSelect(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSelect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnUpdateSelected(IntPtr l) {
		try{
			UI_Event self=(UI_Event)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnUpdateSelected(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Transform))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UI_Event ret=UI_Event.Get(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Transform),typeof(string))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UI_Event ret=UI_Event.Get(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.MonoBehaviour))){
				UnityEngine.MonoBehaviour a1;
				checkType(l,1,out a1);
				UI_Event ret=UI_Event.Get(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.MonoBehaviour),typeof(string))){
				UnityEngine.MonoBehaviour a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UI_Event ret=UI_Event.Get(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				UI_Event ret=UI_Event.Get(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UI_Event ret=UI_Event.Get(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_m_vecArg(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		pushValue(l,o.m_vecArg);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_m_vecArg(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		System.String[] v;
		checkType(l,2,out v);
		o.m_vecArg=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDeselect(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.BaseEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDeselect=v;
		else if(op==1) o.onDeselect+=v;
		else if(op==2) o.onDeselect-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDrag=v;
		else if(op==1) o.onDrag+=v;
		else if(op==2) o.onDrag-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrop(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDrop=v;
		else if(op==1) o.onDrop+=v;
		else if(op==2) o.onDrop-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onMove(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.AxisEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onMove=v;
		else if(op==1) o.onMove+=v;
		else if(op==2) o.onMove-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onClick=v;
		else if(op==1) o.onClick+=v;
		else if(op==2) o.onClick-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDown(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onDown=v;
		else if(op==1) o.onDown+=v;
		else if(op==2) o.onDown-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onEnter(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onEnter=v;
		else if(op==1) o.onEnter+=v;
		else if(op==2) o.onEnter-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onExit(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onExit=v;
		else if(op==1) o.onExit+=v;
		else if(op==2) o.onExit-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUp(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onUp=v;
		else if(op==1) o.onUp+=v;
		else if(op==2) o.onUp-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScroll(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.PointerEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onScroll=v;
		else if(op==1) o.onScroll+=v;
		else if(op==2) o.onScroll-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.BaseEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onSelect=v;
		else if(op==1) o.onSelect+=v;
		else if(op==2) o.onSelect-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateSelect(IntPtr l) {
		UI_Event o = (UI_Event)checkSelf(l);
		UI_Event.BaseEventDelegate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onUpdateSelect=v;
		else if(op==1) o.onUpdateSelect+=v;
		else if(op==2) o.onUpdateSelect-=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UI_Event");
		addMember(l,OnDeselect);
		addMember(l,OnDrag);
		addMember(l,OnDrop);
		addMember(l,OnMove);
		addMember(l,OnPointerClick);
		addMember(l,OnPointerDown);
		addMember(l,OnPointerEnter);
		addMember(l,OnPointerExit);
		addMember(l,OnPointerUp);
		addMember(l,OnScroll);
		addMember(l,OnSelect);
		addMember(l,OnUpdateSelected);
		addMember(l,Get_s);
		addMember(l,"m_vecArg",get_m_vecArg,set_m_vecArg,true);
		addMember(l,"onDeselect",null,set_onDeselect,true);
		addMember(l,"onDrag",null,set_onDrag,true);
		addMember(l,"onDrop",null,set_onDrop,true);
		addMember(l,"onMove",null,set_onMove,true);
		addMember(l,"onClick",null,set_onClick,true);
		addMember(l,"onDown",null,set_onDown,true);
		addMember(l,"onEnter",null,set_onEnter,true);
		addMember(l,"onExit",null,set_onExit,true);
		addMember(l,"onUp",null,set_onUp,true);
		addMember(l,"onScroll",null,set_onScroll,true);
		addMember(l,"onSelect",null,set_onSelect,true);
		addMember(l,"onUpdateSelect",null,set_onUpdateSelect,true);
		createTypeMetatable(l,constructor, typeof(UI_Event),typeof(UnityEngine.EventSystems.EventTrigger));
	}
}