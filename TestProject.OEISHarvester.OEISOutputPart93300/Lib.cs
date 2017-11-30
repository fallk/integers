using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112941
{
public static readonly BigInteger[] Value={ 1L,9L,121L,2209L,51401L,1457649L,48774041L,1880312129L,82028211241L,3993290362449L,214543742998201L,12606663551853409L,804145149477634121L,BigInteger.Parse("55332318403485181809"),BigInteger.Parse("4084986234723143402201"),BigInteger.Parse("322064057582671115832449") };
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
public class A112941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112941Inst Instance=new A112941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112942
{
public static readonly BigInteger[] Value={ 1L,1L,6L,66L,1086L,24186L,684006L,23506626L,951191646L,44281107066L,2330310876486L,136747268000706L,8851092668419326L,626304664252772346L,BigInteger.Parse("48092138192079689766"),BigInteger.Parse("3982448437177141451586"),BigInteger.Parse("353746119265020213643806") };
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
public class A112942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112942Inst Instance=new A112942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112943
{
public static readonly BigInteger[] Value={ 1L,11L,181L,4031L,114001L,3917771L,158531941L,7380184511L,388385146081L,22791211333451L,1475182111403221L,104384110708795391L,8015356365346614961L,BigInteger.Parse("663741406196190241931"),BigInteger.Parse("58957686544170035607301") };
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
public class A112943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112943Inst Instance=new A112943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112944
{
public static readonly BigInteger[] Value={ 1L,2L,7L,39L,308L,3013L,33300L,394340L,4878109L,62232321L,812825244L,10818489817L,146250545528L,2003199281223L,27747288947266L,388087900316025L,5474206895126243L,77795972452841542L,1112947041203866164L,16016508647052018408UL,BigInteger.Parse("231727628211887783830"),BigInteger.Parse("3368855109532696440867") };
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
public class A112944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112944Inst Instance=new A112944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112945
{
public static readonly BigInteger[] Value={ 0L,6L,468L,80600L,16016560L,3360790440L,728936019504L,161858688461184L,36580777518027600L,8382066029146609800L,BigInteger.Parse("1941971956789550319920"),BigInteger.Parse("454006489072843947528288"),BigInteger.Parse("106944132919124515725427808") };
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
public class A112945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112945Inst Instance=new A112945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112946
{
public static readonly BigInteger[] Value={ 0L,26L,111096L,513654400L,2243178389200L,9550256850912960L,BigInteger.Parse("40141310067406592352"),BigInteger.Parse("167483578096089845880576"),BigInteger.Parse("695587719666862982630642400"),BigInteger.Parse("2880023438585172541459822939200") };
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
public class A112946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112946Inst Instance=new A112946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112947
{
public static readonly BigInteger[] Value={ 0L,1904L,17313263640L,53786496621600480L,BigInteger.Parse("115106032016630589567220"),BigInteger.Parse("204887911426306253833736206368"),BigInteger.Parse("326950476035695538194385010882728640"),BigInteger.Parse("485422668906114651402145718767396615062912") };
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
public class A112947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112947Inst Instance=new A112947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112948
{
public static readonly long[] Value={ 2L,6L,26L,191L,1904L,22078L,282388L,3848001L,54953996L,814302292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112948Inst : IEnumerable<long>
{
public static readonly long[] Value=A112948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112948.Bytes);
public long this[int i]=>Value[i];

public static A112948Inst Instance=new A112948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112949
{
public static readonly BigInteger[] Value={ 7L,468L,111096L,39670362L,17313263640L,8581243954044L,4650485509103976L,2692853733312152946L,BigInteger.Parse("1641063780244320916056"),BigInteger.Parse("1041574815624514527248040") };
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
public class A112949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112949Inst Instance=new A112949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112950
{
public static readonly BigInteger[] Value={ 39L,80600L,513654400L,4742588317460L,53786496621600480L,BigInteger.Parse("696401295433093120200"),BigInteger.Parse("9891028759926839453714800"),BigInteger.Parse("150420303869075439022288355100"),BigInteger.Parse("2410984386008752279281147366400400") };
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
public class A112950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112950Inst Instance=new A112950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112951
{
public static readonly long[] Value={ 1L,2L,5L,16L,63L,271L,1225L,5726L,27461L,134461L,669795L,3384945L,17316771L,89518347L,466932059L,2454546192L,12990743783L,69164599115L,370186756425L,1990638982239L,10749412063853L,58265968105385L,316903203993921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112951Inst : IEnumerable<long>
{
public static readonly long[] Value=A112951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112951.Bytes);
public long this[int i]=>Value[i];

public static A112951Inst Instance=new A112951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112952
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,11L,10L,10L,1L,0L,0L,1L,0L,0L,111L,110L,110L,101L,100L,100L,101L,100L,100L,11L,10L,10L,1L,0L,0L,1L,0L,0L,11L,10L,10L,1L,0L,0L,1L,0L,0L,1111L,1110L,1110L,1101L,1100L,1100L,1101L,1100L,1100L,1011L,1010L,1010L,1001L,1000L,1000L,1001L,1000L,1000L,1011L,1010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112952Inst : IEnumerable<long>
{
public static readonly long[] Value=A112952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112952.Bytes);
public long this[int i]=>Value[i];

public static A112952Inst Instance=new A112952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112953
{
public static readonly long[] Value={ 0L,1L,4L,4L,27L,27L,256L,256L,256L,256L,3125L,3125L,46656L,46656L,46656L,46656L,823543L,823543L,16777216L,16777216L,16777216L,16777216L,387420489L,387420489L,387420489L,387420489L,387420489L,387420489L,10000000000L,10000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112953Inst : IEnumerable<long>
{
public static readonly long[] Value=A112953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112953.Bytes);
public long this[int i]=>Value[i];

public static A112953Inst Instance=new A112953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112954
{
public static readonly long[] Value={ 7L,9L,10L,9L,7L,17L,4L,17L,14L,15L,7L,19L,2L,16L,20L,21L,0L,29L,0L,29L,9L,13L,7L,32L,7L,11L,23L,21L,7L,39L,0L,19L,17L,4L,11L,44L,2L,0L,11L,41L,7L,24L,2L,19L,30L,11L,0L,55L,4L,23L,7L,21L,7L,46L,9L,27L,4L,11L,0L,61L,0L,0L,27L,29L,9L,30L,2L,10L,19L,31L,0L,57L,2L,9L,27L,4L,4L,30L,2L,50L,29L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112954Inst : IEnumerable<long>
{
public static readonly long[] Value=A112954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112954.Bytes);
public long this[int i]=>Value[i];

public static A112954Inst Instance=new A112954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112955
{
public static readonly long[] Value={ 30L,120L,210L,420L,330L,840L,294L,1260L,1080L,1320L,690L,2520L,318L,1470L,2310L,3360L,0L,3780L,0L,4620L,1290L,2760L,1410L,5460L,3000L,1590L,7560L,5880L,1770L,9240L,0L,10080L,4830L,1236L,3234L,10920L,894L,0L,2370L,13860L,2490L,6090L,1038L,9660L,11880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112955Inst : IEnumerable<long>
{
public static readonly long[] Value=A112955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112955.Bytes);
public long this[int i]=>Value[i];

public static A112955Inst Instance=new A112955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112956
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,5L,11L,10L,1L,79L,165L,1L,664L,2917L,3308L,9295L,23729L,31874L,301029L,422896L,1L,13716866L,71504979L,100664384L,54148590L,880696661L,498017758L,27450476786L,111911522818L,179459955553L,2144502175213L,59115423982L,45837019664551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112956Inst : IEnumerable<long>
{
public static readonly long[] Value=A112956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112956.Bytes);
public long this[int i]=>Value[i];

public static A112956Inst Instance=new A112956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112957
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,11L,131L,17291L,298995963L,89398586189293211L,BigInteger.Parse("7992107212644486930829797919966571"),BigInteger.Parse("63873777698404030240264509605345282496735163325301838600463378485931") };
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
public class A112957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112957Inst Instance=new A112957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112958
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,19L,379L,144019L,20741616379L,BigInteger.Parse("430214650034342688004"),BigInteger.Parse("185084645104171955001009752069374428191659") };
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
public class A112958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112958Inst Instance=new A112958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112959
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,5L,29L,869L,756029L,571580604869L,BigInteger.Parse("326704387862983487112029"),BigInteger.Parse("106735757048926752040856495274871386126283608845") };
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
public class A112959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112959Inst Instance=new A112959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112960
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,6L,41L,1721L,2963561L,8782696764281L,BigInteger.Parse("77135762453320729974211241"),BigInteger.Parse("5949925849255124079413733148488788342637650064971321") };
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
public class A112960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112960Inst Instance=new A112960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112961
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,737L,400316282L,BigInteger.Parse("64151935432803278787493321"),BigInteger.Parse("264015418305763603932856608512044494366944180663171458205345412119783805892929") };
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
public class A112961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112961Inst Instance=new A112961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112962
{
public static readonly long[] Value={ 0L,1L,0L,0L,-1L,-1L,-4L,-2L,-5L,-8L,-5L,-8L,-9L,-11L,-10L,-24L,1L,-21L,-11L,-23L,-15L,-37L,4L,-42L,-11L,-38L,-7L,-49L,6L,-63L,-12L,-44L,-3L,-81L,10L,-106L,7L,-49L,-8L,-92L,15L,-103L,2L,-72L,-5L,-114L,41L,-140L,-3L,-114L,8L,-113L,49L,-179L,3L,-135L,27L,-131L,46L,-218L,-7L,-99L,32L,-185L,72L,-259L,50L,-104L,23L,-211L,52L,-248L,43L,-153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112962Inst : IEnumerable<long>
{
public static readonly long[] Value=A112962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112962.Bytes);
public long this[int i]=>Value[i];

public static A112962Inst Instance=new A112962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112963
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,-4L,-2L,-5L,-5L,-4L,-7L,-4L,-6L,-7L,-11L,0L,-12L,-1L,-11L,-6L,-12L,-1L,-20L,2L,-13L,-2L,-16L,2L,-19L,9L,-18L,-9L,-20L,4L,-31L,10L,-21L,-2L,-18L,7L,-20L,14L,-26L,-3L,-16L,13L,-40L,5L,-26L,7L,-22L,-1L,-40L,18L,-32L,2L,-21L,10L,-40L,16L,-25L,5L,-21L,17L,-41L,31L,-40L,-4L,-14L,30L,-38L,3L,-39L,8L,-21L,14L,-58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112963Inst : IEnumerable<long>
{
public static readonly long[] Value=A112963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112963.Bytes);
public long this[int i]=>Value[i];

public static A112963Inst Instance=new A112963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112964
{
public static readonly long[] Value={ 0L,1L,2L,0L,0L,-6L,-3L,-12L,-11L,-13L,-22L,-19L,-20L,-30L,-41L,-15L,-55L,-24L,-52L,-41L,-59L,-24L,-109L,-22L,-78L,-42L,-111L,-26L,-131L,-2L,-119L,-75L,-133L,-8L,-214L,7L,-175L,-68L,-176L,-17L,-209L,14L,-231L,-73L,-175L,45L,-349L,-11L,-236L,-20L,-236L,-53L,-384L,68L,-321L,-56L,-270L,1L,-457L,41L,-328L,-48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112964Inst : IEnumerable<long>
{
public static readonly long[] Value=A112964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112964.Bytes);
public long this[int i]=>Value[i];

public static A112964Inst Instance=new A112964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112965
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,4L,7L,8L,9L,10L,14L,14L,17L,18L,23L,24L,27L,26L,32L,32L,35L,36L,44L,42L,47L,48L,52L,50L,58L,54L,65L,62L,67L,66L,78L,70L,79L,78L,88L,84L,94L,88L,100L,100L,103L,100L,118L,106L,119L,114L,124L,116L,135L,122L,138L,134L,141L,136L,155L,142L,155L,154L,163L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112965Inst : IEnumerable<long>
{
public static readonly long[] Value=A112965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112965.Bytes);
public long this[int i]=>Value[i];

public static A112965Inst Instance=new A112965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112966
{
public static readonly long[] Value={ 0L,0L,1L,0L,-1L,-1L,-1L,-2L,-3L,-2L,-2L,-1L,-3L,-3L,-4L,0L,-6L,-1L,-4L,-1L,-3L,-3L,-7L,0L,-5L,-3L,-3L,0L,-5L,1L,-5L,-2L,-10L,-1L,-8L,4L,-8L,-3L,-4L,2L,-6L,0L,-5L,-1L,-4L,-2L,-11L,3L,-8L,-1L,-8L,-1L,-11L,2L,-8L,2L,-7L,-3L,-9L,5L,-2L,-5L,-7L,2L,-11L,7L,-6L,0L,-4L,1L,-9L,4L,-12L,-3L,-6L,0L,-10L,2L,-7L,-1L,-10L,-8L,-12L,6L,-13L,-2L,-12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112966Inst : IEnumerable<long>
{
public static readonly long[] Value=A112966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112966.Bytes);
public long this[int i]=>Value[i];

public static A112966Inst Instance=new A112966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112967
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,6L,10L,10L,17L,18L,26L,24L,33L,30L,41L,38L,52L,46L,64L,54L,71L,62L,87L,70L,91L,80L,106L,90L,116L,100L,130L,112L,139L,120L,163L,130L,161L,144L,185L,152L,190L,162L,208L,172L,205L,178L,244L,186L,232L,208L,262L,212L,267L,218L,291L,246L,287L,248L,329L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112967Inst : IEnumerable<long>
{
public static readonly long[] Value=A112967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112967.Bytes);
public long this[int i]=>Value[i];

public static A112967Inst Instance=new A112967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112968
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,-2L,-2L,-2L,-2L,-2L,-6L,-2L,-4L,-2L,-7L,-1L,-5L,0L,-7L,-3L,-9L,1L,-11L,2L,-7L,1L,-12L,1L,-11L,7L,-8L,-5L,-8L,-1L,-18L,3L,-10L,1L,-13L,1L,-7L,13L,-12L,-2L,-13L,6L,-16L,3L,-11L,3L,-15L,-4L,-16L,13L,-15L,-4L,-15L,4L,-17L,11L,-14L,4L,-13L,7L,-12L,15L,-17L,-5L,-15L,16L,-13L,3L,-12L,3L,-20L,3L,-27L,19L,-20L,-3L,-11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112968Inst : IEnumerable<long>
{
public static readonly long[] Value=A112968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112968.Bytes);
public long this[int i]=>Value[i];

public static A112968Inst Instance=new A112968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112969
{
public static readonly BigInteger[] Value={ 1L,1L,2L,17L,83537L,BigInteger.Parse("48698490414981559682"),BigInteger.Parse("5624216052381164150697569400035392464306474190030694298257552124199835791859537") };
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
public class A112969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112969Inst Instance=new A112969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112970
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,4L,2L,2L,1L,5L,3L,3L,2L,5L,2L,3L,1L,6L,4L,3L,2L,6L,2L,3L,1L,7L,5L,4L,3L,8L,3L,5L,2L,8L,5L,4L,2L,8L,3L,3L,1L,9L,6L,5L,4L,9L,3L,6L,2L,9L,6L,4L,2L,9L,3L,3L,1L,10L,7L,6L,5L,11L,4L,8L,3L,12L,8L,6L,3L,13L,5L,5L,2L,13L,8L,7L,5L,12L,4L,7L,2L,12L,8L,5L,3L,11L,3L,4L,1L,12L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112970Inst : IEnumerable<long>
{
public static readonly long[] Value=A112970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112970.Bytes);
public long this[int i]=>Value[i];

public static A112970Inst Instance=new A112970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112971
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,4L,2L,2L,1L,6L,3L,4L,2L,4L,2L,2L,1L,8L,4L,4L,2L,4L,2L,2L,1L,11L,6L,6L,3L,8L,4L,4L,2L,8L,4L,4L,2L,4L,2L,2L,1L,16L,8L,8L,4L,8L,4L,4L,2L,8L,4L,4L,2L,4L,2L,2L,1L,22L,11L,12L,6L,12L,6L,6L,3L,16L,8L,8L,4L,8L,4L,4L,2L,16L,8L,8L,4L,8L,4L,4L,2L,8L,4L,4L,2L,4L,2L,2L,1L,32L,16L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112971Inst : IEnumerable<long>
{
public static readonly long[] Value=A112971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112971.Bytes);
public long this[int i]=>Value[i];

public static A112971Inst Instance=new A112971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112972
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,3L,9L,0L,43L,102L,0L,595L,1480L,0L,9294L,23728L,0L,157991L,411474L,0L,2849968L,7562583L,0L,53987864L,145173095L,0L,1061533318L,2885383960L,0L,21515805520L,59003023409L,0L,447142442841L,1235311936936L,0L,9489835046489L,26382363207307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112972Inst : IEnumerable<long>
{
public static readonly long[] Value=A112972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112972.Bytes);
public long this[int i]=>Value[i];

public static A112972Inst Instance=new A112972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112973
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,3L,12L,7L,1L,5L,31L,31L,10L,1L,8L,73L,110L,59L,13L,1L,13L,162L,340L,267L,96L,16L,1L,21L,344L,956L,1022L,529L,142L,19L,1L,34L,707L,2507L,3479L,2416L,923L,197L,22L,1L,55L,1416L,6231L,10850L,9657L,4900L,1476L,261L,25L,1L,89L,2778L,14840L,31606L,34905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112973Inst : IEnumerable<long>
{
public static readonly long[] Value=A112973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112973.Bytes);
public long this[int i]=>Value[i];

public static A112973Inst Instance=new A112973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112974
{
public static readonly long[] Value={ 1L,0L,3L,0L,2L,4L,0L,4L,6L,0L,2L,3L,6L,8L,6L,0L,10L,10L,5L,2L,11L,9L,10L,0L,9L,10L,12L,4L,13L,14L,15L,11L,6L,14L,0L,12L,2L,12L,11L,5L,10L,11L,12L,12L,12L,11L,11L,13L,13L,0L,15L,14L,3L,14L,16L,16L,8L,16L,17L,17L,19L,20L,16L,14L,7L,16L,2L,16L,14L,15L,3L,15L,15L,14L,18L,0L,16L,16L,16L,16L,16L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112974Inst : IEnumerable<long>
{
public static readonly long[] Value=A112974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112974.Bytes);
public long this[int i]=>Value[i];

public static A112974Inst Instance=new A112974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112975
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,9L,10L,12L,14L,15L,5L,16L,18L,20L,21L,7L,22L,24L,25L,26L,27L,28L,30L,32L,33L,11L,34L,35L,36L,38L,39L,13L,40L,42L,44L,45L,46L,48L,49L,50L,51L,17L,52L,54L,55L,56L,57L,19L,58L,60L,62L,63L,64L,65L,66L,68L,69L,23L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112975Inst : IEnumerable<long>
{
public static readonly long[] Value=A112975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112975.Bytes);
public long this[int i]=>Value[i];

public static A112975Inst Instance=new A112975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112976
{
public static readonly long[] Value={ 2L,3L,12L,17L,27L,33L,43L,49L,59L,74L,80L,94L,106L,112L,122L,138L,154L,159L,174L,186L,193L,208L,219L,235L,255L,267L,273L,283L,290L,301L,337L,348L,364L,371L,396L,402L,417L,434L,445L,462L,479L,485L,511L,517L,529L,535L,565L,596L,607L,613L,625L,642L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112976Inst : IEnumerable<long>
{
public static readonly long[] Value=A112976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112976.Bytes);
public long this[int i]=>Value[i];

public static A112976Inst Instance=new A112976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112977
{
public static readonly long[] Value={ 1L,2L,3L,8L,6L,10L,12L,14L,5L,18L,20L,4L,21L,22L,25L,26L,9L,27L,30L,32L,33L,11L,34L,36L,39L,13L,15L,40L,42L,44L,46L,48L,16L,49L,51L,52L,54L,55L,57L,19L,58L,60L,7L,62L,64L,65L,66L,68L,24L,69L,70L,74L,75L,76L,77L,78L,81L,82L,28L,84L,86L,29L,88L,90L,91L,92L,31L,94L,95L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112977Inst : IEnumerable<long>
{
public static readonly long[] Value=A112977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112977.Bytes);
public long this[int i]=>Value[i];

public static A112977Inst Instance=new A112977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112978
{
public static readonly long[] Value={ 1L,2L,3L,5L,12L,4L,17L,6L,7L,8L,27L,9L,33L,10L,11L,13L,43L,14L,49L,15L,16L,18L,59L,19L,20L,21L,22L,23L,74L,24L,80L,25L,26L,28L,29L,30L,94L,31L,32L,34L,106L,35L,112L,36L,37L,38L,122L,39L,40L,41L,42L,44L,138L,45L,46L,47L,48L,50L,154L,51L,159L,52L,53L,54L,55L,56L,174L,57L,58L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112978Inst : IEnumerable<long>
{
public static readonly long[] Value=A112978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112978.Bytes);
public long this[int i]=>Value[i];

public static A112978Inst Instance=new A112978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112979
{
public static readonly long[] Value={ 1L,2L,3L,12L,9L,5L,43L,4L,17L,6L,22L,7L,26L,8L,27L,33L,112L,10L,40L,11L,13L,14L,154L,49L,15L,16L,18L,59L,62L,19L,67L,20L,21L,23L,74L,24L,81L,80L,25L,28L,90L,29L,95L,30L,94L,31L,104L,32L,34L,106L,35L,36L,119L,37L,38L,122L,39L,41L,133L,42L,137L,44L,138L,45L,46L,47L,150L,48L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112979Inst : IEnumerable<long>
{
public static readonly long[] Value=A112979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112979.Bytes);
public long this[int i]=>Value[i];

public static A112979Inst Instance=new A112979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112980
{
public static readonly BigInteger[] Value={ 1L,1L,2L,33L,39135425L,BigInteger.Parse("91801604643057285538237803582627026018") };
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
public class A112980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112980.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112980Inst Instance=new A112980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112981
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,29L,24417L,14557168544129L,BigInteger.Parse("3084826414596074361107793217201624802791") };
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
public class A112981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112981.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112981Inst Instance=new A112981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112982
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,259L,4499860819L,BigInteger.Parse("410011770879070587605284428972195139939") };
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
public class A112982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112982Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112982.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112982.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112982Inst Instance=new A112982Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112983
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,2L,4L,0L,7L,8L,4L,8L,4L,8L,1L,0L,4L,2L,4L,12L,16L,8L,4L,8L,14L,8L,25L,4L,4L,8L,4L,0L,16L,8L,1L,20L,4L,8L,16L,32L,4L,2L,4L,32L,34L,8L,4L,32L,11L,48L,16L,32L,4L,2L,31L,8L,16L,8L,4L,32L,4L,8L,16L,0L,64L,62L,4L,32L,16L,18L,4L,56L,4L,8L,61L,32L,36L,50L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112983Inst : IEnumerable<long>
{
public static readonly long[] Value=A112983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112983.Bytes);
public long this[int i]=>Value[i];

public static A112983Inst Instance=new A112983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112984
{
public static readonly long[] Value={ 4L,10L,16L,28L,36L,50L,56L,76L,82L,106L,116L,120L,122L,134L,144L,162L,172L,176L,188L,190L,204L,216L,218L,232L,236L,244L,248L,254L,256L,262L,274L,280L,290L,296L,298L,300L,324L,334L,336L,344L,352L,364L,372L,396L,404L,406L,414L,426L,438L,452L,456L,474L,476L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112984Inst : IEnumerable<long>
{
public static readonly long[] Value=A112984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112984.Bytes);
public long this[int i]=>Value[i];

public static A112984Inst Instance=new A112984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112985
{
public static readonly long[] Value={ 1L,4L,1L,1L,2L,1L,16L,4L,16L,1L,128L,256L,16L,256L,16L,256L,2L,1L,16L,4L,16L,4096L,65536L,256L,16L,256L,16384L,256L,33554432L,16L,16L,256L,16L,1L,65536L,256L,2L,1048576L,16L,256L,65536L,4294967296L,16L,4L,16L,4294967296L,17179869184L,256L,16L,4294967296L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112985Inst : IEnumerable<long>
{
public static readonly long[] Value=A112985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112985.Bytes);
public long this[int i]=>Value[i];

public static A112985Inst Instance=new A112985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112986
{
public static readonly long[] Value={ 0L,0L,0L,3L,5L,7L,18L,22L,26L,45L,51L,57L,84L,92L,100L,135L,145L,155L,198L,210L,222L,273L,287L,301L,360L,376L,392L,459L,477L,495L,570L,590L,610L,693L,715L,737L,828L,852L,876L,975L,1001L,1027L,1134L,1162L,1190L,1305L,1335L,1365L,1488L,1520L,1552L,1683L,1717L,1751L,1890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112986Inst : IEnumerable<long>
{
public static readonly long[] Value=A112986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112986.Bytes);
public long this[int i]=>Value[i];

public static A112986Inst Instance=new A112986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112987
{
public static readonly long[] Value={ 2L,1L,1L,4L,1L,4L,16L,4L,1L,256L,16L,4L,16L,4L,16L,256L,1L,4L,1024L,4L,65536L,256L,16L,4L,65536L,128L,16L,67108864L,65536L,4L,16L,4L,1L,256L,16L,262144L,268435456L,4L,16L,256L,65536L,4L,4194304L,4L,65536L,131072L,16L,4L,65536L,1073741824L,16777216L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112987Inst : IEnumerable<long>
{
public static readonly long[] Value=A112987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112987.Bytes);
public long this[int i]=>Value[i];

public static A112987Inst Instance=new A112987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112988
{
public static readonly long[] Value={ 2L,5L,9L,12L,19L,23L,30L,34L,41L,52L,55L,65L,73L,77L,85L,95L,105L,110L,121L,128L,133L,143L,151L,162L,175L,182L,187L,195L,200L,208L,231L,239L,249L,253L,271L,276L,286L,298L,306L,318L,328L,332L,350L,354L,362L,366L,387L,408L,416L,420L,427L,439L,443L,461L,472L,483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112988Inst : IEnumerable<long>
{
public static readonly long[] Value=A112988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112988.Bytes);
public long this[int i]=>Value[i];

public static A112988Inst Instance=new A112988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112989
{
public static readonly long[] Value={ 8L,27L,64L,243L,512L,2048L,6561L,16384L,59049L,131072L,524288L,1594323L,4194304L,14348907L,33554432L,129140163L,268435456L,1073741824L,3486784401L,8589934592L,31381059609L,68719476736L,274877906944L,847288609443L,2199023255552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112989Inst : IEnumerable<long>
{
public static readonly long[] Value=A112989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112989.Bytes);
public long this[int i]=>Value[i];

public static A112989Inst Instance=new A112989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112990
{
public static readonly long[] Value={ 1L,2L,5L,3L,9L,4L,12L,6L,7L,8L,19L,10L,23L,11L,13L,14L,30L,15L,34L,16L,17L,18L,41L,20L,21L,22L,24L,25L,52L,26L,55L,27L,28L,29L,31L,32L,65L,33L,35L,36L,73L,37L,77L,38L,39L,40L,85L,42L,43L,44L,45L,46L,95L,47L,48L,49L,50L,51L,105L,53L,110L,54L,56L,57L,58L,59L,121L,60L,61L,62L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112990Inst : IEnumerable<long>
{
public static readonly long[] Value=A112990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112990.Bytes);
public long this[int i]=>Value[i];

public static A112990Inst Instance=new A112990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112991
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,5L,1L,0L,85L,5L,1L,5L,1L,5L,85L,0L,1L,341L,1L,21845L,85L,5L,1L,21845L,43L,5L,22369621L,21845L,1L,5L,1L,0L,85L,5L,87381L,89478485L,1L,5L,85L,21845L,1L,1398101L,1L,21845L,43691L,5L,1L,21845L,357913941L,5592405L,85L,21845L,1L,89478485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112991Inst : IEnumerable<long>
{
public static readonly long[] Value=A112991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112991.Bytes);
public long this[int i]=>Value[i];

public static A112991Inst Instance=new A112991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112992
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,16L,25L,32L,45L,55L,64L,91L,95L,99L,125L,128L,135L,143L,153L,155L,161L,175L,187L,225L,235L,245L,247L,256L,261L,273L,275L,279L,285L,289L,297L,319L,329L,333L,335L,355L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112992Inst : IEnumerable<long>
{
public static readonly long[] Value=A112992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112992.Bytes);
public long this[int i]=>Value[i];

public static A112992Inst Instance=new A112992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112993
{
public static readonly long[] Value={ 8L,27L,343L,512L,19683L,79507L,103823L,110592L,140608L,148877L,250047L,314432L,778688L,3869893L,5088448L,6539203L,7077888L,18191447L,54010152L,67917312L,75686967L,96071912L,102503232L,109215352L,115501303L,146363183L,202262003L,224755712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112993Inst : IEnumerable<long>
{
public static readonly long[] Value=A112993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112993.Bytes);
public long this[int i]=>Value[i];

public static A112993Inst Instance=new A112993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112994
{
public static readonly long[] Value={ 2L,3L,7L,8L,27L,43L,47L,48L,52L,53L,63L,68L,92L,157L,172L,187L,192L,263L,378L,408L,423L,458L,468L,478L,487L,527L,587L,608L,648L,692L,823L,843L,918L,1457L,1587L,1592L,4657L,4732L,5692L,6058L,6378L,7658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112994Inst : IEnumerable<long>
{
public static readonly long[] Value=A112994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112994.Bytes);
public long this[int i]=>Value[i];

public static A112994Inst Instance=new A112994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112995
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,9L,10L,10L,10L,11L,11L,13L,14L,14L,14L,14L,15L,15L,19L,20L,21L,21L,21L,21L,22L,22L,26L,28L,29L,29L,29L,29L,29L,30L,30L,37L,39L,40L,41L,41L,41L,41L,41L,42L,42L,50L,53L,54L,55L,55L,55L,55L,55L,55L,56L,56L,68L,72L,74L,75L,76L,76L,76L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112995Inst : IEnumerable<long>
{
public static readonly long[] Value=A112995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112995.Bytes);
public long this[int i]=>Value[i];

public static A112995Inst Instance=new A112995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112996
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,4L,2L,1L,15L,12L,10L,5L,1L,31L,32L,36L,30L,14L,1L,63L,80L,112L,124L,100L,43L,1L,127L,192L,320L,432L,472L,360L,144L,1L,255L,448L,864L,1360L,1832L,1924L,1390L,523L,1L,511L,1024L,2240L,3958L,6320L,8280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112996Inst : IEnumerable<long>
{
public static readonly long[] Value=A112996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112996.Bytes);
public long this[int i]=>Value[i];

public static A112996Inst Instance=new A112996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112997
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,20L,30L,41L,55L,74L,94L,119L,147L,176L,208L,245L,287L,330L,378L,429L,481L,538L,598L,663L,735L,810L,886L,965L,1045L,1128L,1224L,1323L,1427L,1532L,1646L,1761L,1881L,2006L,2134L,2267L,2405L,2544L,2692L,2841L,2993L,3146L,3310L,3485L,3663L,3842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112997Inst : IEnumerable<long>
{
public static readonly long[] Value=A112997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112997.Bytes);
public long this[int i]=>Value[i];

public static A112997Inst Instance=new A112997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112998
{
public static readonly long[] Value={ 61L,73L,193L,277L,397L,421L,613L,661L,757L,1093L,1237L,1453L,1657L,2137L,2341L,2593L,2797L,2917L,3217L,4177L,4621L,5233L,6121L,6133L,6217L,7057L,7537L,8101L,8317L,8353L,8521L,8677L,8893L,9013L,9277L,9721L,9817L,10357L,10957L,11161L,11677L,11701L,12301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112998Inst : IEnumerable<long>
{
public static readonly long[] Value=A112998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112998.Bytes);
public long this[int i]=>Value[i];

public static A112998Inst Instance=new A112998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112999
{
public static readonly BigInteger[] Value={ 1L,5L,221L,331997L,24883531997L,139314094387531997L,BigInteger.Parse("82606411393217618227531997"),BigInteger.Parse("6984964247224120535022357995827531997"),BigInteger.Parse("109110688415578301444592123476429107940843827531997") };
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
public class A112999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112999Inst Instance=new A112999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113000
{
public static readonly long[] Value={ 193L,421L,661L,1093L,1657L,2137L,2341L,2593L,6217L,7057L,8101L,9817L,12421L,12853L,15121L,16033L,16417L,17257L,17881L,19813L,20641L,21817L,25033L,25657L,27337L,28921L,30661L,31081L,31321L,31333L,32377L,35521L,36457L,38281L,40693L,45553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113000Inst : IEnumerable<long>
{
public static readonly long[] Value=A113000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113000.Bytes);
public long this[int i]=>Value[i];

public static A113000Inst Instance=new A113000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113001
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,6L,9L,7L,12L,8L,11L,10L,14L,13L,15L,19L,18L,17L,16L,20L,24L,22L,21L,26L,25L,23L,28L,27L,30L,32L,31L,37L,29L,39L,36L,33L,35L,42L,34L,45L,38L,40L,44L,43L,41L,48L,47L,52L,51L,49L,46L,53L,54L,55L,58L,57L,56L,60L,64L,50L,63L,62L,61L,59L,66L,65L,71L,70L,69L,67L,72L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113001Inst : IEnumerable<long>
{
public static readonly long[] Value=A113001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113001.Bytes);
public long this[int i]=>Value[i];

public static A113001Inst Instance=new A113001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113002
{
public static readonly long[] Value={ 5L,11L,11L,19L,23L,29L,37L,37L,53L,47L,59L,61L,71L,73L,83L,97L,97L,101L,103L,113L,127L,127L,131L,149L,151L,149L,163L,163L,173L,191L,193L,211L,197L,227L,223L,223L,233L,251L,241L,269L,257L,271L,281L,283L,281L,307L,317L,331L,331L,331L,331L,347L,359L,367L,379L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113002Inst : IEnumerable<long>
{
public static readonly long[] Value=A113002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113002.Bytes);
public long this[int i]=>Value[i];

public static A113002Inst Instance=new A113002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113003
{
public static readonly long[] Value={ 3L,7L,13L,17L,31L,41L,43L,67L,79L,89L,107L,109L,137L,139L,157L,167L,179L,181L,199L,229L,239L,263L,277L,293L,311L,313L,337L,349L,353L,373L,389L,401L,421L,439L,443L,457L,463L,467L,491L,499L,509L,523L,557L,569L,571L,599L,617L,619L,647L,659L,661L,683L,701L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113003Inst : IEnumerable<long>
{
public static readonly long[] Value=A113003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113003.Bytes);
public long this[int i]=>Value[i];

public static A113003Inst Instance=new A113003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113004
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,6L,8L,10L,7L,12L,11L,9L,14L,13L,15L,19L,18L,17L,16L,20L,23L,22L,26L,21L,25L,24L,28L,27L,33L,29L,31L,30L,36L,39L,37L,35L,32L,41L,34L,42L,45L,38L,44L,43L,40L,51L,47L,46L,50L,60L,49L,48L,52L,53L,54L,57L,56L,55L,64L,58L,63L,62L,61L,59L,66L,65L,70L,72L,69L,68L,67L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113004Inst : IEnumerable<long>
{
public static readonly long[] Value=A113004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113004.Bytes);
public long this[int i]=>Value[i];

public static A113004Inst Instance=new A113004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113005
{
public static readonly long[] Value={ 1L,4L,5L,6L,11L,15L,20L,22L,25L,31L,47L,62L,69L,76L,89L,93L,98L,105L,114L,137L,139L,152L,156L,159L,193L,197L,199L,211L,213L,214L,219L,249L,252L,255L,257L,276L,289L,294L,296L,303L,318L,332L,351L,361L,368L,377L,394L,398L,402L,403L,411L,415L,418L,427L,445L,451L,470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113005Inst : IEnumerable<long>
{
public static readonly long[] Value=A113005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113005.Bytes);
public long this[int i]=>Value[i];

public static A113005Inst Instance=new A113005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113006
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,12L,9L,10L,7L,11L,8L,13L,14L,15L,16L,17L,18L,19L,20L,26L,22L,24L,23L,25L,21L,27L,28L,32L,37L,31L,35L,30L,34L,33L,29L,36L,40L,39L,41L,42L,45L,43L,44L,38L,52L,47L,53L,46L,51L,48L,54L,55L,58L,60L,56L,57L,50L,59L,49L,61L,62L,63L,64L,65L,66L,72L,67L,69L,71L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113006Inst : IEnumerable<long>
{
public static readonly long[] Value=A113006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113006.Bytes);
public long this[int i]=>Value[i];

public static A113006Inst Instance=new A113006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113007
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,12L,8L,9L,11L,7L,13L,14L,15L,16L,17L,18L,19L,20L,26L,22L,24L,23L,25L,21L,27L,28L,36L,33L,31L,29L,35L,34L,32L,37L,30L,45L,39L,38L,40L,41L,43L,44L,42L,49L,47L,51L,60L,58L,50L,46L,48L,52L,53L,56L,57L,54L,59L,55L,61L,62L,63L,64L,65L,66L,68L,71L,69L,72L,70L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113007Inst : IEnumerable<long>
{
public static readonly long[] Value=A113007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113007.Bytes);
public long this[int i]=>Value[i];

public static A113007Inst Instance=new A113007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113008
{
public static readonly long[] Value={ 15121L,35521L,52321L,117841L,235441L,313561L,398821L,516421L,520021L,531121L,570601L,623641L,761113L,838561L,941041L,1117321L,1190821L,1317361L,1333621L,1336177L,1372081L,1413793L,1424041L,1431361L,1488901L,1513921L,1560121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113008Inst : IEnumerable<long>
{
public static readonly long[] Value=A113008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113008.Bytes);
public long this[int i]=>Value[i];

public static A113008Inst Instance=new A113008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113009
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,4L,9L,16L,25L,36L,49L,64L,81L,100L,121L,9L,16L,25L,36L,49L,64L,81L,100L,121L,144L,16L,25L,36L,49L,64L,81L,100L,121L,144L,169L,25L,36L,49L,64L,81L,100L,121L,144L,169L,196L,36L,49L,64L,81L,100L,121L,144L,169L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113009Inst : IEnumerable<long>
{
public static readonly long[] Value=A113009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113009.Bytes);
public long this[int i]=>Value[i];

public static A113009Inst Instance=new A113009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113010
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113010Inst : IEnumerable<long>
{
public static readonly long[] Value=A113010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113010.Bytes);
public long this[int i]=>Value[i];

public static A113010Inst Instance=new A113010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113011
{
public static readonly long[] Value={ 1L,5L,4L,1L,4L,9L,4L,0L,8L,2L,5L,3L,6L,7L,9L,8L,2L,8L,4L,1L,3L,1L,1L,0L,3L,4L,4L,4L,4L,7L,2L,5L,1L,4L,6L,3L,8L,3L,4L,0L,4L,5L,9L,2L,3L,6L,8L,4L,1L,8L,8L,2L,1L,0L,9L,4L,7L,4L,1L,3L,6L,9L,5L,6L,6L,3L,7L,5L,4L,2L,6L,3L,9L,1L,4L,3L,3L,1L,4L,8L,0L,7L,0L,7L,1L,8L,2L,5L,7L,2L,4L,0L,8L,5L,0L,0L,7L,7L,4L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113011Inst : IEnumerable<long>
{
public static readonly long[] Value=A113011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113011.Bytes);
public long this[int i]=>Value[i];

public static A113011Inst Instance=new A113011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113012
{
public static readonly BigInteger[] Value={ 1L,5L,29L,233L,2329L,27949L,78257L,6260561L,112690097L,2253801941L,49583642701L,47600296993L,30940193045449L,866325405272573L,25989762158177189L,831672389061670049L,5655372245619356333L,BigInteger.Parse("1017967004211484139941") };
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
public class A113012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113012Inst Instance=new A113012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113013
{
public static readonly BigInteger[] Value={ 1L,3L,19L,151L,1511L,18131L,50767L,4061359L,73104463L,1462089259L,32165963699L,30879325151L,20071561348151L,562003717748227L,16860111532446811L,539523569038297951L,3668760269460426067L,BigInteger.Parse("660376848502876692059") };
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
public class A113013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113013Inst Instance=new A113013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113014
{
public static readonly long[] Value={ 3L,7L,9L,7L,3L,1L,9L,5L,4L,7L,4L,0L,9L,9L,5L,6L,3L,2L,8L,0L,2L,1L,0L,6L,2L,5L,3L,6L,3L,4L,7L,5L,5L,3L,8L,1L,6L,1L,2L,5L,9L,4L,1L,6L,0L,3L,5L,9L,0L,8L,1L,2L,5L,3L,1L,5L,2L,6L,4L,3L,3L,4L,4L,9L,4L,4L,8L,8L,0L,5L,2L,5L,3L,7L,3L,6L,3L,5L,6L,7L,3L,8L,3L,1L,7L,4L,4L,4L,8L,3L,2L,3L,0L,7L,1L,5L,4L,8L,1L,7L,4L,8L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113014Inst : IEnumerable<long>
{
public static readonly long[] Value=A113014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113014.Bytes);
public long this[int i]=>Value[i];

public static A113014Inst Instance=new A113014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113015
{
public static readonly long[] Value={ 1L,6L,116L,1928L,27665L,364472L,4547586L,54670463L,639838113L,7338610159L,82857366967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113015Inst : IEnumerable<long>
{
public static readonly long[] Value=A113015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113015.Bytes);
public long this[int i]=>Value[i];

public static A113015Inst Instance=new A113015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113016
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,31L,37L,61L,67L,107L,131L,157L,167L,181L,241L,251L,271L,277L,307L,347L,397L,401L,421L,431L,457L,541L,557L,577L,587L,617L,647L,661L,701L,727L,751L,797L,881L,907L,971L,1021L,1051L,1061L,1087L,1151L,1201L,1231L,1297L,1301L,1367L,1471L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113016Inst : IEnumerable<long>
{
public static readonly long[] Value=A113016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113016.Bytes);
public long this[int i]=>Value[i];

public static A113016Inst Instance=new A113016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113017
{
public static readonly long[] Value={ 13L,19L,23L,29L,41L,43L,47L,53L,59L,71L,73L,79L,83L,89L,97L,101L,103L,109L,113L,127L,137L,139L,149L,151L,163L,173L,179L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,257L,263L,269L,281L,283L,293L,311L,313L,317L,331L,337L,349L,353L,359L,367L,373L,379L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113017Inst : IEnumerable<long>
{
public static readonly long[] Value=A113017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113017.Bytes);
public long this[int i]=>Value[i];

public static A113017Inst Instance=new A113017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113018
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113018Inst : IEnumerable<long>
{
public static readonly long[] Value=A113018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113018.Bytes);
public long this[int i]=>Value[i];

public static A113018Inst Instance=new A113018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113019
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L,64L,128L,256L,512L,2L,4L,8L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113019Inst : IEnumerable<long>
{
public static readonly long[] Value=A113019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113019.Bytes);
public long this[int i]=>Value[i];

public static A113019Inst Instance=new A113019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113020
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,-1L,0L,3L,-3L,2L,0L,4L,-6L,8L,-3L,0L,5L,-10L,20L,-15L,5L,0L,6L,-15L,40L,-45L,30L,-8L,0L,7L,-21L,70L,-105L,105L,-56L,13L,0L,8L,-28L,112L,-210L,280L,-224L,104L,-21L,0L,9L,-36L,168L,-378L,630L,-672L,468L,-189L,34L,0L,10L,-45L,240L,-630L,1260L,-1680L,1560L,-945L,340L,-55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113020Inst : IEnumerable<long>
{
public static readonly long[] Value=A113020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113020.Bytes);
public long this[int i]=>Value[i];

public static A113020Inst Instance=new A113020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113021
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,1L,1L,4L,9L,12L,11L,11L,21L,43L,66L,78L,88L,129L,226L,360L,485L,605L,826L,1287L,2012L,2881L,3851L,5239L,7669L,11592L,16936L,23596L,32581L,46498L,68366L,99913L,142173L,199384L,282701L,408720L,593595L,851835L,1207901L,1714447L,2458522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113021Inst : IEnumerable<long>
{
public static readonly long[] Value=A113021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113021.Bytes);
public long this[int i]=>Value[i];

public static A113021Inst Instance=new A113021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113022
{
public static readonly long[] Value={ 4L,21L,102L,503L,2504L,12505L,62506L,312507L,1562508L,7812509L,39062510L,195312511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113022Inst : IEnumerable<long>
{
public static readonly long[] Value=A113022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113022.Bytes);
public long this[int i]=>Value[i];

public static A113022Inst Instance=new A113022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113023
{
public static readonly long[] Value={ 5L,18L,90L,450L,2250L,11250L,56250L,281250L,1406250L,7031250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113023Inst : IEnumerable<long>
{
public static readonly long[] Value=A113023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113023.Bytes);
public long this[int i]=>Value[i];

public static A113023Inst Instance=new A113023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113024
{
public static readonly long[] Value={ 6L,0L,4L,8L,9L,8L,6L,4L,3L,4L,2L,1L,6L,3L,0L,3L,7L,0L,2L,4L,7L,2L,6L,5L,9L,1L,4L,2L,3L,5L,9L,5L,5L,4L,9L,9L,7L,5L,9L,7L,6L,2L,5L,4L,5L,1L,3L,0L,2L,4L,7L,3L,8L,0L,3L,7L,8L,5L,4L,6L,6L,4L,8L,0L,8L,2L,1L,8L,7L,2L,5L,3L,4L,9L,5L,0L,6L,0L,3L,5L,7L,3L,2L,7L,4L,0L,3L,9L,5L,6L,9L,1L,8L,3L,4L,9L,5L,5L,4L,3L,8L,3L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113024Inst : IEnumerable<long>
{
public static readonly long[] Value=A113024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113024.Bytes);
public long this[int i]=>Value[i];

public static A113024Inst Instance=new A113024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113025
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,12L,1L,12L,60L,120L,1L,20L,180L,840L,1680L,1L,30L,420L,3360L,15120L,30240L,1L,42L,840L,10080L,75600L,332640L,665280L,1L,56L,1512L,25200L,277200L,1995840L,8648640L,17297280L,1L,72L,2520L,55440L,831600L,8648640L,60540480L,259459200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113025Inst : IEnumerable<long>
{
public static readonly long[] Value=A113025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113025.Bytes);
public long this[int i]=>Value[i];

public static A113025Inst Instance=new A113025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113026
{
public static readonly long[] Value={ 25945920L,26611200L,28828800L,29937600L,31449600L,33264000L,33929280L,34594560L,34927200L,35380800L,37255680L,37699200L,37920960L,38918880L,39312000L,39916800L,40098240L,40360320L,41126400L,41277600L,41912640L,42134400L,43243200L,44029440L,44352000L,44553600L,44815680L,44906400L,45239040L,45904320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113026Inst : IEnumerable<long>
{
public static readonly long[] Value=A113026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113026.Bytes);
public long this[int i]=>Value[i];

public static A113026Inst Instance=new A113026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113027
{
public static readonly long[] Value={ 3632428800L,4151347200L,4410806400L,4540536000L,4670265600L,4750099200L,4843238400L,4929724800L,5145940800L,5189184000L,5292967680L,5308934400L,5428684800L,5448643200L,5613753600L,5708102400L,5751345600L,5811886080L,5837832000L,5881075200L,5915669760L,5937624000L,5967561600L,6054048000L,6067353600L,6107270400L,6175128960L,6227020800L,6274195200L,6333465600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113027Inst : IEnumerable<long>
{
public static readonly long[] Value=A113027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113027.Bytes);
public long this[int i]=>Value[i];

public static A113027Inst Instance=new A113027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113028
{
public static readonly long[] Value={ 1L,2L,54L,108L,152L,16200L,2042460L,4416720L,9867312L,2334364200L,421877610L,1779700673520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113028Inst : IEnumerable<long>
{
public static readonly long[] Value=A113028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113028.Bytes);
public long this[int i]=>Value[i];

public static A113028Inst Instance=new A113028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113029
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113029Inst : IEnumerable<long>
{
public static readonly long[] Value=A113029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113029.Bytes);
public long this[int i]=>Value[i];

public static A113029Inst Instance=new A113029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113030
{
public static readonly BigInteger[] Value={ 2L,31L,4231L,5431L,65423L,7652413L,8765423L,98765431L,10987653421L,111098765423L,12111098765413L,13121110987654231L,141312111098765213L,15141312111098763241UL,BigInteger.Parse("16151413121110987654213"),BigInteger.Parse("171615141312111098764523") };
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
public class A113030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113030.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113030Inst Instance=new A113030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113031
{
public static readonly BigInteger[] Value={ 1L,2L,3L,3L,7L,29L,4L,9L,289L,332929L,5L,11L,23L,47L,283L,6L,55L,111L,334L,335L,671L,7L,29L,59L,709L,2837L,22697L,590123L,8L,4913L,2084349468684419L,BigInteger.Parse("24848244676397648518313556708104734780186593641363") };
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
public class A113031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113031Inst Instance=new A113031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113032
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,5L,11L,21L,36L,57L,85L,121L,167L,228L,315L,449L,666L,1023L,1605L,2533L,3974L,6156L,9394L,14137L,21051L,31159L,46066L,68305L,101850L,152857L,230720L,349576L,530476L,804579L,1217951L,1838897L,2769267L,4161918L,6247570L,9375799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113032Inst : IEnumerable<long>
{
public static readonly long[] Value=A113032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113032.Bytes);
public long this[int i]=>Value[i];

public static A113032Inst Instance=new A113032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113033
{
public static readonly BigInteger[] Value={ 7L,73L,733L,7333L,513313L,35931913L,1796595653L,35931913063L,3952510436933L,513826356801293L,143871379904362043L,1438713799043620433L,14387137990436204333UL,BigInteger.Parse("2014199318661068606623") };
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
public class A113033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113033Inst Instance=new A113033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113034
{
public static readonly BigInteger[] Value={ 7L,79L,3169L,31699L,1584959L,110947139L,8875771129L,88757711299L,30177621841669L,10260391426167469L,718227399831722839L,BigInteger.Parse("222650493947834080099"),BigInteger.Parse("122457771671308744054459"),BigInteger.Parse("9796621733704699524356729"),BigInteger.Parse("6563736561582148681319008439"),BigInteger.Parse("3019318818327788393406743881949") };
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
public class A113034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113034Inst Instance=new A113034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113035
{
public static readonly long[] Value={ 0L,1L,1L,0L,3L,4L,0L,10L,17L,0L,46L,78L,0L,231L,401L,0L,1233L,2177L,0L,6869L,12268L,0L,39502L,71172L,0L,232686L,422076L,0L,1396669L,2547246L,0L,8512170L,15593760L,0L,52534875L,96598865L,0L,327669853L,604405633L,0L,2062171364L,3814087419L,0L,13078921499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113035Inst : IEnumerable<long>
{
public static readonly long[] Value=A113035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113035.Bytes);
public long this[int i]=>Value[i];

public static A113035Inst Instance=new A113035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113036
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,0L,8L,13L,0L,0L,69L,123L,0L,0L,719L,1313L,0L,0L,8215L,15260L,0L,0L,99774L,187615L,0L,0L,1264854L,2399207L,0L,0L,16544234L,31587644L,0L,0L,221625505L,425313967L,0L,0L,3025271756L,5829531261L,0L,0L,41929052284L,81066732018L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113036Inst : IEnumerable<long>
{
public static readonly long[] Value=A113036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113036.Bytes);
public long this[int i]=>Value[i];

public static A113036Inst Instance=new A113036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113037
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,5L,0L,0L,23L,39L,0L,0L,219L,396L,0L,0L,2406L,4435L,0L,0L,28431L,53167L,0L,0L,353500L,667874L,0L,0L,4557831L,8675836L,0L,0L,60382450L,115601178L,0L,0L,816998489L,1571272955L,0L,0L,11242173783L,21701318843L,0L,0L,156841667096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113037Inst : IEnumerable<long>
{
public static readonly long[] Value=A113037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113037.Bytes);
public long this[int i]=>Value[i];

public static A113037Inst Instance=new A113037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113038
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,5L,0L,0L,60L,0L,0L,747L,0L,0L,11076L,0L,0L,183092L,0L,0L,3238140L,0L,0L,60475317L,0L,0L,1175471401L,0L,0L,23600724220L,0L,0L,486653058995L,0L,0L,10260353188386L,0L,0L,220439819437387L,0L,0L,4813287355239594L,0L,0L,106583271423691692L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113038Inst : IEnumerable<long>
{
public static readonly long[] Value=A113038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113038.Bytes);
public long this[int i]=>Value[i];

public static A113038Inst Instance=new A113038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113039
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,5L,0L,23L,52L,0L,254L,593L,0L,3611L,8859L,0L,55554L,142169L,0L,946871L,2466282L,0L,17095813L,45359632L,0L,323760077L,870624976L,0L,6367406592L,17307580710L,0L,129063054631L,353941332518L,0L,2682355470491L,7410591325928L,0L,56930627178287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113039Inst : IEnumerable<long>
{
public static readonly long[] Value=A113039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113039.Bytes);
public long this[int i]=>Value[i];

public static A113039Inst Instance=new A113039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113040
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,45L,138L,439L,1417L,4698L,16021L,55146L,190274L,671224L,2404289L,8535117L,30635869L,110496946L,401422210L,1467402238L,5393176633L,19883249002L,73856531314L,273602448261L,1017563027699L,3803902663467L,14266523388813L,53564969402478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113040Inst : IEnumerable<long>
{
public static readonly long[] Value=A113040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113040.Bytes);
public long this[int i]=>Value[i];

public static A113040Inst Instance=new A113040Inst();

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