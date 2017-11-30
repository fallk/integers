using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011570
{
public static readonly long[] Value={ 1L,1048575L,1742343625L,181509070050L,3791262568401L,26585679462804L,82310957214948L,132511015347084L,123272476465204L,71187132291275L,26826851689001L,6833042030178L,1204909218331L,149304004500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011570Inst : IEnumerable<long>
{
public static readonly long[] Value=A011570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011570.Bytes);
public long this[int i]=>Value[i];

public static A011570Inst Instance=new A011570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011569
{
public static readonly long[] Value={ 1L,524287L,580606446L,45232115901L,749206090500L,4306078895384L,11143554045652L,15170932662679L,12011282644725L,5917584964655L,1900842429486L,411016633391L,61068660380L,6302524580L,452329200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011569Inst : IEnumerable<long>
{
public static readonly long[] Value=A011569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011569.Bytes);
public long this[int i]=>Value[i];

public static A011569Inst Instance=new A011569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011568
{
public static readonly long[] Value={ 1L,262143L,193448101L,11259666950L,147589284710L,693081601779L,1492924634839L,1709751003480L,1144614626805L,477297033785L,129413217791L,23466951300L,2892439160L,243577530L,13916778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011568Inst : IEnumerable<long>
{
public static readonly long[] Value=A011568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011568.Bytes);
public long this[int i]=>Value[i];

public static A011568Inst Instance=new A011568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011567
{
public static readonly long[] Value={ 1L,131071L,64439010L,2798806985L,28958095545L,110687251039L,197462483400L,189036065010L,106175395755L,37112163803L,8391004908L,1256328866L,125854638L,8408778L,367200L,9996L,153L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011567Inst : IEnumerable<long>
{
public static readonly long[] Value=A011567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011567.Bytes);
public long this[int i]=>Value[i];

public static A011567Inst Instance=new A011567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011566
{
public static readonly long[] Value={ 1L,65535L,21457825L,694337290L,5652751651L,17505749898L,25708104786L,20415995028L,9528822303L,2758334150L,512060978L,62022324L,4910178L,249900L,7820L,136L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011566Inst : IEnumerable<long>
{
public static readonly long[] Value=A011566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011566.Bytes);
public long this[int i]=>Value[i];

public static A011566Inst Instance=new A011566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011565
{
public static readonly long[] Value={ 1L,32767L,7141686L,171798901L,1096190550L,2734926558L,3281882604L,2141764053L,820784250L,193754990L,28936908L,2757118L,165620L,6020L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011565Inst : IEnumerable<long>
{
public static readonly long[] Value=A011565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011565.Bytes);
public long this[int i]=>Value[i];

public static A011565Inst Instance=new A011565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011564
{
public static readonly long[] Value={ 1L,16383L,2375101L,42355950L,210766920L,420693273L,408741333L,216627840L,67128490L,12662650L,1479478L,106470L,4550L,105L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011564Inst : IEnumerable<long>
{
public static readonly long[] Value=A011564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011564.Bytes);
public long this[int i]=>Value[i];

public static A011564Inst Instance=new A011564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011563
{
public static readonly long[] Value={ 1L,8191L,788970L,10391745L,40075035L,63436373L,49329280L,20912320L,5135130L,752752L,66066L,3367L,91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011563Inst : IEnumerable<long>
{
public static readonly long[] Value=A011563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011563.Bytes);
public long this[int i]=>Value[i];

public static A011563Inst Instance=new A011563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011562
{
public static readonly long[] Value={ 1L,4095L,261625L,2532530L,7508501L,9321312L,5715424L,1899612L,359502L,39325L,2431L,78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011562Inst : IEnumerable<long>
{
public static readonly long[] Value=A011562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011562.Bytes);
public long this[int i]=>Value[i];

public static A011562Inst Instance=new A011562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011561
{
public static readonly long[] Value={ 1L,2047L,86526L,611501L,1379400L,1323652L,627396L,159027L,22275L,1705L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011561Inst : IEnumerable<long>
{
public static readonly long[] Value=A011561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011561.Bytes);
public long this[int i]=>Value[i];

public static A011561Inst Instance=new A011561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011560
{
public static readonly long[] Value={ 1L,1023L,28501L,145750L,246730L,179487L,63987L,11880L,1155L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011560Inst : IEnumerable<long>
{
public static readonly long[] Value=A011560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011560.Bytes);
public long this[int i]=>Value[i];

public static A011560Inst Instance=new A011560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011559
{
public static readonly long[] Value={ 1L,511L,9330L,34105L,42525L,22827L,5880L,750L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011559Inst : IEnumerable<long>
{
public static readonly long[] Value=A011559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011559.Bytes);
public long this[int i]=>Value[i];

public static A011559Inst Instance=new A011559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011558
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011558Inst : IEnumerable<long>
{
public static readonly long[] Value=A011558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011558.Bytes);
public long this[int i]=>Value[i];

public static A011558Inst Instance=new A011558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011557
{
public static readonly long[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100000000L,1000000000L,10000000000L,100000000000L,1000000000000L,10000000000000L,100000000000000L,1000000000000000L,10000000000000000L,100000000000000000L,1000000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011557Inst : IEnumerable<long>
{
public static readonly long[] Value=A011557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011557.Bytes);
public long this[int i]=>Value[i];

public static A011557Inst Instance=new A011557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011556
{
public static readonly long[] Value={ 1L,5L,35L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011556Inst : IEnumerable<long>
{
public static readonly long[] Value=A011556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011556.Bytes);
public long this[int i]=>Value[i];

public static A011556Inst Instance=new A011556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011555
{
public static readonly long[] Value={ 6L,108L,4488L,376200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011555Inst : IEnumerable<long>
{
public static readonly long[] Value=A011555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011555.Bytes);
public long this[int i]=>Value[i];

public static A011555Inst Instance=new A011555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011554
{
public static readonly long[] Value={ 4L,14L,34L,42L,59L,125L,145L,168L,175L,181L,190L,200L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011554Inst : IEnumerable<long>
{
public static readonly long[] Value=A011554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011554.Bytes);
public long this[int i]=>Value[i];

public static A011554Inst Instance=new A011554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011553
{
public static readonly BigInteger[] Value={ 0L,2L,16L,182L,2400L,35310L,562848L,9540674L,169777504L,3142665968L,60099912320L,1181283863632L,23767586624960L,487947659276790L,10195163202404160L,216335108170636650L,4653803620322450880L,BigInteger.Parse("101343766487960918460"),BigInteger.Parse("2231268469684932939360"),BigInteger.Parse("49614581272087698764820") };
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
public class A011553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011553Inst Instance=new A011553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011552
{
public static readonly long[] Value={ 2L,16L,162L,1618L,16180L,161803L,1618034L,16180340L,161803399L,1618033989L,16180339887L,161803398875L,1618033988750L,16180339887499L,161803398874989L,1618033988749895L,16180339887498948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011552Inst : IEnumerable<long>
{
public static readonly long[] Value=A011552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011552.Bytes);
public long this[int i]=>Value[i];

public static A011552Inst Instance=new A011552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011551
{
public static readonly long[] Value={ 1L,16L,161L,1618L,16180L,161803L,1618033L,16180339L,161803398L,1618033988L,16180339887L,161803398874L,1618033988749L,16180339887498L,161803398874989L,1618033988749894L,16180339887498948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011551Inst : IEnumerable<long>
{
public static readonly long[] Value=A011551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011551.Bytes);
public long this[int i]=>Value[i];

public static A011551Inst Instance=new A011551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011550
{
public static readonly long[] Value={ 2L,17L,173L,1732L,17321L,173205L,1732051L,17320508L,173205081L,1732050808L,17320508076L,173205080757L,1732050807569L,17320508075689L,173205080756888L,1732050807568877L,17320508075688773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011550Inst : IEnumerable<long>
{
public static readonly long[] Value=A011550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011550.Bytes);
public long this[int i]=>Value[i];

public static A011550Inst Instance=new A011550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011533
{
public static readonly long[] Value={ 3L,13L,23L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,43L,53L,63L,73L,83L,93L,103L,113L,123L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,143L,153L,163L,173L,183L,193L,203L,213L,223L,230L,231L,232L,233L,234L,235L,236L,237L,238L,239L,243L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011533Inst : IEnumerable<long>
{
public static readonly long[] Value=A011533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011533.Bytes);
public long this[int i]=>Value[i];

public static A011533Inst Instance=new A011533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011532
{
public static readonly long[] Value={ 2L,12L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,42L,52L,62L,72L,82L,92L,102L,112L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,132L,142L,152L,162L,172L,182L,192L,200L,201L,202L,203L,204L,205L,206L,207L,208L,209L,210L,211L,212L,213L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011532Inst : IEnumerable<long>
{
public static readonly long[] Value=A011532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011532.Bytes);
public long this[int i]=>Value[i];

public static A011532Inst Instance=new A011532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011531
{
public static readonly long[] Value={ 1L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,31L,41L,51L,61L,71L,81L,91L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011531Inst : IEnumerable<long>
{
public static readonly long[] Value=A011531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011531.Bytes);
public long this[int i]=>Value[i];

public static A011531Inst Instance=new A011531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011530
{
public static readonly long[] Value={ -121645100408832000L,431565146817638400L,-668609730341153280L,610116075740491776L,-371384787345228000L,161429736530118960L,-52260903362512720L,12953636989943896L,-2503858755467550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011530Inst : IEnumerable<long>
{
public static readonly long[] Value=A011530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011530.Bytes);
public long this[int i]=>Value[i];

public static A011530Inst Instance=new A011530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011529
{
public static readonly long[] Value={ 6402373705728000L,-22376988058521600L,34012249593822720L,-30321254007719424L,17950712280921504L,-7551527592063024L,2353125040549984L,-557921681547048L,102417740732658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011529Inst : IEnumerable<long>
{
public static readonly long[] Value=A011529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011529.Bytes);
public long this[int i]=>Value[i];

public static A011529Inst Instance=new A011529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011528
{
public static readonly long[] Value={ -355687428096000L,1223405590579200L,-1821602444624640L,1583313975727488L,-909299905844112L,369012649234384L,-110228466184200L,24871845297936L,-4308105301929L,577924894833L,-60202693980L,4853222764L,-299650806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011528Inst : IEnumerable<long>
{
public static readonly long[] Value=A011528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011528.Bytes);
public long this[int i]=>Value[i];

public static A011528Inst Instance=new A011528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011527
{
public static readonly long[] Value={ 20922789888000L,-70734282393600L,102992244837120L,-87077748875904L,48366009233424L,-18861567058880L,5374523477960L,-1146901283528L,185953177553L,-23057159840L,2185031420L,-156952432L,8394022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011527Inst : IEnumerable<long>
{
public static readonly long[] Value=A011527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011527.Bytes);
public long this[int i]=>Value[i];

public static A011527Inst Instance=new A011527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011526
{
public static readonly long[] Value={ -1307674368000L,4339163001600L,-6165817614720L,5056995703824L,-2706813345600L,1009672107080L,-272803210680L,54631129553L,-8207628000L,928095740L,-78558480L,4899622L,-218400L,6580L,-120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011526Inst : IEnumerable<long>
{
public static readonly long[] Value=A011526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011526.Bytes);
public long this[int i]=>Value[i];

public static A011526Inst Instance=new A011526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011525
{
public static readonly long[] Value={ 87178291200L,-283465647360L,392156797824L,-310989260400L,159721605680L,-56663366760L,14409322928L,-2681453775L,368411615L,-37312275L,2749747L,-143325L,5005L,-105L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011525Inst : IEnumerable<long>
{
public static readonly long[] Value=A011525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011525.Bytes);
public long this[int i]=>Value[i];

public static A011525Inst Instance=new A011525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011524
{
public static readonly long[] Value={ -6227020800L,19802759040L,-26596717056L,20313753096L,-9957703756L,3336118786L,-790943153L,135036473L,-16669653L,1474473L,-91091L,3731L,-91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011524Inst : IEnumerable<long>
{
public static readonly long[] Value=A011524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011524.Bytes);
public long this[int i]=>Value[i];

public static A011524Inst Instance=new A011524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011523
{
public static readonly long[] Value={ 479001600L,-1486442880L,1931559552L,-1414014888L,657206836L,-206070150L,44990231L,-6926634L,749463L,-55770L,2717L,-78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011523Inst : IEnumerable<long>
{
public static readonly long[] Value=A011523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011523.Bytes);
public long this[int i]=>Value[i];

public static A011523Inst Instance=new A011523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011522
{
public static readonly long[] Value={ -39916800L,120543840L,-150917976L,105258076L,-45995730L,13339535L,-2637558L,357423L,-32670L,1925L,-66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011522Inst : IEnumerable<long>
{
public static readonly long[] Value=A011522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011522.Bytes);
public long this[int i]=>Value[i];

public static A011522Inst Instance=new A011522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011521
{
public static readonly long[] Value={ 3628800L,-10628640L,12753576L,-8409500L,3416930L,-902055L,157773L,-18150L,1320L,-55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011521Inst : IEnumerable<long>
{
public static readonly long[] Value=A011521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011521.Bytes);
public long this[int i]=>Value[i];

public static A011521Inst Instance=new A011521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011520
{
public static readonly long[] Value={ -362880L,1026576L,-1172700L,723680L,-269325L,63273L,-9450L,870L,-45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011520Inst : IEnumerable<long>
{
public static readonly long[] Value=A011520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011520.Bytes);
public long this[int i]=>Value[i];

public static A011520Inst Instance=new A011520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011519
{
public static readonly long[] Value={ 1L,0L,4L,7L,1L,2L,8L,5L,4L,8L,0L,5L,0L,8L,9L,9L,5L,3L,3L,4L,6L,4L,5L,0L,2L,0L,3L,1L,5L,2L,8L,1L,4L,0L,0L,7L,9L,0L,5L,6L,7L,9L,1L,4L,7L,1L,5L,0L,3L,9L,2L,9L,2L,1L,2L,0L,0L,5L,6L,5L,2L,5L,2L,9L,9L,0L,1L,2L,5L,7L,7L,6L,4L,1L,0L,2L,3L,7L,1L,9L,1L,1L,2L,6L,3L,8L,0L,9L,1L,7L,1L,4L,6L,9L,8L,4L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011519Inst : IEnumerable<long>
{
public static readonly long[] Value=A011519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011519.Bytes);
public long this[int i]=>Value[i];

public static A011519Inst Instance=new A011519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011518
{
public static readonly long[] Value={ 1L,0L,4L,7L,5L,0L,9L,4L,0L,5L,7L,6L,1L,9L,8L,5L,6L,2L,4L,9L,8L,0L,2L,8L,7L,9L,4L,9L,5L,8L,4L,3L,2L,1L,6L,2L,4L,1L,5L,6L,4L,0L,4L,9L,1L,9L,7L,8L,2L,0L,5L,9L,4L,7L,6L,6L,8L,9L,3L,5L,3L,5L,6L,8L,2L,0L,8L,3L,2L,4L,1L,2L,1L,4L,2L,4L,7L,7L,4L,9L,1L,2L,2L,5L,3L,3L,9L,1L,7L,9L,2L,3L,3L,4L,2L,1L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011518Inst : IEnumerable<long>
{
public static readonly long[] Value=A011518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011518.Bytes);
public long this[int i]=>Value[i];

public static A011518Inst Instance=new A011518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011517
{
public static readonly long[] Value={ 1L,0L,4L,7L,8L,9L,7L,0L,8L,7L,8L,2L,3L,5L,6L,7L,4L,1L,4L,7L,4L,8L,3L,3L,5L,7L,3L,9L,4L,1L,9L,3L,0L,9L,6L,5L,4L,2L,4L,8L,5L,3L,0L,7L,2L,1L,3L,2L,7L,1L,4L,1L,2L,5L,5L,8L,1L,6L,9L,7L,7L,4L,9L,6L,7L,7L,3L,3L,1L,0L,1L,1L,7L,3L,6L,6L,5L,9L,4L,2L,2L,6L,2L,6L,9L,2L,7L,9L,8L,4L,9L,4L,1L,4L,4L,9L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011517Inst : IEnumerable<long>
{
public static readonly long[] Value=A011517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011517.Bytes);
public long this[int i]=>Value[i];

public static A011517Inst Instance=new A011517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011516
{
public static readonly long[] Value={ 1L,0L,4L,8L,2L,9L,1L,7L,8L,5L,9L,4L,5L,6L,1L,3L,5L,3L,6L,7L,1L,6L,0L,9L,4L,9L,1L,1L,8L,3L,2L,4L,4L,3L,0L,9L,7L,9L,4L,5L,6L,7L,3L,6L,8L,1L,1L,4L,8L,7L,6L,8L,8L,4L,3L,9L,3L,5L,8L,0L,6L,4L,2L,2L,2L,3L,6L,5L,0L,4L,9L,2L,9L,3L,8L,7L,6L,7L,6L,5L,1L,7L,1L,6L,8L,0L,2L,7L,5L,5L,4L,4L,3L,4L,4L,2L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011516Inst : IEnumerable<long>
{
public static readonly long[] Value=A011516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011516.Bytes);
public long this[int i]=>Value[i];

public static A011516Inst Instance=new A011516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011515
{
public static readonly long[] Value={ 1L,0L,4L,8L,6L,9L,3L,6L,9L,9L,2L,2L,2L,6L,3L,0L,3L,5L,6L,0L,6L,7L,2L,5L,5L,7L,5L,2L,6L,6L,6L,3L,2L,9L,4L,5L,7L,9L,2L,7L,0L,4L,7L,3L,3L,2L,5L,2L,1L,7L,2L,4L,3L,9L,6L,4L,4L,2L,3L,1L,4L,8L,6L,4L,9L,1L,0L,3L,2L,3L,5L,7L,1L,1L,2L,4L,2L,4L,3L,6L,5L,0L,1L,1L,1L,6L,1L,5L,4L,0L,2L,3L,3L,3L,0L,5L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011515Inst : IEnumerable<long>
{
public static readonly long[] Value=A011515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011515.Bytes);
public long this[int i]=>Value[i];

public static A011515Inst Instance=new A011515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011514
{
public static readonly long[] Value={ 1L,0L,4L,9L,1L,0L,3L,0L,3L,4L,4L,9L,6L,8L,3L,8L,6L,1L,4L,6L,5L,2L,0L,3L,3L,2L,3L,1L,1L,2L,0L,4L,6L,1L,7L,2L,8L,0L,0L,3L,8L,6L,7L,3L,4L,9L,8L,3L,7L,4L,4L,2L,5L,4L,9L,3L,6L,4L,3L,5L,8L,5L,8L,3L,3L,5L,9L,1L,4L,7L,5L,1L,4L,0L,1L,2L,3L,7L,8L,7L,8L,3L,4L,9L,0L,3L,8L,4L,6L,7L,6L,8L,3L,0L,0L,0L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011514Inst : IEnumerable<long>
{
public static readonly long[] Value=A011514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011514.Bytes);
public long this[int i]=>Value[i];

public static A011514Inst Instance=new A011514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011513
{
public static readonly long[] Value={ 1L,0L,4L,9L,5L,2L,0L,0L,0L,6L,7L,4L,3L,1L,6L,6L,5L,9L,1L,6L,6L,7L,9L,2L,5L,5L,2L,1L,1L,4L,1L,9L,8L,0L,2L,7L,2L,6L,5L,4L,4L,0L,5L,2L,0L,7L,5L,5L,8L,8L,8L,1L,5L,0L,1L,8L,6L,2L,2L,9L,8L,4L,6L,1L,5L,8L,3L,7L,7L,4L,5L,5L,3L,6L,4L,9L,0L,8L,4L,6L,3L,8L,4L,8L,1L,9L,3L,5L,1L,3L,6L,4L,6L,4L,6L,4L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011513Inst : IEnumerable<long>
{
public static readonly long[] Value=A011513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011513.Bytes);
public long this[int i]=>Value[i];

public static A011513Inst Instance=new A011513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011512
{
public static readonly long[] Value={ 1L,0L,4L,9L,9L,4L,4L,8L,3L,9L,4L,7L,7L,6L,1L,2L,9L,3L,7L,6L,9L,0L,3L,7L,5L,4L,3L,3L,2L,2L,5L,0L,3L,1L,1L,6L,2L,0L,8L,6L,9L,8L,2L,6L,9L,4L,6L,1L,9L,7L,4L,3L,9L,0L,4L,1L,0L,3L,2L,4L,9L,0L,9L,3L,8L,1L,1L,0L,3L,8L,4L,0L,0L,3L,4L,1L,4L,9L,4L,7L,5L,0L,8L,8L,2L,1L,4L,7L,8L,7L,2L,8L,0L,6L,5L,3L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011512Inst : IEnumerable<long>
{
public static readonly long[] Value=A011512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011512.Bytes);
public long this[int i]=>Value[i];

public static A011512Inst Instance=new A011512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011511
{
public static readonly long[] Value={ 1L,0L,5L,0L,3L,7L,7L,7L,6L,5L,1L,9L,0L,6L,6L,0L,5L,4L,5L,7L,2L,6L,9L,4L,0L,7L,7L,6L,0L,2L,8L,9L,4L,6L,8L,4L,0L,9L,9L,7L,9L,7L,5L,1L,8L,1L,9L,2L,8L,4L,4L,1L,2L,4L,0L,5L,7L,0L,1L,8L,8L,3L,8L,4L,1L,4L,1L,8L,3L,2L,0L,9L,1L,0L,3L,1L,7L,6L,1L,2L,9L,8L,6L,6L,6L,8L,1L,5L,9L,5L,6L,5L,9L,0L,3L,3L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011511Inst : IEnumerable<long>
{
public static readonly long[] Value=A011511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011511.Bytes);
public long this[int i]=>Value[i];

public static A011511Inst Instance=new A011511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011510
{
public static readonly long[] Value={ 1L,0L,5L,0L,8L,1L,9L,0L,2L,5L,8L,0L,7L,5L,6L,3L,0L,9L,7L,2L,1L,2L,7L,8L,0L,3L,6L,7L,8L,2L,8L,2L,0L,0L,6L,3L,0L,1L,5L,3L,8L,7L,0L,1L,4L,6L,6L,7L,1L,9L,6L,4L,2L,3L,7L,1L,3L,8L,4L,6L,4L,8L,3L,5L,5L,2L,5L,5L,3L,0L,8L,4L,4L,6L,9L,1L,8L,8L,6L,7L,9L,3L,1L,1L,9L,7L,6L,7L,9L,3L,0L,8L,5L,5L,5L,7L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011510Inst : IEnumerable<long>
{
public static readonly long[] Value=A011510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011510.Bytes);
public long this[int i]=>Value[i];

public static A011510Inst Instance=new A011510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011509
{
public static readonly long[] Value={ 1L,0L,5L,1L,2L,6L,8L,8L,7L,3L,1L,7L,7L,4L,7L,9L,5L,4L,2L,6L,6L,5L,9L,4L,2L,1L,1L,8L,4L,5L,1L,9L,9L,9L,7L,0L,1L,0L,2L,3L,7L,5L,8L,3L,9L,5L,8L,0L,4L,5L,2L,7L,9L,7L,3L,2L,7L,6L,1L,1L,2L,0L,0L,8L,9L,2L,4L,2L,1L,4L,3L,5L,2L,2L,4L,0L,1L,0L,4L,7L,6L,3L,2L,5L,8L,9L,5L,0L,9L,1L,1L,6L,2L,8L,5L,1L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011509Inst : IEnumerable<long>
{
public static readonly long[] Value=A011509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011509.Bytes);
public long this[int i]=>Value[i];

public static A011509Inst Instance=new A011509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011508
{
public static readonly long[] Value={ 1L,0L,5L,1L,7L,2L,7L,5L,6L,9L,5L,9L,3L,6L,0L,0L,1L,7L,5L,9L,3L,3L,3L,9L,3L,9L,1L,4L,5L,0L,9L,2L,5L,7L,1L,2L,3L,4L,1L,5L,7L,2L,0L,8L,4L,8L,8L,0L,6L,8L,9L,8L,5L,0L,5L,5L,6L,5L,8L,2L,4L,5L,6L,9L,7L,8L,3L,2L,5L,7L,4L,2L,1L,7L,5L,5L,7L,3L,7L,4L,8L,7L,2L,1L,6L,8L,5L,8L,2L,1L,5L,8L,1L,1L,3L,2L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011508Inst : IEnumerable<long>
{
public static readonly long[] Value=A011508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011508.Bytes);
public long this[int i]=>Value[i];

public static A011508Inst Instance=new A011508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011507
{
public static readonly long[] Value={ 1L,0L,5L,2L,1L,9L,5L,3L,8L,8L,3L,4L,6L,5L,9L,2L,7L,3L,8L,0L,9L,0L,4L,2L,1L,8L,3L,7L,3L,0L,6L,3L,1L,6L,8L,8L,6L,6L,6L,3L,4L,9L,8L,0L,2L,0L,6L,8L,5L,8L,1L,4L,7L,1L,8L,2L,3L,8L,7L,3L,4L,4L,7L,3L,8L,1L,7L,1L,4L,5L,5L,0L,0L,2L,5L,2L,0L,2L,4L,5L,5L,2L,1L,4L,9L,2L,4L,9L,5L,2L,6L,7L,6L,9L,6L,4L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011507Inst : IEnumerable<long>
{
public static readonly long[] Value=A011507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011507.Bytes);
public long this[int i]=>Value[i];

public static A011507Inst Instance=new A011507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011506
{
public static readonly long[] Value={ 1L,0L,5L,2L,6L,7L,2L,6L,1L,4L,3L,1L,3L,8L,9L,9L,9L,3L,5L,7L,6L,4L,0L,3L,6L,2L,4L,7L,6L,1L,8L,7L,1L,8L,1L,5L,1L,0L,4L,0L,4L,7L,0L,7L,6L,6L,5L,5L,8L,8L,7L,9L,5L,0L,8L,2L,7L,8L,4L,8L,0L,2L,6L,6L,1L,9L,5L,1L,5L,0L,4L,3L,7L,9L,3L,4L,3L,2L,1L,9L,7L,3L,1L,3L,7L,2L,5L,4L,0L,7L,4L,3L,7L,5L,3L,4L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011506Inst : IEnumerable<long>
{
public static readonly long[] Value=A011506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011506.Bytes);
public long this[int i]=>Value[i];

public static A011506Inst Instance=new A011506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011505
{
public static readonly long[] Value={ 1L,0L,5L,3L,1L,5L,9L,5L,4L,4L,5L,8L,7L,6L,4L,2L,8L,9L,1L,4L,9L,2L,3L,1L,4L,7L,0L,5L,5L,9L,8L,4L,9L,0L,2L,6L,1L,9L,6L,5L,7L,6L,5L,7L,1L,2L,2L,1L,2L,1L,3L,3L,7L,7L,2L,5L,2L,7L,3L,2L,4L,4L,5L,5L,2L,6L,1L,8L,0L,3L,2L,1L,4L,6L,4L,4L,8L,7L,0L,5L,4L,4L,6L,7L,8L,7L,2L,9L,8L,5L,9L,1L,9L,2L,3L,9L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011505Inst : IEnumerable<long>
{
public static readonly long[] Value=A011505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011505.Bytes);
public long this[int i]=>Value[i];

public static A011505Inst Instance=new A011505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011504
{
public static readonly long[] Value={ 1L,0L,5L,3L,6L,5L,6L,4L,8L,9L,1L,4L,4L,1L,3L,0L,6L,2L,1L,6L,7L,8L,4L,6L,6L,3L,7L,3L,5L,4L,1L,0L,6L,6L,0L,5L,9L,9L,5L,9L,5L,9L,1L,3L,1L,8L,4L,7L,2L,2L,5L,5L,2L,9L,0L,4L,0L,1L,2L,5L,6L,8L,7L,6L,7L,2L,2L,7L,9L,4L,0L,5L,1L,2L,2L,8L,5L,8L,8L,9L,8L,7L,2L,3L,9L,0L,2L,7L,8L,8L,3L,2L,8L,7L,2L,8L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011504Inst : IEnumerable<long>
{
public static readonly long[] Value=A011504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011504.Bytes);
public long this[int i]=>Value[i];

public static A011504Inst Instance=new A011504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011503
{
public static readonly long[] Value={ 1L,0L,5L,4L,1L,6L,3L,7L,7L,1L,5L,5L,8L,2L,4L,6L,2L,0L,4L,0L,1L,9L,5L,5L,2L,4L,5L,2L,2L,5L,0L,6L,1L,2L,0L,9L,6L,1L,9L,6L,2L,3L,8L,7L,2L,6L,8L,6L,7L,6L,2L,3L,2L,2L,1L,0L,8L,6L,1L,1L,7L,6L,2L,2L,8L,7L,9L,7L,0L,3L,2L,8L,7L,9L,0L,4L,1L,1L,9L,1L,9L,6L,9L,2L,5L,8L,9L,4L,1L,5L,6L,8L,1L,7L,3L,4L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011503Inst : IEnumerable<long>
{
public static readonly long[] Value=A011503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011503.Bytes);
public long this[int i]=>Value[i];

public static A011503Inst Instance=new A011503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011502
{
public static readonly long[] Value={ 1L,0L,5L,4L,6L,8L,1L,7L,2L,9L,7L,6L,6L,2L,7L,8L,7L,1L,5L,5L,0L,1L,0L,3L,9L,7L,5L,6L,8L,3L,9L,9L,8L,1L,3L,0L,1L,4L,8L,0L,0L,8L,9L,5L,4L,8L,2L,5L,9L,8L,4L,6L,8L,6L,0L,5L,8L,2L,0L,3L,8L,5L,3L,9L,8L,0L,3L,1L,3L,0L,0L,4L,2L,5L,2L,8L,3L,5L,8L,2L,9L,4L,7L,3L,5L,3L,2L,0L,9L,5L,2L,9L,7L,5L,3L,9L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011502Inst : IEnumerable<long>
{
public static readonly long[] Value=A011502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011502.Bytes);
public long this[int i]=>Value[i];

public static A011502Inst Instance=new A011502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011485
{
public static readonly long[] Value={ 1L,0L,6L,5L,5L,3L,7L,7L,6L,7L,0L,4L,7L,1L,3L,5L,3L,5L,4L,3L,0L,6L,6L,6L,0L,1L,5L,3L,3L,2L,9L,6L,5L,8L,3L,7L,2L,5L,0L,5L,4L,0L,9L,5L,0L,6L,0L,1L,6L,6L,3L,8L,7L,6L,1L,4L,9L,8L,7L,1L,1L,8L,4L,6L,6L,7L,1L,8L,4L,2L,7L,5L,4L,5L,5L,7L,4L,8L,5L,8L,2L,2L,0L,8L,7L,7L,8L,5L,4L,2L,0L,2L,6L,7L,4L,5L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011485Inst : IEnumerable<long>
{
public static readonly long[] Value=A011485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011485.Bytes);
public long this[int i]=>Value[i];

public static A011485Inst Instance=new A011485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011484
{
public static readonly long[] Value={ 1L,0L,6L,6L,3L,2L,8L,3L,9L,6L,5L,5L,6L,7L,9L,7L,9L,9L,0L,6L,4L,3L,2L,1L,3L,1L,9L,3L,0L,4L,5L,8L,4L,1L,2L,4L,2L,9L,6L,4L,1L,3L,7L,6L,7L,8L,6L,1L,5L,6L,4L,9L,3L,3L,2L,5L,4L,3L,1L,2L,2L,6L,0L,2L,4L,5L,9L,9L,5L,8L,4L,0L,6L,6L,3L,0L,3L,0L,3L,3L,8L,2L,5L,1L,6L,6L,2L,4L,7L,7L,3L,4L,1L,9L,4L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011484Inst : IEnumerable<long>
{
public static readonly long[] Value=A011484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011484.Bytes);
public long this[int i]=>Value[i];

public static A011484Inst Instance=new A011484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011483
{
public static readonly long[] Value={ 1L,0L,6L,7L,1L,4L,0L,4L,0L,0L,6L,7L,6L,8L,2L,3L,6L,1L,8L,1L,6L,9L,5L,2L,1L,1L,2L,0L,9L,9L,2L,8L,0L,9L,1L,6L,2L,6L,0L,6L,8L,9L,2L,2L,1L,2L,5L,7L,4L,0L,0L,4L,6L,3L,0L,6L,8L,9L,9L,4L,2L,2L,9L,3L,5L,1L,8L,6L,0L,8L,8L,6L,2L,3L,6L,9L,8L,9L,2L,2L,6L,3L,3L,8L,1L,4L,7L,5L,7L,1L,5L,9L,5L,3L,7L,3L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011483Inst : IEnumerable<long>
{
public static readonly long[] Value=A011483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011483.Bytes);
public long this[int i]=>Value[i];

public static A011483Inst Instance=new A011483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011482
{
public static readonly long[] Value={ 1L,0L,6L,7L,9L,7L,4L,6L,9L,1L,6L,2L,4L,1L,1L,1L,3L,7L,1L,2L,0L,7L,2L,5L,3L,5L,2L,9L,5L,6L,5L,2L,5L,0L,9L,5L,2L,5L,8L,3L,0L,9L,3L,6L,3L,5L,7L,8L,3L,6L,6L,6L,9L,4L,1L,0L,4L,6L,1L,7L,8L,2L,9L,2L,7L,7L,1L,8L,0L,5L,3L,9L,9L,7L,3L,4L,6L,7L,0L,7L,5L,7L,9L,9L,7L,3L,9L,7L,0L,1L,1L,7L,5L,3L,0L,9L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011482Inst : IEnumerable<long>
{
public static readonly long[] Value=A011482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011482.Bytes);
public long this[int i]=>Value[i];

public static A011482Inst Instance=new A011482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011481
{
public static readonly long[] Value={ 1L,0L,6L,8L,8L,3L,2L,2L,3L,5L,3L,1L,1L,8L,8L,9L,2L,7L,9L,0L,9L,3L,5L,6L,6L,9L,9L,5L,9L,5L,2L,1L,1L,8L,9L,4L,3L,4L,6L,1L,5L,1L,0L,7L,8L,9L,2L,5L,1L,6L,0L,2L,2L,4L,1L,4L,1L,9L,2L,2L,4L,7L,9L,4L,2L,5L,8L,3L,7L,3L,0L,8L,7L,0L,8L,5L,9L,9L,0L,8L,7L,8L,4L,3L,8L,2L,3L,8L,5L,0L,5L,7L,9L,3L,5L,1L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011481Inst : IEnumerable<long>
{
public static readonly long[] Value=A011481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011481.Bytes);
public long this[int i]=>Value[i];

public static A011481Inst Instance=new A011481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011480
{
public static readonly long[] Value={ 1L,0L,6L,9L,7L,1L,4L,0L,5L,5L,4L,0L,7L,5L,3L,7L,2L,4L,6L,3L,8L,9L,9L,3L,4L,6L,7L,7L,1L,1L,2L,4L,8L,9L,4L,0L,6L,3L,3L,5L,5L,3L,3L,9L,6L,8L,9L,0L,3L,5L,0L,2L,8L,7L,3L,1L,2L,9L,0L,2L,9L,0L,5L,0L,4L,6L,0L,1L,6L,9L,8L,2L,9L,9L,7L,5L,0L,6L,7L,5L,4L,5L,6L,1L,3L,6L,2L,2L,3L,5L,7L,9L,4L,9L,9L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011480Inst : IEnumerable<long>
{
public static readonly long[] Value=A011480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011480.Bytes);
public long this[int i]=>Value[i];

public static A011480Inst Instance=new A011480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011479
{
public static readonly long[] Value={ 1L,0L,7L,0L,6L,2L,1L,2L,3L,7L,7L,6L,6L,9L,6L,6L,1L,9L,9L,6L,3L,8L,3L,4L,5L,5L,1L,3L,1L,4L,4L,0L,3L,4L,1L,8L,3L,4L,6L,3L,3L,0L,0L,8L,3L,7L,4L,7L,9L,1L,7L,5L,7L,9L,3L,5L,0L,5L,1L,1L,7L,3L,5L,1L,5L,0L,4L,4L,2L,8L,3L,8L,1L,8L,5L,1L,1L,3L,3L,1L,4L,1L,6L,1L,2L,0L,7L,7L,9L,9L,0L,9L,6L,8L,8L,9L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011479Inst : IEnumerable<long>
{
public static readonly long[] Value=A011479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011479.Bytes);
public long this[int i]=>Value[i];

public static A011479Inst Instance=new A011479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011478
{
public static readonly long[] Value={ 1L,0L,7L,1L,5L,5L,4L,9L,3L,5L,2L,8L,7L,1L,8L,4L,0L,6L,1L,6L,9L,2L,7L,6L,1L,9L,4L,5L,9L,6L,5L,2L,6L,5L,1L,8L,9L,0L,9L,4L,5L,2L,0L,2L,9L,8L,7L,9L,0L,3L,8L,5L,6L,4L,0L,9L,9L,8L,0L,5L,9L,2L,5L,1L,0L,9L,6L,4L,8L,1L,7L,2L,0L,9L,7L,8L,0L,7L,5L,5L,7L,3L,1L,8L,2L,1L,4L,5L,6L,9L,8L,0L,2L,8L,8L,6L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011478Inst : IEnumerable<long>
{
public static readonly long[] Value=A011478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011478.Bytes);
public long this[int i]=>Value[i];

public static A011478Inst Instance=new A011478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011477
{
public static readonly long[] Value={ 1L,0L,7L,2L,5L,1L,6L,3L,7L,3L,2L,2L,4L,0L,4L,3L,7L,0L,0L,5L,0L,2L,6L,0L,7L,6L,0L,4L,2L,9L,4L,2L,1L,8L,4L,4L,7L,3L,4L,4L,0L,6L,0L,6L,5L,5L,4L,5L,7L,2L,8L,3L,8L,9L,2L,3L,0L,8L,1L,9L,9L,6L,4L,1L,5L,5L,7L,2L,8L,1L,2L,2L,2L,8L,5L,0L,8L,7L,5L,4L,8L,0L,5L,8L,4L,1L,5L,6L,0L,5L,3L,9L,2L,2L,1L,3L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011477Inst : IEnumerable<long>
{
public static readonly long[] Value=A011477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011477.Bytes);
public long this[int i]=>Value[i];

public static A011477Inst Instance=new A011477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011476
{
public static readonly long[] Value={ 1L,0L,7L,3L,5L,0L,6L,8L,5L,5L,0L,2L,8L,3L,2L,4L,9L,2L,6L,8L,5L,7L,6L,5L,5L,3L,2L,2L,4L,1L,8L,9L,9L,2L,5L,1L,9L,0L,9L,5L,8L,8L,3L,7L,9L,0L,4L,1L,2L,9L,7L,5L,4L,3L,3L,1L,4L,3L,0L,7L,0L,3L,0L,2L,3L,3L,0L,5L,3L,8L,0L,9L,9L,3L,2L,4L,7L,7L,6L,4L,3L,5L,1L,0L,9L,4L,9L,1L,5L,5L,8L,1L,0L,2L,8L,0L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011476Inst : IEnumerable<long>
{
public static readonly long[] Value=A011476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011476.Bytes);
public long this[int i]=>Value[i];

public static A011476Inst Instance=new A011476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011475
{
public static readonly long[] Value={ 1L,0L,7L,4L,5L,2L,7L,7L,6L,8L,7L,6L,0L,3L,8L,4L,4L,4L,4L,5L,0L,4L,6L,3L,4L,4L,4L,4L,1L,0L,2L,0L,4L,6L,5L,0L,8L,2L,3L,7L,8L,1L,8L,2L,7L,3L,7L,2L,0L,2L,4L,1L,8L,0L,9L,5L,1L,1L,1L,9L,5L,6L,3L,5L,1L,2L,3L,6L,9L,9L,7L,8L,2L,6L,2L,9L,7L,1L,3L,8L,2L,8L,2L,5L,0L,1L,7L,6L,1L,4L,1L,7L,1L,2L,5L,6L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011475Inst : IEnumerable<long>
{
public static readonly long[] Value=A011475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011475.Bytes);
public long this[int i]=>Value[i];

public static A011475Inst Instance=new A011475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011474
{
public static readonly long[] Value={ 1L,0L,7L,5L,5L,8L,0L,5L,9L,4L,1L,5L,1L,7L,7L,1L,6L,3L,8L,5L,5L,6L,9L,7L,4L,1L,1L,1L,7L,6L,6L,0L,1L,0L,2L,3L,9L,4L,5L,3L,2L,7L,5L,0L,3L,3L,8L,1L,4L,7L,0L,0L,3L,9L,4L,4L,2L,8L,3L,3L,9L,9L,0L,5L,8L,8L,4L,4L,3L,4L,6L,4L,9L,5L,2L,3L,2L,9L,4L,0L,8L,1L,2L,6L,6L,7L,8L,4L,7L,3L,8L,6L,6L,9L,5L,7L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011474Inst : IEnumerable<long>
{
public static readonly long[] Value=A011474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011474.Bytes);
public long this[int i]=>Value[i];

public static A011474Inst Instance=new A011474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011473
{
public static readonly long[] Value={ 1L,0L,7L,6L,6L,6L,6L,9L,1L,0L,3L,9L,1L,6L,4L,1L,4L,2L,1L,1L,4L,3L,2L,7L,6L,7L,5L,5L,1L,4L,0L,1L,1L,1L,8L,6L,6L,3L,2L,0L,1L,1L,9L,0L,8L,7L,5L,1L,5L,3L,7L,5L,9L,6L,2L,4L,3L,1L,6L,2L,2L,1L,8L,7L,3L,7L,3L,5L,7L,9L,8L,7L,6L,3L,9L,8L,2L,5L,2L,4L,3L,3L,7L,5L,5L,7L,2L,3L,2L,1L,9L,7L,0L,8L,1L,3L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011473Inst : IEnumerable<long>
{
public static readonly long[] Value=A011473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011473.Bytes);
public long this[int i]=>Value[i];

public static A011473Inst Instance=new A011473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011472
{
public static readonly long[] Value={ 1L,0L,7L,7L,7L,8L,8L,4L,0L,4L,7L,2L,6L,7L,2L,1L,5L,0L,9L,7L,4L,4L,3L,2L,3L,3L,7L,7L,4L,3L,0L,4L,8L,1L,8L,4L,8L,5L,0L,1L,7L,7L,5L,0L,1L,0L,8L,6L,3L,8L,1L,2L,8L,8L,3L,4L,6L,5L,1L,1L,0L,9L,7L,9L,4L,9L,6L,5L,9L,6L,8L,3L,6L,4L,2L,9L,4L,9L,4L,8L,2L,8L,8L,8L,7L,2L,7L,4L,6L,2L,0L,5L,1L,3L,8L,3L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011472Inst : IEnumerable<long>
{
public static readonly long[] Value=A011472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011472.Bytes);
public long this[int i]=>Value[i];

public static A011472Inst Instance=new A011472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011471
{
public static readonly long[] Value={ 1L,0L,7L,8L,9L,4L,6L,8L,8L,1L,9L,7L,6L,2L,7L,8L,0L,4L,9L,9L,2L,6L,3L,1L,4L,6L,1L,3L,2L,2L,6L,4L,3L,6L,8L,1L,4L,4L,4L,9L,6L,9L,0L,9L,3L,9L,1L,5L,7L,7L,0L,8L,9L,7L,6L,4L,5L,4L,7L,3L,2L,8L,5L,9L,2L,0L,7L,8L,0L,4L,1L,2L,0L,5L,5L,0L,0L,5L,2L,8L,8L,5L,8L,6L,1L,9L,4L,2L,6L,3L,3L,8L,4L,4L,6L,8L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011471Inst : IEnumerable<long>
{
public static readonly long[] Value=A011471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011471.Bytes);
public long this[int i]=>Value[i];

public static A011471Inst Instance=new A011471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011470
{
public static readonly long[] Value={ 1L,0L,8L,0L,1L,4L,4L,2L,7L,5L,0L,7L,8L,2L,9L,1L,7L,0L,9L,5L,6L,5L,2L,7L,5L,0L,3L,6L,1L,3L,9L,4L,9L,1L,2L,2L,3L,6L,3L,3L,1L,5L,7L,1L,0L,4L,9L,1L,3L,8L,0L,9L,4L,9L,9L,6L,7L,1L,9L,4L,5L,2L,0L,4L,9L,7L,5L,1L,6L,2L,7L,1L,6L,1L,5L,2L,4L,3L,1L,7L,3L,3L,3L,4L,9L,0L,6L,8L,4L,8L,0L,6L,6L,5L,0L,0L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011470Inst : IEnumerable<long>
{
public static readonly long[] Value=A011470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011470.Bytes);
public long this[int i]=>Value[i];

public static A011470Inst Instance=new A011470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011469
{
public static readonly long[] Value={ 1L,0L,8L,1L,3L,8L,2L,6L,5L,6L,8L,0L,0L,2L,9L,3L,3L,0L,2L,6L,4L,5L,1L,7L,8L,4L,9L,4L,1L,5L,3L,5L,8L,8L,8L,5L,6L,7L,2L,7L,8L,7L,6L,1L,4L,1L,7L,0L,3L,7L,5L,5L,3L,3L,3L,7L,5L,9L,2L,3L,1L,4L,0L,5L,3L,7L,2L,3L,0L,7L,9L,8L,7L,9L,7L,8L,2L,3L,3L,3L,1L,2L,8L,3L,7L,2L,3L,9L,4L,0L,8L,0L,7L,4L,7L,8L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011469Inst : IEnumerable<long>
{
public static readonly long[] Value=A011469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011469.Bytes);
public long this[int i]=>Value[i];

public static A011469Inst Instance=new A011469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011468
{
public static readonly long[] Value={ 1L,0L,8L,2L,6L,6L,4L,2L,5L,2L,7L,6L,8L,4L,8L,1L,3L,6L,7L,1L,6L,2L,3L,8L,0L,1L,2L,1L,9L,1L,8L,5L,5L,9L,9L,8L,3L,9L,0L,3L,8L,3L,9L,7L,6L,3L,5L,8L,4L,5L,7L,7L,9L,8L,9L,9L,2L,4L,8L,3L,8L,1L,7L,6L,2L,6L,2L,0L,1L,9L,0L,6L,3L,8L,3L,3L,2L,9L,1L,6L,5L,9L,4L,3L,1L,0L,4L,9L,2L,3L,5L,7L,0L,7L,7L,0L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011468Inst : IEnumerable<long>
{
public static readonly long[] Value=A011468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011468.Bytes);
public long this[int i]=>Value[i];

public static A011468Inst Instance=new A011468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011467
{
public static readonly long[] Value={ 1L,0L,8L,3L,9L,9L,1L,4L,5L,5L,9L,9L,2L,4L,2L,1L,0L,2L,1L,9L,1L,7L,9L,6L,6L,4L,8L,3L,6L,9L,2L,2L,1L,6L,5L,4L,5L,0L,0L,4L,4L,9L,9L,0L,9L,9L,1L,9L,1L,9L,5L,6L,9L,9L,7L,0L,9L,2L,7L,8L,3L,3L,9L,5L,1L,5L,8L,8L,9L,0L,0L,7L,8L,2L,7L,5L,5L,3L,0L,9L,9L,5L,6L,0L,9L,9L,6L,0L,7L,5L,1L,1L,0L,1L,4L,8L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011467Inst : IEnumerable<long>
{
public static readonly long[] Value=A011467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011467.Bytes);
public long this[int i]=>Value[i];

public static A011467Inst Instance=new A011467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011466
{
public static readonly long[] Value={ 1L,0L,8L,5L,3L,6L,6L,8L,4L,3L,0L,9L,0L,4L,9L,3L,8L,1L,2L,4L,1L,0L,4L,8L,2L,6L,8L,7L,4L,8L,7L,8L,2L,8L,2L,1L,8L,5L,4L,9L,9L,5L,9L,6L,3L,0L,5L,9L,5L,3L,4L,9L,3L,7L,9L,2L,5L,3L,5L,1L,4L,8L,2L,3L,1L,9L,4L,4L,1L,7L,7L,2L,8L,6L,8L,6L,6L,2L,3L,0L,0L,7L,3L,5L,9L,8L,6L,0L,4L,5L,2L,1L,5L,9L,0L,5L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011466Inst : IEnumerable<long>
{
public static readonly long[] Value=A011466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011466.Bytes);
public long this[int i]=>Value[i];

public static A011466Inst Instance=new A011466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011465
{
public static readonly long[] Value={ 1L,0L,8L,6L,7L,9L,3L,1L,9L,2L,4L,5L,4L,1L,7L,4L,5L,2L,4L,7L,5L,1L,4L,7L,7L,0L,7L,9L,5L,6L,1L,6L,1L,4L,4L,3L,9L,9L,6L,6L,6L,5L,2L,7L,0L,6L,7L,8L,9L,5L,3L,1L,4L,8L,1L,7L,6L,5L,0L,7L,2L,0L,3L,7L,9L,4L,4L,7L,8L,0L,2L,7L,0L,1L,0L,1L,0L,6L,7L,8L,3L,9L,6L,7L,6L,3L,3L,9L,6L,9L,0L,8L,0L,3L,4L,0L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011465Inst : IEnumerable<long>
{
public static readonly long[] Value=A011465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011465.Bytes);
public long this[int i]=>Value[i];

public static A011465Inst Instance=new A011465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011464
{
public static readonly long[] Value={ 1L,0L,8L,8L,2L,7L,3L,5L,0L,4L,6L,2L,8L,1L,8L,5L,4L,0L,5L,0L,2L,3L,1L,1L,0L,0L,4L,7L,1L,8L,0L,4L,2L,5L,9L,3L,0L,1L,5L,4L,6L,8L,9L,0L,4L,9L,0L,7L,7L,1L,6L,0L,1L,3L,2L,3L,4L,1L,5L,2L,5L,0L,4L,8L,8L,5L,5L,4L,4L,8L,0L,2L,6L,4L,4L,4L,1L,3L,2L,2L,1L,8L,1L,3L,3L,0L,5L,3L,0L,3L,1L,9L,3L,4L,3L,8L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011464Inst : IEnumerable<long>
{
public static readonly long[] Value=A011464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011464.Bytes);
public long this[int i]=>Value[i];

public static A011464Inst Instance=new A011464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011463
{
public static readonly long[] Value={ 1L,0L,8L,9L,8L,1L,1L,0L,2L,5L,2L,2L,9L,8L,9L,0L,7L,0L,8L,3L,2L,2L,5L,8L,0L,2L,4L,5L,5L,1L,5L,4L,5L,8L,6L,7L,8L,8L,0L,0L,6L,2L,0L,8L,4L,6L,1L,0L,4L,1L,9L,2L,0L,6L,8L,4L,1L,7L,7L,7L,5L,5L,7L,8L,8L,9L,4L,2L,4L,5L,4L,2L,8L,5L,7L,9L,6L,9L,8L,6L,0L,7L,1L,6L,4L,1L,8L,9L,5L,3L,5L,2L,7L,9L,4L,9L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011463Inst : IEnumerable<long>
{
public static readonly long[] Value=A011463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011463.Bytes);
public long this[int i]=>Value[i];

public static A011463Inst Instance=new A011463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011462
{
public static readonly long[] Value={ 1L,0L,9L,1L,4L,0L,9L,2L,7L,0L,7L,8L,6L,5L,1L,3L,1L,9L,6L,0L,5L,5L,5L,8L,6L,4L,2L,4L,9L,9L,0L,9L,9L,9L,5L,0L,7L,5L,7L,0L,6L,2L,3L,7L,7L,0L,0L,1L,6L,4L,8L,0L,1L,8L,7L,3L,1L,9L,5L,9L,3L,9L,6L,8L,5L,2L,9L,4L,8L,3L,1L,3L,0L,8L,1L,4L,2L,7L,0L,4L,0L,2L,6L,6L,2L,7L,5L,3L,0L,6L,1L,0L,8L,5L,5L,3L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011462Inst : IEnumerable<long>
{
public static readonly long[] Value=A011462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011462.Bytes);
public long this[int i]=>Value[i];

public static A011462Inst Instance=new A011462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011461
{
public static readonly long[] Value={ 1L,0L,9L,3L,0L,7L,2L,0L,5L,7L,9L,3L,4L,8L,2L,3L,6L,1L,8L,6L,8L,2L,7L,8L,4L,7L,3L,1L,8L,5L,5L,6L,2L,5L,7L,8L,6L,2L,4L,2L,9L,0L,0L,4L,2L,8L,7L,3L,6L,9L,3L,6L,5L,6L,2L,1L,3L,5L,9L,1L,3L,9L,7L,4L,2L,6L,9L,2L,9L,0L,4L,3L,7L,2L,8L,9L,1L,5L,6L,0L,4L,4L,2L,7L,5L,3L,9L,0L,2L,2L,0L,4L,2L,5L,4L,2L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011461Inst : IEnumerable<long>
{
public static readonly long[] Value=A011461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011461.Bytes);
public long this[int i]=>Value[i];

public static A011461Inst Instance=new A011461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011460
{
public static readonly long[] Value={ 1L,0L,9L,4L,8L,0L,3L,5L,3L,6L,5L,0L,7L,2L,9L,5L,7L,3L,2L,8L,4L,2L,5L,0L,4L,8L,0L,1L,3L,2L,8L,5L,9L,3L,2L,3L,9L,5L,8L,6L,6L,7L,5L,0L,5L,9L,5L,3L,5L,0L,9L,5L,3L,0L,6L,6L,3L,3L,6L,2L,5L,5L,9L,9L,5L,1L,9L,7L,5L,8L,0L,1L,1L,1L,6L,8L,4L,4L,0L,4L,7L,1L,6L,7L,2L,9L,8L,6L,1L,1L,1L,1L,2L,6L,9L,3L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011460Inst : IEnumerable<long>
{
public static readonly long[] Value=A011460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011460.Bytes);
public long this[int i]=>Value[i];

public static A011460Inst Instance=new A011460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011459
{
public static readonly long[] Value={ 1L,0L,9L,6L,6L,0L,8L,2L,2L,7L,1L,2L,4L,3L,6L,1L,3L,8L,8L,2L,3L,0L,0L,1L,1L,1L,9L,1L,9L,5L,7L,6L,2L,8L,1L,4L,1L,4L,0L,5L,5L,2L,7L,0L,6L,1L,8L,6L,8L,5L,8L,8L,3L,8L,9L,3L,9L,5L,9L,1L,5L,1L,3L,4L,6L,2L,7L,1L,6L,2L,0L,3L,9L,1L,6L,2L,0L,5L,0L,1L,6L,2L,2L,5L,7L,7L,4L,0L,8L,8L,0L,6L,4L,6L,7L,6L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011459Inst : IEnumerable<long>
{
public static readonly long[] Value=A011459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011459.Bytes);
public long this[int i]=>Value[i];

public static A011459Inst Instance=new A011459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011458
{
public static readonly long[] Value={ 1L,0L,9L,8L,4L,9L,1L,0L,6L,4L,0L,2L,8L,1L,4L,7L,4L,7L,2L,8L,8L,1L,4L,0L,6L,6L,7L,0L,8L,3L,1L,3L,0L,3L,8L,9L,9L,8L,7L,5L,1L,8L,2L,4L,9L,8L,3L,8L,5L,3L,8L,1L,2L,3L,1L,2L,7L,9L,0L,7L,2L,0L,9L,7L,7L,4L,5L,2L,0L,0L,2L,0L,5L,0L,0L,1L,5L,1L,1L,0L,6L,7L,9L,7L,5L,3L,4L,3L,4L,9L,8L,2L,0L,8L,7L,1L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011458Inst : IEnumerable<long>
{
public static readonly long[] Value=A011458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011458.Bytes);
public long this[int i]=>Value[i];

public static A011458Inst Instance=new A011458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011457
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,5L,7L,4L,4L,4L,0L,3L,3L,7L,3L,1L,8L,3L,1L,7L,6L,7L,3L,6L,7L,5L,1L,3L,2L,8L,5L,1L,4L,5L,5L,7L,8L,7L,9L,5L,7L,0L,3L,2L,5L,7L,3L,3L,4L,3L,4L,9L,4L,6L,2L,4L,3L,4L,5L,4L,8L,3L,0L,7L,2L,8L,7L,9L,6L,2L,0L,5L,9L,4L,5L,4L,2L,7L,2L,4L,3L,3L,9L,2L,4L,0L,1L,2L,2L,3L,1L,5L,4L,3L,6L,5L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011457Inst : IEnumerable<long>
{
public static readonly long[] Value=A011457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011457.Bytes);
public long this[int i]=>Value[i];

public static A011457Inst Instance=new A011457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011456
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,1L,3L,2L,8L,2L,6L,4L,5L,6L,1L,0L,9L,4L,2L,1L,6L,5L,2L,7L,9L,9L,7L,5L,9L,0L,2L,1L,3L,2L,1L,2L,4L,0L,5L,2L,5L,7L,6L,2L,0L,7L,9L,9L,4L,1L,0L,0L,3L,3L,0L,8L,7L,8L,3L,0L,3L,6L,0L,3L,3L,1L,6L,0L,7L,9L,8L,9L,2L,3L,8L,3L,9L,4L,9L,0L,5L,3L,4L,0L,8L,5L,5L,8L,2L,4L,6L,0L,3L,8L,4L,4L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011456Inst : IEnumerable<long>
{
public static readonly long[] Value=A011456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011456.Bytes);
public long this[int i]=>Value[i];

public static A011456Inst Instance=new A011456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011455
{
public static readonly BigInteger[] Value={ 2L,6L,14L,46L,302L,8494L,2105646L,17181974830L,36028814200938798L,BigInteger.Parse("618970019678718951650500910"),BigInteger.Parse("22300745198530623760505737951367313156481326"),BigInteger.Parse("13803492693581127574869511746854796103432841704846511061692361604079918") };
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
public class A011455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011455Inst Instance=new A011455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011454
{
public static readonly long[] Value={ 1L,1L,0L,6L,9L,1L,9L,9L,8L,8L,3L,3L,2L,6L,9L,3L,7L,1L,4L,7L,6L,7L,4L,5L,8L,5L,1L,5L,1L,3L,3L,0L,6L,4L,9L,8L,6L,7L,1L,2L,4L,7L,3L,4L,1L,6L,8L,1L,6L,5L,2L,2L,0L,4L,8L,5L,7L,3L,8L,5L,1L,9L,0L,2L,7L,2L,1L,3L,9L,0L,5L,5L,9L,2L,5L,0L,0L,5L,9L,2L,8L,3L,3L,7L,7L,3L,2L,2L,4L,2L,1L,6L,4L,9L,3L,0L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011454Inst : IEnumerable<long>
{
public static readonly long[] Value=A011454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011454.Bytes);
public long this[int i]=>Value[i];

public static A011454Inst Instance=new A011454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011405
{
public static readonly long[] Value={ 1L,1L,9L,7L,9L,9L,3L,6L,9L,2L,7L,5L,6L,5L,5L,5L,9L,9L,9L,3L,8L,7L,7L,8L,3L,2L,7L,2L,0L,4L,7L,1L,4L,2L,5L,4L,0L,7L,7L,7L,5L,9L,4L,2L,8L,4L,5L,3L,7L,2L,2L,6L,8L,4L,2L,7L,3L,3L,3L,9L,2L,0L,7L,1L,7L,1L,3L,8L,0L,6L,6L,5L,5L,2L,6L,6L,1L,9L,8L,1L,8L,3L,7L,4L,8L,3L,0L,5L,6L,3L,3L,3L,9L,4L,0L,7L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011405Inst : IEnumerable<long>
{
public static readonly long[] Value=A011405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011405.Bytes);
public long this[int i]=>Value[i];

public static A011405Inst Instance=new A011405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011404
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,0L,8L,6L,1L,6L,9L,0L,0L,6L,2L,1L,9L,0L,9L,9L,2L,4L,8L,7L,3L,6L,8L,7L,8L,5L,6L,8L,9L,3L,1L,6L,4L,9L,3L,5L,8L,5L,8L,0L,9L,8L,9L,5L,3L,9L,1L,9L,3L,5L,6L,7L,7L,7L,1L,0L,3L,1L,3L,1L,7L,2L,9L,1L,1L,1L,7L,8L,3L,4L,7L,3L,2L,3L,1L,8L,5L,5L,5L,4L,9L,8L,0L,3L,3L,5L,4L,3L,9L,9L,1L,2L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011404Inst : IEnumerable<long>
{
public static readonly long[] Value=A011404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011404.Bytes);
public long this[int i]=>Value[i];

public static A011404Inst Instance=new A011404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011403
{
public static readonly long[] Value={ 1L,2L,2L,9L,3L,1L,2L,5L,6L,8L,2L,7L,1L,1L,4L,6L,8L,7L,0L,6L,0L,5L,1L,3L,0L,5L,4L,3L,9L,7L,3L,3L,9L,2L,4L,9L,4L,9L,6L,0L,4L,6L,8L,1L,6L,9L,4L,8L,6L,1L,0L,0L,2L,8L,1L,7L,3L,6L,3L,3L,3L,5L,8L,7L,3L,8L,8L,2L,7L,2L,3L,2L,4L,3L,2L,1L,4L,3L,7L,1L,9L,3L,2L,1L,9L,1L,0L,6L,1L,5L,0L,6L,9L,6L,4L,5L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011403Inst : IEnumerable<long>
{
public static readonly long[] Value=A011403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011403.Bytes);
public long this[int i]=>Value[i];

public static A011403Inst Instance=new A011403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011402
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,9L,1L,3L,2L,9L,3L,7L,9L,0L,3L,9L,4L,9L,0L,5L,9L,8L,3L,3L,9L,0L,6L,7L,8L,2L,7L,5L,9L,9L,2L,9L,2L,0L,4L,2L,9L,4L,8L,8L,3L,5L,0L,3L,6L,0L,8L,8L,9L,2L,5L,8L,6L,7L,3L,8L,7L,8L,1L,1L,7L,4L,8L,4L,4L,9L,4L,7L,9L,8L,6L,6L,5L,5L,8L,6L,7L,0L,7L,5L,4L,0L,3L,3L,7L,9L,4L,0L,3L,8L,7L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011402Inst : IEnumerable<long>
{
public static readonly long[] Value=A011402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011402.Bytes);
public long this[int i]=>Value[i];

public static A011402Inst Instance=new A011402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011401
{
public static readonly long[] Value={ 1L,2L,7L,2L,3L,4L,8L,3L,8L,2L,6L,6L,1L,1L,9L,8L,1L,2L,4L,3L,8L,8L,0L,5L,9L,7L,1L,8L,3L,7L,0L,5L,5L,5L,5L,7L,6L,4L,4L,4L,5L,9L,5L,8L,9L,1L,7L,3L,8L,9L,8L,7L,4L,9L,2L,2L,4L,3L,6L,8L,3L,6L,0L,3L,0L,3L,2L,6L,4L,9L,3L,9L,4L,5L,8L,6L,4L,4L,0L,6L,8L,4L,3L,2L,9L,0L,0L,0L,0L,5L,6L,0L,7L,6L,1L,7L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011401Inst : IEnumerable<long>
{
public static readonly long[] Value=A011401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011401.Bytes);
public long this[int i]=>Value[i];

public static A011401Inst Instance=new A011401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011400
{
public static readonly long[] Value={ 1L,3L,0L,0L,5L,1L,5L,9L,4L,8L,1L,2L,0L,2L,8L,8L,9L,8L,5L,5L,9L,5L,6L,1L,9L,2L,7L,7L,2L,0L,5L,2L,5L,6L,0L,9L,6L,6L,0L,7L,7L,3L,1L,9L,2L,2L,5L,6L,7L,8L,3L,1L,0L,4L,9L,6L,1L,9L,1L,2L,6L,5L,5L,0L,8L,5L,9L,0L,1L,3L,3L,0L,3L,6L,3L,6L,2L,9L,5L,2L,5L,7L,5L,0L,0L,1L,7L,6L,1L,8L,9L,7L,0L,0L,1L,1L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011400Inst : IEnumerable<long>
{
public static readonly long[] Value=A011400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011400.Bytes);
public long this[int i]=>Value[i];

public static A011400Inst Instance=new A011400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011399
{
public static readonly long[] Value={ 1L,3L,3L,5L,1L,4L,1L,3L,6L,2L,5L,4L,0L,3L,1L,2L,9L,4L,0L,7L,3L,6L,7L,3L,8L,7L,8L,0L,7L,0L,3L,1L,7L,1L,7L,2L,0L,3L,5L,3L,6L,1L,5L,8L,9L,8L,4L,7L,8L,0L,8L,1L,7L,6L,0L,3L,8L,1L,8L,4L,7L,7L,2L,8L,4L,1L,1L,6L,1L,8L,9L,7L,8L,4L,4L,8L,8L,2L,8L,0L,0L,9L,6L,7L,9L,3L,2L,1L,5L,2L,4L,8L,7L,5L,6L,4L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011399Inst : IEnumerable<long>
{
public static readonly long[] Value=A011399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011399.Bytes);
public long this[int i]=>Value[i];

public static A011399Inst Instance=new A011399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011398
{
public static readonly long[] Value={ 1L,3L,7L,8L,7L,1L,5L,7L,0L,5L,3L,4L,1L,7L,2L,8L,6L,0L,4L,1L,4L,5L,6L,6L,0L,2L,6L,7L,1L,9L,7L,5L,4L,9L,9L,0L,6L,5L,3L,4L,2L,8L,5L,9L,4L,6L,2L,2L,6L,4L,7L,5L,2L,7L,7L,4L,6L,3L,7L,2L,0L,5L,1L,6L,4L,9L,4L,3L,1L,0L,4L,2L,9L,1L,5L,8L,1L,3L,0L,7L,8L,9L,9L,6L,2L,5L,2L,6L,7L,3L,1L,1L,7L,9L,5L,4L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011398Inst : IEnumerable<long>
{
public static readonly long[] Value=A011398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011398.Bytes);
public long this[int i]=>Value[i];

public static A011398Inst Instance=new A011398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011397
{
public static readonly long[] Value={ 1L,4L,3L,5L,1L,8L,8L,8L,8L,7L,8L,8L,4L,4L,8L,9L,4L,9L,4L,3L,9L,5L,0L,1L,7L,4L,2L,3L,7L,6L,0L,8L,4L,0L,9L,0L,3L,6L,6L,1L,4L,2L,6L,7L,2L,1L,7L,6L,8L,0L,7L,2L,1L,1L,6L,4L,7L,3L,3L,4L,3L,5L,8L,3L,7L,8L,3L,1L,1L,5L,4L,6L,5L,2L,7L,3L,8L,4L,1L,7L,5L,1L,8L,8L,6L,4L,9L,2L,6L,6L,0L,0L,5L,5L,9L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011397Inst : IEnumerable<long>
{
public static readonly long[] Value=A011397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011397.Bytes);
public long this[int i]=>Value[i];

public static A011397Inst Instance=new A011397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011396
{
public static readonly long[] Value={ 1L,5L,1L,1L,2L,0L,9L,3L,9L,0L,5L,0L,9L,4L,0L,3L,1L,3L,5L,6L,9L,1L,0L,3L,4L,1L,1L,1L,4L,1L,3L,2L,9L,1L,5L,0L,9L,5L,4L,9L,3L,0L,8L,8L,1L,9L,6L,5L,6L,0L,1L,1L,6L,9L,9L,0L,7L,7L,8L,0L,1L,3L,6L,5L,3L,4L,7L,7L,5L,3L,8L,0L,2L,7L,9L,1L,2L,3L,2L,5L,1L,8L,6L,6L,2L,1L,9L,9L,7L,0L,0L,5L,6L,0L,7L,3L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011396Inst : IEnumerable<long>
{
public static readonly long[] Value=A011396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011396.Bytes);
public long this[int i]=>Value[i];

public static A011396Inst Instance=new A011396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011395
{
public static readonly long[] Value={ 1L,6L,1L,8L,8L,7L,0L,4L,0L,6L,8L,6L,0L,5L,6L,6L,6L,5L,1L,9L,3L,0L,3L,4L,8L,0L,0L,5L,2L,7L,0L,5L,9L,2L,2L,1L,9L,9L,8L,4L,4L,6L,7L,5L,0L,3L,9L,8L,3L,5L,4L,1L,5L,0L,0L,3L,9L,4L,9L,7L,4L,1L,0L,3L,1L,1L,7L,5L,8L,6L,5L,8L,0L,4L,9L,0L,2L,0L,7L,6L,1L,1L,7L,8L,0L,1L,7L,3L,2L,7L,0L,8L,1L,3L,2L,6L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011395Inst : IEnumerable<long>
{
public static readonly long[] Value=A011395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011395.Bytes);
public long this[int i]=>Value[i];

public static A011395Inst Instance=new A011395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011394
{
public static readonly long[] Value={ 1L,1L,5L,2L,1L,8L,5L,6L,0L,7L,8L,2L,9L,1L,0L,2L,8L,4L,9L,9L,8L,7L,1L,9L,1L,9L,2L,9L,1L,2L,3L,0L,6L,6L,8L,1L,9L,4L,5L,2L,0L,0L,4L,1L,4L,7L,7L,2L,1L,8L,8L,3L,4L,6L,3L,6L,5L,5L,2L,7L,1L,8L,1L,0L,0L,5L,9L,2L,0L,6L,6L,1L,8L,3L,4L,9L,7L,3L,9L,3L,4L,1L,2L,3L,8L,9L,1L,6L,0L,1L,5L,6L,9L,2L,1L,0L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011394Inst : IEnumerable<long>
{
public static readonly long[] Value=A011394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011394.Bytes);
public long this[int i]=>Value[i];

public static A011394Inst Instance=new A011394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011393
{
public static readonly long[] Value={ 1L,1L,6L,0L,8L,0L,8L,2L,0L,5L,9L,6L,1L,6L,9L,4L,4L,5L,8L,3L,7L,3L,3L,0L,6L,6L,4L,9L,3L,6L,7L,5L,4L,1L,7L,2L,8L,9L,1L,0L,0L,5L,4L,8L,3L,8L,1L,5L,8L,7L,8L,8L,8L,7L,2L,4L,7L,7L,2L,0L,7L,8L,7L,0L,7L,0L,0L,3L,9L,8L,4L,6L,1L,1L,0L,6L,1L,5L,0L,0L,8L,0L,7L,7L,5L,9L,4L,6L,0L,0L,0L,2L,3L,6L,9L,9L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011393Inst : IEnumerable<long>
{
public static readonly long[] Value=A011393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011393.Bytes);
public long this[int i]=>Value[i];

public static A011393Inst Instance=new A011393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011392
{
public static readonly long[] Value={ 1L,1L,7L,0L,4L,6L,4L,5L,7L,3L,4L,6L,6L,3L,4L,1L,9L,1L,1L,6L,1L,1L,0L,6L,4L,5L,8L,8L,8L,4L,9L,7L,6L,4L,4L,4L,5L,4L,5L,8L,3L,4L,7L,7L,4L,1L,1L,0L,5L,8L,8L,3L,9L,1L,3L,6L,7L,6L,6L,9L,3L,4L,1L,9L,0L,2L,5L,4L,2L,1L,6L,7L,2L,3L,2L,1L,4L,8L,6L,7L,0L,3L,5L,9L,6L,5L,1L,2L,5L,6L,5L,1L,1L,8L,9L,9L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011392Inst : IEnumerable<long>
{
public static readonly long[] Value=A011392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011392.Bytes);
public long this[int i]=>Value[i];

public static A011392Inst Instance=new A011392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011391
{
public static readonly long[] Value={ 1L,1L,8L,1L,3L,5L,2L,0L,7L,4L,6L,2L,5L,5L,4L,5L,7L,2L,1L,5L,4L,0L,1L,5L,5L,6L,9L,3L,0L,5L,5L,3L,1L,0L,6L,3L,2L,5L,0L,3L,5L,3L,2L,3L,2L,9L,9L,9L,1L,6L,7L,1L,0L,6L,4L,4L,5L,4L,6L,2L,9L,8L,6L,4L,6L,3L,3L,0L,5L,1L,5L,8L,2L,9L,0L,7L,2L,6L,8L,5L,8L,2L,3L,7L,7L,4L,0L,2L,2L,9L,3L,7L,0L,2L,2L,4L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011391Inst : IEnumerable<long>
{
public static readonly long[] Value=A011391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011391.Bytes);
public long this[int i]=>Value[i];

public static A011391Inst Instance=new A011391Inst();

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