//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using mpl;
//using mplExtension;
//using UnityEngine.UI;
//using Google.Protobuf;
//using System;

//namespace MergeTown
//{
//    public class UIMail : LuaUIBaseCrossScene
//    {
//        public LoopVerticalScrollRect systemScroll;
//        public LoopScrollDataSource<MailItem> systemData = new LoopScrollDataSource<MailItem>();
//        public LoopScrollDataSource<MailItem> systemDataRefresh = new LoopScrollDataSource<MailItem>();
//        //public LoopVerticalScrollRect friendScroll;
//        //public LoopScrollDataSource<MailItem> friendData = new LoopScrollDataSource<MailItem>();
//        #region 父类 方法集
//        public mplExtension.Injection[] Injections;
//        public override object[] AfterAwakeInitLua()
//        {
//            object[] vs = new object[1];
//            vs[0] = "UIMail";
//            systemScroll.RefreshCells();
//            return vs;
//        }
//        public override string GetLuaPath()
//        {
//            return GetLuaRelativePath("ui.UIMail");
//        }

//        public override mplExtension.Injection[] RegistObj()
//        {
//            return Injections;
//        }
//        public override MonoBehaviour GetThis()
//        {
//            return this;
//        }
//        public override void Awake()
//        {
//            base.Awake();
//            mpl.UIAnimationControl.Get<UIAnimationControl>(gameObject).SetAnimation(new UIScaleAnimation());
//            transform.Find("Background/CloseBtn").GetComponent<Button>().onClick.AddListener(ClosePanel);
//        }
//        public override void MplOnOpen(object obj = null, params string[] param)
//        {

//            if (obj != null)
//            {
//                initData((RGetMailList)obj);
//            }
//            base.MplOnOpen(gameObject, param);
//            AudioManager.PlaySound(AudioDefine.Sfx_OpenPopWindow);
//        }
//        public int GetMailCount()
//        {
//            return systemData.TotalCount;
//        }
//        //public bool haveDelete()
//        //{
//        //    if (systemData.TotalCount <= 0)
//        //    {
//        //        return false;
//        //    }
//        //    else
//        //    {
//        //        int Count = 0;
//        //        for (int i = 0; i < systemData.TotalCount; i++)
//        //        {//已领取 或 已读无附件
//        //            if ((systemData[i].Data.Mailstate == 2 && systemData[i].Data.props.Count > 0) || (systemData[i].Data.Mailstate == 1 && systemData[i].Data.props.Count <= 0))
//        //            {
//        //                return true;
//        //            }
//        //        }
//        //        return false;
//        //    }
//        //}
//        public void LoadRedPoint()
//        {
//            if (systemData.TotalCount <= 0)
//            {
//                //红点消失
//                UIEventMessage.Instance.Call(MessageType.Red_Point_CloseMail);
//            }
//            else
//            {
//                for (int i = 0; i < systemData.TotalCount; i++)
//                {
//                    if (systemData[i].Data.Mailstate == 0)
//                    {
//                        //红点打开
//                        UIEventMessage.Instance.Call(MessageType.Red_Point_OpenMail);
//                        return;
//                    }
//                }
//                //红点消失
//                UIEventMessage.Instance.Call(MessageType.Red_Point_CloseMail);
//            }
//        }
//        public bool haveReward()
//        {
//            if (systemData.TotalCount <= 0)
//            {
//                return false;
//            }
//            else
//            {
//                for (int i = 0; i < systemData.TotalCount; i++)
//                {//已领取 或 已读无附件
//                    if (systemData[i].Data.Mailstate != 2 && systemData[i].Data.props.Count > 0)
//                    {
//                        return true;
//                    }
//                }
//                return false;
//            }

//        }
//        public bool canCollection()
//        {
//            if (systemData.TotalCount <= 0)
//            {
//                return false;
//            }
//            else
//            {
//                for (int i = 0; i < systemData.TotalCount; i++)
//                {
//                    if (systemData[i].Data.props.Count > 0 && systemData[i].Data.Mailstate != 2)
//                    {
//                        return true;
//                    }
//                }
//                return false;
//            }
//        }
//        public void ClosePanel()
//        {
//            UIAnimatorCtrl aniCtrl = GetComponentInChildren<UIAnimatorCtrl>();
//            if (aniCtrl != null)
//            {
//                aniCtrl.Close(() =>
//                {
//                    MonoBehaviourUIMgr.Instance.Close(typeof(UIMail));
//                });
//            }
//            else
//            {
//                MonoBehaviourUIMgr.Instance.Close(typeof(UIMail));
//            }
//            AudioManager.PlaySound(AudioDefine.Sfx_ClosePopWindow);

//        }
//        #endregion

