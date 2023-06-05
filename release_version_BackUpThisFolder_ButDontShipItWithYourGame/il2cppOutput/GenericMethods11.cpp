﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif




template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct VirtualFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct GenericInterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>>
struct CacheDict_2_t3592A9BE3B1E812BCE8A13D901156E74C707DBB7;
// System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo>
struct CacheDict_2_tB695739D50653F4D4C3DA03BCF07CC868196FB15;
// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression/ExtensionInfo>
struct ConditionalWeakTable_2_t0F3FDA57EE333DF8B8C1F3FB944E4E19C5DDCFC7;
// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Int32>
struct Dictionary_2_tBB429CD29D6F765D173E93E0F638CBF47BCE9A69;
// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>
struct Dictionary_2_tEF46B4EA472A35123947A8DF4F68C3E8A5F0C4FD;
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>
struct Entry_t9D1CED9843692C309A6349215FAAE61B435EE663;
// System.Linq.Expressions.Expression`1<System.Object>
struct Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7;
// System.Collections.Generic.HashSet`1<System.Object>
struct HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885;
// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>
struct HashSet_1_t068F5201D923072F46716204841D21328FE6218D;
// System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>
struct IEnumerable_1_t49C2F44B68A54E1D7F267F9CC6AEAE8497D42901;
// System.Collections.Generic.IEqualityComparer`1<System.Linq.Expressions.ParameterExpression>
struct IEqualityComparer_1_t3950A1C72D0704C9A5D08F255CB6BE1525EDC4A9;
// MessagePack.Formatters.IMessagePackFormatter`1<System.UInt64>
struct IMessagePackFormatter_1_t128A15812AE77F617A63545162C489662E906706;
// MessagePack.Formatters.IMessagePackFormatter`1<UnityEngine.Vector2>
struct IMessagePackFormatter_1_t65B772B410FCE46422F3E74B0BDD1F15E2A6A0EA;
// MessagePack.Formatters.IMessagePackFormatter`1<UnityEngine.Vector2Int>
struct IMessagePackFormatter_1_t0858F86C75F8D92F197C6B8984E795744054D9FE;
// MessagePack.Formatters.IMessagePackFormatter`1<UnityEngine.Vector3>
struct IMessagePackFormatter_1_t0E6C1F1533B8309C0FEE4E79D3F321B4C37A2116;
// MessagePack.Formatters.IMessagePackFormatter`1<UnityEngine.Vector3Int>
struct IMessagePackFormatter_1_tE484B7F1A724815AACFA0E83964968DB6013B143;
// MessagePack.Formatters.IMessagePackFormatter`1<UnityEngine.Vector4>
struct IMessagePackFormatter_1_t7A9DCCE5B7D5FA0A0FB3F9E7FC1D68FB0C745C94;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>
struct List_1_t1A058A09EDF187502B71E068C526B964CEA1283F;
// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>
struct Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26;
// System.Collections.Generic.Stack`1<System.Object>
struct Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5;
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>
struct ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895;
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>
struct ThreadsafeTypeKeyHashTable_1_tD771140ED7BEB08400856CC4B87D3C6DEAB00FF5;
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<MessagePack.Formatters.IMessagePackFormatter>[]
struct EntryU5BU5D_t650837FCE8FC2EC5D0E117B8E0C4060C36761B42;
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>[]
struct EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076;
// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>[]
struct HashSet_1U5BU5D_tFCEF942AC56CEEEEF243A16089184E53958046D4;
// System.Collections.Generic.HashSet`1/Slot<System.Linq.Expressions.ParameterExpression>[]
struct SlotU5BU5D_t5B6221310D92CD3EFED99B5A41997E4715E36338;
// MessagePack.IFormatterResolver[]
struct IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2;
// MessagePack.Formatters.IMessagePackFormatter[]
struct IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.Linq.Expressions.ParameterExpression[]
struct ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// System.Linq.Expressions.Expression
struct Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785;
// MessagePack.IFormatterResolver
struct IFormatterResolver_t5B1CEFC5BBDC456659A223091F4E9614C7CEF1AB;
// MessagePack.Formatters.IMessagePackFormatter
struct IMessagePackFormatter_tC4FD069CC4D8E672A8031809041681C267EB29E1;
// System.Linq.Expressions.Interpreter.InterpretedFrame
struct InterpretedFrame_tF030A9AC78837B1C2F9CD54B43F7A04D85A8D92D;
// System.Linq.Expressions.LambdaExpression
struct LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// System.Linq.Expressions.ParameterExpression
struct ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// MessagePack.Resolvers.CompositeResolver/CachingResolver
struct CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F;
// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor
struct QuoteVisitor_tAF65D5FC6B193B07A3D795C928F4E02DA518529F;
// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter
struct ExpressionQuoter_t3D5F35B2980800F7F947EBC0819D867CF5AAD536;

