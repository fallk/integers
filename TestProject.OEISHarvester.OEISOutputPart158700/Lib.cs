using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238425
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,11L,34L,124L,512L,2380L,12294L,69972L,435399L,2942672L,21478882L,168473955L,1413823577L,12644505883L,120097766639L,1207617481139L,12818915877849L,143278176040760L,1682262113899134L,20704109403389717L,266568690074855277L,3583926627760681407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238425Inst : IEnumerable<long>
{
public static readonly long[] Value=A238425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238425.Bytes);
public long this[int i]=>Value[i];

public static A238425Inst Instance=new A238425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238426
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,13L,29L,65L,151L,359L,864L,2100L,5160L,12796L,31952L,80272L,202821L,515057L,1313716L,3364049L,8645559L,22291985L,57649712L,149496257L,388647248L,1012717568L,2644555020L,6919609962L,18139104129L,47632278280L,125282210973L,330016728365L,870564606345L,2299577632573L,6081963356452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238426Inst : IEnumerable<long>
{
public static readonly long[] Value=A238426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238426.Bytes);
public long this[int i]=>Value[i];

public static A238426Inst Instance=new A238426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238427
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,31L,81L,219L,599L,1669L,4698L,13378L,38414L,111200L,324026L,949930L,2799477L,8289481L,24649698L,73580353L,220402603L,662285725L,1995853152L,6030654313L,18266757996L,55454844238L,168704450182L,514231352572L,1570282693387L,4803220361258L,14715518413613L,45150691283345L,138726758012623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238427Inst : IEnumerable<long>
{
public static readonly long[] Value=A238427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238427.Bytes);
public long this[int i]=>Value[i];

public static A238427Inst Instance=new A238427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238428
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,17L,42L,118L,321L,920L,2626L,7679L,22554L,67115L,200883L,606238L,1839448L,5613892L,17211963L,53006846L,163866246L,508389780L,1582286912L,4939146731L,15459006948L,48505063741L,152539740067L,480726546083L,1517979996460L,4802074019769L,15217153748772L,48298352064093L,153526087484475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238428Inst : IEnumerable<long>
{
public static readonly long[] Value=A238428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238428.Bytes);
public long this[int i]=>Value[i];

public static A238428Inst Instance=new A238428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238429
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-3L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,-4L,0L,0L,0L,0L,0L,-4L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,-10L,0L,0L,0L,0L,0L,-5L,0L,0L,0L,0L,0L,23L,0L,0L,0L,0L,0L,-25L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,43L,0L,0L,0L,0L,0L,-57L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,74L,0L,0L,0L,0L,0L,-124L,0L,0L,0L,0L,0L,56L,0L,0L,0L,0L,0L,120L,0L,0L,0L,0L,0L,-258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238429Inst : IEnumerable<long>
{
public static readonly long[] Value=A238429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238429.Bytes);
public long this[int i]=>Value[i];

public static A238429Inst Instance=new A238429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238430
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,6L,9L,13L,18L,26L,38L,54L,77L,111L,160L,229L,328L,472L,678L,972L,1396L,2006L,2880L,4134L,5937L,8527L,12242L,17577L,25242L,36246L,52043L,74729L,107308L,154084L,221246L,317692L,456182L,655032L,940564L,1350572L,1939304L,2784660L,3998522L,5741532L,8244326L,11838106L,16998472L,24408302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238430Inst : IEnumerable<long>
{
public static readonly long[] Value=A238430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238430.Bytes);
public long this[int i]=>Value[i];

public static A238430Inst Instance=new A238430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238431
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,10L,19L,36L,69L,135L,258L,500L,963L,1862L,3592L,6940L,13393L,25869L,49939L,96437L,186190L,359531L,694176L,1340393L,2588071L,4997263L,9648958L,18630886L,35973552L,69460077L,134117616L,258962680L,500020761L,965470897L,1864189893L,3599491983L,6950118531L,13419713384L,25911601377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238431Inst : IEnumerable<long>
{
public static readonly long[] Value=A238431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238431.Bytes);
public long this[int i]=>Value[i];

