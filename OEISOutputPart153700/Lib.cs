using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196805
{
public static readonly long[] Value={ 1L,7L,37L,193L,1515L,8719L,52291L,334317L,2067173L,12663609L,78727511L,488078559L,3014804713L,18665197193L,115593457951L,715253390987L,4426801402571L,27403189146691L,169608418907807L,1049766166947791L,6497692031157569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196805Inst : IEnumerable<long>
{
public static readonly long[] Value=A196805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196805.Bytes);
public long this[int i]=>Value[i];

public static A196805Inst Instance=new A196805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196806
{
public static readonly long[] Value={ 1L,17L,120L,1515L,19449L,166682L,1730105L,18344433L,186996068L,1929020093L,20000798340L,205893266832L,2122824479646L,21911879424345L,226005819417517L,2331282643796687L,24051519818547252L,248109780944578426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196806Inst : IEnumerable<long>
{
public static readonly long[] Value=A196806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196806.Bytes);
public long this[int i]=>Value[i];

public static A196806Inst Instance=new A196806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196807
{
public static readonly long[] Value={ 1L,41L,420L,8719L,166682L,2535368L,46685074L,822353649L,14219232895L,247793610490L,4321118145913L,75358654335980L,1315206264464536L,22934359993226090L,399880131880385285L,6973750320639071161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196807Inst : IEnumerable<long>
{
public static readonly long[] Value=A196807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196807.Bytes);
public long this[int i]=>Value[i];

public static A196807Inst Instance=new A196807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196808
{
public static readonly BigInteger[] Value={ 1L,99L,1468L,52291L,1730105L,46685074L,1436535356L,42144649101L,1242942835600L,36966191677933L,1095659240954513L,32430161990804370L,960817109357914432L,BigInteger.Parse("28466699840871876758"),BigInteger.Parse("843388951593615572344"),BigInteger.Parse("24985495292021432741463") };
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
public class A196808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196808Inst Instance=new A196808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196809
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,16L,7L,1L,1L,17L,37L,37L,17L,1L,1L,41L,120L,193L,120L,41L,1L,1L,99L,420L,1515L,1515L,420L,99L,1L,1L,239L,1468L,8719L,19449L,8719L,1468L,239L,1L,1L,577L,4801L,52291L,166682L,166682L,52291L,4801L,577L,1L,1L,1393L,15885L,334317L,1730105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196809Inst : IEnumerable<long>
{
public static readonly long[] Value=A196809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196809.Bytes);
public long this[int i]=>Value[i];

public static A196809Inst Instance=new A196809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196810
{
public static readonly long[] Value={ 0L,4L,18L,80L,200L,420L,756L,1472L,2358L,3860L,5500L,8304L,11232L,15484L,21090L,27392L,34816L,44604L,55404L,69840L,84294L,102124L,122452L,147264L,173800L,203476L,237762L,276752L,318304L,368340L,418500L,478208L,541398L,611524L,689780L,774576L,863136L,963148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196810Inst : IEnumerable<long>
{
public static readonly long[] Value=A196810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196810.Bytes);
public long this[int i]=>Value[i];

public static A196810Inst Instance=new A196810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196811
{
public static readonly long[] Value={ 0L,0L,6L,144L,600L,1992L,4592L,15616L,31788L,74840L,122210L,251184L,384826L,647696L,1085190L,1616384L,2308872L,3449880L,4783326L,7052400L,9253734L,12454640L,16453096L,22180992L,28552450L,36216544L,46089162L,58449104L,72061346L,91140000L,109813780L,135448576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196811Inst : IEnumerable<long>
{
public static readonly long[] Value=A196811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196811.Bytes);
public long this[int i]=>Value[i];

public static A196811Inst Instance=new A196811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196812
{
public static readonly long[] Value={ 0L,2L,18L,72L,200L,378L,588L,1312L,2106L,3650L,4840L,7848L,10140L,14210L,20250L,25728L,32368L,42282L,51984L,67400L,80262L,97042L,116380L,141984L,167500L,195026L,228906L,266952L,306124L,358650L,403620L,463360L,524898L,592450L,671300L,754920L,837828L,936434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196812Inst : IEnumerable<long>
{
public static readonly long[] Value=A196812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196812.Bytes);
public long this[int i]=>Value[i];

public static A196812Inst Instance=new A196812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196813
{
public static readonly long[] Value={ 0L,0L,6L,96L,600L,1392L,2156L,10624L,22410L,62400L,82280L,210336L,280540L,495488L,955950L,1332736L,1844976L,2924640L,3933456L,6319200L,7954170L,10648000L,14081980L,19826304L,25502500L,31809856L,41037354L,52338272L,63979916L,84001200L,98348740L,123033600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196813Inst : IEnumerable<long>
{
public static readonly long[] Value=A196813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196813.Bytes);
public long this[int i]=>Value[i];

public static A196813Inst Instance=new A196813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196814
{
public static readonly long[] Value={ 1L,4L,6L,84L,120L,784L,280L,40816L,13806L,1361706L,110990L,142633176L,4263454L,197730660L,9246172320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196814Inst : IEnumerable<long>
{
public static readonly long[] Value=A196814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196814.Bytes);
public long this[int i]=>Value[i];

public static A196814Inst Instance=new A196814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196815
{
public static readonly long[] Value={ 1L,2L,14L,1L,4L,2L,18L,9L,7L,3L,29L,21L,19L,12L,8L,4L,2L,31L,21L,19L,11L,1L,59L,4L,2L,22L,24L,15L,16L,8L,6L,3L,36L,37L,174L,21L,18L,11L,12L,63L,78L,189L,38L,2L,27L,25L,112L,1L,107L,12L,6L,4L,45L,169L,28L,33L,21L,112L,14L,9L,10L,6L,4L,44L,37L,153L,151L,29L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196815Inst : IEnumerable<long>
{
public static readonly long[] Value=A196815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196815.Bytes);
public long this[int i]=>Value[i];

public static A196815Inst Instance=new A196815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196816
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,0L,5L,8L,2L,4L,4L,0L,6L,4L,1L,6L,0L,4L,3L,5L,7L,1L,0L,5L,0L,1L,5L,5L,0L,2L,2L,2L,2L,4L,0L,7L,3L,8L,8L,4L,8L,1L,0L,5L,8L,2L,0L,0L,9L,7L,7L,5L,1L,1L,6L,0L,8L,5L,3L,7L,5L,3L,7L,1L,4L,7L,6L,3L,5L,2L,2L,9L,5L,8L,5L,5L,8L,8L,3L,9L,6L,0L,3L,3L,1L,5L,5L,3L,6L,1L,0L,8L,1L,4L,9L,4L,8L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196816Inst : IEnumerable<long>
{
public static readonly long[] Value=A196816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196816.Bytes);
public long this[int i]=>Value[i];

public static A196816Inst Instance=new A196816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196817
{
public static readonly long[] Value={ 1L,4L,0L,1L,2L,6L,9L,2L,0L,7L,5L,9L,9L,9L,5L,7L,9L,4L,2L,9L,2L,7L,1L,8L,7L,2L,4L,3L,7L,9L,0L,8L,3L,4L,1L,9L,1L,5L,3L,0L,8L,8L,2L,8L,6L,5L,4L,5L,3L,3L,6L,0L,2L,6L,0L,3L,7L,9L,1L,7L,8L,2L,5L,0L,7L,8L,6L,3L,1L,6L,4L,0L,0L,0L,4L,3L,1L,7L,1L,7L,3L,3L,3L,7L,3L,4L,8L,3L,3L,1L,2L,5L,9L,5L,7L,5L,7L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196817Inst : IEnumerable<long>
{
public static readonly long[] Value=A196817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196817.Bytes);
public long this[int i]=>Value[i];

public static A196817Inst Instance=new A196817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196818
{
public static readonly long[] Value={ 1L,4L,6L,4L,6L,1L,1L,4L,7L,9L,7L,0L,1L,4L,2L,5L,0L,0L,5L,0L,1L,4L,6L,4L,8L,0L,4L,8L,0L,1L,0L,0L,2L,5L,9L,9L,7L,8L,1L,8L,0L,8L,4L,8L,1L,3L,1L,0L,9L,6L,2L,6L,9L,6L,0L,3L,7L,9L,0L,7L,1L,1L,0L,1L,7L,5L,5L,7L,2L,5L,3L,9L,2L,4L,2L,6L,1L,6L,4L,8L,4L,7L,8L,7L,8L,4L,3L,0L,1L,6L,9L,8L,0L,2L,3L,9L,7L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196818Inst : IEnumerable<long>
{
public static readonly long[] Value=A196818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196818.Bytes);
public long this[int i]=>Value[i];

public static A196818Inst Instance=new A196818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196819
{
public static readonly long[] Value={ 1L,4L,9L,3L,3L,1L,9L,5L,3L,5L,7L,3L,8L,2L,4L,2L,0L,1L,9L,2L,6L,6L,6L,7L,6L,1L,8L,4L,1L,7L,9L,8L,1L,8L,4L,0L,9L,6L,2L,5L,3L,4L,9L,9L,3L,6L,9L,7L,4L,1L,5L,8L,7L,8L,6L,6L,3L,7L,2L,7L,1L,3L,8L,7L,3L,4L,2L,0L,8L,4L,6L,1L,0L,8L,8L,1L,0L,1L,5L,7L,6L,7L,9L,2L,5L,5L,0L,3L,5L,7L,5L,2L,7L,0L,2L,8L,7L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196819Inst : IEnumerable<long>
{
public static readonly long[] Value=A196819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196819.Bytes);
public long this[int i]=>Value[i];

public static A196819Inst Instance=new A196819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196820
{
public static readonly long[] Value={ 1L,5L,0L,9L,7L,7L,1L,9L,0L,0L,4L,7L,0L,7L,2L,6L,8L,8L,5L,3L,5L,5L,4L,9L,3L,7L,5L,3L,5L,0L,0L,9L,8L,6L,5L,9L,9L,4L,4L,8L,6L,3L,7L,7L,2L,7L,5L,6L,3L,8L,3L,7L,3L,0L,5L,0L,6L,6L,8L,0L,5L,9L,3L,4L,3L,1L,5L,3L,7L,5L,3L,9L,5L,9L,0L,0L,9L,7L,0L,3L,7L,1L,1L,0L,9L,2L,9L,0L,8L,1L,2L,9L,7L,3L,8L,7L,9L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196820Inst : IEnumerable<long>
{
public static readonly long[] Value=A196820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196820.Bytes);
public long this[int i]=>Value[i];

public static A196820Inst Instance=new A196820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196821
{
public static readonly long[] Value={ 1L,5L,2L,0L,4L,4L,9L,4L,5L,0L,8L,3L,3L,8L,1L,6L,3L,6L,3L,1L,4L,7L,4L,5L,8L,8L,2L,0L,8L,9L,0L,5L,6L,3L,9L,6L,3L,1L,3L,8L,9L,8L,5L,3L,0L,5L,5L,8L,3L,2L,7L,8L,4L,3L,5L,1L,8L,1L,2L,8L,9L,3L,4L,0L,1L,3L,6L,8L,8L,1L,5L,5L,1L,6L,1L,1L,3L,2L,8L,2L,2L,3L,1L,6L,8L,8L,9L,2L,6L,3L,2L,4L,0L,2L,9L,2L,6L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196821Inst : IEnumerable<long>
{
public static readonly long[] Value=A196821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196821.Bytes);
public long this[int i]=>Value[i];

public static A196821Inst Instance=new A196821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196822
{
public static readonly long[] Value={ 6L,8L,6L,9L,2L,8L,0L,7L,2L,5L,0L,7L,1L,1L,4L,1L,5L,1L,4L,7L,7L,4L,2L,6L,6L,1L,4L,9L,4L,4L,4L,5L,7L,6L,9L,5L,9L,5L,8L,2L,2L,1L,4L,9L,8L,9L,9L,9L,1L,3L,4L,9L,6L,4L,8L,4L,9L,0L,6L,0L,3L,7L,4L,0L,8L,8L,7L,4L,9L,3L,4L,1L,8L,8L,9L,1L,8L,1L,0L,9L,4L,8L,5L,5L,1L,5L,3L,2L,6L,7L,7L,2L,9L,7L,4L,5L,9L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196822Inst : IEnumerable<long>
{
public static readonly long[] Value=A196822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196822.Bytes);
public long this[int i]=>Value[i];

public static A196822Inst Instance=new A196822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196823
{
public static readonly long[] Value={ 0L,9L,3L,7L,9L,0L,0L,2L,2L,4L,4L,3L,5L,8L,8L,1L,4L,0L,6L,4L,6L,8L,9L,1L,6L,2L,7L,2L,0L,2L,1L,0L,9L,9L,8L,6L,7L,0L,9L,0L,1L,2L,8L,8L,0L,7L,8L,5L,3L,3L,2L,8L,7L,2L,7L,1L,6L,2L,8L,5L,9L,7L,3L,8L,8L,1L,3L,4L,8L,9L,3L,1L,0L,9L,7L,8L,6L,5L,5L,8L,9L,5L,2L,4L,9L,0L,1L,4L,9L,2L,3L,8L,4L,3L,1L,1L,5L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196823Inst : IEnumerable<long>
{
public static readonly long[] Value=A196823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196823.Bytes);
public long this[int i]=>Value[i];

public static A196823Inst Instance=new A196823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196824
{
public static readonly long[] Value={ 6L,3L,4L,1L,6L,4L,9L,7L,0L,6L,9L,5L,8L,7L,7L,9L,5L,6L,1L,0L,2L,7L,4L,9L,8L,1L,1L,8L,6L,4L,0L,2L,3L,8L,0L,5L,5L,8L,2L,2L,4L,8L,4L,2L,8L,3L,9L,3L,2L,7L,5L,4L,5L,8L,4L,2L,1L,3L,3L,1L,7L,4L,7L,4L,1L,0L,3L,6L,3L,6L,2L,9L,9L,4L,1L,7L,8L,8L,6L,3L,1L,0L,0L,1L,8L,2L,8L,0L,4L,2L,7L,5L,6L,0L,4L,4L,1L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196824Inst : IEnumerable<long>
{
public static readonly long[] Value=A196824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196824.Bytes);
public long this[int i]=>Value[i];

public static A196824Inst Instance=new A196824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196825
{
public static readonly long[] Value={ 7L,1L,9L,4L,2L,1L,2L,9L,6L,3L,2L,7L,4L,1L,0L,3L,1L,5L,7L,1L,6L,9L,2L,2L,9L,7L,0L,0L,3L,7L,3L,3L,2L,0L,4L,9L,0L,8L,5L,1L,0L,1L,0L,6L,8L,3L,9L,1L,7L,9L,8L,9L,7L,8L,5L,7L,1L,0L,4L,1L,5L,7L,4L,3L,2L,1L,2L,3L,5L,3L,5L,3L,4L,5L,8L,4L,2L,0L,5L,5L,0L,1L,0L,8L,1L,9L,4L,4L,8L,3L,4L,5L,2L,2L,0L,3L,6L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196825Inst : IEnumerable<long>
{
public static readonly long[] Value=A196825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196825.Bytes);
public long this[int i]=>Value[i];

public static A196825Inst Instance=new A196825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196826
{
public static readonly long[] Value={ 4L,3L,4L,2L,0L,2L,5L,4L,9L,9L,9L,8L,1L,9L,6L,3L,8L,6L,8L,1L,3L,5L,2L,4L,4L,2L,1L,9L,6L,6L,6L,8L,4L,0L,1L,9L,8L,3L,9L,6L,2L,3L,8L,0L,7L,6L,4L,7L,6L,7L,2L,5L,5L,4L,6L,4L,7L,2L,0L,6L,3L,4L,8L,5L,3L,3L,2L,3L,7L,1L,0L,7L,3L,3L,7L,0L,0L,8L,1L,7L,0L,8L,7L,0L,1L,2L,9L,0L,2L,5L,5L,1L,5L,4L,5L,9L,7L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196826Inst : IEnumerable<long>
{
public static readonly long[] Value=A196826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196826.Bytes);
public long this[int i]=>Value[i];

public static A196826Inst Instance=new A196826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196827
{
public static readonly long[] Value={ 3L,0L,9L,1L,5L,4L,9L,3L,3L,5L,5L,8L,9L,7L,2L,5L,7L,9L,2L,5L,2L,5L,3L,4L,5L,2L,4L,1L,8L,9L,6L,4L,0L,4L,3L,0L,0L,8L,1L,3L,4L,9L,4L,2L,0L,3L,9L,0L,9L,1L,3L,3L,7L,3L,7L,4L,3L,3L,9L,3L,4L,6L,8L,0L,0L,7L,1L,1L,5L,8L,5L,1L,4L,2L,9L,6L,6L,0L,2L,9L,9L,9L,9L,3L,2L,8L,9L,6L,2L,5L,5L,0L,5L,3L,4L,7L,8L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196827Inst : IEnumerable<long>
{
public static readonly long[] Value=A196827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196827.Bytes);
public long this[int i]=>Value[i];

public static A196827Inst Instance=new A196827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196828
{
public static readonly long[] Value={ 2L,3L,8L,7L,7L,7L,6L,5L,9L,4L,4L,5L,9L,0L,4L,8L,5L,2L,5L,6L,4L,7L,2L,9L,0L,3L,0L,9L,5L,4L,6L,1L,3L,7L,4L,7L,6L,3L,8L,1L,5L,3L,9L,8L,9L,3L,9L,2L,6L,5L,3L,6L,7L,9L,7L,4L,7L,1L,1L,8L,5L,8L,5L,8L,5L,8L,4L,4L,8L,3L,5L,3L,5L,1L,1L,3L,2L,5L,0L,9L,1L,9L,6L,5L,3L,5L,9L,0L,7L,7L,4L,8L,2L,0L,9L,4L,5L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196828Inst : IEnumerable<long>
{
public static readonly long[] Value=A196828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196828.Bytes);
public long this[int i]=>Value[i];

public static A196828Inst Instance=new A196828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196829
{
public static readonly long[] Value={ 1L,9L,3L,9L,6L,2L,4L,3L,0L,6L,8L,1L,0L,0L,6L,7L,1L,6L,6L,3L,0L,0L,8L,0L,4L,7L,1L,7L,7L,3L,9L,5L,7L,4L,8L,6L,5L,5L,4L,8L,8L,5L,3L,9L,8L,6L,3L,7L,7L,5L,3L,2L,1L,2L,5L,8L,2L,5L,8L,6L,8L,2L,2L,0L,1L,7L,3L,6L,1L,1L,6L,2L,9L,7L,4L,5L,9L,2L,2L,6L,2L,3L,1L,8L,8L,6L,5L,2L,8L,0L,9L,3L,1L,6L,2L,0L,6L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196829Inst : IEnumerable<long>
{
public static readonly long[] Value=A196829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196829.Bytes);
public long this[int i]=>Value[i];

public static A196829Inst Instance=new A196829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196830
{
public static readonly long[] Value={ 1L,6L,3L,0L,7L,1L,2L,1L,1L,9L,9L,5L,5L,0L,6L,9L,1L,8L,9L,1L,1L,7L,2L,0L,2L,5L,2L,1L,4L,9L,6L,2L,3L,5L,8L,2L,3L,1L,3L,3L,1L,8L,8L,7L,4L,6L,4L,0L,3L,0L,3L,5L,5L,0L,2L,4L,6L,3L,2L,9L,1L,5L,0L,0L,1L,9L,1L,5L,2L,4L,4L,8L,6L,3L,8L,6L,8L,0L,0L,7L,4L,4L,7L,8L,8L,4L,0L,7L,7L,1L,3L,9L,0L,5L,9L,1L,0L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196830Inst : IEnumerable<long>
{
public static readonly long[] Value=A196830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196830.Bytes);
public long this[int i]=>Value[i];

public static A196830Inst Instance=new A196830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196831
{
public static readonly long[] Value={ 2L,2L,1L,4L,4L,1L,6L,9L,0L,5L,0L,7L,9L,6L,3L,6L,3L,3L,0L,6L,7L,9L,5L,6L,5L,9L,6L,0L,3L,6L,7L,7L,9L,2L,2L,1L,5L,9L,6L,6L,3L,7L,6L,4L,7L,5L,4L,4L,0L,5L,8L,6L,1L,5L,8L,1L,4L,8L,7L,3L,1L,8L,2L,5L,7L,6L,3L,1L,6L,5L,9L,4L,0L,8L,0L,2L,1L,0L,6L,1L,9L,9L,6L,1L,9L,3L,4L,3L,0L,3L,0L,7L,2L,8L,3L,6L,9L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196831Inst : IEnumerable<long>
{
public static readonly long[] Value=A196831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196831.Bytes);
public long this[int i]=>Value[i];

public static A196831Inst Instance=new A196831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196832
{
public static readonly long[] Value={ 2L,1L,1L,7L,5L,2L,6L,7L,2L,8L,4L,3L,1L,3L,3L,5L,6L,4L,2L,2L,8L,9L,1L,8L,2L,8L,8L,7L,8L,3L,0L,2L,6L,3L,7L,0L,7L,8L,1L,5L,9L,5L,1L,6L,7L,9L,1L,0L,4L,6L,3L,2L,3L,2L,6L,2L,5L,2L,5L,9L,6L,1L,4L,0L,8L,2L,5L,0L,7L,4L,4L,7L,1L,8L,8L,9L,8L,5L,5L,0L,0L,4L,1L,4L,6L,5L,1L,6L,9L,1L,0L,2L,3L,3L,1L,7L,2L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196832Inst : IEnumerable<long>
{
public static readonly long[] Value=A196832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196832.Bytes);
public long this[int i]=>Value[i];

public static A196832Inst Instance=new A196832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196833
{
public static readonly long[] Value={ 1L,2L,7L,0L,7L,1L,8L,4L,1L,1L,8L,6L,4L,4L,1L,9L,0L,5L,9L,4L,7L,9L,4L,4L,6L,4L,3L,3L,9L,3L,0L,0L,1L,7L,6L,8L,3L,8L,5L,6L,2L,5L,4L,4L,7L,1L,6L,6L,1L,6L,1L,6L,3L,2L,0L,7L,5L,0L,6L,4L,5L,8L,1L,2L,0L,3L,8L,7L,5L,4L,2L,8L,7L,7L,9L,2L,4L,1L,7L,9L,1L,2L,7L,7L,0L,9L,9L,2L,3L,3L,8L,2L,7L,6L,7L,3L,3L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196833Inst : IEnumerable<long>
{
public static readonly long[] Value=A196833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196833.Bytes);
public long this[int i]=>Value[i];

public static A196833Inst Instance=new A196833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196834
{
public static readonly long[] Value={ 1L,6L,37L,235L,1540L,10427L,73013L,529032L,3967195L,30785747L,247126450L,2050937445L,17585497797L,155666739742L,1421428484337L,13377704321695L,129659127547372L,1293095848212799L,13259069937250169L,139671750579429512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196834Inst : IEnumerable<long>
{
public static readonly long[] Value=A196834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196834.Bytes);
public long this[int i]=>Value[i];

public static A196834Inst Instance=new A196834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196835
{
public static readonly long[] Value={ 1L,4L,15L,51L,146L,273L,-319L,-6374L,-36235L,-113833L,69388L,3772035L,28631669L,112704452L,-96418909L,-5652669753L,-50538496446L,-230554460867L,281597003109L,16303457144146L,166512491229617L,872578914956059L,-1111135578108284L,-78512971676777833L,-919653124088665479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196835Inst : IEnumerable<long>
{
public static readonly long[] Value=A196835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196835.Bytes);
public long this[int i]=>Value[i];

public static A196835Inst Instance=new A196835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196836
{
public static readonly long[] Value={ 2L,5L,15L,50L,177L,650L,2445L,9350L,36177L,141170L,554325L,2186750L,8656377L,34355690L,136617405L,544061750L,2169039777L,8654570210L,34553579685L,138020346350L,551499730377L,2204254480730L,8811785649165L,35231447872550L,140878711512177L,563373614503250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196836Inst : IEnumerable<long>
{
public static readonly long[] Value=A196836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196836.Bytes);
public long this[int i]=>Value[i];

public static A196836Inst Instance=new A196836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196837
{
public static readonly long[] Value={ 1L,2L,-3L,3L,-12L,11L,4L,-30L,70L,-50L,5L,-60L,255L,-450L,274L,6L,-105L,700L,-2205L,3248L,-1764L,7L,-168L,1610L,-7840L,20307L,-26264L,13068L,8L,-252L,3276L,-22680L,89796L,-201852L,236248L,-109584L,9L,-360L,6090L,-56700L,316365L,-1077300L,2171040L,-2345400L,1026576L,10L,-495L,10560L,-127050L,946638L,-4510275L,13667720L,-25228500L,25507152L,-10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196837Inst : IEnumerable<long>
{
public static readonly long[] Value=A196837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196837.Bytes);
public long this[int i]=>Value[i];

public static A196837Inst Instance=new A196837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196838
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,0L,1L,-3L,1L,-1L,0L,1L,-2L,1L,0L,-1L,0L,5L,-5L,1L,1L,0L,-1L,0L,5L,-3L,1L,0L,1L,0L,-7L,0L,7L,-7L,1L,-1L,0L,2L,0L,-7L,0L,14L,-4L,1L,0L,-3L,0L,2L,0L,-21L,0L,6L,-9L,1L,5L,0L,-3L,0L,5L,0L,-7L,0L,15L,-5L,1L,0L,5L,0L,-11L,0L,11L,0L,-11L,0L,55L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196838Inst : IEnumerable<long>
{
public static readonly long[] Value=A196838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196838.Bytes);
public long this[int i]=>Value[i];

public static A196838Inst Instance=new A196838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196839
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,1L,1L,2L,2L,1L,30L,1L,1L,1L,1L,1L,6L,1L,3L,2L,1L,42L,1L,2L,1L,2L,1L,1L,1L,6L,1L,6L,1L,2L,2L,1L,30L,1L,3L,1L,3L,1L,3L,1L,1L,1L,10L,1L,1L,1L,5L,1L,1L,2L,1L,66L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,6L,1L,2L,1L,1L,1L,1L,1L,6L,2L,1L,2730L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196839Inst : IEnumerable<long>
{
public static readonly long[] Value=A196839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196839.Bytes);
public long this[int i]=>Value[i];

public static A196839Inst Instance=new A196839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196840
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,-1L,0L,1L,1L,1L,0L,-1L,0L,5L,1L,1L,1L,0L,-1L,0L,1L,1L,1L,0L,1L,0L,-7L,0L,7L,1L,1L,-1L,0L,2L,0L,-7L,0L,2L,1L,1L,0L,-3L,0L,1L,0L,-7L,0L,3L,1L,1L,5L,0L,-1L,0L,1L,0L,-1L,0L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196840Inst : IEnumerable<long>
{
public static readonly long[] Value=A196840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196840.Bytes);
public long this[int i]=>Value[i];

public static A196840Inst Instance=new A196840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196841
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,3L,1L,8L,19L,12L,1L,13L,59L,107L,60L,1L,19L,137L,461L,702L,360L,1L,26L,270L,1420L,3929L,5274L,2520L,1L,34L,478L,3580L,15289L,36706L,44712L,20160L,1L,43L,784L,7882L,47509L,174307L,375066L,422568L,181440L,1L,53L,1214L,15722L,126329L,649397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196841Inst : IEnumerable<long>
{
public static readonly long[] Value=A196841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196841.Bytes);
public long this[int i]=>Value[i];

public static A196841Inst Instance=new A196841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196842
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,14L,8L,1L,12L,49L,78L,40L,1L,18L,121L,372L,508L,240L,1L,25L,247L,1219L,3112L,3796L,1680L,1L,33L,447L,3195L,12864L,28692L,32048L,13440L,1L,42L,744L,7218L,41619L,144468L,290276L,301872L,120960L,1L,52L,1164L,14658L,113799L,560658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196842Inst : IEnumerable<long>
{
public static readonly long[] Value=A196842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196842.Bytes);
public long this[int i]=>Value[i];

public static A196842Inst Instance=new A196842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196843
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,11L,41L,61L,30L,1L,17L,107L,307L,396L,180L,1L,24L,226L,1056L,2545L,2952L,1260L,1L,32L,418L,2864L,10993L,23312L,24876L,10080L,1L,41L,706L,6626L,36769L,122249L,234684L,233964L,90720L,1L,51L,1116L,13686L,103029L,489939L,1457174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196843Inst : IEnumerable<long>
{
public static readonly long[] Value=A196843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196843.Bytes);
public long this[int i]=>Value[i];

public static A196843Inst Instance=new A196843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196844
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,10L,35L,50L,24L,1L,16L,95L,260L,324L,144L,1L,23L,207L,925L,2144L,2412L,1008L,1L,31L,391L,2581L,9544L,19564L,20304L,8064L,1L,40L,670L,6100L,32773L,105460L,196380L,190800L,72576L,1L,50L,1070L,12800L,93773L,433190L,1250980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196844Inst : IEnumerable<long>
{
public static readonly long[] Value=A196844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196844.Bytes);
public long this[int i]=>Value[i];

public static A196844Inst Instance=new A196844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196845
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,12L,1L,12L,47L,60L,1L,18L,119L,342L,360L,1L,25L,245L,1175L,2754L,2520L,1L,33L,445L,3135L,12154L,24552L,20160L,1L,42L,742L,7140L,40369L,133938L,241128L,181440L,1L,52L,1162L,14560L,111769L,537628L,1580508L,2592720L,1814400L,1L,63L,1734L,27342L,271929L,1767087L,7494416L,19978308L,30334320L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196845Inst : IEnumerable<long>
{
public static readonly long[] Value=A196845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196845.Bytes);
public long this[int i]=>Value[i];

public static A196845Inst Instance=new A196845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196846
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,8L,17L,10L,1L,14L,65L,112L,60L,1L,21L,163L,567L,844L,420L,1L,29L,331L,1871L,5380L,7172L,3360L,1L,38L,592L,4850L,22219L,55592L,67908L,30240L,1L,48L,972L,10770L,70719L,277782L,623828L,709320L,302400L,1L,59L,1500L,21462L,189189L,1055691L,3679430L,7571428L,8104920L,3326400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196846Inst : IEnumerable<long>
{
public static readonly long[] Value=A196846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196846.Bytes);
public long this[int i]=>Value[i];

public static A196846Inst Instance=new A196846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196847
{
public static readonly long[] Value={ 1L,1L,-5L,7L,1L,-14L,73L,-168L,148L,1L,-27L,298L,-1719L,5473L,-9162L,6396L,1L,-44L,830L,-8756L,56453L,-227744L,562060L,-778800L,468576L,1L,-65L,1865L,-31070L,332463L,-2385305L,11612795L,-37875240L,79269676L,-96420480L,52148160L,1L,-90L,3647L,-87900L,140202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196847Inst : IEnumerable<long>
{
public static readonly long[] Value=A196847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196847.Bytes);
public long this[int i]=>Value[i];

public static A196847Inst Instance=new A196847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196848
{
public static readonly long[] Value={ 1L,1L,-4L,5L,1L,-12L,55L,-114L,94L,1L,-24L,238L,-1248L,3661L,-5736L,3828L,1L,-40L,690L,-6700L,40053L,-151060L,351800L,-465000L,270576L,1L,-60L,1595L,-24720L,247203L,-1665900L,7660565L,-23745720L,47560876L,-55805520L,29400480L,1L,-84L,3185L,-72030L,1081353L,-11344872L,85234175L,-461800710L,1790256286L,-4843901664L,8693117160L,-9320129280L,4546558080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196848Inst : IEnumerable<long>
{
public static readonly long[] Value=A196848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196848.Bytes);
public long this[int i]=>Value[i];

public static A196848Inst Instance=new A196848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196849
{
public static readonly long[] Value={ 1L,11L,206L,16876L,4326720L,3805929995L,11300853019444L,113522093851497024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196849Inst : IEnumerable<long>
{
public static readonly long[] Value=A196849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196849.Bytes);
public long this[int i]=>Value[i];

public static A196849Inst Instance=new A196849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196850
{
public static readonly long[] Value={ 2L,11L,38L,136L,496L,1792L,6440L,23306L,84180L,303664L,1096874L,3960906L,14299036L,51633110L,186437376L,673147554L,2430568646L,8776143806L,31687921122L,114416191032L,413124704992L,1491673030176L,5386005309890L,19447328987316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196850Inst : IEnumerable<long>
{
public static readonly long[] Value=A196850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196850.Bytes);
public long this[int i]=>Value[i];

public static A196850Inst Instance=new A196850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196851
{
public static readonly long[] Value={ 4L,38L,206L,1370L,8767L,56470L,363685L,2343584L,15108610L,97376923L,627590184L,4044924351L,26070308556L,168028055199L,1082971243944L,6979940126878L,44986968132898L,289949111595991L,1868774104215258L,12044584704922151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196851Inst : IEnumerable<long>
{
public static readonly long[] Value=A196851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196851.Bytes);
public long this[int i]=>Value[i];

public static A196851Inst Instance=new A196851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196852
{
public static readonly long[] Value={ 6L,136L,1370L,16876L,199125L,2369631L,28194191L,335586650L,3993458371L,47516896629L,565414492412L,6728166888869L,80061424960490L,952681438970742L,11336327457310421L,134895508948869550L,1605175914338415794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196852Inst : IEnumerable<long>
{
public static readonly long[] Value=A196852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196852.Bytes);
public long this[int i]=>Value[i];

public static A196852Inst Instance=new A196852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196853
{
public static readonly BigInteger[] Value={ 12L,496L,8767L,199125L,4326720L,94652804L,2069281146L,45250654402L,989582452566L,21641093339471L,473258424515226L,10349412319177011L,226326014259354738L,4949414076598335496L,BigInteger.Parse("108236297594374361032"),BigInteger.Parse("2366965861351964408167") };
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
public class A196853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196853Inst Instance=new A196853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196854
{
public static readonly BigInteger[] Value={ 22L,1792L,56470L,2369631L,94652804L,3805929995L,152929723254L,6148984299163L,247223213832440L,9939022894905148L,399570539750626195L,16063726580619196531UL,BigInteger.Parse("645804489432297174658"),BigInteger.Parse("25963059069129330544089") };
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
public class A196854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196854Inst Instance=new A196854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196855
{
public static readonly BigInteger[] Value={ 40L,6440L,363685L,28194191L,2069281146L,152929723254L,11300853019444L,835390769370971L,61745852507376150L,4563708721504197779L,BigInteger.Parse("337310171120447151691"),BigInteger.Parse("24931202561823495912020"),BigInteger.Parse("1842711946915214490433763") };
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
public class A196855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196855Inst Instance=new A196855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196856
{
public static readonly long[] Value={ 1L,2L,2L,4L,11L,4L,6L,38L,38L,6L,12L,136L,206L,136L,12L,22L,496L,1370L,1370L,496L,22L,40L,1792L,8767L,16876L,8767L,1792L,40L,74L,6440L,56470L,199125L,199125L,56470L,6440L,74L,136L,23306L,363685L,2369631L,4326720L,2369631L,363685L,23306L,136L,250L,84180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196856Inst : IEnumerable<long>
{
public static readonly long[] Value=A196856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196856.Bytes);
public long this[int i]=>Value[i];

public static A196856Inst Instance=new A196856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196857
{
public static readonly long[] Value={ 1L,2L,7L,35L,473L,11280L,494579L,44461736L,7927841482L,2782301025984L,1928382976203757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196857Inst : IEnumerable<long>
{
public static readonly long[] Value=A196857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196857.Bytes);
public long this[int i]=>Value[i];

public static A196857Inst Instance=new A196857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196858
{
public static readonly long[] Value={ 1L,3L,7L,12L,26L,56L,113L,235L,490L,1012L,2099L,4356L,9026L,18714L,38806L,80450L,166797L,345830L,717003L,1486565L,3082117L,6390162L,13248759L,27468753L,56951126L,118077121L,244810064L,507566235L,1052340264L,2181823742L,4523588913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196858Inst : IEnumerable<long>
{
public static readonly long[] Value=A196858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196858.Bytes);
public long this[int i]=>Value[i];

public static A196858Inst Instance=new A196858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196859
{
public static readonly long[] Value={ 1L,4L,12L,35L,102L,281L,787L,2237L,6346L,17976L,50903L,144132L,408157L,1155913L,3273609L,9270960L,26255482L,74355847L,210576950L,596357727L,1688896077L,4782984549L,13545499068L,38361099308L,108639331309L,307668565890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196859Inst : IEnumerable<long>
{
public static readonly long[] Value=A196859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196859.Bytes);
public long this[int i]=>Value[i];

public static A196859Inst Instance=new A196859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196860
{
public static readonly long[] Value={ 1L,6L,26L,102L,473L,1900L,7428L,29859L,120761L,488123L,1973886L,7978980L,32236748L,130244330L,526284444L,2126673912L,8593813805L,34727312754L,140331197760L,567069475233L,2291493536866L,9259796163176L,37418329505296L,151205438122194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196860Inst : IEnumerable<long>
{
public static readonly long[] Value=A196860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196860.Bytes);
public long this[int i]=>Value[i];

public static A196860Inst Instance=new A196860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196861
{
public static readonly long[] Value={ 1L,9L,56L,281L,1900L,11280L,62298L,350779L,1995082L,11350977L,64705845L,368982902L,2102619515L,11979490295L,68255053688L,388895058185L,2215852784526L,12625820295021L,71941345568563L,409917070251636L,2335679313403415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196861Inst : IEnumerable<long>
{
public static readonly long[] Value=A196861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196861.Bytes);
public long this[int i]=>Value[i];

public static A196861Inst Instance=new A196861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196862
{
public static readonly long[] Value={ 1L,13L,113L,787L,7428L,62298L,494579L,3938849L,31419870L,250968250L,2008718820L,16085753439L,128812555358L,1031543802305L,8260521035929L,66148710544824L,529714073173089L,4241953681722567L,33969698176325537L,272030805637262923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196862Inst : IEnumerable<long>
{
public static readonly long[] Value=A196862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196862.Bytes);
public long this[int i]=>Value[i];

public static A196862Inst Instance=new A196862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196863
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,6L,12L,12L,6L,1L,1L,9L,26L,35L,26L,9L,1L,1L,13L,56L,102L,102L,56L,13L,1L,1L,19L,113L,281L,473L,281L,113L,19L,1L,1L,28L,235L,787L,1900L,1900L,787L,235L,28L,1L,1L,41L,490L,2237L,7428L,11280L,7428L,2237L,490L,41L,1L,1L,60L,1012L,6346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196863Inst : IEnumerable<long>
{
public static readonly long[] Value=A196863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196863.Bytes);
public long this[int i]=>Value[i];

public static A196863Inst Instance=new A196863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196864
{
public static readonly BigInteger[] Value={ 1L,3L,-9L,-198L,1188L,30213L,-220239L,-5945238L,47541735L,1325876283L,-11192990913L,-318640183182L,2787445591416L,80483342059224L,-722019579525288L,-21063846331387728L,192542324985927324L,5661585516173303268L,BigInteger.Parse("-52508399485861250604"),BigInteger.Parse("-1553593208517770295816") };
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
public class A196864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196864Inst Instance=new A196864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196865
{
public static readonly BigInteger[] Value={ 1L,3L,18L,-117L,-1971L,16119L,343278L,-3036528L,-71818164L,661017348L,16593480504L,-156436510221L,-4080815440497L,39095628518637L,1047594828442626L,-10152600834566916L,-277489726161424569L,2712640349690579349L,BigInteger.Parse("75279129630178436622"),BigInteger.Parse("-740885355955719640809") };
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
public class A196865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196865Inst Instance=new A196865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196866
{
public static readonly BigInteger[] Value={ 1L,4L,-24L,-800L,9824L,381824L,-5715712L,-236348416L,3885237760L,166141515776L,-2884493168640L,-125973507063808L,2266868356071424L,100441740460359680L,-1853741093854511104L,BigInteger.Parse("-83006642599731134464"),BigInteger.Parse("1561071322451916750848"),BigInteger.Parse("70464426394180291919872") };
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
public class A196866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196866Inst Instance=new A196866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196867
{
public static readonly BigInteger[] Value={ 1L,4L,40L,-544L,-14240L,240512L,7905536L,-144081920L,-5248825856L,99459618816L,3842132979712L,-74547398033408L,-2991092285194240L,58965437254402048L,2429529032173420544L,BigInteger.Parse("-48445417122664284160"),BigInteger.Parse("-2035619492638819483648"),BigInteger.Parse("40941665274780773253120") };
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
public class A196867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196867Inst Instance=new A196867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196868
{
public static readonly BigInteger[] Value={ 1L,6L,-18L,144L,-1026L,10368L,-91044L,995328L,-9630090L,109486080L,-1120744188L,13042778112L,-138540597588L,1637370298368L,-17853248637000L,213325958873088L,-2371846639850586L,28573129903177728L,-322526246042905740L,3910007249908531200L,BigInteger.Parse("-44670671340291807228") };
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
public class A196868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196868Inst Instance=new A196868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196869
{
public static readonly BigInteger[] Value={ 1L,6L,-36L,216L,-2592L,23328L,-311040L,3265920L,-45349632L,517321728L,-7336562688L,88159684608L,-1266403590144L,15771513618432L,-228509902503936L,2921050338066432L,-42583086769766400L,555279063084564480L,-8132204141176946688L,BigInteger.Parse("107718176292801085440") };
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
public class A196869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196869Inst Instance=new A196869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196870
{
public static readonly BigInteger[] Value={ 1L,2L,6L,36L,360L,6120L,171360L,7882560L,591192000L,72125424000L,14280833952000L,4584147698592000L,2383756803267840000L,BigInteger.Parse("2007123228351521280000"),BigInteger.Parse("2735708960243123504640000"),BigInteger.Parse("6034973966296330451235840000"),BigInteger.Parse("21544857059677899710911948800000") };
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
public class A196870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196870Inst Instance=new A196870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196871
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,21L,32L,42L,64L,84L,85L,128L,168L,170L,256L,336L,340L,341L,453L,512L,672L,680L,682L,906L,909L,1024L,1344L,1360L,1364L,1365L,1812L,1813L,1818L,2048L,2688L,2720L,2728L,2730L,3624L,3626L,3636L,4096L,5376L,5440L,5456L,5460L,5461L,7248L,7252L,7272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196871Inst : IEnumerable<long>
{
public static readonly long[] Value=A196871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196871.Bytes);
public long this[int i]=>Value[i];

public static A196871Inst Instance=new A196871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196872
{
public static readonly long[] Value={ 1L,2L,2L,6L,6L,6L,6L,6L,6L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L,1806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196872Inst : IEnumerable<long>
{
public static readonly long[] Value=A196872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196872.Bytes);
public long this[int i]=>Value[i];

public static A196872Inst Instance=new A196872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196873
{
public static readonly BigInteger[] Value={ 1L,1L,17L,961L,116129L,24419521L,7935695921L,3689986634881L,2325980044877633L,1909820766285110401L,BigInteger.Parse("1980859561990210210385"),BigInteger.Parse("2532925102150057552027201"),BigInteger.Parse("3914882960190010585911806177"),BigInteger.Parse("7195136206495188167173611850561"),BigInteger.Parse("15509756436233434005672607162123889") };
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
public class A196873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196873Inst Instance=new A196873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196874
{
public static readonly long[] Value={ 2L,3L,43L,2L,7L,3L,61L,23L,17L,5L,109L,73L,67L,37L,19L,7L,3L,127L,73L,67L,31L,2L,277L,7L,3L,79L,89L,47L,53L,19L,13L,5L,151L,157L,1033L,73L,61L,31L,37L,307L,397L,1129L,163L,3L,103L,97L,613L,2L,587L,37L,13L,7L,197L,1009L,107L,137L,73L,613L,43L,23L,29L,13L,7L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196874Inst : IEnumerable<long>
{
public static readonly long[] Value=A196874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196874.Bytes);
public long this[int i]=>Value[i];

public static A196874Inst Instance=new A196874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196875
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,8L,16L,32L,64L,125L,243L,471L,911L,1759L,3394L,6546L,12622L,24334L,46910L,90427L,174309L,335997L,647661L,1248413L,2406400L,4638492L,8940988L,17234316L,33220220L,64034041L,123429591L,237918195L,458602075L,883983931L,1703933822L,3284438054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196875Inst : IEnumerable<long>
{
public static readonly long[] Value=A196875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196875.Bytes);
public long this[int i]=>Value[i];

public static A196875Inst Instance=new A196875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196876
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,14L,28L,56L,112L,224L,448L,896L,1786L,3559L,7091L,14127L,28143L,56063L,111679L,222463L,443141L,882724L,1758358L,3502590L,6977038L,13898014L,27684350L,55146238L,109849336L,218815949L,435873541L,868244493L,1729511949L,3445125885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196876Inst : IEnumerable<long>
{
public static readonly long[] Value=A196876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196876.Bytes);
public long this[int i]=>Value[i];

public static A196876Inst Instance=new A196876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196877
{
public static readonly long[] Value={ 2L,0L,4L,6L,6L,2L,2L,0L,2L,4L,4L,7L,2L,7L,4L,0L,6L,4L,6L,1L,6L,9L,6L,4L,1L,0L,0L,8L,1L,7L,6L,9L,7L,3L,4L,7L,6L,6L,3L,7L,4L,4L,1L,9L,5L,3L,4L,9L,4L,6L,5L,6L,2L,6L,0L,6L,1L,0L,2L,6L,8L,5L,5L,2L,7L,2L,5L,9L,0L,6L,6L,8L,7L,9L,5L,1L,2L,1L,7L,3L,3L,6L,5L,8L,4L,6L,8L,8L,4L,6L,7L,6L,3L,2L,9L,1L,2L,5L,2L,5L,3L,4L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196877Inst : IEnumerable<long>
{
public static readonly long[] Value=A196877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196877.Bytes);
public long this[int i]=>Value[i];

public static A196877Inst Instance=new A196877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196878
{
public static readonly long[] Value={ 6L,0L,4L,1L,8L,8L,2L,9L,0L,9L,7L,7L,5L,0L,9L,3L,5L,2L,2L,1L,5L,0L,4L,2L,4L,1L,3L,0L,6L,7L,5L,9L,9L,5L,9L,8L,5L,5L,0L,8L,7L,1L,0L,3L,0L,5L,7L,7L,4L,6L,4L,1L,9L,0L,7L,2L,5L,8L,6L,0L,1L,0L,1L,5L,2L,6L,0L,0L,4L,3L,0L,2L,5L,4L,6L,5L,5L,7L,5L,8L,1L,6L,0L,4L,0L,4L,7L,0L,8L,2L,6L,5L,8L,8L,2L,6L,1L,6L,9L,5L,1L,5L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196878Inst : IEnumerable<long>
{
public static readonly long[] Value=A196878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196878.Bytes);
public long this[int i]=>Value[i];

public static A196878Inst Instance=new A196878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196879
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,3L,10L,1L,1L,1L,1L,6L,23L,36L,1L,1L,1L,1L,9L,72L,132L,94L,1L,1L,1L,1L,16L,335L,1086L,729L,284L,1L,1L,1L,1L,36L,2220L,15265L,15076L,3987L,692L,1L,1L,1L,1L,85L,19166L,374160L,642457L,182832L,18687L,1828L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196879Inst : IEnumerable<long>
{
public static readonly long[] Value=A196879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196879.Bytes);
public long this[int i]=>Value[i];

public static A196879Inst Instance=new A196879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196880
{
public static readonly long[] Value={ 1L,1L,4L,10L,36L,94L,284L,692L,1828L,4124L,9828L,20798L,45564L,91018L,186788L,355906L,692004L,1264678L,2347716L,4138358L,7389572L,12625938L,21804900L,36243644L,60777212L,98547380L,160987868L,255297602L,407492292L,633469718L,990388828L,1512185428L,2320518948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196880Inst : IEnumerable<long>
{
public static readonly long[] Value=A196880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196880.Bytes);
public long this[int i]=>Value[i];

public static A196880Inst Instance=new A196880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196881
{
public static readonly long[] Value={ 1L,1L,3L,23L,132L,729L,3987L,18687L,82350L,342383L,1295579L,4634280L,15873501L,51143461L,156932559L,463212189L,1309275981L,3576241449L,9484669665L,24306269493L,60475548510L,146630200929L,345755185335L,796397380425L,1797676089003L,3970398558042L,8602390112508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196881Inst : IEnumerable<long>
{
public static readonly long[] Value=A196881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196881.Bytes);
public long this[int i]=>Value[i];

public static A196881Inst Instance=new A196881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196882
{
public static readonly long[] Value={ 1L,1L,6L,72L,1086L,15076L,182832L,1957192L,18583582L,154252476L,1166493640L,8049232896L,50660059120L,292884155232L,1582952988656L,8045405614080L,38559135542174L,174391413419872L,746859203235976L,3047000304533760L,11915800843394536L,44815994695641600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196882Inst : IEnumerable<long>
{
public static readonly long[] Value=A196882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196882.Bytes);
public long this[int i]=>Value[i];

public static A196882Inst Instance=new A196882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196883
{
public static readonly BigInteger[] Value={ 1L,1L,9L,335L,15265L,642457L,21719504L,619319180L,14357878818L,288862888125L,4963576426547L,73352623884216L,969821344896765L,11543613849547500L,123338010592648600L,1190399192738655590L,10575211376139294058UL,BigInteger.Parse("87409151426766072750"),BigInteger.Parse("674329967169731919750") };
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
public class A196883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196883Inst Instance=new A196883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196884
{
public static readonly BigInteger[] Value={ 1L,1L,16L,2220L,374160L,53511471L,6188114528L,527457882126L,36521876237448L,1952615455825446L,86220169777616208L,3212254985375294550L,BigInteger.Parse("99345949328271872420"),BigInteger.Parse("2632974948301168473984"),BigInteger.Parse("61767819644161815082080"),BigInteger.Parse("1284454579537478675292282"),BigInteger.Parse("23584751451820642893522984") };
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
public class A196884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196884Inst Instance=new A196884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196885
{
public static readonly BigInteger[] Value={ 1L,1L,36L,19166L,14615986L,8939918814L,3837284133564L,1226373476385199L,270102925553717303L,BigInteger.Parse("46188578538444709937"),BigInteger.Parse("5945914039134501155164"),BigInteger.Parse("595502415534028698326141"),BigInteger.Parse("49457500873761026837492373"),BigInteger.Parse("3353360710521929211582306983"),BigInteger.Parse("186523687141803451969677785640") };
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
public class A196885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196885Inst Instance=new A196885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196886
{
public static readonly BigInteger[] Value={ 1L,1L,85L,217862L,880915707L,2723350958080L,5498735029150412L,6897556038713219072L,BigInteger.Parse("6071277235712979102634"),BigInteger.Parse("3511244471110991227215296"),BigInteger.Parse("1503179627327417142865920896"),BigInteger.Parse("477381405632773485831171726016"),BigInteger.Parse("111948028342925752822983662888144") };
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
public class A196886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196886Inst Instance=new A196886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196887
{
public static readonly BigInteger[] Value={ 1L,1L,210L,3428059L,87935111811L,1541533772278182L,16177644099354374847UL,BigInteger.Parse("101539033269801820825743"),BigInteger.Parse("365618223095981778848684187"),BigInteger.Parse("884267692532264259002637317099"),BigInteger.Parse("1357042381209389119735863425487474"),BigInteger.Parse("1470981941328093110877043096244300403") };
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
public class A196887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196887Inst Instance=new A196887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196888
{
public static readonly BigInteger[] Value={ 1L,1L,586L,71688050L,13580513909670L,1659137949188540410L,BigInteger.Parse("104146398517005199125840"),BigInteger.Parse("3421092256089716422594644400"),BigInteger.Parse("64402239847567589358641684368970"),BigInteger.Parse("657656444358222872135019335879897500"),BigInteger.Parse("4362395890943439751990308572939648140812") };
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
public class A196888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196888Inst Instance=new A196888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196889
{
public static readonly long[] Value={ 1L,1L,4L,3L,6L,9L,16L,36L,85L,210L,586L,1914L,6930L,28178L,125440L,603350L,3083410L,17362239L,112403052L,820563290L,6632950912L,58209665965L,544071039000L,5353538904357L,58523908575096L,730174875609318L,10274727352967428L,159586345364505768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196889Inst : IEnumerable<long>
{
public static readonly long[] Value=A196889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196889.Bytes);
public long this[int i]=>Value[i];

public static A196889Inst Instance=new A196889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196890
{
public static readonly BigInteger[] Value={ 1L,1L,10L,23L,72L,335L,2220L,19166L,217862L,3428059L,71688050L,1884401480L,63363038340L,2929516409504L,178211319638172L,13290584617658383L,1240111930777216192L,BigInteger.Parse("158642776309162956097"),BigInteger.Parse("26642849845285577276244"),BigInteger.Parse("5432337767302682299726906") };
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
public class A196890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196890Inst Instance=new A196890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196891
{
public static readonly BigInteger[] Value={ 1L,1L,36L,132L,1086L,15265L,374160L,14615986L,880915707L,87935111811L,13580513909670L,3070403347926710L,1135311726763434816L,BigInteger.Parse("641959330240781369240"),BigInteger.Parse("510702153600297288442786"),BigInteger.Parse("653871437018428663002896250"),BigInteger.Parse("1287709155623146652148156476562") };
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
public class A196891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196891Inst Instance=new A196891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196892
{
public static readonly BigInteger[] Value={ 1L,1L,94L,729L,15076L,642457L,53511471L,8939918814L,2723350958080L,1541533772278182L,1659137949188540410L,BigInteger.Parse("3004476086657587282943"),BigInteger.Parse("10324888948772382935056000"),BigInteger.Parse("62412485736933252992029397897"),BigInteger.Parse("625874099080778019949864563475382") };
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
public class A196892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196892Inst Instance=new A196892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196893
{
public static readonly BigInteger[] Value={ 1L,1L,284L,3987L,182832L,21719504L,6188114528L,3837284133564L,5498735029150412L,16177644099354374847UL,BigInteger.Parse("104146398517005199125840"),BigInteger.Parse("1392276105682819242572329909"),BigInteger.Parse("37088099509347734659184844866868"),BigInteger.Parse("2148432835664289026090145748437694346") };
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
public class A196893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196893Inst Instance=new A196893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196894
{
public static readonly BigInteger[] Value={ 1L,1L,692L,18687L,1957192L,619319180L,527457882126L,1226373476385199L,6897556038713219072L,BigInteger.Parse("101539033269801820825743"),BigInteger.Parse("3421092256089716422594644400"),BigInteger.Parse("290708740669462708301488632766350"),BigInteger.Parse("55192415971099812757135585564036238784") };
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
public class A196894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196894Inst Instance=new A196894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196895
{
public static readonly BigInteger[] Value={ 1L,1L,1828L,82350L,18583582L,14357878818L,36521876237448L,270102925553717303L,BigInteger.Parse("6071277235712979102634"),BigInteger.Parse("365618223095981778848684187"),BigInteger.Parse("64402239847567589358641684368970"),BigInteger.Parse("28651633202605088497137960394142606995"),BigInteger.Parse("36379111301200246544606370148459181785142784") };
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
public class A196895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196895Inst Instance=new A196895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196896
{
public static readonly BigInteger[] Value={ 1L,1L,4124L,342383L,154252476L,288862888125L,1952615455825446L,BigInteger.Parse("46188578538444709937"),BigInteger.Parse("3511244471110991227215296"),BigInteger.Parse("884267692532264259002637317099"),BigInteger.Parse("657656444358222872135019335879897500"),BigInteger.Parse("1581273532137910865654568892971737150590744") };
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
public class A196896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196896Inst Instance=new A196896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196897
{
public static readonly BigInteger[] Value={ 1L,1L,9828L,1295579L,1166493640L,4963576426547L,86220169777616208L,BigInteger.Parse("5945914039134501155164"),BigInteger.Parse("1503179627327417142865920896"),BigInteger.Parse("1357042381209389119735863425487474"),BigInteger.Parse("4362395890943439751990308572939648140812"),BigInteger.Parse("45406477414358716832258194914969299144120147523") };
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
public class A196897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196897Inst Instance=new A196897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196898
{
public static readonly long[] Value={ 1L,1L,20L,401L,37194L,9855864L,8351540397L,21716826606543L,177451785967252194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196898Inst : IEnumerable<long>
{
public static readonly long[] Value=A196898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196898.Bytes);
public long this[int i]=>Value[i];

public static A196898Inst Instance=new A196898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196899
{
public static readonly long[] Value={ 1L,3L,20L,71L,286L,1176L,4768L,19265L,78414L,318016L,1290577L,5238372L,21260925L,86285262L,350204527L,1421330461L,5768590644L,23412347684L,95021149248L,385651641498L,1565201886761L,6352511449133L,25782234607765L,104639500545470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196899Inst : IEnumerable<long>
{
public static readonly long[] Value=A196899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196899.Bytes);
public long this[int i]=>Value[i];

public static A196899Inst Instance=new A196899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196900
{
public static readonly long[] Value={ 1L,7L,71L,401L,2975L,20191L,141833L,986015L,6866117L,47832829L,333044999L,2319651781L,16154076631L,112501830469L,783493377407L,5456430897109L,38000064950619L,264641895220837L,1843034804766363L,12835364615219383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196900Inst : IEnumerable<long>
{
public static readonly long[] Value=A196900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196900.Bytes);
public long this[int i]=>Value[i];

public static A196900Inst Instance=new A196900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196901
{
public static readonly long[] Value={ 1L,17L,286L,2975L,37194L,447668L,5598122L,68526999L,842919460L,10357555484L,127428834080L,1566632663538L,19262232783013L,236846283912466L,2912263245992491L,35808425686370875L,440291862121641219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196901Inst : IEnumerable<long>
{
public static readonly long[] Value=A196901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196901.Bytes);
public long this[int i]=>Value[i];

public static A196901Inst Instance=new A196901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196902
{
public static readonly BigInteger[] Value={ 1L,41L,1176L,20191L,447668L,9855864L,216042764L,4683808777L,102440829474L,2232503865348L,48692888533485L,1062046643313404L,23164137991212547L,505192448140138820L,11018595483560578437UL,BigInteger.Parse("240317309840328016805") };
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
public class A196902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196902Inst Instance=new A196902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196903
{
public static readonly BigInteger[] Value={ 1L,99L,4768L,141833L,5598122L,216042764L,8351540397L,321111082107L,12356839088825L,475267463574534L,18301760788493413L,704261042875463142L,BigInteger.Parse("27105588968030124804"),BigInteger.Parse("1043189030239853499999"),BigInteger.Parse("40149431446819879902095") };
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
public class A196903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196903Inst Instance=new A196903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196904
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,20L,7L,1L,1L,17L,71L,71L,17L,1L,1L,41L,286L,401L,286L,41L,1L,1L,99L,1176L,2975L,2975L,1176L,99L,1L,1L,239L,4768L,20191L,37194L,20191L,4768L,239L,1L,1L,577L,19265L,141833L,447668L,447668L,141833L,19265L,577L,1L,1L,1393L,78414L,986015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196904Inst : IEnumerable<long>
{
public static readonly long[] Value=A196904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196904.Bytes);
public long this[int i]=>Value[i];

public static A196904Inst Instance=new A196904Inst();

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