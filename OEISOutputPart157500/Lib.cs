using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200605
{
public static readonly long[] Value={ 1L,4L,5L,4L,3L,9L,7L,1L,3L,0L,5L,6L,2L,5L,8L,0L,1L,9L,3L,6L,5L,3L,9L,6L,3L,1L,4L,9L,9L,5L,2L,1L,3L,5L,2L,1L,7L,8L,6L,5L,1L,0L,4L,7L,1L,9L,5L,4L,5L,4L,6L,3L,4L,3L,2L,0L,2L,5L,2L,7L,2L,0L,2L,5L,6L,9L,5L,8L,3L,9L,4L,2L,3L,7L,5L,2L,2L,2L,6L,9L,2L,7L,8L,6L,1L,1L,4L,7L,4L,4L,4L,0L,8L,3L,4L,5L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200605Inst : IEnumerable<long>
{
public static readonly long[] Value=A200605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200605.Bytes);
public long this[int i]=>Value[i];

public static A200605Inst Instance=new A200605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200606
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,2L,4L,5L,4L,2L,2L,0L,8L,0L,3L,3L,2L,1L,6L,1L,3L,8L,7L,6L,9L,4L,4L,6L,9L,0L,3L,9L,3L,9L,8L,5L,8L,4L,8L,3L,4L,4L,7L,1L,1L,0L,3L,3L,5L,1L,2L,5L,4L,9L,4L,6L,5L,8L,2L,1L,6L,0L,7L,0L,1L,6L,0L,6L,4L,1L,8L,0L,6L,6L,1L,7L,0L,6L,4L,6L,6L,8L,4L,3L,7L,5L,3L,5L,2L,0L,8L,5L,4L,9L,8L,2L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200606Inst : IEnumerable<long>
{
public static readonly long[] Value=A200606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200606.Bytes);
public long this[int i]=>Value[i];

public static A200606Inst Instance=new A200606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200607
{
public static readonly long[] Value={ 1L,3L,9L,3L,7L,4L,1L,9L,5L,4L,2L,0L,3L,5L,9L,0L,5L,0L,6L,5L,1L,9L,5L,3L,4L,7L,9L,5L,6L,0L,7L,4L,8L,4L,4L,1L,9L,5L,2L,6L,4L,8L,8L,9L,2L,7L,0L,9L,4L,0L,0L,6L,0L,5L,8L,9L,2L,4L,3L,5L,7L,5L,1L,3L,1L,5L,8L,9L,4L,8L,4L,5L,3L,5L,9L,4L,2L,9L,5L,2L,1L,0L,1L,5L,3L,8L,6L,9L,0L,3L,1L,1L,2L,2L,2L,5L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200607Inst : IEnumerable<long>
{
public static readonly long[] Value=A200607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200607.Bytes);
public long this[int i]=>Value[i];

public static A200607Inst Instance=new A200607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200608
{
public static readonly long[] Value={ 1L,4L,2L,5L,9L,4L,9L,1L,1L,1L,8L,3L,1L,5L,0L,1L,9L,7L,5L,6L,7L,7L,5L,9L,9L,7L,2L,4L,4L,7L,1L,2L,4L,3L,7L,0L,1L,4L,6L,4L,0L,0L,4L,2L,1L,3L,5L,6L,4L,9L,1L,0L,4L,1L,8L,5L,9L,0L,5L,9L,0L,3L,7L,6L,3L,7L,4L,7L,9L,0L,9L,6L,5L,4L,9L,7L,1L,6L,7L,7L,4L,5L,7L,6L,2L,1L,4L,0L,0L,7L,7L,6L,1L,0L,0L,7L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200608Inst : IEnumerable<long>
{
public static readonly long[] Value=A200608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200608.Bytes);
public long this[int i]=>Value[i];

public static A200608Inst Instance=new A200608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200609
{
public static readonly long[] Value={ 1L,4L,4L,6L,9L,6L,0L,6L,8L,6L,1L,4L,8L,8L,1L,9L,5L,4L,3L,8L,0L,8L,8L,6L,8L,8L,6L,1L,4L,7L,3L,9L,9L,5L,0L,1L,3L,9L,0L,8L,3L,7L,6L,2L,4L,8L,3L,2L,6L,9L,2L,8L,9L,1L,0L,4L,3L,7L,4L,6L,0L,0L,4L,9L,6L,1L,8L,9L,1L,5L,7L,1L,5L,9L,1L,1L,8L,5L,3L,9L,1L,9L,5L,2L,9L,4L,3L,2L,0L,8L,6L,2L,2L,9L,8L,7L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200609Inst : IEnumerable<long>
{
public static readonly long[] Value=A200609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200609.Bytes);
public long this[int i]=>Value[i];

public static A200609Inst Instance=new A200609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200610
{
public static readonly long[] Value={ 2L,4L,8L,2L,6L,0L,9L,1L,4L,5L,2L,3L,0L,8L,3L,2L,1L,9L,8L,7L,0L,8L,3L,3L,6L,3L,7L,2L,2L,8L,9L,0L,9L,5L,7L,5L,3L,3L,4L,8L,9L,8L,6L,1L,0L,0L,9L,9L,4L,3L,5L,5L,5L,5L,0L,0L,9L,8L,6L,2L,9L,7L,6L,6L,7L,2L,3L,3L,5L,2L,5L,3L,7L,0L,6L,2L,8L,0L,2L,9L,6L,1L,7L,5L,2L,3L,0L,4L,9L,8L,7L,9L,1L,2L,4L,9L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200610Inst : IEnumerable<long>
{
public static readonly long[] Value=A200610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200610.Bytes);
public long this[int i]=>Value[i];

public static A200610Inst Instance=new A200610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200611
{
public static readonly long[] Value={ 1L,3L,7L,6L,0L,5L,2L,5L,1L,5L,3L,9L,9L,6L,6L,9L,7L,5L,3L,5L,7L,9L,4L,8L,9L,2L,7L,4L,8L,8L,0L,9L,1L,1L,6L,1L,2L,8L,3L,1L,1L,3L,8L,8L,8L,2L,4L,0L,3L,0L,3L,6L,7L,6L,5L,9L,3L,2L,9L,8L,6L,3L,0L,8L,3L,2L,5L,3L,6L,4L,7L,0L,0L,9L,9L,4L,9L,9L,1L,6L,0L,5L,7L,3L,2L,2L,6L,6L,0L,7L,3L,2L,0L,7L,1L,8L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200611Inst : IEnumerable<long>
{
public static readonly long[] Value=A200611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200611.Bytes);
public long this[int i]=>Value[i];

public static A200611Inst Instance=new A200611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200612
{
public static readonly long[] Value={ 3L,9L,20L,27L,60L,81L,112L,180L,243L,336L,400L,540L,729L,1008L,1200L,1620L,2187L,2240L,2816L,3024L,3600L,4860L,6561L,6720L,8000L,8448L,9072L,10800L,12544L,13312L,14580L,19683L,20160L,24000L,25344L,27216L,32400L,37632L,39936L,43740L,44800L,56320L,59049L,60480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200612Inst : IEnumerable<long>
{
public static readonly long[] Value=A200612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200612.Bytes);
public long this[int i]=>Value[i];

public static A200612Inst Instance=new A200612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200613
{
public static readonly long[] Value={ 1L,3L,11L,44L,183L,774L,3294L,14034L,59711L,253430L,1072506L,4525168L,19036726L,79861404L,334155036L,1394789214L,5808981711L,24143440374L,100156051746L,414762312504L,1714844273586L,7079573497524L,29187378344676L,120180109515204L,494264431607718L,2030539136846844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200613Inst : IEnumerable<long>
{
public static readonly long[] Value=A200613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200613.Bytes);
public long this[int i]=>Value[i];

public static A200613Inst Instance=new A200613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200614
{
public static readonly long[] Value={ 8L,3L,9L,5L,8L,2L,2L,5L,9L,0L,4L,5L,3L,0L,2L,9L,4L,1L,5L,1L,3L,7L,6L,4L,0L,0L,8L,8L,6L,3L,8L,0L,4L,9L,8L,6L,3L,0L,8L,4L,1L,6L,5L,4L,1L,0L,2L,6L,9L,4L,4L,0L,9L,0L,0L,3L,3L,4L,9L,1L,4L,3L,4L,0L,6L,7L,6L,5L,8L,4L,1L,4L,6L,1L,0L,4L,1L,1L,6L,7L,4L,2L,5L,9L,5L,3L,5L,3L,0L,0L,2L,3L,6L,6L,2L,4L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200614Inst : IEnumerable<long>
{
public static readonly long[] Value=A200614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200614.Bytes);
public long this[int i]=>Value[i];

public static A200614Inst Instance=new A200614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200615
{
public static readonly long[] Value={ 1L,3L,5L,0L,9L,5L,6L,5L,9L,3L,9L,7L,6L,5L,1L,9L,3L,9L,7L,7L,4L,4L,6L,9L,6L,2L,9L,4L,3L,6L,8L,5L,2L,4L,7L,1L,5L,3L,7L,3L,0L,3L,7L,3L,0L,1L,6L,7L,5L,8L,8L,2L,5L,6L,2L,9L,7L,8L,8L,4L,4L,6L,2L,0L,4L,7L,6L,6L,0L,1L,7L,1L,8L,4L,6L,3L,4L,3L,8L,0L,2L,8L,2L,8L,5L,3L,9L,6L,5L,0L,6L,3L,4L,5L,9L,4L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200615Inst : IEnumerable<long>
{
public static readonly long[] Value=A200615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200615.Bytes);
public long this[int i]=>Value[i];

public static A200615Inst Instance=new A200615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200616
{
public static readonly long[] Value={ 6L,6L,9L,1L,0L,2L,9L,7L,2L,0L,2L,3L,5L,7L,5L,4L,1L,6L,0L,7L,6L,6L,0L,1L,2L,5L,0L,1L,8L,8L,4L,5L,6L,9L,8L,2L,4L,5L,6L,2L,2L,7L,9L,4L,4L,3L,8L,7L,1L,8L,5L,6L,4L,3L,3L,0L,1L,1L,5L,8L,3L,0L,0L,2L,1L,7L,3L,9L,4L,9L,8L,4L,0L,8L,4L,2L,6L,3L,7L,2L,4L,5L,6L,0L,2L,7L,9L,3L,9L,0L,4L,3L,4L,2L,2L,9L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200616Inst : IEnumerable<long>
{
public static readonly long[] Value=A200616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200616.Bytes);
public long this[int i]=>Value[i];

public static A200616Inst Instance=new A200616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200617
{
public static readonly long[] Value={ 1L,4L,3L,3L,0L,6L,8L,7L,8L,5L,5L,8L,4L,9L,1L,6L,8L,7L,5L,2L,2L,6L,7L,8L,2L,7L,1L,7L,5L,9L,6L,7L,2L,8L,7L,7L,0L,2L,2L,0L,9L,2L,4L,0L,2L,6L,8L,4L,7L,5L,6L,2L,1L,5L,0L,8L,5L,0L,2L,2L,7L,6L,3L,4L,2L,5L,3L,1L,1L,6L,8L,1L,0L,4L,7L,6L,9L,2L,5L,0L,7L,4L,5L,8L,6L,3L,1L,9L,1L,6L,5L,0L,3L,1L,8L,1L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200617Inst : IEnumerable<long>
{
public static readonly long[] Value=A200617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200617.Bytes);
public long this[int i]=>Value[i];

public static A200617Inst Instance=new A200617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200618
{
public static readonly long[] Value={ 1L,4L,7L,9L,7L,0L,5L,2L,0L,2L,2L,4L,4L,3L,5L,8L,0L,5L,9L,6L,7L,5L,1L,2L,3L,9L,9L,3L,9L,5L,2L,3L,3L,1L,8L,5L,2L,9L,5L,9L,7L,1L,4L,2L,1L,5L,4L,9L,5L,0L,2L,7L,0L,7L,2L,5L,0L,2L,7L,0L,3L,7L,3L,0L,9L,6L,1L,2L,0L,6L,4L,7L,5L,6L,5L,6L,3L,2L,5L,7L,0L,7L,7L,0L,5L,0L,5L,6L,0L,4L,9L,0L,5L,9L,9L,4L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200618Inst : IEnumerable<long>
{
public static readonly long[] Value=A200618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200618.Bytes);
public long this[int i]=>Value[i];

public static A200618Inst Instance=new A200618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200619
{
public static readonly long[] Value={ 1L,4L,5L,0L,1L,4L,9L,5L,5L,1L,5L,6L,1L,7L,6L,7L,7L,4L,0L,8L,6L,2L,2L,1L,6L,8L,3L,0L,9L,0L,9L,2L,2L,0L,1L,3L,5L,2L,4L,3L,6L,4L,2L,6L,2L,5L,8L,8L,4L,3L,7L,3L,6L,0L,4L,2L,0L,3L,1L,0L,5L,7L,9L,5L,4L,0L,8L,6L,8L,1L,5L,2L,0L,3L,9L,9L,4L,3L,4L,1L,8L,7L,2L,2L,5L,9L,1L,2L,8L,2L,6L,7L,0L,7L,2L,4L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200619Inst : IEnumerable<long>
{
public static readonly long[] Value=A200619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200619.Bytes);
public long this[int i]=>Value[i];

public static A200619Inst Instance=new A200619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200620
{
public static readonly long[] Value={ 5L,7L,3L,8L,2L,5L,6L,1L,4L,2L,2L,0L,7L,0L,7L,5L,1L,9L,4L,7L,0L,6L,9L,9L,3L,0L,7L,3L,9L,5L,0L,2L,8L,9L,7L,2L,0L,4L,0L,0L,1L,2L,6L,2L,0L,5L,6L,7L,5L,7L,0L,8L,3L,3L,8L,2L,7L,1L,3L,0L,1L,2L,7L,4L,1L,8L,7L,9L,3L,4L,4L,0L,9L,7L,0L,1L,7L,1L,2L,2L,0L,9L,2L,8L,2L,1L,3L,3L,5L,3L,7L,0L,0L,6L,1L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200620Inst : IEnumerable<long>
{
public static readonly long[] Value=A200620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200620.Bytes);
public long this[int i]=>Value[i];

public static A200620Inst Instance=new A200620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200621
{
public static readonly long[] Value={ 1L,4L,6L,9L,0L,0L,2L,7L,1L,9L,5L,1L,3L,6L,1L,0L,6L,1L,3L,2L,2L,3L,3L,6L,2L,5L,9L,7L,5L,8L,3L,6L,3L,2L,4L,1L,1L,2L,7L,8L,0L,0L,0L,3L,4L,6L,1L,5L,3L,5L,7L,4L,6L,4L,8L,5L,8L,8L,7L,7L,3L,5L,8L,6L,2L,2L,8L,1L,7L,2L,0L,1L,8L,4L,8L,3L,0L,6L,1L,0L,4L,5L,6L,4L,2L,4L,9L,0L,1L,9L,0L,6L,6L,9L,7L,6L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200621Inst : IEnumerable<long>
{
public static readonly long[] Value=A200621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200621.Bytes);
public long this[int i]=>Value[i];

public static A200621Inst Instance=new A200621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200622
{
public static readonly long[] Value={ 7L,7L,0L,8L,9L,6L,8L,8L,3L,9L,1L,4L,2L,7L,7L,1L,8L,2L,8L,3L,7L,2L,6L,4L,9L,2L,7L,3L,5L,8L,7L,0L,6L,3L,2L,1L,8L,6L,8L,7L,5L,4L,8L,4L,3L,3L,6L,1L,9L,2L,8L,8L,8L,3L,4L,1L,1L,0L,9L,3L,2L,0L,8L,9L,6L,3L,2L,6L,1L,7L,9L,1L,3L,9L,9L,0L,3L,8L,2L,1L,8L,6L,6L,4L,7L,7L,7L,3L,0L,9L,1L,9L,7L,1L,1L,5L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200622Inst : IEnumerable<long>
{
public static readonly long[] Value=A200622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200622.Bytes);
public long this[int i]=>Value[i];

public static A200622Inst Instance=new A200622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200623
{
public static readonly long[] Value={ 1L,4L,5L,4L,7L,9L,9L,2L,1L,3L,5L,1L,9L,9L,9L,5L,5L,2L,6L,3L,7L,0L,7L,8L,4L,3L,0L,0L,7L,9L,8L,9L,4L,4L,5L,8L,9L,0L,1L,2L,6L,0L,8L,7L,1L,2L,0L,1L,7L,0L,7L,4L,3L,1L,5L,0L,0L,2L,1L,9L,3L,2L,6L,9L,3L,9L,2L,3L,5L,3L,2L,2L,1L,5L,8L,0L,0L,0L,6L,1L,6L,9L,5L,4L,5L,8L,6L,7L,0L,2L,0L,8L,8L,7L,6L,7L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200623Inst : IEnumerable<long>
{
public static readonly long[] Value=A200623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200623.Bytes);
public long this[int i]=>Value[i];

public static A200623Inst Instance=new A200623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200624
{
public static readonly long[] Value={ 9L,3L,2L,5L,1L,7L,0L,5L,1L,8L,6L,4L,2L,2L,9L,4L,8L,1L,9L,4L,9L,8L,5L,7L,1L,8L,9L,8L,9L,3L,1L,3L,9L,9L,8L,9L,7L,6L,4L,9L,1L,7L,3L,6L,7L,7L,6L,1L,8L,0L,6L,4L,5L,2L,3L,9L,0L,8L,8L,9L,6L,8L,9L,1L,4L,2L,8L,6L,3L,2L,4L,8L,6L,6L,9L,2L,4L,5L,1L,5L,4L,5L,3L,2L,2L,7L,7L,0L,3L,8L,6L,5L,7L,0L,6L,4L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200624Inst : IEnumerable<long>
{
public static readonly long[] Value=A200624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200624.Bytes);
public long this[int i]=>Value[i];

public static A200624Inst Instance=new A200624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200625
{
public static readonly long[] Value={ 1L,4L,3L,4L,4L,3L,6L,7L,9L,8L,5L,3L,1L,0L,6L,4L,8L,8L,2L,7L,1L,8L,8L,6L,4L,3L,5L,1L,3L,5L,4L,3L,3L,5L,8L,5L,0L,3L,4L,3L,9L,6L,6L,8L,1L,5L,1L,2L,5L,3L,6L,8L,1L,7L,1L,8L,4L,8L,5L,3L,0L,2L,3L,6L,4L,7L,1L,1L,6L,6L,0L,5L,2L,5L,8L,3L,9L,9L,2L,6L,4L,1L,9L,5L,5L,1L,8L,5L,9L,7L,6L,8L,1L,3L,6L,1L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200625Inst : IEnumerable<long>
{
public static readonly long[] Value=A200625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200625.Bytes);
public long this[int i]=>Value[i];

public static A200625Inst Instance=new A200625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200626
{
public static readonly long[] Value={ 1L,0L,8L,6L,2L,4L,8L,3L,0L,7L,3L,7L,2L,3L,5L,1L,4L,9L,3L,0L,5L,1L,6L,5L,3L,7L,4L,7L,0L,2L,5L,7L,9L,0L,1L,3L,0L,2L,1L,1L,1L,2L,7L,3L,5L,5L,4L,3L,6L,3L,1L,5L,1L,1L,7L,1L,8L,9L,4L,2L,5L,9L,8L,4L,9L,7L,6L,9L,4L,5L,4L,7L,8L,5L,2L,6L,3L,5L,8L,1L,9L,0L,8L,9L,9L,5L,8L,4L,4L,2L,6L,6L,5L,2L,0L,8L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200626Inst : IEnumerable<long>
{
public static readonly long[] Value=A200626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200626.Bytes);
public long this[int i]=>Value[i];

public static A200626Inst Instance=new A200626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200627
{
public static readonly long[] Value={ 1L,4L,0L,0L,1L,0L,2L,5L,5L,5L,3L,3L,6L,9L,4L,1L,7L,4L,1L,8L,3L,1L,9L,5L,9L,3L,7L,1L,5L,7L,1L,5L,8L,5L,4L,7L,3L,0L,5L,3L,8L,8L,4L,6L,9L,6L,6L,3L,4L,1L,9L,0L,6L,0L,7L,3L,0L,4L,4L,3L,6L,4L,3L,4L,4L,5L,2L,6L,9L,3L,7L,2L,9L,0L,5L,1L,9L,5L,1L,5L,7L,0L,3L,3L,9L,8L,8L,1L,7L,5L,6L,5L,2L,3L,4L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200627Inst : IEnumerable<long>
{
public static readonly long[] Value=A200627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200627.Bytes);
public long this[int i]=>Value[i];

public static A200627Inst Instance=new A200627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200628
{
public static readonly long[] Value={ 1L,4L,8L,8L,1L,5L,5L,7L,7L,9L,6L,4L,7L,9L,2L,1L,7L,1L,7L,9L,5L,9L,5L,7L,4L,1L,1L,8L,6L,2L,8L,2L,0L,9L,8L,6L,9L,0L,4L,1L,7L,5L,4L,3L,2L,8L,2L,8L,2L,0L,5L,8L,8L,7L,8L,0L,2L,4L,6L,8L,3L,1L,2L,7L,1L,9L,9L,4L,1L,8L,6L,6L,6L,5L,2L,9L,0L,2L,8L,1L,9L,3L,5L,9L,6L,1L,8L,3L,2L,7L,7L,0L,3L,9L,1L,9L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200628Inst : IEnumerable<long>
{
public static readonly long[] Value=A200628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200628.Bytes);
public long this[int i]=>Value[i];

public static A200628Inst Instance=new A200628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200629
{
public static readonly long[] Value={ 1L,4L,9L,5L,0L,4L,4L,8L,0L,5L,5L,6L,5L,1L,6L,7L,7L,4L,0L,1L,1L,5L,2L,3L,9L,3L,6L,2L,5L,4L,5L,5L,1L,6L,4L,4L,9L,5L,9L,6L,7L,8L,9L,7L,9L,7L,5L,8L,1L,1L,8L,6L,0L,1L,7L,8L,9L,9L,1L,6L,5L,8L,0L,7L,7L,7L,5L,8L,9L,0L,4L,4L,2L,1L,6L,0L,4L,8L,2L,1L,0L,7L,2L,5L,3L,7L,1L,7L,4L,1L,4L,5L,7L,5L,1L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200629Inst : IEnumerable<long>
{
public static readonly long[] Value=A200629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200629.Bytes);
public long this[int i]=>Value[i];

public static A200629Inst Instance=new A200629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200630
{
public static readonly long[] Value={ 1L,5L,0L,0L,7L,9L,4L,0L,8L,1L,5L,3L,5L,0L,7L,9L,3L,8L,1L,8L,8L,2L,2L,5L,2L,4L,7L,6L,5L,5L,7L,5L,7L,1L,7L,5L,2L,3L,2L,6L,5L,9L,6L,2L,1L,4L,4L,7L,6L,4L,8L,8L,8L,1L,1L,3L,0L,0L,7L,9L,7L,8L,7L,7L,2L,5L,1L,6L,0L,0L,7L,1L,1L,3L,2L,4L,4L,3L,1L,8L,8L,3L,5L,0L,5L,1L,0L,3L,5L,1L,6L,3L,9L,0L,7L,1L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200630Inst : IEnumerable<long>
{
public static readonly long[] Value=A200630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200630.Bytes);
public long this[int i]=>Value[i];

public static A200630Inst Instance=new A200630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200631
{
public static readonly long[] Value={ 1L,5L,0L,5L,6L,7L,9L,7L,3L,4L,4L,8L,8L,3L,8L,7L,0L,0L,6L,2L,2L,6L,5L,5L,8L,5L,8L,7L,6L,7L,7L,6L,1L,2L,5L,6L,6L,5L,2L,3L,7L,8L,2L,2L,9L,0L,1L,8L,1L,6L,9L,5L,3L,9L,4L,7L,6L,1L,9L,6L,2L,9L,6L,8L,2L,9L,7L,6L,1L,9L,1L,2L,0L,1L,7L,9L,3L,4L,5L,1L,0L,7L,5L,9L,4L,8L,9L,5L,5L,5L,7L,3L,1L,6L,6L,6L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200631Inst : IEnumerable<long>
{
public static readonly long[] Value=A200631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200631.Bytes);
public long this[int i]=>Value[i];

public static A200631Inst Instance=new A200631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200632
{
public static readonly long[] Value={ 1L,4L,9L,6L,5L,1L,3L,6L,4L,8L,2L,6L,7L,2L,5L,4L,1L,7L,0L,8L,4L,0L,7L,6L,6L,7L,6L,9L,1L,9L,8L,0L,8L,8L,3L,7L,0L,7L,2L,1L,2L,0L,8L,4L,9L,0L,1L,4L,3L,4L,3L,6L,3L,3L,8L,7L,5L,9L,3L,5L,1L,5L,0L,0L,4L,0L,0L,3L,5L,0L,5L,4L,0L,0L,8L,3L,0L,0L,9L,3L,9L,3L,2L,2L,6L,0L,7L,5L,9L,7L,9L,9L,4L,1L,5L,6L,1L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200632Inst : IEnumerable<long>
{
public static readonly long[] Value=A200632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200632.Bytes);
public long this[int i]=>Value[i];

public static A200632Inst Instance=new A200632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200633
{
public static readonly long[] Value={ 5L,0L,9L,7L,4L,1L,7L,0L,8L,9L,1L,8L,5L,4L,8L,4L,8L,9L,2L,4L,6L,0L,4L,9L,6L,6L,5L,8L,5L,2L,5L,8L,6L,8L,6L,2L,7L,0L,8L,3L,1L,7L,8L,6L,0L,0L,8L,3L,0L,9L,5L,8L,7L,7L,8L,7L,4L,7L,1L,7L,9L,9L,7L,5L,2L,7L,3L,3L,5L,2L,6L,3L,9L,7L,6L,8L,4L,6L,6L,8L,7L,4L,2L,1L,8L,0L,2L,1L,7L,9L,8L,8L,3L,0L,5L,1L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200633Inst : IEnumerable<long>
{
public static readonly long[] Value=A200633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200633.Bytes);
public long this[int i]=>Value[i];

public static A200633Inst Instance=new A200633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200634
{
public static readonly long[] Value={ 1L,4L,8L,9L,7L,8L,3L,6L,5L,6L,0L,8L,3L,4L,9L,8L,2L,2L,0L,9L,6L,6L,8L,1L,7L,9L,8L,6L,8L,6L,0L,6L,7L,1L,4L,7L,5L,0L,4L,2L,6L,1L,4L,1L,5L,1L,4L,5L,8L,4L,9L,3L,2L,5L,8L,7L,9L,8L,2L,4L,1L,9L,1L,4L,6L,2L,0L,1L,1L,9L,1L,7L,6L,2L,2L,0L,1L,7L,8L,7L,0L,3L,4L,0L,1L,8L,8L,7L,0L,9L,4L,1L,5L,0L,3L,8L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200634Inst : IEnumerable<long>
{
public static readonly long[] Value=A200634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200634.Bytes);
public long this[int i]=>Value[i];

public static A200634Inst Instance=new A200634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200635
{
public static readonly long[] Value={ 1L,0L,6L,5L,0L,2L,1L,6L,2L,0L,6L,1L,8L,7L,0L,7L,9L,0L,0L,2L,9L,4L,9L,3L,5L,9L,3L,6L,1L,1L,9L,5L,2L,2L,7L,3L,3L,0L,1L,3L,2L,2L,7L,0L,0L,8L,8L,5L,6L,6L,5L,4L,2L,2L,2L,0L,2L,6L,8L,6L,1L,0L,7L,3L,2L,6L,6L,7L,7L,2L,0L,2L,9L,0L,1L,1L,1L,2L,4L,3L,0L,9L,1L,0L,0L,6L,8L,5L,2L,3L,6L,7L,9L,8L,8L,5L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200635Inst : IEnumerable<long>
{
public static readonly long[] Value=A200635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200635.Bytes);
public long this[int i]=>Value[i];

public static A200635Inst Instance=new A200635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200636
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,7L,2L,7L,9L,7L,7L,4L,7L,7L,2L,7L,8L,3L,9L,7L,3L,7L,7L,5L,9L,5L,7L,1L,3L,6L,3L,1L,8L,0L,6L,3L,4L,7L,5L,2L,4L,1L,9L,4L,0L,1L,6L,2L,8L,5L,6L,2L,7L,2L,5L,4L,8L,4L,5L,2L,6L,7L,0L,5L,9L,8L,1L,8L,9L,4L,9L,9L,2L,6L,7L,0L,0L,1L,3L,6L,4L,5L,6L,5L,8L,9L,7L,8L,0L,1L,1L,3L,5L,1L,5L,1L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200636Inst : IEnumerable<long>
{
public static readonly long[] Value=A200636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200636.Bytes);
public long this[int i]=>Value[i];

public static A200636Inst Instance=new A200636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200637
{
public static readonly long[] Value={ 1L,5L,0L,2L,1L,2L,0L,1L,4L,3L,8L,3L,3L,5L,6L,9L,4L,1L,6L,1L,1L,2L,7L,7L,2L,8L,4L,6L,0L,5L,8L,0L,3L,1L,5L,1L,0L,3L,5L,5L,8L,3L,4L,9L,0L,3L,9L,4L,0L,5L,9L,0L,0L,9L,6L,5L,9L,2L,3L,7L,4L,1L,9L,4L,7L,1L,7L,7L,4L,0L,5L,6L,5L,6L,1L,1L,8L,3L,9L,8L,4L,1L,0L,4L,2L,9L,0L,9L,5L,9L,8L,2L,2L,7L,5L,1L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200637Inst : IEnumerable<long>
{
public static readonly long[] Value=A200637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200637.Bytes);
public long this[int i]=>Value[i];

public static A200637Inst Instance=new A200637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200638
{
public static readonly long[] Value={ 1L,5L,1L,7L,7L,1L,3L,3L,1L,8L,6L,7L,9L,0L,9L,2L,8L,1L,6L,9L,8L,6L,2L,5L,5L,9L,8L,1L,2L,0L,6L,5L,2L,1L,7L,2L,8L,5L,5L,8L,1L,6L,4L,1L,1L,3L,4L,9L,5L,3L,8L,8L,9L,0L,3L,4L,6L,3L,7L,0L,3L,8L,2L,5L,0L,0L,3L,3L,7L,7L,3L,3L,9L,4L,0L,2L,0L,0L,7L,6L,5L,9L,7L,8L,7L,3L,0L,5L,2L,7L,6L,4L,8L,0L,5L,4L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200638Inst : IEnumerable<long>
{
public static readonly long[] Value=A200638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200638.Bytes);
public long this[int i]=>Value[i];

public static A200638Inst Instance=new A200638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200639
{
public static readonly long[] Value={ 1L,4L,2L,9L,7L,7L,9L,1L,8L,9L,1L,9L,0L,6L,0L,7L,6L,4L,8L,7L,2L,8L,6L,6L,8L,9L,1L,7L,2L,2L,2L,1L,3L,4L,2L,4L,9L,2L,0L,7L,9L,5L,2L,2L,5L,8L,4L,8L,0L,0L,0L,2L,9L,9L,9L,7L,5L,0L,4L,0L,7L,7L,4L,9L,5L,6L,6L,3L,0L,1L,2L,5L,2L,3L,2L,0L,5L,0L,3L,9L,5L,7L,4L,5L,4L,6L,1L,0L,8L,7L,0L,3L,9L,9L,0L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200639Inst : IEnumerable<long>
{
public static readonly long[] Value=A200639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200639.Bytes);
public long this[int i]=>Value[i];

public static A200639Inst Instance=new A200639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200640
{
public static readonly long[] Value={ 1L,4L,6L,3L,4L,9L,3L,5L,3L,1L,5L,8L,7L,8L,1L,6L,7L,8L,7L,4L,0L,1L,6L,4L,7L,0L,5L,3L,7L,9L,7L,8L,9L,8L,2L,6L,9L,2L,6L,3L,6L,0L,4L,4L,4L,4L,6L,0L,2L,7L,9L,9L,8L,9L,4L,3L,6L,4L,5L,5L,2L,2L,7L,9L,3L,0L,9L,3L,0L,8L,2L,4L,3L,2L,8L,1L,2L,2L,1L,4L,9L,4L,7L,6L,6L,4L,6L,1L,6L,8L,1L,5L,1L,0L,3L,9L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200640Inst : IEnumerable<long>
{
public static readonly long[] Value=A200640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200640.Bytes);
public long this[int i]=>Value[i];

public static A200640Inst Instance=new A200640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200641
{
public static readonly long[] Value={ 1L,4L,8L,4L,9L,1L,1L,7L,2L,5L,4L,2L,5L,8L,9L,4L,5L,5L,7L,9L,6L,7L,6L,2L,3L,6L,4L,1L,7L,8L,4L,7L,2L,8L,0L,8L,3L,2L,8L,1L,7L,5L,4L,7L,2L,0L,3L,6L,3L,7L,8L,2L,4L,0L,1L,7L,8L,5L,5L,8L,9L,2L,2L,1L,4L,7L,5L,8L,2L,0L,2L,7L,0L,3L,1L,1L,8L,3L,5L,3L,2L,7L,4L,8L,5L,1L,3L,0L,2L,4L,8L,3L,7L,8L,5L,6L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200641Inst : IEnumerable<long>
{
public static readonly long[] Value=A200641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200641.Bytes);
public long this[int i]=>Value[i];

public static A200641Inst Instance=new A200641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200642
{
public static readonly long[] Value={ 1L,4L,9L,9L,4L,5L,5L,6L,9L,7L,1L,2L,8L,7L,3L,0L,9L,7L,4L,2L,7L,9L,9L,3L,6L,4L,0L,4L,3L,1L,7L,2L,1L,6L,3L,6L,5L,2L,6L,3L,3L,8L,1L,8L,9L,4L,6L,1L,2L,9L,8L,9L,5L,2L,4L,8L,6L,0L,5L,6L,6L,9L,2L,5L,8L,1L,6L,9L,7L,5L,3L,9L,3L,4L,7L,5L,7L,0L,1L,9L,7L,8L,8L,1L,3L,5L,4L,5L,0L,3L,1L,3L,3L,4L,4L,2L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200642Inst : IEnumerable<long>
{
public static readonly long[] Value=A200642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200642.Bytes);
public long this[int i]=>Value[i];

public static A200642Inst Instance=new A200642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200643
{
public static readonly long[] Value={ 1L,5L,0L,8L,0L,6L,3L,8L,7L,5L,0L,8L,5L,6L,5L,4L,9L,9L,0L,0L,6L,8L,7L,1L,0L,4L,0L,4L,9L,4L,2L,1L,0L,1L,5L,5L,9L,2L,6L,1L,7L,9L,8L,8L,8L,2L,3L,7L,2L,4L,0L,6L,5L,2L,3L,2L,8L,7L,9L,4L,8L,7L,4L,1L,5L,0L,7L,5L,0L,7L,9L,6L,8L,6L,8L,2L,1L,4L,7L,9L,7L,9L,8L,6L,3L,5L,9L,0L,5L,9L,2L,9L,5L,6L,1L,7L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200643Inst : IEnumerable<long>
{
public static readonly long[] Value=A200643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200643.Bytes);
public long this[int i]=>Value[i];

public static A200643Inst Instance=new A200643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200644
{
public static readonly long[] Value={ 1L,5L,1L,6L,4L,9L,6L,2L,8L,2L,9L,2L,4L,1L,2L,3L,7L,5L,6L,0L,1L,2L,7L,2L,8L,3L,5L,2L,0L,3L,1L,5L,7L,9L,9L,8L,6L,5L,2L,6L,3L,3L,7L,8L,1L,3L,5L,1L,5L,9L,5L,1L,0L,2L,4L,6L,2L,3L,9L,5L,4L,7L,5L,8L,3L,6L,1L,7L,1L,8L,0L,3L,8L,9L,5L,8L,4L,7L,1L,9L,0L,2L,7L,0L,8L,7L,4L,7L,6L,7L,8L,5L,4L,5L,5L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200644Inst : IEnumerable<long>
{
public static readonly long[] Value=A200644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200644.Bytes);
public long this[int i]=>Value[i];

public static A200644Inst Instance=new A200644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200645
{
public static readonly long[] Value={ 1L,5L,2L,2L,9L,2L,5L,8L,1L,4L,4L,6L,9L,9L,6L,5L,5L,3L,7L,6L,7L,3L,6L,6L,4L,3L,8L,7L,6L,6L,5L,1L,9L,9L,6L,6L,1L,6L,6L,2L,7L,3L,7L,1L,7L,8L,3L,3L,6L,5L,2L,6L,2L,1L,9L,4L,7L,2L,9L,4L,8L,1L,1L,4L,6L,5L,6L,1L,4L,2L,5L,9L,5L,1L,2L,3L,6L,9L,4L,1L,8L,7L,8L,9L,0L,3L,2L,4L,3L,4L,6L,7L,3L,6L,3L,4L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200645Inst : IEnumerable<long>
{
public static readonly long[] Value=A200645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200645.Bytes);
public long this[int i]=>Value[i];

public static A200645Inst Instance=new A200645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200646
{
public static readonly long[] Value={ 1L,5L,2L,7L,9L,9L,1L,4L,9L,7L,9L,1L,3L,9L,9L,9L,9L,1L,7L,1L,7L,1L,1L,3L,4L,3L,8L,4L,8L,6L,1L,4L,5L,5L,9L,3L,8L,6L,7L,7L,1L,6L,3L,1L,6L,6L,2L,6L,2L,4L,0L,5L,2L,1L,3L,0L,3L,4L,4L,9L,0L,9L,0L,9L,0L,1L,8L,8L,7L,9L,9L,3L,0L,3L,3L,9L,8L,1L,7L,9L,9L,3L,7L,4L,9L,7L,0L,5L,9L,2L,0L,4L,5L,3L,4L,3L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200646Inst : IEnumerable<long>
{
public static readonly long[] Value=A200646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200646.Bytes);
public long this[int i]=>Value[i];

public static A200646Inst Instance=new A200646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200647
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,4L,2L,1L,2L,3L,4L,4L,3L,2L,3L,2L,2L,3L,4L,4L,3L,4L,5L,4L,2L,3L,4L,2L,1L,2L,3L,4L,4L,3L,4L,5L,4L,4L,5L,6L,4L,3L,2L,3L,4L,4L,3L,2L,3L,2L,2L,3L,4L,4L,3L,4L,5L,4L,4L,5L,6L,4L,3L,4L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200647Inst : IEnumerable<long>
{
public static readonly long[] Value=A200647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200647.Bytes);
public long this[int i]=>Value[i];

public static A200647Inst Instance=new A200647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200648
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,6L,4L,5L,5L,5L,6L,5L,5L,6L,5L,6L,6L,6L,7L,5L,5L,6L,5L,6L,6L,6L,7L,5L,6L,6L,6L,7L,6L,6L,7L,6L,7L,7L,7L,8L,5L,6L,6L,6L,7L,6L,6L,7L,6L,7L,7L,7L,8L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200648Inst : IEnumerable<long>
{
public static readonly long[] Value=A200648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200648.Bytes);
public long this[int i]=>Value[i];

public static A200648Inst Instance=new A200648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200649
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,2L,4L,1L,3L,3L,3L,5L,2L,2L,4L,2L,4L,4L,4L,6L,1L,3L,3L,3L,5L,3L,3L,5L,3L,5L,5L,5L,7L,2L,2L,4L,2L,4L,4L,4L,6L,2L,4L,4L,4L,6L,4L,4L,6L,4L,6L,6L,6L,8L,1L,3L,3L,3L,5L,3L,3L,5L,3L,5L,5L,5L,7L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200649Inst : IEnumerable<long>
{
public static readonly long[] Value=A200649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200649.Bytes);
public long this[int i]=>Value[i];

public static A200649Inst Instance=new A200649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200650
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,1L,0L,2L,2L,1L,2L,1L,1L,1L,0L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L,3L,3L,3L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L,4L,3L,4L,3L,3L,3L,2L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200650Inst : IEnumerable<long>
{
public static readonly long[] Value=A200650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200650.Bytes);
public long this[int i]=>Value[i];

public static A200650Inst Instance=new A200650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200651
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,1L,2L,3L,3L,2L,1L,4L,3L,3L,2L,3L,3L,2L,1L,2L,5L,3L,4L,3L,4L,3L,3L,2L,3L,3L,2L,1L,4L,3L,5L,4L,3L,5L,4L,3L,2L,5L,3L,4L,3L,4L,3L,3L,2L,3L,3L,2L,1L,2L,5L,3L,6L,5L,5L,4L,3L,4L,5L,5L,4L,3L,4L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200651Inst : IEnumerable<long>
{
public static readonly long[] Value=A200651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200651.Bytes);
public long this[int i]=>Value[i];

public static A200651Inst Instance=new A200651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200652
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,-1L,3L,-1L,11L,0L,5L,23L,9L,17L,-1L,9L,5L,5L,0L,-1L,-1L,15L,17L,-1L,9L,0L,53L,9L,11L,0L,27L,5L,29L,39L,17L,0L,21L,-1L,47L,27L,-1L,65L,39L,17L,11L,75L,11L,29L,0L,-1L,5L,33L,0L,-1L,39L,59L,23L,39L,-1L,11L,39L,11L,17L,57L,47L,-1L,81L,29L,101L,39L,119L,23L,15L,89L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200652Inst : IEnumerable<long>
{
public static readonly long[] Value=A200652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200652.Bytes);
public long this[int i]=>Value[i];

public static A200652Inst Instance=new A200652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200653
{
public static readonly long[] Value={ 1L,-1L,5L,0L,-1L,-1L,3L,-1L,17L,0L,17L,23L,15L,17L,29L,9L,5L,5L,0L,11L,-1L,15L,17L,41L,9L,0L,53L,45L,11L,0L,57L,35L,29L,39L,59L,0L,45L,5L,59L,57L,65L,71L,57L,47L,71L,75L,83L,29L,0L,41L,77L,45L,0L,29L,87L,107L,83L,105L,41L,107L,69L,113L,125L,111L,47L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200653Inst : IEnumerable<long>
{
public static readonly long[] Value=A200653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200653.Bytes);
public long this[int i]=>Value[i];

public static A200653Inst Instance=new A200653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200654
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,27L,9L,2L,6L,7L,5L,14L,1L,5L,3L,10L,1L,15L,93L,36L,33L,5L,18L,1L,18L,1L,2L,28L,2L,10L,8L,1L,34L,11L,12L,3L,2L,116L,4L,52L,31L,29L,18L,42L,13L,32L,24L,71L,93L,122L,61L,75L,11L,141L,73L,31L,57L,36L,23L,43L,18L,15L,69L,33L,15L,10L,39L,8L,108L,29L,72L,7L,8L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200654Inst : IEnumerable<long>
{
public static readonly long[] Value=A200654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200654.Bytes);
public long this[int i]=>Value[i];

public static A200654Inst Instance=new A200654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200655
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,19L,20L,23L,96L,190L,312L,400L,434L,852L,980L,1063L,1208L,3960L,5464L,6694L,7178L,13118L,13680L,18803L,27445L,28541L,42031L,73209L,83873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200655Inst : IEnumerable<long>
{
public static readonly long[] Value=A200655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200655.Bytes);
public long this[int i]=>Value[i];

public static A200655Inst Instance=new A200655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200656
{
public static readonly long[] Value={ 1942L,2878L,3862L,6100L,8380L,11512L,15448L,18694L,31228L,93844L,111382L,117118L,129910L,143950L,186145L,210025L,375376L,445528L,468472L,575800L,844596L,1002438L,1054062L,1193740L,1248412L,1326025L,1388545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200656Inst : IEnumerable<long>
{
public static readonly long[] Value=A200656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200656.Bytes);
public long this[int i]=>Value[i];

public static A200656Inst Instance=new A200656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200657
{
public static readonly long[] Value={ 85580L,154396L,240004L,476425L,767125L,1235168L,1920032L,2555956L,5518439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200657Inst : IEnumerable<long>
{
public static readonly long[] Value=A200657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200657.Bytes);
public long this[int i]=>Value[i];

public static A200657Inst Instance=new A200657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200658
{
public static readonly long[] Value={ 52488L,15336L,-20088L,219375L,-293625L,981504L,-1285632L,-474552L,1367631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200658Inst : IEnumerable<long>
{
public static readonly long[] Value=A200658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200658.Bytes);
public long this[int i]=>Value[i];

public static A200658Inst Instance=new A200658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200659
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,13L,21L,9L,1L,71L,132L,76L,16L,1L,461L,955L,670L,200L,25L,1L,3447L,7782L,6309L,2374L,435L,36L,1L,29093L,70441L,63833L,28413L,6713L,833L,49L,1L,273343L,701352L,694500L,351512L,99868L,16240L,1456L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200659Inst : IEnumerable<long>
{
public static readonly long[] Value=A200659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200659.Bytes);
public long this[int i]=>Value[i];

public static A200659Inst Instance=new A200659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200660
{
public static readonly long[] Value={ 0L,1L,8L,49L,284L,1658L,9974L,62375L,406832L,2769493L,19668054L,145559632L,1121153604L,8974604065L,74553168520L,641808575961L,5718014325296L,52653303354906L,500515404889978L,4905937052293759L,49530189989912312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200660Inst : IEnumerable<long>
{
public static readonly long[] Value=A200660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200660.Bytes);
public long this[int i]=>Value[i];

public static A200660Inst Instance=new A200660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200661
{
public static readonly long[] Value={ 2L,3L,5L,8L,12L,17L,25L,36L,51L,72L,102L,144L,202L,284L,399L,560L,785L,1101L,1544L,2164L,3033L,4251L,5958L,8349L,11700L,16396L,22976L,32196L,45116L,63221L,88590L,124139L,173953L,243756L,341568L,478629L,670689L,939816L,1316935L,1845380L,2585874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200661Inst : IEnumerable<long>
{
public static readonly long[] Value=A200661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200661.Bytes);
public long this[int i]=>Value[i];

public static A200661Inst Instance=new A200661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200662
{
public static readonly long[] Value={ 3L,6L,12L,24L,46L,89L,176L,350L,697L,1391L,2780L,5555L,11098L,22170L,44288L,88472L,176729L,353032L,705224L,1408771L,2814203L,5621746L,11230193L,22433834L,44814616L,89523251L,178834811L,357246713L,713648606L,1425609609L,2847847987L,5688961529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200662Inst : IEnumerable<long>
{
public static readonly long[] Value=A200662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200662.Bytes);
public long this[int i]=>Value[i];

public static A200662Inst Instance=new A200662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200663
{
public static readonly long[] Value={ 4L,10L,26L,69L,175L,432L,1076L,2671L,6627L,16421L,40695L,100886L,250093L,619947L,1536810L,3809790L,9444489L,23412999L,58041252L,143885484L,356695266L,884255363L,2192088651L,5434237397L,13471597487L,33396394603L,82790419927L,205239329905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200663Inst : IEnumerable<long>
{
public static readonly long[] Value=A200663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200663.Bytes);
public long this[int i]=>Value[i];

public static A200663Inst Instance=new A200663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200664
{
public static readonly long[] Value={ 5L,15L,45L,135L,406L,1217L,3650L,10959L,32941L,99044L,297812L,895494L,2692703L,8096855L,24346869L,73209872L,220138513L,661945308L,1990435887L,5985139586L,17997009753L,54116091662L,162724331983L,489303778636L,1471311543936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200664Inst : IEnumerable<long>
{
public static readonly long[] Value=A200664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200664.Bytes);
public long this[int i]=>Value[i];

public static A200664Inst Instance=new A200664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200665
{
public static readonly long[] Value={ 6L,21L,75L,267L,938L,3283L,11516L,40399L,141745L,497298L,1744684L,6121152L,21475315L,75342932L,264330011L,927363850L,3253519870L,11414498822L,40046099291L,140495874086L,492909198404L,1729299730308L,6066994825927L,21285162746386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200665Inst : IEnumerable<long>
{
public static readonly long[] Value=A200665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200665.Bytes);
public long this[int i]=>Value[i];

public static A200665Inst Instance=new A200665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200666
{
public static readonly long[] Value={ 7L,28L,112L,448L,1813L,7322L,29536L,119066L,479993L,1935168L,7802161L,31456852L,126827111L,511338342L,2061602939L,8311924900L,33511832745L,135112262286L,544742594039L,2196280995578L,8854916583356L,35701054472646L,143938712300001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200666Inst : IEnumerable<long>
{
public static readonly long[] Value=A200666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200666.Bytes);
public long this[int i]=>Value[i];

public static A200666Inst Instance=new A200666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200667
{
public static readonly long[] Value={ 8L,36L,164L,750L,3414L,15504L,70412L,319532L,1449895L,6578528L,29850070L,135443522L,614568094L,2788573700L,12653014693L,57412388798L,260505742646L,1182031264628L,5363405068469L,24336170423291L,110424101519685L,501043586283665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200667Inst : IEnumerable<long>
{
public static readonly long[] Value=A200667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200667.Bytes);
public long this[int i]=>Value[i];

public static A200667Inst Instance=new A200667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200668
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,12L,7L,21L,45L,69L,46L,17L,8L,28L,75L,135L,175L,89L,25L,9L,36L,112L,267L,406L,432L,176L,36L,10L,45L,164L,448L,938L,1217L,1076L,350L,51L,11L,55L,225L,750L,1813L,3283L,3650L,2671L,697L,72L,12L,66L,305L,1125L,3414L,7322L,11516L,10959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200668Inst : IEnumerable<long>
{
public static readonly long[] Value=A200668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200668.Bytes);
public long this[int i]=>Value[i];

public static A200668Inst Instance=new A200668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200669
{
public static readonly long[] Value={ 12L,46L,175L,406L,938L,1813L,3414L,5682L,9412L,14443L,22009L,31668L,45374L,62393L,85516L,113373L,149874L,193249L,248539L,312886L,393096L,485530L,598634L,727155L,881972L,1056600L,1264221L,1495936L,1768186L,2070552L,2422168L,2809532L,3256044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200669Inst : IEnumerable<long>
{
public static readonly long[] Value=A200669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200669.Bytes);
public long this[int i]=>Value[i];

public static A200669Inst Instance=new A200669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200670
{
public static readonly long[] Value={ 17L,89L,432L,1217L,3283L,7322L,15504L,28743L,52389L,87890L,145070L,225134L,345639L,507376L,738960L,1038003L,1448418L,1966975L,2656248L,3504620L,4603324L,5934897L,7622356L,9631810L,12132029L,15075684L,18682566L,22873460L,27937667L,33775988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200670Inst : IEnumerable<long>
{
public static readonly long[] Value=A200670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200670.Bytes);
public long this[int i]=>Value[i];

public static A200670Inst Instance=new A200670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200671
{
public static readonly long[] Value={ 25L,176L,1076L,3650L,11516L,29536L,70412L,145431L,291683L,534853L,956522L,1600651L,2633406L,4126715L,6386960L,9505210L,14002011L,20025031L,28396896L,39265235L,53923628L,72565437L,97086596L,127619975L,166939721L,215170884L,276186538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200671Inst : IEnumerable<long>
{
public static readonly long[] Value=A200671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200671.Bytes);
public long this[int i]=>Value[i];

public static A200671Inst Instance=new A200671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200672
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,13L,17L,21L,29L,37L,45L,61L,77L,93L,125L,157L,189L,253L,317L,381L,509L,637L,765L,1021L,1277L,1533L,2045L,2557L,3069L,4093L,5117L,6141L,8189L,10237L,12285L,16381L,20477L,24573L,32765L,40957L,49149L,65533L,81917L,98301L,131069L,163837L,196605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200672Inst : IEnumerable<long>
{
public static readonly long[] Value=A200672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200672.Bytes);
public long this[int i]=>Value[i];

public static A200672Inst Instance=new A200672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200673
{
public static readonly long[] Value={ 0L,0L,0L,1L,16L,170L,1549L,13253L,110970L,928822L,7862353L,67758488L,596837558L,5385257886L,49837119320L,473321736911L,4614233950422L,46168813528478L,474017189673555L,4992024759165631L,53902161267878974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200673Inst : IEnumerable<long>
{
public static readonly long[] Value=A200673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200673.Bytes);
public long this[int i]=>Value[i];

public static A200673Inst Instance=new A200673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200674
{
public static readonly long[] Value={ 0L,1L,9L,61L,385L,2365L,14353L,86605L,521089L,3130909L,18798577L,112830829L,677103073L,4062972733L,24378899281L,146276584333L,877669071937L,5266043129437L,31596344870065L,189578327500717L,1137470739845281L,6824826763594621L,40948967555136529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200674Inst : IEnumerable<long>
{
public static readonly long[] Value=A200674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200674.Bytes);
public long this[int i]=>Value[i];

public static A200674Inst Instance=new A200674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200675
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,4L,8L,8L,8L,8L,16L,16L,16L,16L,32L,32L,32L,32L,64L,64L,64L,64L,128L,128L,128L,128L,256L,256L,256L,256L,512L,512L,512L,512L,1024L,1024L,1024L,1024L,2048L,2048L,2048L,2048L,4096L,4096L,4096L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200675Inst : IEnumerable<long>
{
public static readonly long[] Value=A200675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200675.Bytes);
public long this[int i]=>Value[i];

public static A200675Inst Instance=new A200675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200676
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,22L,96L,419L,1829L,7984L,34852L,152137L,664113L,2899006L,12654828L,55241235L,241140697L,1052634608L,4594992184L,20058197793L,87558647021L,382213633910L,1668450426280L,7283169876691L,31792711738525L,138782499488832L,605817532105276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200676Inst : IEnumerable<long>
{
public static readonly long[] Value=A200676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200676.Bytes);
public long this[int i]=>Value[i];

public static A200676Inst Instance=new A200676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200677
{
public static readonly long[] Value={ 0L,0L,0L,4L,6L,9L,10L,15L,14L,21L,0L,35L,22L,33L,26L,39L,0L,65L,34L,51L,38L,57L,0L,95L,46L,69L,0L,115L,0L,161L,58L,87L,62L,93L,0L,155L,0L,217L,74L,111L,0L,185L,82L,123L,86L,129L,0L,215L,94L,141L,0L,235L,0L,329L,106L,159L,0L,265L,0L,371L,118L,177L,122L,183L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200677Inst : IEnumerable<long>
{
public static readonly long[] Value=A200677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200677.Bytes);
public long this[int i]=>Value[i];

public static A200677Inst Instance=new A200677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200678
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,16L,20L,24L,28L,36L,44L,52L,60L,76L,92L,108L,124L,156L,188L,220L,252L,316L,380L,444L,508L,636L,764L,892L,1020L,1276L,1532L,1788L,2044L,2556L,3068L,3580L,4092L,5116L,6140L,7164L,8188L,10236L,12284L,14332L,16380L,20476L,24572L,28668L,32764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200678Inst : IEnumerable<long>
{
public static readonly long[] Value=A200678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200678.Bytes);
public long this[int i]=>Value[i];

public static A200678Inst Instance=new A200678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200679
{
public static readonly long[] Value={ 5L,5L,9L,7L,0L,4L,1L,5L,2L,2L,7L,3L,0L,8L,0L,6L,5L,0L,6L,1L,0L,3L,7L,7L,2L,1L,2L,8L,3L,5L,8L,8L,0L,2L,2L,9L,6L,9L,7L,4L,6L,8L,1L,6L,7L,1L,2L,6L,5L,9L,3L,6L,9L,3L,1L,3L,4L,8L,7L,3L,7L,8L,2L,6L,9L,0L,2L,3L,0L,0L,6L,6L,4L,1L,2L,7L,2L,9L,0L,3L,8L,0L,8L,3L,0L,1L,0L,8L,7L,4L,2L,3L,3L,0L,6L,4L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200679Inst : IEnumerable<long>
{
public static readonly long[] Value=A200679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200679.Bytes);
public long this[int i]=>Value[i];

public static A200679Inst Instance=new A200679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200680
{
public static readonly long[] Value={ 1L,2L,7L,0L,3L,4L,2L,6L,4L,7L,7L,9L,9L,5L,8L,2L,7L,1L,1L,0L,6L,3L,9L,9L,0L,3L,3L,5L,0L,3L,2L,0L,2L,1L,1L,2L,5L,1L,4L,7L,6L,9L,7L,3L,1L,0L,4L,6L,2L,8L,0L,7L,5L,6L,5L,6L,7L,6L,2L,5L,4L,0L,1L,2L,7L,6L,5L,4L,9L,0L,4L,4L,1L,1L,5L,6L,5L,0L,3L,4L,9L,6L,4L,1L,6L,9L,7L,1L,2L,3L,6L,3L,5L,9L,4L,4L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200680Inst : IEnumerable<long>
{
public static readonly long[] Value=A200680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200680.Bytes);
public long this[int i]=>Value[i];

public static A200680Inst Instance=new A200680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200681
{
public static readonly long[] Value={ 3L,4L,7L,4L,2L,5L,7L,6L,4L,4L,7L,7L,4L,3L,8L,7L,1L,1L,2L,8L,9L,0L,5L,6L,4L,1L,2L,9L,5L,5L,3L,2L,5L,8L,7L,6L,7L,2L,3L,1L,5L,3L,1L,7L,0L,2L,7L,7L,1L,9L,3L,9L,3L,7L,2L,0L,4L,8L,9L,6L,8L,3L,6L,8L,0L,0L,8L,0L,9L,5L,6L,5L,4L,2L,5L,1L,2L,3L,4L,8L,8L,8L,2L,7L,0L,5L,2L,9L,2L,2L,7L,5L,0L,5L,7L,8L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200681Inst : IEnumerable<long>
{
public static readonly long[] Value=A200681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200681.Bytes);
public long this[int i]=>Value[i];

public static A200681Inst Instance=new A200681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200682
{
public static readonly long[] Value={ 1L,4L,0L,3L,0L,6L,0L,4L,2L,0L,8L,0L,9L,3L,7L,1L,2L,3L,8L,8L,4L,8L,9L,2L,1L,3L,4L,9L,4L,4L,9L,4L,4L,2L,0L,1L,5L,7L,1L,2L,9L,3L,1L,3L,8L,4L,2L,4L,5L,1L,1L,1L,4L,6L,8L,9L,5L,9L,4L,8L,8L,5L,9L,1L,8L,5L,2L,9L,0L,1L,7L,3L,9L,6L,5L,1L,5L,1L,1L,0L,2L,5L,2L,8L,1L,8L,7L,6L,3L,1L,0L,6L,4L,1L,3L,8L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200682Inst : IEnumerable<long>
{
public static readonly long[] Value=A200682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200682.Bytes);
public long this[int i]=>Value[i];

public static A200682Inst Instance=new A200682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200683
{
public static readonly long[] Value={ 2L,5L,5L,5L,8L,9L,9L,6L,6L,7L,4L,6L,5L,6L,7L,8L,0L,3L,4L,7L,1L,4L,1L,2L,6L,3L,3L,5L,3L,9L,8L,1L,4L,6L,8L,1L,1L,2L,6L,6L,8L,4L,4L,8L,9L,0L,5L,1L,8L,6L,6L,1L,0L,0L,4L,3L,1L,2L,6L,8L,2L,7L,5L,1L,1L,2L,5L,9L,0L,7L,0L,3L,1L,5L,8L,8L,6L,2L,4L,3L,2L,0L,4L,1L,9L,7L,0L,8L,5L,0L,2L,3L,4L,2L,3L,5L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200683Inst : IEnumerable<long>
{
public static readonly long[] Value=A200683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200683.Bytes);
public long this[int i]=>Value[i];

public static A200683Inst Instance=new A200683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200684
{
public static readonly long[] Value={ 1L,4L,5L,2L,9L,1L,6L,1L,6L,0L,9L,1L,6L,5L,1L,4L,5L,1L,8L,7L,4L,2L,7L,4L,8L,6L,8L,7L,5L,9L,0L,4L,4L,8L,3L,2L,3L,2L,4L,0L,2L,2L,5L,9L,9L,9L,0L,3L,2L,5L,0L,9L,5L,1L,4L,9L,7L,6L,4L,6L,3L,1L,3L,0L,5L,3L,3L,6L,2L,8L,3L,7L,1L,6L,6L,5L,5L,6L,8L,6L,0L,7L,3L,1L,9L,9L,2L,4L,8L,3L,1L,1L,1L,7L,1L,5L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200684Inst : IEnumerable<long>
{
public static readonly long[] Value=A200684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200684.Bytes);
public long this[int i]=>Value[i];

public static A200684Inst Instance=new A200684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200685
{
public static readonly long[] Value={ 5L,8L,3L,2L,4L,8L,4L,6L,7L,2L,5L,5L,0L,4L,8L,0L,4L,1L,4L,8L,3L,8L,6L,6L,6L,2L,9L,9L,1L,3L,2L,0L,7L,5L,4L,0L,7L,3L,0L,4L,3L,4L,9L,7L,8L,7L,7L,2L,0L,5L,6L,0L,0L,6L,0L,3L,4L,8L,2L,7L,1L,1L,4L,9L,4L,2L,3L,2L,2L,7L,4L,9L,1L,5L,8L,8L,1L,3L,3L,6L,7L,3L,0L,2L,9L,7L,2L,1L,6L,1L,9L,4L,5L,9L,1L,4L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200685Inst : IEnumerable<long>
{
public static readonly long[] Value=A200685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200685.Bytes);
public long this[int i]=>Value[i];

public static A200685Inst Instance=new A200685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200686
{
public static readonly long[] Value={ 8L,8L,3L,7L,5L,9L,9L,5L,7L,2L,0L,8L,3L,1L,5L,8L,6L,4L,5L,3L,1L,9L,4L,7L,2L,8L,9L,0L,5L,2L,1L,2L,8L,6L,2L,8L,6L,9L,7L,1L,6L,7L,9L,7L,9L,1L,6L,7L,2L,7L,5L,9L,2L,1L,3L,3L,0L,0L,1L,1L,6L,2L,5L,7L,1L,4L,5L,2L,8L,6L,9L,5L,1L,0L,0L,9L,8L,0L,1L,2L,4L,6L,1L,9L,0L,4L,4L,0L,4L,8L,5L,6L,9L,2L,2L,5L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200686Inst : IEnumerable<long>
{
public static readonly long[] Value=A200686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200686.Bytes);
public long this[int i]=>Value[i];

public static A200686Inst Instance=new A200686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200687
{
public static readonly long[] Value={ 1L,0L,7L,4L,3L,0L,7L,6L,1L,9L,5L,9L,3L,5L,8L,9L,1L,7L,7L,1L,9L,6L,3L,6L,3L,6L,3L,4L,6L,2L,8L,6L,8L,7L,2L,2L,8L,6L,3L,7L,8L,6L,5L,2L,1L,6L,3L,2L,7L,4L,8L,5L,0L,2L,3L,8L,3L,7L,3L,8L,7L,0L,4L,1L,7L,5L,0L,6L,4L,8L,9L,9L,8L,3L,5L,1L,5L,7L,8L,2L,6L,7L,7L,6L,8L,1L,7L,2L,6L,7L,9L,4L,8L,4L,1L,1L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200687Inst : IEnumerable<long>
{
public static readonly long[] Value=A200687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200687.Bytes);
public long this[int i]=>Value[i];

public static A200687Inst Instance=new A200687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200688
{
public static readonly long[] Value={ 1L,1L,9L,8L,7L,8L,3L,7L,4L,3L,1L,5L,4L,6L,7L,2L,3L,3L,0L,7L,6L,6L,9L,4L,2L,2L,1L,1L,4L,5L,5L,5L,5L,3L,3L,3L,0L,7L,1L,3L,1L,2L,9L,2L,9L,6L,7L,2L,9L,2L,5L,1L,6L,4L,0L,9L,2L,5L,6L,0L,3L,9L,6L,9L,1L,0L,7L,0L,7L,3L,1L,1L,2L,4L,5L,3L,0L,9L,6L,1L,1L,9L,0L,8L,4L,2L,0L,1L,4L,4L,6L,5L,2L,9L,4L,3L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200688Inst : IEnumerable<long>
{
public static readonly long[] Value=A200688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200688.Bytes);
public long this[int i]=>Value[i];

public static A200688Inst Instance=new A200688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200689
{
public static readonly long[] Value={ 1L,2L,8L,1L,3L,6L,9L,9L,1L,6L,6L,2L,1L,1L,5L,5L,8L,6L,8L,0L,9L,8L,5L,7L,6L,9L,0L,4L,5L,3L,4L,8L,9L,4L,9L,8L,9L,6L,2L,9L,2L,2L,9L,3L,1L,0L,2L,9L,1L,2L,0L,6L,0L,3L,0L,1L,7L,2L,7L,7L,1L,0L,8L,9L,2L,9L,2L,0L,3L,2L,2L,9L,6L,1L,0L,7L,0L,5L,1L,3L,1L,9L,8L,6L,7L,5L,5L,1L,1L,3L,0L,5L,0L,3L,4L,4L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200689Inst : IEnumerable<long>
{
public static readonly long[] Value=A200689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200689.Bytes);
public long this[int i]=>Value[i];

public static A200689Inst Instance=new A200689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200690
{
public static readonly long[] Value={ 1L,3L,3L,7L,6L,2L,8L,4L,7L,2L,7L,2L,8L,0L,0L,8L,4L,8L,8L,4L,7L,1L,5L,7L,8L,3L,8L,8L,4L,1L,8L,8L,4L,5L,7L,0L,8L,7L,5L,8L,7L,1L,1L,0L,2L,0L,6L,7L,7L,3L,1L,8L,4L,9L,6L,4L,3L,6L,7L,9L,6L,3L,0L,9L,8L,8L,4L,2L,0L,5L,6L,8L,3L,5L,0L,3L,1L,7L,2L,3L,1L,3L,8L,2L,3L,8L,2L,1L,4L,8L,3L,6L,5L,6L,4L,0L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200690Inst : IEnumerable<long>
{
public static readonly long[] Value=A200690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200690.Bytes);
public long this[int i]=>Value[i];

public static A200690Inst Instance=new A200690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200691
{
public static readonly long[] Value={ 1L,3L,7L,7L,2L,8L,8L,1L,9L,6L,8L,0L,4L,0L,2L,9L,3L,6L,0L,2L,4L,2L,7L,6L,0L,4L,4L,1L,0L,7L,8L,4L,1L,3L,5L,2L,5L,5L,7L,4L,8L,6L,0L,9L,1L,9L,6L,7L,3L,0L,0L,1L,9L,9L,2L,2L,9L,0L,8L,9L,4L,5L,6L,9L,9L,7L,3L,7L,8L,5L,4L,4L,1L,3L,7L,3L,0L,4L,0L,8L,0L,6L,1L,8L,5L,6L,6L,9L,5L,3L,5L,2L,4L,6L,7L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200691Inst : IEnumerable<long>
{
public static readonly long[] Value=A200691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200691.Bytes);
public long this[int i]=>Value[i];

public static A200691Inst Instance=new A200691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200692
{
public static readonly long[] Value={ 1L,4L,0L,6L,2L,5L,2L,3L,2L,3L,2L,9L,7L,3L,6L,1L,4L,6L,8L,0L,8L,0L,5L,9L,3L,2L,9L,6L,3L,5L,2L,0L,4L,2L,3L,2L,1L,5L,4L,1L,6L,6L,8L,2L,3L,6L,6L,7L,5L,4L,7L,1L,9L,7L,4L,8L,7L,1L,2L,0L,1L,5L,0L,5L,1L,0L,3L,0L,8L,5L,5L,1L,2L,1L,8L,0L,8L,9L,4L,9L,7L,8L,9L,7L,4L,6L,0L,1L,2L,6L,4L,6L,7L,7L,5L,0L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200692Inst : IEnumerable<long>
{
public static readonly long[] Value=A200692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200692.Bytes);
public long this[int i]=>Value[i];

public static A200692Inst Instance=new A200692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200693
{
public static readonly long[] Value={ 1L,4L,2L,8L,1L,0L,5L,1L,9L,3L,9L,3L,4L,3L,8L,0L,7L,4L,9L,6L,9L,9L,5L,8L,6L,0L,5L,3L,7L,1L,3L,8L,8L,0L,6L,8L,6L,8L,4L,6L,8L,5L,5L,4L,3L,1L,1L,1L,4L,3L,9L,5L,2L,6L,2L,3L,4L,1L,3L,0L,3L,3L,5L,3L,1L,6L,9L,1L,5L,3L,5L,2L,3L,5L,7L,8L,6L,3L,7L,5L,1L,3L,6L,4L,0L,7L,0L,3L,8L,4L,1L,7L,1L,2L,7L,5L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200693Inst : IEnumerable<long>
{
public static readonly long[] Value=A200693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200693.Bytes);
public long this[int i]=>Value[i];

public static A200693Inst Instance=new A200693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200694
{
public static readonly long[] Value={ 1L,4L,4L,5L,0L,6L,9L,1L,2L,8L,7L,0L,5L,3L,2L,7L,6L,0L,5L,7L,4L,1L,0L,8L,4L,4L,7L,9L,3L,0L,3L,6L,2L,4L,8L,9L,9L,8L,4L,0L,3L,2L,5L,8L,6L,4L,5L,4L,8L,4L,4L,5L,1L,4L,7L,2L,7L,1L,6L,4L,0L,6L,5L,1L,4L,0L,8L,4L,6L,7L,2L,6L,8L,5L,6L,4L,1L,7L,2L,7L,3L,7L,1L,4L,1L,1L,9L,3L,5L,0L,8L,0L,5L,8L,1L,5L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200694Inst : IEnumerable<long>
{
public static readonly long[] Value=A200694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200694.Bytes);
public long this[int i]=>Value[i];

public static A200694Inst Instance=new A200694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200695
{
public static readonly long[] Value={ 4L,8L,5L,7L,9L,7L,3L,4L,8L,9L,4L,7L,5L,4L,4L,1L,7L,8L,7L,5L,5L,5L,9L,5L,4L,4L,1L,1L,3L,7L,5L,9L,3L,6L,1L,9L,5L,2L,6L,0L,3L,3L,0L,5L,2L,1L,4L,6L,3L,0L,8L,9L,9L,7L,8L,6L,8L,0L,6L,8L,7L,8L,4L,8L,3L,5L,1L,7L,5L,7L,2L,7L,9L,7L,2L,0L,1L,1L,1L,7L,9L,6L,9L,6L,3L,6L,3L,2L,6L,9L,9L,5L,4L,3L,7L,5L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200695Inst : IEnumerable<long>
{
public static readonly long[] Value=A200695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200695.Bytes);
public long this[int i]=>Value[i];

public static A200695Inst Instance=new A200695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200696
{
public static readonly long[] Value={ 9L,1L,9L,0L,5L,2L,4L,5L,5L,3L,3L,2L,6L,7L,3L,5L,1L,2L,1L,5L,9L,9L,5L,3L,1L,9L,0L,5L,3L,9L,4L,6L,3L,5L,6L,3L,2L,7L,5L,7L,7L,8L,8L,6L,5L,4L,4L,3L,3L,8L,6L,9L,1L,8L,6L,4L,3L,9L,0L,4L,4L,8L,5L,4L,0L,4L,4L,8L,0L,5L,4L,4L,8L,3L,0L,5L,6L,3L,2L,7L,0L,5L,9L,4L,3L,1L,8L,1L,6L,3L,5L,3L,0L,4L,0L,2L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200696Inst : IEnumerable<long>
{
public static readonly long[] Value=A200696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200696.Bytes);
public long this[int i]=>Value[i];

public static A200696Inst Instance=new A200696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200697
{
public static readonly long[] Value={ 4L,2L,6L,4L,7L,3L,8L,7L,2L,8L,0L,9L,1L,4L,5L,1L,3L,2L,9L,9L,5L,2L,9L,9L,1L,3L,5L,6L,3L,2L,8L,0L,1L,9L,1L,2L,1L,2L,8L,7L,1L,0L,3L,7L,7L,5L,9L,4L,7L,2L,9L,3L,3L,3L,9L,4L,8L,1L,0L,1L,8L,9L,3L,3L,6L,8L,1L,6L,0L,9L,1L,2L,5L,9L,4L,2L,7L,5L,8L,3L,3L,5L,2L,1L,5L,8L,5L,5L,7L,5L,4L,1L,2L,6L,6L,0L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200697Inst : IEnumerable<long>
{
public static readonly long[] Value=A200697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200697.Bytes);
public long this[int i]=>Value[i];

public static A200697Inst Instance=new A200697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200698
{
public static readonly long[] Value={ 6L,4L,4L,9L,2L,2L,7L,9L,6L,5L,0L,0L,9L,3L,2L,8L,2L,0L,0L,2L,6L,4L,2L,6L,7L,1L,8L,1L,2L,0L,3L,2L,5L,5L,5L,5L,6L,5L,6L,9L,5L,0L,5L,6L,6L,6L,3L,7L,4L,5L,2L,3L,4L,8L,0L,1L,4L,4L,4L,6L,2L,6L,9L,4L,7L,9L,7L,2L,8L,1L,4L,3L,6L,1L,3L,8L,8L,2L,7L,6L,7L,4L,9L,0L,8L,1L,9L,6L,4L,9L,8L,9L,5L,0L,6L,7L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200698Inst : IEnumerable<long>
{
public static readonly long[] Value=A200698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200698.Bytes);
public long this[int i]=>Value[i];

public static A200698Inst Instance=new A200698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200699
{
public static readonly long[] Value={ 3L,8L,5L,4L,4L,2L,2L,7L,3L,9L,4L,1L,3L,9L,4L,6L,8L,8L,4L,8L,6L,2L,7L,9L,7L,1L,4L,8L,2L,0L,2L,8L,9L,3L,1L,0L,6L,0L,7L,4L,1L,3L,6L,7L,1L,1L,9L,2L,2L,2L,7L,2L,4L,3L,2L,3L,7L,1L,9L,8L,5L,9L,2L,5L,4L,5L,0L,7L,8L,6L,4L,4L,1L,0L,6L,4L,0L,8L,3L,9L,8L,6L,3L,5L,5L,9L,3L,0L,8L,2L,6L,8L,2L,5L,7L,6L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200699Inst : IEnumerable<long>
{
public static readonly long[] Value=A200699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200699.Bytes);
public long this[int i]=>Value[i];

public static A200699Inst Instance=new A200699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200700
{
public static readonly long[] Value={ 3L,5L,4L,8L,2L,2L,8L,6L,5L,9L,8L,5L,9L,9L,0L,7L,5L,7L,7L,7L,6L,5L,2L,8L,8L,7L,1L,9L,5L,0L,1L,3L,6L,8L,4L,3L,4L,1L,5L,2L,4L,2L,4L,1L,9L,2L,4L,5L,4L,3L,8L,1L,1L,1L,8L,2L,2L,3L,5L,1L,3L,5L,5L,8L,6L,8L,2L,5L,8L,8L,9L,5L,3L,2L,5L,9L,3L,4L,8L,8L,7L,1L,6L,3L,5L,5L,1L,4L,4L,0L,2L,0L,7L,1L,0L,3L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200700Inst : IEnumerable<long>
{
public static readonly long[] Value=A200700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200700.Bytes);
public long this[int i]=>Value[i];

public static A200700Inst Instance=new A200700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200701
{
public static readonly long[] Value={ 3L,3L,0L,8L,0L,1L,8L,0L,6L,1L,0L,5L,5L,8L,6L,9L,9L,1L,4L,3L,4L,0L,8L,7L,8L,0L,3L,1L,0L,8L,9L,9L,0L,9L,3L,5L,7L,4L,3L,3L,6L,3L,3L,8L,1L,6L,8L,1L,9L,8L,0L,7L,0L,4L,0L,2L,4L,4L,2L,3L,2L,0L,8L,5L,2L,7L,1L,6L,4L,1L,4L,2L,9L,8L,2L,0L,7L,8L,0L,6L,5L,2L,9L,5L,2L,8L,4L,6L,4L,8L,5L,6L,4L,6L,0L,5L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200701Inst : IEnumerable<long>
{
public static readonly long[] Value=A200701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200701.Bytes);
public long this[int i]=>Value[i];

public static A200701Inst Instance=new A200701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200702
{
public static readonly long[] Value={ 3L,1L,1L,2L,7L,8L,8L,8L,4L,1L,7L,5L,9L,3L,6L,8L,6L,7L,8L,9L,6L,7L,9L,9L,2L,6L,5L,6L,8L,8L,2L,1L,3L,2L,1L,8L,1L,7L,1L,5L,2L,3L,7L,1L,0L,2L,3L,8L,9L,5L,0L,3L,3L,3L,3L,4L,3L,8L,6L,3L,6L,3L,2L,4L,4L,6L,7L,1L,2L,7L,6L,8L,5L,1L,4L,6L,8L,5L,2L,3L,3L,6L,6L,8L,7L,9L,3L,7L,5L,3L,3L,8L,5L,3L,8L,7L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200702Inst : IEnumerable<long>
{
public static readonly long[] Value=A200702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200702.Bytes);
public long this[int i]=>Value[i];

public static A200702Inst Instance=new A200702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200703
{
public static readonly long[] Value={ 2L,9L,4L,9L,8L,8L,6L,0L,6L,8L,2L,8L,9L,2L,6L,5L,3L,5L,7L,0L,8L,8L,8L,9L,6L,5L,2L,0L,4L,6L,7L,6L,1L,3L,8L,7L,7L,8L,8L,7L,1L,8L,2L,6L,0L,1L,4L,9L,7L,5L,2L,1L,3L,4L,8L,9L,2L,7L,6L,2L,8L,2L,8L,1L,8L,3L,4L,0L,4L,4L,1L,3L,7L,6L,4L,0L,7L,3L,0L,1L,8L,5L,9L,9L,2L,9L,1L,3L,8L,8L,9L,1L,1L,5L,5L,1L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200703Inst : IEnumerable<long>
{
public static readonly long[] Value=A200703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200703.Bytes);
public long this[int i]=>Value[i];

public static A200703Inst Instance=new A200703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200704
{
public static readonly long[] Value={ 2L,8L,1L,1L,1L,6L,1L,8L,8L,4L,1L,7L,6L,3L,9L,7L,5L,2L,5L,8L,6L,3L,9L,7L,0L,1L,0L,6L,2L,4L,2L,1L,0L,3L,6L,1L,5L,1L,8L,0L,0L,5L,4L,6L,2L,2L,9L,0L,8L,2L,6L,0L,6L,0L,1L,6L,4L,9L,2L,0L,8L,7L,8L,2L,1L,5L,5L,7L,5L,7L,3L,1L,5L,4L,7L,9L,8L,6L,7L,3L,0L,7L,8L,9L,8L,5L,9L,3L,8L,7L,6L,1L,1L,1L,7L,4L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200704Inst : IEnumerable<long>
{
public static readonly long[] Value=A200704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200704.Bytes);
public long this[int i]=>Value[i];

public static A200704Inst Instance=new A200704Inst();

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