public static A238431Inst Instance=new A238431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238448
{
public static readonly long[] Value={ 0L,7L,28L,135L,391L,992L,5837L,9485L,15975L,244178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238448Inst : IEnumerable<long>
{
public static readonly long[] Value=A238448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238448.Bytes);
public long this[int i]=>Value[i];

public static A238448Inst Instance=new A238448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238449
{
public static readonly long[] Value={ 0L,5L,25L,78L,161L,341L,1315L,28238L,56047L,283789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238449Inst : IEnumerable<long>
{
public static readonly long[] Value=A238449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238449.Bytes);
public long this[int i]=>Value[i];

public static A238449Inst Instance=new A238449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238450
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,2L,1L,1L,1L,1L,0L,0L,1L,2L,2L,2L,1L,1L,1L,0L,0L,1L,3L,2L,2L,1L,2L,1L,1L,0L,0L,1L,3L,3L,2L,2L,1L,2L,1L,1L,0L,0L,1L,4L,3L,3L,3L,2L,2L,2L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238450Inst : IEnumerable<long>
{
public static readonly long[] Value=A238450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238450.Bytes);
public long this[int i]=>Value[i];

public static A238450Inst Instance=new A238450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238451
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,2L,2L,2L,0L,1L,1L,1L,1L,0L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,0L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,0L,4L,3L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238451Inst : IEnumerable<long>
{
public static readonly long[] Value=A238451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238451.Bytes);
public long this[int i]=>Value[i];

public static A238451Inst Instance=new A238451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238452
{
public static readonly long[] Value={ 0L,1L,2L,2L,8L,5L,30L,14L,112L,42L,420L,132L,1584L,429L,6006L,1430L,22880L,4862L,87516L,16796L,335920L,58786L,1293292L,208012L,4992288L,742900L,19315400L,2674440L,74884320L,9694845L,290845350L,35357670L,1131445440L,129644790L,4407922860L,477638700L,17194993200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238452Inst : IEnumerable<long>
{
public static readonly long[] Value=A238452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238452.Bytes);
public long this[int i]=>Value[i];

public static A238452Inst Instance=new A238452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238453
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,4L,8L,8L,4L,1L,1L,2L,8L,8L,8L,2L,1L,1L,6L,12L,24L,24L,12L,6L,1L,1L,4L,24L,24L,48L,24L,24L,4L,1L,1L,6L,24L,72L,72L,72L,72L,24L,6L,1L,1L,4L,24L,48L,144L,72L,144L,48L,24L,4L,1L,1L,10L,40L,120L,240L,360L,360L,240L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238453Inst : IEnumerable<long>
{
public static readonly long[] Value=A238453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238453.Bytes);
public long this[int i]=>Value[i];

public static A238453Inst Instance=new A238453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238454
{
public static readonly long[] Value={ 2L,1L,4L,16L,17L,68L,89L,356L,697L,1337L,2449L,4001L,4417L,17668L,24329L,4633L,18532L,74128L,296512L,1186048L,1778369L,1181833L,4727332L,18909328L,28184177L,17830441L,71321764L,285287056L,381898097L,9092137L,36368548L,145474192L,581896768L,2327587072L,9310348288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238454Inst : IEnumerable<long>
{
public static readonly long[] Value=A238454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238454.Bytes);
public long this[int i]=>Value[i];

public static A238454Inst Instance=new A238454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238455
{
public static readonly long[] Value={ 0L,1L,1L,-2L,3L,-11L,1L,-87L,-167L,-306L,-500L,-552L,688L,-3041L,-579L,20854L,37075L,55618L,37108L,-222296L,-147729L,891994L,602155L,-3523022L,-2228805L,14811346L,11792251L,-47737262L,-1136517L,375078994L,741065851L,1445763154L,2746052116L,4910207464L,7492827856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238455Inst : IEnumerable<long>
{
public static readonly long[] Value=A238455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238455.Bytes);
public long this[int i]=>Value[i];

public static A238455Inst Instance=new A238455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238456
{
public static readonly BigInteger[] Value={ 0L,2211L,5151L,1107816L,20959575L,4237107540L,1564279847151L,61066162885575L,2533192954461975L,2774988107938203L,90728963274006291L,BigInteger.Parse("18765679728507154152720") };
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
public class A238456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238456Inst Instance=new A238456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238457
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,4L,3L,3L,3L,3L,3L,4L,4L,3L,4L,2L,3L,2L,4L,4L,4L,3L,1L,4L,4L,4L,3L,3L,4L,4L,5L,4L,5L,4L,3L,3L,5L,2L,2L,8L,6L,6L,2L,4L,5L,6L,3L,7L,6L,4L,6L,5L,6L,4L,3L,3L,4L,2L,4L,5L,7L,5L,6L,4L,7L,7L,5L,2L,5L,6L,2L,6L,5L,4L,7L,7L,5L,6L,5L,3L,6L,2L,6L,4L,9L,8L,2L,5L,7L,6L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238457Inst : IEnumerable<long>
{
public static readonly long[] Value=A238457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238457.Bytes);
public long this[int i]=>Value[i];

public static A238457Inst Instance=new A238457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238458
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,2L,3L,4L,2L,3L,3L,3L,5L,2L,4L,4L,5L,4L,5L,4L,4L,3L,3L,3L,4L,4L,4L,2L,4L,2L,5L,4L,4L,5L,3L,3L,6L,3L,4L,1L,3L,4L,7L,6L,4L,4L,4L,4L,4L,4L,5L,3L,5L,5L,7L,3L,3L,4L,6L,5L,8L,5L,5L,4L,4L,2L,7L,5L,7L,3L,6L,5L,7L,6L,7L,5L,5L,4L,7L,4L,5L,3L,5L,6L,8L,5L,3L,4L,6L,3L,5L,4L,5L,4L,5L,2L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238458Inst : IEnumerable<long>
{
public static readonly long[] Value=A238458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238458.Bytes);
public long this[int i]=>Value[i];

public static A238458Inst Instance=new A238458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238459
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,2L,3L,3L,2L,3L,2L,5L,3L,5L,4L,4L,3L,4L,4L,6L,2L,4L,3L,5L,2L,4L,1L,4L,5L,6L,5L,5L,4L,5L,3L,4L,3L,5L,6L,5L,6L,3L,8L,6L,5L,6L,4L,6L,7L,5L,6L,4L,6L,7L,6L,7L,7L,6L,6L,7L,5L,6L,5L,6L,5L,5L,5L,7L,7L,6L,5L,7L,9L,8L,6L,5L,5L,7L,6L,8L,6L,5L,8L,7L,8L,7L,4L,8L,7L,7L,7L,6L,6L,6L,6L,6L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238459Inst : IEnumerable<long>
{
public static readonly long[] Value=A238459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238459.Bytes);
public long this[int i]=>Value[i];

public static A238459Inst Instance=new A238459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238460
{
public static readonly long[] Value={ 5L,13L,37L,41L,101L,113L,157L,173L,181L,197L,229L,241L,281L,313L,337L,349L,353L,373L,409L,421L,433L,509L,541L,617L,677L,701L,757L,761L,769L,773L,821L,929L,941L,977L,997L,1013L,1093L,1097L,1109L,1181L,1193L,1237L,1409L,1433L,1481L,1489L,1669L,1693L,1721L,1741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238460Inst : IEnumerable<long>
{
public static readonly long[] Value=A238460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238460.Bytes);
public long this[int i]=>Value[i];

public static A238460Inst Instance=new A238460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238461
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,8L,8L,9L,9L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238461Inst : IEnumerable<long>
{
public static readonly long[] Value=A238461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238461.Bytes);
public long this[int i]=>Value[i];

public static A238461Inst Instance=new A238461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238462
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,12L,25L,50L,103L,206L,413L,826L,1654L,3308L,6617L,13234L,26472L,52944L,105889L,211778L,423558L,847116L,1694233L,3388466L,6776935L,13553870L,27107741L,54215482L,108430966L,216861932L,433723865L,867447730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238462Inst : IEnumerable<long>
{
public static readonly long[] Value=A238462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238462.Bytes);
public long this[int i]=>Value[i];

public static A238462Inst Instance=new A238462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238463
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,11L,13L,17L,19L,22L,23L,29L,31L,33L,37L,41L,43L,44L,47L,53L,59L,61L,67L,69L,71L,73L,76L,79L,82L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,140L,149L,151L,157L,163L,167L,173L,179L,181L,190L,191L,193L,197L,199L,211L,223L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238463Inst : IEnumerable<long>
{
public static readonly long[] Value=A238463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238463.Bytes);
public long this[int i]=>Value[i];

public static A238463Inst Instance=new A238463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238480
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,5L,3L,6L,8L,9L,10L,20L,18L,25L,38L,43L,53L,77L,87L,114L,150L,176L,220L,290L,343L,422L,535L,641L,783L,978L,1164L,1415L,1733L,2068L,2497L,3026L,3595L,4304L,5174L,6140L,7300L,8709L,10283L,12176L,14435L,16978L,20001L,23579L,27640L,32423L,38024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238480Inst : IEnumerable<long>
{
public static readonly long[] Value=A238480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238480.Bytes);
public long this[int i]=>Value[i];

public static A238480Inst Instance=new A238480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238481
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,6L,12L,16L,22L,33L,46L,57L,83L,110L,138L,188L,244L,308L,403L,513L,642L,826L,1035L,1285L,1615L,2014L,2475L,3077L,3782L,4626L,5678L,6934L,8410L,10242L,12386L,14951L,18042L,21711L,26011L,31198L,37283L,44465L,52978L,62999L,74699L,88580L,104753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238481Inst : IEnumerable<long>
{
public static readonly long[] Value=A238481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238481.Bytes);
public long this[int i]=>Value[i];

public static A238481Inst Instance=new A238481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238482
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,16L,20L,25L,35L,45L,54L,76L,95L,117L,154L,196L,239L,309L,384L,471L,595L,737L,893L,1116L,1364L,1653L,2032L,2470L,2974L,3618L,4363L,5235L,6309L,7563L,9014L,10796L,12863L,15264L,18157L,21517L,25416L,30069L,35455L,41710L,49084L,57629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238482Inst : IEnumerable<long>
{
public static readonly long[] Value=A238482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238482.Bytes);
public long this[int i]=>Value[i];

public static A238482Inst Instance=new A238482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238483
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,6L,11L,14L,22L,31L,42L,56L,81L,100L,136L,180L,231L,294L,388L,483L,618L,784L,980L,1221L,1543L,1894L,2354L,2912L,3572L,4372L,5375L,6525L,7947L,9648L,11668L,14074L,17001L,20389L,24475L,29319L,35017L,41744L,49759L,59065L,70103L,83044L,98189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238483Inst : IEnumerable<long>
{
public static readonly long[] Value=A238483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238483.Bytes);
public long this[int i]=>Value[i];

public static A238483Inst Instance=new A238483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238484
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,15L,17L,24L,32L,38L,51L,68L,81L,109L,138L,169L,220L,278L,336L,431L,536L,654L,816L,1007L,1221L,1511L,1843L,2225L,2718L,3295L,3954L,4793L,5760L,6886L,8271L,9885L,11759L,14030L,16668L,19738L,23407L,27676L,32615L,38481L,45281L,53153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238484Inst : IEnumerable<long>
{
public static readonly long[] Value=A238484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238484.Bytes);
public long this[int i]=>Value[i];

public static A238484Inst Instance=new A238484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238485
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,7L,11L,15L,25L,32L,45L,63L,84L,108L,150L,188L,247L,321L,407L,514L,666L,824L,1039L,1304L,1620L,2003L,2497L,3054L,3761L,4617L,5631L,6848L,8356L,10090L,12217L,14751L,17744L,21300L,25579L,30553L,36506L,43523L,51768L,61458L,72943L,86273L,101992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238485Inst : IEnumerable<long>
{
public static readonly long[] Value=A238485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238485.Bytes);
public long this[int i]=>Value[i];

public static A238485Inst Instance=new A238485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238486
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,16L,18L,26L,33L,44L,51L,74L,86L,117L,144L,188L,224L,298L,354L,459L,560L,705L,843L,1069L,1279L,1596L,1924L,2365L,2826L,3471L,4134L,5036L,6009L,7252L,8609L,10369L,12272L,14687L,17372L,20674L,24356L,28920L,33973L,40160L,47122L,55471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238486Inst : IEnumerable<long>
{
public static readonly long[] Value=A238486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238486.Bytes);
public long this[int i]=>Value[i];

public static A238486Inst Instance=new A238486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238487
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,6L,11L,14L,24L,30L,44L,57L,84L,102L,145L,180L,241L,302L,403L,494L,648L,796L,1015L,1253L,1593L,1941L,2439L,2969L,3680L,4477L,5523L,6672L,8176L,9847L,11968L,14385L,17406L,20816L,25066L,29896L,35802L,42587L,50819L,60214L,71585L,84594L,100151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238487Inst : IEnumerable<long>
{
public static readonly long[] Value=A238487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238487.Bytes);
public long this[int i]=>Value[i];

public static A238487Inst Instance=new A238487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238488
{
public static readonly long[] Value={ 1L,1L,3L,5L,6L,10L,14L,20L,28L,39L,52L,72L,95L,126L,166L,218L,280L,364L,465L,594L,753L,953L,1195L,1502L,1870L,2326L,2880L,3560L,4374L,5374L,6569L,8018L,9752L,11842L,14327L,17317L,20858L,25088L,30098L,36054L,43073L,51399L,61186L,72737L,86292L,102235L,120882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238488Inst : IEnumerable<long>
{
public static readonly long[] Value=A238488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238488.Bytes);
public long this[int i]=>Value[i];

public static A238488Inst Instance=new A238488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238489
{
public static readonly long[] Value={ 0L,4L,11L,23L,56L,80L,103L,135L,204L,248L,339L,395L,444L,508L,576L,635L,711L,860L,948L,1119L,1219L,1304L,1412L,1619L,1739L,1968L,2100L,2211L,2351L,2495L,2616L,2768L,3055L,3219L,3528L,3704L,3851L,4035L,4223L,4380L,4576L,4943L,5151L,5540L,5760L,5943L,6171L,6596L,6836L,7283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238489Inst : IEnumerable<long>
{
public static readonly long[] Value=A238489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238489.Bytes);
public long this[int i]=>Value[i];

public static A238489Inst Instance=new A238489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238490
{
public static readonly long[] Value={ 103L,2297860813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238490Inst : IEnumerable<long>
{
public static readonly long[] Value=A238490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238490.Bytes);
public long this[int i]=>Value[i];

public static A238490Inst Instance=new A238490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238491
{
public static readonly long[] Value={ 1L,2L,2L,5L,7L,11L,14L,21L,29L,41L,54L,75L,98L,132L,171L,226L,290L,377L,479L,615L,776L,984L,1231L,1548L,1924L,2397L,2960L,3661L,4495L,5523L,6742L,8234L,10003L,12149L,14688L,17752L,21368L,25704L,30814L,36911L,44078L,52591L,62573L,74384L,88206L,104491L,123506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238491Inst : IEnumerable<long>
{
public static readonly long[] Value=A238491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238491.Bytes);
public long this[int i]=>Value[i];

public static A238491Inst Instance=new A238491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238492
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,11L,15L,22L,29L,41L,55L,76L,100L,133L,174L,228L,294L,381L,485L,621L,785L,993L,1245L,1562L,1943L,2418L,2989L,3692L,4535L,5568L,6800L,8299L,10085L,12240L,14803L,17882L,21527L,25886L,31035L,37162L,44381L,52938L,62989L,74858L,88770L,105135L,124270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238492Inst : IEnumerable<long>
{
public static readonly long[] Value=A238492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238492.Bytes);
public long this[int i]=>Value[i];

public static A238492Inst Instance=new A238492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238493
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,4L,7L,10L,14L,15L,27L,28L,43L,50L,69L,80L,115L,127L,176L,204L,268L,310L,412L,471L,606L,710L,892L,1042L,1311L,1517L,1885L,2203L,2692L,3146L,3834L,4459L,5392L,6293L,7540L,8781L,10494L,12186L,14482L,16832L,19874L,23066L,27171L,31445L,36893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238493Inst : IEnumerable<long>
{
public static readonly long[] Value=A238493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238493.Bytes);
public long this[int i]=>Value[i];

public static A238493Inst Instance=new A238493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238494
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,7L,11L,15L,20L,28L,41L,50L,73L,92L,126L,162L,217L,270L,363L,451L,588L,734L,945L,1163L,1487L,1830L,2300L,2826L,3523L,4293L,5325L,6464L,7940L,9618L,11737L,14143L,17178L,20623L,24892L,29798L,35802L,42680L,51075L,60693L,72302L,85684L,101688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238494Inst : IEnumerable<long>
{
public static readonly long[] Value=A238494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238494.Bytes);
public long this[int i]=>Value[i];

public static A238494Inst Instance=new A238494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238495
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,14L,19L,27L,36L,51L,66L,90L,118L,156L,201L,264L,336L,434L,550L,700L,880L,1112L,1385L,1733L,2149L,2666L,3283L,4049L,4956L,6072L,7398L,9009L,10922L,13237L,15970L,19261L,23147L,27790L,33260L,39776L,47425L,56497L,67133L,79685L,94371L,111653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238495Inst : IEnumerable<long>
{
public static readonly long[] Value=A238495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238495.Bytes);
public long this[int i]=>Value[i];

public static A238495Inst Instance=new A238495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238544
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,4L,3L,7L,6L,14L,12L,23L,24L,39L,41L,66L,71L,106L,120L,168L,193L,268L,306L,411L,482L,629L,737L,953L,1116L,1420L,1675L,2096L,2474L,3076L,3619L,4455L,5257L,6410L,7548L,9157L,10761L,12970L,15238L,18248L,21402L,25531L,29870L,35466L,41452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238544Inst : IEnumerable<long>
{
public static readonly long[] Value=A238544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238544.Bytes);
public long this[int i]=>Value[i];

public static A238544Inst Instance=new A238544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238545
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,14L,18L,27L,35L,50L,63L,89L,112L,152L,192L,256L,319L,419L,521L,672L,834L,1062L,1307L,1652L,2025L,2528L,3089L,3828L,4651L,5726L,6929L,8468L,10214L,12409L,14901L,18018L,21560L,25928L,30928L,37035L,44017L,52500L,62205L,73896L,87310L,103352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238545Inst : IEnumerable<long>
{
public static readonly long[] Value=A238545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238545.Bytes);
public long this[int i]=>Value[i];

public static A238545Inst Instance=new A238545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238546
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,8L,10L,17L,23L,35L,45L,66L,86L,120L,154L,209L,267L,355L,448L,585L,736L,946L,1178L,1498L,1857L,2335L,2875L,3583L,4389L,5428L,6611L,8118L,9846L,12013L,14498L,17592L,21147L,25525L,30558L,36711L,43791L,52382L,62259L,74173L,87879L,104303L,123179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238546Inst : IEnumerable<long>
{
public static readonly long[] Value=A238546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238546.Bytes);
public long this[int i]=>Value[i];

public static A238546Inst Instance=new A238546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238547
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,6L,6L,10L,13L,18L,22L,33L,38L,52L,65L,85L,102L,135L,161L,208L,252L,316L,381L,481L,574L,711L,855L,1049L,1252L,1532L,1820L,2207L,2624L,3156L,3740L,4486L,5291L,6308L,7436L,8824L,10363L,12258L,14356L,16912L,19774L,23202L,27056L,31671L,36833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238547Inst : IEnumerable<long>
{
public static readonly long[] Value=A238547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238547.Bytes);
public long this[int i]=>Value[i];

public static A238547Inst Instance=new A238547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238548
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,16L,24L,32L,43L,59L,79L,102L,138L,179L,232L,300L,388L,492L,631L,794L,1003L,1259L,1577L,1955L,2436L,3007L,3710L,4555L,5590L,6817L,8323L,10103L,12259L,14821L,17897L,21529L,25894L,31030L,37147L,44350L,52898L,62917L,74778L,88646L,104980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238548Inst : IEnumerable<long>
{
public static readonly long[] Value=A238548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238548.Bytes);
public long this[int i]=>Value[i];

public static A238548Inst Instance=new A238548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238549
{
public static readonly long[] Value={ 1L,2L,6L,8L,16L,20L,36L,44L,76L,92L,156L,188L,316L,380L,636L,764L,1276L,1532L,2556L,3068L,5116L,6140L,10236L,12284L,20476L,24572L,40956L,49148L,81916L,98300L,163836L,196604L,327676L,393212L,655356L,786428L,1310716L,1572860L,2621436L,3145724L,5242876L,6291452L,10485756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238549Inst : IEnumerable<long>
{
public static readonly long[] Value=A238549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238549.Bytes);
public long this[int i]=>Value[i];

public static A238549Inst Instance=new A238549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238550
{
public static readonly long[] Value={ 1L,3L,4L,1L,1L,3L,8L,3L,1L,6L,23L,33L,22L,6L,1L,1L,6L,40L,101L,125L,54L,10L,1L,9L,68L,262L,534L,532L,276L,74L,12L,1L,1L,9L,98L,509L,1551L,2505L,2196L,971L,219L,20L,1L,12L,139L,927L,3731L,8772L,12069L,9506L,4366L,1160L,179L,16L,1L,1L,12L,182L,1479L,7644L,24024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238550Inst : IEnumerable<long>
{
public static readonly long[] Value=A238550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238550.Bytes);
public long this[int i]=>Value[i];

public static A238550Inst Instance=new A238550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238551
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,1L,4L,4L,1L,4L,11L,3L,1L,1L,6L,21L,13L,4L,1L,6L,36L,32L,13L,1L,8L,54L,82L,49L,8L,1L,1L,8L,77L,165L,151L,44L,6L,1L,10L,103L,319L,382L,173L,31L,1L,10L,134L,530L,867L,559L,164L,12L,1L,1L,12L,168L,852L,1789L,1632L,705L,119L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238551Inst : IEnumerable<long>
{
public static readonly long[] Value=A238551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238551.Bytes);
public long this[int i]=>Value[i];

public static A238551Inst Instance=new A238551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238552
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,1L,4L,1L,6L,4L,1L,6L,9L,1L,8L,18L,1L,8L,28L,1L,10L,42L,10L,1L,10L,57L,28L,1L,12L,76L,76L,1L,12L,96L,140L,1L,14L,120L,254L,25L,1L,14L,145L,392L,107L,1L,16L,174L,600L,321L,1L,16L,204L,840L,731L,1L,18L,238L,1170L,1462L,70L,1L,18L,273L,1540L,2610L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238552Inst : IEnumerable<long>
{
public static readonly long[] Value=A238552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238552.Bytes);
public long this[int i]=>Value[i];

public static A238552Inst Instance=new A238552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238553
{
public static readonly long[] Value={ 5793L,5963L,6593L,6963L,7593L,8593L,9357L,9463L,9663L,9883L,9934L,9937L,9938L,57937L,58893L,58937L,58963L,59463L,59537L,59543L,59663L,59736L,59833L,59863L,59883L,65937L,66893L,68963L,69537L,69634L,69883L,73956L,73957L,79583L,79836L,79837L,79934L,83594L,85938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238553Inst : IEnumerable<long>
{
public static readonly long[] Value=A238553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238553.Bytes);
public long this[int i]=>Value[i];

public static A238553Inst Instance=new A238553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238554
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,11L,3L,9L,1L,35L,15L,39L,3L,39L,63L,35L,1L,149L,3L,419L,7L,221L,25L,155L,73L,735L,69L,29L,193L,261L,3L,135L,81L,149L,85L,125L,117L,809L,303L,509L,27L,699L,325L,29L,27L,285L,639L,65L,61L,1911L,639L,165L,295L,1295L,163L,905L,175L,75L,1593L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238554Inst : IEnumerable<long>
{
public static readonly long[] Value=A238554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238554.Bytes);
public long this[int i]=>Value[i];

public static A238554Inst Instance=new A238554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238555
{
public static readonly long[] Value={ 1L,3L,6L,2L,1L,3L,12L,8L,1L,6L,34L,68L,72L,30L,6L,1L,6L,58L,206L,403L,336L,106L,1L,9L,98L,509L,1551L,2505L,2196L,971L,219L,20L,1L,9L,140L,980L,4248L,10592L,15614L,12876L,5462L,900L,1L,12L,198L,1742L,9748L,33644L,73274L,98779L,80661L,37886L,9679L,1258L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238555Inst : IEnumerable<long>
{
public static readonly long[] Value=A238555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238555.Bytes);
public long this[int i]=>Value[i];

public static A238555Inst Instance=new A238555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238556
{
public static readonly long[] Value={ 1L,3L,2L,1L,3L,4L,1L,6L,9L,1L,6L,21L,13L,4L,1L,9L,39L,53L,23L,1L,9L,64L,128L,87L,1L,12L,95L,283L,311L,91L,10L,1L,12L,133L,521L,891L,543L,106L,1L,15L,177L,917L,2118L,2030L,646L,1L,15L,228L,1444L,4424L,6000L,3295L,456L,25L,1L,18L,285L,2207L,8408L,15484L,13106L,4322L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238556Inst : IEnumerable<long>
{
public static readonly long[] Value=A238556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238556.Bytes);
public long this[int i]=>Value[i];

public static A238556Inst Instance=new A238556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238557
{
public static readonly long[] Value={ 1L,4L,9L,6L,1L,1L,4L,18L,22L,6L,1L,8L,49L,139L,204L,145L,54L,8L,1L,1L,8L,83L,392L,1056L,1438L,956L,240L,25L,1L,12L,139L,927L,3731L,8772L,12069L,9506L,4366L,1160L,179L,16L,1L,1L,12L,198L,1742L,9748L,33644L,73274L,98779L,80661L,37886L,9679L,1258L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238557Inst : IEnumerable<long>
{
public static readonly long[] Value=A238557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238557.Bytes);
public long this[int i]=>Value[i];

public static A238557Inst Instance=new A238557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238558
{
public static readonly long[] Value={ 1L,3L,4L,1L,3L,8L,1L,6L,18L,1L,6L,36L,32L,13L,1L,9L,64L,128L,87L,1L,9L,100L,308L,332L,1L,12L,146L,647L,1118L,451L,68L,1L,12L,200L,1160L,3022L,2756L,824L,1L,15L,264L,1958L,6882L,10076L,5009L,1L,15L,336L,3020L,13798L,28774L,24237L,4774L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238558Inst : IEnumerable<long>
{
public static readonly long[] Value=A238558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238558.Bytes);
public long this[int i]=>Value[i];

public static A238558Inst Instance=new A238558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238559
{
public static readonly long[] Value={ 1L,3L,1L,1L,3L,2L,1L,6L,4L,1L,6L,6L,1L,9L,17L,5L,1L,1L,9L,32L,18L,4L,1L,12L,56L,46L,13L,1L,12L,84L,90L,31L,1L,15L,121L,193L,98L,13L,1L,1L,15L,162L,360L,275L,66L,6L,1L,18L,212L,664L,672L,250L,31L,1L,18L,266L,1080L,1408L,672L,110L,1L,21L,329L,1711L,2797L,1772L,432L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238559Inst : IEnumerable<long>
{
public static readonly long[] Value=A238559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238559.Bytes);
public long this[int i]=>Value[i];

public static A238559Inst Instance=new A238559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238592
{
public static readonly long[] Value={ 1L,4L,9L,2L,1L,4L,18L,8L,1L,8L,42L,28L,1L,8L,77L,165L,151L,44L,6L,1L,12L,133L,521L,891L,543L,106L,1L,12L,200L,1160L,3022L,2756L,824L,1L,16L,288L,2260L,8443L,13336L,9364L,2819L,387L,20L,1L,16L,387L,3867L,19833L,48418L,58731L,34797L,9462L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238592Inst : IEnumerable<long>
{
public static readonly long[] Value=A238592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238592.Bytes);
public long this[int i]=>Value[i];

public static A238592Inst Instance=new A238592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238593
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,2L,10L,7L,12L,13L,14L,15L,16L,17L,18L,19L,5L,21L,22L,23L,24L,25L,26L,27L,28L,29L,6L,31L,7L,12L,34L,35L,36L,37L,38L,19L,21L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,32L,59L,60L,61L,11L,63L,33L,12L,7L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238593Inst : IEnumerable<long>
{
public static readonly long[] Value=A238593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238593.Bytes);
public long this[int i]=>Value[i];

public static A238593Inst Instance=new A238593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238594
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,7L,10L,14L,17L,25L,32L,41L,54L,71L,88L,115L,144L,182L,229L,287L,353L,443L,545L,670L,822L,1009L,1224L,1495L,1809L,2189L,2641L,3182L,3813L,4580L,5470L,6528L,7773L,9248L,10960L,12994L,15355L,18129L,21363L,25146L,29525L,34659L,40589L,47488L,55473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238594Inst : IEnumerable<long>
{
public static readonly long[] Value=A238594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238594.Bytes);
public long this[int i]=>Value[i];

public static A238594Inst Instance=new A238594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238595
{
public static readonly long[] Value={ 43200L,5644800L,10584000L,3801600L,706305600L,440294400L,2203200L,9116352000L,1327233600L,437184000L,210974400L,44689881600L,194184000L,223285708800L,12271089600L,652147200L,6448478400L,285538623552000L,837777600L,547348032000L,688766500800L,747187200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238595Inst : IEnumerable<long>
{
public static readonly long[] Value=A238595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238595.Bytes);
public long this[int i]=>Value[i];

public static A238595Inst Instance=new A238595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238596
{
public static readonly long[] Value={ 2L,6L,50L,1140L,86052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238596Inst : IEnumerable<long>
{
public static readonly long[] Value=A238596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238596.Bytes);
public long this[int i]=>Value[i];

public static A238596Inst Instance=new A238596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238597
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,2L,4L,1L,1L,5L,3L,1L,3L,1L,2L,4L,3L,3L,2L,2L,3L,4L,3L,1L,5L,3L,1L,3L,2L,4L,5L,2L,2L,2L,3L,3L,6L,3L,3L,4L,2L,4L,5L,3L,4L,5L,3L,2L,6L,2L,3L,8L,1L,1L,5L,5L,3L,5L,4L,4L,6L,2L,3L,3L,4L,3L,7L,3L,1L,7L,4L,4L,5L,4L,3L,8L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238597Inst : IEnumerable<long>
{
public static readonly long[] Value=A238597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238597.Bytes);
public long this[int i]=>Value[i];

public static A238597Inst Instance=new A238597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238598
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238598Inst : IEnumerable<long>
{
public static readonly long[] Value=A238598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238598.Bytes);
public long this[int i]=>Value[i];

public static A238598Inst Instance=new A238598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238599
{
public static readonly long[] Value={ 0L,29L,171L,476L,1015L,1044L,1907L,3142L,4815L,7093L,9882L,13313L,17452L,22580L,28393L,35118L,42821L,43120L,51939L,61874L,72991L,85835L,99604L,114759L,131366L,150192L,170009L,191482L,214677L,240625L,267588L,296477L,327358L,361568L,396775L,434178L,473843L,475306L,517455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238599Inst : IEnumerable<long>
{
public static readonly long[] Value=A238599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238599.Bytes);
public long this[int i]=>Value[i];

public static A238599Inst Instance=new A238599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238600
{
public static readonly BigInteger[] Value={ 1L,28L,408L,7896L,137555L,2496144L,44599477L,801617712L,14375440584L,258018516140L,4629531440711L,83076469908768L,1490726895438793L,26750144944686436L,480010941060482040L,8613453244178393184L,BigInteger.Parse("154562103244937408987"),BigInteger.Parse("2773504708179098411952") };
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
public class A238600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238600Inst Instance=new A238600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238601
{
public static readonly BigInteger[] Value={ 1L,44L,1037L,32472L,915305L,26874892L,776952553L,22595381424L,655633561309L,19040507781020L,552780012054689L,16050219184005336L,466002944275859873L,13530204273746536948UL,BigInteger.Parse("392841165312292809085"),BigInteger.Parse("11405932444267712654688"),BigInteger.Parse("331164788382150547106857"),BigInteger.Parse("9615185834308570310716196") };
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
public class A238601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238601Inst Instance=new A238601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238602
{
public static readonly BigInteger[] Value={ 1L,238L,45507L,9063516L,1792708805L,355009117386L,70287911575687L,13916722851826872L,2755438412296182921L,BigInteger.Parse("545562971271797876390"),BigInteger.Parse("108018710075587599558731"),BigInteger.Parse("21387159127038457710621972"),BigInteger.Parse("4234549485214861760195346253"),BigInteger.Parse("838419411023095574089504928386") };
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
public class A238602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238602Inst Instance=new A238602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238603
{
public static readonly BigInteger[] Value={ 1L,51L,2847L,170391L,10555655L,664857063L,42215949223L,2691226507047L,171901443816999L,10990938133564455L,703076406514657319L,BigInteger.Parse("44985901769992495143"),BigInteger.Parse("2878746218051469266983"),BigInteger.Parse("184228512166784552153127"),BigInteger.Parse("11790264946382521291370535"),BigInteger.Parse("754565442462197107544125479") };
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
public class A238603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238603Inst Instance=new A238603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238604
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,65L,125L,216L,344L,533L,793L,1134L,1566L,2125L,2825L,3680L,4704L,5945L,7421L,9150L,11150L,13481L,16165L,19224L,22680L,26605L,31025L,35966L,41454L,47573L,54353L,61824L,70016L,79025L,88885L,99630L,111294L,123985L,137741L,152600L,168600L,185861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238604Inst : IEnumerable<long>
{
public static readonly long[] Value=A238604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238604.Bytes);
public long this[int i]=>Value[i];

public static A238604Inst Instance=new A238604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238605
{
public static readonly long[] Value={ 15L,35L,39L,55L,87L,155L,183L,203L,219L,247L,259L,295L,327L,339L,371L,471L,515L,535L,579L,583L,635L,707L,731L,803L,807L,835L,851L,871L,939L,995L,1011L,1047L,1059L,1067L,1111L,1147L,1191L,1195L,1203L,1207L,1211L,1219L,1255L,1315L,1339L,1355L,1363L,1383L,1507L,1527L,1563L,1591L,1643L,1651L,1687L,1707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238605Inst : IEnumerable<long>
{
public static readonly long[] Value=A238605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238605.Bytes);
public long this[int i]=>Value[i];

public static A238605Inst Instance=new A238605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238606
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,4L,3L,8L,2L,1L,10L,3L,2L,14L,7L,1L,20L,5L,5L,30L,5L,6L,1L,36L,15L,2L,3L,52L,16L,6L,3L,70L,13L,15L,3L,94L,22L,12L,7L,122L,32L,8L,13L,1L,160L,45L,12L,10L,4L,206L,51L,26L,8L,6L,276L,49L,44L,9L,7L,350L,75L,30L,28L,7L,448L,108L,22L,38L,11L,566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238606Inst : IEnumerable<long>
{
public static readonly long[] Value=A238606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238606.Bytes);
public long this[int i]=>Value[i];

public static A238606Inst Instance=new A238606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238607
{
public static readonly long[] Value={ 0L,0L,1L,4L,12L,24L,49L,85L,147L,232L,374L,558L,843L,1223L,1774L,2493L,3519L,4835L,6659L,8999L,12144L,16152L,21479L,28186L,36945L,47959L,62126L,79805L,102352L,130286L,165546L,209070L,263461L,330266L,413207L,514486L,639342L,791261L,977301L,1202636L,1477172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238607Inst : IEnumerable<long>
{
public static readonly long[] Value=A238607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238607.Bytes);
public long this[int i]=>Value[i];

public static A238607Inst Instance=new A238607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238640
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,168L,1582L,15546L,157051L,1625368L,17159223L,184277224L,2008388660L,22172275440L,247558926150L,2791793968821L,31764451979736L,364283594455091L,4207485803818522L,48908343969469479L,571811846280602486L,6720473048598172508L,BigInteger.Parse("79363083519870386700") };
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
public class A238640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238640Inst Instance=new A238640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238641
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,21L,37L,69L,113L,187L,286L,449L,657L,976L,1397L,2003L,2788L,3902L,5323L,7284L,9789L,13144L,17405L,23052L,30142L,39379L,50967L,65842L,84368L,107954L,137126L,173893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238641Inst : IEnumerable<long>
{
public static readonly long[] Value=A238641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238641.Bytes);
public long this[int i]=>Value[i];

public static A238641Inst Instance=new A238641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238642
{
public static readonly long[] Value={ 1L,2L,6L,4L,10L,6L,14L,24L,18L,10L,22L,12L,26L,42L,30L,16L,34L,18L,38L,60L,42L,22L,46L,120L,50L,78L,54L,28L,58L,30L,62L,96L,66L,170L,70L,36L,74L,114L,78L,40L,82L,42L,86L,132L,90L,46L,94L,336L,98L,150L,102L,52L,106L,270L,110L,168L,114L,58L,118L,60L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238642Inst : IEnumerable<long>
{
public static readonly long[] Value=A238642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238642.Bytes);
public long this[int i]=>Value[i];

public static A238642Inst Instance=new A238642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238643
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,3L,4L,2L,1L,3L,1L,2L,5L,2L,3L,3L,1L,2L,3L,3L,1L,4L,2L,1L,4L,2L,3L,5L,3L,1L,2L,2L,2L,3L,3L,4L,4L,2L,3L,2L,1L,2L,5L,1L,3L,4L,1L,2L,3L,1L,2L,4L,4L,2L,5L,4L,2L,5L,2L,1L,2L,4L,3L,5L,3L,1L,6L,7L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238643Inst : IEnumerable<long>
{
public static readonly long[] Value=A238643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238643.Bytes);
public long this[int i]=>Value[i];

public static A238643Inst Instance=new A238643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238644
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,6L,11L,19L,34L,62L,112L,202L,365L,659L,1189L,2146L,3874L,6993L,12623L,22786L,41131L,74245L,134019L,241917L,436683L,788254L,1422873L,2568420L,4636240L,8368850L,15106563L,27268770L,49222700L,88851613L,160385536L,289511009L,522594658L,943332613L,1702804277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238644Inst : IEnumerable<long>
{
public static readonly long[] Value=A238644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238644.Bytes);
public long this[int i]=>Value[i];

public static A238644Inst Instance=new A238644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238645
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,1L,2L,2L,5L,2L,3L,3L,1L,6L,5L,3L,3L,1L,4L,2L,4L,4L,3L,4L,2L,4L,3L,1L,4L,3L,3L,7L,5L,4L,5L,5L,4L,3L,2L,5L,2L,2L,4L,5L,4L,9L,7L,4L,3L,2L,4L,3L,4L,3L,2L,4L,6L,5L,6L,4L,4L,2L,2L,7L,5L,6L,6L,8L,3L,7L,3L,5L,6L,10L,6L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238645Inst : IEnumerable<long>
{
public static readonly long[] Value=A238645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238645.Bytes);
public long this[int i]=>Value[i];

public static A238645Inst Instance=new A238645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238646
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,3L,1L,2L,1L,3L,1L,3L,1L,4L,2L,3L,2L,5L,4L,5L,1L,3L,3L,4L,2L,5L,3L,4L,5L,8L,3L,5L,1L,5L,5L,7L,3L,5L,2L,6L,3L,6L,6L,9L,4L,8L,7L,7L,6L,7L,4L,6L,7L,8L,5L,6L,4L,7L,8L,9L,6L,6L,6L,9L,5L,7L,4L,8L,6L,10L,6L,5L,8L,11L,7L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238646Inst : IEnumerable<long>
{
public static readonly long[] Value=A238646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238646.Bytes);
public long this[int i]=>Value[i];

public static A238646Inst Instance=new A238646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238647
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,29L,31L,41L,43L,47L,59L,61L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,127L,131L,139L,149L,151L,157L,163L,167L,179L,181L,191L,199L,227L,239L,251L,257L,263L,269L,277L,281L,307L,349L,401L,409L,419L,421L,431L,439L,443L,449L,457L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238647Inst : IEnumerable<long>
{
public static readonly long[] Value=A238647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238647.Bytes);
public long this[int i]=>Value[i];

public static A238647Inst Instance=new A238647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238648
{
public static readonly BigInteger[] Value={ 1L,8L,51L,1015L,30116L,1929041L,223336353L,50789138692L,21840171519903L,18066655662899887L,BigInteger.Parse("28530669418446423314"),BigInteger.Parse("86301791696353013652605") };
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
public class A238648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238648Inst Instance=new A238648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238649
{
public static readonly long[] Value={ 3L,18L,51L,189L,630L,2187L,7473L,25692L,88119L,302511L,1038144L,3563151L,12228903L,41971050L,144048471L,494389041L,1696791534L,5823557223L,19987023645L,68597444364L,235433215419L,808030095435L,2773239244320L,9518031521451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238649Inst : IEnumerable<long>
{
public static readonly long[] Value=A238649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238649.Bytes);
public long this[int i]=>Value[i];

public static A238649Inst Instance=new A238649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238650
{
public static readonly long[] Value={ 5L,50L,189L,1015L,4742L,23373L,112827L,549068L,2663629L,12937577L,62809544L,304985137L,1480814097L,7190093330L,34911122149L,169509843307L,823048304238L,3996280864977L,19403790420427L,94214378731132L,457454375449573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238650Inst : IEnumerable<long>
{
public static readonly long[] Value=A238650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238650.Bytes);
public long this[int i]=>Value[i];

public static A238650Inst Instance=new A238650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238651
{
public static readonly long[] Value={ 8L,128L,630L,4742L,30116L,204216L,1349732L,9010526L,59917746L,399048464L,2656049918L,17682689820L,117712030990L,783626030284L,5216639296472L,34727628846946L,231184402116402L,1539013000632024L,10245328946153388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238651Inst : IEnumerable<long>
{
public static readonly long[] Value=A238651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238651.Bytes);
public long this[int i]=>Value[i];

public static A238651Inst Instance=new A238651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238652
{
public static readonly long[] Value={ 13L,338L,2187L,23373L,204216L,1929041L,17672899L,163862944L,1512215465L,13981375097L,129172957098L,1193759325517L,11030970832903L,101936481199220L,941972261582977L,8704613948522775L,80437723394264224L,743310855131757687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238652Inst : IEnumerable<long>
{
public static readonly long[] Value=A238652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238652.Bytes);
public long this[int i]=>Value[i];

public static A238652Inst Instance=new A238652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238653
{
public static readonly long[] Value={ 21L,882L,7473L,112827L,1349732L,17672899L,223336353L,2861990416L,36475373351L,465876675157L,5945303162296L,75896550206911L,968753829090555L,12365941291118010L,157845481105247677L,2014840165844453827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238653Inst : IEnumerable<long>
{
public static readonly long[] Value=A238653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238653.Bytes);
public long this[int i]=>Value[i];

public static A238653Inst Instance=new A238653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238654
{
public static readonly long[] Value={ 1L,2L,2L,3L,8L,3L,5L,18L,18L,5L,8L,50L,51L,50L,8L,13L,128L,189L,189L,128L,13L,21L,338L,630L,1015L,630L,338L,21L,34L,882L,2187L,4742L,4742L,2187L,882L,34L,55L,2312L,7473L,23373L,30116L,23373L,7473L,2312L,55L,89L,6050L,25692L,112827L,204216L,204216L,112827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238654Inst : IEnumerable<long>
{
public static readonly long[] Value=A238654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238654.Bytes);
public long this[int i]=>Value[i];

public static A238654Inst Instance=new A238654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238655
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,5L,5L,10L,15L,23L,33L,49L,68L,99L,133L,179L,246L,334L,432L,583L,756L,974L,1261L,1618L,2076L,2657L,3336L,4228L,5270L,6592L,8190L,10182L,12567L,15533L,19008L,23307L,28410L,34622L,42041L,50959L,61487L,74259L,88734L,106666L,127587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238655Inst : IEnumerable<long>
{
public static readonly long[] Value=A238655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238655.Bytes);
public long this[int i]=>Value[i];

public static A238655Inst Instance=new A238655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238704
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,2L,4L,6L,8L,10L,23L,12L,25L,14L,27L,16L,29L,18L,31L,33L,35L,37L,39L,41L,20L,22L,24L,26L,28L,30L,43L,32L,45L,34L,47L,36L,49L,38L,51L,53L,55L,57L,59L,61L,40L,42L,44L,46L,48L,50L,63L,52L,65L,54L,67L,56L,69L,58L,71L,73L,75L,77L,79L,81L,60L,62L,64L,66L,68L,70L,83L,72L,85L,74L,87L,76L,89L,78L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238704Inst : IEnumerable<long>
{
public static readonly long[] Value=A238704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238704.Bytes);
public long this[int i]=>Value[i];

public static A238704Inst Instance=new A238704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238705
{
public static readonly long[] Value={ 1L,4L,10L,19L,30L,44L,61L,80L,102L,127L,154L,184L,217L,252L,290L,331L,374L,420L,469L,520L,574L,631L,690L,752L,817L,884L,954L,1027L,1102L,1180L,1261L,1344L,1430L,1519L,1610L,1704L,1801L,1900L,2002L,2107L,2214L,2324L,2437L,2552L,2670L,2791L,2914L,3040L,3169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238705Inst : IEnumerable<long>
{
public static readonly long[] Value=A238705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238705.Bytes);
public long this[int i]=>Value[i];

public static A238705Inst Instance=new A238705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238706
{
public static readonly long[] Value={ 0L,2L,11L,36L,89L,183L,335L,565L,894L,1347L,1952L,2738L,3738L,4988L,6525L,8390L,10627L,13281L,16401L,20039L,24248L,29085L,34610L,40884L,47972L,55942L,64863L,74808L,85853L,98075L,111555L,126377L,142626L,160391L,179764L,200838L,223710L,248480L,275249L,304122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238706Inst : IEnumerable<long>
{
public static readonly long[] Value=A238706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238706.Bytes);
public long this[int i]=>Value[i];

public static A238706Inst Instance=new A238706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238707
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,4L,3L,3L,0L,0L,2L,14L,6L,4L,0L,0L,12L,14L,35L,10L,5L,0L,0L,2L,69L,71L,69L,15L,6L,0L,0L,30L,97L,295L,195L,119L,21L,7L,0L,0L,44L,251L,751L,929L,421L,188L,28L,8L,0L,0L,86L,671L,2326L,3044L,2254L,791L,279L,36L,9L,0L,0L,2L,1847L,6524L,11824L,8999L,4696L,1354L,395L,45L,10L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238707Inst : IEnumerable<long>
{
public static readonly long[] Value=A238707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238707.Bytes);
public long this[int i]=>Value[i];

public static A238707Inst Instance=new A238707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238708
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,13L,15L,19L,23L,28L,33L,41L,48L,58L,68L,81L,95L,113L,131L,154L,179L,209L,241L,281L,323L,374L,429L,494L,565L,649L,739L,845L,961L,1095L,1241L,1411L,1595L,1807L,2039L,2303L,2593L,2923L,3283L,3691L,4139L,4643L,5195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238708Inst : IEnumerable<long>
{
public static readonly long[] Value=A238708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238708.Bytes);
public long this[int i]=>Value[i];

public static A238708Inst Instance=new A238708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238709
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,4L,1L,0L,1L,7L,1L,1L,0L,1L,10L,2L,0L,1L,0L,1L,16L,2L,1L,0L,1L,0L,1L,22L,3L,1L,1L,0L,1L,0L,1L,32L,4L,2L,0L,1L,0L,1L,0L,1L,44L,5L,2L,1L,0L,1L,0L,1L,0L,1L,62L,6L,3L,1L,1L,0L,1L,0L,1L,0L,1L,83L,8L,3L,2L,0L,1L,0L,1L,0L,1L,0L,1L,113L,10L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238709Inst : IEnumerable<long>
{
public static readonly long[] Value=A238709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238709.Bytes);
public long this[int i]=>Value[i];

public static A238709Inst Instance=new A238709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238710
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,3L,3L,2L,1L,1L,1L,6L,3L,2L,1L,1L,3L,6L,6L,2L,2L,1L,1L,2L,10L,6L,5L,2L,2L,1L,1L,3L,11L,11L,6L,4L,2L,2L,1L,1L,1L,16L,13L,10L,5L,4L,2L,2L,1L,1L,5L,17L,19L,12L,9L,4L,4L,2L,2L,1L,1L,1L,24L,24L,18L,11L,8L,4L,4L,2L,2L,1L,1L,3L,27L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238710Inst : IEnumerable<long>
{
public static readonly long[] Value=A238710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238710.Bytes);
public long this[int i]=>Value[i];

public static A238710Inst Instance=new A238710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238711
{
public static readonly long[] Value={ 2L,3L,15L,105L,35L,231L,2145L,5005L,4641L,53295L,1616615L,119301L,21505L,7436429L,21489L,57998985L,3038795305L,4123L,13844919L,10393190665L,12838371L,299859855L,7292509103495L,12023917269L,70691995L,37198413949697L,62483343L,2769282065L,98755025688454681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238711Inst : IEnumerable<long>
{
public static readonly long[] Value=A238711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238711.Bytes);
public long this[int i]=>Value[i];

public static A238711Inst Instance=new A238711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238712
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,16L,21L,24L,25L,29L,36L,41L,44L,49L,56L,61L,64L,69L,76L,81L,84L,89L,96L,100L,104L,116L,121L,124L,129L,136L,144L,156L,161L,164L,169L,176L,184L,196L,201L,204L,209L,216L,224L,225L,236L,241L,244L,249L,256L,264L,276L,281L,284L,289L,296L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238712Inst : IEnumerable<long>
{
public static readonly long[] Value=A238712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238712.Bytes);
public long this[int i]=>Value[i];

public static A238712Inst Instance=new A238712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238713
{
public static readonly long[] Value={ 11L,41L,71L,101L,131L,191L,223L,311L,431L,461L,613L,641L,821L,853L,881L,1031L,1061L,1091L,1301L,1423L,1451L,1481L,1601L,1663L,1693L,1783L,1871L,1993L,2081L,2381L,2683L,2711L,3163L,3251L,3461L,3671L,3761L,3911L,4001L,4091L,4153L,4211L,4513L,4721L,4783L,4931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238713Inst : IEnumerable<long>
{
public static readonly long[] Value=A238713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238713.Bytes);
public long this[int i]=>Value[i];

public static A238713Inst Instance=new A238713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238714
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,7L,2L,3L,3L,11L,5L,13L,5L,7L,8L,17L,2L,19L,2L,10L,3L,23L,5L,5L,11L,9L,5L,29L,10L,31L,2L,5L,7L,11L,5L,37L,17L,7L,7L,41L,5L,43L,5L,11L,10L,47L,4L,7L,2L,11L,17L,53L,3L,7L,4L,13L,9L,59L,12L,61L,29L,11L,4L,11L,2L,67L,5L,17L,14L,71L,12L,73L,11L,3L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238714Inst : IEnumerable<long>
{
public static readonly long[] Value=A238714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238714.Bytes);
public long this[int i]=>Value[i];

public static A238714Inst Instance=new A238714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238715
{
public static readonly long[] Value={ 11L,821L,1031L,1423L,5413L,13691L,140831L,220873L,266023L,283571L,464741L,1596311L,1660661L,1966813L,2655403L,3303341L,5191331L,5485393L,8125511L,14241911L,14848511L,15586993L,15852043L,16539163L,19608041L,19696841L,30624071L,31809073L,35493551L,38335541L,40430771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238715Inst : IEnumerable<long>
{
public static readonly long[] Value=A238715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238715.Bytes);
public long this[int i]=>Value[i];

public static A238715Inst Instance=new A238715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238716
{
public static readonly long[] Value={ 5L,2L,1L,2L,2L,3L,3L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238716Inst : IEnumerable<long>
{
public static readonly long[] Value=A238716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238716.Bytes);
public long this[int i]=>Value[i];

public static A238716Inst Instance=new A238716Inst();

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