using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244282
{
public static readonly long[] Value={ 23L,37L,53L,73L,113L,131L,137L,173L,179L,197L,311L,313L,317L,373L,379L,419L,431L,479L,613L,617L,619L,673L,719L,797L,971L,1013L,1019L,1031L,1097L,1277L,1373L,1499L,1571L,1733L,1811L,1997L,2113L,2239L,2293L,2719L,3079L,3137L,3313L,3373L,3491L,3499L,3593L,3673L,4211L };
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
public class A244282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244282Inst : IEnumerable<long>
{
public static readonly long[] Value=A244282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244282.Bytes);
public long this[int i]=>Value[i];

public static A244282Inst Instance=new A244282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244283
{
public static readonly long[] Value={ 10L,11L,14L,19L,40L,41L,44L,49L,90L,91L,94L,99L,164L,364L,649L,816L,1000L,1001L,1004L,1009L,1441L,1961L,2256L,4000L,4001L,4004L,4009L,4841L,6256L,7841L,9000L,9001L,9004L,9009L,20256L,30256L,31369L,40961L,46241L,51849L,54761L,60841L,73969L,79216L,90256L,94096L };
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
public class A244283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244283Inst : IEnumerable<long>
{
public static readonly long[] Value=A244283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244283.Bytes);
public long this[int i]=>Value[i];

public static A244283Inst Instance=new A244283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244284
{
public static readonly long[] Value={ 1L,6L,84L,1168L,20502L,525796L,18939708L,802444170L,38934305898L,2170312156170L };
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
public class A244284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244284Inst : IEnumerable<long>
{
public static readonly long[] Value=A244284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244284.Bytes);
public long this[int i]=>Value[i];

public static A244284Inst Instance=new A244284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244285
{
public static readonly long[] Value={ 2L,4L,9L,9L,6L,1L,6L,1L,1L,2L,9L,3L,6L,2L,9L,8L,2L,7L,4L,9L };
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
public class A244285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244285Inst : IEnumerable<long>
{
public static readonly long[] Value=A244285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244285.Bytes);
public long this[int i]=>Value[i];

public static A244285Inst Instance=new A244285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244286
{
public static readonly long[] Value={ 66L,374L,464L,550L,646L,648L,666L,828L,2847L,5566L,6468L,6666L,8283L,19142L,37398L,46463L,46464L,46560L,55550L,55660L,64646L,66666L,82029L,373758L,374374L,464464L,464640L,550550L,555500L,646646L,648648L,648912L,666666L,737374L,737484L,823170L,828289L,828291L };
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
public class A244286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244286Inst : IEnumerable<long>
{
public static readonly long[] Value=A244286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244286.Bytes);
public long this[int i]=>Value[i];

public static A244286Inst Instance=new A244286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244287
{
public static readonly long[] Value={ 11L,19L,22L,28L,33L,37L,44L,46L,55L,64L,73L,82L,91L,111L,157L,222L,333L,444L,555L,1111L,1919L,2222L,2828L,3333L,3737L,4444L,4646L,5555L,6464L,7373L,8282L,9191L,11111L,22222L,33333L,44444L,55555L,111111L,157157L,191919L,222222L,282828L,333333L,373737L,444444L };
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
public class A244287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244287Inst : IEnumerable<long>
{
public static readonly long[] Value=A244287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244287.Bytes);
public long this[int i]=>Value[i];

public static A244287Inst Instance=new A244287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244288
{
public static readonly BigInteger[] Value={ 1L,5L,57L,1084L,29003L,999717L,42125233L,2096106904L,120194547233L,7799803041491L,564856080384900L,45146219773912540L,3946445378386791157L,BigInteger.Parse("374482268128153003615"),BigInteger.Parse("38330653031858936914329"),BigInteger.Parse("4209191997519328986666624") };
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
public class A244288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244288Inst Instance=new A244288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244289
{
public static readonly long[] Value={ 20L,120L,132L,325L,2213L,4544L,5911L,7071L,7889L,8046L,8297L,9819L,59658L,60772L,64002L,71483L,80717L,95846L,101555L,104195L,109579L,113393L,119894L,130485L,142010L,152556L,152829L,159994L,166038L,168012L,191190L,193622L,201631L,205929L,1098933L,1106171L };
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
public class A244289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244289Inst : IEnumerable<long>
{
public static readonly long[] Value=A244289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244289.Bytes);
public long this[int i]=>Value[i];

public static A244289Inst Instance=new A244289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244290
{
public static readonly long[] Value={ 5L,2L,2L,53L,5L,173L,2L,17L,2L,29L,13L,5L,1697L,53L,2L,73L,13L,5L,37L,2L,389L,733L,2753L,89L,17L,1093L,773L,13L,397L,1789L,2L,41L,821L,53L,5L,29L,193L,281L,6257L,173L,2L,149L,593L,701L,5L,1289L,157L,5L,7993L,13L,2213L,449L,877L,2L,61L,37L,389L,17L,5L,24061L };
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
public class A244290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244290Inst : IEnumerable<long>
{
public static readonly long[] Value=A244290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244290.Bytes);
public long this[int i]=>Value[i];

public static A244290Inst Instance=new A244290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244291
{
public static readonly long[] Value={ 1L,4L,13L,24L,33L,37L,52L,61L,69L,73L,88L,97L,109L,121L,132L,141L,148L,157L,169L,177L,181L,184L,193L,213L,229L,241L,244L,249L,253L,276L,277L,292L,312L,313L,321L,337L,349L,373L,376L,388L,393L,397L,409L,421L,429L,433L,436L,457L,472L,481L,484L,501L,517L,529L,537L };
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
public class A244291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244291Inst : IEnumerable<long>
{
public static readonly long[] Value=A244291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244291.Bytes);
public long this[int i]=>Value[i];

public static A244291Inst Instance=new A244291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244292
{
public static readonly long[] Value={ 2L,9L,9L,0L,4L,7L,0L,3L,9L,9L,3L,7L,1L,9L,0L,4L,7L,9L,8L,7L,7L,8L,2L,7L,5L,1L,6L,9L,4L,2L,0L,6L,3L,1L,0L,3L,9L,8L,8L,5L,3L,7L,7L,6L,9L,9L,9L,3L,0L,1L,0L,9L,3L,5L,5L,0L,5L,9L,0L,3L,6L,9L,2L,3L,2L,2L,5L,4L,0L,6L,1L,0L,2L,1L,1L,9L,8L,6L,7L,9L,5L,6L,8L,7L,1L,6L,5L,8L,1L,9L,7L,5L,6L,4L,8L,1L,1L,0L,1L,1L };
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
public class A244292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244292Inst : IEnumerable<long>
{
public static readonly long[] Value=A244292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244292.Bytes);
public long this[int i]=>Value[i];

public static A244292Inst Instance=new A244292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244293
{
public static readonly long[] Value={ 6L,6L,7L,2L,5L,3L,8L,2L,2L,7L,2L,3L,1L,3L,2L,8L,4L,9L,3L,5L,3L,5L,8L,2L,4L,8L,0L,5L,9L,1L,8L,8L,4L,4L,6L,4L,8L,3L,7L,5L,6L,8L,4L,6L,8L,9L,7L,3L,6L,7L,1L,8L,9L,8L,3L,6L,8L,5L,0L,1L,8L,0L,2L,4L,1L,5L,4L,1L,8L,6L,4L,8L,5L,5L,3L,9L,0L,4L,1L,5L,7L,7L,0L,9L,7L,9L,7L,3L,9L,9L,6L,5L,5L,5L,6L,9L,3L,6L,9L,5L,3L,2L };
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
public class A244293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244293Inst : IEnumerable<long>
{
public static readonly long[] Value=A244293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244293.Bytes);
public long this[int i]=>Value[i];

public static A244293Inst Instance=new A244293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244294
{
public static readonly long[] Value={ 56290L,110172L,127202L,377050L,469555L,775074L,929251L,2249530L,2249531L,2995058L,2995059L,4011471L,4011472L,4469958L,4778861L,4825822L,4825823L,4876245L,4881979L,4901245L };
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
public class A244294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244294Inst : IEnumerable<long>
{
public static readonly long[] Value=A244294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244294.Bytes);
public long this[int i]=>Value[i];

public static A244294Inst Instance=new A244294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244295
{
public static readonly long[] Value={ 2L,3L,14L,14L,69L,97L,251L,671L,1847L,2111L,12869L,33461L,58343L,189045L,841125L,2207347L,6651215L,12781755L,73096191L,308508927L,904926489L,1727792245L,7638794959L,44017642189L,177969495449L,522668483639L,1662245807549L,4496811662189L,32142974215379L };
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
public class A244295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244295Inst : IEnumerable<long>
{
public static readonly long[] Value=A244295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244295.Bytes);
public long this[int i]=>Value[i];

public static A244295Inst Instance=new A244295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244296
{
public static readonly long[] Value={ 3L,6L,35L,71L,295L,751L,2326L,6524L,22309L,55992L,190282L,577410L,1951421L,5414977L,19405654L,64615030L,238446543L,726141375L,2682369977L,9475513873L,41043824531L,138540753071L,524631248766L,1902172512592L,8404692901429L,35025078519164L,148160349275671L };
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
public class A244296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244296Inst : IEnumerable<long>
{
public static readonly long[] Value=A244296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244296.Bytes);
public long this[int i]=>Value[i];

public static A244296Inst Instance=new A244296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244297
{
public static readonly long[] Value={ 4L,10L,69L,195L,929L,3044L,11824L,40985L,158079L,539876L,2065087L,7272937L,27923757L,101194930L,381940222L,1429135919L,5607176733L,21323561733L,84260636527L,325309822037L,1337034045619L,5421586411034L,22509005469068L,92412147570641L,390023528935516L };
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
public class A244297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244297Inst : IEnumerable<long>
{
public static readonly long[] Value=A244297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244297.Bytes);
public long this[int i]=>Value[i];

public static A244297Inst Instance=new A244297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244298
{
public static readonly long[] Value={ 5L,15L,119L,421L,2254L,8999L,40349L,166817L,737829L,3008774L,13186593L,54944783L,238422808L,1010671048L,4395831546L,18821162274L,82799233661L,359711480525L,1599420076729L,7030074945271L,31626819884986L,141486845119777L,646988113794544L,2940338763342920L };
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
public class A244298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244298Inst : IEnumerable<long>
{
public static readonly long[] Value=A244298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244298.Bytes);
public long this[int i]=>Value[i];

public static A244298Inst Instance=new A244298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244299
{
public static readonly long[] Value={ 6L,21L,188L,791L,4696L,21614L,109745L,513421L,2557358L,11885545L,58291639L,275421640L,1342532532L,6411950652L,31310737486L,151220406569L,742729520457L,3625802212441L,17956348335989L,88575381634494L,442565032597013L,2207206278880826L,11138577085071310L };
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
public class A244299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244299Inst : IEnumerable<long>
{
public static readonly long[] Value=A244299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244299.Bytes);
public long this[int i]=>Value[i];

public static A244299Inst Instance=new A244299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244300
{
public static readonly long[] Value={ 7L,28L,279L,1354L,8823L,45553L,256192L,1328368L,7272035L,37498159L,201732490L,1052038304L,5628260010L,29642509180L,158744001098L,844461334762L,4549886593291L,24435491901926L,132677029062176L,719558882421952L,3940213225673584L,21584248413514700L };
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
public class A244300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244300Inst : IEnumerable<long>
{
public static readonly long[] Value=A244300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244300.Bytes);
public long this[int i]=>Value[i];

public static A244300Inst Instance=new A244300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244301
{
public static readonly long[] Value={ 8L,36L,395L,2166L,15365L,87515L,537860L,3043387L,18079805L,101484440L,590719670L,3340021038L,19305133044L,110029379692L,636377579038L,3658493392345L,21277586564634L,123462793881974L,723417146721998L,4238255849152496L,25044116796884830L,148185594856438664L };
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
public class A244301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244301Inst : IEnumerable<long>
{
public static readonly long[] Value=A244301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244301.Bytes);
public long this[int i]=>Value[i];

public static A244301Inst Instance=new A244301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244302
{
public static readonly long[] Value={ 9L,45L,539L,3290L,25234L,156743L,1042823L,6374389L,40710734L,245996972L,1533537330L,9295148728L,57412881670L,349869872571L,2159393201713L,13252915145611L,82161769477646L,508497521855467L,3174435344149894L,19827435510586970L,124802677329672826L };
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
public class A244302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244302Inst : IEnumerable<long>
{
public static readonly long[] Value=A244302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244302.Bytes);
public long this[int i]=>Value[i];

public static A244302Inst Instance=new A244302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244303
{
public static readonly long[] Value={ 10L,55L,714L,4796L,39544L,265589L,1899137L,12448912L,84901024L,547968340L,3633493460L,23423908430L,153474667719L,991845819899L,6480618983179L,42093506667304L,275840531014103L,1804204772698796L,11893232452570720L,78437868094585319L,521001980260102004L };
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
public class A244303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244303Inst : IEnumerable<long>
{
public static readonly long[] Value=A244303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244303.Bytes);
public long this[int i]=>Value[i];

public static A244303Inst Instance=new A244303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244304
{
public static readonly long[] Value={ 11L,66L,923L,6761L,59631L,430135L,3286934L,22973870L,166443706L,1140859011L,8005160811L,54582972124L,377341672273L,2571480311931L,17687177703846L,120864485062762L,832211596826779L,5716894541334650L,39541329587796481L,273544962791156596L,1904469339140619197L };
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
public class A244304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244304Inst : IEnumerable<long>
{
public static readonly long[] Value=A244304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244304.Bytes);
public long this[int i]=>Value[i];

public static A244304Inst Instance=new A244304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244305
{
public static readonly BigInteger[] Value={ 1L,0L,3L,10L,119L,791L,8823L,87515L,1042823L,12448912L,166443706L,2246438833L,32782857721L,488717384754L,7695520330054L,124248088106249L,2091672883631855L,36107381616662300L,644987804706582806L,11799406380611542654UL,BigInteger.Parse("222235188242044718908"),BigInteger.Parse("4280160250751484220674") };
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
public class A244305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244305Inst Instance=new A244305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244306
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,2L,4L,6L,6L,4L,6L,10L,13L,10L,6L,9L,15L,22L,22L,15L,9L,12L,21L,34L,36L,34L,21L,12L,16L,28L,48L,56L,56L,48L,28L,16L,20L,36L,65L,78L,88L,78L,65L,36L,20L,25L,45L,84L,106L,123L,123L,106L,84L,45L,25L,30L,55L,106L,136L,168L,171L,168L,136L,106L,55L,30L };
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
public class A244306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244306Inst : IEnumerable<long>
{
public static readonly long[] Value=A244306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244306.Bytes);
public long this[int i]=>Value[i];

public static A244306Inst Instance=new A244306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244307
{
public static readonly long[] Value={ 0L,2L,7L,20L,45L,92L,170L,296L,486L,766L,1161L,1708L,2443L,3416L,4676L,6288L,8316L,10842L,13947L,17732L,22297L,27764L,34254L,41912L,50882L,61334L,73437L,87388L,103383L,121648L,142408L,165920L,192440L,222258L,255663L,292980L,334533L,380684L,431794L,488264L };
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
public class A244307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244307Inst : IEnumerable<long>
{
public static readonly long[] Value=A244307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244307.Bytes);
public long this[int i]=>Value[i];

public static A244307Inst Instance=new A244307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244308
{
public static readonly long[] Value={ 754205L,1347541L,1347542L,1347543L,1347544L,1347545L,1692355L,2067412L,2067413L,2067414L,2067415L,2218613L,2809181L,5455635L,6127765L,6127766L,7034825L,7034826L,7194143L,8603331L,8815168L,8815169L,8815170L,8815171L,9072188L };
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
public class A244308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244308Inst : IEnumerable<long>
{
public static readonly long[] Value=A244308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244308.Bytes);
public long this[int i]=>Value[i];

public static A244308Inst Instance=new A244308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244309
{
public static readonly long[] Value={ 0L,0L,0L,4L,18L,100L,448L,2028L,8820L,38148L,163350L,697048L,2965248L,12595048L,53440504L,226608900L,960530634L,4070452764L,17246835648L,73069580980L,309555981900L,1311374255620L,5555264316910L,23532984885744L,99688652356608L,422291386890000L };
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
public class A244309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244309Inst : IEnumerable<long>
{
public static readonly long[] Value=A244309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244309.Bytes);
public long this[int i]=>Value[i];

public static A244309Inst Instance=new A244309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244310
{
public static readonly long[] Value={ 4L,0L,18L,48L,294L,1210L,5508L,23548L,101614L,433200L,1845738L,7840998L,33282564L,141149320L,598366458L,2535856048L,10745092894L,45524786370L,192866785668L,817050731748L,3461224027254L,14662350247600L,62111682111618L,263111844646798L,1114566304573444L };
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
public class A244310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244310Inst : IEnumerable<long>
{
public static readonly long[] Value=A244310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244310.Bytes);
public long this[int i]=>Value[i];

public static A244310Inst Instance=new A244310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244311
{
public static readonly long[] Value={ 13L,19L,31L,37L,79L,109L,113L,139L,193L,317L,331L,911L,991L,1453L,1481L,1669L,1831L,1901L,7127L,7561L,7589L,7687L,9343L,9413L,9811L,10223L,11821L,12889L,13627L,13633L,16979L,17551L,32297L,33529L,34157L,35747L,37409L,39521L,39829L,70957L,71339L,75653L,79633L,90289L,94793L,97583L,99877L };
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
public class A244311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244311Inst : IEnumerable<long>
{
public static readonly long[] Value=A244311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244311.Bytes);
public long this[int i]=>Value[i];

public static A244311Inst Instance=new A244311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244312
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,0L,2L,4L,0L,0L,4L,16L,4L,0L,0L,4L,48L,60L,8L,0L,0L,8L,160L,384L,160L,8L,0L,0L,8L,368L,1952L,2176L,520L,16L,0L,0L,16L,1152L,9648L,18688L,9648L,1152L,16L,0L,0L,16L,2432L,37008L,132640L,141680L,45504L,3568L,32L,0L };
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
public class A244312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244312Inst : IEnumerable<long>
{
public static readonly long[] Value=A244312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244312.Bytes);
public long this[int i]=>Value[i];

public static A244312Inst Instance=new A244312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244313
{
public static readonly long[] Value={ 38L,58L,66L,87L,110L,205L,210L,310L,410L,510L,610L,710L,714L,810L,910L,1010L,2010L,3010L,4010L,5010L,6010L,7010L,8010L,9010L,10010L,20010L,30010L,40010L,50010L,60010L,70010L,80010L,90010L,100010L,200010L,300010L,400010L,500010L,600010L,700010L,800010L,900010L };
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
public class A244313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244313Inst : IEnumerable<long>
{
public static readonly long[] Value=A244313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244313.Bytes);
public long this[int i]=>Value[i];

public static A244313Inst Instance=new A244313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244314
{
public static readonly long[] Value={ 0L,2L,5L,6L,7L,14L,15L,16L,17L,18L,19L,20L,21L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L,157L };
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
public class A244314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244314Inst : IEnumerable<long>
{
public static readonly long[] Value=A244314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244314.Bytes);
public long this[int i]=>Value[i];

public static A244314Inst Instance=new A244314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244315
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,4L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,4L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,2L,3L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,5L };
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
public class A244315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244315Inst : IEnumerable<long>
{
public static readonly long[] Value=A244315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244315.Bytes);
public long this[int i]=>Value[i];

public static A244315Inst Instance=new A244315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244316
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,5L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,5L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,3L,4L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,6L };
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
public class A244316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244316Inst : IEnumerable<long>
{
public static readonly long[] Value=A244316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244316.Bytes);
public long this[int i]=>Value[i];

public static A244316Inst Instance=new A244316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244317
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L };
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
public class A244317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244317Inst : IEnumerable<long>
{
public static readonly long[] Value=A244317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244317.Bytes);
public long this[int i]=>Value[i];

public static A244317Inst Instance=new A244317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244318
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,2L,4L,4L,8L,6L,3L,6L,6L,12L,2L,4L,4L,8L,6L,4L,8L,8L,16L,12L,6L,12L,12L,24L,3L,6L,6L,12L,9L,6L,12L,12L,24L,18L,9L,18L,18L,36L,2L,4L,4L,8L,6L,4L,8L,8L,16L,12L,6L,12L,12L,24L,4L,8L,8L,16L,12L,8L,16L,16L,32L,24L,12L,24L,24L,48L,6L,12L,12L,24L,18L,12L,24L,24L,48L };
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
public class A244318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244318Inst : IEnumerable<long>
{
public static readonly long[] Value=A244318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244318.Bytes);
public long this[int i]=>Value[i];

public static A244318Inst Instance=new A244318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244319
{
public static readonly long[] Value={ 1L,3L,2L,9L,6L,5L,26L,11L,4L,21L,8L,125L,56L,25L,16L,15L,344L,115L,36L,1015L,10L,39L,204L,41L,14L,7L,52L,45L,86L,301L,176L,155L,298L,51L,50L,19L,518L,305L,22L,189L,24L,895L,1376L,49L,28L,825L,1268L,11875L,44L,35L,34L,27L,3186L,6625L,2388L,13L,454L,153L,126L,3191L,476L,131L };
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
public class A244319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244319Inst : IEnumerable<long>
{
public static readonly long[] Value=A244319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244319.Bytes);
public long this[int i]=>Value[i];

public static A244319Inst Instance=new A244319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244320
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,4L,5L,5L,6L,8L,8L,9L,9L,13L,13L,14L,14L,15L,17L,17L,18L,18L,19L,21L,21L,22L,22L,26L,26L,27L,27L,28L,30L,30L,31L,31L,32L,34L,34L,35L,35L,41L,41L,42L,42L,43L,45L,45L,46L,46L,47L,49L,49L,50L,50L,54L,54L,55L,55L,56L,58L,58L,59L,59L,60L,62L,62L,63L,63L,67L,67L,68L,68L,69L };
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
public class A244320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244320Inst : IEnumerable<long>
{
public static readonly long[] Value=A244320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244320.Bytes);
public long this[int i]=>Value[i];

public static A244320Inst Instance=new A244320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244321
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,9L,12L,10L,13L,11L,15L,14L,16L,18L,17L,19L,24L,25L,20L,26L,21L,22L,27L,23L,31L,29L,30L,28L,32L,36L,34L,33L,37L,35L,39L,49L,38L,48L,51L,41L,50L,40L,52L,42L,53L,43L,44L,54L,45L,55L,47L,46L,63L,59L,61L,62L,58L,57L,60L,65L,56L,73L,64L,72L,68L,66L,69L };
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
public class A244321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244321Inst : IEnumerable<long>
{
public static readonly long[] Value=A244321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244321.Bytes);
public long this[int i]=>Value[i];

public static A244321Inst Instance=new A244321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244322
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,9L,11L,13L,10L,12L,15L,14L,16L,18L,17L,19L,22L,24L,25L,27L,20L,21L,23L,26L,31L,29L,30L,28L,32L,35L,34L,37L,33L,36L,40L,38L,45L,43L,47L,49L,50L,52L,55L,54L,41L,39L,44L,42L,46L,48L,51L,53L,64L,61L,60L,57L,62L,58L,59L,56L,66L,63L,69L,71L,68L,70L,75L };
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
public class A244322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244322Inst : IEnumerable<long>
{
public static readonly long[] Value=A244322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244322.Bytes);
public long this[int i]=>Value[i];

public static A244322Inst Instance=new A244322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244323
{
public static readonly long[] Value={ 23L,39L,99L,279L,775L,1271L,3003L,26411L,45059L,53219L,96811L,180063L,538083L,1557987L,2994571L,5394027L,76600323L,78603291L,646326135L,5260930155L,11705029515L,55771437087L,918661840551L,2662267345431L,156054629431431L,1885162669463151L,2739827178329319L,23916267980687775L,343334160580618935L };
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
public class A244323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244323Inst : IEnumerable<long>
{
public static readonly long[] Value=A244323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244323.Bytes);
public long this[int i]=>Value[i];

public static A244323Inst Instance=new A244323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244324
{
public static readonly long[] Value={ 1L,2L,15L,20L,104L,207L,464L,650L,1023L,1952L,2975L,19359L,130304L,147455L,522752L,1207359L,5017599L,8382464L };
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
public class A244324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244324Inst : IEnumerable<long>
{
public static readonly long[] Value=A244324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244324.Bytes);
public long this[int i]=>Value[i];

public static A244324Inst Instance=new A244324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244325
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,15L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,21L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,27L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L };
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
public class A244325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244325Inst : IEnumerable<long>
{
public static readonly long[] Value=A244325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244325.Bytes);
public long this[int i]=>Value[i];

public static A244325Inst Instance=new A244325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244326
{
public static readonly long[] Value={ 36L,48L,60L,72L,84L,90L,96L,108L,120L,132L,144L,156L,168L,180L,192L,210L,216L,240L,252L,264L,270L,280L,288L,300L,312L,324L,330L,336L,360L,378L,384L,390L,396L,408L,420L,432L,450L,456L,468L,480L,504L,510L,528L,540L,552L,560L,570L,576L,588L,600L,612L,624L,630L,648L };
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
public class A244326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244326Inst : IEnumerable<long>
{
public static readonly long[] Value=A244326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244326.Bytes);
public long this[int i]=>Value[i];

public static A244326Inst Instance=new A244326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244327
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,3L,3L,5L,2L,6L,4L,5L,4L,8L,4L,9L,5L,7L,7L,11L,5L,10L,8L,9L,7L,14L,6L,15L,8L,11L,11L,13L,7L,18L,12L,13L,9L,20L,9L,21L,11L,13L,15L,23L,9L,21L,13L,18L,14L,26L,12L,21L,13L,20L,19L,29L,10L,30L,20L,19L,16L,25L,15L,33L,18L,25L,17L,35L,13L,36L };
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
public class A244327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244327Inst : IEnumerable<long>
{
public static readonly long[] Value=A244327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244327.Bytes);
public long this[int i]=>Value[i];

public static A244327Inst Instance=new A244327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244328
{
public static readonly long[] Value={ 0L,0L,3L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A244328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244328Inst : IEnumerable<long>
{
public static readonly long[] Value=A244328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244328.Bytes);
public long this[int i]=>Value[i];

public static A244328Inst Instance=new A244328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244329
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,1L,2L,2L,4L,1L,5L,3L,4L,3L,7L,3L,8L,4L,6L,6L,10L,4L,9L,7L,8L,6L,13L,5L,14L,7L,10L,10L,12L,6L,17L,11L,12L,8L,19L,8L,20L,10L,12L,14L,22L,8L,20L,12L,17L,13L,25L,11L,20L,12L,19L,18L,28L,9L,29L,19L,18L,15L,24L,14L,32L,17L,24L,16L,34L,12L,35L,23L };
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
public class A244329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244329Inst : IEnumerable<long>
{
public static readonly long[] Value=A244329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244329.Bytes);
public long this[int i]=>Value[i];

public static A244329Inst Instance=new A244329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244330
{
public static readonly long[] Value={ 1L,2L,3L,15L,31L,65L,153L,343L,775L,1729L,3735L,8175L,17371L,36447L,76077L,157471L,324801L,669469L,1370903L,2807215L,5728545L,11679949L,23777059L,48348375L,98093505L };
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
public class A244330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244330Inst : IEnumerable<long>
{
public static readonly long[] Value=A244330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244330.Bytes);
public long this[int i]=>Value[i];

public static A244330Inst Instance=new A244330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244331
{
public static readonly long[] Value={ 0L,1L,3L,9L,23L,53L,115L,241L,495L,1005L,2027L,4073L,8167L,16357L,32739L,65505L,131039L,262109L,524251L,1048537L,2097111L,4194261L,8388563L,16777169L };
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
public class A244331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244331Inst : IEnumerable<long>
{
public static readonly long[] Value=A244331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244331.Bytes);
public long this[int i]=>Value[i];

public static A244331Inst Instance=new A244331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244332
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,19L,39L,121L,321L,813L,2063L,4957L,11731L,26329L,59501L,132273L,294475L,644557L,1392933L,2982557L };
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
public class A244332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244332Inst : IEnumerable<long>
{
public static readonly long[] Value=A244332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244332.Bytes);
public long this[int i]=>Value[i];

public static A244332Inst Instance=new A244332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244333
{
public static readonly long[] Value={ 0L,1L,1L,4L,5L,33L,139L,515L,1809L,6181L,20759L,68871L,226333L,738089L,2391459L,7705867L,24711977L,78918957L,251105839L };
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
public class A244333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244333Inst : IEnumerable<long>
{
public static readonly long[] Value=A244333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244333.Bytes);
public long this[int i]=>Value[i];

public static A244333Inst Instance=new A244333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244334
{
public static readonly long[] Value={ 3L,7L,8L,6L,9L,8L,2L,2L,4L,8L,5L,2L,0L,7L,1L,0L,0L,5L,9L,1L,7L,1L,5L,9L,7L,6L,3L,3L,1L,3L,6L,0L,9L,4L,6L,7L,4L,5L,5L,6L,2L,1L,3L,0L,1L,7L,7L,5L,1L,4L,7L,9L,2L,8L,9L,9L,4L,0L,8L,2L,8L,4L,0L,2L,3L,6L,6L,8L,6L,3L,9L,0L,5L,3L,2L,5L,4L,4L,3L,7L,8L,6L,9L,8L,2L,2L,4L,8L,5L,2L,0L,7L,1L,0L,0L,5L,9L,1L,7L };
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
public class A244334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244334Inst : IEnumerable<long>
{
public static readonly long[] Value=A244334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244334.Bytes);
public long this[int i]=>Value[i];

public static A244334Inst Instance=new A244334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244335
{
public static readonly long[] Value={ 4L,3L,7L,9L,8L,4L,5L,9L,8L,4L,7L,1L,0L,2L,7L,1L,6L,5L,3L,0L,0L,9L,7L,7L,4L,2L,5L,3L,7L,7L,8L,6L,3L,4L,6L,9L,8L,1L,2L,5L,9L,9L,5L,0L,1L,7L,0L,1L,4L,3L,5L,3L,9L,0L,9L,1L,0L,1L,1L,7L,7L,3L,7L,5L,3L,4L,9L,9L,5L,7L,2L,1L,7L,6L,0L,9L,2L,7L,7L,4L,8L,7L,8L,3L,6L,2L,9L,1L,8L,7L,9L,7L,0L,8L,8L,6L,1L,4L,2L,9L,9L,7L,8L,6L };
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
public class A244335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244335Inst : IEnumerable<long>
{
public static readonly long[] Value=A244335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244335.Bytes);
public long this[int i]=>Value[i];

public static A244335Inst Instance=new A244335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244336
{
public static readonly long[] Value={ 4L,0L,8L,3L,1L,9L,1L,9L,2L,2L,1L,1L,6L,2L,9L,7L,9L,5L,3L,5L,4L,8L,6L,5L,8L,7L,6L,5L,3L,8L,6L,2L,2L,6L,6L,5L,6L,3L,4L,1L,3L,2L,9L,1L,6L,8L,0L,4L,1L,0L,4L,3L,7L,1L,5L,1L,2L,4L,7L,4L,0L,6L,2L,6L,4L,1L,8L,5L,4L,0L,3L,6L,1L,7L,6L,0L,6L,1L,7L,8L,0L,2L,3L,1L,4L,3L,6L,7L,0L,7L,2L,3L,3L,1L,8L,3L,1L,2L,7L,9L };
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
public class A244336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244336Inst : IEnumerable<long>
{
public static readonly long[] Value=A244336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244336.Bytes);
public long this[int i]=>Value[i];

public static A244336Inst Instance=new A244336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244337
{
public static readonly long[] Value={ 3L,9L,0L,7L,3L,1L,3L,8L,2L,9L,6L,5L,2L,4L,5L,2L,8L,7L,3L,2L,6L,8L,6L,6L,6L,8L,6L,0L,9L,5L,8L,9L,8L,0L,1L,3L,6L,2L,7L,5L,9L,0L,9L,6L,4L,7L,5L,5L,7L,3L,5L,0L,3L,2L,4L,7L,7L,4L,9L,5L,1L,0L,4L,3L,5L,7L,7L,0L,3L,3L,9L,6L,2L,7L,2L,3L,8L,9L,1L,4L,4L,7L,6L,2L,2L,1L,9L,1L,8L,8L,8L,8L,0L,6L,1L,3L,3L,7L,5L,9L,8L,7L,6L };
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
public class A244337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244337Inst : IEnumerable<long>
{
public static readonly long[] Value=A244337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244337.Bytes);
public long this[int i]=>Value[i];

public static A244337Inst Instance=new A244337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244338
{
public static readonly long[] Value={ 3L,7L,9L,0L,2L,2L,6L,0L,4L,4L,0L,1L,1L,3L,7L,9L,4L,2L,3L,9L,4L,4L,8L,4L,1L,0L,2L,6L,1L,1L,7L,2L,7L,4L,6L,3L,0L,6L,5L,1L,9L,9L,4L,0L,3L,1L,6L,9L,5L,5L,5L,8L,8L,2L,9L,8L,3L,5L,5L,6L,9L,1L,5L,7L,1L,0L,8L,7L,7L,9L,9L,1L,6L,7L,6L,5L,2L,8L,0L,6L,3L,9L,6L,3L,5L,9L,3L,5L,9L,2L,0L,2L,6L,9L,0L,3L,0L,4L,8L,8L };
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
public class A244338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244338Inst : IEnumerable<long>
{
public static readonly long[] Value=A244338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244338.Bytes);
public long this[int i]=>Value[i];

public static A244338Inst Instance=new A244338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244339
{
public static readonly long[] Value={ 1L,-4L,6L,-4L,0L,0L,6L,-8L,6L,-4L,0L,0L,0L,-8L,12L,0L,0L,0L,6L,-8L,0L,-8L,0L,0L,6L,-4L,12L,-4L,0L,0L,0L,-8L,6L,0L,0L,0L,0L,-8L,12L,-8L,0L,0L,12L,-8L,0L,0L,0L,0L,0L,-12L,6L,0L,0L,0L,6L,0L,12L,-8L,0L,0L,0L,-8L,12L,-8L,0L,0L,0L,-8L,0L,0L,0L,0L,6L,-8L,12L,-4L,0L };
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
public class A244339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244339Inst : IEnumerable<long>
{
public static readonly long[] Value=A244339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244339.Bytes);
public long this[int i]=>Value[i];

public static A244339Inst Instance=new A244339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244340
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,4L,5L,6L,0L,4L,9L,4L,13L,9L,5L,2L,0L,17L,18L,19L,0L,2L,6L,11L,18L,26L,8L,18L,1L,14L,28L,12L,30L,15L,0L,22L,8L,34L,22L,10L,41L,31L,22L,13L,5L,44L,39L,34L,30L,26L,24L,22L,21L,22L,23L,25L,29L,33L,39L,46L,54L,1L,10L,21L,34L,47L,63L,10L,27L,46L };
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
public class A244340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244340Inst : IEnumerable<long>
{
public static readonly long[] Value=A244340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244340.Bytes);
public long this[int i]=>Value[i];

public static A244340Inst Instance=new A244340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244341
{
public static readonly long[] Value={ 30L,67L,76L,88L,97L,105L,115L,125L,136L,140L,155L,166L,175L,189L,199L,217L,222L,230L,235L,236L,251L,253L,254L,257L,259L,269L,275L,283L,296L,308L,309L,311L,314L,336L,337L,352L,366L,384L,399L,401L,417L,418L,422L,433L,440L,461L,468L,483L,492L,496L,498L,514L };
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
public class A244341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244341Inst : IEnumerable<long>
{
public static readonly long[] Value=A244341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244341.Bytes);
public long this[int i]=>Value[i];

public static A244341Inst Instance=new A244341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244342
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,12L,18L,32L,30L,24L,30L,48L,36L,36L,72L,96L,48L,60L,54L,96L,108L,60L,66L,192L,100L,72L,126L,144L,84L,144L,90L,256L,180L,96L,216L,240L,108L,108L,216L,384L,120L,216L,126L,240L,360L,132L,138L,576L,210L,200L,288L,288L,156L,252L,360L,576L,324L,168L };
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
public class A244342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244342Inst : IEnumerable<long>
{
public static readonly long[] Value=A244342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244342.Bytes);
public long this[int i]=>Value[i];

public static A244342Inst Instance=new A244342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244343
{
public static readonly long[] Value={ 16L,46L,46L,64L,100L,254L,326L,392L,392L,590L,776L,776L,1190L,1520L,1814L,2420L,2624L,3764L,3764L,3764L,4454L,4454L,4892L,5752L,6400L,6400L,7210L,9380L,9524L,11414L,11414L,13190L,13190L,13190L,18272L,18272L,19940L,20414L,20414L,21824L,24614L,24614L,25592L };
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
public class A244343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244343Inst : IEnumerable<long>
{
public static readonly long[] Value=A244343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244343.Bytes);
public long this[int i]=>Value[i];

public static A244343Inst Instance=new A244343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244344
{
public static readonly long[] Value={ 582L,1164L,1746L,2328L,3492L,4656L,5238L,6410L,6984L,9312L,10476L,12820L,13968L,15714L,18624L,20952L,25640L,27936L,31428L,32050L,33838L,37248L,41904L,47142L,51280L,55872L,56454L,62856L,64100L,67676L,74496L,83808L,94284L,102560L,111744L,112908L,125712L,128200L };
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
public class A244344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244344Inst : IEnumerable<long>
{
public static readonly long[] Value=A244344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244344.Bytes);
public long this[int i]=>Value[i];

public static A244344Inst Instance=new A244344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244345
{
public static readonly long[] Value={ 5L,0L,7L,4L,7L,0L,8L,0L,3L,2L,0L,4L,8L,2L,6L,8L,1L,2L,5L,1L,0L,6L,0L,1L,2L,7L,7L,1L,3L,7L,2L,6L,0L,1L,4L,2L,9L,7L,0L,8L,4L,4L,6L,5L,3L,7L,6L,5L,1L,4L,9L,8L,9L,6L,0L,0L,8L,7L,4L,4L,5L,5L,3L,3L,8L,8L,2L,9L,8L,7L,3L,8L,1L,2L,9L,1L,2L,2L,0L,1L,1L,0L,6L,8L,2L,3L,5L,1L,7L,7L,1L,1L,4L,1L,2L,8L,3L,4L,7L,4L,7L,2L,9L,3L };
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
public class A244345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244345Inst : IEnumerable<long>
{
public static readonly long[] Value=A244345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244345.Bytes);
public long this[int i]=>Value[i];

public static A244345Inst Instance=new A244345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244346
{
public static readonly long[] Value={ 4L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L };
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
public class A244346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244346Inst : IEnumerable<long>
{
public static readonly long[] Value=A244346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244346.Bytes);
public long this[int i]=>Value[i];

public static A244346Inst Instance=new A244346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244347
{
public static readonly long[] Value={ 0L,0L,1L,9L,9L,7L,7L,4L,6L,9L,3L,4L,0L,5L,3L,8L,8L,6L,2L,6L,2L,0L,1L,9L,7L,1L,1L,6L,7L,4L,8L,4L,8L,5L,9L,7L,2L,0L,9L,9L,9L,7L,5L,6L,0L,6L,2L,4L,4L,9L,3L,6L,9L,1L,6L,9L,6L,6L,7L,8L,5L,9L,5L,1L,7L,6L,7L,2L,8L,3L,9L,9L,5L,5L,4L,4L,1L,3L,2L,5L,2L,6L,4L,6L,2L,7L,2L,0L,2L,1L,9L,1L,6L,1L,6L,1L,2L,7L,4L,8L,2L,9L,8L,8L,5L,9L };
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
public class A244347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244347Inst : IEnumerable<long>
{
public static readonly long[] Value=A244347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244347.Bytes);
public long this[int i]=>Value[i];

public static A244347Inst Instance=new A244347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244348
{
public static readonly long[] Value={ 162207L,1622070L,3349554L,5109589L,6651446L,7001622L,9589051L,10958905L };
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
public class A244348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244348Inst : IEnumerable<long>
{
public static readonly long[] Value=A244348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244348.Bytes);
public long this[int i]=>Value[i];

public static A244348Inst Instance=new A244348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244349
{
public static readonly long[] Value={ 232272L,254294L,326943L,686574L,1021708L,1251812L,1254205L,1347543L,1562959L,2236112L,2607137L,2682138L,2810880L,2884861L,3041717L,3049727L,3049728L,3159941L,3159942L,3314220L };
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
public class A244349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244349Inst : IEnumerable<long>
{
public static readonly long[] Value=A244349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244349.Bytes);
public long this[int i]=>Value[i];

public static A244349Inst Instance=new A244349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244350
{
public static readonly long[] Value={ 5L,1L,3L,8L,7L,8L,0L,1L,3L,2L,6L,0L,2L,8L,3L,4L,2L,3L,6L,8L,9L,4L,2L,2L,0L,2L,7L,4L,8L,4L,6L,1L,5L,5L,1L,6L,2L,9L,8L,4L,4L,0L,8L,5L,7L,8L,3L,2L,7L,9L,3L,7L,0L,3L,7L,5L,7L,5L,5L,8L,6L,7L,8L,3L,3L,7L,5L,2L,7L,7L,8L,7L,5L,3L,6L,2L,6L,1L,0L,9L,1L,5L,9L,9L,3L,1L,4L,0L,7L,8L,1L,4L,6L,7L,4L,3L,9L,5L,7L,7L,9L,7L,3L };
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
public class A244350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244350Inst : IEnumerable<long>
{
public static readonly long[] Value=A244350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244350.Bytes);
public long this[int i]=>Value[i];

public static A244350Inst Instance=new A244350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244351
{
public static readonly long[] Value={ 84687L,429127L,508122L,1273238L,1570311L,1656045L,2574762L,2847748L,3048732L,3345805L,3849481L,5076399L,5324003L,5338292L,5908351L,6961919L,7639428L,8167823L,8508662L,8994775L,9078721L,9421866L,9936270L,9950261L };
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
public class A244351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244351Inst : IEnumerable<long>
{
public static readonly long[] Value=A244351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244351.Bytes);
public long this[int i]=>Value[i];

public static A244351Inst Instance=new A244351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244352
{
public static readonly BigInteger[] Value={ 0L,0L,4L,100L,1584L,23548L,338100L,4798248L,67750848L,954701400L,13441659268L,189185124940L,2662308356400L,37463104912660L,527155118240244L,7417689205890000L,104375121328998144L,1468671237346368048L,BigInteger.Parse("20665783224031936900"),BigInteger.Parse("290789699203441908148") };
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
public class A244352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244352Inst Instance=new A244352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244353
{
public static readonly long[] Value={ 1L,3L,8L,10L,18L,20L,30L,72L,84L,90L,96L,108L,168L,336L,420L,480L,504L,540L,600L,630L,660L,672L,1080L,1440L,2160L,3360L,3780L,3960L,4200L,4320L,4620L,4680L,9240L,12600L,13860L,18480L,30240L,32760L,36960L,37800L,40320L,41580L,42840L,43680L,65520L,75600L,98280L,131040L,138600L,151200L,163800L,196560L,262080L,327600L,360360L,393120L,415800L,443520L,471240L,480480L,491400L,655200L,831600L,942480L,982800L,997920L };
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
public class A244353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244353Inst : IEnumerable<long>
{
public static readonly long[] Value=A244353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244353.Bytes);
public long this[int i]=>Value[i];

public static A244353Inst Instance=new A244353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244354
{
public static readonly long[] Value={ 1L,7L,2L,9L,1L,5L,0L,6L,9L,0L,3L,0L,6L,4L,4L,9L,2L,6L,9L,1L,8L,8L,6L,6L,8L,3L,4L,4L,3L,0L,1L,0L,3L,7L,1L,4L,9L,0L,2L,0L,0L,6L,7L,1L,1L,5L,9L,2L,8L,3L,9L,2L,2L,5L,6L,4L,6L,0L,6L,8L,0L,8L,4L,8L,2L,9L,4L,8L,1L,0L,6L,3L,1L,6L,3L,1L,5L,6L,3L,9L,9L,8L,8L,7L,3L,2L,4L,4L,0L,0L,9L,0L,1L,8L,3L,5L,8L,9L,5L,1L,8L,2L,2L,5L };
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
public class A244354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244354Inst : IEnumerable<long>
{
public static readonly long[] Value=A244354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244354.Bytes);
public long this[int i]=>Value[i];

public static A244354Inst Instance=new A244354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244355
{
public static readonly long[] Value={ 5L,7L,8L,3L,1L,8L,5L,9L,6L,2L,9L,4L,6L,7L,8L,4L,5L,2L,1L,1L,7L,5L,9L,9L,5L,7L,5L,8L,4L,5L,5L,8L,0L,7L,0L,3L,5L,0L,7L,1L,4L,4L,1L,8L,0L,6L,4L,2L,3L,6L,8L,5L,5L,8L,7L,0L,8L,7L,1L,2L,3L,7L,1L,4L,4L,5L,6L,0L,6L,4L,3L,0L,4L,8L,8L,5L,5L,4L,4L,3L,7L,3L,8L,8L,6L,3L,4L,0L,3L,5L,9L,5L,4L,4L,4L,9L,0L,2L,0L,4L,3L,8L,2L };
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
public class A244355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244355Inst : IEnumerable<long>
{
public static readonly long[] Value=A244355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244355.Bytes);
public long this[int i]=>Value[i];

public static A244355Inst Instance=new A244355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244356
{
public static readonly long[] Value={ 37L,46L,53L,56L,57L,58L,67L,68L,73L,78L,86L,97L,307L,337L,346L,358L,373L,376L,379L,388L,397L,406L,429L,433L,446L,457L,466L,469L,473L,477L,478L,489L,493L,498L,506L,507L,508L,538L,553L,556L,557L,558L,577L,578L,586L,587L,588L,596L,597L,598L,646L,656L,657L,658L,667L,668L,669L };
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
public class A244356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244356Inst : IEnumerable<long>
{
public static readonly long[] Value=A244356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244356.Bytes);
public long this[int i]=>Value[i];

public static A244356Inst Instance=new A244356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244357
{
public static readonly long[] Value={ 56L,57L,67L,477L,506L,507L,556L,557L,577L,586L,587L,596L,597L,656L,657L,667L,668L,697L,757L,758L,778L,787L,788L,857L,858L,866L,867L,868L,877L,897L,956L,957L,976L,977L,978L,4077L,4097L,4457L,4477L,4497L,4657L,4677L,4757L,4857L,4897L,4997L,5056L,5057L,5066L,5067L,5077L,5096L };
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
public class A244357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244357Inst : IEnumerable<long>
{
public static readonly long[] Value=A244357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244357.Bytes);
public long this[int i]=>Value[i];

public static A244357Inst Instance=new A244357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244358
{
public static readonly long[] Value={ 56L,506L,556L,586L,596L,656L,667L,757L,787L,857L,866L,867L,956L,976L,977L,5056L,5066L,5096L,5506L,5666L,5756L,5776L,5876L,5906L,5986L,5996L,6056L,6067L,6506L,6697L,6986L,7057L,7556L,7576L,7597L,7757L,7786L,7787L,7876L,7897L,7906L,7976L,7996L,8066L,8067L,8506L,8596L,8666L,8697L };
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
public class A244358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244358Inst : IEnumerable<long>
{
public static readonly long[] Value=A244358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244358.Bytes);
public long this[int i]=>Value[i];

public static A244358Inst Instance=new A244358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244359
{
public static readonly long[] Value={ 866L,976L,7786L,8066L,8786L,8986L,9976L,70786L,77786L,79976L,80066L,80986L,87866L,89066L,89986L,98786L,99866L,99976L,700786L,707786L,709976L,770786L,778786L,778996L,780866L,788986L,789986L,799786L,799976L,800066L,800986L,809986L,879986L,887986L,888986L,889786L,890066L,890786L,890986L };
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
public class A244359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244359Inst : IEnumerable<long>
{
public static readonly long[] Value=A244359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244359.Bytes);
public long this[int i]=>Value[i];

public static A244359Inst Instance=new A244359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244360
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L,20L,25L,33L,41L,51L,58L,70L,78L,91L,104L,120L,130L,148L,159L,179L,197L,216L,229L,253L,270L,292L,314L,342L };
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
public class A244360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244360Inst : IEnumerable<long>
{
public static readonly long[] Value=A244360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244360.Bytes);
public long this[int i]=>Value[i];

public static A244360Inst Instance=new A244360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244361
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,5L,8L,8L,10L,7L,12L,8L,13L,13L,16L,10L,18L,11L,20L,18L,19L,13L,24L,17L,22L,22L,28L };
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
public class A244361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244361Inst : IEnumerable<long>
{
public static readonly long[] Value=A244361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244361.Bytes);
public long this[int i]=>Value[i];

public static A244361Inst Instance=new A244361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244362
{
public static readonly long[] Value={ 2L,6L,12L,20L,28L,40L,50L,66L,82L,102L,116L,140L,156L,182L,208L,240L,260L,296L,318L,358L,394L,432L,458L,506L,540L,584L,628L,684L };
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
public class A244362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244362Inst : IEnumerable<long>
{
public static readonly long[] Value=A244362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244362.Bytes);
public long this[int i]=>Value[i];

public static A244362Inst Instance=new A244362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244363
{
public static readonly long[] Value={ 2L,4L,6L,8L,8L,12L,10L,16L,16L,20L,14L,24L,16L,26L,26L,32L,20L,36L,22L,40L,36L,38L,26L,48L,34L,44L,44L,56L };
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
public class A244363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244363Inst : IEnumerable<long>
{
public static readonly long[] Value=A244363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244363.Bytes);
public long this[int i]=>Value[i];

public static A244363Inst Instance=new A244363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244364
{
public static readonly long[] Value={ 3L,4L,2L,33L,17L,319L,639L,1279L,2559L,5119L,10239L,20479L,40959L,81919L,163839L,327679L,655359L,1310719L,2621439L,5242879L,10485759L,20971519L,41943039L,83886079L,167772159L,335544319L,671088639L };
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
public class A244364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244364Inst : IEnumerable<long>
{
public static readonly long[] Value=A244364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244364.Bytes);
public long this[int i]=>Value[i];

public static A244364Inst Instance=new A244364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244365
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,17L,19L,19L,23L,23L,29L,31L,31L,37L,37L,41L,41L,43L,47L,43L,47L,53L,47L,53L,53L,59L,59L,61L,67L,61L,67L,71L,73L,67L,71L,73L,71L,73L,79L,83L,73L,79L,83L,79L,83L,89L,83L,89L,89L,97L,97L,101L,103L,107L,101L,103L,107L,109L,113L,103L,107L,109L };
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
public class A244365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244365Inst : IEnumerable<long>
{
public static readonly long[] Value=A244365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244365.Bytes);
public long this[int i]=>Value[i];

public static A244365Inst Instance=new A244365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244366
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,2L,3L,2L,1L,4L,5L,4L,6L,1L,8L,4L,7L,4L,2L,6L,8L,6L,12L,0L,10L,7L,14L,8L,2L,8L,17L,8L,14L,2L,16L,12L,16L,10L,3L,8L,18L,10L,20L,2L,18L,10L,23L,16L,1L,14L,24L,16L,20L,4L,30L,16L,22L,16L,5L,16L,24L,18L,30L,4L,28L,14L,32L,18L,6L,20L,33L,16L,26L,1L };
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
public class A244366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244366Inst : IEnumerable<long>
{
public static readonly long[] Value=A244366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244366.Bytes);
public long this[int i]=>Value[i];

public static A244366Inst Instance=new A244366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244367
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,8L,9L,12L,12L,15L,15L,16L,18L,20L,20L,24L,24L,25L,28L,28L,30L,30L,32L,35L,35L,36L,40L,40L,42L,42L,45L,45L,48L,48L,49L,50L,54L,54L,56L,56L,60L,60L,63L,63L,64L,66L,66L,70L,70L,72L,72L,72L,77L,77L,80L,80L,81L,84L,84L,88L,88L,90L,90L,91L,91L };
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
public class A244367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244367Inst : IEnumerable<long>
{
public static readonly long[] Value=A244367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244367.Bytes);
public long this[int i]=>Value[i];

public static A244367Inst Instance=new A244367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244368
{
public static readonly long[] Value={ 0L,5L,6L,12L,14L,15L,17L,21L,24L,26L,27L,32L,35L,36L,39L,41L,45L,47L,50L,56L,57L,59L,60L,62L,66L,69L,74L,77L,84L,87L,89L,90L,92L,95L,96L,101L,102L,104L,110L,111L,116L,117L,125L,126L,129L,131L,132L,134L,140L,144L,147L,150L,155L,161L,162L,164L,165L,167L,171L,176L,179L,180L,182L,186L,189L,192L,195L,197L,200L,201L,204L,206L,209L,210L,215L,216L,221L,222L,225L,227L,231L,234L,236L,239L,242L,245L,246L,249L,252L,255L,264L,266L,267L,269L,272L,279L,281L,285L,287L,290L,291L,294L,297L,299L,300L };
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
public class A244368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244368Inst : IEnumerable<long>
{
public static readonly long[] Value=A244368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244368.Bytes);
public long this[int i]=>Value[i];

public static A244368Inst Instance=new A244368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244369
{
public static readonly long[] Value={ 101L,787L,34543L,7654567L,345676543L,34567876543L };
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
public class A244369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244369Inst : IEnumerable<long>
{
public static readonly long[] Value=A244369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244369.Bytes);
public long this[int i]=>Value[i];

public static A244369Inst Instance=new A244369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244370
{
public static readonly long[] Value={ 8L,24L,48L,80L,112L,160L,200L,264L,328L,408L,464L,560L,624L,728L,832L,960L,1040L,1184L,1272L,1432L,1576L,1728L,1832L,2024L,2160L,2336L,2512L,2736L };
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
public class A244370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244370Inst : IEnumerable<long>
{
public static readonly long[] Value=A244370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244370.Bytes);
public long this[int i]=>Value[i];

public static A244370Inst Instance=new A244370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244371
{
public static readonly long[] Value={ 8L,16L,24L,32L,32L,48L,40L,64L,64L,80L,56L,96L,64L,104L,104L,128L,80L,144L,88L,160L,144L,152L,104L,192L,136L,176L,176L,224L };
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
public class A244371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244371Inst : IEnumerable<long>
{
public static readonly long[] Value=A244371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244371.Bytes);
public long this[int i]=>Value[i];

public static A244371Inst Instance=new A244371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244372
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,5L,2L,1L,0L,1L,10L,6L,2L,1L,0L,1L,22L,16L,6L,2L,1L,0L,1L,45L,43L,17L,6L,2L,1L,0L,1L,97L,113L,49L,17L,6L,2L,1L,0L,1L,206L,300L,136L,50L,17L,6L,2L,1L,0L,1L,450L,787L,386L,142L,50L,17L,6L,2L,1L,0L,1L,982L,2074L,1081L,409L,143L,50L,17L,6L,2L,1L };
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
public class A244372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244372Inst : IEnumerable<long>
{
public static readonly long[] Value=A244372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244372.Bytes);
public long this[int i]=>Value[i];

public static A244372Inst Instance=new A244372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244373
{
public static readonly long[] Value={ 1L,0L,1L,2L,-1L,4L,3L,4L,15L,-14L,65L,224L,-143L,1824L,1441L,12882L,50959L,-151420L,898979L,5337220L,20799L,188372002L,-733599L,6648401344L,39471457217L,-234341035456L,2785299158305L,24790831385826L,98497628929855L,4377139749257604L,-12158771603059997L };
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
public class A244373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244373Inst : IEnumerable<long>
{
public static readonly long[] Value=A244373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244373.Bytes);
public long this[int i]=>Value[i];

public static A244373Inst Instance=new A244373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244374
{
public static readonly long[] Value={ 5L,37L,53L,157L,173L,233L,257L,277L,353L,373L,401L,593L,613L,653L,733L,769L,977L,1097L,1297L,1433L,1493L,1613L,1753L,1993L,2137L,2161L,2377L,2417L,2677L,2693L,2749L,2797L,3313L,3533L,3637L,3733L,4013L,4133L,4457L,4513L };
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
public class A244374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244374Inst : IEnumerable<long>
{
public static readonly long[] Value=A244374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244374.Bytes);
public long this[int i]=>Value[i];

public static A244374Inst Instance=new A244374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244375
{
public static readonly long[] Value={ 1L,3L,1L,-3L,0L,3L,2L,3L,1L,0L,0L,-3L,2L,6L,0L,-3L,0L,3L,2L,0L,2L,0L,0L,3L,1L,6L,1L,-6L,0L,0L,2L,3L,0L,0L,0L,-3L,2L,6L,2L,0L,0L,6L,2L,0L,0L,0L,0L,-3L,3L,3L,0L,-6L,0L,3L,0L,6L,2L,0L,0L,0L,2L,6L,2L,-3L,0L,0L,2L,0L,0L,0L,0L,3L,2L,6L,1L,-6L,0L,6L,2L,0L,1L,0L,0L };
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
public class A244375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244375Inst : IEnumerable<long>
{
public static readonly long[] Value=A244375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244375.Bytes);
public long this[int i]=>Value[i];

public static A244375Inst Instance=new A244375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244376
{
public static readonly long[] Value={ 1L,2L,10L,40L,47L,55L,62L,121L,137L,152L,167L,201L,233L,278L,290L,293L,313L,333L,370L,382L,430L,452L,460L,506L,546L,555L,613L,625L,642L,675L,705L,711L,752L,767L,793L,797L,831L,835L,837L,872L,878L,891L,906L,917L,923L,978L,985L,1005L,1012L,1017L,1018L,1021L };
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
public class A244376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244376Inst : IEnumerable<long>
{
public static readonly long[] Value=A244376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244376.Bytes);
public long this[int i]=>Value[i];

public static A244376Inst Instance=new A244376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244377
{
public static readonly long[] Value={ 2L,3L,15L,26L,30L,42L,63L,77L,107L,114L,123L,131L,143L,149L,173L,177L,212L,288L,297L,308L,309L,348L,411L,474L,548L,551L,600L,659L,681L,701L,705L,711L,770L,780L,788L,833L,840L,894L,927L,1011L,1016L,1059L,1064L,1082L,1092L,1104L,1178L,1239L,1290L,1400L,1422L };
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
public class A244377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244377Inst : IEnumerable<long>
{
public static readonly long[] Value=A244377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244377.Bytes);
public long this[int i]=>Value[i];

public static A244377Inst Instance=new A244377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244378
{
public static readonly long[] Value={ 2L,12L,34L,50L,72L,104L,172L,180L,198L,202L,240L,252L,254L,272L,300L,338L,348L,374L,494L,498L,504L,578L,640L,648L,652L,702L,728L,804L,832L,848L,892L,950L,1002L,1040L,1060L,1070L,1134L,1158L,1184L,1364L,1378L,1464L,1564L,1598L,1608L,1624L,1630L,1678L,1688L,1704L,1734L };
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
public class A244378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244378Inst : IEnumerable<long>
{
public static readonly long[] Value=A244378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244378.Bytes);
public long this[int i]=>Value[i];

public static A244378Inst Instance=new A244378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244379
{
public static readonly long[] Value={ 2L,30L,56L,122L,216L,246L,248L,318L,552L,846L,948L,1100L,1128L,1148L,1200L,1296L,1308L,1416L,1716L,1812L,1818L,1920L,2040L,2166L,2196L,2210L,2582L,2592L,2672L,2696L,2828L,2862L,2886L,2970L,3150L,3192L,3378L,3396L,3492L,3522L,3626L,3782L,3998L,4040L,4070L };
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
public class A244379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244379Inst : IEnumerable<long>
{
public static readonly long[] Value=A244379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244379.Bytes);
public long this[int i]=>Value[i];

public static A244379Inst Instance=new A244379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244380
{
public static readonly long[] Value={ 48L,136L,172L,198L,222L,388L,718L,802L,844L,966L,1342L,1356L,1488L,1542L,1668L,1708L,1734L,1780L,1956L,2008L,2082L,2316L,2356L,2394L,2422L,2536L,2734L,2844L,2880L,2916L,2974L,2982L,3024L,3120L,3258L,3364L,3562L,3664L,3906L,3930L,4308L,4312L,4554L,4566L };
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
public class A244380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244380Inst : IEnumerable<long>
{
public static readonly long[] Value=A244380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244380.Bytes);
public long this[int i]=>Value[i];

public static A244380Inst Instance=new A244380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244381
{
public static readonly long[] Value={ 6L,2L,7L,8L,3L,4L,2L,6L,7L,6L,8L,7L,2L,1L,3L,1L,6L,8L,2L,8L,3L,8L,3L,0L,5L,6L,6L,2L,9L,2L,4L,8L,8L,6L,8L,7L,6L,4L,5L,1L,8L,7L,3L,4L,2L,4L,3L,4L,9L,3L,9L,4L,3L,4L,3L,4L,3L,8L,4L,3L,5L,1L,5L,1L,9L,7L,3L,6L,0L,9L,1L,2L,2L,1L,9L,4L,9L,0L,6L,3L,6L,6L,6L,5L,7L,2L,2L,9L,8L,4L,2L,7L,8L,6L,8L,1L,5L,0L,2L,2L,7L,9L };
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
public class A244381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244381Inst : IEnumerable<long>
{
public static readonly long[] Value=A244381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244381.Bytes);
public long this[int i]=>Value[i];

public static A244381Inst Instance=new A244381Inst();

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