IL2CPP_EXTERN_C RuntimeClass* HashSet_1_t068F5201D923072F46716204841D21328FE6218D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t1A058A09EDF187502B71E068C526B964CEA1283F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* Array_Empty_TisParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110_m3FAA05D641D29AC345AA871116A0E236549DB39F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Add_m9B1803FBD20D89F056AD75F1B6B0E1F5D5CF4F69_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_mC6742D4B2D1A12A042DB56C25EEF951C4BAC992B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m72E70DE20E4D4DFE86D505EDD3DBEA47E50449A5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m90AEF23AAC38CF4A308B9996EEF66C89F96E6A4D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Pop_mBE2B08F95D18382A9C64D99E1065B899EB75E6E5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Stack_1_Push_m7705C6FDAFECD165E7E24091F066CB47F323E6CE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var;

struct EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076;
struct IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2;
struct IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.EmptyArray`1<System.Object>
struct EmptyArray_1_tDF0DD7256B115243AA6BD5558417387A734240EE  : public RuntimeObject
{
};

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>
struct Entry_t9D1CED9843692C309A6349215FAAE61B435EE663  : public RuntimeObject
{
	// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<TValue> MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry::Next
	Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* ___Next_0;
	// System.Type MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry::<Key>k__BackingField
	Type_t* ___U3CKeyU3Ek__BackingField_1;
	// TValue MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry::<Value>k__BackingField
	RuntimeObject* ___U3CValueU3Ek__BackingField_2;
	// System.Int32 MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry::<Hash>k__BackingField
	int32_t ___U3CHashU3Ek__BackingField_3;
};

// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>
struct HashSet_1_t068F5201D923072F46716204841D21328FE6218D  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_t5B6221310D92CD3EFED99B5A41997E4715E36338* ____slots_8;
	// System.Int32 System.Collections.Generic.HashSet`1::_count
	int32_t ____count_9;
	// System.Int32 System.Collections.Generic.HashSet`1::_lastIndex
	int32_t ____lastIndex_10;
	// System.Int32 System.Collections.Generic.HashSet`1::_freeList
	int32_t ____freeList_11;
	// System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::_comparer
	RuntimeObject* ____comparer_12;
	// System.Int32 System.Collections.Generic.HashSet`1::_version
	int32_t ____version_13;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.HashSet`1::_siInfo
	SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37* ____siInfo_14;
};

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>
struct List_1_t1A058A09EDF187502B71E068C526B964CEA1283F  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>
struct Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26  : public RuntimeObject
{
	// T[] System.Collections.Generic.Stack`1::_array
	HashSet_1U5BU5D_tFCEF942AC56CEEEEF243A16089184E53958046D4* ____array_0;
	// System.Int32 System.Collections.Generic.Stack`1::_size
	int32_t ____size_1;
	// System.Int32 System.Collections.Generic.Stack`1::_version
	int32_t ____version_2;
	// System.Object System.Collections.Generic.Stack`1::_syncRoot
	RuntimeObject* ____syncRoot_3;
};

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>
struct ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895  : public RuntimeObject
{
	// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<TValue>[] MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::buckets
	EntryU5BU5D_t650837FCE8FC2EC5D0E117B8E0C4060C36761B42* ___buckets_0;
	// System.Int32 MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::size
	int32_t ___size_1;
	// System.Object MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::writerLock
	RuntimeObject* ___writerLock_2;
	// System.Single MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::loadFactor
	float ___loadFactor_3;
};

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>
struct ThreadsafeTypeKeyHashTable_1_tD771140ED7BEB08400856CC4B87D3C6DEAB00FF5  : public RuntimeObject
{
	// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<TValue>[] MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::buckets
	EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076* ___buckets_0;
	// System.Int32 MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::size
	int32_t ___size_1;
	// System.Object MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::writerLock
	RuntimeObject* ___writerLock_2;
	// System.Single MessagePack.Internal.ThreadsafeTypeKeyHashTable`1::loadFactor
	float ___loadFactor_3;
};

// System.Linq.Expressions.Expression
struct Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785  : public RuntimeObject
{
};