//        /// <summary>
//        /// 系统/好友 是否有邮件  true为空
//        /// </summary>
//        public bool IsNullSystem()
//        {
//            return systemData.TotalCount <= 0 ? true : false;
//        }
//        //public bool IsNullFriend()
//        //{
//        //return friendData.TotalCount <= 0 ? true : false;
//        //}
//        public void Refresh()
//        {
//            systemScroll.RefreshCells();
//            //friendScroll.RefreshCells();
//        }
//        /// <summary>
//        /// 一键删除
//        /// </summary>
//        public void DeleteAll(int type, Action<bool> callback)
//        {
//            if (PlayerMgr.Instance.isLogin)
//            {
//                NetMail.MailAllDelete(type, (rObj) =>
//                 {
//                     if (rObj != null && rObj.Code == WebSocketControl.SuccessCode)
//                     {
//                         clearAll(type);
//                         callback?.Invoke(true);
//                         //MonoBehaviourUIMgr.Instance.Open(typeof(Toast), null, false, false, LanguageUtils.GetInfoById(LanguageKeyDefine.k_210000028));
//                     }
//                     else
//                     {
//                         callback?.Invoke(false);
//                     }
//                 });
//            }
//            else
//            {
//                string content = LuaUtils.GetContentByLanguageId(LanguageKeyDefine.k_220000022);
//                Toast.Show(content);
//                MonoBehaviourUIMgr.Instance.Close(typeof(UIMail));
//            }
//        }
//        private void clearAll(int eMailType)
//        {
//            List<MailItem> remove = new List<MailItem>();
//            if (eMailType == (int)EMailType.System)
//            {
//                for (int i = 0; i < systemData.TotalCount; i++)
//                {//已领取 或 已读无附件
//                    if (systemData[i].Data.Mailstate == 2 || (systemData[i].Data.Mailstate == 1 && systemData[i].Data.props.Count <= 0))
//                    {
//                        remove.Add(systemData[i].Data);
//                    }
//                    else
//                    {
//                        systemDataRefresh.AddItem(systemData[i].Data);
//                    }
//                }
//                systemData.Clear();
//                for (int i = 0; i < systemDataRefresh.TotalCount; i++)
//                {
//                    systemData.AddItem(systemDataRefresh[i].Data);
//                }
//                systemDataRefresh.Clear();
//                systemData.Bind(systemScroll);
//                //for (int i = 0; i < remove.Count; i++)
//                //{
//                //    systemData.DeleteItem(remove[i]);
//                //}
//                //systemData.Bind(systemScroll);
//                //systemScroll.
//                //systemScroll.RefillCells();
//            }
//            //else if (eMailType == (int)EMailType.Friend)
//            //{
//            //    for (int i = 0; i < friendData.TotalCount; i++)
//            //    {
//            //        if (friendData[i].Data.Mailstate == 2)
//            //        {
//            //            remove.Add(friendData[i].Data);
//            //        }
//            //    }
//            //    for (int i = 0; i < remove.Count; i++)
//            //    {
//            //        friendData.DeleteItem(remove[i]);
//            //    }
//            //    friendScroll.RefreshCells();
//            //}
//        }

//        /// <summary>
//        /// obtionAll
//        /// </summary>
//        /// <param name="eMailType"></param>
//        private void obtionAll(int eMailType)
//        {
//            if (eMailType == (int)EMailType.System)
//            {
//                for (int i = 0; i < systemData.TotalCount; i++)
//                {
//                    if (systemData[i].Data.Mailstate != 2)
//                    {
//                        for (int n = 0; n < systemData[i].Data.props.Count; n++)
//                        {
//                            TotalUtils.ShowBubble(systemData[i].Data.props[n].Id, systemData[i].Data.props[n].Count);
//                            //RewardManager.Instance.SendReward(systemData[i].Data.props[n].Id, systemData[i].Data.props[n].Count, RewardDestination.Home);
//                        }
//                        systemData[i].Data.Mailstate = 2;
//                    }
//                }
//                systemScroll.RefreshCells();
//            }
//            //else if (eMailType == (int)EMailType.Friend)
//            //{
//            //    for (int i = 0; i < friendData.TotalCount; i++)
//            //    {
//            //        if (friendData[i].Data.Mailstate != 2)
//            //        {
//            //            for (int n = 0; n < friendData[i].Data.props.Count; n++)
//            //            {
//            //                RewardManager.Instance.SendReward(friendData[i].Data.props[n].Id, friendData[i].Data.props[n].Count, RewardDestination.Home);
//            //            }
//            //            friendData[i].Data.Mailstate = 2;
//            //        }
//            //    }
//            //    friendScroll.RefreshCells();
//            //}
//        }

