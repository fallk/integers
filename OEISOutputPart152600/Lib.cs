using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195705
{
public static readonly long[] Value={ 5L,4L,9L,4L,6L,7L,2L,4L,4L,7L,5L,7L,6L,2L,7L,3L,7L,1L,0L,8L,5L,4L,0L,0L,2L,5L,0L,3L,2L,6L,7L,3L,1L,9L,7L,6L,9L,9L,3L,0L,6L,1L,4L,2L,4L,2L,5L,6L,8L,9L,1L,9L,0L,6L,8L,2L,3L,2L,2L,4L,8L,1L,3L,3L,3L,3L,9L,9L,8L,2L,8L,1L,3L,9L,4L,6L,6L,3L,7L,0L,7L,8L,4L,3L,0L,0L,0L,9L,9L,9L,7L,3L,0L,0L,6L,2L,1L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195705Inst : IEnumerable<long>
{
public static readonly long[] Value=A195705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195705.Bytes);
public long this[int i]=>Value[i];

public static A195705Inst Instance=new A195705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195706
{
public static readonly long[] Value={ 2L,2L,2L,9L,8L,5L,4L,3L,6L,2L,6L,2L,1L,3L,0L,5L,6L,0L,2L,1L,0L,4L,1L,5L,3L,8L,1L,8L,9L,6L,2L,7L,7L,1L,6L,7L,7L,0L,2L,1L,7L,8L,0L,1L,8L,2L,9L,8L,2L,9L,1L,0L,2L,6L,8L,9L,1L,4L,2L,4L,6L,5L,5L,4L,8L,6L,0L,5L,7L,4L,7L,7L,4L,4L,7L,4L,1L,4L,6L,1L,3L,7L,7L,6L,5L,1L,5L,1L,7L,4L,7L,8L,9L,2L,5L,8L,0L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195706Inst : IEnumerable<long>
{
public static readonly long[] Value=A195706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195706.Bytes);
public long this[int i]=>Value[i];

public static A195706Inst Instance=new A195706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195707
{
public static readonly long[] Value={ 6L,6L,8L,9L,6L,4L,0L,7L,4L,2L,6L,8L,4L,0L,7L,1L,3L,0L,1L,4L,1L,3L,2L,7L,1L,1L,2L,6L,1L,2L,1L,7L,6L,4L,7L,8L,0L,1L,6L,9L,3L,0L,7L,1L,8L,1L,1L,9L,6L,3L,4L,7L,0L,8L,1L,6L,2L,9L,2L,9L,7L,6L,0L,3L,5L,2L,0L,5L,0L,4L,1L,5L,4L,9L,0L,1L,8L,2L,2L,3L,8L,8L,0L,5L,9L,8L,6L,4L,2L,4L,0L,2L,1L,7L,7L,4L,0L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195707Inst : IEnumerable<long>
{
public static readonly long[] Value=A195707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195707.Bytes);
public long this[int i]=>Value[i];

public static A195707Inst Instance=new A195707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195708
{
public static readonly long[] Value={ 8L,8L,6L,0L,7L,7L,1L,2L,3L,7L,9L,2L,6L,1L,3L,7L,0L,5L,3L,4L,3L,2L,2L,3L,6L,2L,1L,9L,2L,8L,6L,8L,7L,4L,2L,6L,1L,6L,9L,3L,1L,1L,3L,9L,0L,5L,4L,4L,8L,9L,0L,6L,4L,8L,3L,7L,2L,3L,6L,1L,7L,6L,9L,8L,0L,4L,7L,5L,8L,7L,8L,8L,8L,8L,5L,9L,7L,8L,1L,7L,4L,8L,4L,4L,9L,3L,1L,1L,7L,1L,3L,8L,0L,7L,2L,9L,2L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195708Inst : IEnumerable<long>
{
public static readonly long[] Value=A195708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195708.Bytes);
public long this[int i]=>Value[i];

public static A195708Inst Instance=new A195708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195709
{
public static readonly long[] Value={ 5L,6L,3L,9L,4L,2L,6L,4L,1L,3L,6L,0L,6L,2L,8L,8L,4L,2L,6L,9L,3L,8L,3L,1L,1L,7L,2L,1L,8L,3L,7L,4L,6L,8L,4L,7L,8L,5L,1L,8L,5L,9L,5L,3L,9L,3L,0L,4L,2L,5L,6L,7L,8L,3L,7L,5L,7L,2L,4L,2L,6L,6L,4L,2L,6L,6L,9L,2L,6L,2L,7L,9L,6L,5L,7L,8L,7L,4L,1L,2L,3L,6L,4L,0L,9L,2L,9L,4L,5L,7L,1L,8L,8L,3L,8L,4L,5L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195709Inst : IEnumerable<long>
{
public static readonly long[] Value=A195709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195709.Bytes);
public long this[int i]=>Value[i];

public static A195709Inst Instance=new A195709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195710
{
public static readonly long[] Value={ 2L,2L,5L,5L,5L,1L,5L,5L,2L,9L,7L,9L,7L,1L,7L,9L,5L,3L,3L,1L,1L,9L,4L,1L,9L,7L,6L,1L,3L,5L,0L,8L,1L,5L,4L,5L,8L,0L,2L,7L,8L,5L,8L,0L,0L,8L,8L,3L,0L,2L,1L,5L,1L,7L,2L,6L,0L,2L,5L,8L,2L,8L,2L,2L,5L,0L,3L,0L,5L,7L,6L,1L,7L,4L,0L,0L,2L,3L,0L,8L,2L,3L,7L,8L,3L,1L,0L,3L,6L,5L,3L,9L,6L,1L,3L,8L,7L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195710Inst : IEnumerable<long>
{
public static readonly long[] Value=A195710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195710.Bytes);
public long this[int i]=>Value[i];

public static A195710Inst Instance=new A195710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195711
{
public static readonly long[] Value={ 2L,4L,8L,2L,5L,3L,4L,6L,1L,7L,7L,6L,3L,3L,8L,4L,2L,5L,5L,5L,8L,9L,8L,1L,1L,2L,5L,5L,9L,5L,6L,4L,8L,2L,6L,4L,9L,2L,7L,3L,9L,7L,3L,9L,1L,6L,0L,7L,9L,7L,4L,8L,4L,6L,2L,5L,4L,8L,1L,7L,0L,3L,3L,3L,6L,0L,1L,1L,4L,9L,8L,3L,4L,9L,5L,5L,1L,6L,7L,3L,6L,0L,1L,7L,6L,9L,0L,0L,4L,9L,0L,1L,2L,0L,5L,9L,5L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195711Inst : IEnumerable<long>
{
public static readonly long[] Value=A195711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195711.Bytes);
public long this[int i]=>Value[i];

public static A195711Inst Instance=new A195711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195712
{
public static readonly long[] Value={ 9L,1L,6L,8L,6L,8L,3L,8L,4L,2L,9L,4L,6L,7L,3L,2L,5L,2L,9L,1L,7L,1L,8L,2L,3L,9L,9L,1L,8L,8L,5L,0L,8L,8L,0L,6L,3L,0L,7L,1L,6L,4L,2L,9L,0L,0L,4L,9L,6L,3L,1L,3L,3L,0L,9L,0L,2L,4L,4L,0L,9L,0L,8L,2L,5L,4L,5L,9L,6L,8L,3L,1L,5L,9L,9L,3L,7L,8L,1L,9L,7L,1L,0L,6L,9L,9L,7L,5L,7L,8L,8L,4L,0L,2L,1L,0L,1L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195712Inst : IEnumerable<long>
{
public static readonly long[] Value=A195712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195712.Bytes);
public long this[int i]=>Value[i];

public static A195712Inst Instance=new A195712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195713
{
public static readonly long[] Value={ 6L,5L,3L,9L,2L,7L,9L,4L,2L,5L,0L,0L,2L,2L,3L,3L,6L,6L,3L,1L,4L,1L,3L,9L,2L,9L,2L,4L,5L,1L,2L,4L,2L,6L,3L,5L,7L,9L,1L,4L,2L,0L,4L,0L,9L,6L,3L,7L,9L,2L,1L,5L,7L,9L,5L,8L,5L,0L,3L,1L,3L,8L,7L,8L,9L,9L,3L,1L,1L,3L,7L,1L,5L,4L,3L,7L,2L,6L,3L,0L,2L,2L,0L,7L,0L,1L,9L,8L,3L,3L,8L,3L,0L,8L,4L,8L,3L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195713Inst : IEnumerable<long>
{
public static readonly long[] Value=A195713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195713.Bytes);
public long this[int i]=>Value[i];

public static A195713Inst Instance=new A195713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195714
{
public static readonly long[] Value={ 6L,7L,0L,8L,8L,7L,9L,7L,8L,7L,1L,2L,5L,1L,5L,2L,2L,9L,6L,5L,7L,6L,0L,4L,2L,3L,8L,1L,8L,7L,2L,2L,2L,3L,4L,8L,1L,2L,5L,9L,1L,7L,5L,4L,5L,7L,6L,9L,6L,0L,8L,5L,9L,6L,1L,0L,6L,6L,2L,7L,9L,1L,6L,4L,6L,2L,5L,0L,8L,9L,4L,1L,9L,9L,7L,2L,4L,7L,5L,2L,8L,6L,4L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195714Inst : IEnumerable<long>
{
public static readonly long[] Value=A195714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195714.Bytes);
public long this[int i]=>Value[i];

public static A195714Inst Instance=new A195714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195715
{
public static readonly long[] Value={ 2L,4L,8L,7L,6L,6L,4L,7L,1L,1L,0L,8L,9L,5L,6L,9L,8L,7L,2L,1L,4L,8L,5L,0L,4L,0L,9L,0L,8L,2L,8L,2L,6L,0L,2L,4L,8L,4L,0L,5L,7L,4L,8L,9L,8L,9L,7L,3L,7L,1L,8L,4L,2L,4L,1L,3L,8L,9L,9L,1L,3L,2L,0L,4L,4L,0L,8L,5L,0L,5L,0L,3L,4L,7L,4L,2L,4L,8L,2L,6L,9L,6L,4L,2L,1L,0L,1L,4L,9L,9L,1L,5L,1L,1L,2L,6L,8L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195715Inst : IEnumerable<long>
{
public static readonly long[] Value=A195715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195715.Bytes);
public long this[int i]=>Value[i];

public static A195715Inst Instance=new A195715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195716
{
public static readonly long[] Value={ 6L,8L,1L,5L,0L,2L,3L,8L,1L,6L,8L,1L,4L,1L,3L,5L,4L,0L,9L,5L,5L,8L,6L,3L,4L,3L,2L,1L,5L,8L,8L,9L,5L,0L,6L,0L,5L,5L,9L,3L,7L,4L,2L,4L,7L,2L,1L,8L,3L,3L,7L,6L,3L,7L,0L,2L,2L,7L,2L,2L,2L,5L,4L,1L,3L,2L,0L,7L,7L,2L,8L,3L,0L,1L,9L,7L,1L,4L,1L,3L,5L,6L,9L,4L,3L,5L,9L,7L,9L,7L,4L,9L,5L,0L,9L,0L,6L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195716Inst : IEnumerable<long>
{
public static readonly long[] Value=A195716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195716.Bytes);
public long this[int i]=>Value[i];

public static A195716Inst Instance=new A195716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195717
{
public static readonly long[] Value={ 8L,8L,9L,2L,9L,3L,9L,4L,5L,1L,1L,3L,4L,8L,3L,0L,7L,8L,2L,7L,5L,4L,5L,8L,2L,5L,9L,4L,8L,0L,8L,5L,6L,3L,8L,1L,5L,3L,9L,2L,1L,0L,4L,5L,2L,4L,6L,9L,2L,1L,5L,2L,7L,3L,4L,6L,4L,7L,5L,0L,0L,4L,2L,0L,2L,1L,8L,3L,0L,9L,2L,0L,1L,2L,3L,3L,9L,0L,3L,6L,3L,6L,1L,9L,6L,5L,7L,6L,1L,5L,1L,7L,5L,9L,6L,7L,8L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195717Inst : IEnumerable<long>
{
public static readonly long[] Value=A195717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195717.Bytes);
public long this[int i]=>Value[i];

public static A195717Inst Instance=new A195717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195718
{
public static readonly long[] Value={ 5L,6L,2L,1L,5L,8L,4L,8L,4L,3L,5L,7L,2L,2L,1L,9L,0L,1L,5L,2L,2L,5L,2L,0L,2L,3L,4L,4L,3L,5L,0L,8L,2L,0L,6L,6L,5L,3L,4L,6L,6L,7L,0L,5L,8L,3L,9L,7L,5L,8L,6L,6L,5L,0L,6L,7L,0L,4L,3L,0L,8L,6L,8L,6L,9L,2L,1L,2L,0L,4L,6L,8L,3L,7L,2L,4L,9L,8L,3L,8L,2L,0L,0L,4L,5L,3L,2L,1L,2L,5L,5L,6L,1L,5L,7L,8L,4L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195718Inst : IEnumerable<long>
{
public static readonly long[] Value=A195718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195718.Bytes);
public long this[int i]=>Value[i];

public static A195718Inst Instance=new A195718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195719
{
public static readonly long[] Value={ 2L,2L,5L,2L,2L,9L,8L,7L,0L,8L,4L,7L,6L,3L,1L,0L,1L,6L,0L,1L,8L,7L,1L,8L,5L,1L,2L,3L,7L,9L,8L,6L,4L,6L,5L,0L,2L,6L,5L,7L,9L,5L,8L,9L,4L,6L,9L,0L,5L,8L,9L,0L,5L,4L,7L,5L,1L,0L,1L,9L,4L,5L,5L,0L,2L,8L,5L,9L,8L,5L,4L,8L,6L,1L,6L,2L,8L,1L,8L,6L,3L,5L,0L,0L,8L,3L,7L,7L,2L,1L,0L,1L,6L,6L,1L,4L,9L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195719Inst : IEnumerable<long>
{
public static readonly long[] Value=A195719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195719.Bytes);
public long this[int i]=>Value[i];

public static A195719Inst Instance=new A195719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195720
{
public static readonly long[] Value={ 1L,1L,5L,0L,2L,6L,1L,9L,9L,1L,5L,1L,0L,9L,3L,1L,4L,9L,1L,3L,4L,3L,0L,5L,9L,1L,7L,5L,7L,2L,6L,5L,3L,6L,0L,6L,8L,7L,4L,7L,5L,4L,5L,3L,0L,6L,8L,6L,7L,6L,3L,3L,3L,0L,0L,5L,9L,8L,2L,1L,0L,8L,9L,3L,8L,0L,7L,8L,6L,3L,5L,5L,1L,4L,0L,4L,9L,3L,5L,8L,1L,9L,0L,5L,4L,7L,5L,0L,4L,1L,0L,2L,4L,5L,2L,6L,6L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195720Inst : IEnumerable<long>
{
public static readonly long[] Value=A195720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195720.Bytes);
public long this[int i]=>Value[i];

public static A195720Inst Instance=new A195720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195721
{
public static readonly long[] Value={ 3L,8L,7L,5L,9L,6L,6L,8L,6L,6L,5L,5L,1L,8L,0L,6L,5L,3L,6L,0L,2L,0L,4L,6L,8L,5L,5L,5L,9L,1L,2L,3L,6L,7L,1L,2L,8L,9L,9L,9L,0L,8L,7L,1L,7L,0L,1L,1L,5L,0L,1L,2L,5L,7L,9L,6L,4L,0L,8L,2L,2L,3L,0L,7L,8L,8L,0L,5L,8L,8L,3L,8L,7L,5L,1L,0L,3L,9L,3L,9L,9L,6L,4L,9L,9L,0L,3L,2L,7L,9L,8L,9L,2L,7L,6L,4L,6L,0L,4L,4L,9L,8L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195721Inst : IEnumerable<long>
{
public static readonly long[] Value=A195721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195721.Bytes);
public long this[int i]=>Value[i];

public static A195721Inst Instance=new A195721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195722
{
public static readonly long[] Value={ 1L,9L,9L,1L,3L,3L,0L,6L,6L,2L,0L,7L,8L,8L,6L,1L,7L,4L,7L,1L,1L,9L,5L,8L,4L,2L,0L,7L,5L,5L,2L,9L,6L,6L,8L,1L,5L,4L,4L,9L,6L,2L,4L,0L,9L,2L,5L,0L,7L,4L,7L,2L,5L,2L,0L,3L,7L,6L,7L,3L,3L,6L,9L,8L,4L,9L,9L,9L,5L,2L,8L,5L,4L,8L,8L,1L,2L,7L,3L,1L,7L,9L,5L,7L,3L,2L,8L,4L,4L,1L,5L,0L,9L,6L,8L,5L,1L,0L,5L,0L,8L,8L,2L,5L,6L,3L,3L,8L,5L,8L,7L,4L,6L,5L,6L,4L,1L,1L,3L,4L,8L,7L,5L,8L,7L,0L,0L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195722Inst : IEnumerable<long>
{
public static readonly long[] Value=A195722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195722.Bytes);
public long this[int i]=>Value[i];

public static A195722Inst Instance=new A195722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195723
{
public static readonly long[] Value={ 1L,0L,1L,7L,2L,2L,1L,9L,6L,7L,8L,9L,7L,8L,5L,1L,3L,6L,7L,7L,2L,2L,7L,8L,8L,9L,6L,1L,5L,5L,0L,4L,8L,2L,9L,2L,2L,0L,6L,3L,5L,6L,0L,8L,7L,6L,9L,8L,6L,8L,3L,6L,5L,8L,7L,1L,4L,9L,2L,0L,2L,6L,9L,2L,4L,3L,7L,0L,5L,3L,0L,3L,3L,6L,5L,4L,4L,2L,3L,1L,0L,2L,3L,0L,7L,3L,0L,8L,8L,4L,8L,3L,2L,7L,9L,7L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195723Inst : IEnumerable<long>
{
public static readonly long[] Value=A195723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195723.Bytes);
public long this[int i]=>Value[i];

public static A195723Inst Instance=new A195723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195724
{
public static readonly long[] Value={ 1L,2L,8L,9L,7L,6L,1L,4L,2L,5L,2L,9L,2L,0L,8L,3L,0L,2L,1L,5L,1L,1L,3L,0L,6L,7L,4L,1L,2L,7L,7L,4L,8L,2L,8L,9L,8L,5L,7L,5L,4L,6L,7L,1L,9L,7L,0L,8L,8L,3L,9L,9L,6L,9L,3L,0L,1L,1L,9L,8L,0L,2L,2L,1L,5L,1L,1L,4L,6L,1L,1L,3L,4L,1L,8L,3L,7L,3L,2L,7L,2L,5L,2L,1L,4L,0L,1L,8L,0L,1L,8L,6L,0L,5L,3L,5L,3L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195724Inst : IEnumerable<long>
{
public static readonly long[] Value=A195724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195724.Bytes);
public long this[int i]=>Value[i];

public static A195724Inst Instance=new A195724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195725
{
public static readonly long[] Value={ 7L,3L,9L,8L,8L,0L,7L,7L,4L,3L,7L,8L,7L,4L,0L,7L,6L,6L,8L,7L,3L,1L,8L,1L,0L,8L,3L,4L,3L,4L,8L,2L,0L,3L,7L,4L,1L,0L,2L,4L,0L,2L,5L,9L,5L,6L,5L,9L,6L,4L,5L,2L,1L,4L,0L,9L,0L,9L,6L,6L,7L,3L,1L,1L,6L,7L,2L,0L,9L,1L,3L,4L,4L,1L,4L,5L,7L,5L,7L,2L,8L,6L,3L,8L,2L,7L,4L,2L,9L,0L,4L,0L,8L,9L,0L,4L,6L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195725Inst : IEnumerable<long>
{
public static readonly long[] Value=A195725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195725.Bytes);
public long this[int i]=>Value[i];

public static A195725Inst Instance=new A195725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195726
{
public static readonly long[] Value={ 2L,7L,2L,1L,0L,5L,8L,3L,1L,8L,3L,0L,5L,8L,2L,8L,1L,1L,0L,5L,7L,4L,3L,8L,0L,8L,6L,7L,3L,6L,6L,2L,8L,7L,5L,1L,0L,8L,4L,6L,1L,3L,0L,0L,0L,6L,5L,5L,5L,1L,8L,6L,2L,1L,1L,0L,8L,5L,6L,8L,3L,1L,8L,9L,9L,6L,1L,7L,7L,1L,7L,5L,4L,5L,4L,8L,0L,4L,0L,3L,1L,8L,3L,6L,8L,7L,6L,7L,8L,2L,2L,9L,1L,6L,3L,2L,4L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195726Inst : IEnumerable<long>
{
public static readonly long[] Value=A195726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195726.Bytes);
public long this[int i]=>Value[i];

public static A195726Inst Instance=new A195726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195727
{
public static readonly long[] Value={ 2L,4L,4L,9L,7L,8L,6L,6L,3L,1L,2L,6L,8L,6L,4L,1L,5L,4L,1L,7L,2L,0L,8L,2L,4L,8L,1L,2L,1L,1L,2L,7L,5L,8L,1L,0L,9L,1L,4L,1L,4L,4L,0L,9L,8L,3L,8L,1L,1L,8L,4L,0L,6L,7L,1L,2L,7L,3L,7L,5L,9L,1L,4L,6L,6L,7L,3L,5L,5L,1L,1L,9L,5L,8L,7L,6L,4L,2L,0L,9L,6L,5L,7L,4L,5L,3L,4L,1L,5L,7L,6L,6L,8L,7L,0L,1L,9L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195727Inst : IEnumerable<long>
{
public static readonly long[] Value=A195727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195727.Bytes);
public long this[int i]=>Value[i];

public static A195727Inst Instance=new A195727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195728
{
public static readonly long[] Value={ 1L,1L,8L,3L,1L,9L,9L,6L,4L,0L,1L,3L,9L,7L,1L,5L,9L,6L,5L,6L,2L,9L,2L,7L,4L,8L,3L,6L,0L,4L,8L,5L,1L,4L,7L,2L,9L,1L,9L,8L,6L,7L,5L,9L,8L,2L,6L,7L,6L,0L,5L,1L,6L,5L,2L,5L,2L,3L,3L,9L,0L,0L,6L,5L,3L,6L,5L,8L,4L,9L,3L,6L,4L,3L,9L,2L,0L,6L,5L,0L,9L,9L,6L,6L,4L,1L,1L,4L,1L,3L,2L,7L,7L,8L,2L,9L,3L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195728Inst : IEnumerable<long>
{
public static readonly long[] Value=A195728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195728.Bytes);
public long this[int i]=>Value[i];

public static A195728Inst Instance=new A195728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195729
{
public static readonly long[] Value={ 1L,2L,4L,9L,0L,4L,5L,7L,7L,2L,3L,9L,8L,2L,5L,4L,4L,2L,5L,8L,2L,9L,9L,1L,7L,0L,7L,7L,2L,8L,1L,0L,9L,0L,1L,2L,3L,0L,7L,7L,8L,2L,9L,4L,0L,4L,1L,2L,9L,8L,9L,6L,7L,1L,9L,0L,5L,4L,6L,6L,9L,2L,3L,6L,7L,9L,7L,1L,5L,1L,9L,6L,5L,7L,3L,7L,2L,9L,3L,9L,5L,4L,9L,5L,7L,6L,0L,8L,9L,9L,0L,3L,2L,0L,4L,1L,7L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195729Inst : IEnumerable<long>
{
public static readonly long[] Value=A195729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195729.Bytes);
public long this[int i]=>Value[i];

public static A195729Inst Instance=new A195729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195730
{
public static readonly long[] Value={ 1L,2L,6L,4L,5L,1L,8L,9L,5L,7L,6L,2L,5L,2L,2L,7L,1L,6L,3L,1L,4L,9L,0L,8L,3L,4L,7L,2L,0L,0L,7L,0L,1L,2L,2L,0L,3L,5L,8L,6L,0L,4L,8L,7L,1L,2L,0L,1L,1L,0L,0L,9L,3L,6L,4L,4L,5L,4L,2L,1L,1L,8L,4L,2L,4L,5L,7L,9L,1L,8L,6L,0L,1L,7L,8L,6L,4L,0L,2L,7L,2L,8L,0L,5L,1L,6L,7L,2L,8L,1L,9L,0L,5L,1L,2L,1L,7L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195730Inst : IEnumerable<long>
{
public static readonly long[] Value=A195730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195730.Bytes);
public long this[int i]=>Value[i];

public static A195730Inst Instance=new A195730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195731
{
public static readonly long[] Value={ 1L,3L,1L,8L,1L,1L,6L,0L,7L,1L,6L,5L,2L,8L,1L,7L,9L,6L,5L,7L,4L,5L,6L,6L,4L,2L,5L,4L,6L,4L,6L,0L,4L,0L,4L,6L,9L,8L,4L,6L,3L,9L,0L,9L,6L,6L,5L,9L,0L,7L,1L,4L,7L,1L,6L,8L,5L,3L,5L,4L,8L,5L,1L,7L,4L,1L,3L,3L,3L,3L,1L,4L,2L,6L,6L,2L,0L,8L,3L,2L,7L,6L,9L,0L,2L,2L,6L,8L,6L,7L,0L,4L,4L,3L,0L,4L,3L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195731Inst : IEnumerable<long>
{
public static readonly long[] Value=A195731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195731.Bytes);
public long this[int i]=>Value[i];

public static A195731Inst Instance=new A195731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195732
{
public static readonly long[] Value={ 1L,2L,3L,11L,30L,62L,534L,620L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195732Inst : IEnumerable<long>
{
public static readonly long[] Value=A195732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195732.Bytes);
public long this[int i]=>Value[i];

public static A195732Inst Instance=new A195732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195733
{
public static readonly long[] Value={ 1L,2L,4L,12L,36L,144L,288L,1440L,3840L,9216L,120384L,700416L,5455872L,65015808L,188018688L,439805952L,1098528768L,31016134656L,324642484224L,12673570111488L,75959807901696L,1301903865544704L,2870722110554112L,32326598156353536L,193916357676367872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195733Inst : IEnumerable<long>
{
public static readonly long[] Value=A195733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195733.Bytes);
public long this[int i]=>Value[i];

public static A195733Inst Instance=new A195733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195734
{
public static readonly long[] Value={ 1L,1L,3L,6L,11L,22L,40L,72L,123L,215L,363L,605L,991L,1618L,2598L,4139L,6537L,10229L,15871L,24476L,37487L,56995L,86177L,129531L,193662L,287992L,426254L,627841L,920708L,1344331L,1954987L,2831688L,4086168L,5875087L,8417724L,12020250L,17108958L,24275947L,34340966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195734Inst : IEnumerable<long>
{
public static readonly long[] Value=A195734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195734.Bytes);
public long this[int i]=>Value[i];

public static A195734Inst Instance=new A195734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195735
{
public static readonly long[] Value={ 1L,5L,10L,13L,26L,38L,50L,29L,73L,110L,122L,22L,170L,222L,230L,61L,290L,173L,362L,158L,458L,566L,530L,-298L,601L,798L,586L,398L,842L,458L,962L,125L,1154L,1382L,1230L,-779L,1370L,1734L,1622L,-226L,1682L,1158L,1850L,1190L,1418L,2558L,2210L,-2090L,2353L,2285L,2798L,1742L,2810L,902L,3062L,78L,3506L,4094L,3482L,-3238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195735Inst : IEnumerable<long>
{
public static readonly long[] Value=A195735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195735.Bytes);
public long this[int i]=>Value[i];

public static A195735Inst Instance=new A195735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195736
{
public static readonly BigInteger[] Value={ 1L,2L,21L,568L,29705L,2573136L,335201293L,61480323584L,15135660248913L,4823681315219200L,1934425407465004421L,BigInteger.Parse("954153609788873382912"),BigInteger.Parse("568125617688093236137561"),BigInteger.Parse("402006917909739659429470208"),BigInteger.Parse("333597313002114320208678928125") };
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
public class A195736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195736Inst Instance=new A195736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195737
{
public static readonly BigInteger[] Value={ 1L,2L,15L,256L,7935L,392526L,28498246L,2863702080L,381411964485L,65129544696250L,13888321460879976L,3620285828450155008L,BigInteger.Parse("1133432920326577483795"),BigInteger.Parse("419923892646668363653350"),BigInteger.Parse("181795302703808044653240000"),BigInteger.Parse("90971411268941227901619966976") };
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
public class A195737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195737Inst Instance=new A195737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195738
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,6L,3L,0L,1L,17L,17L,4L,0L,1L,59L,131L,52L,7L,0L,1L,195L,915L,709L,153L,13L,0L,1L,703L,6553L,8946L,3350L,454L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195738Inst : IEnumerable<long>
{
public static readonly long[] Value=A195738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195738.Bytes);
public long this[int i]=>Value[i];

public static A195738Inst Instance=new A195738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195739
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,4L,0L,1L,17L,32L,0L,1L,61L,348L,400L,0L,1L,214L,2836L,8640L,6912L,0L,1L,758L,21225L,129288L,254800L,153664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195739Inst : IEnumerable<long>
{
public static readonly long[] Value=A195739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195739.Bytes);
public long this[int i]=>Value[i];

public static A195739Inst Instance=new A195739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195740
{
public static readonly long[] Value={ 29L,1247L,261L,89972L,5511L,608992L,58631L,418808411L,312221L,278668008656L,6651971L,1886445877264L,70864611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195740Inst : IEnumerable<long>
{
public static readonly long[] Value=A195740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195740.Bytes);
public long this[int i]=>Value[i];

public static A195740Inst Instance=new A195740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195741
{
public static readonly long[] Value={ 0L,0L,1L,6L,17L,59L,195L,703L,2499L,9188L,33890L,126758L,476269L,1802311L,6849776L,26152417L,100203193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195741Inst : IEnumerable<long>
{
public static readonly long[] Value=A195741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195741.Bytes);
public long this[int i]=>Value[i];

public static A195741Inst Instance=new A195741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195742
{
public static readonly long[] Value={ 2L,200L,1L,300L,10L,400L,2L,200L,1L,1L,30L,5L,10L,600L,1L,400L,5L,300L,40L,10L,600L,6L,1L,400L,5L,1L,200L,900L,6L,5L,1L,200L,900L,5L,10L,400L,5L,400L,5L,6L,6L,2L,5L,6L,6L,8L,300L,500L,70L,30L,80L,50L,10L,400L,5L,6L,600L,6L,200L,6L,8L,1L,30L,5L,10L,600L,40L,200L,8L,80L,400L,70L,30L,80L,50L,10L,5L,40L,10L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195742Inst : IEnumerable<long>
{
public static readonly long[] Value=A195742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195742.Bytes);
public long this[int i]=>Value[i];

public static A195742Inst Instance=new A195742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195743
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,2L,3L,3L,5L,3L,6L,5L,6L,2L,7L,3L,8L,3L,5L,6L,9L,3L,5L,7L,3L,5L,10L,5L,11L,2L,11L,8L,11L,3L,12L,11L,8L,3L,13L,4L,14L,7L,10L,11L,15L,3L,7L,4L,15L,5L,16L,3L,9L,5L,11L,13L,17L,4L,18L,16L,6L,2L,18L,8L,19L,6L,19L,9L,20L,3L,21L,17L,10L,11L,21L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195743Inst : IEnumerable<long>
{
public static readonly long[] Value=A195743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195743.Bytes);
public long this[int i]=>Value[i];

public static A195743Inst Instance=new A195743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195744
{
public static readonly long[] Value={ 31L,61L,121L,241L,481L,961L,1921L,3841L,7681L,15361L,30721L,61441L,122881L,245761L,491521L,983041L,1966081L,3932161L,7864321L,15728641L,31457281L,62914561L,125829121L,251658241L,503316481L,1006632961L,2013265921L,4026531841L,8053063681L,16106127361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195744Inst : IEnumerable<long>
{
public static readonly long[] Value=A195744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195744.Bytes);
public long this[int i]=>Value[i];

public static A195744Inst Instance=new A195744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195745
{
public static readonly BigInteger[] Value={ 31L,61L,241L,7681L,15361L,61441L,2013265921L,2061584302081L,4123168604161L,263882790666241L,4222124650659841L,BigInteger.Parse("4533471823554859405148161"),BigInteger.Parse("77884452878022414427957444938301441"),BigInteger.Parse("5612166287350667205902149757630526795478780965027841") };
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
public class A195745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195745Inst Instance=new A195745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195746
{
public static readonly long[] Value={ 3L,4L,8L,12L,19L,42L,98L,154L,107L,572L,932L,2132L,539L,3825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195746Inst : IEnumerable<long>
{
public static readonly long[] Value=A195746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195746.Bytes);
public long this[int i]=>Value[i];

public static A195746Inst Instance=new A195746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195747
{
public static readonly long[] Value={ 4L,5L,14L,11L,63L,27L,298L,69L,1221L,179L,6819L,467L,21893L,1221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195747Inst : IEnumerable<long>
{
public static readonly long[] Value=A195747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195747.Bytes);
public long this[int i]=>Value[i];

public static A195747Inst Instance=new A195747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195748
{
public static readonly long[] Value={ 12L,11L,50L,37L,1245L,1159L,39608L,7275L,52541L,75291L,1212200L,607435L,181087528L,1225261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195748Inst : IEnumerable<long>
{
public static readonly long[] Value=A195748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195748.Bytes);
public long this[int i]=>Value[i];

public static A195748Inst Instance=new A195748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195749
{
public static readonly long[] Value={ 19L,63L,2816L,1245L,143L,70668L,74283746L,622677L,34716123L,4522574L,82212839L,1010388604L,34860663827L,2227981245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195749Inst : IEnumerable<long>
{
public static readonly long[] Value=A195749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195749.Bytes);
public long this[int i]=>Value[i];

public static A195749Inst Instance=new A195749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195750
{
public static readonly long[] Value={ 42L,27L,1632L,1159L,70668L,3853L,4667448L,216143L,14658527L,40619575L,14072629988L,115245795L,21481359503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195750Inst : IEnumerable<long>
{
public static readonly long[] Value=A195750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195750.Bytes);
public long this[int i]=>Value[i];

public static A195750Inst Instance=new A195750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195751
{
public static readonly long[] Value={ 98L,298L,15004L,39608L,74283746L,4667448L,471247L,31057338L,79885513801295L,58727863626L,1157365463811298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195751Inst : IEnumerable<long>
{
public static readonly long[] Value=A195751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195751.Bytes);
public long this[int i]=>Value[i];

public static A195751Inst Instance=new A195751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195752
{
public static readonly long[] Value={ 4L,8L,8L,26L,19L,94L,98L,348L,107L,1296L,934L,4834L,539L,18038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195752Inst : IEnumerable<long>
{
public static readonly long[] Value=A195752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195752.Bytes);
public long this[int i]=>Value[i];

public static A195752Inst Instance=new A195752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195753
{
public static readonly long[] Value={ 8L,30L,74L,269L,356L,3309L,11178L,10351L,28028L,519141L,56511L,6511653L,4798118L,3319643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195753Inst : IEnumerable<long>
{
public static readonly long[] Value=A195753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195753.Bytes);
public long this[int i]=>Value[i];

public static A195753Inst Instance=new A195753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195754
{
public static readonly long[] Value={ 8L,74L,62L,960L,2816L,118668L,15004L,3399408L,223244L,20464714L,851928L,1659128426L,136296090L,2866207958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195754Inst : IEnumerable<long>
{
public static readonly long[] Value=A195754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195754.Bytes);
public long this[int i]=>Value[i];

public static A195754Inst Instance=new A195754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195755
{
public static readonly long[] Value={ 26L,269L,960L,417L,5502L,4276501L,50446504L,92694437L,42601245L,74269856053L,3914071518L,78122151013L,981143881088L,176981282511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195755Inst : IEnumerable<long>
{
public static readonly long[] Value=A195755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195755.Bytes);
public long this[int i]=>Value[i];

public static A195755Inst Instance=new A195755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195756
{
public static readonly long[] Value={ 19L,3516L,2816L,5502L,6085L,989568L,74283746L,547462302L,34716123L,19876549906L,82212839L,75644545049024L,34860663827L,126494851419642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195756Inst : IEnumerable<long>
{
public static readonly long[] Value=A195756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195756.Bytes);
public long this[int i]=>Value[i];

public static A195756Inst Instance=new A195756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195757
{
public static readonly long[] Value={ 94L,3309L,118668L,4276501L,989568L,206991L,236701922202L,474044608301L,27317507372L,11912444546191029L,36025114345204896L,1857217354169779821L,334722240784573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195757Inst : IEnumerable<long>
{
public static readonly long[] Value=A195757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195757.Bytes);
public long this[int i]=>Value[i];

public static A195757Inst Instance=new A195757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195758
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,3L,3L,7L,3L,7L,3L,3L,11L,3L,7L,3L,3L,11L,7L,3L,3L,7L,11L,3L,3L,7L,3L,19L,3L,7L,11L,3L,7L,3L,11L,3L,7L,3L,7L,19L,3L,3L,11L,3L,3L,23L,3L,7L,11L,7L,3L,11L,3L,3L,19L,3L,11L,7L,19L,11L,7L,3L,3L,7L,23L,3L,3L,7L,3L,23L,3L,19L,11L,3L,7L,3L,7L,11L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195758Inst : IEnumerable<long>
{
public static readonly long[] Value=A195758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195758.Bytes);
public long this[int i]=>Value[i];

public static A195758Inst Instance=new A195758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195759
{
public static readonly long[] Value={ 7L,11L,19L,23L,11L,31L,43L,19L,47L,23L,59L,67L,19L,71L,31L,79L,83L,23L,43L,103L,107L,47L,31L,127L,131L,59L,139L,23L,151L,67L,43L,163L,71L,167L,47L,179L,79L,191L,83L,31L,199L,211L,59L,223L,227L,31L,239L,103L,67L,107L,251L,71L,263L,271L,43L,283L,79L,127L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195759Inst : IEnumerable<long>
{
public static readonly long[] Value=A195759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195759.Bytes);
public long this[int i]=>Value[i];

public static A195759Inst Instance=new A195759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195760
{
public static readonly long[] Value={ 1L,5L,15L,35L,70L,130L,230L,390L,635L,995L,1515L,2255L,3290L,4710L,6620L,9160L,12505L,16865L,22485L,29645L,38695L,50055L,64215L,81735L,103245L,129505L,161405L,199965L,246335L,301795L,367855L,446255L,538965L,648185L,776345L,926265L,1101155L,1304615L,1540635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195760Inst : IEnumerable<long>
{
public static readonly long[] Value=A195760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195760.Bytes);
public long this[int i]=>Value[i];

public static A195760Inst Instance=new A195760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195761
{
public static readonly long[] Value={ 1L,5L,15L,35L,70L,135L,255L,465L,810L,1345L,2180L,3480L,5465L,8410L,12645L,18720L,27405L,39690L,56785L,80120L,111840L,154805L,212590L,289485L,390495L,522640L,694955L,918490L,1206310L,1573495L,2040260L,2631955L,3379065L,4317210L,5487145L,6941780L,8746180L,10977565L,13725310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195761Inst : IEnumerable<long>
{
public static readonly long[] Value=A195761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195761.Bytes);
public long this[int i]=>Value[i];

public static A195761Inst Instance=new A195761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195762
{
public static readonly long[] Value={ 1L,1L,4L,32L,400L,6912L,153664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195762Inst : IEnumerable<long>
{
public static readonly long[] Value=A195762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195762.Bytes);
public long this[int i]=>Value[i];

public static A195762Inst Instance=new A195762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195763
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1039761L,379137552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195763Inst : IEnumerable<long>
{
public static readonly long[] Value=A195763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195763.Bytes);
public long this[int i]=>Value[i];

public static A195763Inst Instance=new A195763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195764
{
public static readonly long[] Value={ 1L,1L,1L,3L,15L,135L,2889L,146559L,17742675L,5342155407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195764Inst : IEnumerable<long>
{
public static readonly long[] Value=A195764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195764.Bytes);
public long this[int i]=>Value[i];

public static A195764Inst Instance=new A195764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195765
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8472L,898125L,276763188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195765Inst : IEnumerable<long>
{
public static readonly long[] Value=A195765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195765.Bytes);
public long this[int i]=>Value[i];

public static A195765Inst Instance=new A195765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195766
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1037343L,374504433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195766Inst : IEnumerable<long>
{
public static readonly long[] Value=A195766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195766.Bytes);
public long this[int i]=>Value[i];

public static A195766Inst Instance=new A195766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195767
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1039761L,379119168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195767Inst : IEnumerable<long>
{
public static readonly long[] Value=A195767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195767.Bytes);
public long this[int i]=>Value[i];

public static A195767Inst Instance=new A195767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195768
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,15L,1L,1L,1L,1L,3L,18L,135L,1L,1L,1L,1L,3L,18L,228L,2889L,1L,1L,1L,1L,3L,18L,228L,8472L,146559L,1L,1L,1L,1L,3L,18L,228L,8904L,898125L,17742675L,1L,1L,1L,1L,3L,18L,228L,8904L,1037343L,276763188L,5342155407L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195768Inst : IEnumerable<long>
{
public static readonly long[] Value=A195768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195768.Bytes);
public long this[int i]=>Value[i];

public static A195768Inst Instance=new A195768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195769
{
public static readonly long[] Value={ 1L,3L,7L,3L,4L,0L,0L,7L,6L,6L,9L,4L,5L,0L,1L,5L,8L,6L,0L,8L,6L,1L,2L,7L,1L,9L,2L,6L,4L,4L,4L,9L,6L,1L,1L,4L,8L,6L,5L,0L,9L,9L,9L,5L,9L,5L,8L,9L,9L,7L,0L,0L,8L,0L,8L,9L,6L,9L,7L,8L,3L,3L,5L,5L,9L,1L,2L,8L,7L,4L,2L,3L,3L,1L,6L,4L,8L,6L,0L,7L,1L,3L,5L,8L,1L,3L,1L,9L,5L,8L,4L,6L,3L,3L,7L,7L,0L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195769Inst : IEnumerable<long>
{
public static readonly long[] Value=A195769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195769.Bytes);
public long this[int i]=>Value[i];

public static A195769Inst Instance=new A195769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195770
{
public static readonly long[] Value={ 3L,5L,6L,7L,7L,9L,9L,10L,11L,11L,12L,13L,13L,14L,14L,15L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,32L,33L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195770Inst : IEnumerable<long>
{
public static readonly long[] Value=A195770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195770.Bytes);
public long this[int i]=>Value[i];

public static A195770Inst Instance=new A195770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195771
{
public static readonly long[] Value={ 1L,3L,6L,9L,4L,3L,8L,4L,0L,6L,0L,0L,4L,5L,6L,5L,8L,2L,7L,7L,7L,6L,1L,9L,6L,1L,3L,9L,4L,2L,2L,1L,2L,8L,0L,3L,1L,8L,5L,8L,5L,4L,6L,6L,1L,8L,2L,8L,5L,3L,2L,4L,5L,2L,4L,2L,3L,0L,2L,2L,1L,0L,5L,2L,6L,9L,8L,2L,9L,8L,8L,2L,8L,5L,1L,4L,2L,5L,2L,6L,4L,8L,9L,3L,8L,1L,7L,2L,4L,8L,2L,5L,8L,0L,6L,5L,8L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195771Inst : IEnumerable<long>
{
public static readonly long[] Value=A195771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195771.Bytes);
public long this[int i]=>Value[i];

public static A195771Inst Instance=new A195771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195772
{
public static readonly long[] Value={ 2L,0L,1L,3L,5L,7L,9L,2L,0L,7L,9L,0L,3L,3L,0L,7L,9L,1L,4L,5L,5L,1L,2L,5L,5L,5L,2L,2L,1L,7L,6L,2L,3L,4L,1L,0L,2L,4L,0L,0L,3L,8L,0L,8L,1L,4L,0L,2L,2L,2L,8L,3L,8L,6L,2L,5L,7L,2L,5L,1L,2L,4L,3L,4L,5L,5L,6L,0L,9L,3L,7L,4L,6L,2L,8L,8L,5L,1L,8L,5L,0L,3L,7L,5L,8L,4L,4L,9L,3L,0L,0L,9L,0L,3L,9L,9L,9L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195772Inst : IEnumerable<long>
{
public static readonly long[] Value=A195772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195772.Bytes);
public long this[int i]=>Value[i];

public static A195772Inst Instance=new A195772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195773
{
public static readonly long[] Value={ 1L,4L,0L,5L,6L,4L,7L,6L,4L,9L,3L,8L,0L,2L,6L,9L,7L,8L,0L,9L,5L,2L,1L,9L,3L,4L,0L,1L,9L,9L,5L,8L,0L,7L,9L,8L,8L,1L,0L,0L,1L,9L,8L,0L,3L,9L,2L,2L,2L,5L,2L,5L,0L,9L,1L,4L,6L,9L,4L,3L,7L,8L,6L,6L,1L,4L,2L,7L,6L,2L,5L,4L,0L,9L,6L,3L,2L,9L,9L,3L,5L,7L,8L,3L,9L,1L,3L,0L,2L,7L,4L,7L,7L,2L,3L,5L,8L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195773Inst : IEnumerable<long>
{
public static readonly long[] Value=A195773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195773.Bytes);
public long this[int i]=>Value[i];

public static A195773Inst Instance=new A195773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195774
{
public static readonly long[] Value={ 1L,6L,5L,1L,4L,8L,6L,7L,7L,4L,1L,4L,6L,2L,6L,8L,3L,8L,2L,7L,9L,1L,2L,8L,2L,8L,9L,6L,4L,3L,9L,4L,3L,4L,5L,3L,9L,9L,8L,3L,8L,6L,6L,6L,0L,4L,6L,5L,0L,2L,7L,8L,1L,9L,0L,1L,8L,0L,3L,4L,4L,3L,0L,0L,1L,1L,1L,4L,5L,6L,6L,2L,1L,7L,9L,8L,0L,5L,1L,4L,1L,4L,7L,4L,8L,8L,7L,1L,3L,7L,8L,9L,8L,7L,0L,0L,1L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195774Inst : IEnumerable<long>
{
public static readonly long[] Value=A195774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195774.Bytes);
public long this[int i]=>Value[i];

public static A195774Inst Instance=new A195774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195775
{
public static readonly long[] Value={ 1L,4L,0L,3L,3L,4L,8L,2L,4L,7L,5L,7L,5L,2L,0L,7L,2L,8L,8L,6L,7L,8L,0L,4L,7L,0L,8L,5L,5L,9L,6L,1L,1L,3L,2L,2L,1L,1L,8L,3L,6L,2L,7L,5L,3L,7L,3L,7L,1L,3L,1L,4L,5L,9L,0L,0L,2L,1L,6L,8L,4L,9L,9L,2L,4L,2L,0L,6L,1L,0L,5L,6L,5L,5L,3L,4L,4L,3L,8L,5L,6L,7L,5L,1L,1L,9L,1L,9L,8L,6L,1L,2L,1L,8L,3L,6L,6L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195775Inst : IEnumerable<long>
{
public static readonly long[] Value=A195775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195775.Bytes);
public long this[int i]=>Value[i];

public static A195775Inst Instance=new A195775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195776
{
public static readonly long[] Value={ 1L,6L,7L,4L,4L,8L,0L,7L,9L,2L,1L,9L,6L,8L,9L,3L,3L,0L,5L,5L,3L,2L,7L,4L,6L,0L,6L,0L,4L,3L,6L,3L,8L,2L,2L,0L,9L,1L,4L,9L,5L,7L,1L,6L,2L,3L,1L,6L,2L,3L,8L,3L,2L,0L,4L,6L,5L,7L,8L,7L,3L,0L,3L,7L,3L,3L,2L,9L,7L,6L,3L,7L,6L,0L,8L,6L,6L,5L,9L,3L,1L,8L,0L,2L,0L,9L,7L,5L,5L,1L,4L,5L,2L,6L,9L,2L,3L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195776Inst : IEnumerable<long>
{
public static readonly long[] Value=A195776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195776.Bytes);
public long this[int i]=>Value[i];

public static A195776Inst Instance=new A195776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195777
{
public static readonly long[] Value={ 1L,4L,2L,8L,8L,9L,9L,2L,7L,2L,1L,9L,0L,7L,3L,2L,6L,9L,6L,4L,1L,8L,4L,7L,0L,0L,7L,4L,5L,3L,7L,1L,9L,8L,3L,5L,9L,0L,9L,0L,8L,0L,2L,9L,4L,0L,9L,5L,9L,0L,8L,8L,8L,3L,8L,1L,0L,9L,3L,4L,2L,2L,6L,6L,7L,9L,0L,4L,6L,6L,5L,7L,6L,3L,8L,3L,1L,7L,3L,3L,3L,8L,3L,6L,9L,8L,2L,5L,5L,5L,1L,0L,3L,6L,8L,1L,2L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195777Inst : IEnumerable<long>
{
public static readonly long[] Value=A195777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195777.Bytes);
public long this[int i]=>Value[i];

public static A195777Inst Instance=new A195777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195778
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195778Inst : IEnumerable<long>
{
public static readonly long[] Value=A195778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195778.Bytes);
public long this[int i]=>Value[i];

public static A195778Inst Instance=new A195778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195779
{
public static readonly long[] Value={ 1L,4L,2L,7L,4L,4L,8L,7L,5L,7L,8L,8L,9L,5L,3L,1L,2L,6L,1L,6L,3L,6L,2L,4L,7L,4L,1L,1L,4L,8L,3L,1L,3L,3L,1L,1L,5L,9L,9L,9L,6L,4L,5L,4L,8L,6L,5L,5L,4L,0L,8L,8L,5L,8L,2L,0L,4L,0L,5L,8L,3L,4L,3L,8L,0L,8L,8L,9L,8L,0L,1L,0L,7L,2L,1L,6L,1L,4L,8L,2L,0L,6L,0L,9L,9L,7L,8L,0L,6L,7L,7L,9L,0L,9L,1L,5L,5L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195779Inst : IEnumerable<long>
{
public static readonly long[] Value=A195779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195779.Bytes);
public long this[int i]=>Value[i];

public static A195779Inst Instance=new A195779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195780
{
public static readonly long[] Value={ 1L,4L,3L,3L,4L,7L,5L,6L,8L,9L,0L,5L,3L,6L,5L,3L,5L,7L,5L,9L,5L,0L,7L,4L,2L,8L,0L,1L,5L,6L,6L,1L,8L,3L,2L,6L,0L,9L,8L,9L,3L,9L,2L,1L,3L,1L,3L,3L,4L,6L,4L,3L,2L,8L,4L,4L,6L,8L,8L,8L,8L,5L,8L,0L,6L,4L,9L,2L,8L,0L,9L,5L,9L,2L,6L,9L,5L,6L,2L,9L,3L,2L,1L,4L,2L,3L,6L,7L,3L,4L,7L,6L,1L,9L,0L,2L,7L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195780Inst : IEnumerable<long>
{
public static readonly long[] Value=A195780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195780.Bytes);
public long this[int i]=>Value[i];

public static A195780Inst Instance=new A195780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195781
{
public static readonly long[] Value={ 1L,4L,4L,6L,4L,4L,1L,3L,3L,2L,2L,4L,8L,1L,3L,5L,1L,8L,4L,1L,9L,9L,9L,6L,6L,8L,4L,2L,4L,7L,5L,8L,8L,0L,4L,1L,6L,5L,2L,5L,4L,1L,4L,5L,0L,7L,9L,1L,7L,7L,4L,8L,8L,2L,0L,5L,7L,2L,3L,5L,8L,1L,7L,7L,0L,3L,8L,1L,8L,5L,9L,3L,5L,7L,1L,5L,5L,3L,7L,7L,4L,0L,6L,9L,0L,3L,0L,6L,8L,1L,8L,3L,5L,7L,7L,0L,5L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195781Inst : IEnumerable<long>
{
public static readonly long[] Value=A195781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195781.Bytes);
public long this[int i]=>Value[i];

public static A195781Inst Instance=new A195781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195782
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,4L,9L,9L,4L,5L,4L,6L,7L,6L,1L,4L,3L,5L,0L,3L,1L,3L,5L,4L,8L,4L,9L,1L,6L,3L,8L,7L,1L,0L,2L,5L,5L,7L,3L,1L,7L,0L,1L,9L,1L,7L,6L,9L,8L,0L,4L,0L,8L,9L,9L,1L,5L,1L,1L,4L,1L,1L,9L,1L,1L,5L,7L,2L,2L,2L,6L,7L,4L,2L,7L,5L,6L,6L,7L,5L,8L,6L,2L,3L,7L,1L,0L,5L,9L,4L,3L,1L,3L,3L,5L,3L,3L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195782Inst : IEnumerable<long>
{
public static readonly long[] Value=A195782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195782.Bytes);
public long this[int i]=>Value[i];

public static A195782Inst Instance=new A195782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195783
{
public static readonly long[] Value={ 1L,4L,4L,5L,4L,6L,8L,4L,9L,5L,6L,2L,6L,8L,3L,1L,2L,2L,2L,3L,5L,6L,7L,5L,4L,7L,0L,5L,2L,8L,2L,6L,6L,6L,7L,2L,4L,0L,5L,0L,4L,3L,6L,9L,7L,2L,8L,4L,8L,8L,8L,0L,5L,3L,5L,2L,5L,3L,5L,0L,8L,2L,6L,5L,1L,6L,7L,4L,1L,4L,7L,6L,3L,8L,2L,9L,2L,6L,0L,5L,2L,9L,9L,2L,9L,6L,5L,5L,2L,2L,1L,8L,7L,8L,2L,0L,2L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195783Inst : IEnumerable<long>
{
public static readonly long[] Value=A195783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195783.Bytes);
public long this[int i]=>Value[i];

public static A195783Inst Instance=new A195783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195784
{
public static readonly long[] Value={ 1L,2L,5L,3L,2L,7L,8L,3L,1L,1L,6L,8L,0L,6L,5L,3L,9L,6L,8L,7L,4L,5L,6L,6L,9L,8L,6L,3L,5L,7L,0L,8L,4L,7L,1L,8L,0L,4L,8L,1L,4L,7L,7L,2L,6L,8L,3L,8L,6L,7L,2L,3L,7L,5L,2L,3L,3L,9L,6L,4L,0L,3L,0L,9L,8L,6L,4L,9L,3L,4L,3L,9L,3L,1L,3L,8L,4L,3L,9L,6L,9L,3L,8L,4L,3L,6L,2L,1L,9L,0L,7L,9L,2L,8L,5L,5L,9L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195784Inst : IEnumerable<long>
{
public static readonly long[] Value=A195784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195784.Bytes);
public long this[int i]=>Value[i];

public static A195784Inst Instance=new A195784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195785
{
public static readonly long[] Value={ 1L,4L,6L,0L,1L,3L,9L,1L,0L,5L,6L,2L,1L,0L,0L,0L,9L,7L,2L,6L,7L,2L,1L,8L,1L,8L,1L,9L,4L,2L,9L,6L,8L,9L,3L,3L,6L,1L,2L,3L,2L,9L,8L,6L,0L,4L,6L,8L,4L,4L,8L,8L,8L,7L,8L,3L,6L,4L,6L,5L,7L,8L,5L,3L,0L,4L,6L,2L,6L,2L,9L,9L,7L,4L,0L,2L,6L,0L,5L,7L,8L,5L,5L,4L,8L,7L,8L,8L,5L,2L,3L,2L,3L,7L,5L,7L,0L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195785Inst : IEnumerable<long>
{
public static readonly long[] Value=A195785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195785.Bytes);
public long this[int i]=>Value[i];

public static A195785Inst Instance=new A195785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195786
{
public static readonly long[] Value={ 1L,1L,0L,6L,5L,7L,2L,2L,1L,1L,7L,3L,8L,9L,5L,6L,4L,6L,5L,5L,9L,1L,3L,9L,8L,7L,2L,2L,1L,0L,0L,6L,2L,1L,0L,5L,9L,7L,5L,2L,8L,6L,0L,9L,5L,0L,0L,3L,0L,6L,4L,0L,3L,2L,1L,2L,2L,8L,1L,4L,4L,4L,3L,1L,0L,7L,6L,4L,5L,2L,0L,5L,7L,4L,0L,4L,9L,8L,7L,1L,3L,7L,6L,5L,2L,2L,8L,8L,8L,9L,4L,3L,3L,4L,8L,7L,9L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195786Inst : IEnumerable<long>
{
public static readonly long[] Value=A195786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195786.Bytes);
public long this[int i]=>Value[i];

public static A195786Inst Instance=new A195786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195787
{
public static readonly long[] Value={ 1L,4L,5L,9L,4L,5L,5L,3L,1L,2L,4L,5L,3L,9L,3L,2L,7L,2L,6L,9L,0L,9L,5L,9L,3L,3L,1L,9L,6L,2L,6L,6L,4L,1L,3L,9L,0L,7L,9L,3L,0L,1L,1L,8L,2L,8L,0L,9L,5L,4L,2L,7L,3L,8L,1L,4L,1L,7L,8L,9L,8L,9L,8L,2L,9L,2L,3L,6L,3L,7L,7L,9L,9L,3L,3L,3L,5L,3L,4L,2L,7L,7L,5L,9L,0L,9L,6L,6L,8L,1L,5L,6L,3L,8L,9L,4L,7L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195787Inst : IEnumerable<long>
{
public static readonly long[] Value=A195787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195787.Bytes);
public long this[int i]=>Value[i];

public static A195787Inst Instance=new A195787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195788
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,0L,1L,4L,3L,4L,0L,9L,6L,3L,8L,9L,2L,3L,2L,1L,7L,2L,8L,3L,7L,2L,0L,1L,3L,1L,1L,0L,0L,5L,1L,3L,0L,5L,5L,7L,2L,8L,7L,1L,5L,9L,2L,1L,2L,5L,5L,2L,9L,0L,6L,9L,5L,7L,3L,3L,1L,3L,2L,3L,0L,2L,7L,0L,4L,0L,3L,8L,0L,9L,5L,7L,0L,2L,2L,1L,7L,2L,3L,0L,5L,0L,5L,9L,7L,0L,3L,2L,1L,1L,1L,5L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195788Inst : IEnumerable<long>
{
public static readonly long[] Value=A195788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195788.Bytes);
public long this[int i]=>Value[i];

public static A195788Inst Instance=new A195788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195789
{
public static readonly long[] Value={ 1L,4L,7L,1L,1L,2L,7L,6L,7L,4L,3L,0L,3L,7L,3L,4L,5L,9L,1L,8L,5L,2L,8L,7L,5L,5L,7L,1L,7L,6L,1L,7L,3L,0L,8L,5L,1L,8L,5L,5L,3L,0L,6L,3L,7L,7L,1L,8L,3L,2L,3L,8L,2L,6L,2L,4L,7L,1L,9L,6L,3L,5L,1L,9L,3L,4L,3L,8L,8L,0L,4L,5L,5L,6L,9L,5L,5L,5L,3L,8L,4L,4L,8L,9L,3L,4L,0L,4L,7L,8L,8L,2L,3L,6L,7L,7L,2L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195789Inst : IEnumerable<long>
{
public static readonly long[] Value=A195789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195789.Bytes);
public long this[int i]=>Value[i];

public static A195789Inst Instance=new A195789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195790
{
public static readonly long[] Value={ 0L,9L,9L,6L,6L,8L,6L,5L,2L,4L,9L,1L,1L,6L,2L,0L,2L,7L,3L,7L,8L,4L,4L,6L,1L,1L,9L,8L,7L,8L,0L,2L,0L,5L,9L,0L,2L,4L,3L,2L,7L,8L,3L,2L,2L,5L,0L,4L,3L,1L,4L,6L,4L,8L,0L,1L,5L,5L,0L,8L,7L,7L,6L,8L,1L,0L,0L,2L,7L,7L,4L,7L,4L,4L,7L,5L,5L,0L,6L,5L,4L,4L,2L,0L,6L,1L,2L,6L,2L,4L,4L,3L,4L,2L,8L,6L,3L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195790Inst : IEnumerable<long>
{
public static readonly long[] Value=A195790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195790.Bytes);
public long this[int i]=>Value[i];

public static A195790Inst Instance=new A195790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195791
{
public static readonly long[] Value={ 1L,4L,7L,0L,6L,2L,8L,9L,0L,5L,6L,3L,3L,3L,3L,6L,8L,2L,2L,8L,8L,5L,7L,9L,8L,5L,1L,2L,1L,8L,7L,0L,5L,8L,1L,2L,3L,5L,2L,9L,9L,0L,8L,7L,2L,7L,4L,5L,7L,9L,2L,3L,3L,6L,9L,0L,9L,6L,4L,4L,8L,4L,4L,1L,1L,1L,7L,5L,0L,5L,5L,2L,9L,4L,9L,2L,2L,4L,1L,9L,4L,7L,6L,6L,0L,0L,7L,9L,5L,4L,8L,3L,1L,1L,5L,5L,4L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195791Inst : IEnumerable<long>
{
public static readonly long[] Value=A195791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195791.Bytes);
public long this[int i]=>Value[i];

public static A195791Inst Instance=new A195791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195792
{
public static readonly long[] Value={ 1L,0L,0L,1L,6L,7L,4L,2L,1L,1L,6L,1L,5L,5L,9L,7L,9L,6L,3L,4L,5L,5L,2L,3L,1L,7L,9L,4L,5L,2L,6L,9L,3L,3L,1L,8L,5L,6L,8L,6L,7L,5L,9L,7L,2L,2L,2L,9L,6L,2L,9L,5L,4L,1L,3L,9L,1L,0L,2L,3L,8L,5L,5L,0L,3L,6L,4L,0L,2L,6L,7L,3L,6L,5L,0L,8L,6L,2L,5L,5L,1L,6L,5L,3L,9L,3L,7L,8L,6L,4L,3L,5L,9L,5L,0L,4L,4L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195792Inst : IEnumerable<long>
{
public static readonly long[] Value=A195792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195792.Bytes);
public long this[int i]=>Value[i];

public static A195792Inst Instance=new A195792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195793
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,9L,5L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,5L,6L,4L,6L,5L,5L,0L,2L,4L,9L,7L,2L,8L,8L,4L,7L,7L,5L,4L,3L,1L,9L,1L,8L,1L,7L,5L,8L,7L,8L,0L,2L,9L,1L,0L,0L,8L,5L,2L,5L,5L,1L,6L,6L,1L,2L,3L,3L,3L,6L,4L,1L,9L,1L,5L,9L,9L,0L,9L,2L,8L,7L,8L,3L,7L,9L,3L,9L,6L,4L,7L,8L,1L,1L,6L,7L,9L,0L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195793Inst : IEnumerable<long>
{
public static readonly long[] Value=A195793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195793.Bytes);
public long this[int i]=>Value[i];

public static A195793Inst Instance=new A195793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195794
{
public static readonly long[] Value={ 1L,2L,3L,8L,4L,5L,8L,21L,6L,16L,7L,15L,40L,8L,15L,9L,24L,65L,10L,16L,42L,11L,35L,96L,12L,32L,13L,48L,133L,14L,30L,80L,15L,24L,40L,63L,176L,16L,21L,30L,55L,17L,80L,225L,18L,48L,130L,19L,99L,280L,20L,32L,84L,21L,45L,56L,120L,341L,22L,70L,192L,23L,143L,408L,24L,35L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195794Inst : IEnumerable<long>
{
public static readonly long[] Value=A195794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195794.Bytes);
public long this[int i]=>Value[i];

public static A195794Inst Instance=new A195794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195795
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,7L,19L,6L,14L,7L,13L,37L,8L,13L,9L,21L,61L,10L,14L,38L,11L,31L,91L,12L,28L,13L,43L,127L,14L,26L,74L,15L,21L,35L,57L,169L,16L,19L,26L,49L,17L,73L,217L,18L,42L,122L,19L,91L,271L,20L,28L,76L,21L,39L,49L,111L,331L,22L,62L,182L,23L,133L,397L,24L,31L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195795Inst : IEnumerable<long>
{
public static readonly long[] Value=A195795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195795.Bytes);
public long this[int i]=>Value[i];

public static A195795Inst Instance=new A195795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195796
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,7L,8L,9L,11L,11L,13L,13L,15L,16L,16L,17L,17L,19L,19L,21L,23L,23L,24L,24L,25L,25L,27L,29L,29L,31L,31L,32L,32L,33L,35L,35L,37L,39L,40L,40L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,55L,56L,56L,56L,56L,57L,63L,64L,64L,65L,69L,72L,75L,77L,80L,80L,85L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195796Inst : IEnumerable<long>
{
public static readonly long[] Value=A195796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195796.Bytes);
public long this[int i]=>Value[i];

public static A195796Inst Instance=new A195796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195797
{
public static readonly long[] Value={ 1L,1L,4L,125L,5052L,5828215L,479534519840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195797Inst : IEnumerable<long>
{
public static readonly long[] Value=A195797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195797.Bytes);
public long this[int i]=>Value[i];

public static A195797Inst Instance=new A195797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195798
{
public static readonly long[] Value={ 1L,1L,2L,8L,16L,64L,1184L,5300L,130324L,14748808L,421963232L,54990266540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195798Inst : IEnumerable<long>
{
public static readonly long[] Value=A195798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195798.Bytes);
public long this[int i]=>Value[i];

public static A195798Inst Instance=new A195798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195799
{
public static readonly long[] Value={ 1L,1L,3L,27L,105L,1695L,284427L,11606931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195799Inst : IEnumerable<long>
{
public static readonly long[] Value=A195799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195799.Bytes);
public long this[int i]=>Value[i];

public static A195799Inst Instance=new A195799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195800
{
public static readonly long[] Value={ 1L,1L,4L,64L,496L,24928L,17528896L,3850960912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195800Inst : IEnumerable<long>
{
public static readonly long[] Value=A195800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195800.Bytes);
public long this[int i]=>Value[i];

public static A195800Inst Instance=new A195800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195801
{
public static readonly long[] Value={ 1L,1L,5L,125L,1759L,213319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195801Inst : IEnumerable<long>
{
public static readonly long[] Value=A195801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195801.Bytes);
public long this[int i]=>Value[i];

public static A195801Inst Instance=new A195801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195802
{
public static readonly long[] Value={ 1L,1L,6L,216L,5052L,1274808L,6711447312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195802Inst : IEnumerable<long>
{
public static readonly long[] Value=A195802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195802.Bytes);
public long this[int i]=>Value[i];

public static A195802Inst Instance=new A195802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195803
{
public static readonly long[] Value={ 1L,1L,7L,343L,12469L,5828215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195803Inst : IEnumerable<long>
{
public static readonly long[] Value=A195803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195803.Bytes);
public long this[int i]=>Value[i];

public static A195803Inst Instance=new A195803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195804
{
public static readonly long[] Value={ 1L,1L,8L,512L,27412L,21779968L,479534519840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195804Inst : IEnumerable<long>
{
public static readonly long[] Value=A195804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195804.Bytes);
public long this[int i]=>Value[i];

public static A195804Inst Instance=new A195804Inst();

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