// System.Linq.Expressions.ExpressionVisitor
struct ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590  : public RuntimeObject
{
};

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// MessagePack.Resolvers.CompositeResolver/CachingResolver
struct CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F  : public RuntimeObject
{
	// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter> MessagePack.Resolvers.CompositeResolver/CachingResolver::formattersCache
	ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* ___formattersCache_0;
	// MessagePack.Formatters.IMessagePackFormatter[] MessagePack.Resolvers.CompositeResolver/CachingResolver::subFormatters
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* ___subFormatters_1;
	// MessagePack.IFormatterResolver[] MessagePack.Resolvers.CompositeResolver/CachingResolver::subResolvers
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* ___subResolvers_2;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.Linq.Expressions.LambdaExpression
struct LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E  : public Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785
{
	// System.Linq.Expressions.Expression System.Linq.Expressions.LambdaExpression::_body
	Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* ____body_3;
};

// System.Linq.Expressions.ParameterExpression
struct ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110  : public Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785
{
	// System.String System.Linq.Expressions.ParameterExpression::<Name>k__BackingField
	String_t* ___U3CNameU3Ek__BackingField_3;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor
struct QuoteVisitor_tAF65D5FC6B193B07A3D795C928F4E02DA518529F  : public ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590
{
	// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Int32> System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::_definedParameters
	Dictionary_2_tBB429CD29D6F765D173E93E0F638CBF47BCE9A69* ____definedParameters_0;
	// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression> System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::_hoistedParameters
	HashSet_1_t068F5201D923072F46716204841D21328FE6218D* ____hoistedParameters_1;
};

// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter
struct ExpressionQuoter_t3D5F35B2980800F7F947EBC0819D867CF5AAD536  : public ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590
{
	// System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_variables
	Dictionary_2_tEF46B4EA472A35123947A8DF4F68C3E8A5F0C4FD* ____variables_0;
	// System.Linq.Expressions.Interpreter.InterpretedFrame System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_frame
	InterpretedFrame_tF030A9AC78837B1C2F9CD54B43F7A04D85A8D92D* ____frame_1;
	// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>> System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::_shadowedVars
	Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26* ____shadowedVars_2;
};

// System.Linq.Expressions.Expression`1<System.Object>
struct Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7  : public LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E
{
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// System.Type
struct Type_t  : public MemberInfo_t
{
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl_8;
};

// System.EmptyArray`1<System.Object>
struct EmptyArray_1_tDF0DD7256B115243AA6BD5558417387A734240EE_StaticFields
{
	// T[] System.EmptyArray`1::Value
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___Value_0;
};

// System.EmptyArray`1<System.Object>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>

// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>

// System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Object>

// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>
struct List_1_t1A058A09EDF187502B71E068C526B964CEA1283F_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>

// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>

// System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>

// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>

// System.Linq.Expressions.Expression
struct Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785_StaticFields
{
	// System.Dynamic.Utils.CacheDict`2<System.Type,System.Reflection.MethodInfo> System.Linq.Expressions.Expression::s_lambdaDelegateCache
	CacheDict_2_tB695739D50653F4D4C3DA03BCF07CC868196FB15* ___s_lambdaDelegateCache_0;
	// System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`5<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> modreq(System.Runtime.CompilerServices.IsVolatile) System.Linq.Expressions.Expression::s_lambdaFactories
	CacheDict_2_t3592A9BE3B1E812BCE8A13D901156E74C707DBB7* ___s_lambdaFactories_1;
	// System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression/ExtensionInfo> System.Linq.Expressions.Expression::s_legacyCtorSupportTable
	ConditionalWeakTable_2_t0F3FDA57EE333DF8B8C1F3FB944E4E19C5DDCFC7* ___s_legacyCtorSupportTable_2;
};

// System.Linq.Expressions.Expression

// System.Linq.Expressions.ExpressionVisitor

// System.Linq.Expressions.ExpressionVisitor

// System.Reflection.MemberInfo

// System.Reflection.MemberInfo

// System.ValueType

// System.ValueType

// MessagePack.Resolvers.CompositeResolver/CachingResolver

// MessagePack.Resolvers.CompositeResolver/CachingResolver

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// System.Linq.Expressions.LambdaExpression

// System.Linq.Expressions.LambdaExpression

// System.Linq.Expressions.ParameterExpression

// System.Linq.Expressions.ParameterExpression

// System.Void

// System.Void

// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor

// System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor

// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter

// System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter

// System.Linq.Expressions.Expression`1<System.Object>

// System.Linq.Expressions.Expression`1<System.Object>

// System.RuntimeTypeHandle

// System.RuntimeTypeHandle

// System.Type
struct Type_t_StaticFields
{
	// System.Reflection.Binder modreq(System.Runtime.CompilerServices.IsVolatile) System.Type::s_defaultBinder
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder_0;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_1;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes_2;
	// System.Object System.Type::Missing
	RuntimeObject* ___Missing_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase_6;
};

// System.Type
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// MessagePack.Formatters.IMessagePackFormatter[]
struct IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// MessagePack.IFormatterResolver[]
struct IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Linq.Expressions.ParameterExpression[]
struct ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C  : public RuntimeArray
{
	ALIGN_FIELD (8) ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* m_Items[1];

	inline ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// MessagePack.Internal.ThreadsafeTypeKeyHashTable`1/Entry<System.Object>[]
struct EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076  : public RuntimeArray
{
	ALIGN_FIELD (8) Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* m_Items[1];