//        /// <summary>
//        /// 一键领取奖励
//        /// </summary>
//        public void CollectAll(int type, Action<bool> callback)
//        {
//            if (PlayerMgr.Instance.isLogin)
//            {
//                NetMail.MailAllRead(type, (rObj) =>
//                {
//                    if (rObj != null && rObj.Code == WebSocketControl.SuccessCode)
//                    {
//                        obtionAll(type);
//                        //MonoBehaviourUIMgr.Instance.Open(typeof(Toast), null, false, false, false, LanguageUtils.GetInfoById(LanguageKeyDefine.k_220000016));
//                        callback?.Invoke(true);
//                    }
//                    else
//                    {
//                        callback?.Invoke(false);
//                    }
//                });
//                string str = LuaUtils.GetContentByLanguageId(120000103);//奖励已放到家园
//                UIFlowMessage.Show(str);
//            }
//            else
//            {
//                string content = LuaUtils.GetContentByLanguageId(LanguageKeyDefine.k_220000022);
//                Toast.Show(content);
//                MonoBehaviourUIMgr.Instance.Close(typeof(UIMail));
//            }
//        }

//        /// <summary>
//        /// 领取通过id
//        /// </summary>
//        /// <param name="id"></param>
//        public void Collect(long id, Action<bool> callback)
//        {
//            if (PlayerMgr.Instance.isLogin)
//            {
//                NetMail.MailGetAttachment(id, (rObj) =>
//                {
//                    if (rObj != null && rObj.Code == WebSocketControl.SuccessCode)
//                    {
//                        callback?.Invoke(true);
//                        //MonoBehaviourUIMgr.Instance.Open(typeof(Toast), null, false, false, false, LanguageUtils.GetInfoById(LanguageKeyDefine.k_220000016));
//                    }
//                    else
//                    {
//                        callback?.Invoke(false);
//                        List<MailItem> remove = new List<MailItem>();
//                        for (int i = 0; i < systemData.TotalCount; i++)
//                        {//已领取 或 已读无附件
//                            if (systemData[i].Data.Id == id)
//                            {
//                                remove.Add(systemData[i].Data);
//                            }
//                        }
//                        for (int i = 0; i < remove.Count; i++)
//                        {
//                            systemData.DeleteItem(remove[i]);
//                        }
//                        systemData.Bind(systemScroll);
//                        //systemScroll.
//                        systemScroll.RefillCells();
//                    }
//                });
//            }
//            else
//            {
//                string content = LuaUtils.GetContentByLanguageId(LanguageKeyDefine.k_220000022);
//                Toast.Show(content);
//                MonoBehaviourUIMgr.Instance.Close(typeof(UIMail));
//            }
//        }

//        /// <summary>
//        /// 初始化邮件数据
//        /// </summary>
//        /// <param name="id"></param>
//        private void initData(RGetMailList paramObj)
//        {
//            systemData.Clear();
//            //friendData.Clear();
//            for (int i = 0; i < paramObj.Mails.Count; i++)
//            {
//                MailItem itemData = new MailItem();
//                itemData.Id = paramObj.Mails[i].Mailid;
//                itemData.Type = paramObj.Mails[i].Mailtype;
//                itemData.ConfigId = paramObj.Mails[i].ConfigId;
//                itemData.Time = paramObj.Mails[i].SendTime;
//                itemData.EndTime = paramObj.Mails[i].ExpireTime;
//                itemData.Mailstate = paramObj.Mails[i].Mailstate;
//                for (int n = 0; n < paramObj.Mails[i].ExtraData.Count; n++)
//                {
//                    mailkv prop = new mailkv();
//                    prop.k = paramObj.Mails[i].ExtraData[n].Key;
//                    prop.v = paramObj.Mails[i].ExtraData[n].Value;
//                    itemData.param.Add(prop);
//                }
//                for (int n = 0; n < paramObj.Mails[i].Attachment.Count; n++)
//                {
//                    Prop prop = new Prop();
//                    prop.Id = paramObj.Mails[i].Attachment[n].Id;
//                    prop.Count = paramObj.Mails[i].Attachment[n].Count;
//                    itemData.props.Add(prop);
//                }
//                //if (itemData.Type == (int)EMailType.System)
//                //{
//                Debug.Log(itemData.ToString());
//                systemData.AddItem(itemData);
//                //}
//                //else if (itemData.Type == (int)EMailType.Friend)
//                //{
//                //    friendData.AddItem(itemData);
//                //}
//            }
//            MailComparer com = new MailComparer();
//            systemData.DataSouce.Sort(com);
//            //friendData.DataSouce.Sort(com);
//            systemData.Bind(systemScroll);
//            //friendData.Bind(friendScroll);

//        }


//        public void TrackToOne()
//        {
//            //if (systemScroll.gameObject.active == true)
//            //{
//            //    systemScroll.ScrollToCell(0, 3500);
//            //}
//            //systemScroll.transform.Find("Viewport/Content").localPosition = new Vector3(0, -1500, 0);
//        }

//    }
//}