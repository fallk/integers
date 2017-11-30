using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275493
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,3L,6L,8L,9L,10L,14L,16L,20L,24L,29L,33L,46L,55L,61L,79L,87L,103L,128L,152L,173L,234L,266L,313L,403L,483L,561L,756L,842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275493Inst : IEnumerable<long>
{
public static readonly long[] Value=A275493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275493.Bytes);
public long this[int i]=>Value[i];

public static A275493Inst Instance=new A275493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275494
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,3L,2L,1L,1L,4L,2L,4L,4L,5L,4L,13L,9L,6L,18L,8L,16L,25L,24L,21L,61L,32L,47L,90L,80L,78L,195L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275494Inst : IEnumerable<long>
{
public static readonly long[] Value=A275494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275494.Bytes);
public long this[int i]=>Value[i];

public static A275494Inst Instance=new A275494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275495
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,5L,4L,6L,7L,8L,7L,8L,9L,12L,10L,11L,12L,13L,12L,15L,16L,17L,14L,16L,17L,20L,19L,20L,21L,22L,19L,22L,23L,26L,24L,25L,26L,29L,26L,27L,28L,29L,28L,33L,34L,35L,30L,32L,33L,36L,35L,36L,37L,40L,37L,40L,41L,42L,39L,40L,41L,46L,42L,45L,46L,47L,46L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275495Inst : IEnumerable<long>
{
public static readonly long[] Value=A275495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275495.Bytes);
public long this[int i]=>Value[i];