	inline Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Entry_t9D1CED9843692C309A6349215FAAE61B435EE663** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Entry_t9D1CED9843692C309A6349215FAAE61B435EE663** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Boolean MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>::TryGetValue(System.Type,TValue&)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool ThreadsafeTypeKeyHashTable_1_TryGetValue_mBDAA61635F80A7FFF5A9FC9CB8B94AAE7CFF126A_gshared_inline (ThreadsafeTypeKeyHashTable_1_tD771140ED7BEB08400856CC4B87D3C6DEAB00FF5* __this, Type_t* ___0_key, RuntimeObject** ___1_value, const RuntimeMethod* method) ;
// System.Boolean MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<System.Object>::TryAdd(System.Type,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ThreadsafeTypeKeyHashTable_1_TryAdd_m2D0705619D3BF5C1E977C3BE8FBDE31C656DA25C_gshared (ThreadsafeTypeKeyHashTable_1_tD771140ED7BEB08400856CC4B87D3C6DEAB00FF5* __this, Type_t* ___0_key, RuntimeObject* ___1_value, const RuntimeMethod* method) ;
// T[] System.Array::Empty<System.Object>()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* Array_Empty_TisRuntimeObject_mFB8A63D602BB6974D31E20300D9EB89C6FE7C278_gshared_inline (const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___0_capacity, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.HashSet`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.HashSet`1<System.Object>::Add(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Stack`1<System.Object>::Push(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stack_1_Push_m709DD11BC1291A905814182CF9A367DE7399A778_gshared (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// T System.Collections.Generic.Stack`1<System.Object>::Pop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Stack_1_Pop_m2AFF69249659372F07EE25817DBCAFE74E1CF778_gshared (Stack_1_tAD790A47551563636908E21E4F08C54C0C323EB5* __this, const RuntimeMethod* method) ;

// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57 (RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ___0_handle, const RuntimeMethod* method) ;
// System.Boolean MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>::TryGetValue(System.Type,TValue&)
inline bool ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* __this, Type_t* ___0_key, RuntimeObject** ___1_value, const RuntimeMethod* method)
{
	return ((  bool (*) (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*, Type_t*, RuntimeObject**, const RuntimeMethod*))ThreadsafeTypeKeyHashTable_1_TryGetValue_mBDAA61635F80A7FFF5A9FC9CB8B94AAE7CFF126A_gshared_inline)(__this, ___0_key, ___1_value, method);
}
// System.Boolean MessagePack.Internal.ThreadsafeTypeKeyHashTable`1<MessagePack.Formatters.IMessagePackFormatter>::TryAdd(System.Type,TValue)
inline bool ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* __this, Type_t* ___0_key, RuntimeObject* ___1_value, const RuntimeMethod* method)
{
	return ((  bool (*) (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*, Type_t*, RuntimeObject*, const RuntimeMethod*))ThreadsafeTypeKeyHashTable_1_TryAdd_m2D0705619D3BF5C1E977C3BE8FBDE31C656DA25C_gshared)(__this, ___0_key, ___1_value, method);
}
// T[] System.Array::Empty<System.Linq.Expressions.ParameterExpression>()
inline ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* Array_Empty_TisParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110_m3FAA05D641D29AC345AA871116A0E236549DB39F_inline (const RuntimeMethod* method)
{
	return ((  ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* (*) (const RuntimeMethod*))Array_Empty_TisRuntimeObject_mFB8A63D602BB6974D31E20300D9EB89C6FE7C278_gshared_inline)(method);
}
// System.Void System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>::.ctor(System.Int32)
inline void List_1__ctor_m90AEF23AAC38CF4A308B9996EEF66C89F96E6A4D (List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* __this, int32_t ___0_capacity, const RuntimeMethod* method)
{
	((  void (*) (List_1_t1A058A09EDF187502B71E068C526B964CEA1283F*, int32_t, const RuntimeMethod*))List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared)(__this, ___0_capacity, method);
}
// System.Void System.Collections.Generic.List`1<System.Linq.Expressions.ParameterExpression>::Add(T)
inline void List_1_Add_m72E70DE20E4D4DFE86D505EDD3DBEA47E50449A5_inline (List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* __this, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t1A058A09EDF187502B71E068C526B964CEA1283F*, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
// System.Void System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::PushParameters(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void QuoteVisitor_PushParameters_mC0368A13FEDC063CA6CE13884A8167B788434D76 (QuoteVisitor_tAF65D5FC6B193B07A3D795C928F4E02DA518529F* __this, RuntimeObject* ___0_parameters, const RuntimeMethod* method) ;
// System.Void System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::PopParameters(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void QuoteVisitor_PopParameters_m608713B0CFFB54DA0D4D0CF12F3E693A873D3FF9 (QuoteVisitor_tAF65D5FC6B193B07A3D795C928F4E02DA518529F* __this, RuntimeObject* ___0_parameters, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>::.ctor()
inline void HashSet_1__ctor_mC6742D4B2D1A12A042DB56C25EEF951C4BAC992B (HashSet_1_t068F5201D923072F46716204841D21328FE6218D* __this, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_t068F5201D923072F46716204841D21328FE6218D*, const RuntimeMethod*))HashSet_1__ctor_m9132EE1422BAA45E44B7FFF495F378790D36D90E_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>::Add(T)
inline bool HashSet_1_Add_m9B1803FBD20D89F056AD75F1B6B0E1F5D5CF4F69 (HashSet_1_t068F5201D923072F46716204841D21328FE6218D* __this, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t068F5201D923072F46716204841D21328FE6218D*, ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110*, const RuntimeMethod*))HashSet_1_Add_m2CD7657B3459B61DD4BBA47024AC71F7D319658B_gshared)(__this, ___0_item, method);
}
// System.Void System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>::Push(T)
inline void Stack_1_Push_m7705C6FDAFECD165E7E24091F066CB47F323E6CE (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26* __this, HashSet_1_t068F5201D923072F46716204841D21328FE6218D* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26*, HashSet_1_t068F5201D923072F46716204841D21328FE6218D*, const RuntimeMethod*))Stack_1_Push_m709DD11BC1291A905814182CF9A367DE7399A778_gshared)(__this, ___0_item, method);
}
// System.Linq.Expressions.Expression System.Linq.Expressions.LambdaExpression::get_Body()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* LambdaExpression_get_Body_m161E156442547AE8A6837C5AE065BD93345451DE_inline (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.Stack`1<System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression>>::Pop()
inline HashSet_1_t068F5201D923072F46716204841D21328FE6218D* Stack_1_Pop_mBE2B08F95D18382A9C64D99E1065B899EB75E6E5 (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26* __this, const RuntimeMethod* method)
{
	return ((  HashSet_1_t068F5201D923072F46716204841D21328FE6218D* (*) (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26*, const RuntimeMethod*))Stack_1_Pop_m2AFF69249659372F07EE25817DBCAFE74E1CF778_gshared)(__this, method);
}
// System.Boolean System.Type::op_Equality(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_op_Equality_m99930A0E44E420A685FABA60E60BA1CC5FA0EBDC (Type_t* ___0_left, Type_t* ___1_right, const RuntimeMethod* method) ;
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<System.UInt64>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisUInt64_t8F12534CC8FC4B5860F2A2CD1EE79D322E7A41AF_m71E256643B430513AC3AB5C116940F93691CF0E5_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<UnityEngine.Vector2>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m8429A254FB19063BAB65CA4D985EFC21A6BF5177_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<UnityEngine.Vector2Int>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisVector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A_m924E2197AE71FEB5FB498C2AAF03777161D1CC5C_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<UnityEngine.Vector3>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_m9C9180BBB412A9DDDFB8C948D54091A9146FD54E_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<UnityEngine.Vector3Int>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisVector3Int_t65CB06F557251D18A37BD71F3655BA836A357376_m8DAA61C47C7FC69D5A2363E753E989184777C7A0_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// MessagePack.Formatters.IMessagePackFormatter`1<T> MessagePack.Resolvers.CompositeResolver/CachingResolver::GetFormatter<UnityEngine.Vector4>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CachingResolver_GetFormatter_TisVector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_mD83426B8F08B0803AB1FFBA4084554522A9E20C0_gshared (CachingResolver_tB085ADC654B6785769BCF1707E2EAB8BBF86071F* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* V_4 = NULL;
	{
		// if (!this.formattersCache.TryGetValue(typeof(T), out IMessagePackFormatter? formatter))
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_0 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_1, NULL);
		NullCheck(L_0);
		bool L_3;
		L_3 = ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_inline(L_0, L_2, (&V_0), ThreadsafeTypeKeyHashTable_1_TryGetValue_m40A362A462D52FC776150F830CA353AA68B00CAC_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0079;
		}
	}
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_4 = (IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1*)__this->___subFormatters_1;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0038;
	}

