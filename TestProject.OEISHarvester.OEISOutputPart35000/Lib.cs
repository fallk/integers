using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010322
{
public static readonly long[] Value={ 4L,1L,1L,4L,1L,5L,6L,12L,1L,1L,1L,3L,6L,1L,4L,13L,1L,14L,2L,1L,1L,2L,28L,19L,2L,1L,1L,1L,4L,4L,6L,1L,1L,4L,1L,2L,3L,2L,1L,11L,1L,1L,16L,15L,7L,5L,1L,1L,2L,1L,2L,12L,1L,1L,1L,1L,2L,4L,1L,247L,29L,7L,3L,1L,1L,1L,6L,1L,1L,1L,2L,1L,1L,3L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010322Inst : IEnumerable<long>
{
public static readonly long[] Value=A010322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010322.Bytes);
public long this[int i]=>Value[i];

public static A010322Inst Instance=new A010322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010321
{
public static readonly long[] Value={ 4L,1L,1L,7L,1L,1L,1L,9L,8L,1L,12L,2L,2L,5L,26L,1L,2L,17L,21L,42L,2L,8L,123L,1L,12L,14L,1L,1L,4L,4L,1L,1L,1L,1L,4L,1L,1L,6L,2L,7L,5L,1L,3L,18L,11L,1L,6L,2L,7L,174L,1L,1L,1L,4L,1L,14L,3L,14L,39L,60L,2L,1L,1L,4L,87L,1L,2L,3L,1L,2L,2L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010321Inst : IEnumerable<long>
{
public static readonly long[] Value=A010321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010321.Bytes);
public long this[int i]=>Value[i];

public static A010321Inst Instance=new A010321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010320
{
public static readonly long[] Value={ 4L,1L,1L,16L,1L,10L,2L,3L,1L,1L,1L,1L,8L,1L,19L,1L,5L,2L,21L,3L,3L,9L,4L,6L,5L,1L,3L,1L,1L,188L,2L,5L,1L,2L,1L,6L,2L,4L,42L,2L,1L,1L,3L,6L,1L,2L,1L,1L,2L,3L,1L,7L,1L,2L,14L,42L,1L,17L,3L,2L,20L,3L,2L,6L,1L,17L,7L,1L,3L,1L,3L,5L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010320Inst : IEnumerable<long>
{
public static readonly long[] Value=A010320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010320.Bytes);
public long this[int i]=>Value[i];

public static A010320Inst Instance=new A010320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010319
{
public static readonly long[] Value={ 4L,2L,120L,1L,16L,1L,181L,5L,1L,1L,5L,1L,7L,1L,4L,1L,2L,1L,1L,1L,242L,5L,24L,1L,1L,4L,2L,15L,2L,4L,2L,8L,1L,14L,14L,4L,1L,2L,2L,3L,1L,11L,2L,70L,1L,2L,1L,4L,1L,15L,3L,1L,1L,2L,4L,12L,2L,1L,2L,3L,1L,9L,1L,13L,1L,1L,3L,4L,2L,1L,1L,66L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010319Inst : IEnumerable<long>
{
public static readonly long[] Value=A010319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010319.Bytes);
public long this[int i]=>Value[i];

public static A010319Inst Instance=new A010319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010318
{
public static readonly long[] Value={ 4L,2L,12L,1L,16L,1L,19L,5L,1L,1L,5L,10L,1314L,1L,2L,2L,3L,1L,3L,2L,2L,2L,43L,1L,3L,2L,1L,1L,1L,5L,1L,1L,3L,1L,1L,73L,2L,1L,6L,1L,4L,5L,4L,36L,1L,1L,10L,3L,1L,3L,1L,3L,1L,1L,1L,1L,2L,1L,21L,2L,15L,27L,11L,6L,2L,1L,2L,1L,1L,1L,2L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010318Inst : IEnumerable<long>
{
public static readonly long[] Value=A010318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010318.Bytes);
public long this[int i]=>Value[i];

public static A010318Inst Instance=new A010318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010301
{
public static readonly long[] Value={ 4L,5L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,4L,9L,1L,1L,1L,25L,4L,1L,2L,3L,1L,3L,2L,16L,5L,3L,3L,1L,2L,1L,9L,73L,4L,1L,2L,13L,9L,72L,3L,50L,1L,4L,8L,1L,1L,1L,3L,2L,8L,2L,4L,1L,1L,14L,1L,2L,1L,1L,1L,19L,12L,3L,2L,1L,2L,1L,1L,1L,3L,1L,3L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010301Inst : IEnumerable<long>
{
public static readonly long[] Value=A010301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010301.Bytes);
public long this[int i]=>Value[i];

public static A010301Inst Instance=new A010301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010300
{
public static readonly long[] Value={ 4L,6L,4L,9L,3L,3L,2L,3L,1L,11L,1L,20L,2L,1L,9L,2L,1L,4L,6L,6L,1L,2L,1L,1L,6L,2L,4L,2L,2L,2L,1L,1L,24L,1L,3L,1L,10L,1L,2L,14L,1L,1L,4L,1L,2L,1L,11L,4L,3L,9L,1L,1L,1L,1L,19L,1L,1L,5L,1L,3L,93L,12L,1L,2L,2L,2L,3L,2L,8L,3L,1L,11L,2L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010300Inst : IEnumerable<long>
{
public static readonly long[] Value=A010300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010300.Bytes);
public long this[int i]=>Value[i];

public static A010300Inst Instance=new A010300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010299
{
public static readonly long[] Value={ 4L,7L,9L,1L,6L,2L,1L,3L,1L,1L,2L,4L,7L,1L,5L,9L,1L,1L,1L,1L,1L,1L,2L,21L,1L,18L,1L,2L,4L,8L,7L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,24L,1L,21L,1L,9L,7L,1L,8L,104L,1L,1L,14L,6L,2L,2L,13L,1L,11L,2L,2L,29L,1L,1L,3L,4L,1L,1L,23L,112L,9L,1L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010299Inst : IEnumerable<long>
{
public static readonly long[] Value=A010299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010299.Bytes);
public long this[int i]=>Value[i];

public static A010299Inst Instance=new A010299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010298
{
public static readonly long[] Value={ 4L,8L,4L,12L,3L,3L,1L,2L,1L,1L,1L,16L,10L,7L,2L,2L,2L,1L,1L,1L,1L,4L,1L,2L,7L,7L,1L,1L,9L,1L,10L,2L,1L,1L,59L,6L,9L,2L,2L,5L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,3L,2L,2L,12L,9L,1L,1L,2L,1L,1L,5L,2L,11L,7L,2L,1L,1L,2L,1L,3L,5L,2L,2L,2L,2L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010298Inst : IEnumerable<long>
{
public static readonly long[] Value=A010298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010298.Bytes);
public long this[int i]=>Value[i];

public static A010298Inst Instance=new A010298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010297
{
public static readonly long[] Value={ 4L,9L,1L,5L,2L,17L,2L,1L,61L,1L,3L,3L,1L,1L,2L,14L,12L,1L,60L,14L,3L,82L,2L,12L,1L,2L,1L,8L,1L,11L,1L,2L,10L,1L,1L,1L,1L,2L,1L,2L,2L,8L,2L,1L,13L,3L,3L,2L,7L,1L,14L,2L,2L,1L,6L,6L,1L,9L,5L,4L,1L,2L,2L,1L,1L,2L,2L,1L,25L,1L,2L,1L,8L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010297Inst : IEnumerable<long>
{
public static readonly long[] Value=A010297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010297.Bytes);
public long this[int i]=>Value[i];

public static A010297Inst Instance=new A010297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010296
{
public static readonly long[] Value={ 4L,12L,4L,18L,3L,4L,15L,24L,1L,2L,17L,1L,2L,28L,2L,3L,1L,7L,8L,3L,1L,2L,2L,2L,1L,1L,4L,4L,1L,1L,32L,1L,2L,121L,1L,1L,4L,3L,5L,7L,4L,2L,1L,1L,1L,11L,1L,1L,1L,2L,5L,1L,1L,1L,4L,1L,2L,1L,1L,20L,1L,5L,3L,3L,1L,1L,1L,1L,2L,22L,1L,2L,11L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010296Inst : IEnumerable<long>
{
public static readonly long[] Value=A010296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010296.Bytes);
public long this[int i]=>Value[i];

public static A010296Inst Instance=new A010296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010295
{
public static readonly long[] Value={ 4L,16L,4L,24L,3L,4L,3L,1L,4L,32L,1L,1L,7L,2L,6L,1L,13L,1L,2L,5L,1L,5L,1L,2L,7L,1L,11L,2L,7L,1L,10L,4L,1L,2L,4L,1L,4L,1L,1L,4L,4L,1L,3L,1L,5L,1L,8L,16L,4L,35L,1L,1L,1L,1L,1L,1L,1L,11L,1L,3L,1L,1L,2L,1L,2L,1L,3L,9L,8L,1L,1L,1L,4L,9L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010295Inst : IEnumerable<long>
{
public static readonly long[] Value=A010295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010295.Bytes);
public long this[int i]=>Value[i];

public static A010295Inst Instance=new A010295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010294
{
public static readonly long[] Value={ 4L,24L,4L,36L,3L,4L,2L,12L,1L,47L,1L,4L,1L,1L,24L,79L,5L,1L,13L,1L,1L,1L,1L,2L,2L,2L,1L,58L,1L,1L,48L,2L,8L,9L,2L,1L,1L,6L,10L,1L,2L,2L,2L,1L,4L,2L,1L,5L,1L,6L,2L,1L,15L,2L,2L,61L,1L,1L,2L,1L,8L,3L,1L,2L,10L,6L,1L,10L,1L,1L,3L,26L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010294Inst : IEnumerable<long>
{
public static readonly long[] Value=A010294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010294.Bytes);
public long this[int i]=>Value[i];

public static A010294Inst Instance=new A010294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010293
{
public static readonly long[] Value={ 4L,48L,4L,72L,3L,4L,1L,2L,1L,1L,1L,3L,1L,95L,1L,25L,1L,8L,1L,1L,2L,4L,9L,1L,1L,1L,6L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,6L,6L,1L,1L,1L,3L,1L,2L,1L,1L,2L,4L,5L,1L,1L,4L,5L,1L,2L,8L,2L,1L,1L,1L,1L,1L,3L,1L,13L,1L,1L,1L,12L,1L,7L,2L,1L,1L,19L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010293Inst : IEnumerable<long>
{
public static readonly long[] Value=A010293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010293.Bytes);
public long this[int i]=>Value[i];

public static A010293Inst Instance=new A010293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010292
{
public static readonly long[] Value={ 3L,1L,46L,1L,2L,1L,70L,1L,2L,5L,3L,4L,1L,2L,94L,1L,8L,4L,1L,6L,1L,1L,1L,7L,3L,3L,1L,3L,1L,1L,2L,2L,5L,1L,2L,4L,1L,4L,1L,1L,6L,1L,77L,1L,1L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,64L,1L,1L,9L,6L,10L,1L,6L,1L,1L,2L,1L,1L,3L,1L,1L,2L,53L,1L,2L,24L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010292Inst : IEnumerable<long>
{
public static readonly long[] Value=A010292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010292.Bytes);
public long this[int i]=>Value[i];

public static A010292Inst Instance=new A010292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010291
{
public static readonly long[] Value={ 3L,1L,22L,1L,2L,1L,34L,1L,2L,5L,1L,2L,2314L,1L,1L,1L,1L,13L,3L,43L,3L,1L,1L,1L,5L,2L,1L,24L,1L,7L,1L,1L,4L,1L,4L,2L,5L,1L,2L,1L,4L,8L,1L,1L,1L,1L,3L,1L,3L,2L,1L,9L,1L,24163L,1L,1L,3L,16L,4L,8L,1L,1L,7L,1L,3L,2L,23L,3L,1L,1L,1L,6L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010291Inst : IEnumerable<long>
{
public static readonly long[] Value=A010291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010291.Bytes);
public long this[int i]=>Value[i];

public static A010291Inst Instance=new A010291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010290
{
public static readonly long[] Value={ 3L,1L,14L,1L,2L,1L,22L,1L,2L,6L,12L,1L,30L,3L,6L,2L,2L,1L,3L,19L,8L,1L,10L,5L,4L,3L,2L,6L,30L,2L,17L,9L,1L,5L,1L,1L,9L,4L,3L,6L,4L,1L,6L,3L,18L,1L,1L,3L,2L,1L,1L,1L,8L,19L,2L,1L,1L,2L,1L,18L,1L,5L,1L,1L,2L,1L,2L,1L,7L,1L,1L,6L,1L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010290Inst : IEnumerable<long>
{
public static readonly long[] Value=A010290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010290.Bytes);
public long this[int i]=>Value[i];

public static A010290Inst Instance=new A010290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010289
{
public static readonly long[] Value={ 3L,1L,10L,1L,2L,1L,16L,1L,2L,6L,1L,1L,3L,1L,22L,2L,5L,2L,11L,22L,1L,9L,4L,3L,2L,2L,4L,7L,1L,2L,1L,1L,2L,1L,1L,2L,1L,12L,2L,3L,1L,5L,2L,1L,1L,4L,2L,214L,1L,3L,24L,1L,1L,1L,7L,1L,13L,6L,1L,9L,2L,2L,8L,1L,4L,1L,4L,2L,1L,50L,9L,1L,2L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010289Inst : IEnumerable<long>
{
public static readonly long[] Value=A010289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010289.Bytes);
public long this[int i]=>Value[i];

public static A010289Inst Instance=new A010289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010288
{
public static readonly long[] Value={ 3L,1L,8L,2L,1L,8L,2L,11L,1L,6L,8L,2L,10L,2L,1L,2L,2L,3L,2L,4L,3L,10L,3L,13L,1L,2L,1L,1L,3L,1L,1L,7L,1L,2L,1L,12L,1L,1L,1L,1L,2L,1L,4L,3L,4L,1L,1L,1L,10L,1L,13L,3L,5L,1L,5L,1L,1L,1L,1L,5L,4L,4L,1L,1L,4L,2L,3L,6L,1L,3L,30L,1L,11L,3L,1L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010288Inst : IEnumerable<long>
{
public static readonly long[] Value=A010288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010288.Bytes);
public long this[int i]=>Value[i];

public static A010288Inst Instance=new A010288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010287
{
public static readonly long[] Value={ 3L,1L,6L,1L,2L,1L,10L,1L,2L,7L,1L,4L,15L,37L,1L,6L,1L,2L,2L,1L,2L,8L,10L,39L,75L,1L,2L,2L,1L,1L,2L,1L,10L,18L,1L,4L,3L,2L,1L,2L,1L,2L,1L,5L,1L,4L,1L,1L,3L,181L,1L,2L,1L,5L,11L,2L,16L,1L,2L,1L,2L,3L,1L,1L,1L,3L,3L,1L,1L,15L,3L,8L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010287Inst : IEnumerable<long>
{
public static readonly long[] Value=A010287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010287.Bytes);
public long this[int i]=>Value[i];

public static A010287Inst Instance=new A010287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010286
{
public static readonly long[] Value={ 3L,1L,5L,1L,1L,1L,1L,55L,1L,3L,1L,2L,1L,13L,1L,3L,1L,1L,2L,4L,1L,1L,3L,2L,1L,2L,1L,1L,1L,4L,2L,1L,6L,1L,1L,6L,1L,5L,1L,1L,1L,2L,4L,27L,7L,1L,9L,1L,1L,2L,2L,2L,2L,1L,2L,4L,10L,1L,1L,9L,9L,1L,2L,3L,1L,1L,23L,6L,8L,18L,1L,2L,1L,1L,1L,1L,24L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010286Inst : IEnumerable<long>
{
public static readonly long[] Value=A010286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010286.Bytes);
public long this[int i]=>Value[i];

public static A010286Inst Instance=new A010286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010285
{
public static readonly long[] Value={ 3L,1L,4L,1L,2L,1L,7L,1L,2L,9L,1L,2L,10L,1L,7L,2L,1L,6L,5L,5L,1L,1L,2L,2L,1L,1L,5L,13L,1L,1L,1L,1L,565L,4L,2L,1L,3L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,6L,1L,2L,3L,2L,4L,1L,1L,4L,4L,2L,1L,4L,2L,11L,74L,4L,2L,5L,15L,1L,2L,3L,3L,1L,4L,13L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010285Inst : IEnumerable<long>
{
public static readonly long[] Value=A010285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010285.Bytes);
public long this[int i]=>Value[i];

public static A010285Inst Instance=new A010285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010284
{
public static readonly long[] Value={ 3L,1L,4L,13L,2L,1L,6L,1L,8L,1L,5L,12L,15L,1L,5L,3L,1L,3L,3L,8L,9L,2L,1L,3L,1L,6L,1L,1L,2L,4L,8L,2L,1L,1L,6L,1L,4L,1L,1L,17L,6L,4L,1L,19L,1L,3L,1L,1L,1L,6L,3L,1L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,7L,5L,7L,1L,1L,67L,11L,1L,1L,7L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010284Inst : IEnumerable<long>
{
public static readonly long[] Value=A010284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010284.Bytes);
public long this[int i]=>Value[i];

public static A010284Inst Instance=new A010284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010283
{
public static readonly long[] Value={ 3L,1L,3L,1L,1L,5L,1L,1L,1L,27L,1L,4L,3L,3L,2L,4L,1L,2L,1L,3L,2L,11L,11L,1L,1L,1L,7L,4L,1L,3L,2L,3L,1L,47L,1L,3L,1L,2L,1L,177L,1L,1L,17L,1L,1L,40L,4L,4L,2L,2L,3L,10L,4L,1L,13L,4L,1L,2L,2L,2L,7L,2L,2L,1L,2L,1L,3L,1L,21L,2L,5L,7L,3L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010283Inst : IEnumerable<long>
{
public static readonly long[] Value=A010283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010283.Bytes);
public long this[int i]=>Value[i];

public static A010283Inst Instance=new A010283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010282
{
public static readonly long[] Value={ 3L,1L,3L,9L,1L,2L,3L,1L,6L,1L,1L,8L,1L,1L,1L,7L,2L,9L,6L,1L,6L,1L,26L,3L,7L,2L,1L,48L,1L,1L,1L,9L,1L,5L,2L,1L,2L,1L,17L,6L,2L,1L,1L,1L,4L,3L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,1L,1L,2L,1L,8L,1L,1L,1L,35L,1L,1L,1L,1L,1L,3L,17L,1L,1L,4L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010282Inst : IEnumerable<long>
{
public static readonly long[] Value=A010282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010282.Bytes);
public long this[int i]=>Value[i];

public static A010282Inst Instance=new A010282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010281
{
public static readonly long[] Value={ 3L,1L,2L,1L,2L,1L,4L,1L,2L,19L,7L,6L,3L,2L,3L,3L,1L,7L,1L,1L,1L,1L,13L,17L,1L,2L,7L,1L,1L,2L,1L,3L,11L,2L,2L,1L,10L,2L,1L,5L,1L,6L,1L,1L,1L,1L,2L,241L,2L,4L,1L,6L,1L,2L,27L,1L,5L,2L,4L,2L,1L,1L,150L,12L,1L,1L,1L,2L,1L,2L,9L,6L,1L,2L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010281Inst : IEnumerable<long>
{
public static readonly long[] Value=A010281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010281.Bytes);
public long this[int i]=>Value[i];

public static A010281Inst Instance=new A010281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010280
{
public static readonly long[] Value={ 3L,1L,2L,2L,3L,17L,1L,2L,2L,5L,1L,12L,1L,1L,5L,1L,1L,1L,6L,2L,1L,1L,1L,2L,1L,5L,4L,2L,5L,3L,2L,19L,8L,7038L,19L,1L,3L,2L,1L,2L,2L,4L,2L,7L,5L,1L,5L,1L,2L,2L,9L,1L,1L,5L,1L,1L,1L,13L,11L,3L,1L,1L,1L,1L,10L,6L,1L,3L,2L,1L,4L,1L,8L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010280Inst : IEnumerable<long>
{
public static readonly long[] Value=A010280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010280.Bytes);
public long this[int i]=>Value[i];

public static A010280Inst Instance=new A010280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010279
{
public static readonly long[] Value={ 3L,1L,2L,6L,15L,3L,5L,1L,2L,1L,5L,3L,22L,1L,8L,2L,2L,2L,8L,1L,26L,1L,2L,1L,3L,1L,1L,1L,3L,1L,2L,1L,30L,4L,1L,3L,2L,12L,3L,3L,1L,4L,2L,17L,1L,2L,56L,1L,4L,2L,4L,1L,1L,7L,1L,1L,3L,1L,5L,15L,6L,16L,39L,1L,6L,1L,5L,16L,1L,26L,1L,4L,1L,19L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010279Inst : IEnumerable<long>
{
public static readonly long[] Value=A010279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010279.Bytes);
public long this[int i]=>Value[i];

public static A010279Inst Instance=new A010279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010278
{
public static readonly long[] Value={ 3L,1L,1L,1L,14L,2L,2L,1L,34L,2L,1L,2L,1L,1L,6L,4L,1L,1L,2L,1L,80L,4L,1L,3L,3L,1L,3L,5L,1L,4L,1L,39L,1L,1L,2L,2L,1L,7L,2L,29L,4L,5L,1L,1L,4L,13L,13L,63L,1L,31L,3L,1L,2L,4L,1L,17L,19L,4L,2L,16L,5L,2L,1L,3L,1L,2L,4L,4L,5L,4L,5L,4L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010278Inst : IEnumerable<long>
{
public static readonly long[] Value=A010278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010278.Bytes);
public long this[int i]=>Value[i];

public static A010278Inst Instance=new A010278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010277
{
public static readonly long[] Value={ 3L,1L,1L,1L,2L,1L,3L,6L,254L,2L,2L,1L,1L,2L,3L,6L,50L,3L,1L,1L,1L,1L,60L,2L,20L,79L,13L,5L,6L,2L,5L,3L,1L,1L,5L,180L,6L,3L,1L,1L,6L,1L,3L,2L,1L,37L,1L,8L,4L,1L,20L,7L,7L,2L,6L,1L,2L,3L,2L,1L,12L,1L,9L,32L,1L,4L,1L,13L,2L,1L,2L,2L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010277Inst : IEnumerable<long>
{
public static readonly long[] Value=A010277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010277.Bytes);
public long this[int i]=>Value[i];

public static A010277Inst Instance=new A010277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010276
{
public static readonly long[] Value={ 3L,1L,1L,1L,1L,3L,1L,13L,1L,2L,2L,5L,1L,1L,1L,1L,10L,2L,5L,1L,5L,5L,3L,3L,1L,12L,1L,9L,1L,1L,1L,2L,2L,2L,9L,1L,3L,3L,1L,9L,60L,6L,2L,2L,2L,1L,2L,61L,3L,1L,1L,11L,12L,2L,1L,2L,1L,1L,10L,1L,2L,10L,2L,1L,1L,19L,1L,1L,1L,3L,1L,1L,4L,1L,10L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010276Inst : IEnumerable<long>
{
public static readonly long[] Value=A010276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010276.Bytes);
public long this[int i]=>Value[i];

public static A010276Inst Instance=new A010276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010275
{
public static readonly long[] Value={ 3L,1L,1L,2L,1L,1L,23L,1L,2L,1L,9L,7L,1L,1L,9L,1L,4L,3L,1L,1L,1L,1L,1L,2L,16L,1L,1L,1L,3L,8L,2L,4L,1L,2L,2L,9L,4L,11L,1L,11L,1L,9L,1L,1L,1L,7L,5L,14L,1L,1L,1L,8L,34L,4L,5L,1L,3L,1L,8L,1L,28L,16L,1L,1L,2L,1L,1L,6L,1L,14L,1L,1L,1L,27L,6L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010275Inst : IEnumerable<long>
{
public static readonly long[] Value=A010275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010275.Bytes);
public long this[int i]=>Value[i];

public static A010275Inst Instance=new A010275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010274
{
public static readonly long[] Value={ 3L,1L,1L,3L,1L,8L,2L,4L,1L,1L,2L,5L,1L,5L,1L,1L,1L,20L,1L,1L,1L,1L,1L,5L,1L,1L,1L,48L,4L,2L,1L,1L,2L,2L,3L,2L,1L,2L,1L,1L,1L,1L,1L,1L,187L,3L,1L,3L,6L,6L,1L,2L,10L,1L,1L,5L,2L,1L,1L,1L,13L,1L,61L,1L,4L,1L,1L,1L,1L,22L,2L,4L,3L,2L,1L,1L,1L,3L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010274Inst : IEnumerable<long>
{
public static readonly long[] Value=A010274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010274.Bytes);
public long this[int i]=>Value[i];

public static A010274Inst Instance=new A010274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010273
{
public static readonly long[] Value={ 3L,1L,1L,7L,1L,2L,1L,4L,3L,12L,1L,1L,1L,1L,3L,4L,1L,4L,1L,2L,2L,1L,17L,2L,18L,2L,16L,1L,2L,45L,1L,2L,6L,2L,3L,111L,16L,2L,1L,1L,3L,31L,1L,4L,1L,1L,1L,12L,1L,19L,1L,8L,3L,1L,1L,1L,1L,1L,2L,1L,2L,1L,8L,2L,1L,3L,7L,2L,20L,5L,2L,25L,1L,3L,22L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010273Inst : IEnumerable<long>
{
public static readonly long[] Value=A010273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010273.Bytes);
public long this[int i]=>Value[i];

public static A010273Inst Instance=new A010273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010272
{
public static readonly long[] Value={ 3L,1L,1L,73L,14L,110L,2L,1L,18L,5L,4L,1L,9L,147L,8L,1L,10L,1L,4L,3L,5L,1L,1L,1L,1L,1L,2L,3L,1L,45L,1L,1L,2L,1L,1L,9L,1L,7L,6L,1L,2L,1L,59L,3L,1L,5L,7L,1L,1L,1L,2L,2L,8L,2L,3L,9L,1L,8L,11L,1L,2L,5L,1L,1L,2L,249L,1L,2L,1L,5L,2L,3L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010272Inst : IEnumerable<long>
{
public static readonly long[] Value=A010272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010272.Bytes);
public long this[int i]=>Value[i];

public static A010272Inst Instance=new A010272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010271
{
public static readonly long[] Value={ 3L,2L,9L,1L,12L,1L,14L,1L,1L,1L,16L,1L,2L,1L,8L,1L,19L,1L,7L,1L,6L,2L,2L,2L,1L,8L,1L,40L,2L,807L,1L,26L,1L,1L,2L,1L,7L,2L,8L,9L,2L,5L,1L,5L,9L,41L,1L,4L,7L,4L,1L,2L,72L,2L,1L,2L,158L,1L,5L,2L,1L,4L,1L,1L,2L,1L,736L,1L,1L,3L,13L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010271Inst : IEnumerable<long>
{
public static readonly long[] Value=A010271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010271.Bytes);
public long this[int i]=>Value[i];

public static A010271Inst Instance=new A010271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010270
{
public static readonly long[] Value={ 3L,2L,4L,3L,19L,1L,36L,2L,3L,3L,1L,4L,4L,3L,11L,1L,1L,3L,1L,2L,97L,1L,3L,1L,1L,1L,3L,1L,16L,2L,3L,7L,1L,6L,2L,2L,1L,4L,3L,1L,6L,1L,3L,11L,1L,1L,1L,15L,1L,2L,4L,4L,1L,4L,3L,1L,1L,1L,4L,2L,2L,3L,1L,2L,4L,3L,1L,1L,4L,1L,1L,2L,6L,1L,22L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010270Inst : IEnumerable<long>
{
public static readonly long[] Value=A010270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010270.Bytes);
public long this[int i]=>Value[i];

public static A010270Inst Instance=new A010270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010269
{
public static readonly long[] Value={ 3L,2L,2L,1L,1L,1L,1L,1L,7L,1L,2L,3L,1L,1L,1L,1L,4L,1L,1L,8L,2L,7L,3L,1L,1525L,1L,4L,4L,2L,2L,7L,1L,2L,6L,1L,1L,2L,3L,27L,1L,83L,1L,1L,1L,1L,5L,1L,11L,1L,15L,7L,16L,1L,2L,4L,4L,1L,1L,4L,1L,2L,7L,1L,1L,5L,1L,1L,3L,1L,1L,4L,1L,1L,23L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010269Inst : IEnumerable<long>
{
public static readonly long[] Value=A010269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010269.Bytes);
public long this[int i]=>Value[i];

public static A010269Inst Instance=new A010269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010268
{
public static readonly long[] Value={ 3L,2L,1L,1L,3L,1L,19L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,29L,1L,21L,1L,1L,1L,3L,9L,2L,2L,3L,2L,4L,4L,1L,5L,4L,1L,39L,1L,7L,1L,6L,1L,173L,3L,4L,7L,1L,1L,6L,2L,3L,1L,1L,2L,9L,1L,6L,1L,1L,79L,1L,7L,1L,24L,2L,1L,2L,1L,1L,1L,7L,5L,1L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010268Inst : IEnumerable<long>
{
public static readonly long[] Value=A010268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010268.Bytes);
public long this[int i]=>Value[i];

public static A010268Inst Instance=new A010268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010267
{
public static readonly long[] Value={ 3L,2L,1L,3L,4L,1L,2L,2L,1L,2L,1L,1L,1L,3L,13L,2L,3L,1L,4L,1L,1L,1L,572L,1L,1L,1L,1L,10L,1L,1L,2L,1L,9L,1L,1L,1L,1L,1L,1L,2L,1L,1L,74L,4L,2L,1L,11L,2L,1L,2L,1L,2L,1L,6L,2L,1L,1L,1L,1L,1L,1L,3L,9L,1L,1L,8L,1L,1L,6L,6L,1L,1L,161L,1L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010267Inst : IEnumerable<long>
{
public static readonly long[] Value=A010267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010267.Bytes);
public long this[int i]=>Value[i];

public static A010267Inst Instance=new A010267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010266
{
public static readonly long[] Value={ 3L,3L,99L,1L,1L,1L,2L,1L,1L,1L,149L,3L,2L,3L,178L,5L,3L,1L,199L,7L,4L,7L,1L,1L,1L,1L,14L,4L,2L,1L,2L,1L,1L,5L,5L,2L,64L,1L,2L,1L,3L,7L,1L,4L,2L,4L,16L,4L,1L,1L,2L,3L,5L,2L,6L,1L,1L,6L,1L,5L,5L,2L,6L,4L,1L,25L,9L,4L,1L,2L,19L,1L,1L,32L,1L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010266Inst : IEnumerable<long>
{
public static readonly long[] Value=A010266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010266.Bytes);
public long this[int i]=>Value[i];

public static A010266Inst Instance=new A010266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010265
{
public static readonly long[] Value={ 3L,3L,3L,4L,1L,7L,1L,83L,1L,36L,15L,3L,2L,3L,1L,3L,2L,2L,4L,1L,1L,4L,1L,1L,5L,1L,1L,1L,5L,1L,25L,1L,1L,9L,2L,1L,1L,8L,3L,1L,1L,1L,2L,6L,3L,2L,14L,1L,1L,2L,11L,2L,1L,4L,1L,4L,1L,3L,1L,1L,2L,1L,1L,1L,11L,1L,1L,1L,1L,15L,9L,1L,1L,20L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010265Inst : IEnumerable<long>
{
public static readonly long[] Value=A010265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010265.Bytes);
public long this[int i]=>Value[i];

public static A010265Inst Instance=new A010265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010264
{
public static readonly long[] Value={ 3L,3L,1L,2L,4L,1L,1L,1L,1L,2L,1L,2L,2L,46L,13L,4L,6L,1L,11L,4L,2L,1L,1L,2L,4L,1L,1L,11L,46L,1L,9L,8L,4L,1L,3L,52L,1L,13L,5L,1L,1L,1L,2L,3L,1L,1L,14L,1L,11L,11L,7L,3L,3L,13L,1L,16L,1L,7L,1L,3L,3L,1L,1L,1L,23L,4L,1L,1L,7L,1L,1L,12L,184L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010264Inst : IEnumerable<long>
{
public static readonly long[] Value=A010264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010264.Bytes);
public long this[int i]=>Value[i];

public static A010264Inst Instance=new A010264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010263
{
public static readonly long[] Value={ 3L,4L,5L,1L,3L,3L,1L,1L,4L,2L,1L,1L,3L,6L,1L,1L,3L,1L,1L,20L,1L,4L,2L,1L,1L,4L,1L,160L,1L,1L,1L,1L,1L,2L,8L,1L,1L,1L,2L,1L,1L,2L,14L,4L,4L,2L,5L,2L,1L,2L,1L,1L,2L,1L,2L,26L,2L,42L,6L,2L,3L,5L,1L,2L,2L,158L,1L,2L,109L,4L,2L,2L,1L,41L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010263Inst : IEnumerable<long>
{
public static readonly long[] Value=A010263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010263.Bytes);
public long this[int i]=>Value[i];

public static A010263Inst Instance=new A010263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010262
{
public static readonly long[] Value={ 3L,4L,1L,4L,1L,1L,27L,5L,1L,1L,2L,2L,1L,3L,2L,1L,1L,6L,3L,1L,1L,1L,1L,50L,6L,3L,1L,5L,1L,3L,3L,1L,4L,1L,19L,1L,5L,1L,4L,17L,1L,4L,1L,3L,2L,1L,4L,5L,1L,8L,1L,1L,1L,1L,3L,1L,2L,1L,10L,6L,1L,2L,1L,6L,5L,1L,1L,13L,7L,2L,2L,9L,1L,1L,30L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010262Inst : IEnumerable<long>
{
public static readonly long[] Value=A010262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010262.Bytes);
public long this[int i]=>Value[i];

public static A010262Inst Instance=new A010262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010261
{
public static readonly long[] Value={ 3L,5L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,62L,1L,1L,1L,5L,4L,1L,1L,2L,1L,1L,1L,1L,3L,1L,14L,1L,6L,1L,2L,3L,3L,52L,1L,3L,15L,4L,1L,132L,1L,7L,1L,2L,1L,1L,1L,29L,1L,12L,1L,3L,1L,1L,2L,13L,1L,1L,1L,1L,9L,1L,10L,30L,1L,1L,1L,1L,1L,1L,4L,15L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010261Inst : IEnumerable<long>
{
public static readonly long[] Value=A010261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010261.Bytes);
public long this[int i]=>Value[i];

public static A010261Inst Instance=new A010261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010260
{
public static readonly long[] Value={ 3L,7L,13L,1L,2L,8L,1L,1L,12L,1L,7L,1L,4L,237L,1L,372L,1L,1L,1L,3L,2L,1L,3L,4L,3L,4L,4L,1L,1L,2L,1L,1L,279L,3L,6L,2L,15L,9L,1L,2L,2L,9L,17L,2L,2L,3L,5L,1L,1L,1L,9L,2L,2L,2L,1L,4L,3L,1L,4L,5L,2L,18L,1L,1L,2L,7L,1L,2L,2L,2L,2L,1L,3L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010260Inst : IEnumerable<long>
{
public static readonly long[] Value=A010260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010260.Bytes);
public long this[int i]=>Value[i];

public static A010260Inst Instance=new A010260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010259
{
public static readonly long[] Value={ 3L,9L,3L,13L,1L,9L,1L,2L,5L,4L,1L,1L,3L,1L,18L,3L,2L,4L,5L,3L,4L,1L,2L,2L,22L,1L,3L,1L,3L,79L,6L,5L,1L,1L,10L,1L,1L,1L,26L,1L,4L,2L,2L,19L,26L,1L,3L,12L,27L,1L,1L,1L,19L,1L,1L,1L,7L,1L,4L,3L,1L,2L,5L,1L,1L,26L,1L,1L,1L,2L,10L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010259Inst : IEnumerable<long>
{
public static readonly long[] Value=A010259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010259.Bytes);
public long this[int i]=>Value[i];

public static A010259Inst Instance=new A010259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010258
{
public static readonly long[] Value={ 3L,13L,1L,4L,1L,4L,2L,2L,2L,3L,1L,1L,2L,1L,1L,4L,1L,3L,2L,3L,8L,7L,2L,2L,1L,2L,8L,1L,3L,12L,1L,2L,3L,1L,11L,1L,2L,1L,1L,170L,2L,1L,4L,1L,3L,2L,11L,1L,2L,1L,2L,2L,3L,5L,3L,53L,2L,10L,6L,1L,2L,5L,3L,2L,3L,2L,1L,3L,2L,12L,13L,5L,6L,4L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010258Inst : IEnumerable<long>
{
public static readonly long[] Value=A010258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010258.Bytes);
public long this[int i]=>Value[i];

public static A010258Inst Instance=new A010258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010257
{
public static readonly long[] Value={ 3L,27L,3L,40L,1L,10L,1L,1L,21L,13L,1L,2L,2L,1L,7L,2L,2L,63L,1L,1L,2L,1L,5L,3L,3L,1L,1L,1L,11L,4L,1L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,3L,2L,1L,1L,2L,3L,5L,124L,17L,2L,1L,41L,4L,47L,1L,2L,1L,5L,1L,8L,1L,1L,32L,1L,4L,1L,6L,4L,2L,4L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010257Inst : IEnumerable<long>
{
public static readonly long[] Value=A010257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010257.Bytes);
public long this[int i]=>Value[i];

public static A010257Inst Instance=new A010257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010256
{
public static readonly long[] Value={ 2L,1L,25L,1L,1L,1L,39L,12L,1L,1L,4L,4L,13L,93L,3L,17L,3L,1L,85L,1L,3L,5L,1L,1L,8L,1L,6L,1L,2L,1L,1L,3L,67L,20L,52L,1L,1L,1L,3L,1L,3L,5L,3L,18L,13L,1L,2L,1L,2L,8L,5L,23L,3L,4L,2L,1L,22L,2L,13L,3L,1L,1L,1L,10L,4L,1L,3L,6L,1L,1L,2L,95L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010256Inst : IEnumerable<long>
{
public static readonly long[] Value=A010256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010256.Bytes);
public long this[int i]=>Value[i];

public static A010256Inst Instance=new A010256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010255
{
public static readonly long[] Value={ 2L,1L,12L,6L,4L,1L,2L,2L,2L,5L,1L,1L,4L,1L,2L,1L,3L,1L,2L,3L,3L,610L,3L,10L,1L,14L,1L,5L,1L,1L,2L,4L,4L,70L,2L,7L,1L,24L,2L,1L,1L,3L,8L,2L,2L,2L,167L,1L,10L,5L,16L,1L,2L,4L,1L,1L,1L,1L,1L,1L,1L,50L,9L,1L,2L,1L,9L,1L,1L,3L,1L,1L,94L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010255Inst : IEnumerable<long>
{
public static readonly long[] Value=A010255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010255.Bytes);
public long this[int i]=>Value[i];

public static A010255Inst Instance=new A010255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010254
{
public static readonly long[] Value={ 2L,1L,7L,1L,1L,1L,12L,13L,1L,10L,4L,6L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,7L,1L,6L,2L,2L,2L,19L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,14L,1L,1L,3L,3L,6L,7L,1L,1L,3L,1L,1L,1L,14L,1L,2L,2L,1L,2L,1L,1L,1L,1L,22L,4L,2L,69L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010254Inst : IEnumerable<long>
{
public static readonly long[] Value=A010254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010254.Bytes);
public long this[int i]=>Value[i];

public static A010254Inst Instance=new A010254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010221
{
public static readonly long[] Value={ 13L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L,2L,3L,3L,26L,3L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010221Inst : IEnumerable<long>
{
public static readonly long[] Value=A010221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010221.Bytes);
public long this[int i]=>Value[i];

public static A010221Inst Instance=new A010221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010220
{
public static readonly long[] Value={ 13L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L,26L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010220Inst : IEnumerable<long>
{
public static readonly long[] Value=A010220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010220.Bytes);
public long this[int i]=>Value[i];

public static A010220Inst Instance=new A010220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010219
{
public static readonly long[] Value={ 13L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L,1L,2L,4L,26L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010219Inst : IEnumerable<long>
{
public static readonly long[] Value=A010219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010219.Bytes);
public long this[int i]=>Value[i];

public static A010219Inst Instance=new A010219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010218
{
public static readonly long[] Value={ 13L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L,26L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010218Inst : IEnumerable<long>
{
public static readonly long[] Value=A010218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010218.Bytes);
public long this[int i]=>Value[i];

public static A010218Inst Instance=new A010218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010217
{
public static readonly long[] Value={ 13L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L,26L,6L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010217Inst : IEnumerable<long>
{
public static readonly long[] Value=A010217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010217.Bytes);
public long this[int i]=>Value[i];

public static A010217Inst Instance=new A010217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010216
{
public static readonly long[] Value={ 13L,8L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,2L,2L,1L,8L,26L,8L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,2L,2L,1L,8L,26L,8L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,2L,2L,1L,8L,26L,8L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,2L,2L,1L,8L,26L,8L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010216Inst : IEnumerable<long>
{
public static readonly long[] Value=A010216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010216.Bytes);
public long this[int i]=>Value[i];

public static A010216Inst Instance=new A010216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010215
{
public static readonly long[] Value={ 12L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L,11L,1L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010215Inst : IEnumerable<long>
{
public static readonly long[] Value=A010215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010215.Bytes);
public long this[int i]=>Value[i];

public static A010215Inst Instance=new A010215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010214
{
public static readonly long[] Value={ 12L,1L,7L,1L,1L,1L,2L,4L,1L,3L,2L,12L,2L,3L,1L,4L,2L,1L,1L,1L,7L,1L,24L,1L,7L,1L,1L,1L,2L,4L,1L,3L,2L,12L,2L,3L,1L,4L,2L,1L,1L,1L,7L,1L,24L,1L,7L,1L,1L,1L,2L,4L,1L,3L,2L,12L,2L,3L,1L,4L,2L,1L,1L,1L,7L,1L,24L,1L,7L,1L,1L,1L,2L,4L,1L,3L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010214Inst : IEnumerable<long>
{
public static readonly long[] Value=A010214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010214.Bytes);
public long this[int i]=>Value[i];

public static A010214Inst Instance=new A010214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010213
{
public static readonly long[] Value={ 12L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L,2L,5L,1L,24L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010213Inst : IEnumerable<long>
{
public static readonly long[] Value=A010213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010213.Bytes);
public long this[int i]=>Value[i];

public static A010213Inst Instance=new A010213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010212
{
public static readonly long[] Value={ 12L,1L,3L,3L,2L,1L,1L,7L,1L,11L,1L,7L,1L,1L,2L,3L,3L,1L,24L,1L,3L,3L,2L,1L,1L,7L,1L,11L,1L,7L,1L,1L,2L,3L,3L,1L,24L,1L,3L,3L,2L,1L,1L,7L,1L,11L,1L,7L,1L,1L,2L,3L,3L,1L,24L,1L,3L,3L,2L,1L,1L,7L,1L,11L,1L,7L,1L,1L,2L,3L,3L,1L,24L,1L,3L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010212Inst : IEnumerable<long>
{
public static readonly long[] Value=A010212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010212.Bytes);
public long this[int i]=>Value[i];

public static A010212Inst Instance=new A010212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010211
{
public static readonly long[] Value={ 12L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L,12L,2L,1L,2L,1L,24L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010211Inst : IEnumerable<long>
{
public static readonly long[] Value=A010211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010211.Bytes);
public long this[int i]=>Value[i];

public static A010211Inst Instance=new A010211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010210
{
public static readonly long[] Value={ 12L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L,2L,1L,24L,1L,2L,4L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010210Inst : IEnumerable<long>
{
public static readonly long[] Value=A010210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010210.Bytes);
public long this[int i]=>Value[i];

public static A010210Inst Instance=new A010210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010209
{
public static readonly long[] Value={ 12L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L,1L,1L,1L,24L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010209Inst : IEnumerable<long>
{
public static readonly long[] Value=A010209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010209.Bytes);
public long this[int i]=>Value[i];

public static A010209Inst Instance=new A010209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010208
{
public static readonly long[] Value={ 12L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010208Inst : IEnumerable<long>
{
public static readonly long[] Value=A010208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010208.Bytes);
public long this[int i]=>Value[i];

public static A010208Inst Instance=new A010208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010207
{
public static readonly long[] Value={ 12L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010207Inst : IEnumerable<long>
{
public static readonly long[] Value=A010207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010207.Bytes);
public long this[int i]=>Value[i];

public static A010207Inst Instance=new A010207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010206
{
public static readonly long[] Value={ 12L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010206Inst : IEnumerable<long>
{
public static readonly long[] Value=A010206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010206.Bytes);
public long this[int i]=>Value[i];

public static A010206Inst Instance=new A010206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010205
{
public static readonly long[] Value={ 12L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010205Inst : IEnumerable<long>
{
public static readonly long[] Value=A010205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010205.Bytes);
public long this[int i]=>Value[i];

public static A010205Inst Instance=new A010205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010204
{
public static readonly long[] Value={ 12L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010204Inst : IEnumerable<long>
{
public static readonly long[] Value=A010204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010204.Bytes);
public long this[int i]=>Value[i];

public static A010204Inst Instance=new A010204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010203
{
public static readonly long[] Value={ 12L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010203Inst : IEnumerable<long>
{
public static readonly long[] Value=A010203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010203.Bytes);
public long this[int i]=>Value[i];

public static A010203Inst Instance=new A010203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010202
{
public static readonly long[] Value={ 12L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010202Inst : IEnumerable<long>
{
public static readonly long[] Value=A010202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010202.Bytes);
public long this[int i]=>Value[i];

public static A010202Inst Instance=new A010202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010201
{
public static readonly long[] Value={ 11L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010201Inst : IEnumerable<long>
{
public static readonly long[] Value=A010201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010201.Bytes);
public long this[int i]=>Value[i];

public static A010201Inst Instance=new A010201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010200
{
public static readonly long[] Value={ 11L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010200Inst : IEnumerable<long>
{
public static readonly long[] Value=A010200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010200.Bytes);
public long this[int i]=>Value[i];

public static A010200Inst Instance=new A010200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010199
{
public static readonly long[] Value={ 11L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010199Inst : IEnumerable<long>
{
public static readonly long[] Value=A010199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010199.Bytes);
public long this[int i]=>Value[i];

public static A010199Inst Instance=new A010199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010198
{
public static readonly long[] Value={ 11L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010198Inst : IEnumerable<long>
{
public static readonly long[] Value=A010198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010198.Bytes);
public long this[int i]=>Value[i];

public static A010198Inst Instance=new A010198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010197
{
public static readonly long[] Value={ 11L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010197Inst : IEnumerable<long>
{
public static readonly long[] Value=A010197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010197.Bytes);
public long this[int i]=>Value[i];

public static A010197Inst Instance=new A010197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010196
{
public static readonly long[] Value={ 11L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010196Inst : IEnumerable<long>
{
public static readonly long[] Value=A010196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010196.Bytes);
public long this[int i]=>Value[i];

public static A010196Inst Instance=new A010196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010195
{
public static readonly long[] Value={ 11L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010195Inst : IEnumerable<long>
{
public static readonly long[] Value=A010195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010195.Bytes);
public long this[int i]=>Value[i];

public static A010195Inst Instance=new A010195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010194
{
public static readonly long[] Value={ 11L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010194Inst : IEnumerable<long>
{
public static readonly long[] Value=A010194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010194.Bytes);
public long this[int i]=>Value[i];

public static A010194Inst Instance=new A010194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010193
{
public static readonly long[] Value={ 11L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010193Inst : IEnumerable<long>
{
public static readonly long[] Value=A010193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010193.Bytes);
public long this[int i]=>Value[i];

public static A010193Inst Instance=new A010193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010192
{
public static readonly long[] Value={ 11L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010192Inst : IEnumerable<long>
{
public static readonly long[] Value=A010192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010192.Bytes);
public long this[int i]=>Value[i];

public static A010192Inst Instance=new A010192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010191
{
public static readonly long[] Value={ 11L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010191Inst : IEnumerable<long>
{
public static readonly long[] Value=A010191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010191.Bytes);
public long this[int i]=>Value[i];

public static A010191Inst Instance=new A010191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010190
{
public static readonly long[] Value={ 11L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010190Inst : IEnumerable<long>
{
public static readonly long[] Value=A010190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010190.Bytes);
public long this[int i]=>Value[i];

public static A010190Inst Instance=new A010190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010189
{
public static readonly long[] Value={ 11L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010189Inst : IEnumerable<long>
{
public static readonly long[] Value=A010189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010189.Bytes);
public long this[int i]=>Value[i];

public static A010189Inst Instance=new A010189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010188
{
public static readonly long[] Value={ 11L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010188Inst : IEnumerable<long>
{
public static readonly long[] Value=A010188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010188.Bytes);
public long this[int i]=>Value[i];

public static A010188Inst Instance=new A010188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010187
{
public static readonly long[] Value={ 11L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010187Inst : IEnumerable<long>
{
public static readonly long[] Value=A010187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010187.Bytes);
public long this[int i]=>Value[i];

public static A010187Inst Instance=new A010187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010186
{
public static readonly long[] Value={ 11L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010186Inst : IEnumerable<long>
{
public static readonly long[] Value=A010186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010186.Bytes);
public long this[int i]=>Value[i];

public static A010186Inst Instance=new A010186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010185
{
public static readonly long[] Value={ 11L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010185Inst : IEnumerable<long>
{
public static readonly long[] Value=A010185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010185.Bytes);
public long this[int i]=>Value[i];

public static A010185Inst Instance=new A010185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010184
{
public static readonly long[] Value={ 10L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010184Inst : IEnumerable<long>
{
public static readonly long[] Value=A010184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010184.Bytes);
public long this[int i]=>Value[i];

public static A010184Inst Instance=new A010184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010183
{
public static readonly long[] Value={ 10L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010183Inst : IEnumerable<long>
{
public static readonly long[] Value=A010183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010183.Bytes);
public long this[int i]=>Value[i];

public static A010183Inst Instance=new A010183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010182
{
public static readonly long[] Value={ 10L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010182Inst : IEnumerable<long>
{
public static readonly long[] Value=A010182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010182.Bytes);
public long this[int i]=>Value[i];

public static A010182Inst Instance=new A010182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010181
{
public static readonly long[] Value={ 10L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010181Inst : IEnumerable<long>
{
public static readonly long[] Value=A010181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010181.Bytes);
public long this[int i]=>Value[i];

public static A010181Inst Instance=new A010181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010180
{
public static readonly long[] Value={ 10L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010180Inst : IEnumerable<long>
{
public static readonly long[] Value=A010180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010180.Bytes);
public long this[int i]=>Value[i];

public static A010180Inst Instance=new A010180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010179
{
public static readonly long[] Value={ 10L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010179Inst : IEnumerable<long>
{
public static readonly long[] Value=A010179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010179.Bytes);
public long this[int i]=>Value[i];

public static A010179Inst Instance=new A010179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010178
{
public static readonly long[] Value={ 10L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010178Inst : IEnumerable<long>
{
public static readonly long[] Value=A010178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010178.Bytes);
public long this[int i]=>Value[i];

public static A010178Inst Instance=new A010178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010177
{
public static readonly long[] Value={ 10L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010177Inst : IEnumerable<long>
{
public static readonly long[] Value=A010177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010177.Bytes);
public long this[int i]=>Value[i];

public static A010177Inst Instance=new A010177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010176
{
public static readonly long[] Value={ 10L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010176Inst : IEnumerable<long>
{
public static readonly long[] Value=A010176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010176.Bytes);
public long this[int i]=>Value[i];

public static A010176Inst Instance=new A010176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010175
{
public static readonly long[] Value={ 10L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010175Inst : IEnumerable<long>
{
public static readonly long[] Value=A010175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010175.Bytes);
public long this[int i]=>Value[i];

public static A010175Inst Instance=new A010175Inst();

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