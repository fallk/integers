using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A105241
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,2L,4L,3L,3L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105241Inst : IEnumerable<long>
{
public static readonly long[] Value=A105241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105241.Bytes);
public long this[int i]=>Value[i];

public static A105241Inst Instance=new A105241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105242
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,2L,4L,3L,3L,1L,4L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,2L,4L,3L,3L,1L,4L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105242Inst : IEnumerable<long>
{
public static readonly long[] Value=A105242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105242.Bytes);
public long this[int i]=>Value[i];

public static A105242Inst Instance=new A105242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105243
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,2L,0L,1L,1L,1L,0L,1L,2L,3L,0L,2L,1L,1L,0L,1L,2L,3L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,0L,1L,3L,5L,0L,3L,2L,2L,0L,2L,1L,2L,0L,1L,1L,1L,0L,1L,3L,5L,0L,3L,2L,2L,0L,2L,1L,2L,0L,1L,1L,1L,0L,1L,2L,3L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,0L,1L,5L,8L,0L,5L,3L,3L,0L,3L,2L,4L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105243Inst : IEnumerable<long>
{
public static readonly long[] Value=A105243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105243.Bytes);
public long this[int i]=>Value[i];

public static A105243Inst Instance=new A105243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105244
{
public static readonly long[] Value={ 1L,2L,3L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105244Inst : IEnumerable<long>
{
public static readonly long[] Value=A105244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105244.Bytes);
public long this[int i]=>Value[i];

public static A105244Inst Instance=new A105244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105245
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,4L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,2L,4L,7L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,2L,4L,7L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,2L,4L,7L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105245Inst : IEnumerable<long>
{
public static readonly long[] Value=A105245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105245.Bytes);
public long this[int i]=>Value[i];

public static A105245Inst Instance=new A105245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105246
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,4L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,0L,1L,1L,2L,4L,7L,1L,2L,4L,1L,1L,2L,1L,1L,2L,1L,2L,4L,0L,1L,1L,2L,4L,7L,1L,2L,4L,1L,1L,2L,1L,1L,2L,1L,2L,4L,0L,1L,1L,1L,1L,2L,1L,2L,4L,0L,1L,1L,2L,4L,7L,1L,2L,4L,1L,1L,2L,1L,1L,2L,1L,2L,4L,0L,1L,1L,4L,6L,11L,3L,6L,12L,1L,3L,4L,2L,4L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105246Inst : IEnumerable<long>
{
public static readonly long[] Value=A105246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105246.Bytes);
public long this[int i]=>Value[i];

public static A105246Inst Instance=new A105246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105247
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,5L,5L,5L,10L,10L,10L,10L,10L,50L,50L,50L,50L,50L,100L,100L,100L,100L,100L,500L,500L,500L,500L,500L,1000L,1000L,1000L,1000L,1000L,5000L,5000L,5000L,5000L,5000L,10000L,500L,500L,500L,500L,2500L,2500L,2500L,2500L,2500L,5000L,50L,50L,50L,50L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105247Inst : IEnumerable<long>
{
public static readonly long[] Value=A105247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105247.Bytes);
public long this[int i]=>Value[i];

public static A105247Inst Instance=new A105247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105248
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,3L,3L,1L,2L,3L,1L,3L,4L,4L,4L,4L,2L,3L,3L,4L,3L,2L,3L,2L,2L,3L,5L,5L,4L,3L,4L,2L,5L,6L,2L,5L,3L,2L,3L,3L,3L,3L,3L,4L,2L,4L,2L,5L,2L,3L,5L,3L,6L,4L,5L,2L,5L,4L,3L,3L,3L,4L,2L,5L,4L,4L,5L,5L,4L,5L,1L,3L,6L,4L,2L,2L,4L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105248Inst : IEnumerable<long>
{
public static readonly long[] Value=A105248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105248.Bytes);
public long this[int i]=>Value[i];

public static A105248Inst Instance=new A105248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105249
{
public static readonly long[] Value={ 1L,21L,168L,840L,3150L,9702L,25872L,61776L,135135L,275275L,528528L,965328L,1689324L,2848860L,4651200L,7379904L,11415789L,17261937L,25573240L,37191000L,53183130L,74890530L,103980240L,142506000L,192976875L,258434631L,342540576L,449672608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105249Inst : IEnumerable<long>
{
public static readonly long[] Value=A105249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105249.Bytes);
public long this[int i]=>Value[i];

public static A105249Inst Instance=new A105249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105250
{
public static readonly long[] Value={ 1L,32L,360L,2400L,11550L,44352L,144144L,411840L,1061775L,2516800L,5562128L,11583936L,22926540L,43411200L,79070400L,139163904L,237557133L,394558560L,639331000L,1013012000L,1572701130L,2396496960L,3589794000L,5293080000L,7691506875L,11026544256L,15610063392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105250Inst : IEnumerable<long>
{
public static readonly long[] Value=A105250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105250.Bytes);
public long this[int i]=>Value[i];

public static A105250Inst Instance=new A105250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105251
{
public static readonly long[] Value={ 1L,45L,675L,5775L,34650L,162162L,630630L,2123550L,6370650L,17381650L,43801758L,103169430L,229265400L,484306200L,978496200L,1900457064L,3563356995L,6473226375L,11428041625L,19658764125L,33026723730L,54295634250L,87501228750L,138447123750L,215362192500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105251Inst : IEnumerable<long>
{
public static readonly long[] Value=A105251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105251.Bytes);
public long this[int i]=>Value[i];

public static A105251Inst Instance=new A105251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105252
{
public static readonly long[] Value={ 1L,60L,1155L,12320L,90090L,504504L,2312310L,9060480L,31286970L,97337240L,277411134L,733649280L,1818838840L,4261894560L,9502285320L,20271542016L,41572498275L,82281899700L,157706974425L,293570877600L,532097215650L,941124327000L,1627522854750L,2756636064000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105252Inst : IEnumerable<long>
{
public static readonly long[] Value=A105252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105252.Bytes);
public long this[int i]=>Value[i];

public static A105252Inst Instance=new A105252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105253
{
public static readonly long[] Value={ 1L,77L,1848L,24024L,210210L,1387386L,7399392L,33372768L,131405274L,462351890L,1479526048L,4365213216L,12004336344L,31040798712L,76018282560L,177375992640L,396324483555L,851617661895L,1766318113560L,3547314771000L,6917263803450L,13128684361650L,24304341297600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105253Inst : IEnumerable<long>
{
public static readonly long[] Value=A105253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105253.Bytes);
public long this[int i]=>Value[i];

public static A105253Inst Instance=new A105253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105254
{
public static readonly long[] Value={ 1L,96L,2808L,43680L,450450L,3459456L,21237216L,109219968L,486370170L,1921462400L,6859620768L,22449667968L,68128506264L,193501082880L,518306472000L,1317650231040L,3196331224515L,7432299594720L,16630917303000L,35933837940000L,75191555889450L,152770145299200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105254Inst : IEnumerable<long>
{
public static readonly long[] Value=A105254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105254.Bytes);
public long this[int i]=>Value[i];

public static A105254Inst Instance=new A105254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105255
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,5L,3L,2L,5L,3L,1L,6L,4L,1L,4L,4L,3L,4L,4L,2L,3L,3L,3L,4L,4L,2L,6L,5L,4L,6L,3L,1L,5L,6L,2L,6L,4L,3L,7L,5L,2L,8L,7L,4L,7L,5L,4L,7L,3L,7L,5L,3L,3L,9L,6L,5L,3L,3L,3L,7L,3L,4L,6L,4L,2L,6L,7L,5L,7L,7L,4L,7L,6L,4L,5L,3L,4L,6L,2L,2L,7L,5L,3L,9L,6L,4L,8L,6L,7L,5L,2L,5L,6L,5L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105255Inst : IEnumerable<long>
{
public static readonly long[] Value=A105255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105255.Bytes);
public long this[int i]=>Value[i];

public static A105255Inst Instance=new A105255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105256
{
public static readonly long[] Value={ 1L,4L,2L,4L,2L,1L,5L,1L,3L,4L,2L,1L,5L,1L,3L,1L,5L,1L,3L,4L,2L,4L,6L,4L,2L,1L,4L,2L,1L,5L,1L,3L,1L,5L,1L,3L,4L,2L,4L,6L,4L,2L,1L,1L,5L,1L,3L,4L,2L,4L,6L,4L,2L,1L,4L,2L,4L,6L,4L,2L,1L,1L,5L,1L,3L,1L,5L,4L,1L,5L,1L,3L,4L,2L,4L,2L,1L,5L,1L,3L,1L,5L,1L,3L,4L,2L,4L,6L,4L,2L,1L,1L,5L,1L,3L,4L,2L,4L,6L,4L,2L,1L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105256Inst : IEnumerable<long>
{
public static readonly long[] Value=A105256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105256.Bytes);
public long this[int i]=>Value[i];

public static A105256Inst Instance=new A105256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105257
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,2L,1L,4L,3L,6L,5L,3L,6L,5L,2L,1L,4L,4L,5L,6L,1L,2L,3L,5L,4L,1L,6L,3L,2L,6L,3L,2L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105257Inst : IEnumerable<long>
{
public static readonly long[] Value=A105257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105257.Bytes);
public long this[int i]=>Value[i];

public static A105257Inst Instance=new A105257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105258
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,2L,1L,3L,1L,3L,2L,1L,1L,2L,2L,1L,3L,2L,1L,3L,1L,3L,2L,1L,2L,1L,3L,1L,3L,2L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,3L,2L,1L,3L,1L,3L,2L,1L,2L,1L,3L,1L,3L,2L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,2L,1L,3L,1L,3L,2L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,2L,1L,1L,3L,2L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105258Inst : IEnumerable<long>
{
public static readonly long[] Value=A105258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105258.Bytes);
public long this[int i]=>Value[i];

public static A105258Inst Instance=new A105258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105259
{
public static readonly long[] Value={ 0L,2L,1L,2L,1L,3L,1L,4L,2L,3L,3L,3L,3L,4L,3L,4L,3L,6L,2L,4L,4L,3L,3L,5L,4L,7L,4L,6L,2L,6L,3L,6L,1L,2L,3L,5L,3L,10L,4L,7L,5L,4L,6L,7L,1L,7L,2L,6L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105259Inst : IEnumerable<long>
{
public static readonly long[] Value=A105259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105259.Bytes);
public long this[int i]=>Value[i];

public static A105259Inst Instance=new A105259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105260
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,1L,6L,6L,1L,8L,15L,4L,1L,10L,28L,20L,1L,1L,12L,45L,56L,15L,1L,14L,66L,120L,70L,6L,1L,16L,91L,220L,210L,56L,1L,1L,18L,120L,364L,495L,252L,28L,1L,20L,153L,560L,1001L,792L,210L,8L,1L,22L,190L,816L,1820L,2002L,924L,120L,1L,1L,24L,231L,1140L,3060L,4368L,3003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105260Inst : IEnumerable<long>
{
public static readonly long[] Value=A105260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105260.Bytes);
public long this[int i]=>Value[i];

public static A105260Inst Instance=new A105260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105261
{
public static readonly long[] Value={ 1L,8L,108L,250L,6174L,41154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105261Inst : IEnumerable<long>
{
public static readonly long[] Value=A105261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105261.Bytes);
public long this[int i]=>Value[i];

public static A105261Inst Instance=new A105261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105262
{
public static readonly long[] Value={ 1L,1L,5L,13L,42L,126L,387L,1180L,3606L,11012L,33636L,102733L,313781L,958384L,2927209L,8940617L,27307465L,83405605L,254747014L,778077690L,2376494563L,7258563604L,22169941574L,67713990832L,206819875428L,631693101321L,1929389878185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105262Inst : IEnumerable<long>
{
public static readonly long[] Value=A105262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105262.Bytes);
public long this[int i]=>Value[i];

public static A105262Inst Instance=new A105262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105263
{
public static readonly long[] Value={ 3L,7L,8L,15L,39L,7L,8L,8L,335L,32L,55L,24L,704L,39L,1631L,87L,15L,15L,16L,9235919L,119L,4959L,5247L,56L,39L,80L,40L,746511L,104L,488880L,33695L,92901159L,23L,23L,24L,24L,175L,244184L,23855L,552L,1391L,6215L,157440L,55L,168L,56L,319L,43455L,44295L,847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105263Inst : IEnumerable<long>
{
public static readonly long[] Value=A105263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105263.Bytes);
public long this[int i]=>Value[i];

public static A105263Inst Instance=new A105263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105264
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,4L,1L,2L,3L,3L,4L,3L,4L,4L,4L,1L,3L,4L,4L,4L,1L,4L,4L,1L,4L,1L,4L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,1L,3L,4L,4L,4L,1L,4L,4L,1L,4L,1L,4L,1L,2L,3L,4L,4L,4L,1L,4L,4L,1L,4L,1L,4L,1L,2L,4L,4L,1L,4L,1L,4L,1L,2L,4L,1L,4L,1L,2L,4L,1L,2L,4L,1L,2L,3L,2L,3L,3L,4L,3L,4L,4L,4L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105264Inst : IEnumerable<long>
{
public static readonly long[] Value=A105264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105264.Bytes);
public long this[int i]=>Value[i];

public static A105264Inst Instance=new A105264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105265
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105265Inst : IEnumerable<long>
{
public static readonly long[] Value=A105265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105265.Bytes);
public long this[int i]=>Value[i];

public static A105265Inst Instance=new A105265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105266
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,19L,20L,21L,25L,26L,27L,55L,56L,57L,61L,62L,63L,73L,74L,75L,79L,80L,81L,163L,164L,165L,169L,170L,171L,181L,182L,183L,187L,188L,189L,217L,218L,219L,223L,224L,225L,235L,236L,237L,241L,242L,243L,487L,488L,489L,493L,494L,495L,505L,506L,507L,511L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105266Inst : IEnumerable<long>
{
public static readonly long[] Value=A105266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105266.Bytes);
public long this[int i]=>Value[i];

public static A105266Inst Instance=new A105266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105267
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,8L,8L,16L,4L,4L,8L,2L,8L,24L,8L,4L,16L,8L,8L,4L,16L,8L,8L,6L,8L,16L,64L,4L,4L,8L,8L,16L,16L,2L,8L,8L,64L,64L,8L,4L,8L,32L,8L,2L,8L,8L,16L,64L,8L,8L,32L,8L,32L,2L,8L,64L,32L,16L,8L,32L,8L,8L,32L,16L,64L,64L,8L,64L,4L,4L,16L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105267Inst : IEnumerable<long>
{
public static readonly long[] Value=A105267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105267.Bytes);
public long this[int i]=>Value[i];

public static A105267Inst Instance=new A105267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105268
{
public static readonly BigInteger[] Value={ 2L,89L,97L,809L,907L,8009L,8699L,9697L,9887L,81119L,98887L,8000009L,9888887L,81111119L,8666699999L,9888888887L,8111111119L,8000000000009L,9888888888887L,98888888888888887L,BigInteger.Parse("81111111111111111119"),BigInteger.Parse("800000000000000000009") };
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
public class A105268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105268Inst Instance=new A105268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105269
{
public static readonly long[] Value={ 5L,2L,3L,13L,23L,37L,83L,233L,283L,383L,887L,2383L,2887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105269Inst : IEnumerable<long>
{
public static readonly long[] Value=A105269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105269.Bytes);
public long this[int i]=>Value[i];

public static A105269Inst Instance=new A105269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105270
{
public static readonly long[] Value={ 11L,25L,64L,122L,205L,300L,442L,605L,854L,1140L,1402L,1737L,2070L,2471L,2960L,3549L,4105L,4578L,52L,16L,5796L,6487L,7465L,8442L,9444L,10374L,10998L,11634L,12870L,14191L,15975L,17764L,19234L,2063L,7L,22115L,23950L,25350L,27146L,28979L,30550L,32673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105270Inst : IEnumerable<long>
{
public static readonly long[] Value=A105270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105270.Bytes);
public long this[int i]=>Value[i];

public static A105270Inst Instance=new A105270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105271
{
public static readonly long[] Value={ 0L,1L,4L,6L,17L,21L,25L,29L,1024L,1032L,1040L,1048L,1056L,1064L,1072L,1080L,1088L,1096L,1104L,1112L,1120L,1128L,1136L,1144L,1152L,1160L,1168L,1176L,1184L,1192L,1200L,1208L,1216L,1224L,1232L,1240L,1248L,1256L,1264L,1272L,1280L,1288L,1296L,1304L,1312L,1320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105271Inst : IEnumerable<long>
{
public static readonly long[] Value=A105271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105271.Bytes);
public long this[int i]=>Value[i];

public static A105271Inst Instance=new A105271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105272
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,4L,2L,2L,1L,4L,4L,2L,2L,1L,3L,6L,4L,2L,2L,1L,3L,6L,7L,4L,2L,2L,1L,6L,4L,3L,7L,4L,2L,2L,1L,6L,4L,3L,15L,14L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105272Inst : IEnumerable<long>
{
public static readonly long[] Value=A105272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105272.Bytes);
public long this[int i]=>Value[i];

public static A105272Inst Instance=new A105272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105273
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,2L,4L,2L,2L,0L,1L,1L,3L,3L,0L,0L,4L,2L,0L,1L,0L,2L,0L,2L,0L,2L,3L,0L,1L,0L,1L,2L,2L,0L,4L,0L,3L,0L,0L,1L,2L,3L,0L,1L,4L,4L,0L,0L,0L,3L,0L,4L,4L,0L,1L,2L,0L,5L,5L,1L,4L,5L,4L,2L,6L,1L,2L,1L,0L,0L,1L,4L,5L,2L,0L,0L,2L,4L,1L,3L,0L,2L,0L,1L,1L,3L,2L,0L,1L,1L,4L,1L,0L,0L,2L,2L,2L,0L,1L,1L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105273Inst : IEnumerable<long>
{
public static readonly long[] Value=A105273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105273.Bytes);
public long this[int i]=>Value[i];

public static A105273Inst Instance=new A105273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105274
{
public static readonly long[] Value={ 4L,9L,6L,9L,9L,8L,6L,6L,8L,9L,9L,9L,7L,8L,9L,9L,9L,3L,8L,6L,6L,8L,8L,8L,5L,4L,7L,9L,8L,8L,3L,8L,3L,7L,9L,8L,6L,9L,8L,3L,7L,5L,9L,8L,8L,8L,7L,5L,8L,7L,9L,8L,9L,6L,9L,9L,9L,8L,9L,9L,9L,6L,8L,7L,6L,8L,8L,8L,6L,7L,2L,9L,9L,6L,8L,9L,6L,8L,5L,8L,9L,6L,7L,6L,9L,4L,7L,7L,8L,6L,7L,5L,9L,9L,8L,9L,5L,9L,7L,5L,6L,9L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105274Inst : IEnumerable<long>
{
public static readonly long[] Value=A105274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105274.Bytes);
public long this[int i]=>Value[i];

public static A105274Inst Instance=new A105274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105275
{
public static readonly long[] Value={ 855L,1012L,1220L,2564L,3967L,3983L,4556L,6600L,7033L,7771L,9987L,10432L,12236L,15327L,16217L,17540L,17769L,18101L,19613L,19806L,20785L,21865L,22213L,23237L,23365L,23840L,25992L,26935L,28184L,28487L,28489L,29460L,30083L,31138L,32096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105275Inst : IEnumerable<long>
{
public static readonly long[] Value=A105275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105275.Bytes);
public long this[int i]=>Value[i];

public static A105275Inst Instance=new A105275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105276
{
public static readonly long[] Value={ 1000L,1240L,1314L,2182L,2647L,3567L,4038L,6264L,6580L,6582L,6584L,6950L,7939L,9151L,9426L,9868L,9966L,11014L,13249L,14025L,17561L,17985L,22108L,23863L,25254L,25404L,27170L,28286L,28860L,29892L,30104L,30185L,30372L,30490L,31278L,31591L,33347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105276Inst : IEnumerable<long>
{
public static readonly long[] Value=A105276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105276.Bytes);
public long this[int i]=>Value[i];

public static A105276Inst Instance=new A105276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105277
{
public static readonly long[] Value={ 0L,1L,5L,29L,203L,1680L,16058L,173865L,2099957L,27952999L,406125305L,6389713034L,108157272720L,1958821525361L,37779732341077L,772829270394685L,16708083353842267L,380563529091632760L,9106983116342966818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105277Inst : IEnumerable<long>
{
public static readonly long[] Value=A105277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105277.Bytes);
public long this[int i]=>Value[i];

public static A105277Inst Instance=new A105277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105278
{
public static readonly long[] Value={ 1L,2L,1L,6L,6L,1L,24L,36L,12L,1L,120L,240L,120L,20L,1L,720L,1800L,1200L,300L,30L,1L,5040L,15120L,12600L,4200L,630L,42L,1L,40320L,141120L,141120L,58800L,11760L,1176L,56L,1L,362880L,1451520L,1693440L,846720L,211680L,28224L,2016L,72L,1L,3628800L,16329600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105278Inst : IEnumerable<long>
{
public static readonly long[] Value=A105278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105278.Bytes);
public long this[int i]=>Value[i];

public static A105278Inst Instance=new A105278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105279
{
public static readonly ulong[] Value={ 0L,10L,110L,1110L,11110L,111110L,1111110L,11111110L,111111110L,1111111110L,11111111110L,111111111110L,1111111111110L,11111111111110L,111111111111110L,1111111111111110L,11111111111111110L,111111111111111110L,1111111111111111110L,11111111111111111110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105279Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A105279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105279.Bytes);
public ulong this[int i]=>Value[i];

public static A105279Inst Instance=new A105279Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105280
{
public static readonly BigInteger[] Value={ 0L,11L,132L,1463L,16104L,177155L,1948716L,21435887L,235794768L,2593742459L,28531167060L,313842837671L,3452271214392L,37974983358323L,417724816941564L,4594972986357215L,50544702849929376L,555991731349223147L,6115909044841454628L,BigInteger.Parse("67274999493256000919") };
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
public class A105280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105280Inst Instance=new A105280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105281
{
public static readonly long[] Value={ 0L,6L,42L,258L,1554L,9330L,55986L,335922L,2015538L,12093234L,72559410L,435356466L,2612138802L,15672832818L,94036996914L,564221981490L,3385331888946L,20311991333682L,121871948002098L,731231688012594L,4387390128075570L,26324340768453426L,157946044610720562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105281Inst : IEnumerable<long>
{
public static readonly long[] Value=A105281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105281.Bytes);
public long this[int i]=>Value[i];

public static A105281Inst Instance=new A105281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105282
{
public static readonly long[] Value={ 2L,4L,46L,154L,266L,472L,748L,1434L,1738L,2058L,2204L,2222L,2428L,2478L,2510L,2866L,3132L,3288L,3576L,3688L,3756L,4142L,4506L,4940L,5164L,6252L,6330L,6786L,7180L,7300L,7338L,7416L,7628L,7806L,9270L,9312L,10044L,10722L,10860L,12126L,12422L,12668L,12998L,13350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105282Inst : IEnumerable<long>
{
public static readonly long[] Value=A105282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105282.Bytes);
public long this[int i]=>Value[i];

public static A105282Inst Instance=new A105282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105283
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,1L,1L,5L,7L,1L,2L,5L,10L,9L,8L,3L,3L,7L,11L,13L,13L,17L,15L,7L,4L,5L,8L,11L,10L,11L,14L,23L,20L,31L,34L,35L,3L,3L,7L,9L,11L,13L,13L,17L,13L,19L,21L,23L,31L,41L,47L,49L,47L,53L,51L,53L,49L,3L,57L,59L,2L,1L,8L,15L,18L,17L,20L,21L,28L,39L,40L,35L,36L,43L,38L,45L,40L,53L,60L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105283Inst : IEnumerable<long>
{
public static readonly long[] Value=A105283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105283.Bytes);
public long this[int i]=>Value[i];

public static A105283Inst Instance=new A105283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105284
{
public static readonly long[] Value={ 1L,3L,10L,37L,142L,558L,2212L,8811L,35170L,140538L,561868L,2246914L,8986540L,35943948L,143771368L,575076661L,2300289022L,9201120918L,36804413332L,147217512790L,588869770084L,2355478518468L,9421912950136L,37687649553630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105284Inst : IEnumerable<long>
{
public static readonly long[] Value=A105284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105284.Bytes);
public long this[int i]=>Value[i];

public static A105284Inst Instance=new A105284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105285
{
public static readonly long[] Value={ 6L,15L,18L,21L,35L,39L,44L,45L,54L,55L,57L,78L,80L,84L,90L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105285Inst : IEnumerable<long>
{
public static readonly long[] Value=A105285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105285.Bytes);
public long this[int i]=>Value[i];

public static A105285Inst Instance=new A105285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105286
{
public static readonly long[] Value={ 1L,2L,3L,10L,24L,25L,66L,168L,182L,186L,187L,188L,438L,6462L,40071L,40084L,40085L,40091L,40108L,40118L,251745L,637224L,637306L,637336L,637338L,10553441L,10553445L,10553452L,10553479L,10553515L,10553550L,10553829L,27067032L,27067054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105286Inst : IEnumerable<long>
{
public static readonly long[] Value=A105286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105286.Bytes);
public long this[int i]=>Value[i];

public static A105286Inst Instance=new A105286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105287
{
public static readonly long[] Value={ 1L,9L,67L,437L,441L,2615L,100349L,100353L,100359L,637197L,637305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105287Inst : IEnumerable<long>
{
public static readonly long[] Value=A105287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105287.Bytes);
public long this[int i]=>Value[i];

public static A105287Inst Instance=new A105287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105288
{
public static readonly long[] Value={ 1L,2L,4L,5L,70L,440L,1055L,1058L,6461L,6466L,6469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105288Inst : IEnumerable<long>
{
public static readonly long[] Value=A105288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105288.Bytes);
public long this[int i]=>Value[i];

public static A105288Inst Instance=new A105288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105289
{
public static readonly long[] Value={ 6L,12L,18L,20L,21L,33L,36L,48L,51L,54L,55L,60L,75L,78L,87L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105289Inst : IEnumerable<long>
{
public static readonly long[] Value=A105289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105289.Bytes);
public long this[int i]=>Value[i];

public static A105289Inst Instance=new A105289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105290
{
public static readonly long[] Value={ 1L,3L,11L,13L,69L,71L,637225L,637253L,637313L,637327L,4124459L,4124685L,27067033L,179993017L,179993023L,1208198853L,8179002097L,8179002109L,55762149091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105290Inst : IEnumerable<long>
{
public static readonly long[] Value=A105290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105290.Bytes);
public long this[int i]=>Value[i];

public static A105290Inst Instance=new A105290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105291
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,6L,15L,20L,15L,6L,1L,1L,24L,276L,2024L,10626L,42504L,134596L,346104L,735471L,1307504L,1961256L,2496144L,2704156L,2496144L,1961256L,1307504L,735471L,346104L,134596L,42504L,10626L,2024L,276L,24L,1L,1L,120L,7140L,280840L,8214570L,190578024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105291Inst : IEnumerable<long>
{
public static readonly long[] Value=A105291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105291.Bytes);
public long this[int i]=>Value[i];

public static A105291Inst Instance=new A105291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105292
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,13L,10L,6L,4L,1L,34L,26L,15L,8L,5L,1L,89L,68L,39L,20L,10L,6L,1L,233L,178L,102L,52L,25L,12L,7L,1L,610L,466L,267L,136L,65L,30L,14L,8L,1L,1597L,1220L,699L,356L,170L,78L,35L,16L,9L,1L,4181L,3194L,1830L,932L,445L,204L,91L,40L,18L,10L,1L,10946L,8362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105292Inst : IEnumerable<long>
{
public static readonly long[] Value=A105292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105292.Bytes);
public long this[int i]=>Value[i];

public static A105292Inst Instance=new A105292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105293
{
public static readonly BigInteger[] Value={ 3L,31L,631L,10631L,BigInteger.Parse("19531891183017701711"),665545362821L,BigInteger.Parse("7140702169036786667065556441"),BigInteger.Parse("1178111628114761132511175110261087810731"),0L,55453628211510631L };
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
public class A105293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105293Inst Instance=new A105293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105294
{
public static readonly long[] Value={ 210231253L,496528561L,630666703L,780820861L,99010351081L,495050505151L,918093169453L,9730987010011L,120901224612403L,135301369513861L,201002030120503L,223662257822791L,368563712837401L,379503822638503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105294Inst : IEnumerable<long>
{
public static readonly long[] Value=A105294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105294.Bytes);
public long this[int i]=>Value[i];

public static A105294Inst Instance=new A105294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105295
{
public static readonly BigInteger[] Value={ 171190210231L,465496528561L,94699010351081L,1275132613781431L,7626775078758001L,11325114761162811781UL,12561127201288013041UL,14535147061487815051UL,18145183361852818721UL,BigInteger.Parse("19701199002010020301") };
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
public class A105295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105295Inst Instance=new A105295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105296
{
public static readonly BigInteger[] Value={ 36101521L,435465496528561L,BigInteger.Parse("48514950505051515253"),BigInteger.Parse("1522515400155761575315931"),BigInteger.Parse("3213132385326403289633153"),BigInteger.Parse("3315333411336703393034191"),BigInteger.Parse("3631536585368563712837401") };
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
public class A105296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105296Inst Instance=new A105296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105297
{
public static readonly BigInteger[] Value={ 136101521L,153171190210231253L,231253276300325351L,BigInteger.Parse("86190394699010351081"),BigInteger.Parse("185281872118915191101930619503"),BigInteger.Parse("193061950319701199002010020301"),BigInteger.Parse("225782279123005232202343623653"),BigInteger.Parse("385033878139060393403962139903") };
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
public class A105297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105297Inst Instance=new A105297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105298
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1596165317111770183018911953"),BigInteger.Parse("6216632864416555667067866903"),BigInteger.Parse("33930341913445334716349803524535511"),BigInteger.Parse("38226385033878139060393403962139903"),BigInteger.Parse("1066530106799110694531070916107238010738451075311"),BigInteger.Parse("1119756112125311227511124250112575011272511128753") };
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
public class A105298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105298Inst Instance=new A105298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105299
{
public static readonly BigInteger[] Value={ BigInteger.Parse("105120136153171190210231"),BigInteger.Parse("351378406435465496528561"),BigInteger.Parse("8425584666850788549185905863208673687153"),BigInteger.Parse("649230650370651511652653653796654940656085657231") };
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
public class A105299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105299Inst Instance=new A105299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105300
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1178111628114761132511175110261087810731"),BigInteger.Parse("779376778128776881775635774390773146771903770661"),BigInteger.Parse("852165850860849556848253846951845650844350843051") };
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
public class A105300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105300Inst Instance=new A105300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105301
{
public static readonly BigInteger[] Value={ BigInteger.Parse("7140702169036786667065556441"),BigInteger.Parse("16110159311575315576154001522515051"),BigInteger.Parse("47586472784697146665463604605645753"),BigInteger.Parse("55278549465461554285539565362853301") };
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
public class A105301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105301Inst Instance=new A105301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105302
{
public static readonly BigInteger[] Value={ 665545362821L,496465435406378351L,946903861820780741L,BigInteger.Parse("112810811035990946903"),BigInteger.Parse("195318911830177017111653"),BigInteger.Parse("382837413655357034863403"),BigInteger.Parse("133661320313041128801272012561") };
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
public class A105302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105302Inst Instance=new A105302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105303
{
public static readonly BigInteger[] Value={ BigInteger.Parse("19531891183017701711"),BigInteger.Parse("30032926285027752701"),BigInteger.Parse("4075540470401863990339621"),BigInteger.Parse("6570365341649806462064261"),BigInteger.Parse("7277172390720107163171253"),BigInteger.Parse("8715386736863208590585491"),BigInteger.Parse("190653190036189420188805188191") };
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
public class A105303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105303Inst Instance=new A105303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105304
{
public static readonly BigInteger[] Value={ 10631L,13612010591L,2926285027752701L,4656456044654371L,13530133661320313041UL,BigInteger.Parse("29890296462940329161"),BigInteger.Parse("34980347163445334191"),BigInteger.Parse("40755404704018639903"),BigInteger.Parse("52650523265200351681"),BigInteger.Parse("52975526505232652003") };
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
public class A105304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105304Inst Instance=new A105304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105305
{
public static readonly long[] Value={ 631L,1063L,276253231L,535652535151L,775076267503L,141961402813861L,162901611015931L,199001970119503L,326403238532131L,460564575345451L,593405899658653L,705007012569751L,723907201071631L,918069137890951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105305Inst : IEnumerable<long>
{
public static readonly long[] Value=A105305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105305.Bytes);
public long this[int i]=>Value[i];

public static A105305Inst Instance=new A105305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105306
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,5L,3L,1L,8L,12L,9L,4L,1L,16L,28L,25L,14L,5L,1L,32L,64L,66L,44L,20L,6L,1L,64L,144L,168L,129L,70L,27L,7L,1L,128L,320L,416L,360L,225L,104L,35L,8L,1L,256L,704L,1008L,968L,681L,363L,147L,44L,9L,1L,512L,1536L,2400L,2528L,1970L,1182L,553L,200L,54L,10L,1L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105306Inst : IEnumerable<long>
{
public static readonly long[] Value=A105306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105306.Bytes);
public long this[int i]=>Value[i];

public static A105306Inst Instance=new A105306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105307
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,2L,2L,1L,-1L,1L,2L,3L,3L,1L,4L,2L,4L,3L,2L,1L,-1L,-1L,2L,4L,4L,1L,6L,2L,4L,3L,2L,3L,-1L,3L,3L,3L,6L,2L,6L,1L,5L,5L,3L,1L,-1L,3L,-1L,3L,4L,2L,7L,4L,-1L,5L,3L,2L,-1L,2L,3L,5L,6L,3L,6L,3L,5L,5L,7L,2L,-1L,2L,4L,-1L,5L,4L,7L,2L,9L,7L,3L,1L,-1L,4L,3L,4L,9L,2L,11L,-1L,6L,4L,2L,6L,-1L,4L,5L,6L,-1L,2L,7L,3L,7L,7L,3L,2L,-1L,2L,-1L,5L,-1L,2L,9L,4L,6L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105307Inst : IEnumerable<long>
{
public static readonly long[] Value=A105307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105307.Bytes);
public long this[int i]=>Value[i];

public static A105307Inst Instance=new A105307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105308
{
public static readonly long[] Value={ 4L,6L,11L,45L,1408L,13313L,41752L,142122836L,48792948403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105308Inst : IEnumerable<long>
{
public static readonly long[] Value=A105308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105308.Bytes);
public long this[int i]=>Value[i];

public static A105308Inst Instance=new A105308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105309
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,20L,41L,85L,178L,369L,769L,1600L,3329L,6929L,14418L,30005L,62441L,129940L,270409L,562725L,1171042L,2436961L,5071361L,10553600L,21962241L,45703841L,95110562L,197926885L,411889609L,857150100L,1783745641L,3712008565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105309Inst : IEnumerable<long>
{
public static readonly long[] Value=A105309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105309.Bytes);
public long this[int i]=>Value[i];

public static A105309Inst Instance=new A105309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105310
{
public static readonly BigInteger[] Value={ 1L,1122L,111222333L,1111222233334444L,BigInteger.Parse("1111122222333334444455555"),BigInteger.Parse("111111222222333333444444555555666666"),BigInteger.Parse("1111111222222233333334444444555555566666667777777") };
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
public class A105310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105310Inst Instance=new A105310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105311
{
public static readonly BigInteger[] Value={ 1L,1212L,123123123L,1234123412341234L,12345123451234512345UL,BigInteger.Parse("123456123456123456123456123456123456"),BigInteger.Parse("1234567123456712345671234567123456712345671234567") };
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
public class A105311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105311.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105311Inst Instance=new A105311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105312
{
public static readonly long[] Value={ 1L,16L,65535L,21523360L,1431655765L,38146972656L,564221981491L,5538821761600L,40210710958665L,231627523606480L,1111111111111111L,4594972986357216L,16807659899548765L,55451384098598320L,167534872139182395L,469172025408063616L,1229782938247303441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105312Inst : IEnumerable<long>
{
public static readonly long[] Value=A105312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105312.Bytes);
public long this[int i]=>Value[i];

public static A105312Inst Instance=new A105312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105313
{
public static readonly long[] Value={ 1L,1L,4L,3L,2L,1L,4L,3L,2L,4L,3L,2L,3L,2L,1L,4L,2L,1L,4L,3L,1L,1L,4L,3L,2L,4L,3L,2L,3L,2L,1L,4L,2L,1L,4L,3L,1L,4L,3L,2L,3L,2L,1L,4L,2L,1L,4L,3L,1L,3L,2L,1L,4L,2L,1L,4L,3L,1L,4L,2L,1L,4L,3L,1L,4L,3L,2L,3L,2L,1L,4L,3L,1L,4L,3L,2L,3L,2L,1L,4L,2L,1L,4L,3L,2L,1L,4L,3L,2L,4L,3L,2L,3L,2L,1L,4L,2L,1L,4L,3L,1L,4L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105313Inst : IEnumerable<long>
{
public static readonly long[] Value=A105313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105313.Bytes);
public long this[int i]=>Value[i];

public static A105313Inst Instance=new A105313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105314
{
public static readonly long[] Value={ 1L,4L,9L,22L,40L,62L,88L,118L,152L,190L,253L,322L,397L,478L,565L,658L,757L,862L,973L,1090L,1213L,1342L,1477L,1618L,1765L,1918L,2077L,2242L,2413L,2590L,2773L,2986L,3246L,3514L,3790L,4074L,4366L,4666L,4974L,5290L,5614L,5946L,6286L,6634L,6990L,7354L,7726L,8106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105314Inst : IEnumerable<long>
{
public static readonly long[] Value=A105314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105314.Bytes);
public long this[int i]=>Value[i];

public static A105314Inst Instance=new A105314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105315
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,2L,3L,3L,4L,4L,1L,2L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,4L,1L,1L,1L,2L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,4L,1L,1L,2L,3L,3L,4L,4L,3L,4L,4L,4L,1L,1L,3L,4L,4L,4L,1L,1L,4L,1L,1L,1L,2L,3L,2L,3L,1L,2L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,4L,1L,1L,2L,3L,3L,4L,4L,3L,4L,4L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105315Inst : IEnumerable<long>
{
public static readonly long[] Value=A105315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105315.Bytes);
public long this[int i]=>Value[i];

public static A105315Inst Instance=new A105315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105316
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,2L,3L,3L,4L,1L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,1L,3L,1L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,1L,3L,2L,3L,3L,4L,3L,4L,1L,3L,3L,4L,1L,3L,1L,3L,2L,3L,1L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,1L,3L,2L,3L,3L,4L,3L,4L,1L,3L,3L,4L,1L,3L,1L,3L,2L,3L,2L,3L,3L,4L,3L,4L,1L,3L,3L,4L,1L,3L,1L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105316Inst : IEnumerable<long>
{
public static readonly long[] Value=A105316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105316.Bytes);
public long this[int i]=>Value[i];

public static A105316Inst Instance=new A105316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105317
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,13L,16L,21L,25L,27L,32L,34L,55L,64L,81L,89L,125L,128L,144L,169L,233L,243L,256L,377L,441L,512L,610L,625L,729L,987L,1024L,1156L,1597L,2048L,2187L,2197L,2584L,3025L,3125L,4096L,4181L,6561L,6765L,7921L,8192L,9261L,10946L,15625L,16384L,17711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105317Inst : IEnumerable<long>
{
public static readonly long[] Value=A105317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105317.Bytes);
public long this[int i]=>Value[i];

public static A105317Inst Instance=new A105317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105318
{
public static readonly long[] Value={ 5L,3L,271L,169219L,356498179L,2500282512131L,20594058719087111L,2185103796349763249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105318Inst : IEnumerable<long>
{
public static readonly long[] Value=A105318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105318.Bytes);
public long this[int i]=>Value[i];

public static A105318Inst Instance=new A105318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105319
{
public static readonly long[] Value={ 1L,2L,4L,8L,20L,42L,95L,201L,465L,1014L,2292L,5014L,11043L,23594L,49910L,102699L,207520L,408597L,788081L,1484174L,2738264L,4944037L,8755686L,15208359L,25952790L,43527033L,71841425L,116752322L,187018934L,295451249L,460722893L,709561513L,1080061323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105319Inst : IEnumerable<long>
{
public static readonly long[] Value=A105319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105319.Bytes);
public long this[int i]=>Value[i];

public static A105319Inst Instance=new A105319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105320
{
public static readonly long[] Value={ 31L,41L,59L,26L,53L,58L,97L,93L,23L,84L,62L,64L,33L,83L,27L,95L,2L,88L,41L,97L,16L,93L,99L,37L,51L,5L,82L,9L,74L,94L,45L,92L,30L,78L,16L,40L,62L,86L,20L,89L,98L,62L,80L,34L,82L,53L,42L,11L,70L,67L,98L,21L,48L,8L,65L,13L,28L,23L,6L,64L,70L,93L,84L,46L,9L,55L,5L,82L,23L,17L,25L,35L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105320Inst : IEnumerable<long>
{
public static readonly long[] Value=A105320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105320.Bytes);
public long this[int i]=>Value[i];

public static A105320Inst Instance=new A105320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105321
{
public static readonly long[] Value={ 1L,3L,4L,6L,6L,6L,8L,12L,10L,6L,8L,12L,12L,12L,16L,24L,18L,6L,8L,12L,12L,12L,16L,24L,20L,12L,16L,24L,24L,24L,32L,48L,34L,6L,8L,12L,12L,12L,16L,24L,20L,12L,16L,24L,24L,24L,32L,48L,36L,12L,16L,24L,24L,24L,32L,48L,40L,24L,32L,48L,48L,48L,64L,96L,66L,6L,8L,12L,12L,12L,16L,24L,20L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105321Inst : IEnumerable<long>
{
public static readonly long[] Value=A105321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105321.Bytes);
public long this[int i]=>Value[i];

public static A105321Inst Instance=new A105321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105322
{
public static readonly BigInteger[] Value={ 73L,7993L,799993L,7999993L,79999999993L,7999999999993L,79999999999993L,BigInteger.Parse("7999999999999999999999999999999999999993"),BigInteger.Parse("7999999999999999999999999999999999999999999999993") };
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
public class A105322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105322Inst Instance=new A105322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105323
{
public static readonly BigInteger[] Value={ 861L,8241L,82000041L,8200000041L,82000000041L,8200000000041L,BigInteger.Parse("8200000000000000000041"),BigInteger.Parse("8200000000000000000000041"),BigInteger.Parse("8200000000000000000000000000000000000000041") };
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
public class A105323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105323Inst Instance=new A105323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105324
{
public static readonly long[] Value={ 6L,73L,483L,4074L,4473L,4623L,7993L,42813L,69855L,253782L,799993L,7999993L,46000023L,426000213L,4600000023L,6718967838L,42600000213L,46000000023L,79999999993L,426000000213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105324Inst : IEnumerable<long>
{
public static readonly long[] Value=A105324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105324.Bytes);
public long this[int i]=>Value[i];

public static A105324Inst Instance=new A105324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105325
{
public static readonly long[] Value={ 27L,18L,28L,18L,28L,45L,90L,45L,23L,53L,60L,28L,74L,71L,35L,26L,62L,49L,77L,57L,24L,70L,93L,69L,99L,59L,57L,49L,66L,96L,76L,27L,72L,40L,76L,63L,3L,53L,54L,75L,94L,57L,13L,82L,17L,85L,25L,16L,64L,27L,42L,74L,66L,39L,19L,32L,0L,30L,59L,92L,18L,17L,41L,35L,96L,62L,90L,43L,57L,29L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105325Inst : IEnumerable<long>
{
public static readonly long[] Value=A105325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105325.Bytes);
public long this[int i]=>Value[i];

public static A105325Inst Instance=new A105325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105326
{
public static readonly long[] Value={ 58L,59L,87L,44L,82L,4L,88L,38L,47L,38L,22L,93L,8L,54L,63L,21L,65L,38L,19L,54L,41L,64L,93L,7L,50L,65L,39L,59L,41L,91L,22L,20L,3L,18L,93L,3L,66L,39L,75L,65L,93L,19L,94L,17L,0L,38L,67L,28L,34L,95L,40L,96L,14L,47L,84L,45L,28L,53L,66L,56L,89L,11L,25L,82L,6L,17L,96L,25L,80L,46L,25L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105326Inst : IEnumerable<long>
{
public static readonly long[] Value=A105326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105326.Bytes);
public long this[int i]=>Value[i];

public static A105326Inst Instance=new A105326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105327
{
public static readonly long[] Value={ 0L,1L,2L,115L,1626L,5370L,5371L,5570L,5571L,6170L,6171L,40854L,373369L,373469L,419386L,419658L,419685L,889609L,889619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105327Inst : IEnumerable<long>
{
public static readonly long[] Value=A105327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105327.Bytes);
public long this[int i]=>Value[i];

public static A105327Inst Instance=new A105327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105328
{
public static readonly long[] Value={ 85L,39L,73L,42L,22L,67L,35L,67L,6L,54L,63L,55L,8L,69L,54L,65L,74L,49L,50L,34L,88L,85L,35L,76L,51L,14L,96L,18L,79L,60L,11L,30L,17L,92L,28L,61L,11L,57L,33L,8L,7L,57L,25L,63L,86L,97L,10L,47L,39L,43L,91L,37L,74L,94L,25L,11L,67L,74L,67L,64L,63L,21L,18L,75L,90L,69L,60L,23L,99L,6L,18L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105328Inst : IEnumerable<long>
{
public static readonly long[] Value=A105328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105328.Bytes);
public long this[int i]=>Value[i];

public static A105328Inst Instance=new A105328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105329
{
public static readonly long[] Value={ 1L,2L,6L,7L,12L,14L,181L,1053L,1057L,2614L,40089L,40114L,40117L,40119L,100346L,100352L,100358L,251707L,251742L,251743L,251754L,251757L,1617173L,4124458L,10553513L,27067262L,27067272L,179992838L,179993008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105329Inst : IEnumerable<long>
{
public static readonly long[] Value=A105329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105329.Bytes);
public long this[int i]=>Value[i];

public static A105329Inst Instance=new A105329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105330
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,10L,13L,14L,26L,40L,49L,50L,110L,142L,170L,315L,349L,502L,842L,1251L,1630L,2054L,2906L,3482L,5110L,5227L,5620L,8224L,8788L,8912L,13027L,16243L,17222L,28557L,46532L,54974L,92866L,93093L,120855L,155416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105330Inst : IEnumerable<long>
{
public static readonly long[] Value=A105330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105330.Bytes);
public long this[int i]=>Value[i];

public static A105330Inst Instance=new A105330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105331
{
public static readonly BigInteger[] Value={ 3L,14L,52L,184L,656L,34688L,2118656L,134438912L,537346048L,9007202811510784L,BigInteger.Parse("2417851639318318791262208"),BigInteger.Parse("633825300114170432793740312576"),BigInteger.Parse("2535301200456572518883997515776") };
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
public class A105331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105331Inst Instance=new A105331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105332
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L,5L,7L,2L,6L,3L,1L,0L,0L,1L,3L,6L,2L,7L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105332Inst : IEnumerable<long>
{
public static readonly long[] Value=A105332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105332.Bytes);
public long this[int i]=>Value[i];

public static A105332Inst Instance=new A105332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105333
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,5L,12L,4L,13L,7L,2L,14L,11L,9L,8L,8L,9L,11L,14L,2L,7L,13L,4L,12L,5L,15L,10L,6L,3L,1L,0L,0L,1L,3L,6L,10L,15L,5L,12L,4L,13L,7L,2L,14L,11L,9L,8L,8L,9L,11L,14L,2L,7L,13L,4L,12L,5L,15L,10L,6L,3L,1L,0L,0L,1L,3L,6L,10L,15L,5L,12L,4L,13L,7L,2L,14L,11L,9L,8L,8L,9L,11L,14L,2L,7L,13L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105333Inst : IEnumerable<long>
{
public static readonly long[] Value=A105333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105333.Bytes);
public long this[int i]=>Value[i];

public static A105333Inst Instance=new A105333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105334
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,4L,13L,23L,2L,14L,27L,9L,24L,8L,25L,11L,30L,18L,7L,29L,20L,12L,5L,31L,26L,22L,19L,17L,16L,16L,17L,19L,22L,26L,31L,5L,12L,20L,29L,7L,18L,30L,11L,25L,8L,24L,9L,27L,14L,2L,23L,13L,4L,28L,21L,15L,10L,6L,3L,1L,0L,0L,1L,3L,6L,10L,15L,21L,28L,4L,13L,23L,2L,14L,27L,9L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105334Inst : IEnumerable<long>
{
public static readonly long[] Value=A105334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105334.Bytes);
public long this[int i]=>Value[i];

public static A105334Inst Instance=new A105334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105335
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,2L,14L,27L,41L,56L,8L,25L,43L,62L,18L,39L,61L,20L,44L,5L,31L,58L,22L,51L,17L,48L,16L,49L,19L,54L,26L,63L,37L,12L,52L,29L,7L,50L,30L,11L,57L,40L,24L,9L,59L,46L,34L,23L,13L,4L,60L,53L,47L,42L,38L,35L,33L,32L,32L,33L,35L,38L,42L,47L,53L,60L,4L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105335Inst : IEnumerable<long>
{
public static readonly long[] Value=A105335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105335.Bytes);
public long this[int i]=>Value[i];

public static A105335Inst Instance=new A105335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105336
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,8L,25L,43L,62L,82L,103L,125L,20L,44L,69L,95L,122L,22L,51L,81L,112L,16L,49L,83L,118L,26L,63L,101L,12L,52L,93L,7L,50L,94L,11L,57L,104L,24L,73L,123L,46L,98L,23L,77L,4L,60L,117L,47L,106L,38L,99L,33L,96L,32L,97L,35L,102L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105336Inst : IEnumerable<long>
{
public static readonly long[] Value=A105336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105336.Bytes);
public long this[int i]=>Value[i];

public static A105336Inst Instance=new A105336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105337
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,20L,44L,69L,95L,122L,150L,179L,209L,240L,16L,49L,83L,118L,154L,191L,229L,12L,52L,93L,135L,178L,222L,11L,57L,104L,152L,201L,251L,46L,98L,151L,205L,4L,60L,117L,175L,234L,38L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105337Inst : IEnumerable<long>
{
public static readonly long[] Value=A105337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105337.Bytes);
public long this[int i]=>Value[i];

public static A105337Inst Instance=new A105337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105338
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,16L,49L,83L,118L,154L,191L,229L,268L,308L,349L,391L,434L,478L,11L,57L,104L,152L,201L,251L,302L,354L,407L,461L,4L,60L,117L,175L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105338Inst : IEnumerable<long>
{
public static readonly long[] Value=A105338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105338.Bytes);
public long this[int i]=>Value[i];

public static A105338Inst Instance=new A105338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105339
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,528L,561L,595L,630L,666L,703L,741L,780L,820L,861L,903L,946L,990L,11L,57L,104L,152L,201L,251L,302L,354L,407L,461L,516L,572L,629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105339Inst : IEnumerable<long>
{
public static readonly long[] Value=A105339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105339.Bytes);
public long this[int i]=>Value[i];

public static A105339Inst Instance=new A105339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105340
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,528L,561L,595L,630L,666L,703L,741L,780L,820L,861L,903L,946L,990L,1035L,1081L,1128L,1176L,1225L,1275L,1326L,1378L,1431L,1485L,1540L,1596L,1653L,1711L,1770L,1830L,1891L,1953L,2016L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105340Inst : IEnumerable<long>
{
public static readonly long[] Value=A105340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105340.Bytes);
public long this[int i]=>Value[i];

public static A105340Inst Instance=new A105340Inst();

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