IL_0024:
	{
		// foreach (var subFormatter in this.subFormatters)
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		// if (subFormatter is IMessagePackFormatter<T>)
		RuntimeObject* L_9 = V_3;
		if (!((RuntimeObject*)IsInst((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1))))
		{
			goto IL_0034;
		}
	}
	{
		// formatter = subFormatter;
		RuntimeObject* L_10 = V_3;
		V_0 = L_10;
		// goto CACHE;
		goto IL_0062;
	}

IL_0034:
	{
		int32_t L_11 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0038:
	{
		// foreach (var subFormatter in this.subFormatters)
		int32_t L_12 = V_2;
		IMessagePackFormatterU5BU5D_tA8CC7BB547D433C326AF80C2C9042387BC699EF1* L_13 = V_1;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_0024;
		}
	}
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_14 = (IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2*)__this->___subResolvers_2;
		V_4 = L_14;
		V_2 = 0;
		goto IL_005b;
	}

IL_004a:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_15 = V_4;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		// formatter = resolver.GetFormatter<T>();
		NullCheck(L_18);
		RuntimeObject* L_19;
		L_19 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 2), L_18);
		V_0 = (RuntimeObject*)L_19;
		// if (formatter != null)
		RuntimeObject* L_20 = V_0;
		if (L_20)
		{
			goto IL_0062;
		}
	}
	{
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_005b:
	{
		// foreach (IFormatterResolver resolver in this.subResolvers)
		int32_t L_22 = V_2;
		IFormatterResolverU5BU5D_t58D5B46802F0A7D68262F00AD169EF64B91A5BB2* L_23 = V_4;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_004a;
		}
	}