public static A275495Inst Instance=new A275495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275496
{
public static readonly long[] Value={ 0L,1L,36L,153L,528L,1225L,2628L,4753L,8256L,13041L,20100L,29161L,41616L,56953L,77028L,101025L,131328L,166753L,210276L,260281L,320400L,388521L,468996L,559153L,664128L,780625L,914628L,1062153L,1230096L,1413721L,1620900L,1846081L,2098176L,2370753L,2673828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275496Inst : IEnumerable<long>
{
public static readonly long[] Value=A275496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275496.Bytes);
public long this[int i]=>Value[i];

public static A275496Inst Instance=new A275496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275497
{
public static readonly long[] Value={ 1L,9L,80L,656L,4180L,68080L,1643372L,58423188L,3045734096L,235680645520L,26923774835716L,4558306996574952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275497Inst : IEnumerable<long>
{
public static readonly long[] Value=A275497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275497.Bytes);
public long this[int i]=>Value[i];

public static A275497Inst Instance=new A275497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275498
{
public static readonly long[] Value={ 2L,9L,16L,28L,56L,104L,200L,380L,724L,1380L,2628L,5008L,9540L,18176L,34628L,65972L,125688L,239456L,456204L,869144L,1655864L,3154696L,6010220L,11450468L,21815044L,41561284L,79181152L,150853252L,287400512L,547545732L,1043165604L,1987403816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275498Inst : IEnumerable<long>
{
public static readonly long[] Value=A275498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275498.Bytes);
public long this[int i]=>Value[i];

public static A275498Inst Instance=new A275498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275499
{
public static readonly long[] Value={ 5L,54L,80L,136L,232L,516L,1168L,2660L,6024L,13716L,31168L,70868L,161176L,366452L,833360L,1894996L,4309160L,9799012L,22282576L,50670228L,115222840L,262014052L,595814224L,1354867540L,3080938312L,7005983220L,15931445856L,36227745252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275499Inst : IEnumerable<long>
{
public static readonly long[] Value=A275499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275499.Bytes);
public long this[int i]=>Value[i];

public static A275499Inst Instance=new A275499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275500
{
public static readonly long[] Value={ 14L,324L,400L,656L,988L,2628L,7140L,19368L,52864L,144228L,394248L,1077956L,2947432L,8062396L,22050256L,60314412L,164976924L,451256880L,1234335036L,3376282048L,9235192524L,25261198432L,69097304872L,189003117812L,516983415672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275500Inst : IEnumerable<long>
{
public static readonly long[] Value=A275500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275500.Bytes);
public long this[int i]=>Value[i];

public static A275500Inst Instance=new A275500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275501
{
public static readonly long[] Value={ 41L,1944L,2000L,3168L,4180L,13384L,43780L,143784L,470352L,1549756L,5114352L,16851668L,55718276L,183999596L,607959912L,2009783684L,6640967048L,21951863104L,72556631720L,239811612380L,792682822452L,2620034132264L,8660100023060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275501Inst : IEnumerable<long>
{
public static readonly long[] Value=A275501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275501.Bytes);
public long this[int i]=>Value[i];

public static A275501Inst Instance=new A275501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275502
{
public static readonly long[] Value={ 122L,11664L,10000L,15296L,17712L,68080L,268152L,1063756L,4220952L,16808164L,66958736L,267555284L,1069442584L,4276248392L,17124441536L,68526589584L,274440666248L,1099065057188L,4401177662772L,17628768823132L,70603317991512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275502Inst : IEnumerable<long>
{
public static readonly long[] Value=A275502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275502.Bytes);
public long this[int i]=>Value[i];

public static A275502Inst Instance=new A275502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275503
{
public static readonly long[] Value={ 365L,69984L,50000L,73856L,75024L,346528L,1643372L,7886280L,37846556L,182923008L,884628720L,4276847052L,20741192940L,100647222904L,488252256740L,2372706557348L,11527428408920L,56008813182076L,272332971514256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275503Inst : IEnumerable<long>
{
public static readonly long[] Value=A275503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275503.Bytes);
public long this[int i]=>Value[i];

public static A275503Inst Instance=new A275503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275504
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,3L,14L,54L,16L,6L,41L,324L,80L,28L,12L,122L,1944L,400L,136L,56L,24L,365L,11664L,2000L,656L,232L,104L,48L,1094L,69984L,10000L,3168L,988L,516L,200L,96L,3281L,419904L,50000L,15296L,4180L,2628L,1168L,380L,192L,9842L,2519424L,250000L,73856L,17712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275504Inst : IEnumerable<long>
{
public static readonly long[] Value=A275504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275504.Bytes);
public long this[int i]=>Value[i];

public static A275504Inst Instance=new A275504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275505
{
public static readonly long[] Value={ 12L,56L,232L,988L,4180L,17712L,75024L,317812L,1346268L,5702888L,24157816L,102334156L,433494436L,1836311904L,7778742048L,32951280100L,139583862444L,591286729880L,2504730781960L,10610209857724L,44945570212852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275505Inst : IEnumerable<long>
{
public static readonly long[] Value=A275505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275505.Bytes);
public long this[int i]=>Value[i];

public static A275505Inst Instance=new A275505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275506
{
public static readonly long[] Value={ 24L,104L,516L,2628L,13384L,68080L,346528L,1763408L,8974288L,45670736L,232422608L,1182818704L,6019467984L,30633598480L,155897059664L,793373760912L,4037548401360L,20547436657936L,104567700792400L,532154167518352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275506Inst : IEnumerable<long>
{
public static readonly long[] Value=A275506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275506.Bytes);
public long this[int i]=>Value[i];

public static A275506Inst Instance=new A275506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275507
{
public static readonly long[] Value={ 48L,200L,1168L,7140L,43780L,268152L,1643372L,10069540L,61703488L,378096660L,2316847540L,14196847960L,86993404476L,533065762516L,3266444015616L,20015648328132L,122649024958372L,751551142797496L,4605247533843404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275507Inst : IEnumerable<long>
{
public static readonly long[] Value=A275507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275507.Bytes);
public long this[int i]=>Value[i];

public static A275507Inst Instance=new A275507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275636
{
public static readonly long[] Value={ 0L,2L,16L,130L,1120L,9922L,88816L,797890L,7176640L,64576642L,581150416L,5230235650L,47071766560L,423644836162L,3812800336816L,34315193465410L,308836712490880L,2779530326324482L,25015772678640016L,225141953332919170L,2026277577671749600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275636Inst : IEnumerable<long>
{
public static readonly long[] Value=A275636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275636.Bytes);
public long this[int i]=>Value[i];

public static A275636Inst Instance=new A275636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275637
{
public static readonly BigInteger[] Value={ 0L,0L,24L,3588L,336336L,28456296L,2337415080L,190203890604L,15430065218592L,1250470878111312L,101305299883043256L,8206192556032342740L,BigInteger.Parse("664714105019032509168"),BigInteger.Parse("53842180220318324555448"),BigInteger.Parse("4361225716102504132538952"),BigInteger.Parse("353259529197097010875926396"),BigInteger.Parse("28614028512169065293302438464") };
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
public class A275637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275637Inst Instance=new A275637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275638
{
public static readonly long[] Value={ 1L,-3L,4L,-3L,2L,-3L,5L,-6L,6L,-6L,6L,-6L,7L,-9L,10L,-9L,8L,-9L,11L,-12L,12L,-12L,12L,-12L,13L,-15L,16L,-15L,14L,-15L,17L,-18L,18L,-18L,18L,-18L,19L,-21L,22L,-21L,20L,-21L,23L,-24L,24L,-24L,24L,-24L,25L,-27L,28L,-27L,26L,-27L,29L,-30L,30L,-30L,30L,-30L,31L,-33L,34L,-33L,32L,-33L,35L,-36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275638Inst : IEnumerable<long>
{
public static readonly long[] Value=A275638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275638.Bytes);
public long this[int i]=>Value[i];

public static A275638Inst Instance=new A275638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275639
{
public static readonly long[] Value={ 1L,-4L,7L,-7L,5L,-4L,4L,-4L,5L,-7L,8L,-8L,9L,-11L,12L,-11L,9L,-8L,9L,-11L,13L,-15L,16L,-15L,14L,-15L,16L,-15L,14L,-15L,17L,-19L,21L,-22L,21L,-19L,18L,-19L,21L,-22L,22L,-23L,25L,-26L,26L,-26L,25L,-23L,23L,-26L,29L,-30L,30L,-30L,30L,-30L,30L,-30L,30L,-30L,31L,-34L,37L,-37L,35L,-34L,34L,-34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275639Inst : IEnumerable<long>
{
public static readonly long[] Value=A275639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275639.Bytes);
public long this[int i]=>Value[i];

public static A275639Inst Instance=new A275639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275640
{
public static readonly long[] Value={ 1L,-5L,11L,-14L,12L,-9L,9L,-13L,20L,-26L,27L,-25L,26L,-33L,43L,-49L,47L,-42L,43L,-53L,67L,-77L,78L,-73L,72L,-82L,98L,-108L,107L,-102L,104L,-118L,138L,-151L,150L,-142L,141L,-155L,178L,-194L,194L,-187L,189L,-206L,230L,-246L,245L,-235L,235L,-255L,285L,-305L,305L,-295L,295L,-315L,345L,-365L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275640Inst : IEnumerable<long>
{
public static readonly long[] Value=A275640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275640.Bytes);
public long this[int i]=>Value[i];

public static A275640Inst Instance=new A275640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275641
{
public static readonly long[] Value={ 1L,-6L,16L,-25L,26L,-21L,18L,-21L,27L,-30L,28L,-26L,30L,-41L,55L,-65L,66L,-61L,59L,-66L,79L,-89L,90L,-85L,84L,-95L,114L,-127L,126L,-119L,121L,-138L,161L,-175L,174L,-166L,164L,-175L,195L,-211L,213L,-207L,210L,-231L,261L,-281L,280L,-267L,263L,-280L,309L,-329L,329L,-320L,323L,-347L,380L,-401L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275641Inst : IEnumerable<long>
{
public static readonly long[] Value=A275641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275641.Bytes);
public long this[int i]=>Value[i];

public static A275641Inst Instance=new A275641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275642
{
public static readonly long[] Value={ 1L,-7L,22L,-41L,51L,-47L,39L,-39L,49L,-64L,80L,-95L,107L,-118L,135L,-159L,180L,-191L,200L,-220L,252L,-286L,314L,-334L,349L,-370L,409L,-461L,505L,-531L,554L,-593L,648L,-706L,758L,-801L,835L,-870L,924L,-999L,1072L,-1126L,1175L,-1242L,1327L,-1412L,1485L,-1546L,1602L,-1669L,1764L,-1880L,1985L,-2061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275642Inst : IEnumerable<long>
{
public static readonly long[] Value=A275642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275642.Bytes);
public long this[int i]=>Value[i];

public static A275642Inst Instance=new A275642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275643
{
public static readonly long[] Value={ 1L,-11L,56L,-175L,376L,-592L,719L,-722L,678L,-696L,815L,-988L,1143L,-1254L,1374L,-1602L,1986L,-2440L,2794L,-2971L,3095L,-3378L,3906L,-4562L,5147L,-5568L,5937L,-6487L,7336L,-8317L,9111L,-9601L,10048L,-10852L,12146L,-13656L,14954L,-15853L,16601L,-17692L,19402L,-21465L,23298L,-24631L,25843L,-27577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275643Inst : IEnumerable<long>
{
public static readonly long[] Value=A275643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275643.Bytes);
public long this[int i]=>Value[i];

public static A275643Inst Instance=new A275643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275644
{
public static readonly long[] Value={ 1L,-15L,106L,-469L,1457L,-3381L,6099L,-8829L,10624L,-11208L,11274L,-11858L,13447L,-15709L,18001L,-20090L,22420L,-25667L,29965L,-34627L,38835L,-42687L,47352L,-53944L,62270L,-70875L,78399L,-84913L,91988L,-101370L,113336L,-126336L,138584L,-150174L,163347L,-180341L,200990L,-222634L,242515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275644Inst : IEnumerable<long>
{
public static readonly long[] Value=A275644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275644.Bytes);
public long this[int i]=>Value[i];

public static A275644Inst Instance=new A275644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275645
{
public static readonly long[] Value={ 1L,5L,7L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275645Inst : IEnumerable<long>
{
public static readonly long[] Value=A275645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275645.Bytes);
public long this[int i]=>Value[i];

public static A275645Inst Instance=new A275645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275646
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275646Inst : IEnumerable<long>
{
public static readonly long[] Value=A275646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275646.Bytes);
public long this[int i]=>Value[i];

public static A275646Inst Instance=new A275646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275647
{
public static readonly long[] Value={ 1L,1L,9L,2L,6L,8L,6L,6L,4L,6L,8L,0L,7L,1L,6L,0L,9L,3L,7L,9L,6L,5L,8L,7L,1L,8L,0L,1L,8L,1L,3L,7L,7L,7L,2L,5L,5L,0L,4L,5L,7L,1L,8L,5L,5L,7L,9L,6L,6L,9L,0L,6L,0L,1L,5L,9L,9L,9L,1L,3L,9L,2L,9L,9L,0L,1L,8L,8L,4L,2L,4L,4L,3L,0L,3L,9L,2L,8L,9L,9L,9L,9L,3L,8L,4L,6L,7L,1L,3L,5L,6L,2L,6L,4L,8L,5L,1L,8L,4L,7L,0L,8L,1L,1L,9L,8L,0L,9L,1L,2L,9L,5L,4L,1L,6L,5L,5L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275647Inst : IEnumerable<long>
{
public static readonly long[] Value=A275647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275647.Bytes);
public long this[int i]=>Value[i];

public static A275647Inst Instance=new A275647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275648
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,3L,3L,1L,2L,4L,1L,1L,2L,3L,3L,3L,3L,2L,2L,1L,2L,4L,3L,3L,5L,3L,2L,2L,1L,4L,5L,2L,5L,4L,1L,2L,4L,4L,3L,3L,2L,5L,2L,1L,2L,6L,4L,4L,7L,4L,5L,3L,2L,4L,5L,2L,4L,5L,2L,4L,2L,6L,4L,4L,4L,4L,4L,1L,4L,7L,4L,4L,7L,1L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275648Inst : IEnumerable<long>
{
public static readonly long[] Value=A275648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275648.Bytes);
public long this[int i]=>Value[i];

public static A275648Inst Instance=new A275648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275649
{
public static readonly long[] Value={ 2L,14L,112L,997L,8982L,82305L,764092L,7159654L,67581778L,641696858L,6122456540L,58649349611L,563729377405L,5434188304040L,52515178669973L,508607849995010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275649Inst : IEnumerable<long>
{
public static readonly long[] Value=A275649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275649.Bytes);
public long this[int i]=>Value[i];

public static A275649Inst Instance=new A275649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275650
{
public static readonly long[] Value={ 4L,28L,214L,1803L,15830L,142844L,1313047L,12220699L,114790260L,1085885280L,10330026070L,98719755796L,947012920362L,9113815047794L,87950106960771L,850754904051968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275650Inst : IEnumerable<long>
{
public static readonly long[] Value=A275650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275650.Bytes);
public long this[int i]=>Value[i];

public static A275650Inst Instance=new A275650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275651
{
public static readonly BigInteger[] Value={ 1L,1L,13L,389L,21785L,1960649L,258805669L,47102631757L,11304631621681L,3459217276234385L,1314502564969066301L,BigInteger.Parse("607300185015708631061"),BigInteger.Parse("335229702128671164345673") };
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
public class A275651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275651Inst Instance=new A275651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275732
{
public static readonly long[] Value={ 1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,7L,14L,21L,42L,7L,14L,35L,70L,105L,210L,35L,70L,7L,14L,21L,42L,7L,14L,7L,14L,21L,42L,7L,14L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275732Inst : IEnumerable<long>
{
public static readonly long[] Value=A275732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275732.Bytes);
public long this[int i]=>Value[i];

public static A275732Inst Instance=new A275732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275733
{
public static readonly long[] Value={ 1L,2L,3L,6L,3L,6L,5L,10L,15L,30L,15L,30L,5L,10L,15L,30L,15L,30L,5L,10L,15L,30L,15L,30L,7L,14L,21L,42L,21L,42L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,7L,14L,21L,42L,21L,42L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,7L,14L,21L,42L,21L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275733Inst : IEnumerable<long>
{
public static readonly long[] Value=A275733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275733.Bytes);
public long this[int i]=>Value[i];

public static A275733Inst Instance=new A275733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275734
{
public static readonly long[] Value={ 1L,2L,3L,6L,2L,4L,5L,10L,15L,30L,10L,20L,3L,6L,9L,18L,6L,12L,2L,4L,6L,12L,4L,8L,7L,14L,21L,42L,14L,28L,35L,70L,105L,210L,70L,140L,21L,42L,63L,126L,42L,84L,14L,28L,42L,84L,28L,56L,5L,10L,15L,30L,10L,20L,25L,50L,75L,150L,50L,100L,15L,30L,45L,90L,30L,60L,10L,20L,30L,60L,20L,40L,3L,6L,9L,18L,6L,12L,15L,30L,45L,90L,30L,60L,9L,18L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275734Inst : IEnumerable<long>
{
public static readonly long[] Value=A275734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275734.Bytes);
public long this[int i]=>Value[i];

public static A275734Inst Instance=new A275734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275735
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,4L,4L,8L,6L,12L,3L,6L,6L,12L,9L,18L,5L,10L,10L,20L,15L,30L,2L,4L,4L,8L,6L,12L,4L,8L,8L,16L,12L,24L,6L,12L,12L,24L,18L,36L,10L,20L,20L,40L,30L,60L,3L,6L,6L,12L,9L,18L,6L,12L,12L,24L,18L,36L,9L,18L,18L,36L,27L,54L,15L,30L,30L,60L,45L,90L,5L,10L,10L,20L,15L,30L,10L,20L,20L,40L,30L,60L,15L,30L,30L,60L,45L,90L,25L,50L,50L,100L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275735Inst : IEnumerable<long>
{
public static readonly long[] Value=A275735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275735.Bytes);
public long this[int i]=>Value[i];

public static A275735Inst Instance=new A275735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275736
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,8L,9L,10L,11L,8L,9L,8L,9L,10L,11L,8L,9L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275736Inst : IEnumerable<long>
{
public static readonly long[] Value=A275736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275736.Bytes);
public long this[int i]=>Value[i];

public static A275736Inst Instance=new A275736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275737
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275737Inst : IEnumerable<long>
{
public static readonly long[] Value=A275737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275737.Bytes);
public long this[int i]=>Value[i];

public static A275737Inst Instance=new A275737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275738
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,1L,3L,3L,1L,3L,4L,1L,1L,2L,3L,3L,2L,5L,5L,1L,1L,1L,5L,3L,3L,5L,3L,2L,2L,1L,2L,4L,2L,7L,7L,1L,2L,3L,5L,3L,2L,3L,8L,3L,1L,3L,4L,4L,3L,9L,6L,3L,3L,1L,4L,4L,1L,6L,5L,2L,3L,2L,5L,3L,3L,5L,8L,3L,1L,3L,7L,4L,4L,8L,4L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275738Inst : IEnumerable<long>
{
public static readonly long[] Value=A275738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275738.Bytes);
public long this[int i]=>Value[i];

public static A275738Inst Instance=new A275738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275739
{
public static readonly long[] Value={ 617L,1723L,2731L,3191L,6547L,11087L,13103L,21683L,21839L,47737L,49727L,49739L,51679L,52361L,60679L,63719L,117721L,133169L,145531L,232681L,275183L,281353L,306431L,341879L,373463L,607319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275739Inst : IEnumerable<long>
{
public static readonly long[] Value=A275739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275739.Bytes);
public long this[int i]=>Value[i];

public static A275739Inst Instance=new A275739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275740
{
public static readonly long[] Value={ 0L,2L,8L,21L,46L,83L,136L,210L,306L,426L,575L,758L,972L,1223L,1519L,1855L,2236L,2669L,3156L,3694L,4290L,4956L,5678L,6467L,7332L,8269L,9278L,10368L,11548L,12804L,14148L,15593L,17126L,18753L,20485L,22325L,24262L,26308L,28481L,30756L,33148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275740Inst : IEnumerable<long>
{
public static readonly long[] Value=A275740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275740.Bytes);
public long this[int i]=>Value[i];

public static A275740Inst Instance=new A275740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275741
{
public static readonly long[] Value={ 1L,3L,10L,6L,6L,17L,15L,11L,25L,38L,9L,37L,47L,39L,86L,58L,107L,50L,101L,36L,98L,45L,123L,92L,170L,57L,80L,72L,158L,194L,194L,67L,78L,133L,120L,302L,144L,158L,128L,97L,91L,303L,76L,191L,139L,178L,302L,117L,242L,179L,335L,390L,362L,197L,290L,314L,327L,227L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275741Inst : IEnumerable<long>
{
public static readonly long[] Value=A275741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275741.Bytes);
public long this[int i]=>Value[i];

public static A275741Inst Instance=new A275741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275742
{
public static readonly long[] Value={ 3L,4L,4L,7L,15L,15L,15L,15L,23L,31L,31L,47L,31L,39L,39L,63L,63L,63L,55L,79L,63L,79L,71L,95L,95L,95L,119L,119L,95L,111L,135L,143L,143L,143L,127L,159L,143L,167L,167L,191L,159L,191L,175L,191L,191L,207L,191L,215L,247L,223L,239L,255L,255L,239L,239L,247L,255L,255L,271L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275742Inst : IEnumerable<long>
{
public static readonly long[] Value=A275742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275742.Bytes);
public long this[int i]=>Value[i];

public static A275742Inst Instance=new A275742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275743
{
public static readonly long[] Value={ 1L,12L,83L,600L,3058L,18222L,130411L,783480L,3418488L,24857930L,181308931L,610675758L,6529545751L,18840405540L,102444103996L,95639401274L,3188347929974L,27288773879397L,96923972375603L,702926766993950L,2980668206142664L,20046633698159181L,88137290213079355L,502113072640777785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275743Inst : IEnumerable<long>
{
public static readonly long[] Value=A275743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275743.Bytes);
public long this[int i]=>Value[i];

public static A275743Inst Instance=new A275743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275744
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,0L,5L,1L,0L,0L,19L,2L,0L,0L,0L,85L,8L,1L,0L,0L,0L,509L,29L,2L,0L,0L,0L,0L,4060L,138L,8L,1L,0L,0L,0L,0L,41301L,774L,33L,2L,0L,0L,0L,0L,0L,510489L,5693L,153L,8L,1L,0L,0L,0L,0L,0L,7319447L,53581L,861L,33L,2L,0L,0L,0L,0L,0L,0L,117940535L,626717L,6173L,158L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275744Inst : IEnumerable<long>
{
public static readonly long[] Value=A275744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275744.Bytes);
public long this[int i]=>Value[i];

public static A275744Inst Instance=new A275744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275745
{
public static readonly long[] Value={ -1L,-1L,1L,0L,-4L,-2L,2L,4L,0L,-2L,0L,-10L,10L,4L,8L,-10L,-4L,-2L,12L,-8L,10L,0L,12L,-6L,2L,6L,-16L,-12L,14L,2L,-8L,-12L,-6L,-4L,22L,-8L,14L,-4L,0L,-18L,20L,-10L,16L,2L,6L,-8L,20L,8L,-20L,6L,-6L,-16L,-14L,12L,18L,16L,14L,16L,6L,-6L,-12L,6L,28L,-24L,26L,-2L,12L,-14L,-28L,-2L,18L,-24L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275745Inst : IEnumerable<long>
{
public static readonly long[] Value=A275745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275745.Bytes);
public long this[int i]=>Value[i];

public static A275745Inst Instance=new A275745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275746
{
public static readonly ulong[] Value={ 3L,62L,840L,12350L,99912L,2358913L,12173587L,120900206L,1224812108L,20439317893L,130357794430L,1534358290778L,13544972574336L,142155007727976L,1648210755327790L,14816750258004918L,151900144117560355L,1525977077403654254L,16185530587326104490UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275746Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275746.Bytes);
public ulong this[int i]=>Value[i];

public static A275746Inst Instance=new A275746Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275747
{
public static readonly BigInteger[] Value={ 4L,114L,1595L,24195L,190463L,4613167L,23815950L,240951477L,2448240688L,40379465440L,258630935725L,3044619003271L,26232953378021L,264066033166293L,3218396161633945L,29248021240625765L,302064442857973298L,3027736057187540859L,BigInteger.Parse("32207709908667683204") };
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
public class A275747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275747Inst Instance=new A275747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276004
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,3L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276004Inst : IEnumerable<long>
{
public static readonly long[] Value=A276004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276004.Bytes);
public long this[int i]=>Value[i];

public static A276004Inst Instance=new A276004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276005
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,12L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,48L,49L,54L,55L,60L,66L,67L,72L,74L,76L,78L,84L,86L,88L,90L,92L,94L,96L,97L,98L,100L,101L,102L,103L,108L,110L,112L,114L,115L,116L,118L,119L,120L,121L,122L,124L,125L,126L,127L,132L,134L,136L,138L,139L,140L,142L,143L,240L,241L,242L,244L,245L,264L,265L,266L,268L,269L,288L,289L,312L,314L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276005Inst : IEnumerable<long>
{
public static readonly long[] Value=A276005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276005.Bytes);
public long this[int i]=>Value[i];

public static A276005Inst Instance=new A276005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276006
{
public static readonly long[] Value={ 3L,8L,9L,10L,11L,13L,15L,17L,21L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,56L,57L,58L,59L,61L,62L,63L,64L,65L,68L,69L,70L,71L,73L,75L,77L,79L,80L,81L,82L,83L,85L,87L,89L,91L,93L,95L,99L,104L,105L,106L,107L,109L,111L,113L,117L,123L,128L,129L,130L,131L,133L,135L,137L,141L,144L,145L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276006Inst : IEnumerable<long>
{
public static readonly long[] Value=A276006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276006.Bytes);
public long this[int i]=>Value[i];

public static A276006Inst Instance=new A276006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276007
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,3L,2L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,0L,2L,3L,2L,2L,0L,1L,1L,3L,1L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,3L,1L,2L,0L,2L,0L,3L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276007Inst : IEnumerable<long>
{
public static readonly long[] Value=A276007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276007.Bytes);
public long this[int i]=>Value[i];

public static A276007Inst Instance=new A276007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276008
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,6L,7L,8L,9L,8L,9L,6L,7L,8L,9L,8L,9L,6L,7L,8L,9L,8L,9L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276008Inst : IEnumerable<long>
{
public static readonly long[] Value=A276008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276008.Bytes);
public long this[int i]=>Value[i];

public static A276008Inst Instance=new A276008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276009
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,2L,6L,6L,6L,6L,8L,8L,12L,12L,12L,12L,14L,14L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,2L,6L,6L,6L,6L,8L,8L,12L,12L,12L,12L,14L,14L,24L,24L,24L,24L,26L,26L,24L,24L,24L,24L,26L,26L,30L,30L,30L,30L,32L,32L,36L,36L,36L,36L,38L,38L,48L,48L,48L,48L,50L,50L,48L,48L,48L,48L,50L,50L,54L,54L,54L,54L,56L,56L,60L,60L,60L,60L,62L,62L,72L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276009Inst : IEnumerable<long>
{
public static readonly long[] Value=A276009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276009.Bytes);
public long this[int i]=>Value[i];

public static A276009Inst Instance=new A276009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276010
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,4L,5L,6L,7L,5L,5L,2L,3L,2L,3L,3L,3L,1L,1L,3L,3L,1L,1L,8L,9L,10L,11L,9L,9L,12L,13L,14L,15L,13L,13L,10L,11L,10L,11L,11L,11L,9L,9L,11L,11L,9L,9L,4L,5L,6L,7L,5L,5L,4L,5L,6L,7L,5L,5L,6L,7L,6L,7L,7L,7L,5L,5L,7L,7L,5L,5L,2L,3L,2L,3L,3L,3L,6L,7L,6L,7L,7L,7L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,3L,3L,1L,1L,5L,5L,7L,7L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276010Inst : IEnumerable<long>
{
public static readonly long[] Value=A276010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276010.Bytes);
public long this[int i]=>Value[i];

public static A276010Inst Instance=new A276010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276011
{
public static readonly long[] Value={ 0L,3L,1L,2L,14L,17L,15L,16L,10L,13L,11L,12L,4L,5L,8L,9L,6L,7L,78L,81L,79L,80L,92L,95L,93L,94L,88L,91L,89L,90L,82L,83L,86L,87L,84L,85L,60L,63L,61L,62L,74L,77L,75L,76L,70L,73L,71L,72L,64L,65L,68L,69L,66L,67L,42L,45L,43L,44L,56L,59L,57L,58L,52L,55L,53L,54L,46L,47L,50L,51L,48L,49L,18L,19L,22L,23L,20L,21L,36L,37L,40L,41L,38L,39L,30L,31L,34L,35L,32L,33L,24L,25L,28L,29L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276011Inst : IEnumerable<long>
{
public static readonly long[] Value=A276011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276011.Bytes);
public long this[int i]=>Value[i];

public static A276011Inst Instance=new A276011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276012
{
public static readonly long[] Value={ 0L,2L,3L,1L,12L,13L,16L,17L,14L,15L,8L,10L,11L,9L,4L,6L,7L,5L,72L,73L,76L,77L,74L,75L,90L,91L,94L,95L,92L,93L,84L,85L,88L,89L,86L,87L,78L,79L,82L,83L,80L,81L,54L,56L,57L,55L,66L,67L,70L,71L,68L,69L,62L,64L,65L,63L,58L,60L,61L,59L,36L,38L,39L,37L,48L,49L,52L,53L,50L,51L,44L,46L,47L,45L,40L,42L,43L,41L,18L,20L,21L,19L,30L,31L,34L,35L,32L,33L,26L,28L,29L,27L,22L,24L,25L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276012Inst : IEnumerable<long>
{
public static readonly long[] Value=A276012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276012.Bytes);
public long this[int i]=>Value[i];

public static A276012Inst Instance=new A276012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276013
{
public static readonly BigInteger[] Value={ 1L,12L,864L,100800L,14112000L,2139830784L,338341183488L,54913641209856L,9080061146956800L,1523231914913280000L,BigInteger.Parse("258557709598427086848"),BigInteger.Parse("44324863067728222027776"),BigInteger.Parse("7663322563977594870300672"),BigInteger.Parse("1334677098876385703362560000"),BigInteger.Parse("233951210561895726160281600000") };
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
public class A276013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276013Inst Instance=new A276013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276014
{
public static readonly BigInteger[] Value={ 1L,72L,45360L,46569600L,59594535000L,86482063571904L,136141986298526208L,BigInteger.Parse("226888189910421811200"),BigInteger.Parse("394399917777684601926000"),BigInteger.Parse("708188604075430924446000000"),BigInteger.Parse("1304782547573305224852017990400"),BigInteger.Parse("2454776409299366206456800694732800"),BigInteger.Parse("4699106882676505497505898579906736000"),BigInteger.Parse("9127695522416954472516114289988092800000") };
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
public class A276014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276014Inst Instance=new A276014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276015
{
public static readonly BigInteger[] Value={ 1L,18L,1404L,158760L,21234150L,3126159036L,489778537248L,80153987120064L,13547671656870780L,2347445149320843000L,BigInteger.Parse("414851046001557525360"),BigInteger.Parse("74499573518808987538080"),BigInteger.Parse("13557818392046546526712440"),BigInteger.Parse("2495117936356342079352318000"),BigInteger.Parse("463604343771018075763879080000"),BigInteger.Parse("86854813070150110063356637257600") };
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
public class A276015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276015Inst Instance=new A276015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276016
{
public static readonly BigInteger[] Value={ 1L,18L,1620L,211680L,32744250L,5578048476L,1011486123648L,191622065057280L,37496545808513220L,7522455177633825000L,BigInteger.Parse("1539274868268143806800"),BigInteger.Parse("320076654200479057190400"),BigInteger.Parse("67449486609121784655852000"),BigInteger.Parse("14374016718897406159444968000") };
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
public class A276016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276016Inst Instance=new A276016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276017
{
public static readonly BigInteger[] Value={ 1L,18L,2160L,423360L,99792000L,25499650176L,6797581959168L,1860535606026240L,518890571236477440L,BigInteger.Parse("146835076503772800000"),BigInteger.Parse("42046646730013562757120"),BigInteger.Parse("12160617341681775057960960"),BigInteger.Parse("3547136319516173918512742400"),BigInteger.Parse("1042325945372157283978798694400"),BigInteger.Parse("308269259704090665806809006080000") };
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
public class A276017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276017Inst Instance=new A276017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276018
{
public static readonly BigInteger[] Value={ 1L,3L,36L,588L,11025L,223587L,4769856L,105423552L,2391796836L,55365667500L,1302200499600L,31026810250800L,747229013540100L,18158991471060300L,444709995209640000L,10963583748568324800UL,BigInteger.Parse("271862615765280179025"),BigInteger.Parse("6775869970094509098675"),BigInteger.Parse("169647707399403264840900"),BigInteger.Parse("4264689597367270438867500") };
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
public class A276018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276018Inst Instance=new A276018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276019
{
public static readonly BigInteger[] Value={ 1L,10L,230L,6500L,199750L,6366060L,204990300L,6539387400L,202432551750L,5897526329500L,151804596385780L,2807347223915000L,-15232296765302500L,-5584390420089725000L,BigInteger.Parse("-416025902106681525000"),BigInteger.Parse("-24002385182809425846000"),BigInteger.Parse("-1235898175219724085176250"),BigInteger.Parse("-59486502796252242452122500"),BigInteger.Parse("-2731496764897242177292037500"),BigInteger.Parse("-120874274801920384164027025000"),BigInteger.Parse("-5181210157044172846922944311500") };
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
public class A276019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276019Inst Instance=new A276019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276084
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276084Inst : IEnumerable<long>
{
public static readonly long[] Value=A276084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276084.Bytes);
public long this[int i]=>Value[i];

public static A276084Inst Instance=new A276084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276085
{
public static readonly BigInteger[] Value={ 0L,1L,2L,2L,6L,3L,30L,3L,4L,7L,210L,4L,2310L,31L,8L,4L,30030L,5L,510510L,8L,32L,211L,9699690L,5L,12L,2311L,6L,32L,223092870L,9L,6469693230L,5L,212L,30031L,36L,6L,200560490130L,510511L,2312L,9L,7420738134810L,33L,304250263527210L,212L,10L,9699691L,13082761331670030L,6L,60L,13L,30032L,2312L,614889782588491410L,7L,216L,33L,510512L,223092871L,BigInteger.Parse("32589158477190044730"),10L };
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
public class A276085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276085Inst Instance=new A276085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276086
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,18L,5L,10L,15L,30L,45L,90L,25L,50L,75L,150L,225L,450L,125L,250L,375L,750L,1125L,2250L,625L,1250L,1875L,3750L,5625L,11250L,7L,14L,21L,42L,63L,126L,35L,70L,105L,210L,315L,630L,175L,350L,525L,1050L,1575L,3150L,875L,1750L,2625L,5250L,7875L,15750L,4375L,8750L,13125L,26250L,39375L,78750L,49L,98L,147L,294L,441L,882L,245L,490L,735L,1470L,2205L,4410L,1225L,2450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276086Inst : IEnumerable<long>
{
public static readonly long[] Value=A276086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276086.Bytes);
public long this[int i]=>Value[i];

public static A276086Inst Instance=new A276086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276087
{
public static readonly long[] Value={ 2L,3L,6L,5L,30L,125L,18L,45L,150L,7L,1050L,343L,1250L,2625L,7350L,16807L,1650L,847L,43218L,3465L,27731550L,3195731L,1183724850L,435930295269007L,17794411250L,7105308412125L,3782866198615350L,2709490941157L,6237907125450L,161696170950365051L,10L,75L,750L,175L,294L,12005L,126L,2205L,51450L,11L,565950L,1331L,21008750L,9904125L,6225450L,161051L,1002614947950L,190333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276087Inst : IEnumerable<long>
{
public static readonly long[] Value=A276087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276087.Bytes);
public long this[int i]=>Value[i];

public static A276087Inst Instance=new A276087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276088
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,4L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,4L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,4L,1L,1L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276088Inst : IEnumerable<long>
{
public static readonly long[] Value=A276088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276088.Bytes);
public long this[int i]=>Value[i];

public static A276088Inst Instance=new A276088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276089
{
public static readonly long[] Value={ 0L,1L,6L,7L,12L,13L,120L,121L,126L,127L,132L,133L,240L,241L,246L,247L,252L,253L,360L,361L,366L,367L,372L,373L,5040L,5041L,5046L,5047L,5052L,5053L,5160L,5161L,5166L,5167L,5172L,5173L,5280L,5281L,5286L,5287L,5292L,5293L,5400L,5401L,5406L,5407L,5412L,5413L,10080L,10081L,10086L,10087L,10092L,10093L,10200L,10201L,10206L,10207L,10212L,10213L,10320L,10321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276089Inst : IEnumerable<long>
{
public static readonly long[] Value=A276089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276089.Bytes);
public long this[int i]=>Value[i];

public static A276089Inst Instance=new A276089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276090
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,7L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,7L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,7L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,7L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276090Inst : IEnumerable<long>
{
public static readonly long[] Value=A276090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276090.Bytes);
public long this[int i]=>Value[i];

public static A276090Inst Instance=new A276090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276091
{
public static readonly long[] Value={ 0L,1L,4L,5L,18L,19L,22L,23L,96L,97L,100L,101L,114L,115L,118L,119L,600L,601L,604L,605L,618L,619L,622L,623L,696L,697L,700L,701L,714L,715L,718L,719L,4320L,4321L,4324L,4325L,4338L,4339L,4342L,4343L,4416L,4417L,4420L,4421L,4434L,4435L,4438L,4439L,4920L,4921L,4924L,4925L,4938L,4939L,4942L,4943L,5016L,5017L,5020L,5021L,5034L,5035L,5038L,5039L,35280L,35281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276091Inst : IEnumerable<long>
{
public static readonly long[] Value=A276091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276091.Bytes);
public long this[int i]=>Value[i];

public static A276091Inst Instance=new A276091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276092
{
public static readonly BigInteger[] Value={ 1L,2L,18L,11250L,1323551250L,BigInteger.Parse("34329510752434301250"),BigInteger.Parse("799811863723341113907011901401250"),BigInteger.Parse("38919798565076223182552300534870824616780123359001250"),BigInteger.Parse("4052615498709835178737678586220586796222761283625319842830388618784835051250"),BigInteger.Parse("3679152532021669595137666762315244807517735994898621013565758767014111825486079213219685771368099483111250") };
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
public class A276092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276092Inst Instance=new A276092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276093
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,0L,6L,6L,8L,6L,10L,0L,12L,12L,14L,12L,16L,0L,18L,18L,20L,18L,22L,0L,24L,24L,26L,24L,28L,0L,30L,30L,32L,30L,34L,30L,36L,36L,38L,36L,40L,30L,42L,42L,44L,42L,46L,30L,48L,48L,50L,48L,52L,30L,54L,54L,56L,54L,58L,0L,60L,60L,62L,60L,64L,60L,66L,66L,68L,66L,70L,60L,72L,72L,74L,72L,76L,60L,78L,78L,80L,78L,82L,60L,84L,84L,86L,84L,88L,0L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276093Inst : IEnumerable<long>
{
public static readonly long[] Value=A276093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276093.Bytes);
public long this[int i]=>Value[i];

public static A276093Inst Instance=new A276093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276094
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,1L,6L,1L,2L,1L,4L,1L,12L,1L,2L,1L,4L,1L,18L,1L,2L,1L,4L,1L,24L,1L,2L,1L,4L,1L,30L,1L,2L,1L,4L,1L,6L,1L,2L,1L,4L,1L,12L,1L,2L,1L,4L,1L,18L,1L,2L,1L,4L,1L,24L,1L,2L,1L,4L,1L,60L,1L,2L,1L,4L,1L,6L,1L,2L,1L,4L,1L,12L,1L,2L,1L,4L,1L,18L,1L,2L,1L,4L,1L,24L,1L,2L,1L,4L,1L,90L,1L,2L,1L,4L,1L,6L,1L,2L,1L,4L,1L,12L,1L,2L,1L,4L,1L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276094Inst : IEnumerable<long>
{
public static readonly long[] Value=A276094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276094.Bytes);
public long this[int i]=>Value[i];

public static A276094Inst Instance=new A276094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276095
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,9L,121L,17161L,298978681L,9933176210033041L,BigInteger.Parse("815437979830770470704295274609"),BigInteger.Parse("38747106750801481775941360512378545527545442200632960401") };
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
public class A276095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276095Inst Instance=new A276095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276096
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,3L,6L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276096Inst : IEnumerable<long>
{
public static readonly long[] Value=A276096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276096.Bytes);
public long this[int i]=>Value[i];

public static A276096Inst Instance=new A276096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276097
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,16L,361L,143641L,20741472361L,BigInteger.Parse("430214650013601071641"),BigInteger.Parse("11567790319010747187536221088708755344001"),BigInteger.Parse("370675271093071368960746074163948008803845834307486807769098691609909105887376") };
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
public class A276097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276097Inst Instance=new A276097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276098
{
public static readonly BigInteger[] Value={ 1L,48L,6006L,860160L,130378950L,20392706048L,3254013513660L,526470648692736L,86047769258554950L,14173603389190963200UL,BigInteger.Parse("2349023203055914140756"),BigInteger.Parse("391249767795614684282880"),BigInteger.Parse("65434374898388743460014620"),BigInteger.Parse("10981406991821583404677201920") };
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
public class A276098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276098Inst Instance=new A276098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276099
{
public static readonly BigInteger[] Value={ 1L,96L,24310L,7028736L,2149374150L,678057476096L,218191487357116L,71184392021606400L,BigInteger.Parse("23459604526110889542"),BigInteger.Parse("7791432263086689484800"),BigInteger.Parse("2603575153867220801823060"),BigInteger.Parse("874329826463740757819785216"),BigInteger.Parse("294822072977645830504963830300") };
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
public class A276099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276099Inst Instance=new A276099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276164
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,15L,17L,26L,27L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276164Inst : IEnumerable<long>
{
public static readonly long[] Value=A276164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276164.Bytes);
public long this[int i]=>Value[i];

public static A276164Inst Instance=new A276164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276165
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,1L,1L,4L,2L,0L,2L,2L,0L,2L,0L,5L,3L,1L,3L,1L,1L,1L,1L,3L,-1L,1L,1L,3L,1L,1L,1L,6L,4L,2L,4L,0L,2L,2L,2L,2L,0L,2L,0L,2L,2L,0L,2L,4L,-2L,0L,2L,2L,0L,2L,0L,4L,2L,0L,0L,2L,0L,2L,0L,7L,5L,3L,5L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,3L,3L,-1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276165Inst : IEnumerable<long>
{
public static readonly long[] Value=A276165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276165.Bytes);
public long this[int i]=>Value[i];

public static A276165Inst Instance=new A276165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276166
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,2L,2L,4L,3L,2L,3L,3L,2L,3L,2L,5L,4L,3L,4L,3L,3L,3L,3L,4L,2L,3L,3L,4L,3L,3L,3L,6L,5L,4L,5L,3L,4L,4L,4L,4L,3L,4L,3L,4L,4L,3L,4L,5L,2L,3L,4L,4L,3L,4L,3L,5L,4L,3L,3L,4L,3L,4L,3L,7L,6L,5L,6L,4L,5L,5L,5L,4L,4L,5L,4L,4L,5L,4L,5L,5L,3L,4L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276166Inst : IEnumerable<long>
{
public static readonly long[] Value=A276166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276166.Bytes);
public long this[int i]=>Value[i];

public static A276166Inst Instance=new A276166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276167
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,2L,1L,2L,0L,1L,2L,1L,2L,2L,2L,2L,1L,3L,2L,2L,1L,2L,2L,2L,0L,1L,2L,1L,3L,2L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,1L,4L,3L,2L,2L,3L,2L,3L,1L,2L,3L,3L,2L,3L,2L,3L,0L,1L,2L,1L,3L,2L,2L,2L,3L,3L,2L,3L,3L,2L,3L,2L,2L,4L,3L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276167Inst : IEnumerable<long>
{
public static readonly long[] Value=A276167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276167.Bytes);
public long this[int i]=>Value[i];

public static A276167Inst Instance=new A276167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276168
{
public static readonly long[] Value={ 1L,1L,0L,0L,-3L,1L,-8L,0L,-15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276168Inst : IEnumerable<long>
{
public static readonly long[] Value=A276168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276168.Bytes);
public long this[int i]=>Value[i];

public static A276168Inst Instance=new A276168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276169
{
public static readonly long[] Value={ 2L,29L,59L,149L,191L,269L,359L,449L,479L,491L,569L,593L,599L,719L,911L,929L,1109L,1193L,1229L,1319L,1439L,1559L,1619L,1979L,1987L,2129L,2339L,2459L,2549L,2609L,2699L,2897L,2909L,2963L,3209L,3299L,3449L,3491L,3539L,3719L,3911L,3923L,4019L,4049L,4091L,4349L,4649L,4793L,4943L,4987L,5099L,5399L,5519L,5639L,5693L,5897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276169Inst : IEnumerable<long>
{
public static readonly long[] Value=A276169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276169.Bytes);
public long this[int i]=>Value[i];

public static A276169Inst Instance=new A276169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276170
{
public static readonly long[] Value={ 1L,1364L,3435L,4155L,4316L,4355L,17463L,48625L,63725L,78215L,117693L,136775L,137456L,137529L,164726L,184746L,196753L,264719L,326617L,326671L,397612L,423858L,516974L,637395L,652812L,653285L,653957L,687523L,834272L,936627L,1374962L,1617349L,1679812L,1683397L,1683514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276170Inst : IEnumerable<long>
{
public static readonly long[] Value=A276170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276170.Bytes);
public long this[int i]=>Value[i];

public static A276170Inst Instance=new A276170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276171
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,4L,1L,9L,1L,16L,30L,12L,1L,1L,25L,132L,200L,79L,1L,36L,360L,1232L,1246L,1L,49L,780L,5048L,13211L,11984L,4526L,758L,51L,1L,1L,64L,1470L,15468L,78851L,193672L,234394L,139188L,37760L,3600L,1L,81L,2520L,38972L,324721L,1490562L,3761236L,5052890L,3305328L,807648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276171Inst : IEnumerable<long>
{
public static readonly long[] Value=A276171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276171.Bytes);
public long this[int i]=>Value[i];

public static A276171Inst Instance=new A276171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276172
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,2L,1L,3L,4L,1L,3L,1L,1L,3L,3L,1L,2L,2L,3L,2L,1L,1L,2L,2L,2L,3L,1L,2L,3L,3L,3L,2L,3L,2L,3L,1L,5L,1L,2L,3L,3L,2L,3L,1L,3L,2L,4L,1L,3L,4L,3L,2L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276172Inst : IEnumerable<long>
{
public static readonly long[] Value=A276172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276172.Bytes);
public long this[int i]=>Value[i];

public static A276172Inst Instance=new A276172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276173
{
public static readonly long[] Value={ 3L,5L,5L,6L,11L,17L,11L,17L,23L,35L,35L,35L,35L,35L,59L,47L,65L,53L,71L,71L,71L,71L,89L,95L,107L,101L,107L,95L,107L,107L,143L,113L,119L,125L,167L,143L,161L,179L,179L,185L,191L,161L,167L,179L,215L,179L,215L,215L,209L,233L,239L,215L,251L,269L,239L,263L,281L,287L,287L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276173Inst : IEnumerable<long>
{
public static readonly long[] Value=A276173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276173.Bytes);
public long this[int i]=>Value[i];

public static A276173Inst Instance=new A276173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276174
{
public static readonly long[] Value={ 5L,11L,23L,71L,101L,263L,503L,1031L,1283L,1487L,1511L,1583L,1637L,2039L,2087L,2543L,2843L,2903L,3023L,5039L,5519L,5927L,7823L,9851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276174Inst : IEnumerable<long>
{
public static readonly long[] Value=A276174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276174.Bytes);
public long this[int i]=>Value[i];

public static A276174Inst Instance=new A276174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276175
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,8L,36L,666L,222111L,685187756L,2819713283228248L,BigInteger.Parse("644335913093223286486628176"),BigInteger.Parse("5604757351123068775966272886689217889936356651"),BigInteger.Parse("14861563788248216173988661093334637018340529129342104300621091389266132702213641") };
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
public class A276175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276175Inst Instance=new A276175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276176
{
public static readonly long[] Value={ 2L,26L,31L,34L,15526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276176Inst : IEnumerable<long>
{
public static readonly long[] Value=A276176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276176.Bytes);
public long this[int i]=>Value[i];

public static A276176Inst Instance=new A276176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276177
{
public static readonly BigInteger[] Value={ 1L,78L,4446L,20124L,-38185290L,-6138851004L,-560711991060L,-21068540562888L,3057536757534246L,744702083933794740L,BigInteger.Parse("85203074089262120004"),BigInteger.Parse("5052846560269468159368"),BigInteger.Parse("-180318018879496001303748"),BigInteger.Parse("-86176724948835065345458008"),BigInteger.Parse("-11276003918572185562671306600"),BigInteger.Parse("-751248675388448553292016521104") };
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
public class A276177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276177Inst Instance=new A276177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276178
{
public static readonly long[] Value={ 1L,4L,12L,32L,84L,240L,784L,2816L,10404L,38096L,137456L,493440L,1783376L,6532288L,24245568L,90814464L,341776164L,1289126160L,4870386736L,18439692928L,70004793936L,266551445952L,1017708956224L,3894679004160L,14932998810896L,57349426579264L,220574904103872L,849571289810432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276178Inst : IEnumerable<long>
{
public static readonly long[] Value=A276178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276178.Bytes);
public long this[int i]=>Value[i];

public static A276178Inst Instance=new A276178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276179
{
public static readonly long[] Value={ 1L,6L,24L,78L,216L,504L,906L,756L,-2808L,-17832L,-57312L,-104832L,81882L,1734156L,9360576L,35755956L,106475472L,232967664L,215497680L,-1178534304L,-8734303296L,-36146763648L,-108833048064L,-220247838720L,-46688571558L,2220777704700L,13473296923536L,53523581091900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276179Inst : IEnumerable<long>
{
public static readonly long[] Value=A276179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276179.Bytes);
public long this[int i]=>Value[i];

public static A276179Inst Instance=new A276179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276260
{
public static readonly long[] Value={ 5L,13L,17L,53L,61L,107L,251L,283L,1367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276260Inst : IEnumerable<long>
{
public static readonly long[] Value=A276260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276260.Bytes);
public long this[int i]=>Value[i];

public static A276260Inst Instance=new A276260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276261
{
public static readonly long[] Value={ 127L,211L,757L,2521L,2857L,6301L,8527L,16381L,19867L,23689L,24697L,27847L,32341L,37171L,38431L,42337L,66361L,68041L,82237L,89839L,97777L,103951L,114661L,140071L,152461L,162751L,170689L,192781L,204331L,216217L,231547L,240997L,284131L,308827L,353557L,357421L,385057L,389089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276261Inst : IEnumerable<long>
{
public static readonly long[] Value=A276261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276261.Bytes);
public long this[int i]=>Value[i];

public static A276261Inst Instance=new A276261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276262
{
public static readonly long[] Value={ 23L,67L,331L,463L,617L,991L,1453L,2003L,2311L,4621L,6073L,7151L,7723L,8317L,8933L,11617L,12343L,14653L,15467L,18041L,19867L,25873L,26951L,28051L,29173L,37643L,41603L,42967L,51613L,61051L,62701L,64373L,66067L,67783L,73063L,78541L,94117L,102433L,117833L,120121L,131891L,136753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276262Inst : IEnumerable<long>
{
public static readonly long[] Value=A276262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276262.Bytes);
public long this[int i]=>Value[i];

public static A276262Inst Instance=new A276262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276263
{
public static readonly long[] Value={ 139L,829L,4831L,15319L,36709L,53959L,58789L,65551L,74521L,107089L,142969L,198859L,227011L,278071L,292561L,727399L,750721L,804541L,879199L,957169L,1181281L,1325491L,1364821L,1519519L,1700161L,1835401L,1881631L,2111539L,2231461L,2396509L,2778079L,2926981L,3067879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276263Inst : IEnumerable<long>
{
public static readonly long[] Value=A276263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276263.Bytes);
public long this[int i]=>Value[i];

public static A276263Inst Instance=new A276263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276264
{
public static readonly long[] Value={ 151L,251L,701L,1951L,3001L,4751L,10151L,12401L,16651L,19501L,28201L,29401L,33151L,38501L,39901L,45751L,56951L,63901L,65701L,81001L,87151L,95701L,104651L,114001L,136501L,144451L,147151L,158201L,178501L,181501L,193751L,219451L,232901L,257401L,275651L,290701L,318001L,322001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276264Inst : IEnumerable<long>
{
public static readonly long[] Value=A276264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276264.Bytes);
public long this[int i]=>Value[i];

public static A276264Inst Instance=new A276264Inst();

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