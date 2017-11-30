using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197657
{
public static readonly long[] Value={ 1L,4L,22L,134L,866L,5812L,40048L,281374L,2006698L,14482064L,105527060L,775113440L,5731756720L,42628923040L,318621793472L,2391808860446L,18023208400634L,136271601087352L,1033449449559724L,7858699302115444L,59906766929537116L,457685157123172664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197657Inst : IEnumerable<long>
{
public static readonly long[] Value=A197657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197657.Bytes);
public long this[int i]=>Value[i];

public static A197657Inst Instance=new A197657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197658
{
public static readonly long[] Value={ 2L,3L,0L,5L,3L,7L,0L,0L,5L,11L,0L,13L,7L,5L,0L,17L,0L,19L,0L,7L,11L,23L,0L,0L,13L,0L,0L,29L,5L,31L,0L,11L,17L,13L,0L,37L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,0L,0L,17L,0L,53L,0L,21L,0L,19L,29L,59L,0L,61L,31L,0L,0L,13L,11L,67L,0L,23L,13L,71L,0L,73L,37L,0L,0L,31L,13L,79L,0L,0L,41L,83L,0L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197658Inst : IEnumerable<long>
{
public static readonly long[] Value=A197658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197658.Bytes);
public long this[int i]=>Value[i];

public static A197658Inst Instance=new A197658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197659
{
public static readonly long[] Value={ 1L,1L,4L,12L,42L,172L,768L,4488L,28215L,202201L,1848800L,18647319L,230926401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197659Inst : IEnumerable<long>
{
public static readonly long[] Value=A197659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197659.Bytes);
public long this[int i]=>Value[i];

public static A197659Inst Instance=new A197659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197660
{
public static readonly long[] Value={ 1L,1L,4L,19L,116L,1109L,15390L,312785L,9410767L,416753642L,27195802437L,2617717241482L,371516018279032L,77760873988114592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197660Inst : IEnumerable<long>
{
public static readonly long[] Value=A197660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197660.Bytes);
public long this[int i]=>Value[i];

public static A197660Inst Instance=new A197660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197661
{
public static readonly long[] Value={ 1L,5L,14L,63L,536L,15648L,545796L,50029471L,6569786146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197661Inst : IEnumerable<long>
{
public static readonly long[] Value=A197661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197661.Bytes);
public long this[int i]=>Value[i];

public static A197661Inst Instance=new A197661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197662
{
public static readonly long[] Value={ 1L,4L,21L,260L,5402L,277217L,26746470L,4529806572L,1752572020493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197662Inst : IEnumerable<long>
{
public static readonly long[] Value=A197662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197662.Bytes);
public long this[int i]=>Value[i];

public static A197662Inst Instance=new A197662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197663
{
public static readonly long[] Value={ 1L,1L,13L,49L,567L,15412L,329372L,21751339L,2108724044L,293878982370L,87209877288093L,39253957174939181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197663Inst : IEnumerable<long>
{
public static readonly long[] Value=A197663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197663.Bytes);
public long this[int i]=>Value[i];

public static A197663Inst Instance=new A197663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197664
{
public static readonly long[] Value={ 1L,4L,10L,47L,489L,6519L,146513L,6298384L,434627282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197664Inst : IEnumerable<long>
{
public static readonly long[] Value=A197664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197664.Bytes);
public long this[int i]=>Value[i];

public static A197664Inst Instance=new A197664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197665
{
public static readonly long[] Value={ 1L,9L,95L,5005L,709083L,311676959L,417293944115L,1717065757366333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197665Inst : IEnumerable<long>
{
public static readonly long[] Value=A197665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197665.Bytes);
public long this[int i]=>Value[i];

public static A197665Inst Instance=new A197665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197666
{
public static readonly long[] Value={ 3L,9L,22L,71L,217L,642L,1963L,5963L,18018L,54753L,166329L,504940L,1534985L,4667983L,14198968L,43215503L,131584139L,400800484L,1221337807L,3723140135L,11353757744L,34635822651L,105696236527L,322652635812L,985253141189L,3009481166143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197666Inst : IEnumerable<long>
{
public static readonly long[] Value=A197666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197666.Bytes);
public long this[int i]=>Value[i];

public static A197666Inst Instance=new A197666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197667
{
public static readonly long[] Value={ 4L,22L,95L,546L,2765L,14503L,74812L,386556L,2008698L,10415923L,54096117L,280793815L,1457402796L,7564115674L,39256668738L,203743660496L,1057439556784L,5488205547156L,28484308704921L,147836021658293L,767281388051654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197667Inst : IEnumerable<long>
{
public static readonly long[] Value=A197667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197667.Bytes);
public long this[int i]=>Value[i];

public static A197667Inst Instance=new A197667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197668
{
public static readonly long[] Value={ 5L,71L,546L,5005L,44323L,403960L,3675345L,33272751L,301565202L,2734015025L,24796812073L,224875172500L,2039110071283L,18490725428895L,167679905896100L,1520586052304877L,13789181642921163L,125044668702632018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197668Inst : IEnumerable<long>
{
public static readonly long[] Value=A197668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197668.Bytes);
public long this[int i]=>Value[i];

public static A197668Inst Instance=new A197668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197669
{
public static readonly ulong[] Value={ 9L,217L,2765L,44323L,709083L,11277331L,178113620L,2824369075L,44803424135L,710299706355L,11259206241825L,178502455899971L,2830080961456550L,44867619862024252L,711321096455186766L,11277240691421407939UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197669Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197669.Bytes);
public ulong this[int i]=>Value[i];

public static A197669Inst Instance=new A197669Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197670
{
public static readonly BigInteger[] Value={ 16L,642L,14503L,403960L,11277331L,311676959L,8613257822L,239118653300L,6630227642552L,183756345226485L,5094599088185193L,141246701196281961L,3915786139554013344L,BigInteger.Parse("108558677747367102730"),BigInteger.Parse("3009656266880644396542") };
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
public class A197670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197670Inst Instance=new A197670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197671
{
public static readonly BigInteger[] Value={ 25L,1963L,74812L,3675345L,178113620L,8613257822L,417293944115L,20252638815131L,981414876628367L,47569549221404522L,2306162325188337684L,BigInteger.Parse("111794015697526614448"),BigInteger.Parse("5419263655984491978357"),BigInteger.Parse("262704965350074163519109") };
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
public class A197671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197671Inst Instance=new A197671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197672
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,22L,22L,5L,9L,71L,95L,71L,9L,16L,217L,546L,546L,217L,16L,25L,642L,2765L,5005L,2765L,642L,25L,39L,1963L,14503L,44323L,44323L,14503L,1963L,39L,64L,5963L,74812L,403960L,709083L,403960L,74812L,5963L,64L,105L,18018L,386556L,3675345L,11277331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197672Inst : IEnumerable<long>
{
public static readonly long[] Value=A197672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197672.Bytes);
public long this[int i]=>Value[i];

public static A197672Inst Instance=new A197672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197673
{
public static readonly long[] Value={ 1L,9L,57L,1111L,45162L,4268977L,924904506L,452341382317L,504191764208638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197673Inst : IEnumerable<long>
{
public static readonly long[] Value=A197673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197673.Bytes);
public long this[int i]=>Value[i];

public static A197673Inst Instance=new A197673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197674
{
public static readonly long[] Value={ 4L,16L,57L,202L,721L,2557L,8930L,31326L,110217L,387627L,1363559L,4796483L,16870356L,59337438L,208705786L,734075168L,2581952574L,9081465807L,31942103268L,112349483389L,395165129695L,1389908311471L,4888703531124L,17194963235219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197674Inst : IEnumerable<long>
{
public static readonly long[] Value=A197674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197674.Bytes);
public long this[int i]=>Value[i];

public static A197674Inst Instance=new A197674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197675
{
public static readonly long[] Value={ 5L,33L,202L,1111L,5639L,29190L,153715L,817865L,4363976L,23310791L,124634939L,666885018L,3570183285L,19119296745L,102409115514L,548602179057L,2939069643391L,15746490425394L,84366772518821L,452030585522887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197675Inst : IEnumerable<long>
{
public static readonly long[] Value=A197675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197675.Bytes);
public long this[int i]=>Value[i];

public static A197675Inst Instance=new A197675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197676
{
public static readonly long[] Value={ 9L,73L,721L,5639L,45162L,358209L,2871646L,22955155L,183536379L,1469158622L,11763937411L,94210675699L,754505710941L,6042768236882L,48396947691377L,387618351751497L,3104512821455985L,24864750644129585L,199147883255433840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197676Inst : IEnumerable<long>
{
public static readonly long[] Value=A197676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197676.Bytes);
public long this[int i]=>Value[i];

public static A197676Inst Instance=new A197676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197677
{
public static readonly long[] Value={ 16L,160L,2557L,29190L,358209L,4268977L,51167876L,612121676L,7361707007L,88656931195L,1068147837085L,12872396820775L,155149962503924L,1870214789373352L,22545546614910072L,271799896014413918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197677Inst : IEnumerable<long>
{
public static readonly long[] Value=A197677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197677.Bytes);
public long this[int i]=>Value[i];

public static A197677Inst Instance=new A197677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197678
{
public static readonly BigInteger[] Value={ 25L,361L,8930L,153715L,2871646L,51167876L,924904506L,16683567785L,302284521370L,5474405589906L,99183749443489L,1797437230322126L,32577752904902204L,590500270236515512L,10703710573822288345UL,BigInteger.Parse("194025178417426634201") };
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
public class A197678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197678Inst Instance=new A197678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197679
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,16L,16L,5L,9L,33L,57L,33L,9L,16L,73L,202L,202L,73L,16L,25L,160L,721L,1111L,721L,160L,25L,39L,361L,2557L,5639L,5639L,2557L,361L,39L,64L,835L,8930L,29190L,45162L,29190L,8930L,835L,64L,105L,1966L,31326L,153715L,358209L,358209L,153715L,31326L,1966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197679Inst : IEnumerable<long>
{
public static readonly long[] Value=A197679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197679.Bytes);
public long this[int i]=>Value[i];

public static A197679Inst Instance=new A197679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197680
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,46L,47L,48L,51L,53L,55L,57L,58L,59L,61L,62L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197680Inst : IEnumerable<long>
{
public static readonly long[] Value=A197680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197680.Bytes);
public long this[int i]=>Value[i];

public static A197680Inst Instance=new A197680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197681
{
public static readonly long[] Value={ 1L,4L,9L,12L,24L,45L,57L,71L,171L,162L,294L,526L,634L,774L,1965L,1306L,2739L,4924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197681Inst : IEnumerable<long>
{
public static readonly long[] Value=A197681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197681.Bytes);
public long this[int i]=>Value[i];

public static A197681Inst Instance=new A197681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197682
{
public static readonly long[] Value={ 3L,7L,9L,2L,7L,3L,4L,9L,6L,4L,9L,7L,3L,8L,8L,0L,7L,2L,6L,7L,2L,2L,1L,5L,3L,4L,4L,5L,2L,2L,4L,4L,6L,4L,3L,2L,0L,6L,9L,2L,1L,3L,1L,8L,2L,8L,2L,0L,2L,6L,5L,4L,9L,8L,3L,3L,4L,4L,9L,4L,1L,0L,6L,8L,9L,1L,2L,7L,4L,0L,6L,8L,5L,5L,0L,4L,7L,8L,6L,8L,8L,1L,6L,0L,3L,1L,6L,5L,8L,7L,0L,0L,7L,6L,7L,7L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197682Inst : IEnumerable<long>
{
public static readonly long[] Value=A197682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197682.Bytes);
public long this[int i]=>Value[i];

public static A197682Inst Instance=new A197682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197683
{
public static readonly long[] Value={ 2L,1L,5L,6L,7L,4L,3L,5L,9L,5L,7L,5L,3L,9L,6L,7L,5L,7L,2L,1L,3L,3L,9L,6L,9L,1L,8L,5L,7L,2L,8L,3L,7L,6L,6L,6L,1L,9L,8L,9L,7L,6L,6L,1L,7L,7L,9L,8L,5L,8L,6L,5L,7L,6L,3L,0L,3L,1L,5L,4L,0L,7L,1L,0L,4L,9L,8L,8L,1L,4L,5L,5L,8L,3L,8L,8L,6L,1L,5L,5L,3L,0L,3L,6L,6L,1L,0L,3L,5L,3L,7L,0L,1L,0L,9L,2L,9L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197683Inst : IEnumerable<long>
{
public static readonly long[] Value=A197683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197683.Bytes);
public long this[int i]=>Value[i];

public static A197683Inst Instance=new A197683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197684
{
public static readonly long[] Value={ 1L,1L,9L,1L,5L,2L,2L,8L,3L,0L,2L,9L,7L,5L,0L,8L,5L,4L,6L,5L,5L,9L,1L,0L,6L,3L,4L,7L,1L,1L,7L,3L,0L,5L,0L,1L,0L,0L,2L,9L,3L,7L,1L,5L,1L,6L,8L,6L,7L,2L,8L,7L,4L,1L,2L,1L,5L,2L,9L,7L,8L,1L,8L,9L,2L,6L,2L,6L,3L,4L,1L,3L,4L,5L,9L,2L,6L,2L,5L,8L,1L,1L,1L,5L,3L,7L,0L,0L,8L,2L,5L,6L,6L,3L,3L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197684Inst : IEnumerable<long>
{
public static readonly long[] Value=A197684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197684.Bytes);
public long this[int i]=>Value[i];

public static A197684Inst Instance=new A197684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197685
{
public static readonly long[] Value={ 9L,5L,9L,7L,8L,0L,8L,5L,6L,4L,4L,3L,2L,3L,9L,3L,2L,9L,8L,5L,0L,7L,2L,6L,3L,0L,3L,6L,8L,5L,7L,8L,2L,5L,8L,0L,3L,6L,1L,1L,6L,2L,0L,6L,6L,7L,3L,1L,4L,6L,0L,1L,1L,5L,2L,7L,8L,5L,5L,5L,5L,2L,1L,1L,1L,1L,4L,4L,3L,3L,6L,9L,2L,0L,6L,7L,8L,8L,6L,6L,0L,6L,5L,6L,6L,4L,6L,0L,2L,9L,2L,1L,4L,3L,8L,4L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197685Inst : IEnumerable<long>
{
public static readonly long[] Value=A197685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197685.Bytes);
public long this[int i]=>Value[i];

public static A197685Inst Instance=new A197685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197686
{
public static readonly long[] Value={ 6L,1L,1L,0L,1L,5L,4L,7L,0L,3L,5L,1L,6L,5L,7L,2L,8L,9L,3L,8L,0L,5L,9L,5L,3L,8L,7L,9L,5L,3L,9L,6L,8L,8L,6L,1L,7L,3L,7L,4L,2L,2L,6L,3L,2L,9L,5L,6L,0L,9L,2L,7L,9L,5L,2L,0L,8L,9L,1L,6L,7L,7L,5L,0L,4L,2L,4L,6L,4L,8L,3L,3L,9L,3L,6L,3L,1L,5L,8L,3L,8L,6L,5L,7L,3L,7L,1L,3L,8L,3L,4L,5L,6L,6L,7L,4L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197686Inst : IEnumerable<long>
{
public static readonly long[] Value=A197686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197686.Bytes);
public long this[int i]=>Value[i];

public static A197686Inst Instance=new A197686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197687
{
public static readonly long[] Value={ 7L,6L,7L,2L,9L,1L,0L,3L,4L,4L,5L,6L,7L,1L,7L,6L,2L,1L,9L,7L,8L,4L,3L,4L,7L,0L,3L,2L,0L,7L,5L,7L,0L,0L,7L,2L,5L,6L,7L,3L,4L,6L,4L,6L,7L,8L,7L,2L,0L,3L,4L,6L,2L,4L,1L,3L,1L,7L,5L,3L,7L,5L,1L,2L,1L,0L,5L,9L,2L,5L,5L,4L,2L,1L,4L,8L,7L,5L,6L,6L,3L,0L,4L,1L,5L,6L,9L,0L,7L,2L,5L,6L,4L,7L,4L,1L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197687Inst : IEnumerable<long>
{
public static readonly long[] Value=A197687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197687.Bytes);
public long this[int i]=>Value[i];

public static A197687Inst Instance=new A197687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197688
{
public static readonly long[] Value={ 8L,7L,9L,8L,0L,1L,6L,9L,2L,9L,7L,6L,8L,8L,5L,2L,4L,8L,1L,7L,9L,0L,4L,2L,7L,4L,9L,0L,2L,7L,4L,2L,6L,7L,6L,7L,5L,9L,8L,3L,7L,4L,8L,8L,6L,4L,7L,5L,3L,7L,8L,4L,8L,2L,5L,3L,1L,8L,9L,9L,7L,3L,6L,2L,5L,1L,6L,8L,0L,4L,2L,6L,1L,6L,7L,8L,0L,6L,1L,9L,5L,3L,7L,3L,7L,0L,0L,9L,1L,5L,8L,7L,3L,8L,5L,2L,6L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197688Inst : IEnumerable<long>
{
public static readonly long[] Value=A197688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197688.Bytes);
public long this[int i]=>Value[i];

public static A197688Inst Instance=new A197688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197689
{
public static readonly long[] Value={ 1L,0L,3L,0L,9L,7L,7L,6L,7L,7L,2L,9L,4L,3L,8L,0L,7L,5L,7L,6L,4L,9L,5L,5L,9L,1L,2L,4L,6L,8L,0L,7L,1L,8L,3L,7L,5L,4L,9L,8L,3L,5L,4L,0L,3L,2L,9L,5L,0L,6L,7L,4L,4L,5L,0L,1L,9L,1L,0L,8L,3L,0L,4L,3L,9L,6L,1L,8L,9L,6L,6L,2L,8L,3L,9L,3L,7L,9L,2L,2L,1L,1L,1L,7L,7L,2L,6L,6L,1L,1L,0L,2L,5L,3L,7L,0L,4L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197689Inst : IEnumerable<long>
{
public static readonly long[] Value=A197689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197689.Bytes);
public long this[int i]=>Value[i];

public static A197689Inst Instance=new A197689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197690
{
public static readonly long[] Value={ 3L,0L,5L,5L,0L,7L,7L,3L,5L,1L,7L,5L,8L,2L,8L,6L,4L,4L,6L,9L,0L,2L,9L,7L,6L,9L,3L,9L,7L,6L,9L,8L,4L,4L,3L,0L,8L,6L,8L,7L,1L,1L,3L,1L,6L,4L,7L,8L,0L,4L,6L,3L,9L,7L,6L,0L,4L,4L,5L,8L,3L,8L,7L,5L,2L,1L,2L,3L,2L,4L,1L,6L,9L,6L,8L,1L,5L,7L,9L,1L,9L,3L,2L,8L,6L,8L,5L,6L,9L,1L,7L,2L,8L,3L,3L,7L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197690Inst : IEnumerable<long>
{
public static readonly long[] Value=A197690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197690.Bytes);
public long this[int i]=>Value[i];

public static A197690Inst Instance=new A197690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197691
{
public static readonly long[] Value={ 1L,8L,9L,6L,3L,6L,7L,4L,8L,2L,4L,8L,6L,9L,4L,0L,3L,6L,3L,3L,6L,1L,0L,7L,6L,7L,2L,2L,6L,1L,2L,2L,3L,2L,1L,6L,0L,3L,4L,6L,0L,6L,5L,9L,1L,4L,1L,0L,1L,3L,2L,7L,4L,9L,1L,6L,7L,2L,4L,7L,0L,5L,3L,4L,4L,5L,6L,3L,7L,0L,3L,4L,2L,7L,5L,2L,3L,9L,3L,4L,4L,0L,8L,0L,1L,5L,8L,2L,9L,3L,5L,0L,3L,8L,3L,8L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197691Inst : IEnumerable<long>
{
public static readonly long[] Value=A197691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197691.Bytes);
public long this[int i]=>Value[i];

public static A197691Inst Instance=new A197691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197692
{
public static readonly long[] Value={ 6L,7L,7L,5L,6L,0L,9L,8L,3L,6L,0L,9L,7L,4L,9L,9L,3L,1L,0L,0L,8L,9L,6L,2L,3L,8L,6L,5L,3L,3L,4L,5L,6L,8L,8L,7L,9L,4L,9L,8L,0L,4L,0L,4L,0L,9L,4L,4L,4L,8L,3L,1L,6L,7L,0L,9L,2L,1L,5L,9L,1L,1L,2L,5L,5L,2L,0L,1L,3L,3L,7L,3L,6L,5L,2L,1L,2L,1L,4L,7L,3L,1L,3L,8L,7L,0L,3L,5L,2L,9L,4L,8L,4L,9L,8L,2L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197692Inst : IEnumerable<long>
{
public static readonly long[] Value=A197692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197692.Bytes);
public long this[int i]=>Value[i];

public static A197692Inst Instance=new A197692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197693
{
public static readonly long[] Value={ 5L,9L,5L,7L,6L,1L,4L,1L,5L,1L,4L,8L,7L,5L,4L,2L,7L,3L,2L,7L,9L,5L,5L,3L,1L,7L,3L,5L,5L,8L,6L,5L,2L,5L,0L,5L,0L,1L,4L,6L,8L,5L,7L,5L,8L,4L,3L,3L,6L,4L,3L,7L,0L,6L,0L,7L,6L,4L,8L,9L,0L,9L,4L,6L,3L,1L,3L,1L,7L,0L,6L,7L,2L,9L,6L,3L,1L,2L,9L,0L,5L,5L,7L,6L,8L,5L,0L,4L,1L,2L,8L,3L,1L,6L,9L,0L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197693Inst : IEnumerable<long>
{
public static readonly long[] Value=A197693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197693.Bytes);
public long this[int i]=>Value[i];

public static A197693Inst Instance=new A197693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197694
{
public static readonly long[] Value={ 4L,3L,9L,9L,0L,0L,8L,4L,6L,4L,8L,8L,4L,4L,2L,6L,2L,4L,0L,8L,9L,5L,2L,1L,3L,7L,4L,5L,1L,3L,7L,1L,3L,3L,8L,3L,7L,9L,9L,1L,8L,7L,4L,4L,3L,2L,3L,7L,6L,8L,9L,2L,4L,1L,2L,6L,5L,9L,4L,9L,8L,6L,8L,1L,2L,5L,8L,4L,0L,2L,1L,3L,0L,8L,3L,9L,0L,3L,0L,9L,7L,6L,8L,6L,8L,5L,0L,4L,5L,7L,9L,3L,6L,9L,2L,6L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197694Inst : IEnumerable<long>
{
public static readonly long[] Value=A197694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197694.Bytes);
public long this[int i]=>Value[i];

public static A197694Inst Instance=new A197694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197695
{
public static readonly long[] Value={ 2L,5L,5L,7L,6L,3L,6L,7L,8L,1L,5L,2L,2L,3L,9L,2L,0L,7L,3L,2L,6L,1L,4L,4L,9L,0L,1L,0L,6L,9L,1L,9L,0L,0L,2L,4L,1L,8L,9L,1L,1L,5L,4L,8L,9L,2L,9L,0L,6L,7L,8L,2L,0L,8L,0L,4L,3L,9L,1L,7L,9L,1L,7L,0L,7L,0L,1L,9L,7L,5L,1L,8L,0L,7L,1L,6L,2L,5L,2L,2L,1L,0L,1L,3L,8L,5L,6L,3L,5L,7L,5L,2L,1L,5L,8L,0L,4L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197695Inst : IEnumerable<long>
{
public static readonly long[] Value=A197695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197695.Bytes);
public long this[int i]=>Value[i];

public static A197695Inst Instance=new A197695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197696
{
public static readonly long[] Value={ 1L,6L,9L,2L,0L,8L,7L,6L,5L,6L,1L,4L,1L,0L,9L,5L,9L,3L,8L,1L,0L,5L,4L,6L,9L,0L,1L,9L,9L,1L,4L,0L,7L,5L,6L,7L,0L,0L,5L,0L,0L,9L,5L,8L,4L,0L,7L,9L,3L,8L,5L,6L,4L,9L,7L,2L,1L,3L,1L,0L,0L,5L,7L,4L,6L,4L,9L,1L,7L,4L,6L,5L,1L,3L,8L,0L,2L,8L,6L,1L,6L,6L,8L,9L,2L,6L,2L,5L,0L,4L,3L,3L,6L,2L,9L,4L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197696Inst : IEnumerable<long>
{
public static readonly long[] Value=A197696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197696.Bytes);
public long this[int i]=>Value[i];

public static A197696Inst Instance=new A197696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197697
{
public static readonly long[] Value={ 4L,7L,3L,3L,7L,2L,4L,0L,3L,6L,2L,4L,8L,4L,1L,9L,2L,2L,6L,9L,9L,7L,0L,0L,7L,6L,4L,3L,7L,6L,1L,5L,8L,2L,6L,5L,8L,6L,5L,2L,6L,4L,3L,1L,2L,3L,1L,8L,0L,5L,6L,5L,1L,1L,2L,9L,2L,7L,1L,3L,5L,0L,1L,6L,8L,2L,2L,4L,4L,8L,4L,1L,6L,6L,0L,0L,1L,7L,3L,8L,6L,6L,6L,2L,8L,2L,3L,7L,3L,4L,7L,4L,9L,3L,2L,7L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197697Inst : IEnumerable<long>
{
public static readonly long[] Value=A197697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197697.Bytes);
public long this[int i]=>Value[i];

public static A197697Inst Instance=new A197697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197698
{
public static readonly long[] Value={ 4L,3L,1L,9L,3L,8L,5L,6L,5L,2L,3L,8L,6L,3L,2L,8L,3L,3L,7L,0L,3L,5L,6L,8L,5L,6L,1L,1L,7L,1L,3L,6L,5L,4L,9L,7L,0L,2L,4L,0L,1L,3L,2L,0L,0L,1L,1L,7L,8L,4L,6L,7L,7L,3L,7L,1L,0L,9L,2L,4L,0L,3L,0L,7L,8L,8L,2L,5L,1L,4L,7L,0L,6L,9L,7L,2L,9L,1L,1L,5L,7L,9L,2L,1L,5L,3L,6L,4L,7L,0L,5L,5L,4L,5L,4L,0L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197698Inst : IEnumerable<long>
{
public static readonly long[] Value=A197698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197698.Bytes);
public long this[int i]=>Value[i];

public static A197698Inst Instance=new A197698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197699
{
public static readonly long[] Value={ 3L,4L,3L,6L,5L,9L,2L,2L,5L,7L,6L,4L,7L,9L,3L,5L,8L,5L,8L,8L,3L,1L,8L,6L,3L,7L,4L,8L,9L,3L,5L,7L,2L,7L,9L,1L,8L,3L,2L,7L,8L,4L,6L,7L,7L,6L,5L,0L,2L,2L,4L,8L,1L,6L,7L,3L,0L,3L,6L,1L,0L,1L,4L,6L,5L,3L,9L,6L,5L,5L,4L,2L,7L,9L,7L,9L,3L,0L,7L,3L,7L,0L,5L,9L,0L,8L,8L,7L,0L,3L,4L,1L,7L,9L,0L,1L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197699Inst : IEnumerable<long>
{
public static readonly long[] Value=A197699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197699.Bytes);
public long this[int i]=>Value[i];

public static A197699Inst Instance=new A197699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197700
{
public static readonly long[] Value={ 4L,3L,1L,3L,4L,8L,7L,1L,9L,1L,5L,0L,7L,9L,3L,5L,1L,4L,4L,2L,6L,7L,9L,3L,8L,3L,7L,1L,4L,5L,6L,7L,5L,3L,3L,2L,3L,9L,7L,9L,5L,3L,2L,3L,5L,5L,9L,7L,1L,7L,3L,1L,5L,2L,6L,0L,6L,3L,0L,8L,1L,4L,2L,0L,9L,9L,7L,6L,2L,9L,1L,1L,6L,7L,7L,7L,2L,3L,1L,0L,6L,0L,7L,3L,2L,2L,0L,7L,0L,7L,4L,0L,2L,1L,8L,5L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197700Inst : IEnumerable<long>
{
public static readonly long[] Value=A197700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197700.Bytes);
public long this[int i]=>Value[i];

public static A197700Inst Instance=new A197700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197701
{
public static readonly long[] Value={ 2L,3L,1L,5L,7L,2L,0L,7L,9L,4L,3L,7L,7L,0L,9L,7L,2L,1L,6L,0L,6L,2L,8L,9L,1L,1L,4L,5L,5L,1L,1L,3L,1L,2L,3L,0L,8L,9L,3L,0L,5L,4L,4L,3L,8L,1L,6L,8L,6L,5L,5L,2L,5L,2L,2L,8L,3L,8L,8L,4L,2L,4L,7L,9L,9L,2L,4L,0L,9L,7L,2L,9L,9L,7L,4L,0L,5L,9L,2L,3L,2L,7L,5L,6L,6L,1L,8L,4L,5L,6L,7L,2L,9L,1L,6L,5L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197701Inst : IEnumerable<long>
{
public static readonly long[] Value=A197701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197701.Bytes);
public long this[int i]=>Value[i];

public static A197701Inst Instance=new A197701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197702
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,4L,3L,4L,3L,4L,5L,6L,5L,4L,5L,4L,5L,6L,5L,6L,7L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,8L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,10L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197702Inst : IEnumerable<long>
{
public static readonly long[] Value=A197702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197702.Bytes);
public long this[int i]=>Value[i];

public static A197702Inst Instance=new A197702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197703
{
public static readonly long[] Value={ 1L,4L,15L,118L,1410L,30190L,1180218L,81842153L,10130408182L,2211726542134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197703Inst : IEnumerable<long>
{
public static readonly long[] Value=A197703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197703.Bytes);
public long this[int i]=>Value[i];

public static A197703Inst Instance=new A197703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197704
{
public static readonly long[] Value={ 13L,18L,42L,60L,100L,115L,120L,145L,272L,279L,310L,319L,341L,372L,403L,434L,465L,480L,493L,496L,518L,540L,592L,595L,612L,665L,720L,748L,792L,805L,864L,884L,900L,918L,952L,1053L,1080L,1147L,1200L,1254L,1287L,1312L,1320L,1360L,1440L,1482L,1520L,1560L,1591L,1596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197704Inst : IEnumerable<long>
{
public static readonly long[] Value=A197704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197704.Bytes);
public long this[int i]=>Value[i];

public static A197704Inst Instance=new A197704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197705
{
public static readonly long[] Value={ 1L,1L,10L,39L,464L,13117L,385689L,22773446L,2779601106L,534016211475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197705Inst : IEnumerable<long>
{
public static readonly long[] Value=A197705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197705.Bytes);
public long this[int i]=>Value[i];

public static A197705Inst Instance=new A197705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197706
{
public static readonly long[] Value={ 1L,2L,5L,12L,77L,720L,9259L,193296L,6058254L,309777781L,24621646669L,3052707195554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197706Inst : IEnumerable<long>
{
public static readonly long[] Value=A197706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197706.Bytes);
public long this[int i]=>Value[i];

public static A197706Inst Instance=new A197706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197707
{
public static readonly long[] Value={ 1L,2L,0L,1L,3L,1L,5L,5L,6L,9L,8L,18L,19L,26L,33L,41L,52L,60L,87L,99L,132L,166L,209L,261L,323L,398L,481L,604L,716L,893L,1086L,1331L,1629L,1991L,2428L,2952L,3578L,4314L,5217L,6229L,7508L,8967L,10737L,12838L,15345L,18334L,21894L,26127L,31149L,37093L,44100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197707Inst : IEnumerable<long>
{
public static readonly long[] Value=A197707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197707.Bytes);
public long this[int i]=>Value[i];

public static A197707Inst Instance=new A197707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197708
{
public static readonly long[] Value={ 128L,610L,4572L,25045L,102807L,339119L,948645L,2337564L,5211939L,10721353L,20642867L,37610342L,65394162L,109236388L,176246402L,275862066L,420381442L,625570111L,911349137L,1302568701L,1829872465L,2530657691L,3450136161L,4642500937L,6172204001L,8115349815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197708Inst : IEnumerable<long>
{
public static readonly long[] Value=A197708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197708.Bytes);
public long this[int i]=>Value[i];

public static A197708Inst Instance=new A197708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197709
{
public static readonly long[] Value={ 256L,1525L,15241L,106441L,534597L,2091239L,6776036L,18992710L,47486563L,108285670L,228948163L,454458310L,855154435L,1537112038L,2655445795L,4431034438L,7171212835L,11295015910L,17363599363L,26116502470L,38514458563L,55789499110L,79503137635L,111613460038L,154551988195L,211311224038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197709Inst : IEnumerable<long>
{
public static readonly long[] Value=A197709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197709.Bytes);
public long this[int i]=>Value[i];

public static A197709Inst Instance=new A197709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197710
{
public static readonly long[] Value={ 512L,3814L,50805L,452376L,2779905L,12895977L,48400258L,154315775L,432655358L,1093685272L,2539243267L,5491371250L,11182788769L,21629362253L,40008716648L,71173490663L,122332454247L,203937787267L,330822261550L,523635874526L,810637651662L,1229904866745L,1832028823765L,2683373601749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197710Inst : IEnumerable<long>
{
public static readonly long[] Value=A197710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197710.Bytes);
public long this[int i]=>Value[i];

public static A197710Inst Instance=new A197710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197711
{
public static readonly long[] Value={ 1024L,9536L,169350L,1922601L,14455510L,79525193L,345716130L,1253815679L,3941971040L,11046221254L,28162516239L,66354069277L,146236468527L,304356025989L,602797997502L,1143224193788L,2086847748926L,3682210047876L,6303034667438L,10498899284252L,17061992477838L,27113811835076L,42216316373726L,64512773675388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197711Inst : IEnumerable<long>
{
public static readonly long[] Value=A197711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197711.Bytes);
public long this[int i]=>Value[i];

public static A197711Inst Instance=new A197711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197712
{
public static readonly BigInteger[] Value={ 1L,6L,42L,410L,5032L,75418L,1334838L,27249052L,630249409L,16288946267L,465239139606L,14551915228366L,494696673952511L,18161513224841275L,716102966059713315L,BigInteger.Parse("30181658957863752409"),BigInteger.Parse("1354087807629298185929"),BigInteger.Parse("64430442087414935111821"),BigInteger.Parse("3240840189607299761533535"),BigInteger.Parse("171821387249394349577932210") };
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
public class A197712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197712Inst Instance=new A197712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197713
{
public static readonly BigInteger[] Value={ 1L,5L,37L,352L,4315L,64534L,1140538L,23256803L,537441241L,13880477010L,396218076727L,12386985584175L,420923890579261L,15447592770126359L,608903758014263548L,BigInteger.Parse("25656487848259583960"),BigInteger.Parse("1150788495459483630199"),BigInteger.Parse("54745172171004903538414"),BigInteger.Parse("2753138362843249502728559"),BigInteger.Parse("145939080567682948612742851") };
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
public class A197713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197713Inst Instance=new A197713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197714
{
public static readonly BigInteger[] Value={ 1L,5L,34L,326L,3988L,59604L,1052848L,21460092L,495764693L,12800845441L,365323615365L,11419131242070L,387977390372849L,14236659589753581L,561109543344974893L,BigInteger.Parse("23640346895461300427"),BigInteger.Parse("1060265646084471617079"),BigInteger.Parse("50434955069054663240727"),BigInteger.Parse("2536202597745552881270240") };
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
public class A197714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197714Inst Instance=new A197714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197715
{
public static readonly BigInteger[] Value={ 1L,4L,32L,311L,3802L,56800L,1003061L,20441408L,472161363L,12189944199L,347854999334L,10872213398722L,369369563065819L,13553043160362242L,534138422146939893L,BigInteger.Parse("22502990284669009819"),BigInteger.Parse("1009214769013552542796"),BigInteger.Parse("48004835269442445650150"),BigInteger.Parse("2413922625560072092051194"),BigInteger.Parse("127946199132847926094882311") };
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
public class A197715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197715Inst Instance=new A197715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197716
{
public static readonly BigInteger[] Value={ 3L,21L,255L,4633L,110409L,3243618L,113177497L,4570858600L,209655304353L,10763674952098L,611433842280388L,38071427445729201L,2578294348444597267L,BigInteger.Parse("188670154792420320215"),BigInteger.Parse("14834716200104606205408"),BigInteger.Parse("1247263229999781126495328"),BigInteger.Parse("111661618863544248806155260") };
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
public class A197716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197716Inst Instance=new A197716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197717
{
public static readonly BigInteger[] Value={ 4L,43L,814L,22519L,811369L,35946076L,1888624972L,114746269758L,7912720985080L,610470884770407L,52094956940751711L,4871691779130290167L,BigInteger.Parse("495409898474358881327"),BigInteger.Parse("54427906182810588386674"),BigInteger.Parse("6424384909407981686846706"),BigInteger.Parse("810777549111969648699638307"),BigInteger.Parse("108944087230453697240059783284") };
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
public class A197717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197717Inst Instance=new A197717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197718
{
public static readonly long[] Value={ 1L,2L,11L,80L,1162L,32623L,1615507L,144988922L,23856782383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197718Inst : IEnumerable<long>
{
public static readonly long[] Value=A197718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197718.Bytes);
public long this[int i]=>Value[i];

public static A197718Inst Instance=new A197718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197719
{
public static readonly long[] Value={ 61L,110L,248L,328L,445L,499L,510L,561L,697L,708L,1001L,1004L,1145L,1226L,1309L,1342L,1470L,1563L,1565L,1785L,2012L,2042L,2065L,2259L,2372L,2515L,2540L,2795L,2800L,2806L,2840L,2958L,3076L,3390L,3448L,3779L,3896L,4022L,4031L,4135L,4235L,4320L,4345L,4396L,4412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197719Inst : IEnumerable<long>
{
public static readonly long[] Value=A197719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197719.Bytes);
public long this[int i]=>Value[i];

public static A197719Inst Instance=new A197719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197720
{
public static readonly long[] Value={ 1L,1L,22L,87L,1726L,68819L,4003781L,565032173L,152764693020L,80175405643606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197720Inst : IEnumerable<long>
{
public static readonly long[] Value=A197720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197720.Bytes);
public long this[int i]=>Value[i];

public static A197720Inst Instance=new A197720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197721
{
public static readonly long[] Value={ 1L,7L,25L,409L,14185L,1029761L,168151040L,60063611063L,47206720536227L,81729461999719503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197721Inst : IEnumerable<long>
{
public static readonly long[] Value=A197721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197721.Bytes);
public long this[int i]=>Value[i];

public static A197721Inst Instance=new A197721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197722
{
public static readonly long[] Value={ 1L,9L,52L,8L,112L,147L,586L,716L,27L,100L,1154L,4157L,4688L,5239L,581L,64L,22166L,2415L,2619L,28285L,30432L,10319L,34882L,37181L,125L,41924L,44366L,46853L,15617L,51962L,54582L,18102L,59948L,62693L,207063L,216L,71171L,74076L,77019L,800L,83019L,272192L,28197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197722Inst : IEnumerable<long>
{
public static readonly long[] Value=A197722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197722.Bytes);
public long this[int i]=>Value[i];

public static A197722Inst Instance=new A197722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197723
{
public static readonly long[] Value={ 4L,7L,1L,2L,3L,8L,8L,9L,8L,0L,3L,8L,4L,6L,8L,9L,8L,5L,7L,6L,9L,3L,9L,6L,5L,0L,7L,4L,9L,1L,9L,2L,5L,4L,3L,2L,6L,2L,9L,5L,7L,5L,4L,0L,9L,9L,0L,6L,2L,6L,5L,8L,7L,3L,1L,4L,6L,2L,4L,1L,6L,8L,8L,8L,4L,6L,1L,7L,2L,4L,6L,0L,9L,4L,2L,9L,3L,1L,3L,4L,9L,7L,9L,4L,2L,0L,5L,2L,2L,3L,8L,0L,1L,3L,1L,7L,5L,6L,0L,1L,9L,7L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197723Inst : IEnumerable<long>
{
public static readonly long[] Value=A197723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197723.Bytes);
public long this[int i]=>Value[i];

public static A197723Inst Instance=new A197723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197724
{
public static readonly long[] Value={ 1L,9L,1L,9L,5L,6L,1L,7L,1L,2L,8L,8L,6L,4L,7L,8L,6L,5L,9L,7L,0L,1L,4L,5L,2L,6L,0L,7L,3L,7L,1L,5L,6L,5L,1L,6L,0L,7L,2L,2L,3L,2L,4L,1L,3L,3L,4L,6L,2L,9L,2L,0L,2L,3L,0L,5L,5L,7L,1L,1L,1L,0L,4L,2L,2L,2L,2L,8L,8L,6L,7L,3L,8L,4L,1L,3L,5L,7L,7L,3L,2L,1L,3L,1L,3L,2L,9L,2L,0L,5L,8L,4L,2L,8L,7L,6L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197724Inst : IEnumerable<long>
{
public static readonly long[] Value=A197724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197724.Bytes);
public long this[int i]=>Value[i];

public static A197724Inst Instance=new A197724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197725
{
public static readonly long[] Value={ 1L,3L,8L,1L,9L,8L,9L,2L,6L,7L,6L,3L,6L,0L,2L,2L,7L,4L,2L,1L,0L,4L,5L,5L,7L,8L,8L,5L,2L,2L,4L,6L,4L,9L,3L,4L,9L,0L,0L,0L,4L,1L,9L,6L,2L,6L,4L,2L,4L,3L,4L,8L,8L,5L,5L,9L,1L,1L,1L,4L,5L,1L,1L,9L,8L,0L,4L,4L,5L,5L,5L,5L,3L,9L,5L,0L,5L,9L,6L,6L,0L,7L,8L,8L,0L,6L,3L,2L,9L,9L,3L,5L,9L,4L,4L,1L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197725Inst : IEnumerable<long>
{
public static readonly long[] Value=A197725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197725.Bytes);
public long this[int i]=>Value[i];

public static A197725Inst Instance=new A197725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197726
{
public static readonly long[] Value={ 7L,5L,8L,5L,4L,6L,9L,9L,2L,9L,9L,4L,7L,7L,6L,1L,4L,5L,3L,4L,4L,4L,3L,0L,6L,8L,9L,0L,4L,4L,8L,9L,2L,8L,6L,4L,1L,3L,8L,4L,2L,6L,3L,6L,5L,6L,4L,0L,5L,3L,0L,9L,9L,6L,6L,6L,8L,9L,8L,8L,2L,1L,3L,7L,8L,2L,5L,4L,8L,1L,3L,7L,1L,0L,0L,9L,5L,7L,3L,7L,6L,3L,2L,0L,6L,3L,3L,1L,7L,4L,0L,1L,5L,3L,5L,5L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197726Inst : IEnumerable<long>
{
public static readonly long[] Value=A197726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197726.Bytes);
public long this[int i]=>Value[i];

public static A197726Inst Instance=new A197726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197727
{
public static readonly long[] Value={ 1L,2L,2L,2L,0L,3L,0L,9L,4L,0L,7L,0L,3L,3L,1L,4L,5L,7L,8L,7L,6L,1L,1L,9L,0L,7L,7L,5L,9L,0L,7L,9L,3L,7L,7L,2L,3L,4L,7L,4L,8L,4L,5L,2L,6L,5L,9L,1L,2L,1L,8L,5L,5L,9L,0L,4L,1L,7L,8L,3L,3L,5L,5L,0L,0L,8L,4L,9L,2L,9L,6L,6L,7L,8L,7L,2L,6L,3L,1L,6L,7L,7L,3L,1L,4L,7L,4L,2L,7L,6L,6L,9L,1L,3L,3L,4L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197727Inst : IEnumerable<long>
{
public static readonly long[] Value=A197727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197727.Bytes);
public long this[int i]=>Value[i];

public static A197727Inst Instance=new A197727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197728
{
public static readonly long[] Value={ 1L,1L,3L,7L,8L,2L,0L,4L,8L,9L,4L,9L,2L,1L,6L,4L,2L,1L,8L,0L,1L,6L,6L,4L,6L,0L,3L,3L,5L,6L,7L,3L,3L,9L,2L,9L,6L,2L,0L,7L,6L,3L,9L,5L,4L,8L,4L,6L,0L,7L,9L,6L,4L,9L,5L,0L,0L,3L,4L,8L,2L,3L,2L,0L,6L,7L,3L,8L,2L,2L,2L,0L,5L,6L,5L,1L,4L,3L,6L,0L,6L,4L,4L,8L,0L,9L,4L,9L,7L,6L,1L,0L,2L,3L,0L,3L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197728Inst : IEnumerable<long>
{
public static readonly long[] Value=A197728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197728.Bytes);
public long this[int i]=>Value[i];

public static A197728Inst Instance=new A197728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197729
{
public static readonly long[] Value={ 1L,8L,3L,3L,0L,4L,6L,4L,1L,1L,0L,5L,4L,9L,7L,1L,8L,6L,8L,1L,4L,1L,7L,8L,6L,1L,6L,3L,8L,6L,1L,9L,0L,6L,5L,8L,5L,2L,1L,2L,2L,6L,7L,8L,9L,8L,8L,6L,8L,2L,7L,8L,3L,8L,5L,6L,2L,6L,7L,5L,0L,3L,2L,5L,1L,2L,7L,3L,9L,4L,5L,0L,1L,8L,0L,8L,9L,4L,7L,5L,1L,5L,9L,7L,2L,1L,1L,4L,1L,5L,0L,3L,7L,0L,0L,2L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197729Inst : IEnumerable<long>
{
public static readonly long[] Value=A197729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197729.Bytes);
public long this[int i]=>Value[i];

public static A197729Inst Instance=new A197729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197730
{
public static readonly long[] Value={ 1L,3L,1L,9L,7L,0L,2L,5L,3L,9L,4L,6L,5L,3L,2L,7L,8L,7L,2L,2L,6L,8L,5L,6L,4L,1L,2L,3L,5L,4L,1L,1L,4L,0L,1L,5L,1L,3L,9L,7L,5L,6L,2L,3L,2L,9L,7L,1L,3L,0L,6L,7L,7L,2L,3L,7L,9L,7L,8L,4L,9L,6L,0L,4L,3L,7L,7L,5L,2L,0L,6L,3L,9L,2L,5L,1L,7L,0L,9L,2L,9L,3L,0L,6L,0L,5L,5L,1L,3L,7L,3L,8L,1L,0L,7L,7L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197730Inst : IEnumerable<long>
{
public static readonly long[] Value=A197730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197730.Bytes);
public long this[int i]=>Value[i];

public static A197730Inst Instance=new A197730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197731
{
public static readonly long[] Value={ 4L,6L,3L,1L,4L,4L,1L,5L,8L,8L,7L,5L,4L,1L,9L,4L,4L,3L,2L,1L,2L,5L,7L,8L,2L,2L,9L,1L,0L,2L,2L,6L,2L,4L,6L,1L,7L,8L,6L,1L,0L,8L,8L,7L,6L,3L,3L,7L,3L,1L,0L,5L,0L,4L,5L,6L,7L,7L,6L,8L,4L,9L,5L,9L,8L,4L,8L,1L,9L,4L,5L,9L,9L,4L,8L,1L,1L,8L,4L,6L,5L,5L,1L,3L,2L,3L,6L,9L,1L,3L,4L,5L,8L,3L,3L,1L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197731Inst : IEnumerable<long>
{
public static readonly long[] Value=A197731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197731.Bytes);
public long this[int i]=>Value[i];

public static A197731Inst Instance=new A197731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197732
{
public static readonly long[] Value={ 8L,6L,2L,6L,9L,7L,4L,3L,8L,3L,0L,1L,5L,8L,7L,0L,2L,8L,8L,5L,3L,5L,8L,7L,6L,7L,4L,2L,9L,1L,3L,5L,0L,6L,6L,4L,7L,9L,5L,9L,0L,6L,4L,7L,1L,1L,9L,4L,3L,4L,6L,3L,0L,5L,2L,1L,2L,6L,1L,6L,2L,8L,4L,1L,9L,9L,5L,2L,5L,8L,2L,3L,3L,5L,5L,4L,4L,6L,2L,1L,2L,1L,4L,6L,4L,4L,1L,4L,1L,4L,8L,0L,4L,3L,7L,1L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197732Inst : IEnumerable<long>
{
public static readonly long[] Value=A197732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197732.Bytes);
public long this[int i]=>Value[i];

public static A197732Inst Instance=new A197732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197733
{
public static readonly long[] Value={ 1L,5L,1L,7L,0L,9L,3L,9L,8L,5L,9L,8L,9L,5L,5L,2L,2L,9L,0L,6L,8L,8L,8L,6L,1L,3L,7L,8L,0L,8L,9L,7L,8L,5L,7L,2L,8L,2L,7L,6L,8L,5L,2L,7L,3L,1L,2L,8L,1L,0L,6L,1L,9L,9L,3L,3L,3L,7L,9L,7L,6L,4L,2L,7L,5L,6L,5L,0L,9L,6L,2L,7L,4L,2L,0L,1L,9L,1L,4L,7L,5L,2L,6L,4L,1L,2L,6L,6L,3L,4L,8L,0L,3L,0L,7L,1L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197733Inst : IEnumerable<long>
{
public static readonly long[] Value=A197733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197733.Bytes);
public long this[int i]=>Value[i];

public static A197733Inst Instance=new A197733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197734
{
public static readonly long[] Value={ 40L,46L,53L,61L,68L,72L,79L,85L,98L,113L,117L,121L,123L,130L,137L,146L,151L,155L,159L,164L,174L,178L,186L,190L,195L,200L,206L,212L,217L,218L,222L,225L,234L,235L,239L,243L,247L,253L,254L,256L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197734Inst : IEnumerable<long>
{
public static readonly long[] Value=A197734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197734.Bytes);
public long this[int i]=>Value[i];

public static A197734Inst Instance=new A197734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197735
{
public static readonly long[] Value={ 2L,2L,7L,5L,6L,4L,0L,9L,7L,8L,9L,8L,4L,3L,2L,8L,4L,3L,6L,0L,3L,3L,2L,9L,2L,0L,6L,7L,1L,3L,4L,6L,7L,8L,5L,9L,2L,4L,1L,5L,2L,7L,9L,0L,9L,6L,9L,2L,1L,5L,9L,2L,9L,9L,0L,0L,0L,6L,9L,6L,4L,6L,4L,1L,3L,4L,7L,6L,4L,4L,4L,1L,1L,3L,0L,2L,8L,7L,2L,1L,2L,8L,9L,6L,1L,8L,9L,9L,5L,2L,2L,0L,4L,6L,0L,6L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197735Inst : IEnumerable<long>
{
public static readonly long[] Value=A197735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197735.Bytes);
public long this[int i]=>Value[i];

public static A197735Inst Instance=new A197735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197736
{
public static readonly long[] Value={ 3L,0L,3L,4L,1L,8L,7L,9L,7L,1L,9L,7L,9L,1L,0L,4L,5L,8L,1L,3L,7L,7L,7L,2L,2L,7L,5L,6L,1L,7L,9L,5L,7L,1L,4L,5L,6L,5L,5L,3L,7L,0L,5L,4L,6L,2L,5L,6L,2L,1L,2L,3L,9L,8L,6L,6L,7L,5L,9L,5L,2L,8L,5L,5L,1L,3L,0L,1L,9L,2L,5L,4L,8L,4L,0L,3L,8L,2L,9L,5L,0L,5L,2L,8L,2L,5L,3L,2L,6L,9L,6L,0L,6L,1L,4L,2L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197736Inst : IEnumerable<long>
{
public static readonly long[] Value=A197736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197736.Bytes);
public long this[int i]=>Value[i];

public static A197736Inst Instance=new A197736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197737
{
public static readonly long[] Value={ 1L,2L,5L,1L,1L,5L,1L,8L,3L,5L,2L,2L,0L,7L,6L,4L,8L,1L,1L,5L,9L,2L,8L,7L,0L,0L,6L,8L,7L,8L,8L,1L,6L,1L,8L,5L,9L,9L,4L,5L,3L,5L,6L,1L,0L,8L,5L,8L,8L,9L,6L,8L,6L,3L,6L,2L,0L,1L,7L,8L,2L,8L,1L,2L,1L,0L,3L,6L,0L,1L,9L,1L,8L,2L,3L,8L,2L,1L,0L,9L,1L,0L,4L,1L,1L,2L,7L,3L,5L,7L,6L,5L,9L,4L,8L,6L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197737Inst : IEnumerable<long>
{
public static readonly long[] Value=A197737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197737.Bytes);
public long this[int i]=>Value[i];

public static A197737Inst Instance=new A197737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197738
{
public static readonly long[] Value={ 5L,5L,0L,0L,0L,9L,3L,4L,9L,9L,2L,7L,2L,6L,1L,5L,6L,6L,6L,6L,4L,9L,5L,3L,6L,1L,9L,4L,7L,1L,7L,2L,9L,2L,6L,1L,1L,6L,7L,2L,8L,5L,0L,9L,2L,4L,3L,5L,7L,9L,3L,7L,8L,4L,5L,7L,0L,9L,3L,9L,2L,2L,0L,4L,2L,5L,2L,6L,0L,4L,4L,5L,2L,5L,2L,4L,4L,5L,3L,3L,2L,8L,5L,3L,9L,2L,4L,4L,5L,4L,3L,1L,6L,4L,9L,6L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197738Inst : IEnumerable<long>
{
public static readonly long[] Value=A197738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197738.Bytes);
public long this[int i]=>Value[i];

public static A197738Inst Instance=new A197738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197739
{
public static readonly long[] Value={ 4L,7L,7L,6L,5L,8L,3L,0L,9L,0L,6L,2L,2L,5L,4L,6L,3L,9L,0L,8L,1L,9L,2L,8L,5L,5L,1L,2L,5L,7L,8L,7L,8L,8L,7L,7L,1L,2L,1L,7L,0L,7L,3L,4L,7L,5L,0L,5L,0L,0L,2L,7L,4L,5L,4L,7L,9L,8L,4L,9L,0L,6L,4L,6L,6L,0L,9L,5L,6L,0L,2L,2L,9L,5L,1L,9L,8L,8L,2L,2L,7L,6L,9L,3L,6L,9L,5L,8L,0L,1L,2L,9L,2L,8L,1L,4L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197739Inst : IEnumerable<long>
{
public static readonly long[] Value=A197739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197739.Bytes);
public long this[int i]=>Value[i];

public static A197739Inst Instance=new A197739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197740
{
public static readonly long[] Value={ 1L,2L,23L,359L,14055L,1201128L,242811875L,111519014903L,116476823660735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197740Inst : IEnumerable<long>
{
public static readonly long[] Value=A197740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197740.Bytes);
public long this[int i]=>Value[i];

public static A197740Inst Instance=new A197740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197741
{
public static readonly long[] Value={ 1L,5L,20L,179L,3353L,108281L,6601649L,818828659L,196362508518L,91040908551719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197741Inst : IEnumerable<long>
{
public static readonly long[] Value=A197741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197741.Bytes);
public long this[int i]=>Value[i];

public static A197741Inst Instance=new A197741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197742
{
public static readonly long[] Value={ 1L,1L,19L,277L,8113L,584747L,84584638L,27156929082L,18818051940232L,28191505077956117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197742Inst : IEnumerable<long>
{
public static readonly long[] Value=A197742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197742.Bytes);
public long this[int i]=>Value[i];

public static A197742Inst Instance=new A197742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197743
{
public static readonly BigInteger[] Value={ 0L,2L,20L,600L,70048L,34265920L,69135737856L,563921434969088L,BigInteger.Parse("18455775305195147264"),BigInteger.Parse("2418183926567027902291968"),BigInteger.Parse("1267698967252460350153517105152") };
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
public class A197743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197743Inst Instance=new A197743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197744
{
public static readonly long[] Value={ 1L,7L,66L,1317L,115795L,26488736L,16946352492L,30667098889607L,150836015759040225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197744Inst : IEnumerable<long>
{
public static readonly long[] Value=A197744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197744.Bytes);
public long this[int i]=>Value[i];

public static A197744Inst Instance=new A197744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197745
{
public static readonly long[] Value={ 2L,12L,66L,212L,921L,4086L,17332L,75122L,326124L,1408419L,6097753L,26404858L,114255411L,494519798L,2140532037L,9264510866L,40098753497L,173557720814L,751196491106L,3251349837567L,14072600064116L,60909443628883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197745Inst : IEnumerable<long>
{
public static readonly long[] Value=A197745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197745.Bytes);
public long this[int i]=>Value[i];

public static A197745Inst Instance=new A197745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197746
{
public static readonly long[] Value={ 3L,31L,212L,1317L,9499L,64832L,462515L,3316363L,23465652L,167021811L,1187571067L,8438773594L,60016633869L,426656318067L,3033239021542L,21565974491771L,153321389406967L,1090053687664854L,7749841908849879L,55097853719155295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197746Inst : IEnumerable<long>
{
public static readonly long[] Value=A197746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197746.Bytes);
public long this[int i]=>Value[i];

public static A197746Inst Instance=new A197746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197747
{
public static readonly long[] Value={ 5L,79L,921L,9499L,115795L,1345639L,15943658L,189654699L,2233388582L,26384576019L,311889887397L,3684879253441L,43551918669270L,514650532034112L,6081348725134877L,71864666895246523L,849224348337144245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197747Inst : IEnumerable<long>
{
public static readonly long[] Value=A197747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197747.Bytes);
public long this[int i]=>Value[i];

public static A197747Inst Instance=new A197747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197748
{
public static readonly BigInteger[] Value={ 8L,186L,4086L,64832L,1345639L,26488736L,517762136L,10253557106L,201303354308L,3960281174841L,78026833052921L,1535648544087160L,30232523451117831L,595202431920865248L,11716746352661448795UL,BigInteger.Parse("230663246714597008476") };
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
public class A197748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197748Inst Instance=new A197748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197749
{
public static readonly BigInteger[] Value={ 13L,465L,17332L,462515L,15943658L,517762136L,16946352492L,558436739769L,18226535390462L,597638865062474L,19604855669620153L,642346166847903042L,BigInteger.Parse("21058400260743006736"),BigInteger.Parse("690290048778192927506"),BigInteger.Parse("22625839121192679890893") };
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
public class A197749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197749Inst Instance=new A197749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197750
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,12L,12L,3L,5L,31L,66L,31L,5L,8L,79L,212L,212L,79L,8L,13L,186L,921L,1317L,921L,186L,13L,21L,465L,4086L,9499L,9499L,4086L,465L,21L,34L,1131L,17332L,64832L,115795L,64832L,17332L,1131L,34L,55L,2776L,75122L,462515L,1345639L,1345639L,462515L,75122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197750Inst : IEnumerable<long>
{
public static readonly long[] Value=A197750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197750.Bytes);
public long this[int i]=>Value[i];

public static A197750Inst Instance=new A197750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197751
{
public static readonly long[] Value={ 1L,1L,10L,67L,884L,19670L,1109494L,102276730L,16849486788L,5455873268965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197751Inst : IEnumerable<long>
{
public static readonly long[] Value=A197751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197751.Bytes);
public long this[int i]=>Value[i];

public static A197751Inst Instance=new A197751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197752
{
public static readonly long[] Value={ 1L,4L,13L,82L,973L,13261L,309663L,11566445L,631393531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197752Inst : IEnumerable<long>
{
public static readonly long[] Value=A197752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197752.Bytes);
public long this[int i]=>Value[i];

public static A197752Inst Instance=new A197752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197753
{
public static readonly long[] Value={ 1L,4L,15L,154L,2560L,77908L,4327313L,430599055L,75914929553L,23997418533210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197753Inst : IEnumerable<long>
{
public static readonly long[] Value=A197753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197753.Bytes);
public long this[int i]=>Value[i];

public static A197753Inst Instance=new A197753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197754
{
public static readonly long[] Value={ 1L,1L,7L,46L,620L,15146L,684630L,56031069L,8451164309L,2311439501298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197754Inst : IEnumerable<long>
{
public static readonly long[] Value=A197754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197754.Bytes);
public long this[int i]=>Value[i];

public static A197754Inst Instance=new A197754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197755
{
public static readonly long[] Value={ 8L,9L,3L,7L,2L,7L,2L,2L,6L,6L,2L,6L,7L,2L,1L,3L,6L,9L,1L,7L,3L,7L,4L,6L,4L,1L,5L,4L,7L,4L,9L,9L,3L,8L,0L,8L,2L,9L,4L,2L,2L,6L,9L,6L,9L,3L,0L,2L,3L,2L,6L,0L,2L,5L,9L,8L,0L,9L,0L,5L,5L,0L,6L,5L,0L,5L,5L,9L,7L,1L,7L,2L,1L,5L,4L,2L,1L,2L,1L,2L,6L,2L,4L,6L,4L,3L,7L,1L,2L,9L,1L,3L,7L,7L,4L,8L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197755Inst : IEnumerable<long>
{
public static readonly long[] Value=A197755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197755.Bytes);
public long this[int i]=>Value[i];

public static A197755Inst Instance=new A197755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197756
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,10L,7L,12L,14L,11L,16L,18L,9L,20L,22L,24L,13L,26L,28L,30L,32L,15L,34L,36L,101L,38L,40L,42L,44L,46L,17L,48L,50L,52L,54L,56L,58L,19L,60L,62L,64L,66L,103L,68L,70L,72L,74L,76L,78L,80L,21L,82L,84L,86L,88L,90L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197756Inst : IEnumerable<long>
{
public static readonly long[] Value=A197756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197756.Bytes);
public long this[int i]=>Value[i];

public static A197756Inst Instance=new A197756Inst();

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