IL_0062:
	{
		// this.formattersCache.TryAdd(typeof(T), formatter);
		ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895* L_24 = (ThreadsafeTypeKeyHashTable_1_t35FF329824EB6A286901F0CA0EDE4D834B313895*)__this->___formattersCache_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m6062B81682F79A4D6DF2640692EE6D9987858C57(L_25, NULL);
		RuntimeObject* L_27 = V_0;
		NullCheck(L_24);
		bool L_28;
		L_28 = ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F(L_24, L_26, L_27, ThreadsafeTypeKeyHashTable_1_TryAdd_m5828A725214D6FF2BEA08BBA19F47B98DD33366F_RuntimeMethod_var);
	}

IL_0079:
	{
		// return (IMessagePackFormatter<T>?)formatter;
		RuntimeObject* L_29 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// System.Linq.Expressions.Expression System.Linq.Expressions.Interpreter.LightCompiler/QuoteVisitor::VisitLambda<System.Object>(System.Linq.Expressions.Expression`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* QuoteVisitor_VisitLambda_TisRuntimeObject_m8546CE5243FDDEFA3C7483FEB44BF91BD8F91DAF_gshared (QuoteVisitor_tAF65D5FC6B193B07A3D795C928F4E02DA518529F* __this, Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* ___0_node, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110_m3FAA05D641D29AC345AA871116A0E236549DB39F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m72E70DE20E4D4DFE86D505EDD3DBEA47E50449A5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m90AEF23AAC38CF4A308B9996EEF66C89F96E6A4D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t1A058A09EDF187502B71E068C526B964CEA1283F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	int32_t V_1 = 0;
	List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* V_2 = NULL;
	int32_t V_3 = 0;
	{
		ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* L_0;
		L_0 = Array_Empty_TisParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110_m3FAA05D641D29AC345AA871116A0E236549DB39F_inline(Array_Empty_TisParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110_m3FAA05D641D29AC345AA871116A0E236549DB39F_RuntimeMethod_var);
		V_0 = (RuntimeObject*)L_0;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_1 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_1);
		int32_t L_2;
		L_2 = VirtualFuncInvoker0< int32_t >::Invoke(17 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_1);
		V_1 = L_2;
		int32_t L_3 = V_1;
		if ((((int32_t)L_3) <= ((int32_t)0)))
		{
			goto IL_0033;
		}
	}
	{
		int32_t L_4 = V_1;
		List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* L_5 = (List_1_t1A058A09EDF187502B71E068C526B964CEA1283F*)il2cpp_codegen_object_new(List_1_t1A058A09EDF187502B71E068C526B964CEA1283F_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		List_1__ctor_m90AEF23AAC38CF4A308B9996EEF66C89F96E6A4D(L_5, L_4, List_1__ctor_m90AEF23AAC38CF4A308B9996EEF66C89F96E6A4D_RuntimeMethod_var);
		V_2 = L_5;
		V_3 = 0;
		goto IL_002d;
	}

IL_001c:
	{
		List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* L_6 = V_2;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_7 = ___0_node;
		int32_t L_8 = V_3;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_7);
		ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* L_9;
		L_9 = VirtualFuncInvoker1< ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110*, int32_t >::Invoke(16 /* System.Linq.Expressions.ParameterExpression System.Linq.Expressions.LambdaExpression::GetParameter(System.Int32) */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_7, L_8);
		NullCheck(L_6);
		List_1_Add_m72E70DE20E4D4DFE86D505EDD3DBEA47E50449A5_inline(L_6, L_9, List_1_Add_m72E70DE20E4D4DFE86D505EDD3DBEA47E50449A5_RuntimeMethod_var);
		int32_t L_10 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_002d:
	{
		int32_t L_11 = V_3;
		int32_t L_12 = V_1;
		if ((((int32_t)L_11) < ((int32_t)L_12)))
		{
			goto IL_001c;
		}
	}
	{
		List_1_t1A058A09EDF187502B71E068C526B964CEA1283F* L_13 = V_2;
		V_0 = (RuntimeObject*)L_13;
	}

IL_0033:
	{
		RuntimeObject* L_14 = V_0;
		QuoteVisitor_PushParameters_mC0368A13FEDC063CA6CE13884A8167B788434D76(__this, L_14, NULL);
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_15 = ___0_node;
		NullCheck((ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590*)__this);
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_16;
		L_16 = ((  Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* (*) (ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590*, Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))((ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590*)__this, L_15, il2cpp_rgctx_method(method->rgctx_data, 0));
		RuntimeObject* L_17 = V_0;
		QuoteVisitor_PopParameters_m608713B0CFFB54DA0D4D0CF12F3E693A873D3FF9(__this, L_17, NULL);
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_18 = ___0_node;
		return (Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*)L_18;
	}
}
// System.Linq.Expressions.Expression System.Linq.Expressions.Interpreter.QuoteInstruction/ExpressionQuoter::VisitLambda<System.Object>(System.Linq.Expressions.Expression`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* ExpressionQuoter_VisitLambda_TisRuntimeObject_m367D8F5D10D80B4A1A34D42A5339BAF95A51FE5E_gshared (ExpressionQuoter_t3D5F35B2980800F7F947EBC0819D867CF5AAD536* __this, Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* ___0_node, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_m9B1803FBD20D89F056AD75F1B6B0E1F5D5CF4F69_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_mC6742D4B2D1A12A042DB56C25EEF951C4BAC992B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_t068F5201D923072F46716204841D21328FE6218D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Pop_mBE2B08F95D18382A9C64D99E1065B899EB75E6E5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stack_1_Push_m7705C6FDAFECD165E7E24091F066CB47F323E6CE_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* V_0 = NULL;
	HashSet_1_t068F5201D923072F46716204841D21328FE6218D* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_0 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_0);
		int32_t L_1;
		L_1 = VirtualFuncInvoker0< int32_t >::Invoke(17 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_0);
		if ((((int32_t)L_1) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		HashSet_1_t068F5201D923072F46716204841D21328FE6218D* L_2 = (HashSet_1_t068F5201D923072F46716204841D21328FE6218D*)il2cpp_codegen_object_new(HashSet_1_t068F5201D923072F46716204841D21328FE6218D_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		HashSet_1__ctor_mC6742D4B2D1A12A042DB56C25EEF951C4BAC992B(L_2, HashSet_1__ctor_mC6742D4B2D1A12A042DB56C25EEF951C4BAC992B_RuntimeMethod_var);
		V_1 = L_2;
		V_2 = 0;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_3 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_3);
		int32_t L_4;
		L_4 = VirtualFuncInvoker0< int32_t >::Invoke(17 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_3);
		V_3 = L_4;
		goto IL_002c;
	}

IL_001a:
	{
		HashSet_1_t068F5201D923072F46716204841D21328FE6218D* L_5 = V_1;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_6 = ___0_node;
		int32_t L_7 = V_2;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_6);
		ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110* L_8;
		L_8 = VirtualFuncInvoker1< ParameterExpression_tE8D3A1137422F75D256CBB200EDC82820F240110*, int32_t >::Invoke(16 /* System.Linq.Expressions.ParameterExpression System.Linq.Expressions.LambdaExpression::GetParameter(System.Int32) */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_6, L_7);
		NullCheck(L_5);
		bool L_9;
		L_9 = HashSet_1_Add_m9B1803FBD20D89F056AD75F1B6B0E1F5D5CF4F69(L_5, L_8, HashSet_1_Add_m9B1803FBD20D89F056AD75F1B6B0E1F5D5CF4F69_RuntimeMethod_var);
		int32_t L_10 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_002c:
	{
		int32_t L_11 = V_2;
		int32_t L_12 = V_3;
		if ((((int32_t)L_11) < ((int32_t)L_12)))
		{
			goto IL_001a;
		}
	}
	{
		Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26* L_13 = (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26*)__this->____shadowedVars_2;
		HashSet_1_t068F5201D923072F46716204841D21328FE6218D* L_14 = V_1;
		NullCheck(L_13);
		Stack_1_Push_m7705C6FDAFECD165E7E24091F066CB47F323E6CE(L_13, L_14, Stack_1_Push_m7705C6FDAFECD165E7E24091F066CB47F323E6CE_RuntimeMethod_var);
	}

IL_003c:
	{
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_15 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_15);
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_16;
		L_16 = LambdaExpression_get_Body_m161E156442547AE8A6837C5AE065BD93345451DE_inline((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_15, NULL);
		NullCheck((ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590*)__this);
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_17;
		L_17 = VirtualFuncInvoker1< Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*, Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* >::Invoke(4 /* System.Linq.Expressions.Expression System.Linq.Expressions.ExpressionVisitor::Visit(System.Linq.Expressions.Expression) */, (ExpressionVisitor_tD26583FF464068F23017BC372C81133A62C5A590*)__this, L_16);
		V_0 = L_17;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_18 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_18);
		int32_t L_19;
		L_19 = VirtualFuncInvoker0< int32_t >::Invoke(17 /* System.Int32 System.Linq.Expressions.LambdaExpression::get_ParameterCount() */, (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_18);
		if ((((int32_t)L_19) <= ((int32_t)0)))
		{
			goto IL_005e;
		}
	}
	{
		Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26* L_20 = (Stack_1_tC4810ACEE7FD00840B5CB4333A83E2E1553CAD26*)__this->____shadowedVars_2;
		NullCheck(L_20);
		HashSet_1_t068F5201D923072F46716204841D21328FE6218D* L_21;
		L_21 = Stack_1_Pop_mBE2B08F95D18382A9C64D99E1065B899EB75E6E5(L_20, Stack_1_Pop_mBE2B08F95D18382A9C64D99E1065B899EB75E6E5_RuntimeMethod_var);
	}

IL_005e:
	{
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_22 = V_0;
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_23 = ___0_node;
		NullCheck((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_23);
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_24;
		L_24 = LambdaExpression_get_Body_m161E156442547AE8A6837C5AE065BD93345451DE_inline((LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E*)L_23, NULL);
		if ((!(((RuntimeObject*)(Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*)L_22) == ((RuntimeObject*)(Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*)L_24))))
		{
			goto IL_0069;
		}
	}
	{
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_25 = ___0_node;
		return (Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*)L_25;
	}

IL_0069:
	{
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_26 = ___0_node;
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_27 = V_0;
		NullCheck(L_26);
		Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7* L_28;
		L_28 = VirtualFuncInvoker2< Expression_1_t63D438A2F366BA0B43CCDBBFCE66D131C313A7D7*, Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*, ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C* >::Invoke(18 /* System.Linq.Expressions.Expression`1<TDelegate> System.Linq.Expressions.Expression`1<System.Object>::Rewrite(System.Linq.Expressions.Expression,System.Linq.Expressions.ParameterExpression[]) */, L_26, L_27, (ParameterExpressionU5BU5D_tA217A6969CA4383EF6D3C43B8EB0989358ABE72C*)NULL);
		return (Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785*)L_28;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* LambdaExpression_get_Body_m161E156442547AE8A6837C5AE065BD93345451DE_inline (LambdaExpression_tD26FB6AEAD01B2EBB668CDEAFAAFA4948697300E* __this, const RuntimeMethod* method) 
{
	{
		Expression_t70AA908ECBD33E94249BF235E4EBB0F831AD8785* L_0 = __this->____body_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool ThreadsafeTypeKeyHashTable_1_TryGetValue_mBDAA61635F80A7FFF5A9FC9CB8B94AAE7CFF126A_gshared_inline (ThreadsafeTypeKeyHashTable_1_tD771140ED7BEB08400856CC4B87D3C6DEAB00FF5* __this, Type_t* ___0_key, RuntimeObject** ___1_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076* V_0 = NULL;
	int32_t V_1 = 0;
	Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* V_2 = NULL;
	{
		// Entry[] table = this.buckets;
		EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076* L_0 = (EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076*)__this->___buckets_0;
		V_0 = L_0;
		// var hash = key.GetHashCode();
		Type_t* L_1 = ___0_key;
		NullCheck((RuntimeObject*)L_1);
		int32_t L_2;
		L_2 = VirtualFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, (RuntimeObject*)L_1);
		V_1 = L_2;
		// Entry? entry = table[hash & table.Length - 1];
		EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076* L_3 = V_0;
		int32_t L_4 = V_1;
		EntryU5BU5D_tFF3444192A10A99D05439A2077A3C00BC04F4076* L_5 = V_0;
		NullCheck(L_5);
		NullCheck(L_3);
		int32_t L_6 = ((int32_t)(L_4&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_5)->max_length)), 1))));
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_7 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_2 = L_7;
		goto IL_003d;
	}

