using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198805
{
public static readonly long[] Value={ 1L,0L,0L,30L,0L,360L,7650L,0L,302400L,4544400L,11226600L,324324000L,4310633250L,24324300000L,437404968000L,5634178329780L,45972927000000L,697866761592000L,8962716395833200L,88725951057744000L,1258898645656852200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198805Inst : IEnumerable<long>
{
public static readonly long[] Value=A198805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198805.Bytes);
public long this[int i]=>Value[i];

public static A198805Inst Instance=new A198805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198806
{
public static readonly long[] Value={ 1L,0L,14L,0L,546L,0L,32900L,10080L,2570050L,2540160L,238935564L,465696000L,25142196156L,76886409600L,2900343069624L,12211317518400L,359067702643650L,1915829643087360L,47006105030584700L,300455419743198720L,6437718469449262996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198806Inst : IEnumerable<long>
{
public static readonly long[] Value=A198806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198806.Bytes);
public long this[int i]=>Value[i];

public static A198806Inst Instance=new A198806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198807
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6227020800L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198807Inst : IEnumerable<long>
{
public static readonly long[] Value=A198807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198807.Bytes);
public long this[int i]=>Value[i];

public static A198807Inst Instance=new A198807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198808
{
public static readonly long[] Value={ 1L,0L,12L,24L,396L,2160L,23160L,186480L,1845900L,17213280L,171575712L,1703560320L,17365421304L,178323713568L,1856554560432L,19487791106784L,206411964321420L,2201711191213248L,23642813637773616L,255355132936441824L,2772650461148938656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198808Inst : IEnumerable<long>
{
public static readonly long[] Value=A198808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198808.Bytes);
public long this[int i]=>Value[i];

public static A198808Inst Instance=new A198808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198809
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,39916800L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198809Inst : IEnumerable<long>
{
public static readonly long[] Value=A198809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198809.Bytes);
public long this[int i]=>Value[i];

public static A198809Inst Instance=new A198809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198810
{
public static readonly long[] Value={ 1L,0L,0L,18L,0L,0L,2430L,0L,0L,640080L,0L,0L,215488350L,0L,0L,84569753268L,0L,0L,36905812607664L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198810Inst : IEnumerable<long>
{
public static readonly long[] Value=A198810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198810.Bytes);
public long this[int i]=>Value[i];

public static A198810Inst Instance=new A198810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198811
{
public static readonly long[] Value={ 2L,3L,1L,3L,5L,8L,9L,3L,4L,9L,0L,4L,8L,4L,8L,7L,9L,2L,2L,4L,4L,5L,3L,0L,4L,1L,3L,3L,6L,6L,6L,6L,7L,2L,8L,0L,7L,6L,1L,5L,6L,6L,4L,7L,2L,0L,7L,2L,0L,6L,7L,7L,3L,7L,5L,2L,1L,7L,0L,4L,8L,3L,6L,4L,1L,9L,2L,1L,9L,6L,8L,8L,7L,1L,5L,5L,4L,2L,7L,3L,4L,2L,5L,0L,0L,0L,1L,1L,5L,7L,7L,6L,3L,7L,2L,3L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198811Inst : IEnumerable<long>
{
public static readonly long[] Value=A198811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198811.Bytes);
public long this[int i]=>Value[i];

public static A198811Inst Instance=new A198811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198812
{
public static readonly long[] Value={ 2L,1L,6L,0L,8L,1L,9L,4L,5L,8L,1L,0L,8L,3L,9L,5L,5L,4L,4L,9L,4L,7L,6L,8L,7L,7L,6L,3L,5L,0L,8L,3L,4L,8L,3L,3L,5L,9L,8L,2L,3L,6L,0L,1L,7L,6L,0L,5L,1L,8L,3L,5L,5L,9L,7L,2L,1L,1L,6L,1L,4L,5L,3L,0L,2L,5L,2L,0L,5L,1L,4L,2L,3L,6L,1L,2L,1L,3L,2L,4L,6L,3L,5L,9L,5L,1L,9L,1L,7L,5L,7L,1L,7L,0L,8L,6L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198812Inst : IEnumerable<long>
{
public static readonly long[] Value=A198812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198812.Bytes);
public long this[int i]=>Value[i];

public static A198812Inst Instance=new A198812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198813
{
public static readonly long[] Value={ 2L,5L,4L,6L,3L,9L,0L,7L,7L,5L,8L,0L,2L,8L,8L,8L,7L,7L,6L,8L,5L,6L,1L,7L,2L,7L,0L,9L,3L,9L,3L,6L,1L,2L,8L,9L,5L,0L,3L,7L,3L,3L,5L,1L,2L,3L,1L,9L,1L,4L,5L,9L,0L,3L,8L,1L,8L,4L,1L,2L,9L,9L,7L,9L,3L,4L,1L,7L,9L,8L,3L,1L,9L,5L,8L,4L,9L,9L,6L,8L,7L,3L,0L,0L,1L,2L,8L,1L,7L,6L,7L,8L,9L,1L,7L,1L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198813Inst : IEnumerable<long>
{
public static readonly long[] Value=A198813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198813.Bytes);
public long this[int i]=>Value[i];

public static A198813Inst Instance=new A198813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198814
{
public static readonly long[] Value={ 1L,1L,1L,7L,8L,9L,0L,5L,8L,7L,7L,5L,6L,7L,5L,3L,7L,5L,9L,7L,9L,6L,8L,8L,7L,1L,6L,9L,5L,7L,9L,1L,6L,2L,9L,5L,6L,1L,8L,6L,1L,7L,5L,8L,7L,0L,3L,7L,5L,4L,0L,6L,9L,4L,6L,9L,4L,6L,7L,1L,9L,3L,0L,1L,4L,5L,1L,3L,9L,9L,2L,4L,3L,9L,1L,1L,8L,6L,3L,1L,6L,2L,9L,5L,3L,1L,4L,1L,9L,6L,9L,3L,8L,1L,0L,2L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198814Inst : IEnumerable<long>
{
public static readonly long[] Value=A198814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198814.Bytes);
public long this[int i]=>Value[i];

public static A198814Inst Instance=new A198814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198815
{
public static readonly long[] Value={ 2L,7L,8L,3L,1L,1L,4L,7L,5L,6L,5L,0L,3L,0L,2L,0L,3L,0L,0L,6L,3L,9L,9L,2L,2L,7L,2L,9L,2L,3L,6L,9L,5L,8L,5L,1L,8L,5L,9L,8L,8L,1L,3L,0L,7L,0L,3L,5L,6L,5L,4L,2L,1L,3L,4L,2L,4L,9L,6L,8L,8L,7L,3L,8L,8L,0L,8L,9L,3L,7L,9L,2L,4L,2L,7L,8L,6L,8L,9L,4L,7L,2L,5L,9L,6L,6L,3L,7L,0L,1L,3L,5L,1L,5L,9L,5L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198815Inst : IEnumerable<long>
{
public static readonly long[] Value=A198815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198815.Bytes);
public long this[int i]=>Value[i];

public static A198815Inst Instance=new A198815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198816
{
public static readonly long[] Value={ 1L,1L,7L,6L,5L,0L,1L,9L,3L,9L,9L,0L,1L,8L,3L,2L,4L,0L,0L,4L,4L,7L,3L,7L,7L,2L,6L,8L,7L,3L,1L,0L,4L,0L,9L,8L,6L,6L,2L,3L,7L,1L,2L,3L,5L,8L,9L,8L,1L,2L,9L,2L,4L,1L,4L,4L,2L,8L,6L,6L,0L,1L,8L,4L,9L,8L,5L,8L,6L,6L,3L,7L,4L,4L,1L,5L,1L,3L,5L,9L,0L,7L,3L,4L,3L,3L,0L,0L,4L,7L,1L,5L,7L,1L,5L,9L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198816Inst : IEnumerable<long>
{
public static readonly long[] Value=A198816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198816.Bytes);
public long this[int i]=>Value[i];

public static A198816Inst Instance=new A198816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198817
{
public static readonly long[] Value={ 1L,4L,5L,4L,6L,1L,8L,9L,2L,9L,2L,0L,8L,1L,1L,1L,2L,7L,8L,7L,9L,5L,8L,4L,2L,2L,2L,3L,3L,7L,8L,0L,9L,3L,2L,9L,1L,0L,4L,3L,2L,4L,7L,9L,6L,7L,5L,8L,6L,4L,2L,5L,8L,2L,7L,5L,9L,7L,3L,1L,8L,4L,8L,7L,1L,9L,5L,3L,9L,1L,2L,9L,9L,6L,9L,4L,2L,5L,4L,2L,9L,8L,5L,1L,4L,6L,0L,4L,8L,1L,3L,4L,3L,9L,9L,0L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198817Inst : IEnumerable<long>
{
public static readonly long[] Value=A198817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198817.Bytes);
public long this[int i]=>Value[i];

public static A198817Inst Instance=new A198817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198818
{
public static readonly long[] Value={ 1L,6L,9L,5L,7L,0L,5L,0L,9L,9L,0L,8L,3L,0L,6L,6L,8L,0L,6L,1L,5L,7L,4L,9L,1L,2L,9L,9L,6L,4L,4L,3L,9L,7L,7L,9L,7L,5L,4L,3L,8L,8L,9L,7L,4L,2L,2L,4L,4L,5L,8L,9L,1L,5L,7L,9L,2L,6L,0L,8L,8L,9L,9L,4L,4L,5L,4L,2L,8L,9L,0L,4L,4L,4L,7L,7L,2L,1L,8L,5L,3L,9L,1L,2L,0L,8L,1L,3L,4L,5L,0L,2L,5L,5L,7L,2L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198818Inst : IEnumerable<long>
{
public static readonly long[] Value=A198818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198818.Bytes);
public long this[int i]=>Value[i];

public static A198818Inst Instance=new A198818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198819
{
public static readonly long[] Value={ 1L,9L,1L,4L,0L,2L,0L,6L,1L,9L,0L,2L,5L,9L,8L,5L,3L,9L,1L,1L,9L,3L,9L,6L,3L,8L,3L,0L,1L,7L,1L,0L,9L,8L,0L,4L,2L,9L,3L,7L,9L,5L,9L,9L,7L,3L,2L,8L,1L,0L,6L,5L,5L,8L,5L,5L,0L,8L,5L,5L,4L,0L,9L,1L,0L,8L,0L,6L,4L,2L,8L,4L,8L,6L,2L,2L,4L,4L,5L,0L,3L,0L,8L,1L,9L,9L,2L,9L,7L,0L,5L,4L,9L,7L,0L,8L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198819Inst : IEnumerable<long>
{
public static readonly long[] Value=A198819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198819.Bytes);
public long this[int i]=>Value[i];

public static A198819Inst Instance=new A198819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198820
{
public static readonly long[] Value={ 8L,0L,9L,3L,2L,4L,5L,6L,9L,9L,4L,6L,0L,6L,7L,2L,0L,8L,5L,3L,6L,3L,2L,9L,7L,1L,4L,1L,9L,0L,7L,3L,1L,9L,0L,5L,9L,6L,0L,0L,5L,7L,7L,4L,4L,5L,0L,7L,6L,0L,6L,8L,4L,3L,9L,2L,2L,8L,5L,1L,1L,8L,7L,2L,6L,5L,7L,3L,7L,7L,0L,8L,5L,5L,0L,6L,2L,5L,4L,7L,9L,6L,1L,9L,5L,5L,9L,3L,2L,1L,9L,5L,4L,4L,1L,5L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198820Inst : IEnumerable<long>
{
public static readonly long[] Value=A198820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198820.Bytes);
public long this[int i]=>Value[i];

public static A198820Inst Instance=new A198820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198821
{
public static readonly long[] Value={ 1L,2L,6L,5L,4L,2L,3L,7L,0L,5L,8L,6L,9L,3L,3L,4L,9L,5L,5L,9L,4L,9L,5L,6L,9L,3L,2L,5L,7L,5L,5L,3L,2L,7L,0L,5L,6L,0L,7L,1L,8L,3L,2L,1L,7L,6L,1L,7L,7L,6L,7L,9L,8L,0L,5L,4L,1L,8L,2L,7L,8L,3L,4L,7L,4L,4L,9L,1L,6L,3L,5L,0L,6L,5L,0L,1L,4L,0L,7L,1L,5L,6L,7L,5L,2L,7L,0L,8L,1L,8L,7L,1L,3L,1L,5L,9L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198821Inst : IEnumerable<long>
{
public static readonly long[] Value=A198821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198821.Bytes);
public long this[int i]=>Value[i];

public static A198821Inst Instance=new A198821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198822
{
public static readonly long[] Value={ 1L,4L,7L,8L,1L,7L,0L,2L,6L,6L,4L,3L,0L,3L,2L,1L,2L,8L,3L,3L,1L,0L,6L,2L,4L,1L,7L,5L,3L,4L,7L,7L,4L,6L,8L,0L,8L,0L,2L,6L,8L,2L,3L,5L,1L,7L,8L,0L,1L,5L,1L,4L,9L,2L,9L,9L,3L,1L,3L,6L,1L,2L,7L,1L,5L,4L,6L,5L,6L,9L,3L,0L,9L,7L,6L,7L,0L,9L,5L,1L,8L,9L,1L,9L,8L,7L,5L,2L,2L,1L,3L,6L,5L,6L,9L,6L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198822Inst : IEnumerable<long>
{
public static readonly long[] Value=A198822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198822.Bytes);
public long this[int i]=>Value[i];

public static A198822Inst Instance=new A198822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198823
{
public static readonly long[] Value={ 1L,6L,7L,2L,4L,4L,1L,3L,0L,4L,8L,7L,3L,5L,2L,9L,5L,1L,3L,4L,3L,2L,9L,6L,0L,4L,5L,2L,0L,8L,9L,4L,0L,1L,9L,9L,7L,3L,8L,0L,1L,2L,6L,6L,8L,0L,9L,7L,1L,9L,8L,0L,0L,3L,5L,5L,4L,9L,6L,6L,6L,6L,6L,8L,4L,4L,7L,5L,4L,7L,0L,2L,4L,8L,4L,3L,7L,1L,3L,1L,3L,4L,3L,3L,9L,0L,1L,4L,0L,8L,7L,2L,2L,7L,5L,5L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198823Inst : IEnumerable<long>
{
public static readonly long[] Value=A198823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198823.Bytes);
public long this[int i]=>Value[i];

public static A198823Inst Instance=new A198823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198824
{
public static readonly long[] Value={ 1L,8L,5L,4L,6L,7L,8L,2L,4L,7L,9L,1L,4L,9L,3L,1L,4L,9L,4L,7L,5L,6L,7L,5L,5L,1L,3L,2L,0L,3L,3L,0L,6L,5L,0L,6L,8L,2L,6L,1L,4L,0L,1L,6L,8L,8L,4L,7L,6L,3L,2L,9L,7L,9L,4L,4L,8L,7L,0L,5L,4L,2L,3L,2L,5L,7L,4L,2L,4L,2L,6L,6L,4L,7L,3L,3L,8L,3L,6L,1L,7L,3L,9L,5L,5L,7L,3L,7L,2L,3L,9L,3L,1L,6L,7L,5L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198824Inst : IEnumerable<long>
{
public static readonly long[] Value=A198824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198824.Bytes);
public long this[int i]=>Value[i];

public static A198824Inst Instance=new A198824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198825
{
public static readonly long[] Value={ 7L,1L,4L,6L,2L,1L,0L,5L,7L,7L,7L,9L,2L,8L,3L,5L,7L,1L,3L,0L,7L,6L,0L,2L,6L,8L,1L,4L,9L,2L,2L,6L,1L,1L,5L,1L,3L,1L,7L,1L,8L,9L,3L,0L,0L,0L,0L,5L,5L,8L,0L,5L,6L,5L,3L,8L,1L,1L,2L,8L,4L,2L,0L,0L,8L,7L,1L,9L,2L,0L,8L,9L,2L,5L,7L,3L,5L,9L,3L,6L,7L,9L,3L,6L,9L,5L,7L,0L,7L,1L,1L,9L,2L,8L,0L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198825Inst : IEnumerable<long>
{
public static readonly long[] Value=A198825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198825.Bytes);
public long this[int i]=>Value[i];

public static A198825Inst Instance=new A198825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198826
{
public static readonly long[] Value={ 1L,3L,2L,0L,3L,8L,3L,3L,5L,6L,9L,4L,3L,9L,6L,2L,6L,4L,7L,4L,8L,1L,6L,3L,5L,3L,0L,2L,1L,7L,6L,8L,2L,9L,4L,9L,6L,5L,5L,4L,8L,5L,7L,3L,9L,0L,8L,2L,4L,4L,3L,1L,6L,5L,9L,7L,8L,9L,5L,1L,4L,2L,1L,3L,0L,8L,9L,1L,6L,2L,1L,8L,1L,6L,1L,2L,9L,7L,6L,8L,4L,3L,9L,1L,4L,2L,0L,6L,4L,2L,3L,9L,2L,7L,0L,0L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198826Inst : IEnumerable<long>
{
public static readonly long[] Value=A198826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198826.Bytes);
public long this[int i]=>Value[i];

public static A198826Inst Instance=new A198826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198827
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,9L,0L,0L,6L,7L,0L,2L,6L,9L,1L,7L,2L,0L,7L,3L,6L,5L,4L,2L,3L,8L,3L,9L,7L,6L,4L,5L,8L,0L,0L,0L,0L,4L,0L,9L,1L,5L,3L,4L,5L,8L,9L,6L,7L,2L,7L,2L,0L,3L,0L,6L,2L,9L,6L,2L,2L,0L,6L,8L,9L,0L,0L,5L,8L,5L,3L,4L,3L,4L,9L,3L,0L,6L,8L,8L,1L,8L,1L,7L,9L,7L,0L,3L,2L,3L,2L,6L,4L,3L,8L,0L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198827Inst : IEnumerable<long>
{
public static readonly long[] Value=A198827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198827.Bytes);
public long this[int i]=>Value[i];

public static A198827Inst Instance=new A198827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198828
{
public static readonly long[] Value={ 1L,4L,9L,3L,6L,8L,6L,6L,5L,7L,8L,3L,4L,6L,5L,2L,5L,7L,6L,6L,4L,8L,7L,9L,0L,7L,9L,9L,2L,2L,3L,9L,0L,5L,7L,1L,6L,1L,4L,1L,1L,1L,4L,9L,5L,3L,7L,3L,6L,5L,3L,4L,1L,8L,5L,3L,3L,1L,3L,6L,2L,5L,2L,8L,8L,7L,8L,6L,1L,6L,0L,9L,6L,4L,1L,3L,9L,7L,5L,1L,0L,9L,6L,4L,4L,0L,1L,9L,9L,1L,1L,8L,4L,9L,1L,9L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198828Inst : IEnumerable<long>
{
public static readonly long[] Value=A198828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198828.Bytes);
public long this[int i]=>Value[i];

public static A198828Inst Instance=new A198828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198829
{
public static readonly long[] Value={ 1L,6L,5L,6L,3L,7L,4L,8L,5L,7L,4L,5L,0L,9L,3L,8L,9L,1L,4L,1L,8L,7L,3L,4L,9L,9L,4L,0L,4L,1L,7L,6L,7L,1L,1L,0L,2L,0L,0L,7L,4L,3L,6L,9L,4L,1L,0L,0L,2L,2L,9L,4L,1L,2L,5L,9L,8L,8L,8L,3L,5L,4L,5L,2L,2L,6L,0L,6L,9L,9L,0L,5L,8L,3L,6L,3L,5L,1L,5L,8L,3L,9L,5L,4L,5L,1L,8L,5L,9L,0L,0L,6L,2L,0L,6L,7L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198829Inst : IEnumerable<long>
{
public static readonly long[] Value=A198829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198829.Bytes);
public long this[int i]=>Value[i];

public static A198829Inst Instance=new A198829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198830
{
public static readonly long[] Value={ 1L,8L,1L,2L,0L,0L,6L,2L,8L,9L,8L,3L,9L,4L,2L,3L,4L,2L,8L,9L,7L,7L,3L,2L,0L,9L,3L,8L,2L,4L,0L,6L,6L,7L,8L,4L,8L,6L,2L,7L,8L,5L,7L,2L,9L,8L,9L,1L,9L,1L,5L,8L,1L,1L,2L,0L,8L,2L,3L,6L,5L,5L,0L,1L,7L,8L,3L,0L,9L,3L,4L,7L,2L,9L,7L,5L,3L,6L,4L,2L,7L,1L,5L,3L,8L,6L,1L,9L,9L,7L,6L,0L,5L,9L,2L,2L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198830Inst : IEnumerable<long>
{
public static readonly long[] Value=A198830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198830.Bytes);
public long this[int i]=>Value[i];

public static A198830Inst Instance=new A198830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198831
{
public static readonly long[] Value={ 0L,4L,20L,28L,39L,47L,81L,135L,152L,207L,216L,270L,496L,546L,615L,732L,832L,1148L,1208L,1343L,1391L,1541L,1750L,2000L,2260L,2548L,2575L,2825L,3679L,3807L,4220L,4604L,5076L,5508L,5835L,5859L,6291L,7538L,7656L,8188L,8423L,8712L,8964L,12092L,12205L,12511L,12926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198831Inst : IEnumerable<long>
{
public static readonly long[] Value=A198831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198831.Bytes);
public long this[int i]=>Value[i];

public static A198831Inst Instance=new A198831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198832
{
public static readonly long[] Value={ 1L,2L,6L,8L,10L,12L,13L,19L,26L,31L,33L,39L,40L,43L,46L,52L,68L,72L,78L,84L,90L,93L,95L,105L,109L,133L,139L,149L,152L,162L,176L,180L,190L,202L,211L,219L,231L,243L,265L,269L,272L,306L,330L,336L,341L,346L,351L,356L,366L,393L,407L,422L,436L,446L,450L,467L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198832Inst : IEnumerable<long>
{
public static readonly long[] Value=A198832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198832.Bytes);
public long this[int i]=>Value[i];

public static A198832Inst Instance=new A198832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198833
{
public static readonly long[] Value={ 1L,10L,56L,220L,680L,1771L,4060L,8436L,16215L,29260L,50116L,82160L,129766L,198485L,295240L,428536L,608685L,848046L,1161280L,1565620L,2081156L,2731135L,3542276L,4545100L,5774275L,7268976L,9073260L,11236456L,13813570L,16865705L,20460496L,24672560L,29583961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198833Inst : IEnumerable<long>
{
public static readonly long[] Value=A198833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198833.Bytes);
public long this[int i]=>Value[i];

public static A198833Inst Instance=new A198833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198834
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,6L,10L,16L,26L,42L,68L,110L,178L,288L,466L,754L,1220L,1974L,3194L,5168L,8362L,13530L,21892L,35422L,57314L,92736L,150050L,242786L,392836L,635622L,1028458L,1664080L,2692538L,4356618L,7049156L,11405774L,18454930L,29860704L,48315634L,78176338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198834Inst : IEnumerable<long>
{
public static readonly long[] Value=A198834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198834.Bytes);
public long this[int i]=>Value[i];

public static A198834Inst Instance=new A198834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198835
{
public static readonly long[] Value={ 9L,1L,3L,1L,3L,2L,0L,0L,0L,7L,8L,5L,9L,1L,6L,0L,4L,1L,7L,3L,6L,8L,0L,8L,6L,0L,0L,1L,2L,3L,1L,6L,5L,7L,4L,6L,8L,7L,3L,0L,2L,8L,8L,6L,2L,2L,9L,7L,7L,5L,6L,4L,7L,1L,7L,7L,8L,2L,3L,4L,5L,1L,2L,9L,8L,8L,2L,7L,5L,5L,0L,2L,8L,5L,8L,0L,0L,7L,1L,3L,9L,1L,2L,9L,9L,6L,3L,9L,0L,7L,0L,5L,8L,9L,4L,3L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198835Inst : IEnumerable<long>
{
public static readonly long[] Value=A198835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198835.Bytes);
public long this[int i]=>Value[i];

public static A198835Inst Instance=new A198835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198836
{
public static readonly long[] Value={ 6L,3L,8L,9L,2L,0L,6L,5L,7L,6L,0L,4L,5L,9L,4L,5L,3L,8L,9L,0L,8L,2L,5L,7L,4L,6L,2L,6L,4L,4L,2L,5L,9L,6L,7L,6L,3L,0L,1L,0L,5L,8L,0L,6L,6L,0L,6L,3L,6L,8L,8L,9L,0L,7L,7L,5L,8L,0L,5L,9L,9L,7L,0L,7L,7L,5L,5L,8L,6L,4L,2L,4L,9L,9L,7L,3L,0L,0L,3L,0L,7L,6L,4L,7L,7L,5L,5L,4L,3L,0L,0L,7L,7L,1L,2L,0L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198836Inst : IEnumerable<long>
{
public static readonly long[] Value=A198836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198836.Bytes);
public long this[int i]=>Value[i];

public static A198836Inst Instance=new A198836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198837
{
public static readonly long[] Value={ 1L,3L,8L,0L,3L,4L,3L,5L,1L,9L,9L,5L,5L,4L,3L,1L,1L,4L,4L,2L,0L,6L,9L,4L,9L,1L,5L,7L,5L,5L,6L,8L,8L,1L,5L,5L,7L,1L,5L,5L,6L,4L,6L,4L,6L,9L,7L,8L,5L,3L,6L,8L,3L,2L,8L,5L,5L,3L,7L,1L,2L,9L,3L,9L,9L,6L,5L,2L,9L,7L,9L,7L,3L,9L,9L,1L,0L,4L,3L,4L,5L,9L,1L,3L,8L,5L,1L,7L,4L,0L,7L,2L,4L,5L,9L,2L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198837Inst : IEnumerable<long>
{
public static readonly long[] Value=A198837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198837.Bytes);
public long this[int i]=>Value[i];

public static A198837Inst Instance=new A198837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198838
{
public static readonly long[] Value={ 1L,3L,5L,8L,0L,9L,2L,3L,4L,9L,7L,9L,6L,9L,3L,5L,9L,1L,5L,2L,2L,9L,3L,4L,4L,7L,8L,2L,9L,4L,8L,7L,3L,2L,1L,8L,3L,3L,8L,3L,9L,9L,6L,9L,6L,0L,5L,6L,2L,0L,9L,2L,1L,9L,2L,8L,5L,9L,0L,0L,7L,8L,6L,1L,2L,0L,3L,9L,1L,1L,8L,7L,3L,4L,6L,8L,2L,7L,7L,9L,1L,2L,0L,2L,0L,7L,7L,2L,7L,5L,8L,6L,3L,6L,8L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198838Inst : IEnumerable<long>
{
public static readonly long[] Value=A198838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198838.Bytes);
public long this[int i]=>Value[i];

public static A198838Inst Instance=new A198838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198839
{
public static readonly long[] Value={ 1L,5L,0L,4L,7L,1L,0L,1L,0L,6L,8L,5L,0L,9L,4L,5L,4L,9L,9L,7L,7L,7L,2L,5L,1L,4L,4L,9L,0L,7L,7L,7L,0L,9L,6L,5L,7L,1L,8L,8L,8L,5L,9L,0L,3L,7L,4L,3L,3L,2L,3L,4L,8L,1L,9L,6L,2L,5L,1L,3L,3L,0L,5L,9L,3L,6L,0L,9L,0L,3L,1L,2L,1L,0L,4L,8L,3L,9L,0L,9L,7L,4L,9L,7L,6L,2L,8L,1L,8L,9L,3L,3L,2L,2L,4L,9L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198839Inst : IEnumerable<long>
{
public static readonly long[] Value=A198839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198839.Bytes);
public long this[int i]=>Value[i];

public static A198839Inst Instance=new A198839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198840
{
public static readonly long[] Value={ 1L,6L,4L,4L,6L,4L,7L,2L,7L,4L,3L,1L,3L,4L,6L,2L,7L,1L,7L,7L,1L,4L,6L,4L,2L,3L,2L,5L,5L,6L,8L,1L,5L,9L,2L,4L,6L,7L,0L,5L,8L,7L,0L,1L,4L,1L,3L,4L,1L,8L,6L,0L,7L,1L,5L,0L,7L,2L,8L,0L,1L,8L,6L,7L,6L,3L,9L,9L,6L,8L,8L,5L,4L,0L,8L,5L,6L,3L,4L,9L,7L,8L,2L,1L,7L,1L,1L,6L,4L,8L,5L,9L,3L,7L,8L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198840Inst : IEnumerable<long>
{
public static readonly long[] Value=A198840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198840.Bytes);
public long this[int i]=>Value[i];

public static A198840Inst Instance=new A198840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198841
{
public static readonly long[] Value={ 1L,7L,8L,0L,1L,1L,7L,2L,2L,3L,4L,1L,3L,3L,4L,6L,8L,8L,9L,5L,9L,0L,3L,8L,5L,8L,7L,8L,9L,0L,2L,8L,3L,5L,8L,8L,2L,5L,4L,6L,2L,0L,1L,9L,4L,0L,3L,4L,4L,7L,7L,3L,5L,4L,7L,0L,5L,6L,8L,9L,9L,7L,1L,0L,4L,6L,8L,8L,4L,3L,4L,3L,5L,8L,3L,2L,6L,7L,0L,9L,7L,7L,0L,2L,8L,8L,5L,3L,0L,2L,8L,5L,8L,8L,8L,7L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198841Inst : IEnumerable<long>
{
public static readonly long[] Value=A198841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198841.Bytes);
public long this[int i]=>Value[i];

public static A198841Inst Instance=new A198841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198842
{
public static readonly long[] Value={ 1L,0L,2L,9L,7L,0L,4L,0L,0L,0L,7L,3L,6L,0L,5L,4L,5L,5L,8L,4L,1L,1L,6L,7L,9L,2L,6L,7L,9L,8L,2L,9L,0L,6L,9L,5L,8L,9L,4L,5L,5L,8L,8L,8L,3L,4L,8L,1L,5L,9L,5L,7L,8L,4L,0L,6L,8L,8L,0L,7L,9L,2L,9L,7L,4L,9L,5L,7L,2L,7L,6L,2L,9L,7L,4L,3L,4L,7L,2L,6L,5L,2L,4L,8L,3L,5L,7L,7L,1L,8L,8L,8L,9L,1L,0L,5L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198842Inst : IEnumerable<long>
{
public static readonly long[] Value=A198842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198842.Bytes);
public long this[int i]=>Value[i];

public static A198842Inst Instance=new A198842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198843
{
public static readonly long[] Value={ 8L,3L,2L,2L,9L,6L,4L,6L,2L,4L,2L,0L,4L,5L,4L,8L,1L,5L,8L,3L,2L,6L,8L,9L,6L,3L,9L,1L,5L,4L,8L,3L,8L,2L,7L,3L,9L,2L,3L,2L,7L,3L,3L,4L,7L,5L,9L,0L,9L,2L,0L,9L,5L,3L,8L,4L,6L,3L,3L,1L,8L,2L,9L,9L,0L,7L,2L,2L,1L,4L,3L,1L,4L,2L,2L,9L,9L,5L,9L,5L,8L,8L,0L,4L,2L,3L,4L,0L,0L,9L,8L,4L,3L,7L,6L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198843Inst : IEnumerable<long>
{
public static readonly long[] Value=A198843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198843.Bytes);
public long this[int i]=>Value[i];

public static A198843Inst Instance=new A198843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198844
{
public static readonly long[] Value={ 5L,8L,2L,8L,1L,3L,0L,0L,3L,4L,7L,1L,8L,1L,3L,8L,3L,2L,1L,9L,9L,9L,4L,8L,8L,0L,1L,1L,0L,4L,9L,7L,0L,5L,9L,8L,5L,8L,7L,5L,3L,4L,5L,3L,2L,3L,3L,2L,6L,7L,1L,6L,4L,6L,4L,5L,7L,8L,0L,3L,1L,6L,0L,3L,8L,1L,6L,6L,0L,0L,2L,5L,0L,5L,2L,6L,0L,1L,8L,4L,0L,2L,6L,3L,0L,0L,9L,0L,5L,2L,0L,4L,6L,4L,3L,1L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198844Inst : IEnumerable<long>
{
public static readonly long[] Value=A198844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198844.Bytes);
public long this[int i]=>Value[i];

public static A198844Inst Instance=new A198844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198845
{
public static readonly long[] Value={ 7L,47L,287L,1727L,10367L,62207L,373247L,2239487L,13436927L,80621567L,483729407L,2902376447L,17414258687L,104485552127L,626913312767L,3761479876607L,22568879259647L,135413275557887L,812479653347327L,4874877920083967L,29249267520503807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198845Inst : IEnumerable<long>
{
public static readonly long[] Value=A198845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198845.Bytes);
public long this[int i]=>Value[i];

public static A198845Inst Instance=new A198845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198846
{
public static readonly long[] Value={ 8L,53L,323L,1943L,11663L,69983L,419903L,2519423L,15116543L,90699263L,544195583L,3265173503L,19591041023L,117546246143L,705277476863L,4231664861183L,25389989167103L,152339935002623L,914039610015743L,5484237660094463L,32905425960566783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198846Inst : IEnumerable<long>
{
public static readonly long[] Value=A198846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198846.Bytes);
public long this[int i]=>Value[i];

public static A198846Inst Instance=new A198846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198847
{
public static readonly long[] Value={ 9L,59L,359L,2159L,12959L,77759L,466559L,2799359L,16796159L,100776959L,604661759L,3627970559L,21767823359L,130606940159L,783641640959L,4701849845759L,28211099074559L,169266594447359L,1015599566684159L,6093597400104959L,36561584400629759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198847Inst : IEnumerable<long>
{
public static readonly long[] Value=A198847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198847.Bytes);
public long this[int i]=>Value[i];

public static A198847Inst Instance=new A198847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198848
{
public static readonly long[] Value={ 10L,65L,395L,2375L,14255L,85535L,513215L,3079295L,18475775L,110854655L,665127935L,3990767615L,23944605695L,143667634175L,862005805055L,5172034830335L,31032208982015L,186193253892095L,1117159523352575L,6702957140115455L,40217742840692735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198848Inst : IEnumerable<long>
{
public static readonly long[] Value=A198848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198848.Bytes);
public long this[int i]=>Value[i];

public static A198848Inst Instance=new A198848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198849
{
public static readonly long[] Value={ 2L,13L,79L,475L,2851L,17107L,102643L,615859L,3695155L,22170931L,133025587L,798153523L,4788921139L,28733526835L,172401161011L,1034406966067L,6206441796403L,37238650778419L,223431904670515L,1340591428023091L,8043548568138547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198849Inst : IEnumerable<long>
{
public static readonly long[] Value=A198849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198849.Bytes);
public long this[int i]=>Value[i];

public static A198849Inst Instance=new A198849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198850
{
public static readonly long[] Value={ 1L,15L,127L,1023L,8191L,65535L,524287L,4194303L,33554431L,268435455L,2147483647L,17179869183L,137438953471L,1099511627775L,8796093022207L,70368744177663L,562949953421311L,4503599627370495L,36028797018963967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198850Inst : IEnumerable<long>
{
public static readonly long[] Value=A198850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198850.Bytes);
public long this[int i]=>Value[i];

public static A198850Inst Instance=new A198850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198851
{
public static readonly long[] Value={ 2L,23L,191L,1535L,12287L,98303L,786431L,6291455L,50331647L,402653183L,3221225471L,25769803775L,206158430207L,1649267441663L,13194139533311L,105553116266495L,844424930131967L,6755399441055743L,54043195528445951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198851Inst : IEnumerable<long>
{
public static readonly long[] Value=A198851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198851.Bytes);
public long this[int i]=>Value[i];

public static A198851Inst Instance=new A198851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198852
{
public static readonly long[] Value={ 3L,31L,255L,2047L,16383L,131071L,1048575L,8388607L,67108863L,536870911L,4294967295L,34359738367L,274877906943L,2199023255551L,17592186044415L,140737488355327L,1125899906842623L,9007199254740991L,72057594037927935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198852Inst : IEnumerable<long>
{
public static readonly long[] Value=A198852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198852.Bytes);
public long this[int i]=>Value[i];

public static A198852Inst Instance=new A198852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198853
{
public static readonly long[] Value={ 4L,39L,319L,2559L,20479L,163839L,1310719L,10485759L,83886079L,671088639L,5368709119L,42949672959L,343597383679L,2748779069439L,21990232555519L,175921860444159L,1407374883553279L,11258999068426239L,90071992547409919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198853Inst : IEnumerable<long>
{
public static readonly long[] Value=A198853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198853.Bytes);
public long this[int i]=>Value[i];

public static A198853Inst Instance=new A198853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198854
{
public static readonly long[] Value={ 5L,47L,383L,3071L,24575L,196607L,1572863L,12582911L,100663295L,805306367L,6442450943L,51539607551L,412316860415L,3298534883327L,26388279066623L,211106232532991L,1688849860263935L,13510798882111487L,108086391056891903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198854Inst : IEnumerable<long>
{
public static readonly long[] Value=A198854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198854.Bytes);
public long this[int i]=>Value[i];

public static A198854Inst Instance=new A198854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198855
{
public static readonly long[] Value={ 6L,55L,447L,3583L,28671L,229375L,1835007L,14680063L,117440511L,939524095L,7516192767L,60129542143L,481036337151L,3848290697215L,30786325577727L,246290604621823L,1970324836974591L,15762598695796735L,126100789566373887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198855Inst : IEnumerable<long>
{
public static readonly long[] Value=A198855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198855.Bytes);
public long this[int i]=>Value[i];

public static A198855Inst Instance=new A198855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198856
{
public static readonly long[] Value={ 8L,71L,575L,4607L,36863L,294911L,2359295L,18874367L,150994943L,1207959551L,9663676415L,77309411327L,618475290623L,4947802324991L,39582418599935L,316659348799487L,2533274790395903L,20266198323167231L,162129586585337855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198856Inst : IEnumerable<long>
{
public static readonly long[] Value=A198856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198856.Bytes);
public long this[int i]=>Value[i];

public static A198856Inst Instance=new A198856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198857
{
public static readonly long[] Value={ 9L,79L,639L,5119L,40959L,327679L,2621439L,20971519L,167772159L,1342177279L,10737418239L,85899345919L,687194767359L,5497558138879L,43980465111039L,351843720888319L,2814749767106559L,22517998136852479L,180143985094819839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198857Inst : IEnumerable<long>
{
public static readonly long[] Value=A198857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198857.Bytes);
public long this[int i]=>Value[i];

public static A198857Inst Instance=new A198857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198858
{
public static readonly long[] Value={ 10L,87L,703L,5631L,45055L,360447L,2883583L,23068671L,184549375L,1476395007L,11811160063L,94489280511L,755914244095L,6047313952767L,48378511622143L,387028092977151L,3096224743817215L,24769797950537727L,198158383604301823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198858Inst : IEnumerable<long>
{
public static readonly long[] Value=A198858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198858.Bytes);
public long this[int i]=>Value[i];

public static A198858Inst Instance=new A198858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198859
{
public static readonly long[] Value={ 1L,17L,161L,1457L,13121L,118097L,1062881L,9565937L,86093441L,774840977L,6973568801L,62762119217L,564859072961L,5083731656657L,45753584909921L,411782264189297L,3706040377703681L,33354363399333137L,300189270593998241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198859Inst : IEnumerable<long>
{
public static readonly long[] Value=A198859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198859.Bytes);
public long this[int i]=>Value[i];

public static A198859Inst Instance=new A198859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198860
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,144L,1634L,23312L,401274L,8096680L,187472136L,4900535832L,142766286552L,4587190461840L,161161214978880L,6146415080939520L,252902928346825104L,11167368115492742400UL,BigInteger.Parse("526752556713346955520"),BigInteger.Parse("26433830208985721222400"),BigInteger.Parse("1406218428780691953635712") };
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
public class A198860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198860Inst Instance=new A198860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198861
{
public static readonly long[] Value={ 2L,30L,1680L,7983360L,40548366802944000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198861Inst : IEnumerable<long>
{
public static readonly long[] Value=A198861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198861.Bytes);
public long this[int i]=>Value[i];

public static A198861Inst Instance=new A198861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198862
{
public static readonly long[] Value={ -1L,2L,2L,2L,3L,1L,-1L,-3L,-6L,-7L,-6L,-3L,3L,10L,16L,19L,16L,6L,-10L,-29L,-45L,-51L,-41L,-12L,33L,84L,125L,137L,104L,20L,-105L,-242L,-346L,-366L,-261L,-19L,327L,693L,954L,973L,646L,-47L,-1001L,-1974L,-2620L,-2573L,-1572L,402L,3022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198862Inst : IEnumerable<long>
{
public static readonly long[] Value=A198862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198862.Bytes);
public long this[int i]=>Value[i];

public static A198862Inst Instance=new A198862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198863
{
public static readonly long[] Value={ 3164252736L,3164326683L,3164389113L,3164391957L,3164406057L,3164416923L,3164421333L,3164454864L,3164466768L,3164482974L,3164528124L,3164547114L,3164689392L,3164695206L,3164735277L,3164770866L,3164789766L,3164863185L,3164867118L,3164907357L,3165009693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198863Inst : IEnumerable<long>
{
public static readonly long[] Value=A198863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198863.Bytes);
public long this[int i]=>Value[i];

public static A198863Inst Instance=new A198863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198864
{
public static readonly BigInteger[] Value={ 1L,2L,4L,11L,92L,8101L,65585702L,4301483913318599L,BigInteger.Parse("18502763856538658405109886092616"),BigInteger.Parse("342352270330833327273885765082712290623512199361069533040982537") };
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
public class A198864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198864Inst Instance=new A198864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198865
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,368L,5941L,121632L,3019563L,88140544L,2958267241L,112246484480L,4751313955543L,221980968007680L,11346405913579101L,629859586327810048L,BigInteger.Parse("37736053514310470371"),BigInteger.Parse("2426956220333852131328"),BigInteger.Parse("166775317658298155269585"),BigInteger.Parse("12195158366650225121427456") };
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
public class A198865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198865Inst Instance=new A198865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198866
{
public static readonly long[] Value={ 1L,4L,0L,9L,6L,2L,4L,0L,0L,4L,0L,0L,2L,5L,9L,6L,2L,4L,9L,2L,3L,5L,5L,9L,3L,9L,7L,0L,5L,8L,9L,4L,9L,3L,5L,4L,7L,1L,2L,3L,5L,4L,8L,3L,5L,1L,0L,7L,8L,9L,0L,1L,5L,1L,5L,1L,0L,1L,6L,6L,8L,3L,0L,0L,9L,9L,1L,8L,3L,6L,0L,1L,6L,7L,3L,1L,8L,1L,4L,5L,2L,5L,1L,6L,8L,7L,4L,8L,9L,2L,1L,4L,3L,2L,5L,9L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198866Inst : IEnumerable<long>
{
public static readonly long[] Value=A198866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198866.Bytes);
public long this[int i]=>Value[i];

public static A198866Inst Instance=new A198866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198867
{
public static readonly long[] Value={ 6L,3L,6L,7L,3L,2L,6L,5L,0L,8L,0L,5L,2L,8L,2L,0L,1L,0L,8L,8L,7L,9L,9L,0L,9L,0L,3L,8L,3L,8L,2L,8L,0L,0L,5L,8L,9L,9L,7L,8L,0L,5L,0L,7L,8L,8L,4L,1L,7L,9L,1L,6L,7L,3L,3L,8L,2L,8L,1L,8L,2L,6L,3L,1L,9L,5L,8L,0L,4L,4L,0L,2L,9L,0L,1L,2L,0L,2L,5L,9L,2L,6L,5L,1L,4L,5L,9L,4L,7L,3L,1L,1L,8L,0L,7L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198867Inst : IEnumerable<long>
{
public static readonly long[] Value=A198867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198867.Bytes);
public long this[int i]=>Value[i];

public static A198867Inst Instance=new A198867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198868
{
public static readonly long[] Value={ 6L,3L,0L,3L,9L,8L,6L,6L,3L,9L,9L,3L,5L,9L,9L,3L,8L,6L,4L,4L,0L,7L,0L,4L,8L,6L,1L,7L,7L,7L,0L,4L,4L,9L,9L,2L,6L,7L,8L,5L,0L,2L,5L,1L,7L,0L,1L,8L,1L,0L,1L,7L,6L,8L,6L,5L,4L,9L,2L,6L,9L,1L,3L,0L,8L,5L,9L,5L,7L,8L,9L,5L,0L,6L,9L,5L,6L,0L,2L,9L,7L,5L,2L,9L,0L,5L,7L,4L,3L,9L,9L,3L,8L,4L,7L,4L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198868Inst : IEnumerable<long>
{
public static readonly long[] Value=A198868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198868.Bytes);
public long this[int i]=>Value[i];

public static A198868Inst Instance=new A198868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198869
{
public static readonly long[] Value={ 9L,6L,4L,4L,2L,0L,4L,4L,6L,8L,5L,1L,1L,0L,3L,3L,9L,9L,2L,6L,0L,3L,5L,6L,9L,0L,9L,1L,2L,4L,7L,2L,7L,2L,0L,6L,5L,1L,4L,3L,3L,9L,5L,4L,3L,6L,0L,4L,6L,8L,2L,7L,4L,8L,9L,4L,8L,5L,5L,2L,7L,3L,1L,6L,7L,3L,1L,8L,0L,2L,3L,9L,9L,9L,0L,9L,4L,8L,1L,8L,4L,2L,2L,4L,7L,0L,3L,6L,2L,1L,2L,7L,2L,7L,3L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198869Inst : IEnumerable<long>
{
public static readonly long[] Value=A198869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198869.Bytes);
public long this[int i]=>Value[i];

public static A198869Inst Instance=new A198869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198870
{
public static readonly long[] Value={ 1L,2L,1L,6L,2L,3L,8L,8L,0L,9L,4L,6L,6L,3L,9L,3L,2L,9L,0L,5L,9L,9L,6L,2L,5L,7L,6L,7L,0L,2L,9L,3L,4L,3L,2L,9L,1L,1L,5L,4L,4L,7L,0L,4L,5L,7L,2L,0L,2L,5L,3L,0L,0L,3L,1L,9L,4L,0L,7L,1L,1L,9L,0L,7L,8L,9L,7L,3L,6L,1L,8L,0L,1L,4L,4L,6L,3L,8L,5L,6L,4L,9L,9L,0L,4L,4L,3L,4L,8L,4L,7L,0L,9L,9L,3L,6L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198870Inst : IEnumerable<long>
{
public static readonly long[] Value=A198870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198870.Bytes);
public long this[int i]=>Value[i];

public static A198870Inst Instance=new A198870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198871
{
public static readonly long[] Value={ 9L,0L,0L,3L,6L,7L,2L,2L,2L,5L,8L,9L,7L,4L,7L,1L,4L,6L,0L,7L,3L,0L,7L,7L,3L,9L,3L,5L,2L,5L,3L,6L,3L,6L,5L,4L,6L,4L,0L,2L,7L,3L,0L,0L,3L,4L,4L,6L,1L,1L,0L,8L,6L,8L,0L,3L,0L,1L,1L,6L,9L,8L,2L,7L,2L,7L,2L,8L,3L,1L,3L,3L,9L,7L,0L,4L,4L,6L,7L,5L,9L,0L,9L,4L,5L,4L,8L,2L,4L,4L,3L,7L,6L,0L,3L,6L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198871Inst : IEnumerable<long>
{
public static readonly long[] Value=A198871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198871.Bytes);
public long this[int i]=>Value[i];

public static A198871Inst Instance=new A198871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198872
{
public static readonly long[] Value={ 1L,1L,0L,6L,3L,3L,2L,5L,5L,5L,0L,2L,9L,9L,3L,5L,9L,1L,5L,2L,5L,4L,7L,5L,6L,0L,9L,5L,7L,2L,9L,5L,1L,6L,7L,5L,2L,6L,3L,5L,2L,8L,9L,3L,9L,5L,4L,3L,9L,2L,0L,9L,3L,7L,7L,3L,2L,6L,2L,8L,5L,3L,7L,8L,7L,8L,6L,7L,5L,0L,5L,3L,0L,5L,6L,8L,9L,7L,0L,9L,1L,5L,8L,1L,2L,2L,9L,1L,0L,0L,6L,7L,1L,1L,0L,5L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198872Inst : IEnumerable<long>
{
public static readonly long[] Value=A198872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198872.Bytes);
public long this[int i]=>Value[i];

public static A198872Inst Instance=new A198872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198873
{
public static readonly long[] Value={ 1L,2L,8L,1L,6L,3L,0L,3L,8L,6L,1L,5L,9L,9L,6L,2L,1L,1L,0L,4L,2L,9L,9L,0L,6L,6L,7L,9L,6L,2L,0L,0L,1L,9L,4L,3L,1L,6L,4L,9L,7L,2L,1L,0L,9L,0L,8L,3L,6L,3L,6L,6L,0L,0L,0L,3L,9L,9L,8L,1L,0L,6L,3L,6L,5L,4L,9L,7L,4L,9L,4L,3L,3L,8L,4L,3L,5L,8L,0L,8L,9L,7L,3L,4L,1L,6L,0L,3L,4L,0L,7L,8L,4L,1L,3L,1L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198873Inst : IEnumerable<long>
{
public static readonly long[] Value=A198873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198873.Bytes);
public long this[int i]=>Value[i];

public static A198873Inst Instance=new A198873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198874
{
public static readonly long[] Value={ 1L,4L,3L,7L,5L,1L,3L,2L,6L,8L,4L,1L,3L,4L,2L,0L,3L,0L,4L,2L,5L,7L,2L,3L,4L,1L,4L,7L,0L,9L,5L,9L,2L,7L,5L,3L,7L,4L,2L,3L,8L,8L,0L,9L,3L,2L,4L,6L,4L,4L,9L,0L,6L,5L,7L,3L,7L,1L,7L,5L,5L,3L,6L,6L,9L,4L,6L,9L,7L,9L,6L,0L,1L,3L,0L,3L,4L,3L,0L,3L,7L,8L,9L,2L,6L,1L,8L,6L,7L,1L,3L,9L,6L,0L,8L,4L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198874Inst : IEnumerable<long>
{
public static readonly long[] Value=A198874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198874.Bytes);
public long this[int i]=>Value[i];

public static A198874Inst Instance=new A198874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198875
{
public static readonly long[] Value={ 5L,8L,0L,0L,3L,6L,6L,7L,8L,6L,4L,7L,0L,9L,7L,6L,9L,4L,5L,4L,8L,3L,6L,7L,9L,1L,6L,1L,9L,0L,6L,3L,7L,2L,4L,8L,2L,4L,2L,2L,3L,7L,7L,1L,9L,1L,5L,0L,0L,4L,5L,3L,3L,4L,5L,9L,2L,0L,4L,8L,4L,6L,2L,5L,5L,0L,1L,0L,1L,5L,5L,1L,5L,8L,5L,1L,4L,3L,4L,7L,6L,9L,6L,1L,2L,0L,5L,8L,8L,8L,1L,0L,9L,9L,6L,7L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198875Inst : IEnumerable<long>
{
public static readonly long[] Value=A198875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198875.Bytes);
public long this[int i]=>Value[i];

public static A198875Inst Instance=new A198875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198876
{
public static readonly long[] Value={ 1L,3L,2L,1L,5L,9L,9L,6L,2L,0L,8L,7L,6L,7L,1L,8L,2L,2L,2L,1L,3L,7L,7L,3L,3L,4L,9L,2L,8L,1L,7L,5L,0L,4L,2L,4L,4L,9L,9L,2L,5L,6L,1L,5L,3L,4L,7L,3L,1L,2L,1L,4L,4L,0L,6L,8L,0L,4L,7L,9L,1L,0L,5L,5L,2L,3L,4L,6L,0L,7L,0L,3L,9L,7L,2L,0L,7L,7L,9L,1L,8L,2L,0L,7L,8L,2L,1L,2L,0L,8L,0L,8L,3L,0L,6L,4L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198876Inst : IEnumerable<long>
{
public static readonly long[] Value=A198876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198876.Bytes);
public long this[int i]=>Value[i];

public static A198876Inst Instance=new A198876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198877
{
public static readonly long[] Value={ 5L,3L,7L,2L,7L,2L,4L,7L,4L,7L,7L,2L,1L,2L,4L,6L,4L,5L,3L,7L,2L,0L,5L,1L,5L,0L,8L,5L,1L,2L,5L,3L,0L,2L,4L,2L,2L,8L,6L,3L,8L,0L,6L,0L,7L,0L,4L,1L,1L,1L,8L,7L,6L,1L,9L,3L,8L,4L,3L,2L,3L,8L,9L,5L,0L,6L,3L,1L,3L,5L,7L,8L,7L,0L,9L,3L,5L,8L,7L,1L,8L,9L,2L,4L,4L,3L,7L,8L,5L,2L,0L,1L,1L,0L,8L,0L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198877Inst : IEnumerable<long>
{
public static readonly long[] Value=A198877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198877.Bytes);
public long this[int i]=>Value[i];

public static A198877Inst Instance=new A198877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198878
{
public static readonly long[] Value={ 7L,6L,3L,7L,7L,2L,2L,7L,4L,9L,0L,1L,1L,1L,9L,0L,5L,0L,1L,1L,0L,5L,5L,9L,8L,8L,5L,9L,2L,8L,2L,8L,3L,1L,4L,5L,4L,9L,7L,3L,6L,5L,0L,3L,4L,6L,2L,0L,7L,4L,5L,4L,9L,8L,2L,2L,6L,2L,1L,7L,2L,5L,0L,8L,5L,8L,9L,6L,3L,1L,5L,6L,5L,0L,0L,5L,3L,6L,7L,6L,2L,7L,2L,0L,9L,5L,6L,3L,6L,4L,0L,1L,5L,0L,4L,5L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198878Inst : IEnumerable<long>
{
public static readonly long[] Value=A198878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198878.Bytes);
public long this[int i]=>Value[i];

public static A198878Inst Instance=new A198878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198879
{
public static readonly long[] Value={ 1L,0L,9L,1L,6L,0L,2L,4L,7L,5L,2L,5L,0L,6L,5L,0L,8L,3L,1L,6L,8L,6L,9L,6L,9L,3L,0L,1L,5L,1L,2L,9L,5L,3L,4L,9L,6L,9L,6L,0L,2L,7L,0L,5L,7L,7L,3L,2L,6L,4L,9L,1L,2L,0L,0L,3L,3L,1L,3L,1L,8L,5L,0L,5L,5L,8L,6L,3L,4L,1L,8L,3L,3L,6L,8L,3L,5L,5L,0L,7L,9L,0L,7L,4L,8L,2L,5L,7L,7L,0L,5L,1L,9L,2L,6L,5L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198879Inst : IEnumerable<long>
{
public static readonly long[] Value=A198879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198879.Bytes);
public long this[int i]=>Value[i];

public static A198879Inst Instance=new A198879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198880
{
public static readonly long[] Value={ 1L,2L,2L,7L,0L,1L,7L,2L,0L,7L,3L,5L,2L,9L,2L,2L,0L,8L,9L,7L,2L,2L,1L,9L,9L,7L,0L,8L,1L,9L,5L,4L,2L,6L,9L,3L,5L,0L,5L,9L,4L,3L,6L,1L,8L,6L,6L,4L,7L,8L,5L,9L,0L,8L,7L,7L,5L,9L,0L,6L,7L,3L,2L,8L,0L,3L,4L,6L,9L,4L,7L,4L,0L,9L,0L,7L,4L,1L,8L,7L,9L,6L,7L,6L,4L,3L,2L,1L,5L,2L,1L,1L,7L,2L,0L,6L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198880Inst : IEnumerable<long>
{
public static readonly long[] Value=A198880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198880.Bytes);
public long this[int i]=>Value[i];

public static A198880Inst Instance=new A198880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198881
{
public static readonly long[] Value={ 1L,3L,5L,1L,4L,4L,2L,8L,9L,2L,9L,4L,2L,0L,7L,9L,0L,4L,9L,6L,9L,5L,5L,5L,4L,7L,8L,0L,3L,6L,6L,3L,0L,4L,9L,3L,9L,3L,8L,3L,1L,2L,2L,1L,3L,0L,4L,4L,0L,7L,7L,3L,5L,6L,5L,6L,4L,7L,3L,3L,3L,3L,7L,1L,0L,7L,8L,7L,7L,5L,6L,4L,7L,4L,0L,7L,7L,8L,2L,4L,5L,5L,0L,3L,2L,0L,2L,8L,1L,0L,3L,2L,3L,8L,7L,9L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198881Inst : IEnumerable<long>
{
public static readonly long[] Value=A198881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198881.Bytes);
public long this[int i]=>Value[i];

public static A198881Inst Instance=new A198881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198882
{
public static readonly long[] Value={ 1L,4L,6L,7L,7L,5L,1L,3L,6L,0L,2L,0L,4L,1L,4L,6L,5L,4L,1L,5L,6L,0L,5L,8L,4L,6L,1L,8L,8L,5L,6L,9L,2L,6L,3L,1L,6L,3L,3L,7L,3L,6L,3L,4L,3L,8L,9L,5L,1L,4L,7L,9L,7L,0L,8L,5L,3L,6L,6L,8L,1L,1L,7L,8L,4L,1L,7L,9L,7L,5L,6L,1L,9L,4L,5L,8L,8L,1L,3L,0L,3L,3L,1L,0L,6L,6L,0L,7L,3L,8L,6L,8L,5L,8L,2L,9L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198882Inst : IEnumerable<long>
{
public static readonly long[] Value=A198882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198882.Bytes);
public long this[int i]=>Value[i];

public static A198882Inst Instance=new A198882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198883
{
public static readonly long[] Value={ 5L,0L,2L,6L,3L,0L,1L,8L,3L,5L,2L,3L,6L,8L,1L,8L,9L,7L,0L,4L,3L,8L,6L,9L,2L,1L,6L,0L,0L,9L,3L,5L,3L,8L,7L,5L,3L,1L,7L,9L,7L,6L,9L,8L,2L,3L,1L,6L,6L,8L,7L,8L,2L,3L,5L,4L,5L,9L,9L,1L,4L,4L,5L,8L,7L,2L,1L,4L,4L,5L,8L,9L,3L,0L,4L,1L,4L,0L,4L,8L,8L,4L,9L,3L,2L,8L,5L,4L,0L,0L,6L,8L,5L,9L,1L,2L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198883Inst : IEnumerable<long>
{
public static readonly long[] Value=A198883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198883.Bytes);
public long this[int i]=>Value[i];

public static A198883Inst Instance=new A198883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198884
{
public static readonly long[] Value={ 8L,7L,9L,9L,7L,0L,4L,0L,3L,2L,4L,2L,3L,9L,4L,2L,3L,8L,7L,9L,6L,3L,1L,5L,3L,4L,4L,0L,5L,3L,6L,4L,4L,3L,8L,3L,9L,3L,8L,7L,1L,8L,2L,8L,8L,5L,4L,4L,9L,7L,2L,8L,4L,9L,9L,3L,3L,2L,2L,4L,9L,1L,0L,0L,1L,9L,1L,6L,5L,6L,1L,6L,6L,9L,7L,8L,9L,9L,2L,1L,2L,1L,5L,9L,3L,5L,4L,2L,3L,9L,7L,7L,6L,9L,9L,5L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198884Inst : IEnumerable<long>
{
public static readonly long[] Value=A198884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198884.Bytes);
public long this[int i]=>Value[i];

public static A198884Inst Instance=new A198884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198885
{
public static readonly long[] Value={ 1L,1L,4L,8L,6L,6L,0L,1L,3L,5L,6L,9L,8L,6L,6L,5L,9L,8L,7L,7L,2L,6L,9L,4L,2L,4L,6L,8L,0L,3L,2L,4L,4L,1L,7L,6L,7L,5L,1L,4L,3L,2L,2L,2L,4L,5L,7L,6L,3L,6L,4L,9L,4L,0L,2L,9L,5L,2L,7L,5L,3L,8L,8L,3L,3L,4L,1L,2L,7L,0L,4L,7L,7L,4L,6L,6L,8L,7L,3L,1L,1L,6L,8L,7L,6L,3L,4L,2L,6L,6L,1L,8L,1L,7L,5L,1L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198885Inst : IEnumerable<long>
{
public static readonly long[] Value=A198885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198885.Bytes);
public long this[int i]=>Value[i];

public static A198885Inst Instance=new A198885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198886
{
public static readonly long[] Value={ 1L,3L,7L,4L,6L,7L,5L,3L,4L,3L,9L,3L,4L,6L,8L,1L,8L,9L,9L,6L,3L,0L,1L,5L,6L,6L,5L,7L,3L,2L,3L,7L,5L,8L,5L,8L,9L,1L,5L,5L,0L,5L,4L,3L,6L,6L,9L,3L,5L,9L,5L,8L,9L,7L,6L,7L,6L,9L,1L,5L,6L,7L,5L,5L,3L,0L,0L,8L,7L,2L,4L,4L,1L,6L,2L,5L,1L,9L,5L,0L,2L,1L,1L,8L,2L,2L,1L,4L,1L,0L,3L,3L,4L,2L,1L,6L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198886Inst : IEnumerable<long>
{
public static readonly long[] Value=A198886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198886.Bytes);
public long this[int i]=>Value[i];

public static A198886Inst Instance=new A198886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198887
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,269L,5056L,84247L,2400448L,57253849L,2191568896L,68151324491L,3278448139264L,125802549088933L,7291045162516480L,332950230966532831L,BigInteger.Parse("22581201334925049856"),BigInteger.Parse("1196122595530554458033"),BigInteger.Parse("92934371464549349982208"),BigInteger.Parse("5602230959364892208231443") };
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
public class A198887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198887Inst Instance=new A198887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198888
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,22L,61L,172L,528L,1695L,5447L,17486L,56778L,187064L,622149L,2080325L,6990670L,23621143L,80230388L,273687898L,937072049L,3219316096L,11095261035L,38351414036L,132915860364L,461770505371L,1607875309626L,5610314558562L,19614016834508L,68696001390320L,241007011551493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198888Inst : IEnumerable<long>
{
public static readonly long[] Value=A198888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198888.Bytes);
public long this[int i]=>Value[i];

public static A198888Inst Instance=new A198888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198889
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,2L,12L,6L,2L,2L,20L,24L,6L,2L,2L,30L,72L,24L,6L,2L,2L,42L,172L,120L,24L,6L,2L,2L,56L,352L,480L,120L,24L,6L,2L,2L,72L,646L,1512L,720L,120L,24L,6L,2L,2L,90L,1094L,3976L,3600L,720L,120L,24L,6L,2L,2L,110L,1742L,9144L,14184L,5040L,720L,120L,24L,6L,2L,2L,132L,2642L,18990L,45992L,30240L,5040L,720L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198889Inst : IEnumerable<long>
{
public static readonly long[] Value=A198889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198889.Bytes);
public long this[int i]=>Value[i];

public static A198889Inst Instance=new A198889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198890
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,4L,4L,4L,5L,4L,5L,5L,4L,6L,4L,5L,5L,4L,5L,4L,4L,4L,3L,4L,2L,3L,2L,2L,2L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,3L,2L,4L,3L,5L,5L,7L,6L,8L,8L,9L,10L,12L,10L,14L,12L,14L,15L,16L,15L,18L,16L,18L,18L,20L,17L,21L,18L,20L,20L,20L,18L,21L,17L,20L,18L,18L,16L,18L,15L,16L,15L,14L,12L,14L,10L,12L,10L,9L,8L,8L,6L,7L,5L,5L,3L,4L,2L,3L,2L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198890Inst : IEnumerable<long>
{
public static readonly long[] Value=A198890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198890.Bytes);
public long this[int i]=>Value[i];

public static A198890Inst Instance=new A198890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198891
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,32L,180L,1219L,9646L,87192L,886536L,10016159L,124481258L,1687686528L,24787991800L,392081193504L,6644677619581L,120115898158288L,2307044712629472L,46917527736860976L,1007152702625923440L,BigInteger.Parse("22757886107313170356"),BigInteger.Parse("539955309450787483261"),BigInteger.Parse("13421068671117864869156") };
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
public class A198891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198891Inst Instance=new A198891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198892
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,48L,300L,2280L,20580L,211680L,2434320L,31134600L,438807600L,6744276000L,112237725600L,2011760150400L,38639999197800L,791610365145600L,17230493212732800L,397111119429024000L,9660782144094681600UL,BigInteger.Parse("247393077222459168000"),BigInteger.Parse("6651976858409613931200") };
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
public class A198892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198892Inst Instance=new A198892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198893
{
public static readonly long[] Value={ 1L,4L,66L,7128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198893Inst : IEnumerable<long>
{
public static readonly long[] Value=A198893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198893.Bytes);
public long this[int i]=>Value[i];

public static A198893Inst Instance=new A198893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198894
{
public static readonly long[] Value={ 1L,2L,11L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198894Inst : IEnumerable<long>
{
public static readonly long[] Value=A198894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198894.Bytes);
public long this[int i]=>Value[i];

public static A198894Inst Instance=new A198894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198895
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,5L,2L,1L,8L,18L,16L,5L,1L,16L,58L,88L,61L,16L,1L,32L,179L,416L,479L,272L,61L,1L,64L,543L,1824L,3111L,2880L,1385L,272L,1L,128L,1636L,7680L,18270L,24576L,19028L,7936L,1385L,1L,256L,4916L,31616L,101166L,185856L,206276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198895Inst : IEnumerable<long>
{
public static readonly long[] Value=A198895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198895.Bytes);
public long this[int i]=>Value[i];

public static A198895Inst Instance=new A198895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198896
{
public static readonly long[] Value={ 1L,2L,5L,12L,26L,54L,114L,228L,449L,878L,1690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198896Inst : IEnumerable<long>
{
public static readonly long[] Value=A198896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198896.Bytes);
public long this[int i]=>Value[i];

public static A198896Inst Instance=new A198896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198897
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,2L,2L,4L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198897Inst : IEnumerable<long>
{
public static readonly long[] Value=A198897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198897.Bytes);
public long this[int i]=>Value[i];

public static A198897Inst Instance=new A198897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198898
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198898Inst : IEnumerable<long>
{
public static readonly long[] Value=A198898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198898.Bytes);
public long this[int i]=>Value[i];

public static A198898Inst Instance=new A198898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198899
{
public static readonly BigInteger[] Value={ 1L,4L,1211L,6907736L,423503301834L,274342896958292170L,BigInteger.Parse("1877611081501313948217870"),BigInteger.Parse("135766460737448561825230968357842") };
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
public class A198899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198899Inst Instance=new A198899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198900
{
public static readonly long[] Value={ 1L,4L,33L,380L,4801L,62004L,804833L,10459180L,135958401L,1767426404L,22976444833L,298693487580L,3883014452801L,50479185229204L,656229400008033L,8530982176189580L,110902768218720001L,1441735986628126404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198900Inst : IEnumerable<long>
{
public static readonly long[] Value=A198900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198900.Bytes);
public long this[int i]=>Value[i];

public static A198900Inst Instance=new A198900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198901
{
public static readonly BigInteger[] Value={ 2L,33L,1211L,50384L,2125425L,89793204L,3794115705L,160319061892L,6774239755817L,286243775060868L,12095158053422201L,511077834439270724L,BigInteger.Parse("21595464215307153225"),BigInteger.Parse("912510860892666556164"),BigInteger.Parse("38557914891188891686425") };
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
public class A198901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198901Inst Instance=new A198901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198902
{
public static readonly BigInteger[] Value={ 5L,380L,50384L,6907736L,948656912L,130292546801L,17895005957823L,2457786852894234L,337564362706067534L,BigInteger.Parse("46362726246946052884"),BigInteger.Parse("6367681611531782236418"),BigInteger.Parse("874568266109492180669275") };
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
public class A198902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198902Inst Instance=new A198902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198903
{
public static readonly BigInteger[] Value={ 15L,4801L,2125425L,948656912L,423503301834L,189062985604305L,84402688527136201L,BigInteger.Parse("37679579867128064832"),BigInteger.Parse("16821155393975907014458"),BigInteger.Parse("7509406150309683843851949"),BigInteger.Parse("3352396396661126098060061297") };
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
public class A198903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198903Inst Instance=new A198903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198904
{
public static readonly BigInteger[] Value={ 51L,62004L,89793204L,130292546801L,189062985604305L,274342896958292170L,BigInteger.Parse("398089706066811447174"),BigInteger.Parse("577654521153750977585383"),BigInteger.Parse("838214957290859115489996817"),BigInteger.Parse("1216305402162613228248847610489") };
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
public class A198904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198904Inst Instance=new A198904Inst();

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