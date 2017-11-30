using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A089459
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,30L,221L,2201L,27769L,424757L,7639190L,157969167L,3692733181L,96293669499L,2771232779481L,87247362424120L,2982901522141490L,110057420712635526L,4358745145279372293L,BigInteger.Parse("184433423940319376323") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089459Inst Instance=new A089459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089492
{
public static readonly long[] Value={ 1552237L,4315469L,8774137L,9629197L,10048081L,10875149L,11469389L,14498741L,18280861L,18789629L,19309957L,19309981L,25386029L,27265457L,28398641L,29697029L,31298269L,31355297L,36792901L,47318969L,47487889L,55449689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089492Inst : IEnumerable<long>
{
public static readonly long[] Value=A089492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089492.Bytes);
public long this[int i]=>Value[i];

public static A089492Inst Instance=new A089492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089493
{
public static readonly long[] Value={ 196L,879L,106L,1077L,10553L,111L,1L,10583L,10022L,10071L,10331L,10128L,10210L,10132L,10278L,113L,10746L,10748L,1057L,10122L,10123L,10248L,10337L,10220L,10204L,10212L,10969L,10437L,10983L,10222L,10183L,12898L,128L,10119L,13694L,10036L,10292L,10173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089493Inst : IEnumerable<long>
{
public static readonly long[] Value=A089493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089493.Bytes);
public long this[int i]=>Value[i];

public static A089493Inst Instance=new A089493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089494
{
public static readonly long[] Value={ 10577L,1000000537869L,100000070637875L,10004697841L,10000671273L,100010097365L,990699L,1997L,19098L,10563L,109918L,10735L,101976L,1060004932996L,100059426L,90379L,10003991597L,100000089687980L,90900469909L,13097L,1005989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089494Inst : IEnumerable<long>
{
public static readonly long[] Value=A089494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089494.Bytes);
public long this[int i]=>Value[i];

public static A089494Inst Instance=new A089494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089495
{
public static readonly long[] Value={ -1L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,1L,1L,-1L,-1L,0L,1L,0L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,1L,-1L,0L,0L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089495Inst : IEnumerable<long>
{
public static readonly long[] Value=A089495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089495.Bytes);
public long this[int i]=>Value[i];

public static A089495Inst Instance=new A089495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089496
{
public static readonly long[] Value={ 0L,-1L,1L,1L,1L,1L,0L,0L,1L,-1L,-1L,1L,-1L,-1L,1L,0L,1L,1L,-1L,-1L,1L,-1L,1L,0L,0L,-1L,-1L,1L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,1L,0L,1L,-1L,1L,-1L,-1L,1L,0L,0L,1L,-1L,1L,-1L,0L,-1L,0L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,0L,-1L,1L,-1L,1L,0L,1L,0L,-1L,1L,-1L,-1L,0L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,0L,-1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089496Inst : IEnumerable<long>
{
public static readonly long[] Value=A089496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089496.Bytes);
public long this[int i]=>Value[i];

public static A089496Inst Instance=new A089496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089497
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,0L,0L,-1L,-1L,1L,1L,-1L,1L,-1L,0L,-1L,1L,1L,1L,1L,1L,-1L,0L,0L,-1L,1L,-1L,-1L,-1L,0L,1L,-1L,1L,0L,0L,1L,0L,-1L,-1L,-1L,-1L,1L,1L,0L,0L,-1L,1L,-1L,-1L,0L,1L,0L,0L,-1L,-1L,0L,0L,1L,-1L,1L,0L,0L,1L,1L,-1L,-1L,0L,-1L,0L,-1L,-1L,1L,-1L,0L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,-1L,0L,0L,1L,-1L,1L,0L,0L,1L,-1L,0L,-1L,1L,-1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089497Inst : IEnumerable<long>
{
public static readonly long[] Value=A089497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089497.Bytes);
public long this[int i]=>Value[i];

public static A089497Inst Instance=new A089497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089498
{
public static readonly long[] Value={ 0L,4L,20L,120L,696L,4060L,23660L,137904L,803760L,4684660L,27304196L,159140520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089498Inst : IEnumerable<long>
{
public static readonly long[] Value=A089498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089498.Bytes);
public long this[int i]=>Value[i];

public static A089498Inst Instance=new A089498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089499
{
public static readonly long[] Value={ 0L,1L,4L,5L,24L,29L,140L,169L,816L,985L,4756L,5741L,27720L,33461L,161564L,195025L,941664L,1136689L,5488420L,6625109L,31988856L,38613965L,186444716L,225058681L,1086679440L,1311738121L,6333631924L,7645370045L,36915112104L,44560482149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089499Inst : IEnumerable<long>
{
public static readonly long[] Value=A089499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089499.Bytes);
public long this[int i]=>Value[i];

public static A089499Inst Instance=new A089499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089500
{
public static readonly BigInteger[] Value={ 1L,2L,10L,630L,2520L,277200L,97297200L,3405402000L,463134672000L,475176173472000L,16631166071520000L,4207685016094560000L,BigInteger.Parse("3786916514485104000000"),BigInteger.Parse("98459829376612704000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089500Inst Instance=new A089500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089501
{
public static readonly BigInteger[] Value={ 1L,6L,2880L,870912000L,637129677864960000L,BigInteger.Parse("3076276241856388273274880000000"),BigInteger.Parse("218470761021769399142244567460557619200000000000"),BigInteger.Parse("444747235963340607791337561259087696911923105885061120000000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089501Inst Instance=new A089501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089502
{
public static readonly long[] Value={ 17L,13L,17L,13L,17L,41L,31L,53L,53L,17L,71L,13L,13L,23L,41L,107L,17L,41L,71L,17L,13L,23L,23L,53L,13L,83L,47L,17L,31L,23L,47L,47L,11L,31L,31L,41L,41L,41L,23L,41L,13L,31L,23L,23L,23L,17L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089502Inst : IEnumerable<long>
{
public static readonly long[] Value=A089502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089502.Bytes);
public long this[int i]=>Value[i];

public static A089502Inst Instance=new A089502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089503
{
public static readonly long[] Value={ 1L,1L,4L,1L,12L,30L,1L,24L,168L,336L,1L,40L,540L,2880L,5040L,1L,60L,1320L,13200L,59400L,95040L,1L,84L,2730L,43680L,360360L,1441440L,2162160L,1L,112L,5040L,117600L,1528800L,11007360L,40360320L,57657600L,1L,144L,8568L,274176L,5140800L,57576960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089503Inst : IEnumerable<long>
{
public static readonly long[] Value=A089503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089503.Bytes);
public long this[int i]=>Value[i];

public static A089503Inst Instance=new A089503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089504
{
public static readonly long[] Value={ 1L,6L,1L,36L,30L,1L,216L,756L,90L,1L,1296L,18360L,6156L,210L,1L,7776L,441936L,387720L,31356L,420L,1L,46656L,10614240L,23705136L,4150440L,119556L,756L,1L,279936L,254788416L,1432922400L,521757936L,29257200L,373572L,1260L,1L,1679616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089504Inst : IEnumerable<long>
{
public static readonly long[] Value=A089504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089504.Bytes);
public long this[int i]=>Value[i];

public static A089504Inst Instance=new A089504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089505
{
public static readonly long[] Value={ 1L,-1L,4L,1L,-24L,50L,-1L,114L,-950L,1350L,31L,-15504L,400520L,-1897200L,2052855L,-9269L,19612560L,-1431859000L,17333030000L,-56265334125L,49236404224L,342953L,-3011508588L,594221485000L,-16634292228125L,123422029355625L,-302409994743808L,222337901418633L,-9945637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089505Inst : IEnumerable<long>
{
public static readonly long[] Value=A089505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089505.Bytes);
public long this[int i]=>Value[i];

public static A089505Inst Instance=new A089505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089506
{
public static readonly BigInteger[] Value={ 1L,3L,27L,513L,540702L,8891844390L,27306854121690L,94235953573952190L,BigInteger.Parse("1684561906087969348440"),BigInteger.Parse("1106757172299795861925080"),BigInteger.Parse("8644064410182787098480243878401800") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089506Inst Instance=new A089506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089507
{
public static readonly BigInteger[] Value={ 1L,30L,756L,18360L,441936L,10614240L,254788416L,6115201920L,146766525696L,3522406694400L,84537821131776L,2028908069959680L,48693795855814656L,1168651113600245760L,BigInteger.Parse("28047626804770062336"),BigInteger.Parse("673143043784666480640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089507Inst Instance=new A089507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089524
{
public static readonly long[] Value={ 117814L,303839L,588398L,641658L,667591L,718808L,755409L,940389L,1168122L,1198507L,1229482L,1229483L,1588488L,1698574L,1764688L,1840175L,1933195L,1936524L,2249818L,2849725L,2859255L,3307463L,3363452L,3414415L,3481752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089524Inst : IEnumerable<long>
{
public static readonly long[] Value=A089524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089524.Bytes);
public long this[int i]=>Value[i];

public static A089524Inst Instance=new A089524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089525
{
public static readonly long[] Value={ 77L,87L,455L,3386L,7811L,11926L,12233L,12705L,13448L,15382L,16338L,17462L,17844L,18387L,18580L,20577L,22492L,25001L,26060L,32604L,34578L,42718L,52713L,55807L,60272L,65730L,67963L,77232L,85964L,92239L,98963L,99587L,100386L,102163L,103689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089525Inst : IEnumerable<long>
{
public static readonly long[] Value=A089525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089525.Bytes);
public long this[int i]=>Value[i];

public static A089525Inst Instance=new A089525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089526
{
public static readonly long[] Value={ 3L,7L,14L,33L,44L,45L,48L,49L,70L,75L,90L,174L,186L,213L,225L,246L,253L,254L,447L,505L,524L,531L,589L,592L,625L,665L,745L,766L,806L,866L,868L,989L,1047L,1084L,1091L,1105L,1131L,1191L,1202L,1228L,1257L,1280L,1333L,1395L,1410L,1429L,1495L,1512L,1550L,1643L,1651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089526Inst : IEnumerable<long>
{
public static readonly long[] Value=A089526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089526.Bytes);
public long this[int i]=>Value[i];

public static A089526Inst Instance=new A089526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089527
{
public static readonly long[] Value={ 5L,17L,43L,137L,193L,197L,223L,227L,349L,379L,463L,1033L,1109L,1303L,1427L,1559L,1607L,1609L,3163L,3613L,3767L,3823L,4289L,4337L,4637L,4969L,5657L,5839L,6199L,6709L,6733L,7823L,8363L,8699L,8747L,8863L,9127L,9643L,9743L,9967L,10253L,10459L,10979L,11593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089527Inst : IEnumerable<long>
{
public static readonly long[] Value=A089527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089527.Bytes);
public long this[int i]=>Value[i];

public static A089527Inst Instance=new A089527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089528
{
public static readonly long[] Value={ 13L,37L,89L,277L,389L,397L,449L,457L,701L,761L,929L,2069L,2221L,2609L,2857L,3121L,3217L,3221L,6329L,7229L,7537L,7649L,8581L,8677L,9277L,9941L,11317L,11681L,12401L,13421L,13469L,15649L,16729L,17401L,17497L,17729L,18257L,19289L,19489L,19937L,20509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089528Inst : IEnumerable<long>
{
public static readonly long[] Value=A089528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089528.Bytes);
public long this[int i]=>Value[i];

public static A089528Inst Instance=new A089528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089529
{
public static readonly long[] Value={ 6L,12L,24L,59L,77L,78L,87L,88L,126L,135L,158L,312L,331L,379L,415L,445L,455L,456L,824L,924L,955L,971L,1069L,1080L,1148L,1226L,1368L,1402L,1480L,1592L,1597L,1826L,1934L,2002L,2014L,2035L,2093L,2187L,2212L,2254L,2315L,2353L,2461L,2587L,2619L,2653L,2766L,2792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089529Inst : IEnumerable<long>
{
public static readonly long[] Value=A089529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089529.Bytes);
public long this[int i]=>Value[i];

public static A089529Inst Instance=new A089529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089530
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,10L,14L,15L,16L,19L,21L,24L,25L,30L,31L,33L,34L,37L,39L,40L,44L,45L,46L,48L,49L,50L,57L,59L,61L,63L,68L,70L,71L,75L,76L,78L,80L,85L,90L,91L,93L,96L,97L,99L,101L,102L,103L,109L,111L,112L,113L,117L,118L,120L,131L,132L,137L,139L,140L,144L,147L,149L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089530Inst : IEnumerable<long>
{
public static readonly long[] Value=A089530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089530.Bytes);
public long this[int i]=>Value[i];

public static A089530Inst Instance=new A089530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089531
{
public static readonly long[] Value={ 7L,13L,17L,29L,37L,41L,61L,89L,97L,109L,137L,149L,181L,197L,229L,257L,277L,281L,317L,337L,349L,389L,397L,401L,449L,457L,461L,541L,557L,569L,617L,677L,701L,709L,761L,769L,797L,821L,881L,929L,937L,977L,1009L,1021L,1049L,1097L,1117L,1129L,1201L,1217L,1229L,1237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089531Inst : IEnumerable<long>
{
public static readonly long[] Value=A089531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089531.Bytes);
public long this[int i]=>Value[i];

public static A089531Inst Instance=new A089531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089532
{
public static readonly long[] Value={ 4L,6L,7L,10L,12L,13L,18L,24L,25L,29L,33L,35L,42L,45L,50L,55L,59L,60L,66L,68L,70L,77L,78L,79L,87L,88L,89L,100L,102L,104L,113L,123L,126L,127L,135L,136L,139L,142L,152L,158L,159L,165L,169L,172L,176L,184L,187L,189L,197L,199L,201L,203L,209L,211L,216L,234L,237L,244L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089532Inst : IEnumerable<long>
{
public static readonly long[] Value=A089532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089532.Bytes);
public long this[int i]=>Value[i];

public static A089532Inst Instance=new A089532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089533
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,2L,1L,4L,6L,1L,1L,2L,1L,3L,2L,1L,1L,2L,1L,1L,5L,2L,1L,2L,1L,3L,2L,5L,4L,2L,3L,1L,2L,1L,1L,2L,4L,1L,2L,7L,1L,6L,2L,1L,2L,1L,6L,5L,1L,3L,2L,1L,3L,3L,1L,1L,2L,1L,3L,2L,1L,1L,3L,3L,9L,2L,1L,1L,3L,3L,3L,2L,1L,1L,14L,3L,3L,2L,2L,1L,3L,2L,1L,6L,2L,1L,2L,5L,1L,6L,1L,3L,5L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089533Inst : IEnumerable<long>
{
public static readonly long[] Value=A089533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089533.Bytes);
public long this[int i]=>Value[i];

public static A089533Inst Instance=new A089533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089534
{
public static readonly long[] Value={ 5L,13L,11L,13L,26L,18L,20L,53L,42L,26L,67L,53L,32L,60L,36L,116L,172L,42L,43L,79L,47L,121L,89L,53L,54L,98L,58L,60L,230L,110L,64L,116L,67L,172L,126L,279L,234L,135L,193L,79L,142L,82L,83L,152L,279L,89L,160L,474L,94L,431L,172L,98L,178L,100L,464L,408L,105L,271L,194L,110L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089534Inst : IEnumerable<long>
{
public static readonly long[] Value=A089534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089534.Bytes);
public long this[int i]=>Value[i];

public static A089534Inst Instance=new A089534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089535
{
public static readonly BigInteger[] Value={ 6L,2059L,8388631L,17179869218L,576460752303423547L,BigInteger.Parse("590295810358705651781"),BigInteger.Parse("154742504910672534362390615"),BigInteger.Parse("39614081257132168796771975263"),BigInteger.Parse("664613997892457936451903530140172407") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089535Inst Instance=new A089535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089536
{
public static readonly BigInteger[] Value={ 2L,29L,31L,2L,7L,7L,5L,1188359L,1307L,165864626101044727L,36120307175753L,BigInteger.Parse("9772772454840984668059"),BigInteger.Parse("8944440848667088469951"),3041407L,6446147951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089536Inst Instance=new A089536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089537
{
public static readonly BigInteger[] Value={ 3L,71L,270601L,8589934609L,82351536043346221L,BigInteger.Parse("84327972908386521683"),BigInteger.Parse("30948500982134506872478123"),BigInteger.Parse("33335112753917098113257"),BigInteger.Parse("508503441386731397438334759097301"),BigInteger.Parse("64111463765644650653") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089537Inst Instance=new A089537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089538
{
public static readonly long[] Value={ 2L,1L,2L,0L,0L,0L,0L,0L,3L,0L,2L,7L,0L,0L,4L,1L,2L,9L,0L,0L,5L,10L,2L,0L,0L,0L,12L,0L,13L,1L,8L,5L,5L,0L,4L,2L,13L,0L,6L,31L,15L,17L,1L,12L,3L,12L,17L,0L,1L,21L,17L,22L,21L,0L,0L,18L,0L,12L,0L,18L,11L,12L,14L,4L,23L,20L,8L,4L,27L,8L,0L,28L,12L,39L,0L,27L,2L,21L,29L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089538Inst : IEnumerable<long>
{
public static readonly long[] Value=A089538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089538.Bytes);
public long this[int i]=>Value[i];

public static A089538Inst Instance=new A089538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089539
{
public static readonly long[] Value={ 4L,4L,9L,25L,121L,721L,5041L,40321L,362885L,3628801L,39916803L,479001617L,6227020801L,87178291201L,1307674368007L,20922789888002L,355687428096003L,6402373705728023L,121645100408832001L,2432902008176640001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089539Inst : IEnumerable<long>
{
public static readonly long[] Value=A089539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089539.Bytes);
public long this[int i]=>Value[i];

public static A089539Inst Instance=new A089539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089556
{
public static readonly long[] Value={ 3L,7L,9L,13L,19L,15L,21L,31L,27L,33L,33L,43L,43L,37L,45L,51L,57L,49L,55L,63L,73L,73L,75L,91L,69L,87L,79L,93L,99L,111L,97L,103L,93L,85L,115L,129L,133L,117L,103L,135L,121L,133L,111L,147L,139L,157L,163L,159L,153L,141L,145L,183L,183L,201L,169L,189L,175L,153L,189L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089556Inst : IEnumerable<long>
{
public static readonly long[] Value=A089556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089556.Bytes);
public long this[int i]=>Value[i];

public static A089556Inst Instance=new A089556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089557
{
public static readonly long[] Value={ 2L,3L,5L,4L,7L,14L,5L,6L,18L,9L,21L,7L,22L,33L,24L,11L,8L,45L,39L,26L,9L,13L,30L,10L,60L,30L,55L,33L,15L,11L,60L,51L,68L,84L,34L,17L,12L,65L,91L,39L,76L,57L,95L,38L,70L,13L,19L,42L,84L,105L,105L,14L,42L,21L,112L,80L,115L,144L,92L,15L,138L,69L,48L,46L,119L,85L,153L,16L,23L,51L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089557Inst : IEnumerable<long>
{
public static readonly long[] Value=A089557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089557.Bytes);
public long this[int i]=>Value[i];

public static A089557Inst Instance=new A089557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089558
{
public static readonly long[] Value={ 2L,21L,35L,68L,161L,14L,155L,294L,306L,423L,483L,497L,902L,231L,984L,869L,776L,315L,1209L,1898L,1143L,1547L,2670L,1610L,1020L,3390L,2585L,3927L,2505L,2189L,4380L,5253L,3332L,84L,5474L,3791L,2892L,6695L,2093L,7449L,6764L,8607L,2945L,8246L,9590L,3731L,5453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089558Inst : IEnumerable<long>
{
public static readonly long[] Value=A089558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089558.Bytes);
public long this[int i]=>Value[i];

public static A089558Inst Instance=new A089558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089559
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,13L,14L,16L,19L,22L,23L,26L,28L,29L,32L,34L,37L,41L,43L,44L,46L,47L,49L,56L,58L,61L,62L,67L,68L,71L,74L,76L,79L,82L,83L,88L,89L,91L,92L,98L,104L,106L,107L,109L,112L,113L,118L,121L,124L,127L,128L,131L,133L,134L,139L,146L,148L,149L,151L,158L,161L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089559Inst : IEnumerable<long>
{
public static readonly long[] Value=A089559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089559.Bytes);
public long this[int i]=>Value[i];

public static A089559Inst Instance=new A089559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089560
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,14L,9L,6L,57L,13L,18L,17L,16L,12L,20L,82L,42L,21L,45L,78L,98L,33L,133L,50L,28L,41L,124L,36L,44L,19L,80L,40L,75L,63L,372L,168L,179L,85L,84L,128L,64L,302L,151L,248L,10L,69L,123L,11L,54L,31L,149L,34L,185L,51L,213L,43L,282L,105L,125L,237L,55L,174L,96L,438L,215L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089560Inst : IEnumerable<long>
{
public static readonly long[] Value=A089560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089560.Bytes);
public long this[int i]=>Value[i];

public static A089560Inst Instance=new A089560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089561
{
public static readonly BigInteger[] Value={ 1L,31L,431L,5431L,75431L,1475431L,91475431L,691475431L,57691475431L,1357691475431L,181357691475431L,17181357691475431L,1617181357691475431L,BigInteger.Parse("121617181357691475431"),BigInteger.Parse("20121617181357691475431") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089561Inst Instance=new A089561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089562
{
public static readonly long[] Value={ 7L,1L,3L,6L,2L,21L,10L,9L,8L,37L,20L,25L,29L,72L,28L,30L,27L,23L,39L,19L,51L,32L,22L,54L,42L,35L,24L,73L,36L,120L,44L,186L,4L,26L,126L,171L,70L,33L,18L,60L,113L,99L,81L,76L,47L,108L,91L,170L,159L,49L,65L,114L,238L,185L,285L,34L,98L,312L,63L,183L,15L,205L,230L,198L,310L,524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089562Inst : IEnumerable<long>
{
public static readonly long[] Value=A089562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089562.Bytes);
public long this[int i]=>Value[i];

public static A089562Inst Instance=new A089562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089563
{
public static readonly BigInteger[] Value={ 7L,17L,317L,6317L,26317L,2126317L,102126317L,9102126317L,89102126317L,3789102126317L,203789102126317L,25203789102126317L,2925203789102126317L,BigInteger.Parse("722925203789102126317"),BigInteger.Parse("28722925203789102126317") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089563Inst Instance=new A089563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089564
{
public static readonly long[] Value={ 9L,1L,4L,5L,3L,7L,12L,11L,13L,42L,26L,10L,17L,16L,20L,82L,29L,78L,57L,27L,28L,66L,45L,6L,69L,33L,236L,40L,116L,237L,196L,65L,133L,90L,60L,72L,80L,61L,126L,24L,153L,68L,88L,122L,43L,156L,231L,285L,125L,177L,249L,106L,36L,147L,23L,208L,483L,138L,281L,63L,108L,22L,38L,75L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089564Inst : IEnumerable<long>
{
public static readonly long[] Value=A089564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089564.Bytes);
public long this[int i]=>Value[i];

public static A089564Inst Instance=new A089564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089565
{
public static readonly BigInteger[] Value={ 9L,19L,419L,5419L,35419L,735419L,12735419L,1112735419L,131112735419L,42131112735419L,2642131112735419L,102642131112735419L,17102642131112735419UL,BigInteger.Parse("1617102642131112735419"),BigInteger.Parse("201617102642131112735419") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089565Inst Instance=new A089565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089566
{
public static readonly long[] Value={ 11L,2L,4L,3L,5L,9L,1L,30L,6L,20L,16L,8L,24L,15L,13L,39L,36L,56L,64L,72L,29L,49L,27L,60L,54L,63L,65L,45L,12L,99L,28L,47L,88L,51L,83L,31L,59L,94L,336L,108L,182L,204L,184L,38L,37L,188L,210L,91L,62L,10L,224L,202L,128L,115L,66L,111L,156L,566L,43L,255L,279L,315L,180L,257L,102L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089566Inst : IEnumerable<long>
{
public static readonly long[] Value=A089566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089566.Bytes);
public long this[int i]=>Value[i];

public static A089566Inst Instance=new A089566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089567
{
public static readonly BigInteger[] Value={ 11L,211L,4211L,34211L,534211L,9534211L,19534211L,3019534211L,63019534211L,2063019534211L,162063019534211L,8162063019534211L,248162063019534211L,15248162063019534211UL,BigInteger.Parse("1315248162063019534211"),BigInteger.Parse("391315248162063019534211") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089567Inst Instance=new A089567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089568
{
public static readonly long[] Value={ 13L,1L,2L,19L,3L,8L,15L,18L,10L,17L,45L,24L,22L,11L,37L,5L,30L,39L,81L,6L,76L,57L,69L,56L,84L,36L,49L,48L,38L,63L,148L,27L,75L,239L,31L,50L,171L,67L,116L,282L,42L,175L,23L,55L,236L,70L,278L,73L,90L,140L,91L,9L,210L,174L,126L,105L,89L,94L,224L,34L,114L,26L,133L,143L,54L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089568Inst : IEnumerable<long>
{
public static readonly long[] Value=A089568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089568.Bytes);
public long this[int i]=>Value[i];

public static A089568Inst Instance=new A089568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089569
{
public static readonly BigInteger[] Value={ 13L,113L,2113L,192113L,3192113L,83192113L,1583192113L,181583192113L,10181583192113L,1710181583192113L,451710181583192113L,BigInteger.Parse("24451710181583192113"),BigInteger.Parse("2224451710181583192113"),BigInteger.Parse("112224451710181583192113") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089569Inst Instance=new A089569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089570
{
public static readonly long[] Value={ 17L,3L,6L,2L,1L,21L,35L,43L,23L,34L,47L,10L,26L,4L,14L,15L,12L,40L,18L,54L,51L,5L,27L,9L,132L,63L,166L,98L,78L,24L,30L,58L,105L,71L,75L,57L,70L,42L,11L,19L,38L,217L,285L,36L,77L,64L,56L,259L,45L,93L,102L,60L,122L,66L,96L,103L,267L,255L,92L,91L,276L,152L,208L,204L,90L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089570Inst : IEnumerable<long>
{
public static readonly long[] Value=A089570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089570.Bytes);
public long this[int i]=>Value[i];

public static A089570Inst Instance=new A089570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089571
{
public static readonly BigInteger[] Value={ 17L,317L,6317L,26317L,126317L,21126317L,3521126317L,433521126317L,23433521126317L,3423433521126317L,473423433521126317L,10473423433521126317UL,BigInteger.Parse("2610473423433521126317"),BigInteger.Parse("42610473423433521126317") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089571Inst Instance=new A089571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089604
{
public static readonly long[] Value={ 0L,1L,2L,11L,12L,21L,22L,31L,112L,121L,122L,131L,212L,213L,222L,231L,312L,321L,1122L,1131L,1212L,1221L,1222L,1231L,1312L,1321L,2122L,2131L,2212L,2221L,2222L,2231L,2312L,2321L,3122L,3131L,3212L,3221L,11222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089604Inst : IEnumerable<long>
{
public static readonly long[] Value=A089604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089604.Bytes);
public long this[int i]=>Value[i];

public static A089604Inst Instance=new A089604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089605
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,2L,0L,1L,3L,3L,0L,1L,1L,1L,0L,1L,2L,1L,3L,1L,1L,1L,2L,2L,4L,0L,4L,3L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,3L,3L,2L,1L,4L,3L,2L,0L,2L,2L,2L,1L,3L,1L,3L,1L,5L,1L,0L,3L,5L,2L,4L,3L,2L,1L,2L,2L,3L,0L,3L,4L,3L,1L,2L,1L,3L,3L,2L,2L,2L,4L,2L,1L,3L,2L,2L,1L,4L,4L,4L,0L,3L,0L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089605Inst : IEnumerable<long>
{
public static readonly long[] Value=A089605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089605.Bytes);
public long this[int i]=>Value[i];

public static A089605Inst Instance=new A089605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089606
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,3L,2L,1L,16L,5L,3L,2L,1L,32L,7L,4L,3L,2L,1L,64L,10L,6L,4L,3L,2L,1L,128L,13L,8L,5L,4L,3L,2L,1L,256L,18L,10L,7L,5L,4L,3L,2L,1L,512L,23L,13L,9L,6L,5L,4L,3L,2L,1L,1024L,30L,16L,11L,8L,6L,5L,4L,3L,2L,1L,2048L,37L,19L,13L,10L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089606Inst : IEnumerable<long>
{
public static readonly long[] Value=A089606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089606.Bytes);
public long this[int i]=>Value[i];

public static A089606Inst Instance=new A089606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089607
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089607Inst : IEnumerable<long>
{
public static readonly long[] Value=A089607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089607.Bytes);
public long this[int i]=>Value[i];

public static A089607Inst Instance=new A089607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089608
{
public static readonly long[] Value={ 1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089608Inst : IEnumerable<long>
{
public static readonly long[] Value=A089608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089608.Bytes);
public long this[int i]=>Value[i];

public static A089608Inst Instance=new A089608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089609
{
public static readonly long[] Value={ 2L,5L,11L,47L,163L,89L,463L,479L,199L,107L,241L,151L,709L,151L,599L,313L,547L,211L,613L,859L,863L,241L,1217L,1091L,827L,311L,967L,1327L,691L,1109L,1123L,829L,389L,821L,857L,431L,1301L,433L,1451L,1933L,3449L,5701L,1753L,4663L,563L,3557L,4253L,1867L,4447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089609Inst : IEnumerable<long>
{
public static readonly long[] Value=A089609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089609.Bytes);
public long this[int i]=>Value[i];

public static A089609Inst Instance=new A089609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089610
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,4L,2L,2L,3L,2L,4L,4L,1L,2L,3L,3L,4L,4L,2L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,4L,5L,7L,3L,6L,6L,8L,5L,5L,7L,4L,6L,7L,6L,7L,6L,6L,5L,9L,7L,7L,6L,7L,7L,6L,8L,8L,7L,7L,8L,9L,11L,7L,8L,10L,8L,11L,8L,7L,7L,10L,11L,12L,4L,9L,11L,6L,9L,9L,10L,8L,9L,8L,11L,8L,8L,9L,10L,8L,13L,10L,9L,10L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089610Inst : IEnumerable<long>
{
public static readonly long[] Value=A089610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089610.Bytes);
public long this[int i]=>Value[i];

public static A089610Inst Instance=new A089610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089611
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,3L,3L,2L,3L,3L,3L,3L,5L,2L,3L,5L,2L,4L,3L,6L,3L,4L,5L,2L,4L,5L,4L,3L,3L,3L,4L,6L,4L,3L,4L,4L,5L,4L,4L,6L,4L,6L,4L,5L,7L,5L,6L,7L,6L,7L,5L,5L,3L,8L,8L,7L,2L,7L,7L,4L,7L,4L,4L,5L,5L,4L,8L,5L,6L,5L,7L,4L,8L,8L,6L,6L,11L,8L,9L,5L,7L,7L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089611Inst : IEnumerable<long>
{
public static readonly long[] Value=A089611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089611.Bytes);
public long this[int i]=>Value[i];

public static A089611Inst Instance=new A089611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089612
{
public static readonly long[] Value={ 1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,2L,1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,4L,1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,2L,1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,3L,1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,2L,1L,4L,1L,3L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,4L,1L,4L,1L,3L,1L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089612Inst : IEnumerable<long>
{
public static readonly long[] Value=A089612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089612.Bytes);
public long this[int i]=>Value[i];

public static A089612Inst Instance=new A089612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089613
{
public static readonly long[] Value={ 1L,8L,25L,49L,83L,126L,176L,241L,307L,377L,457L,547L,639L,746L,857L,988L,1124L,1273L,1427L,1598L,1786L,1995L,2225L,2472L,2723L,2995L,3276L,3568L,3882L,4202L,4526L,4868L,5214L,5569L,5932L,6310L,6690L,7078L,7485L,7896L,8317L,8761L,9211L,9665L,10143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089613Inst : IEnumerable<long>
{
public static readonly long[] Value=A089613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089613.Bytes);
public long this[int i]=>Value[i];

public static A089613Inst Instance=new A089613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089614
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,0L,2L,1L,2L,2L,2L,1L,2L,2L,3L,4L,2L,3L,4L,2L,4L,2L,5L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,3L,5L,2L,3L,3L,2L,5L,4L,2L,4L,3L,4L,1L,3L,5L,3L,5L,6L,4L,5L,2L,3L,3L,6L,7L,6L,2L,5L,6L,2L,6L,4L,4L,3L,5L,3L,7L,3L,6L,4L,6L,2L,6L,6L,6L,5L,7L,7L,6L,4L,4L,4L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089614Inst : IEnumerable<long>
{
public static readonly long[] Value=A089614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089614.Bytes);
public long this[int i]=>Value[i];

public static A089614Inst Instance=new A089614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089615
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,1L,2L,0L,0L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,0L,1L,1L,2L,2L,1L,0L,2L,2L,2L,3L,1L,3L,4L,2L,4L,2L,4L,2L,1L,1L,2L,3L,2L,2L,2L,2L,1L,3L,4L,1L,2L,2L,1L,5L,2L,2L,4L,3L,4L,1L,2L,4L,3L,3L,5L,2L,3L,2L,3L,3L,5L,5L,4L,2L,4L,5L,2L,5L,2L,4L,3L,5L,2L,6L,3L,5L,4L,6L,1L,4L,6L,5L,4L,7L,6L,6L,4L,2L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089615Inst : IEnumerable<long>
{
public static readonly long[] Value=A089615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089615.Bytes);
public long this[int i]=>Value[i];

public static A089615Inst Instance=new A089615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089616
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,0L,1L,2L,0L,0L,1L,2L,2L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,2L,1L,1L,0L,1L,2L,2L,3L,1L,2L,4L,2L,3L,2L,4L,1L,1L,1L,1L,3L,2L,2L,2L,2L,1L,2L,4L,1L,2L,2L,1L,4L,2L,2L,3L,3L,4L,1L,2L,4L,3L,2L,3L,1L,3L,2L,2L,3L,3L,3L,4L,2L,3L,3L,1L,5L,2L,3L,3L,5L,2L,5L,3L,4L,4L,5L,1L,3L,6L,4L,4L,7L,5L,5L,2L,2L,3L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089616Inst : IEnumerable<long>
{
public static readonly long[] Value=A089616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089616.Bytes);
public long this[int i]=>Value[i];

public static A089616Inst Instance=new A089616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089617
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,2L,2L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,3L,1L,2L,3L,1L,3L,2L,3L,0L,0L,1L,0L,2L,1L,2L,2L,1L,1L,1L,3L,1L,2L,1L,1L,4L,2L,1L,3L,2L,3L,0L,2L,4L,3L,2L,3L,0L,3L,2L,2L,2L,3L,2L,3L,1L,3L,3L,1L,5L,2L,3L,3L,4L,2L,5L,3L,3L,4L,4L,1L,2L,4L,4L,4L,5L,5L,4L,2L,2L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089617Inst : IEnumerable<long>
{
public static readonly long[] Value=A089617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089617.Bytes);
public long this[int i]=>Value[i];

public static A089617Inst Instance=new A089617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089618
{
public static readonly long[] Value={ 0L,2L,5L,1L,11L,1L,3L,1L,22L,2L,4L,1L,7L,1L,2L,1L,45L,2L,4L,1L,8L,1L,3L,1L,14L,1L,3L,1L,6L,1L,2L,1L,91L,2L,4L,1L,9L,1L,3L,1L,17L,2L,3L,1L,6L,1L,2L,1L,30L,2L,4L,1L,7L,1L,2L,1L,12L,1L,3L,1L,5L,1L,2L,1L,184L,2L,5L,1L,10L,1L,3L,1L,20L,2L,4L,1L,6L,1L,2L,1L,36L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089618Inst : IEnumerable<long>
{
public static readonly long[] Value=A089618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089618.Bytes);
public long this[int i]=>Value[i];

public static A089618Inst Instance=new A089618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089619
{
public static readonly long[] Value={ 5L,13L,5L,41L,61L,17L,113L,29L,181L,17L,53L,313L,73L,421L,37L,109L,613L,137L,761L,29L,37L,1013L,17L,1201L,1301L,281L,89L,13L,1741L,1861L,397L,2113L,449L,2381L,2521L,41L,97L,593L,3121L,193L,53L,3613L,757L,233L,101L,173L,4513L,941L,29L,5101L,1061L,149L,229L,457L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089619Inst : IEnumerable<long>
{
public static readonly long[] Value=A089619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089619.Bytes);
public long this[int i]=>Value[i];

public static A089619Inst Instance=new A089619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089636
{
public static readonly long[] Value={ 1L,3L,5L,9L,23L,39L,79L,158L,281L,741L,1145L,2297L,4495L,10111L,20223L,40446L,80983L,162009L,323369L,646271L,1216723L,2592211L,5184422L,9733109L,20739329L,41467565L,81559503L,163649289L,311481083L,662667007L,1325334527L,2628708543L,5308871023L,9627863373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089636Inst : IEnumerable<long>
{
public static readonly long[] Value=A089636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089636.Bytes);
public long this[int i]=>Value[i];

public static A089636Inst Instance=new A089636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089637
{
public static readonly long[] Value={ 17L,41L,107L,71L,2267L,1091L,461L,1319L,1151L,347L,5741L,2999L,5279L,10139L,1487L,9461L,881L,659L,13007L,9041L,15359L,8627L,28751L,13397L,18539L,14627L,26261L,24419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089637Inst : IEnumerable<long>
{
public static readonly long[] Value=A089637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089637.Bytes);
public long this[int i]=>Value[i];

public static A089637Inst Instance=new A089637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089638
{
public static readonly BigInteger[] Value={ 0L,5L,115L,1039L,58157L,1454021L,6854599L,30564710941L,244517610353L,37411196579209L,64619338818497L,86008340157931507L,8951094220597141L,BigInteger.Parse("334314418075511195849"),BigInteger.Parse("334314418069194908729"),BigInteger.Parse("48475590620225838341897"),BigInteger.Parse("707173321988579559023843") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089638Inst Instance=new A089638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089639
{
public static readonly BigInteger[] Value={ 1L,4L,96L,864L,48384L,1209600L,5702400L,25427001600L,203416012800L,31122649958400L,53757304473600L,71550972254361600L,7446481275340800L,BigInteger.Parse("278118629152703539200"),BigInteger.Parse("278118629152703539200"),BigInteger.Parse("40327201227142013184000"),BigInteger.Parse("588302700254777604096000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089639Inst Instance=new A089639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089640
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,4L,4L,6L,11L,15L,18L,27L,43L,59L,78L,115L,172L,239L,330L,480L,698L,980L,1379L,1988L,2856L,4037L,5726L,8211L,11737L,16656L,23700L,33885L,48341L,68749L,97941L,139811L,199316L,283780L,404442L,576879L,822223L,1171318L,1669543L,2380423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089640Inst : IEnumerable<long>
{
public static readonly long[] Value=A089640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089640.Bytes);
public long this[int i]=>Value[i];

public static A089640Inst Instance=new A089640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089641
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,1L,2L,1L,2L,4L,2L,2L,3L,1L,4L,2L,5L,3L,3L,2L,2L,2L,1L,2L,2L,4L,1L,2L,4L,2L,4L,1L,1L,4L,1L,2L,2L,3L,2L,2L,1L,2L,2L,4L,2L,4L,8L,1L,1L,5L,2L,4L,2L,8L,6L,5L,2L,1L,2L,2L,3L,2L,3L,4L,1L,3L,1L,2L,2L,7L,5L,2L,1L,2L,2L,2L,8L,2L,2L,4L,2L,1L,5L,2L,4L,4L,4L,2L,6L,2L,8L,2L,6L,6L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089641Inst : IEnumerable<long>
{
public static readonly long[] Value=A089641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089641.Bytes);
public long this[int i]=>Value[i];

public static A089641Inst Instance=new A089641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089642
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,12L,13L,15L,21L,30L,34L,39L,40L,42L,48L,55L,56L,65L,72L,74L,80L,89L,102L,110L,130L,144L,168L,170L,176L,180L,185L,193L,194L,208L,233L,272L,275L,288L,297L,299L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089642Inst : IEnumerable<long>
{
public static readonly long[] Value=A089642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089642.Bytes);
public long this[int i]=>Value[i];

public static A089642Inst Instance=new A089642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089643
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,3L,1L,1L,2L,2L,1L,2L,2L,2L,3L,2L,2L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,4L,1L,1L,2L,2L,1L,2L,2L,2L,3L,2L,2L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,4L,2L,2L,3L,3L,2L,3L,3L,3L,4L,3L,3L,4L,4L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,4L,2L,2L,3L,3L,2L,3L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089643Inst : IEnumerable<long>
{
public static readonly long[] Value=A089643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089643.Bytes);
public long this[int i]=>Value[i];

public static A089643Inst Instance=new A089643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089644
{
public static readonly long[] Value={ 7L,14L,28L,35L,49L,56L,70L,77L,91L,98L,112L,119L,133L,140L,154L,161L,175L,182L,196L,203L,217L,224L,238L,245L,259L,266L,280L,287L,301L,308L,322L,329L,343L,350L,364L,371L,385L,392L,406L,413L,427L,434L,448L,455L,469L,476L,490L,497L,511L,518L,532L,539L,553L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089644Inst : IEnumerable<long>
{
public static readonly long[] Value=A089644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089644.Bytes);
public long this[int i]=>Value[i];

public static A089644Inst Instance=new A089644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089645
{
public static readonly long[] Value={ 2L,3L,9L,11L,24L,35L,28L,31L,80L,60L,121L,119L,116L,195L,75L,79L,204L,323L,228L,199L,146L,264L,529L,504L,200L,675L,540L,251L,840L,899L,186L,191L,1088L,748L,1225L,324L,740L,1140L,1521L,1079L,1680L,336L,1204L,484L,540L,460L,1692L,1151L,734L,2499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089645Inst : IEnumerable<long>
{
public static readonly long[] Value=A089645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089645.Bytes);
public long this[int i]=>Value[i];

public static A089645Inst Instance=new A089645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089646
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,13L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,32L,33L,33L,35L,36L,38L,41L,42L,43L,45L,46L,47L,51L,52L,53L,56L,57L,58L,59L,60L,62L,64L,65L,66L,69L,71L,72L,74L,75L,76L,82L,83L,84L,87L,87L,89L,93L,94L,95L,97L,101L,102L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089646Inst : IEnumerable<long>
{
public static readonly long[] Value=A089646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089646.Bytes);
public long this[int i]=>Value[i];

public static A089646Inst Instance=new A089646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089647
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,8L,12L,18L,26L,37L,54L,76L,111L,156L,221L,310L,438L,608L,850L,1178L,1633L,2251L,3104L,4257L,5837L,7972L,10866L,14772L,20042L,27121L,36625L,49356L,66366L,89077L,119319L,159547L,212942L,283753L,377423L,501274L,664639L,879963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089647Inst : IEnumerable<long>
{
public static readonly long[] Value=A089647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089647.Bytes);
public long this[int i]=>Value[i];

public static A089647Inst Instance=new A089647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089648
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,9L,10L,12L,17L,18L,19L,20L,21L,22L,24L,25L,26L,28L,35L,37L,38L,41L,42L,44L,49L,50L,52L,56L,67L,69L,70L,71L,73L,74L,75L,76L,77L,78L,81L,82L,83L,84L,85L,86L,88L,89L,90L,92L,97L,98L,99L,100L,101L,102L,104L,105L,106L,108L,112L,113L,114L,116L,120L,135L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089648Inst : IEnumerable<long>
{
public static readonly long[] Value=A089648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089648.Bytes);
public long this[int i]=>Value[i];

public static A089648Inst Instance=new A089648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089649
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,23L,27L,31L,37L,43L,49L,57L,65L,73L,83L,93L,103L,116L,129L,142L,158L,174L,190L,209L,228L,247L,270L,293L,316L,343L,370L,397L,428L,459L,490L,527L,564L,601L,644L,687L,730L,779L,828L,877L,934L,991L,1048L,1113L,1178L,1243L,1316L,1389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089649Inst : IEnumerable<long>
{
public static readonly long[] Value=A089649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089649.Bytes);
public long this[int i]=>Value[i];

public static A089649Inst Instance=new A089649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089650
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,0L,2L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,1L,1L,0L,2L,1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,0L,2L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,0L,2L,1L,2L,0L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089650Inst : IEnumerable<long>
{
public static readonly long[] Value=A089650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089650.Bytes);
public long this[int i]=>Value[i];

public static A089650Inst Instance=new A089650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089651
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,16L,19L,22L,25L,29L,33L,37L,41L,46L,51L,56L,61L,68L,75L,82L,89L,98L,107L,116L,125L,136L,147L,158L,169L,182L,195L,208L,221L,237L,253L,269L,285L,304L,323L,342L,361L,383L,405L,427L,449L,474L,499L,524L,549L,578L,607L,636L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089651Inst : IEnumerable<long>
{
public static readonly long[] Value=A089651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089651.Bytes);
public long this[int i]=>Value[i];

public static A089651Inst Instance=new A089651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089668
{
public static readonly long[] Value={ 0L,4L,521L,17136L,320716L,4356560L,48024786L,456843520L,3893995184L,30487086144L,223052123830L,1544098243424L,10208488021176L,64917814932256L,399310478637476L,2386386863086080L,13906802738650816L,79261768839946496L,442921922267640894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089668Inst : IEnumerable<long>
{
public static readonly long[] Value=A089668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089668.Bytes);
public long this[int i]=>Value[i];

public static A089668Inst Instance=new A089668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089669
{
public static readonly BigInteger[] Value={ 0L,8L,155L,2286L,29296L,344140L,3807774L,40327280L,413058080L,4120742808L,40242188170L,386141947972L,3650905945872L,34087726136672L,314844824466704L,2880757518523200L,26141327872575616L,235490128979282224L,2107598857648209954L,BigInteger.Parse("18752794473550896332") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089669Inst Instance=new A089669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089670
{
public static readonly BigInteger[] Value={ 0L,8L,283L,6044L,101360L,1470640L,19361174L,237684384L,2768042208L,30935313600L,334481353690L,3519672963752L,36206551801264L,365363625058432L,3626585989411280L,35485636769545600L,342894590805622656L,3276865150482420480L,BigInteger.Parse("31008279252965786178") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089670Inst Instance=new A089670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089671
{
public static readonly BigInteger[] Value={ 0L,8L,539L,16632L,364042L,6510160L,101817234L,1447146512L,19144522160L,239513659776L,2865559784050L,33052451375152L,369790434398988L,4031805422883680L,42996629236138928L,449821323139340160L,4627609615665499456L,BigInteger.Parse("46907404618252667392"),BigInteger.Parse("469254490696475078130") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089671Inst Instance=new A089671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089672
{
public static readonly BigInteger[] Value={ 0L,8L,1051L,47024L,1343372L,29595904L,549599246L,9039987264L,135800368320L,1901346478080L,25165027679242L,318105020914208L,3870088369412824L,45584244411107584L,522235732874214800L,5840992473138691072L,BigInteger.Parse("63970901725419781632"),BigInteger.Parse("687749464543749095424"),BigInteger.Parse("7273214936974305201570") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089672Inst Instance=new A089672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089673
{
public static readonly long[] Value={ 0L,0L,0L,652L,1658784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089673Inst : IEnumerable<long>
{
public static readonly long[] Value=A089673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089673.Bytes);
public long this[int i]=>Value[i];

public static A089673Inst Instance=new A089673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089674
{
public static readonly long[] Value={ 0L,0L,0L,1692L,2329280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089674Inst : IEnumerable<long>
{
public static readonly long[] Value=A089674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089674.Bytes);
public long this[int i]=>Value[i];

public static A089674Inst Instance=new A089674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089675
{
public static readonly long[] Value={ 1L,2L,3L,17L,140L,990L,1887L,3530L,5996L,13820L,21873L,26045L,87720L,232599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089675Inst : IEnumerable<long>
{
public static readonly long[] Value=A089675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089675.Bytes);
public long this[int i]=>Value[i];

public static A089675Inst Instance=new A089675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089676
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,6L,8L,9L,10L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089676Inst : IEnumerable<long>
{
public static readonly long[] Value=A089676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089676.Bytes);
public long this[int i]=>Value[i];

public static A089676Inst Instance=new A089676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089677
{
public static readonly BigInteger[] Value={ 0L,1L,1L,7L,37L,271L,2341L,23647L,272917L,3543631L,51123781L,811316287L,14045783797L,263429174191L,5320671485221L,115141595488927L,2657827340990677L,65185383514567951L,1692767331628422661L,BigInteger.Parse("46400793659664205567"),BigInteger.Parse("1338843898122192101557") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089677Inst Instance=new A089677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089678
{
public static readonly long[] Value={ 2L,3L,5L,1608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089678Inst : IEnumerable<long>
{
public static readonly long[] Value=A089678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089678.Bytes);
public long this[int i]=>Value[i];

public static A089678Inst Instance=new A089678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089679
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,2L,1L,0L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089679Inst : IEnumerable<long>
{
public static readonly long[] Value=A089679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089679.Bytes);
public long this[int i]=>Value[i];

public static A089679Inst Instance=new A089679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089680
{
public static readonly long[] Value={ 3L,3L,1L,2L,4L,3L,3L,1L,2L,2L,3L,4L,4L,2L,2L,3L,4L,4L,4L,3L,2L,3L,3L,3L,3L,3L,2L,2L,2L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089680Inst : IEnumerable<long>
{
public static readonly long[] Value=A089680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089680.Bytes);
public long this[int i]=>Value[i];

public static A089680Inst Instance=new A089680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089681
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,14L,18L,22L,26L,28L,30L,34L,40L,44L,48L,50L,52L,54L,58L,60L,70L,72L,74L,76L,78L,92L,96L,110L,118L,122L,136L,138L,144L,150L,154L,158L,164L,176L,182L,186L,188L,204L,210L,214L,216L,230L,232L,234L,236L,242L,248L,260L,268L,272L,274L,280L,298L,304L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089681Inst : IEnumerable<long>
{
public static readonly long[] Value=A089681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089681.Bytes);
public long this[int i]=>Value[i];

public static A089681Inst Instance=new A089681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089682
{
public static readonly long[] Value={ 2L,11L,47L,107L,191L,431L,587L,971L,1451L,2027L,2351L,2699L,3467L,4799L,5807L,6911L,7499L,8111L,8747L,10091L,10799L,14699L,15551L,16427L,17327L,18251L,25391L,27647L,36299L,41771L,44651L,55487L,57131L,62207L,67499L,71147L,74891L,80687L,92927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089682Inst : IEnumerable<long>
{
public static readonly long[] Value=A089682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089682.Bytes);
public long this[int i]=>Value[i];

public static A089682Inst Instance=new A089682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089683
{
public static readonly BigInteger[] Value={ 81L,6561L,531441L,43046721L,3486784401L,282429536481L,22876792454961L,1853020188851841L,150094635296999121L,12157665459056928801UL,BigInteger.Parse("984770902183611232881"),BigInteger.Parse("79766443076872509863361"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("523347633027360537213511521") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089683Inst Instance=new A089683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089716
{
public static readonly long[] Value={ 11L,101L,181L,191L,271L,281L,461L,541L,631L,641L,811L,821L,911L,991L,1091L,1171L,1181L,1361L,1451L,1531L,1621L,1721L,1801L,1811L,1901L,2081L,2161L,2251L,2341L,2351L,2441L,2521L,2531L,2621L,2711L,2791L,2801L,2971L,3061L,3251L,3331L,3511L,3691L,3701L,3881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089716Inst : IEnumerable<long>
{
public static readonly long[] Value=A089716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089716.Bytes);
public long this[int i]=>Value[i];

public static A089716Inst Instance=new A089716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089717
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,66L,253L,561L,990L,1540L,2211L,3003L,3916L,4950L,5151L,6216L,7381L,8646L,10011L,11476L,13041L,14706L,16471L,18336L,20503L,22578L,24753L,27028L,29403L,31878L,34453L,37128L,39903L,42778L,46056L,49141L,52326L,55611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089717Inst : IEnumerable<long>
{
public static readonly long[] Value=A089717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089717.Bytes);
public long this[int i]=>Value[i];

public static A089717Inst Instance=new A089717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089718
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,1020L,60120L,4207140L,32160568320L,2718954045547227180L,BigInteger.Parse("207010809050400405050407020207010800"),BigInteger.Parse("22077011088099055044004405505504407702202207701108800") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089718Inst Instance=new A089718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}