IL_001a:
	{
		// if (entry.Key == key)
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_8 = V_2;
		NullCheck(L_8);
		Type_t* L_9;
		L_9 = ((  Type_t* (*) (Entry_t9D1CED9843692C309A6349215FAAE61B435EE663*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		Type_t* L_10 = ___0_key;
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		bool L_11;
		L_11 = Type_op_Equality_m99930A0E44E420A685FABA60E60BA1CC5FA0EBDC(L_9, L_10, NULL);
		if (!L_11)
		{
			goto IL_0036;
		}
	}
	{
		// value = entry.Value;
		RuntimeObject** L_12 = ___1_value;
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_13 = V_2;
		NullCheck(L_13);
		RuntimeObject* L_14;
		L_14 = ((  RuntimeObject* (*) (Entry_t9D1CED9843692C309A6349215FAAE61B435EE663*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_13, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		*(RuntimeObject**)L_12 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_12, (void*)L_14);
		// return true;
		return (bool)1;
	}

IL_0036:
	{
		// entry = entry.Next;
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_15 = V_2;
		NullCheck(L_15);
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_16 = (Entry_t9D1CED9843692C309A6349215FAAE61B435EE663*)L_15->___Next_0;
		V_2 = L_16;
	}

IL_003d:
	{
		// while (entry != null)
		Entry_t9D1CED9843692C309A6349215FAAE61B435EE663* L_17 = V_2;
		if (L_17)
		{
			goto IL_001a;
		}
	}
	{
		// value = default(TValue);
		RuntimeObject** L_18 = ___1_value;
		il2cpp_codegen_initobj(L_18, sizeof(RuntimeObject*));
		// return false;
		return (bool)0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* Array_Empty_TisRuntimeObject_mFB8A63D602BB6974D31E20300D9EB89C6FE7C278_gshared_inline (const RuntimeMethod* method) 
{
	{
		il2cpp_codegen_runtime_class_init_inline(il2cpp_rgctx_data(method->rgctx_data, 0));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_0 = ((EmptyArray_1_tDF0DD7256B115243AA6BD5558417387A734240EE_StaticFields*)il2cpp_codegen_static_fields_for(il2cpp_rgctx_data(method->rgctx_data, 0)))->___Value_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___0_item;
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
