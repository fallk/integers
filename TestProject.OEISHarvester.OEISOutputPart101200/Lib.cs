using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A120841
{
public static readonly long[] Value={ 1L,3L,5L,5L,9L,11L,13L,15L,13L,19L,21L,35L,25L,27L,29L,19L,33L,53L,37L,59L,41L,43L,45L,47L,37L,51L,53L,83L,57L,59L,61L,95L,65L,67L,69L,53L,73L,75L,77L,79L,81L,83L,85L,131L,133L,91L,93L,119L,73L,149L,101L,155L,105L,107L,109L,111L,113L,115L,117L,179L,121L,123L,187L,74L,129L };
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
public class A120841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120841Inst : IEnumerable<long>
{
public static readonly long[] Value=A120841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120841.Bytes);
public long this[int i]=>Value[i];

public static A120841Inst Instance=new A120841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120842
{
public static readonly long[] Value={ 1L,3L,2L,5L,2L,11L,2L,7L,4L,9L,2L,17L,2L,9L,7L,9L,2L,17L,2L,13L,5L,7L,2L,23L,3L,7L,5L,13L,2L,29L,2L,11L,5L,7L,4L,25L,2L,7L,5L,19L,2L,25L,2L,13L,11L,7L,2L,29L,3L,13L,5L,11L,2L,23L,4L,17L,5L,7L,2L,43L,2L,7L,10L,13L,4L,25L,2L,11L,5L,23L,2L,35L,2L,7L,11L,11L,4L,25L,2L,23L,7L,7L,2L,41L,4L,7L,5L,17L,2L };
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
public class A120842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120842Inst : IEnumerable<long>
{
public static readonly long[] Value=A120842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120842.Bytes);
public long this[int i]=>Value[i];

public static A120842Inst Instance=new A120842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120843
{
public static readonly long[] Value={ 2L,2L,5L,7L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
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
public class A120843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120843Inst : IEnumerable<long>
{
public static readonly long[] Value=A120843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120843.Bytes);
public long this[int i]=>Value[i];

public static A120843Inst Instance=new A120843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120844
{
public static readonly long[] Value={ 1L,3L,11L,32L,90L,231L,576L,1363L,3141L,7003L,15261L,32468L,67788L,138892L,280103L,556302L,1089991L,2108332L,4030649L,7620671L,14261450L,26431346L,48544170L,88393064L,159654022L,286149924L,509137464L,899603036L,1579014769L };
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
public class A120844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120844Inst : IEnumerable<long>
{
public static readonly long[] Value=A120844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120844.Bytes);
public long this[int i]=>Value[i];

public static A120844Inst Instance=new A120844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120845
{
public static readonly long[] Value={ 2L,10L,23L,50L,117L,300L,823L,2350L,6857L,20240L,60123L,179250L,535597L,1602580L,4799423L,14381750L,43112337L,129271320L,387682723L,1162785850L,3487833077L,10462450460L,31385254023L,94151567550L,282446313817L,847322164000L };
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
public class A120845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120845Inst : IEnumerable<long>
{
public static readonly long[] Value=A120845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120845.Bytes);
public long this[int i]=>Value[i];

public static A120845Inst Instance=new A120845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120846
{
public static readonly long[] Value={ 2L,6L,15L,38L,101L,280L,799L,2322L,6825L,20204L,60083L,179206L,535549L,1602528L,4799367L,14381690L,43112273L,129271252L,387682651L,1162785774L,3487832997L,10462450376L,31385253935L,94151567458L,282446313721L,847322163900L };
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
public class A120846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120846Inst : IEnumerable<long>
{
public static readonly long[] Value=A120846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120846.Bytes);
public long this[int i]=>Value[i];

public static A120846Inst Instance=new A120846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120847
{
public static readonly long[] Value={ 2L,5L,17L,29L,47L,53L,83L,89L,101L,173L,191L,251L,263L,269L,281L,317L,431L,467L,479L,521L,587L,659L,809L,857L,911L,929L,947L,953L,983L,1019L,1091L,1163L,1307L,1439L,1451L,1493L,1559L,1601L,1613L,1667L,1811L,1847L,1871L,1901L,1979L,2027L,2063L,2099L,2207L,2243L };
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
public class A120847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120847Inst : IEnumerable<long>
{
public static readonly long[] Value=A120847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120847.Bytes);
public long this[int i]=>Value[i];

public static A120847Inst Instance=new A120847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120848
{
public static readonly long[] Value={ 2L,4L,11L,32L,93L,270L,787L,2308L,6809L,20186L,60063L,179184L,535525L,1602502L,4799339L,14381660L,43112241L,129271218L,387682615L,1162785736L,3487832957L,10462450334L,31385253891L,94151567412L,282446313673L,847322163850L };
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
public class A120848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120848Inst : IEnumerable<long>
{
public static readonly long[] Value=A120848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120848.Bytes);
public long this[int i]=>Value[i];

public static A120848Inst Instance=new A120848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120849
{
public static readonly long[] Value={ 0L,6L,15L,34L,85L,236L,695L,2094L,6345L,19216L,58075L,175154L,527405L,1586196L,4766655L,14316214L,42981265L,129009176L,387158435L,1161737274L,3485735925L,10458256156L,31376865415L,94134790334L,282412759385L,847255055136L };
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
public class A120849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120849Inst : IEnumerable<long>
{
public static readonly long[] Value=A120849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120849.Bytes);
public long this[int i]=>Value[i];

public static A120849Inst Instance=new A120849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120850
{
public static readonly BigInteger[] Value={ 11L,227L,30071L,BigInteger.Parse("24647906487115793512432470614609487044327490547070674282967249490409801198254927547005559122946385681862066942903289"),BigInteger.Parse("62797802135946735863734268232365323600796854989079318289826397214991489160762431714712874321823048719463864215556568570809157897364620234601356930764612312239892910549558645813243759770009793795858849126389709") };
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
public class A120850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120850Inst Instance=new A120850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120851
{
public static readonly long[] Value={ 193L,29989L,13082761331669749L };
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
public class A120851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120851Inst : IEnumerable<long>
{
public static readonly long[] Value=A120851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120851.Bytes);
public long this[int i]=>Value[i];

public static A120851Inst Instance=new A120851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120852
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,6L,11L,16L,1L,12L,23L,34L,45L,1L,24L,47L,70L,93L,116L,1L,48L,95L,142L,189L,236L,283L,1L,284L,567L,850L,1133L,1416L,1699L,1982L,1L,1700L,3399L,5098L,6797L,8496L,10195L,11894L,13593L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,8L,15L,22L,29L,36L,43L,50L,57L,64L,71L };
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
public class A120852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120852Inst : IEnumerable<long>
{
public static readonly long[] Value=A120852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120852.Bytes);
public long this[int i]=>Value[i];

public static A120852Inst Instance=new A120852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120853
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,5L,9L,13L,17L,1L,10L,19L,28L,37L,46L,1L,47L,93L,139L,185L,231L,277L,1L,232L,463L,694L,925L,1156L,1387L,1618L,1L,1619L,3237L,4855L,6473L,8091L,9709L,11327L,12945L,1L,12946L,25891L,38836L,51781L,64726L,77671L,90616L,103561L,116506L };
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
public class A120853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120853Inst : IEnumerable<long>
{
public static readonly long[] Value=A120853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120853.Bytes);
public long this[int i]=>Value[i];

public static A120853Inst Instance=new A120853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120854
{
public static readonly long[] Value={ 0L,2L,0L,3L,-2L,0L,2L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,3L,-2L,0L,3L,0L,0L,-2L,0L,0L,0L,0L,3L,0L,0L,-2L,0L,2L,0L,0L,0L,3L,0L,0L,-2L,3L,-2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,3L,-2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,3L,-2L,0L,0L,0L,0L,0L };
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
public class A120854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120854Inst : IEnumerable<long>
{
public static readonly long[] Value=A120854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120854.Bytes);
public long this[int i]=>Value[i];

public static A120854Inst Instance=new A120854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120855
{
public static readonly long[] Value={ 0L,2L,1L,2L,4L,3L,1L,3L,2L,2L,4L,3L,4L,6L,5L,3L,5L,4L,1L,3L,2L,3L,5L,4L,2L,4L,3L,2L,4L,3L,4L,6L,5L,3L,5L,4L,4L,6L,5L,6L,8L,7L,5L,7L,6L,3L,5L,4L,5L,7L,6L,4L,6L,5L,1L,3L,2L,3L,5L,4L,2L,4L,3L,3L,5L,4L,5L,7L,6L,4L,6L,5L,2L,4L,3L,4L,6L,5L,3L,5L,4L,2L,4L,3L,4L,6L,5L,3L,5L,4L,4L,6L,5L,6L,8L,7L,5L,7L,6L,3L,5L,4L,5L,7L,6L };
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
public class A120855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120855Inst : IEnumerable<long>
{
public static readonly long[] Value=A120855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120855.Bytes);
public long this[int i]=>Value[i];

public static A120855Inst Instance=new A120855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120856
{
public static readonly long[] Value={ 2L,3L,7L,11L,29L,53L,103L,191L,311L,331L,709L,1021L,1091L,1597L,3181L,3547L,5449L,8243L,10831L,11621L,13711L,16673L,17579L,18899L,32191L,37217L,62207L,71023L,74441L,87869L,94439L,94789L,96353L,114013L,115499L,171167L,229981L,437389L,457981L };
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
public class A120856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120856Inst : IEnumerable<long>
{
public static readonly long[] Value=A120856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120856.Bytes);
public long this[int i]=>Value[i];

public static A120856Inst Instance=new A120856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120857
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,13L,17L,19L,31L,55L,59L,85L,109L,133L,159L,197L,227L,317L,361L,415L,457L,521L,799L,859L,1073L,1163L,1637L,1691L,1861L,1997L,2053L,2633L,3011L,3167L,3397L,3721L,3833L,5207L,7633L,9199L,11603L,13469L,13549L,14099L,16103L,17483L,17693L,18113L };
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
public class A120857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120857Inst : IEnumerable<long>
{
public static readonly long[] Value=A120857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120857.Bytes);
public long this[int i]=>Value[i];

public static A120857Inst Instance=new A120857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120858
{
public static readonly long[] Value={ 1L,2L,5L,3L,11L,29L,4L,17L,64L,169L,6L,23L,99L,373L,985L,7L,34L,134L,577L,2174L,5741L,8L,40L,198L,781L,3363L,12671L,33461L,9L,46L,233L,1154L,4552L,19601L,73852L,195025L,10L,52L,268L,1358L,6726L,26531L,114243L,430441L,1136689L,12L,58L,303L,1562L };
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
public class A120858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120858Inst : IEnumerable<long>
{
public static readonly long[] Value=A120858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120858.Bytes);
public long this[int i]=>Value[i];

public static A120858Inst Instance=new A120858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120859
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,35L,4L,18L,70L,204L,5L,24L,105L,408L,1189L,7L,30L,140L,612L,2378L,6930L,8L,41L,175L,816L,3567L,13860L,40391L,9L,47L,239L,1020L,4756L,20790L,80782L,235416L,10L,53L,274L,1393L,5945L,27720L,121173L,470832L,1372105L,11L,59L,309L,1597L,8119L };
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
public class A120859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120859Inst : IEnumerable<long>
{
public static readonly long[] Value=A120859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120859.Bytes);
public long this[int i]=>Value[i];

public static A120859Inst Instance=new A120859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120860
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,29L,4L,17L,58L,169L,6L,22L,99L,338L,985L,7L,34L,128L,577L,1970L,5741L,8L,39L,198L,746L,3363L,11482L,33461L,9L,46L,227L,1154L,4348L,19601L,66922L,195025L,11L,51L,268L,1323L,6726L,25342L,114243L,390050L,1136689L,12L,63L,297L,1562L,7711L };
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
public class A120860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120860Inst : IEnumerable<long>
{
public static readonly long[] Value=A120860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120860.Bytes);
public long this[int i]=>Value[i];

public static A120860Inst Instance=new A120860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120861
{
public static readonly long[] Value={ 1L,2L,7L,3L,12L,41L,4L,19L,70L,239L,5L,24L,111L,408L,1393L,6L,31L,140L,647L,2378L,8119L,8L,36L,181L,816L,3771L,13860L,47321L,9L,48L,210L,1055L,4756L,21979L,80782L,275807L,10L,53L,280L,1224L,6149L,27720L,128103L,470832L,1607521L,11L,60L,309L,1632L,7134L };
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
public class A120861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120861Inst : IEnumerable<long>
{
public static readonly long[] Value=A120861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120861.Bytes);
public long this[int i]=>Value[i];

public static A120861Inst Instance=new A120861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120862
{
public static readonly long[] Value={ 1L,2L,10L,3L,20L,109L,4L,30L,218L,1189L,5L,43L,327L,2378L,12970L,6L,53L,469L,3567L,25940L,141481L,7L,63L,578L,5116L,38910L,282962L,1543321L,8L,76L,687L,6305L,55807L };
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
public class A120862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120862Inst : IEnumerable<long>
{
public static readonly long[] Value=A120862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120862.Bytes);
public long this[int i]=>Value[i];

public static A120862Inst Instance=new A120862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120863
{
public static readonly long[] Value={ 1L,2L,13L,3L,23L,142L,4L,33L,251L,1549L,5L,46L,360L,2738L,16897L,6L,56L,502L,3927L,29867L,184318L,7L,66L,611L,5476L,42837L };
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
public class A120863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120863Inst : IEnumerable<long>
{
public static readonly long[] Value=A120863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120863.Bytes);
public long this[int i]=>Value[i];

public static A120863Inst Instance=new A120863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120864
{
public static readonly long[] Value={ 2L,3L,2L,12L,11L,8L,3L,23L,18L,11L,2L,32L,23L,12L,50L,39L,26L,11L,59L,44L,27L,8L,66L,47L,26L,3L,71L,48L,23L,99L,74L,47L,18L,104L,75L,44L,11L,107L,74L,39L,2L,108L,71L,32L,146L,107L,66L,23L,147L,104L,59L,12L,146L,99L,50L,192L,143L,92L,39L,191L,138L,83L,26L,188L,131L,72L,11L,183L };
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
public class A120864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120864Inst : IEnumerable<long>
{
public static readonly long[] Value=A120864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120864.Bytes);
public long this[int i]=>Value[i];

public static A120864Inst Instance=new A120864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120865
{
public static readonly long[] Value={ 1L,4L,9L,1L,6L,13L,22L,4L,13L,24L,37L,9L,22L,37L,1L,16L,33L,52L,6L,25L,46L,69L,13L,36L,61L,88L,22L,49L,78L,4L,33L,64L,97L,13L,46L,81L,118L,24L,61L,100L,141L,37L,78L,121L,9L,52L,97L,144L,22L,69L,118L,169L,37L,88L,141L,1L,54L,109L,166L,16L,73L,132L,193L,33L,94L,157L,222L,52L };
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
public class A120865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120865Inst : IEnumerable<long>
{
public static readonly long[] Value=A120865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120865.Bytes);
public long this[int i]=>Value[i];

public static A120865Inst Instance=new A120865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120866
{
public static readonly long[] Value={ 1L,4L,9L,16L,4L,11L,20L,31L,5L,16L,29L,44L,4L,19L,36L,55L,1L,20L,41L,64L,89L,19L,44L,71L,100L,16L,45L,76L,109L,11L,44L,79L,116L,4L,41L,80L,121L,164L,36L,79L,124L,171L,29L,76L,125L,176L,20L,71L,124L,179L,9L,64L,121L,180L,241L,55L,116L,179L,244L,44L,109L,176L,245L,31L,100L };
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
public class A120866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120866Inst : IEnumerable<long>
{
public static readonly long[] Value=A120866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120866.Bytes);
public long this[int i]=>Value[i];

public static A120866Inst Instance=new A120866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120867
{
public static readonly long[] Value={ 4L,5L,4L,1L,19L,16L,11L,4L,36L,29L,20L,9L,55L,44L,31L,16L,76L,61L,44L,25L,4L,80L,59L,36L,11L,101L,76L,49L,20L,124L,95L,64L,31L,149L,116L,81L,44L,5L,139L,100L,59L,16L,164L,121L,76L,29L,191L,144L,95L,44L,220L,169L,116L,61L,4L,196L,139L,80L,19L,225L,164L,101L,36L,256L,191L };
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
public class A120867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120867Inst : IEnumerable<long>
{
public static readonly long[] Value=A120867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120867.Bytes);
public long this[int i]=>Value[i];

public static A120867Inst Instance=new A120867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120868
{
public static readonly long[] Value={ 1L,4L,1L,5L,11L,4L,11L,1L,9L,19L,5L,16L,29L,11L,25L,4L,19L,36L,11L,29L,1L,20L,41L,9L,31L,55L,19L,44L,5L,31L,59L,16L,45L,76L,29L,61L,11L,44L,79L,25L,61L,4L,41L,80L,19L,59L,101L,36L,79L,11L,55L,101L,29L,76L,1L,49L,99L,20L,71L,124L,41L,95L,9L,64L,121L,31L,89L,149L,55L,116L,19L,81L,145L };
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
public class A120868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120868Inst : IEnumerable<long>
{
public static readonly long[] Value=A120868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120868.Bytes);
public long this[int i]=>Value[i];

public static A120868Inst Instance=new A120868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120869
{
public static readonly long[] Value={ 1L,4L,9L,3L,9L,17L,3L,12L,23L,1L,13L,27L,43L,12L,29L,48L,9L,29L,51L,4L,27L,52L,79L,23L,51L,81L,17L,48L,81L,9L,43L,79L,117L,36L,75L,116L,27L,69L,113L,16L,61L,108L,3L,51L,101L,153L,39L,92L,147L,25L,81L,139L,9L,68L,129L,192L,53L,117L,183L,36L,103L,172L,17L,87L,159L,233L,69L,144L };
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
public class A120869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120869Inst : IEnumerable<long>
{
public static readonly long[] Value=A120869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120869.Bytes);
public long this[int i]=>Value[i];

public static A120869Inst Instance=new A120869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120870
{
public static readonly long[] Value={ 3L,3L,1L,12L,9L,4L,23L,17L,9L,36L,27L,16L,3L,39L,25L,9L,53L,36L,17L,69L,49L,27L,3L,64L,39L,12L,81L,53L,23L,100L,69L,36L,1L,87L,51L,13L,107L,68L,27L,129L,87L,43L,153L,108L,61L,12L,131L,81L,29L,156L,103L,48L,183L,127L,69L,9L,153L,92L,29L,181L,117L,51L,211L,144L,75L,4L,173L,101L };
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
public class A120870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120870Inst : IEnumerable<long>
{
public static readonly long[] Value=A120870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120870.Bytes);
public long this[int i]=>Value[i];

public static A120870Inst Instance=new A120870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120871
{
public static readonly long[] Value={ 1L,4L,2L,7L,8L,17L,7L,18L,17L,32L,14L,31L,9L,28L,23L,46L,16L,41L,34L,63L,25L,56L,14L,47L,36L,73L,23L,62L,49L };
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
public class A120871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120871Inst : IEnumerable<long>
{
public static readonly long[] Value=A120871.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120871.Bytes);
public long this[int i]=>Value[i];

public static A120871Inst Instance=new A120871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120872
{
public static readonly long[] Value={ 2L,1L,7L,4L,14L,9L,16L,7L,25L,14L,23L,8L,34L,17L,47L,28L,41L,18L };
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
public class A120872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120872Inst : IEnumerable<long>
{
public static readonly long[] Value=A120872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120872.Bytes);
public long this[int i]=>Value[i];

public static A120872Inst Instance=new A120872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120873
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,2L,5L,6L,3L,7L,8L,1L,9L,4L,10L,11L,2L,12L,5L,13L,14L,6L,15L,16L,3L,17L,7L,18L,19L,8L,20L,21L,1L,22L,9L,23L,24L,4L,25L,10L,26L,27L,11L,28L,29L,2L,30L,12L,31L,32L,5L,33L,13L,34L,35L,14L,36L,37L,6L,38L,15L,39L,40L,16L,41L,42L,3L,43L,17L,44L,45L,7L,46L,18L,47L,48L,19L,49L };
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
public class A120873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120873Inst : IEnumerable<long>
{
public static readonly long[] Value=A120873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120873.Bytes);
public long this[int i]=>Value[i];

public static A120873Inst Instance=new A120873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120874
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,5L,1L,6L,7L,3L,8L,9L,4L,10L,2L,11L,12L,5L,13L,1L,14L,15L,6L,16L,17L,7L,18L,3L,19L,20L,8L,21L,22L,9L,23L,4L,24L,25L,10L,26L,2L,27L,28L,11L,29L,30L,12L,31L,5L,32L,33L,13L,34L,1L,35L,36L,14L,37L,38L,15L,39L,6L,40L,41L,16L,42L,43L,17L,44L,7L,45L,46L,18L,47L,3L,48L,49L,19L };
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
public class A120874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120874Inst : IEnumerable<long>
{
public static readonly long[] Value=A120874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120874.Bytes);
public long this[int i]=>Value[i];

public static A120874Inst Instance=new A120874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120875
{
public static readonly long[] Value={ 14L,34L,142L,322L,898L,1762L,3598L,5182L,10402L,11662L,19042L,22498L,32398L,36862L,39202L,51982L,57598L,72898L,79522L,97342L,121102L,176398L,186622L,213442L,272482L,324898L,359998L,381922L,412162L,435598L,656098L,675682L,685582L,736162L };
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
public class A120875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120875Inst : IEnumerable<long>
{
public static readonly long[] Value=A120875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120875.Bytes);
public long this[int i]=>Value[i];

public static A120875Inst Instance=new A120875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120876
{
public static readonly long[] Value={ 7L,17L,71L,161L,449L,881L,1799L,2591L,5201L,5831L,9521L,11249L,16199L,18431L,19601L,25991L,28799L,36449L,39761L,48671L,60551L,88199L,93311L,106721L,136241L,162449L,179999L,190961L,206081L,217799L,328049L,337841L,342791L,368081L,388961L,520199L,532511L,551249L,563921L };
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
public class A120876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120876Inst : IEnumerable<long>
{
public static readonly long[] Value=A120876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120876.Bytes);
public long this[int i]=>Value[i];

public static A120876Inst Instance=new A120876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120877
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,6L,7L,2L,4L,2L,4L,2L,4L,2L,4L,3L,12L,12L,12L,12L,12L,13L,2L,2L,5L,10L,23L,2L,3L,15L,2L,7L,18L,12L,12L,14L,32L,16L,31L,2L,6L,6L,9L,20L,13L,7L,13L,2L,2L,6L,6L,7L,17L,6L,6L,8L,2L,6L,3L,16L,19L,9L,32L,16L,33L,9L,45L,10L,3L,19L,5L,16L,20L,20L,35L,4L,8L,2L,3L,17L,19L,17L,19L,22L,35L };
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
public class A120877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120877Inst : IEnumerable<long>
{
public static readonly long[] Value=A120877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120877.Bytes);
public long this[int i]=>Value[i];

public static A120877Inst Instance=new A120877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120878
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,12L,18L,25L,27L,31L,33L,37L,39L,43L,45L,49L,52L,64L,76L,88L,100L,112L,125L,127L,129L,134L,144L,167L,169L,172L,187L,189L,196L,214L,226L,238L,252L,284L,300L,331L,333L,339L,345L,354L,374L,387L,394L,407L,409L,411L,417L,423L,430L,447L,453L,459L,467L,469L };
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
public class A120878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120878Inst : IEnumerable<long>
{
public static readonly long[] Value=A120878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120878.Bytes);
public long this[int i]=>Value[i];

public static A120878Inst Instance=new A120878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120879
{
public static readonly long[] Value={ 1L,3L,2L,3L,9L,6L,2L,6L,4L,3L,9L,6L,9L,27L,18L,6L,18L,12L,2L,6L,4L,6L,18L,12L,4L,12L,8L,3L,9L,6L,9L,27L,18L,6L,18L,12L,9L,27L,18L,27L,81L,54L,18L,54L,36L,6L,18L,12L,18L,54L,36L,12L,36L,24L,2L,6L,4L,6L,18L,12L,4L,12L,8L,6L,18L,12L,18L,54L,36L,12L,36L,24L,4L,12L,8L,12L,36L,24L,8L,24L,16L,3L,9L };
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
public class A120879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120879Inst : IEnumerable<long>
{
public static readonly long[] Value=A120879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120879.Bytes);
public long this[int i]=>Value[i];

public static A120879Inst Instance=new A120879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120880
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,4L,2L,4L,8L,4L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,4L,2L,4L,8L,4L,2L,4L,2L,4L,8L,4L,8L,16L,8L,4L,8L,4L,2L,4L,2L,4L,8L,4L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,4L,2L,4L,8L,4L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,4L,2L,4L,8L,4L,2L,4L,2L,4L,8L,4L,8L,16L,8L,4L,8L,4L,2L,4L,2L,4L,8L,4L };
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
public class A120880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120880Inst : IEnumerable<long>
{
public static readonly long[] Value=A120880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120880.Bytes);
public long this[int i]=>Value[i];

public static A120880Inst Instance=new A120880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120881
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,2L,3L,2L,2L,2L,2L,1L,1L,4L,4L,4L,4L,5L,4L,3L,3L,5L,6L,5L,7L,8L,8L,3L,3L,7L,7L,6L,6L,8L,8L,7L,6L,9L,9L,6L,6L,7L,9L,8L,8L,11L,12L,12L,12L,13L,13L,14L,13L,15L,14L,13L,13L,11L,11L,10L,11L,16L,16L,12L,12L,13L,13L,10L,10L,15L,15L,14L,15L,16L,16L,13L,13L,17L };
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
public class A120881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120881Inst : IEnumerable<long>
{
public static readonly long[] Value=A120881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120881.Bytes);
public long this[int i]=>Value[i];

public static A120881Inst Instance=new A120881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120882
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,6L,7L,6L,6L,8L,9L,10L,11L,13L,14L,12L,13L,14L,15L,15L,17L,19L,20L,19L,19L,21L,20L,20L,21L,27L,28L,25L,26L,28L,29L,28L,29L,31L,33L,31L,32L,36L,37L,37L,36L,38L,39L,37L,37L,38L,39L,39L,40L,40L,42L,41L,43L,45L,46L,49L,50L,52L,52L,48L,49L,54L,55L,55L,56L,60L,61L,57L,58L };
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
public class A120882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120882Inst : IEnumerable<long>
{
public static readonly long[] Value=A120882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120882.Bytes);
public long this[int i]=>Value[i];

public static A120882Inst Instance=new A120882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120883
{
public static readonly long[] Value={ 0L,1L,3L,8L,13L,20L,28L,39L,52L,64L,79L,96L,112L,135L,154L,179L,203L,228L,255L,281L,316L,349L,382L,416L,451L,494L,532L,573L,618L,661L,707L,756L,807L,859L,910L,963L,1015L,1076L,1137L,1198L,1256L,1321L,1386L,1452L,1523L,1594L,1667L,1737L,1808L,1889L,1965L,2046L,2123L };
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
public class A120883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120883Inst : IEnumerable<long>
{
public static readonly long[] Value=A120883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120883.Bytes);
public long this[int i]=>Value[i];

public static A120883Inst Instance=new A120883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120884
{
public static readonly long[] Value={ 1L,4L,17L,35L,69L,114L,184L,272L,389L,528L,702L,901L,1166L,1442L,1791L,2157L,2584L,3058L,3596L,4194L,4878L,5590L,6388L,7232L,8219L,9228L,10339L,11512L,12776L,14138L,15600L,17172L,18865L,20621L,22493L,24420L,26559L,28768L,31109L,33512L,36117L,38781L };
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
public class A120884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120884Inst : IEnumerable<long>
{
public static readonly long[] Value=A120884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120884.Bytes);
public long this[int i]=>Value[i];

public static A120884Inst Instance=new A120884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120885
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,2L,1L,5L,3L,2L,2L,1L,6L,3L,2L,2L,2L,1L,7L,4L,3L,2L,2L,2L,1L,8L,4L,3L,2L,2L,2L,2L,1L,9L,5L,3L,3L,2L,2L,2L,2L,1L,10L,5L,4L,3L,2L,2L,2L,2L,2L,1L,11L,6L,4L,3L,3L,2L,2L,2L,2L,2L,1L,12L,6L,4L,3L,3L,2L,2L,2L,2L,2L,2L,1L };
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
public class A120885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120885Inst : IEnumerable<long>
{
public static readonly long[] Value=A120885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120885.Bytes);
public long this[int i]=>Value[i];

public static A120885Inst Instance=new A120885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120886
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,4L,4L,3L,2L,4L,4L,5L,5L,7L,8L,6L,6L,8L,8L,9L,9L,11L,11L,11L,10L,12L,10L,10L,10L,15L,15L,12L,13L,15L,15L,14L,14L,16L,16L,15L,15L,22L,22L,22L,22L,24L,24L,22L,21L,22L,23L,23L,23L,24L,24L,22L,22L,24L,24L,27L,27L,29L,27L,23L,23L,28L,28L,28L,29L,34L,34L,31L,31L,33L,32L,32L };
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
public class A120886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120886Inst : IEnumerable<long>
{
public static readonly long[] Value=A120886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120886.Bytes);
public long this[int i]=>Value[i];

public static A120886Inst Instance=new A120886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120887
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,3L,4L,6L,8L,7L,8L,8L,9L,8L,8L,11L,12L,11L,12L,12L,13L,12L,13L,14L,16L,15L,18L,19L,20L,16L,17L,21L,21L,20L,21L,23L,24L,23L,24L,26L,27L,21L,22L,23L,24L,23L,24L,27L,29L,29L,29L,30L,31L,31L,32L,35L,36L,35L,36L,34L,35L,34L,37L,42L,43L,39L,40L,41L,41L,37L,38L,42L,43L,42L };
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
public class A120887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120887Inst : IEnumerable<long>
{
public static readonly long[] Value=A120887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120887.Bytes);
public long this[int i]=>Value[i];

public static A120887Inst Instance=new A120887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120888
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A120888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120888Inst : IEnumerable<long>
{
public static readonly long[] Value=A120888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120888.Bytes);
public long this[int i]=>Value[i];

public static A120888Inst Instance=new A120888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120889
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,2L,1L,1L,2L,3L,2L,1L,2L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,2L,1L,2L,1L,1L };
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
public class A120889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120889Inst : IEnumerable<long>
{
public static readonly long[] Value=A120889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120889.Bytes);
public long this[int i]=>Value[i];

public static A120889Inst Instance=new A120889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120890
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,15L,17L,19L,21L,21L,23L,25L,27L,29L,31L,33L,33L,35L,35L,37L,39L,39L,41L,43L,45L,45L,47L,49L,51L,51L,53L,55L,55L,57L,57L,59L,61L,63L,63L,65L,65L,67L,69L,69L,71L,73L,75L,75L,77L,77L,79L,81L,83L,85L,85L,87L,87L,89L,91L,91L,93L,93L,95L,95L,97L,99L,99L,101L,103L };
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
public class A120890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120890Inst : IEnumerable<long>
{
public static readonly long[] Value=A120890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120890.Bytes);
public long this[int i]=>Value[i];

public static A120890Inst Instance=new A120890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120891
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,1L,4L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,4L,1L,1L,2L,2L };
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
public class A120891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120891Inst : IEnumerable<long>
{
public static readonly long[] Value=A120891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120891.Bytes);
public long this[int i]=>Value[i];

public static A120891Inst Instance=new A120891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120892
{
public static readonly long[] Value={ 1L,0L,3L,8L,33L,120L,451L,1680L,6273L,23408L,87363L,326040L,1216801L,4541160L,16947843L,63250208L,236052993L,880961760L,3287794051L,12270214440L,45793063713L,170902040408L,637815097923L,2380358351280L,8883618307201L };
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
public class A120892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120892Inst : IEnumerable<long>
{
public static readonly long[] Value=A120892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120892.Bytes);
public long this[int i]=>Value[i];

public static A120892Inst Instance=new A120892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120893
{
public static readonly long[] Value={ 1L,1L,5L,17L,65L,241L,901L,3361L,12545L,46817L,174725L,652081L,2433601L,9082321L,33895685L,126500417L,472105985L,1761923521L,6575588101L,24540428881L,91586127425L,341804080817L,1275630195845L,4760716702561L,17767236614401L };
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
public class A120893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120893Inst : IEnumerable<long>
{
public static readonly long[] Value=A120893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120893.Bytes);
public long this[int i]=>Value[i];

public static A120893Inst Instance=new A120893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120894
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,2L,1L,2L,5L,7L,6L,5L,3L,2L,5L,12L,18L,18L,14L,10L,10L,7L,5L,12L,30L,48L,50L,42L,34L,27L,22L,24L,17L,12L,30L,78L,128L,140L,126L,103L,83L,73L,63L,53L,59L,42L,30L,78L,206L,346L,394L,369L,312L,259L,219L,189L,175L,154L,131L,150L,108L,78L,206L,552L,946L,1109L };
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
public class A120894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120894Inst : IEnumerable<long>
{
public static readonly long[] Value=A120894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120894.Bytes);
public long this[int i]=>Value[i];

public static A120894Inst Instance=new A120894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120895
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,30L,78L,206L,552L,1498L,4105L,11340L,31541L,88237L,248076L,700478L,1985397L,5646129L,16104378L,46056513L,132031176L,379315946L,1091890772L,3148736064L,9095091878L,26310816944L,76219704957L,221085782559L };
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
public class A120895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120895Inst : IEnumerable<long>
{
public static readonly long[] Value=A120895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120895.Bytes);
public long this[int i]=>Value[i];

public static A120895Inst Instance=new A120895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120896
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,27L,73L,189L,518L,1413L,3857L,10707L,29804L,83365L,234665L,662654L,1878059L,5341302L,15231940L,43552610L,124829236L,358537455L,1031835260L,2974872009L,8590929683L,24847042484L,71964879243L,208704926659L };
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
public class A120896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120896Inst : IEnumerable<long>
{
public static readonly long[] Value=A120896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120896.Bytes);
public long this[int i]=>Value[i];

public static A120896Inst Instance=new A120896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120897
{
public static readonly long[] Value={ 1L,3L,10L,33L,106L,336L,1056L,3296L,10234L,31648L,97551L,299888L,919865L,2816291L,8608712L,26278538L,80120533L,244022331L,742525242L,2257527861L,6858558246L,20822959508L,63181453350L,191601205342L,580749971840L,1759465640586L };
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
public class A120897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120897Inst : IEnumerable<long>
{
public static readonly long[] Value=A120897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120897.Bytes);
public long this[int i]=>Value[i];

public static A120897Inst Instance=new A120897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120898
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,6L,5L,2L,5L,16L,22L,18L,14L,12L,5L,16L,54L,78L,72L,58L,43L,38L,37L,16L,54L,186L,282L,280L,231L,182L,156L,128L,123L,124L,54L,186L,654L,1030L,1073L,924L,751L,622L,535L,498L,425L,418L,426L,186L,654L,2338L,3787L,4100L,3672L,3048L,2530L,2190L,1956L,1766L };
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
public class A120898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120898Inst : IEnumerable<long>
{
public static readonly long[] Value=A120898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120898.Bytes);
public long this[int i]=>Value[i];

public static A120898Inst Instance=new A120898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120899
{
public static readonly long[] Value={ 1L,2L,5L,16L,54L,186L,654L,2338L,8463L,30938L,114022L,423096L,1579049L,5922512L,22309350L,84354388L,320020227L,1217689680L,4645693038L,17766596202L,68092473570L,261486788434L,1005962436536L,3876412305114L,14960183283203L };
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
public class A120899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120899Inst : IEnumerable<long>
{
public static readonly long[] Value=A120899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120899.Bytes);
public long this[int i]=>Value[i];

public static A120899Inst Instance=new A120899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120900
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,62L,209L,722L,2539L,9054L,32654L,118876L,436171L,1611067L,5984943L,22344455L,83786875L,315397144L,1191324649L,4513742858L,17149228138L,65318912291L,249356597492L,953902701488L,3656057618727L,14037222220896L };
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
public class A120900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120900Inst : IEnumerable<long>
{
public static readonly long[] Value=A120900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120900.Bytes);
public long this[int i]=>Value[i];

public static A120900Inst Instance=new A120900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120901
{
public static readonly long[] Value={ 1L,1L,5L,14L,43L,156L,535L,1956L,7175L,26418L,98375L,367176L,1378022L,5193625L,19641164L,74535167L,283651169L,1082274210L,4139129734L,15863315213L,60913982404L,234317240601L,902804442380L,3483620505111L,13460665855850L };
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
public class A120901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120901Inst : IEnumerable<long>
{
public static readonly long[] Value=A120901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120901.Bytes);
public long this[int i]=>Value[i];

public static A120901Inst Instance=new A120901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120902
{
public static readonly long[] Value={ 1L,5L,23L,103L,450L,1932L,8196L,34468L,143997L,598463L,2476936L,10216818L,42023225L,172436363L,706132290L,2886574198L,11781962631L,48025519977L,195530083266L,795241236228L,3231290822280L,13118557603984L,53218706064038L };
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
public class A120902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120902Inst : IEnumerable<long>
{
public static readonly long[] Value=A120902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120902.Bytes);
public long this[int i]=>Value[i];

public static A120902Inst Instance=new A120902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120903
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,1L,7L,-3L,3L,1L,-61L,28L,-6L,4L,1L,751L,-305L,70L,-10L,5L,1L,-11821L,4506L,-915L,140L,-15L,6L,1L,226927L,-82747L,15771L,-2135L,245L,-21L,7L,1L,-5142061L,1815416L,-330988L,42056L,-4270L,392L,-28L,8L,1L,134341711L,-46278549L,8169372L,-992964L,94626L,-7686L,588L,-36L,9L,1L,-3975839341L,1343417110L };
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
public class A120903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120903Inst : IEnumerable<long>
{
public static readonly long[] Value=A120903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120903.Bytes);
public long this[int i]=>Value[i];

public static A120903Inst Instance=new A120903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120904
{
public static readonly long[] Value={ 169L,635L,723L,791L,2697L,3057L,3067L,3073L,3079L,3089L,3099L,3167L,3183L,3193L,3303L,3371L,3427L,11419L,11435L,11451L,11461L,11529L,11555L,12973L,12989L,13051L,13057L,13067L,13109L,13135L,13155L,13161L,13171L,13187L,13863L,14077L,14329L,14355L };
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
public class A120904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120904Inst : IEnumerable<long>
{
public static readonly long[] Value=A120904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120904.Bytes);
public long this[int i]=>Value[i];

public static A120904Inst Instance=new A120904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120905
{
public static readonly BigInteger[] Value={ 1L,-3L,-7L,-527L,164833L,-98248054847L,BigInteger.Parse("-3977703802948722503807"),BigInteger.Parse("-510456831154766758152181998159655209453904127") };
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
public class A120905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120905Inst Instance=new A120905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120906
{
public static readonly long[] Value={ 1L,3L,6L,3L,10L,16L,1L,15L,51L,15L,21L,126L,90L,6L,28L,266L,357L,77L,1L,36L,504L,1107L,504L,36L,45L,882L,2907L,2304L,414L,9L,55L,1452L,6765L,8350L,2850L,210L,1L,66L,2277L,14355L,25653L,14355L,2277L,66L,78L,3432L,28314L,69576L,58278L,16236L,1221L,12L,91L,5005L };
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
public class A120906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120906Inst : IEnumerable<long>
{
public static readonly long[] Value=A120906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120906.Bytes);
public long this[int i]=>Value[i];

public static A120906Inst Instance=new A120906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120907
{
public static readonly long[] Value={ 1L,3L,6L,2L,1L,10L,10L,7L,15L,30L,31L,4L,1L,21L,70L,105L,36L,11L,28L,140L,294L,184L,76L,6L,1L,36L,252L,714L,696L,396L,78L,15L,45L,420L,1554L,2160L,1666L,566L,141L,8L,1L,55L,660L,3102L,5808L,5918L,2990L,995L,136L,19L,66L,990L,5775L,13992L,18348L,12746L,5615L,1280L,226L };
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
public class A120907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120907Inst : IEnumerable<long>
{
public static readonly long[] Value=A120907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120907.Bytes);
public long this[int i]=>Value[i];

public static A120907Inst Instance=new A120907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120908
{
public static readonly long[] Value={ 0L,4L,24L,108L,432L,1620L,5832L,20412L,69984L,236196L,787320L,2598156L,8503056L,27634932L,89282088L,286978140L,918330048L,2927177028L,9298091736L,29443957164L,92980917360L,292889889684L,920511081864L,2887057484028L };
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
public class A120908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120908Inst : IEnumerable<long>
{
public static readonly long[] Value=A120908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120908.Bytes);
public long this[int i]=>Value[i];

public static A120908Inst Instance=new A120908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120909
{
public static readonly long[] Value={ 3L,3L,6L,3L,12L,12L,3L,18L,36L,24L,3L,24L,72L,96L,48L,3L,30L,120L,240L,240L,96L,3L,36L,180L,480L,720L,576L,192L,3L,42L,252L,840L,1680L,2016L,1344L,384L,3L,48L,336L,1344L,3360L,5376L,5376L,3072L,768L,3L,54L,432L,2016L,6048L,12096L,16128L,13824L,6912L,1536L,3L,60L };
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
public class A120909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120909Inst : IEnumerable<long>
{
public static readonly long[] Value=A120909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120909.Bytes);
public long this[int i]=>Value[i];

public static A120909Inst Instance=new A120909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120910
{
public static readonly long[] Value={ 3L,6L,3L,12L,12L,3L,24L,36L,18L,3L,48L,96L,72L,24L,3L,96L,240L,240L,120L,30L,3L,192L,576L,720L,480L,180L,36L,3L,384L,1344L,2016L,1680L,840L,252L,42L,3L,768L,3072L,5376L,5376L,3360L,1344L,336L,48L,3L,1536L,6912L,13824L,16128L,12096L,6048L,2016L,432L,54L,3L,3072L };
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
public class A120910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120910Inst : IEnumerable<long>
{
public static readonly long[] Value=A120910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120910.Bytes);
public long this[int i]=>Value[i];

public static A120910Inst Instance=new A120910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120911
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,8L,7L,9L,15L,12L,11L,13L,14L,21L,18L,17L,16L,19L,20L,28L,24L,23L,22L,25L,26L,27L,36L,32L,30L,31L,29L,33L,34L,35L,45L,40L,39L,38L,37L,41L,42L,43L,44L,55L,50L,48L,47L,49L,46L,51L,52L,53L,54L,66L,60L,58L,57L,59L,56L,61L,62L,63L,64L,65L,78L,72L,70L,69L,68L,71L };
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
public class A120911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120911Inst : IEnumerable<long>
{
public static readonly long[] Value=A120911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120911.Bytes);
public long this[int i]=>Value[i];

public static A120911Inst Instance=new A120911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120912
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,9L,8L,10L,7L,13L,12L,14L,15L,11L,19L,18L,17L,20L,21L,16L,25L,24L,23L,26L,27L,28L,22L,33L,31L,32L,30L,34L,35L,36L,29L,41L,40L,39L,38L,42L,43L,44L,45L,37L,51L,49L,48L,50L,47L,52L,53L,54L,55L,46L,61L,59L,58L,60L,57L,62L,63L,64L,65L,66L,56L,73L,71L,70L,69L,72L,68L };
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
public class A120912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120912Inst : IEnumerable<long>
{
public static readonly long[] Value=A120912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120912.Bytes);
public long this[int i]=>Value[i];

public static A120912Inst Instance=new A120912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120913
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,8L,9L,7L,15L,13L,12L,14L,11L,21L,18L,17L,19L,20L,16L,28L,25L,24L,23L,26L,27L,22L,36L,32L,31L,30L,33L,34L,35L,29L,45L,41L,39L,40L,38L,42L,43L,44L,37L,55L,50L,49L,48L,47L,51L,52L,53L,54L,46L,66L,61L,59L,58L,60L,57L,62L,63L,64L,65L,56L,78L,72L,70L,69L,71L,68L };
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
public class A120913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120913Inst : IEnumerable<long>
{
public static readonly long[] Value=A120913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120913.Bytes);
public long this[int i]=>Value[i];

public static A120913Inst Instance=new A120913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120914
{
public static readonly long[] Value={ 1L,4L,4L,4L,20L,36L,32L,16L,20L,116L,256L,288L,212L,144L,80L,116L,720L,1776L,2388L,2144L,1504L,1012L,784L,464L,720L,4656L,12372L,18800L,19632L,15604L,10848L,7648L,5712L,4736L,2880L,4656L,30996L,86912L,144320L,169332L,151792L,113456L,79696L,58176L };
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
public class A120914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120914Inst : IEnumerable<long>
{
public static readonly long[] Value=A120914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120914.Bytes);
public long this[int i]=>Value[i];

public static A120914Inst Instance=new A120914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120915
{
public static readonly long[] Value={ 1L,4L,20L,116L,720L,4656L,30996L,210896L,1459536L,10239796L,72651184L,520328112L,3756512912L,27307671040L,199705789248L,1468209751856L,10844681408064L,80437588353600L,598867568439828L,4473784063109904L,33524058847464912L };
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
public class A120915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120915Inst : IEnumerable<long>
{
public static readonly long[] Value=A120915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120915.Bytes);
public long this[int i]=>Value[i];

public static A120915Inst Instance=new A120915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120916
{
public static readonly long[] Value={ 1L,2L,8L,42L,244L,1504L,9656L,63856L,431872L,2972778L,20756036L,146627648L,1046060836L,7525452296L,54530660832L,397628393728L,2915496099136L,21481907631872L,158975372309176L,1181109256858096L,8806197969093184L };
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
public class A120916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120916Inst : IEnumerable<long>
{
public static readonly long[] Value=A120916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120916.Bytes);
public long this[int i]=>Value[i];

public static A120916Inst Instance=new A120916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120917
{
public static readonly long[] Value={ 1L,4L,32L,212L,1504L,10848L,79696L,596160L,4520000L,34673940L,268538048L,2096374656L,16475970896L,130234435648L,1034568731408L,8254368150320L,66112337392256L,531345216883584L,4283682906179728L,34632004320564416L };
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
public class A120917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120917Inst : IEnumerable<long>
{
public static readonly long[] Value=A120917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120917.Bytes);
public long this[int i]=>Value[i];

public static A120917Inst Instance=new A120917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120918
{
public static readonly long[] Value={ 1L,12L,124L,1212L,11512L,107544L,994236L,9128024L,83400856L,759387964L,6896903064L,62519804504L,565914425336L,5116780986152L,46223426993576L,417279346904792L,3764890593799336L,33953608251139560L,306100904240342268L };
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
public class A120918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120918Inst : IEnumerable<long>
{
public static readonly long[] Value=A120918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120918.Bytes);
public long this[int i]=>Value[i];

public static A120918Inst Instance=new A120918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120919
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,12L,19L,18L,15L,10L,3L,12L,55L,111L,138L,128L,96L,66L,55L,39L,12L,55L,276L,636L,930L,1005L,876L,669L,498L,360L,263L,240L,177L,55L,276L,1464L,3666L,5979L,7317L,7242L,6138L,4737L,3506L,2607L,2046L,1569L,1212L,1170L,883L,276L,1464L,8058L,21369L,37716L };
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
public class A120919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120919Inst : IEnumerable<long>
{
public static readonly long[] Value=A120919.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120919.Bytes);
public long this[int i]=>Value[i];

public static A120919Inst Instance=new A120919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120920
{
public static readonly long[] Value={ 1L,3L,12L,55L,276L,1464L,8058L,45543L,262626L,1538607L,9130446L,54761628L,331403447L,2021021082L,12407102937L,76611488305L,475493441604L,2964664310319L,18560063203353L,116621922800283L,735236268006654L };
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
public class A120920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120920Inst : IEnumerable<long>
{
public static readonly long[] Value=A120920.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120920.Bytes);
public long this[int i]=>Value[i];

public static A120920Inst Instance=new A120920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120921
{
public static readonly long[] Value={ 1L,1L,3L,12L,56L,283L,1503L,8262L,46591L,267984L,1565949L,9269559L,55465035L,334919996L,2038268620L,12489068727L,76980573203L,476994419698L,2969444848029L,18563305700106L,116485903375761L,733457500802353L };
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
public class A120921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120921Inst : IEnumerable<long>
{
public static readonly long[] Value=A120921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120921.Bytes);
public long this[int i]=>Value[i];

public static A120921Inst Instance=new A120921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120922
{
public static readonly long[] Value={ 1L,3L,18L,128L,876L,6138L,43373L,307857L,2194731L,15698743L,112614054L,809905638L,5838361138L,42178611879L,305340946455L,2214760026120L,16094665727934L,117171115942752L,854506665035841L,6242259681316251L,45674776431331398L };
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
public class A120922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120922Inst : IEnumerable<long>
{
public static readonly long[] Value=A120922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120922.Bytes);
public long this[int i]=>Value[i];

public static A120922Inst Instance=new A120922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120923
{
public static readonly long[] Value={ 1L,10L,89L,755L,6261L,51276L,416802L,3371901L,27192291L,218814309L,1758106311L,14110481670L,113160495179L,906973579067L,7266174714391L,58193602100496L,465947698757267L,3730070760926851L,29856161486307842L,238947353750059666L };
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
public class A120923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120923Inst : IEnumerable<long>
{
public static readonly long[] Value=A120923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120923.Bytes);
public long this[int i]=>Value[i];

public static A120923Inst Instance=new A120923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120924
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,13L,12L,2L,33L,36L,12L,83L,108L,48L,4L,209L,316L,172L,32L,527L,904L,588L,160L,8L,1329L,2548L,1932L,672L,80L,3351L,7104L,6140L,2592L,480L,16L,8449L,19628L,19020L,9440L,2320L,192L,21303L,53816L,57756L,32896L,10000L,1344L,32L,53713L,146596L };
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
public class A120924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120924Inst : IEnumerable<long>
{
public static readonly long[] Value=A120924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120924.Bytes);
public long this[int i]=>Value[i];

public static A120924Inst Instance=new A120924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120925
{
public static readonly long[] Value={ 1L,2L,5L,13L,33L,83L,209L,527L,1329L,3351L,8449L,21303L,53713L,135431L,341473L,860983L,2170865L,5473575L,13800961L,34797463L,87737617L,221219847L,557779233L,1406373239L,3546000945L,8940814823L,22543189057L,56839939415L,143315069777L };
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
public class A120925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120925Inst : IEnumerable<long>
{
public static readonly long[] Value=A120925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120925.Bytes);
public long this[int i]=>Value[i];

public static A120925Inst Instance=new A120925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120926
{
public static readonly long[] Value={ 1L,4L,16L,60L,216L,756L,2592L,8748L,29160L,96228L,314928L,1023516L,3306744L,10628820L,34012224L,108413964L,344373768L,1090516932L,3443737680L,10847773692L,34093003032L,106928054964L,334731302496L,1046035320300L,3263630199336L,10167463313316L,31632108085872L };
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
public class A120926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120926Inst : IEnumerable<long>
{
public static readonly long[] Value=A120926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120926.Bytes);
public long this[int i]=>Value[i];

public static A120926Inst Instance=new A120926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120927
{
public static readonly long[] Value={ 4L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L };
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
public class A120927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120927Inst : IEnumerable<long>
{
public static readonly long[] Value=A120927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120927.Bytes);
public long this[int i]=>Value[i];

public static A120927Inst Instance=new A120927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120928
{
public static readonly BigInteger[] Value={ 2L,8L,44L,280L,2040L,16800L,154560L,1572480L,17539200L,212889600L,2794176000L,39437798400L,595718323200L,9589612032000L,163895187456000L,2964061900800000L,56554301067264000L,1135354270482432000L,BigInteger.Parse("23923536413736960000"),BigInteger.Parse("527939735774330880000") };
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
public class A120928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120928Inst Instance=new A120928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120929
{
public static readonly BigInteger[] Value={ 1L,2L,18L,19701L,4294986997L,298023228171940122L,BigInteger.Parse("10314424798788558774343889178"),BigInteger.Parse("256923577521069192513410265783009965210785"),BigInteger.Parse("6277101735386681020759366944276858929512621227473999723681") };
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
public class A120929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120929Inst Instance=new A120929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120930
{
public static readonly long[] Value={ 6L,17L,4L,17L,76L,32L,14L,209L,55L,261L,15L,19L,51L,23L,42L,23L,40L,19L,53L,54L,43L,51L,81L,159L,31L,55L,30L,53L,34L,266L,33L,54L,70L,39L,77L,38L,174L,43L,146L,141L,114L,83L,230L,51L,53L,47L,75L,85L,80L,61L,82L,321L,58L,80L,113L,61L,68L,59L,93L,342L,90L,183L,228L,75L,87L,97L };
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
public class A120930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120930Inst : IEnumerable<long>
{
public static readonly long[] Value=A120930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120930.Bytes);
public long this[int i]=>Value[i];

public static A120930Inst Instance=new A120930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120931
{
public static readonly long[] Value={ 8L,40L,5L,22L,123L,33L,17L,1744L,116L,323L,27L,53L,104L,70L,49L,41L,86L,21L,90L,79L,84L,54L,300L,382L,86L,78L,37L,75L,44L,427L,72L,85L,92L,65L,202L,61L,1331L,66L,156L,366L,319L,205L,1165L,118L,199L,148L,295L,491L,263L,64L,477L,3327L,194L,163L,296L,210L,180L,69L,148L };
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
public class A120931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120931Inst : IEnumerable<long>
{
public static readonly long[] Value=A120931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120931.Bytes);
public long this[int i]=>Value[i];

public static A120931Inst Instance=new A120931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120932
{
public static readonly long[] Value={ 9L,41L,6L,25L,132L,41L,20L,1745L,120L,372L,29L,54L,108L,71L,58L,44L,89L,28L,96L,87L,88L,67L,302L,391L,88L,87L,46L,84L,53L,459L,76L,93L,105L,72L,206L,69L,1332L,75L,191L,373L,324L,210L,1168L,123L,201L,151L,297L,492L,266L,85L,478L,3328L,197L,171L,302L,213L,185L,90L,162L };
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
public class A120932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120932Inst : IEnumerable<long>
{
public static readonly long[] Value=A120932.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120932.Bytes);
public long this[int i]=>Value[i];

public static A120932Inst Instance=new A120932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120933
{
public static readonly long[] Value={ 2L,1L,3L,2L,2L,4L,4L,4L,3L,5L,8L,8L,6L,4L,6L,16L,16L,12L,8L,5L,7L,32L,32L,24L,16L,10L,6L,8L,64L,64L,48L,32L,20L,12L,7L,9L,128L,128L,96L,64L,40L,24L,14L,8L,10L,256L,256L,192L,128L,80L,48L,28L,16L,9L,11L,512L,512L,384L,256L,160L,96L,56L,32L,18L,10L,12L,1024L,1024L,768L,512L,320L };
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
public class A120933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120933Inst : IEnumerable<long>
{
public static readonly long[] Value=A120933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120933.Bytes);
public long this[int i]=>Value[i];

public static A120933Inst Instance=new A120933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120934
{
public static readonly long[] Value={ 2L,11L,457L,3251L,165701L,10526557L,495233351L,196039655873L,10687033762033L,79006533276941L,4313367040646743L,1740318019946551931L };
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
public class A120934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120934Inst : IEnumerable<long>
{
public static readonly long[] Value=A120934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120934.Bytes);
public long this[int i]=>Value[i];

public static A120934Inst Instance=new A120934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120935
{
public static readonly long[] Value={ 2L,13L,463L,3259L,165713L,10526573L,495233371L,196039655899L,10687033762063L,79006533276973L,4313367040646779L,1740318019946551973L };
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
public class A120935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120935Inst : IEnumerable<long>
{
public static readonly long[] Value=A120935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120935.Bytes);
public long this[int i]=>Value[i];

public static A120935Inst Instance=new A120935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120936
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,2L,2L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L };
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
public class A120936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120936Inst : IEnumerable<long>
{
public static readonly long[] Value=A120936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120936.Bytes);
public long this[int i]=>Value[i];

public static A120936Inst Instance=new A120936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120937
{
public static readonly long[] Value={ 3L,5L,23L,53L,211L,211L,211L,1847L,2179L,2179L,3967L,16033L,16033L,24281L,24281L,24281L,38501L,38501L,38501L,38501L,38501L,58831L,203713L,206699L,206699L,413353L,413353L,413353L,1272749L,1272749L,1272749L,1272749L,2198981L,2198981L,2198981L };
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
public class A120937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120937Inst : IEnumerable<long>
{
public static readonly long[] Value=A120937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120937.Bytes);
public long this[int i]=>Value[i];

public static A120937Inst Instance=new A120937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120938
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,13L,26L,52L,65L,130L,143L,273L,416L,426L,569L,1138L,1707L,3414L,3983L,7966L,11949L,13087L,26174L,38123L,76246L,152492L,190615L,381230L,571845L,1143690L,1181813L,2325503L,4651006L,9302012L,11627515L,20929527L,32557042L,65114084L };
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
public class A120938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120938Inst : IEnumerable<long>
{
public static readonly long[] Value=A120938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120938.Bytes);
public long this[int i]=>Value[i];

public static A120938Inst Instance=new A120938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120939
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,14L,23L,46L,92L,115L,230L,345L,690L,1035L,1127L,2254L,4508L,5635L,11270L,12397L,12627L,25254L,25268L,37665L,62933L,100598L,201196L,264129L,528258L,591191L,1182382L,1773573L,2955955L,5911910L,7685483L,15370966L,30741932L,38427415L };
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
public class A120939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120939Inst : IEnumerable<long>
{
public static readonly long[] Value=A120939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120939.Bytes);
public long this[int i]=>Value[i];

public static A120939Inst Instance=new A120939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120940
{
public static readonly long[] Value={ 0L,1L,3L,6L,14L,26L,52L,95L,177L,318L,572L,1012L,1784L,3117L,5423L,9382L,16170L,27758L,47500L,81035L,137885L,234046L,396408L,670056L,1130544L,1904281L,3202587L,5378310L,9020102L,15109058L,25279012L,42248567L,70537929L,117657342L,196076468L,326485852L };
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
public class A120940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120940Inst : IEnumerable<long>
{
public static readonly long[] Value=A120940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120940.Bytes);
public long this[int i]=>Value[i];

public static A120940Inst Instance=new A120940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}