using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019865
{
public static readonly long[] Value={ 8L,2L,9L,0L,3L,7L,5L,7L,2L,5L,5L,5L,0L,4L,1L,6L,9L,2L,0L,0L,6L,3L,3L,6L,8L,4L,1L,5L,0L,1L,6L,4L,2L,0L,2L,6L,3L,2L,9L,0L,7L,0L,2L,1L,2L,1L,6L,5L,6L,2L,5L,3L,4L,4L,8L,9L,4L,5L,7L,9L,6L,6L,8L,3L,2L,3L,9L,7L,1L,9L,0L,0L,0L,3L,2L,1L,2L,5L,7L,7L,7L,0L,7L,8L,9L,4L,3L,6L,5L,6L,5L,6L,4L,1L,4L,9L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019865Inst : IEnumerable<long>
{
public static readonly long[] Value=A019865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019865.Bytes);
public long this[int i]=>Value[i];

public static A019865Inst Instance=new A019865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019864
{
public static readonly long[] Value={ 8L,1L,9L,1L,5L,2L,0L,4L,4L,2L,8L,8L,9L,9L,1L,7L,8L,9L,6L,8L,4L,4L,8L,8L,3L,8L,5L,9L,1L,6L,8L,4L,3L,4L,3L,1L,8L,9L,0L,0L,1L,1L,4L,6L,9L,0L,2L,6L,1L,6L,2L,0L,0L,8L,2L,5L,7L,5L,5L,5L,0L,4L,1L,2L,5L,4L,1L,8L,8L,5L,5L,8L,4L,5L,4L,6L,9L,3L,0L,8L,0L,7L,5L,2L,9L,6L,2L,4L,5L,2L,8L,0L,8L,4L,6L,1L,3L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019864Inst : IEnumerable<long>
{
public static readonly long[] Value=A019864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019864.Bytes);
public long this[int i]=>Value[i];

public static A019864Inst Instance=new A019864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019863
{
public static readonly long[] Value={ 8L,0L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019863Inst : IEnumerable<long>
{
public static readonly long[] Value=A019863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019863.Bytes);
public long this[int i]=>Value[i];

public static A019863Inst Instance=new A019863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019862
{
public static readonly long[] Value={ 7L,9L,8L,6L,3L,5L,5L,1L,0L,0L,4L,7L,2L,9L,2L,8L,4L,6L,2L,8L,4L,0L,0L,0L,8L,0L,4L,0L,6L,8L,9L,3L,6L,2L,4L,4L,2L,6L,6L,2L,6L,7L,6L,3L,4L,4L,9L,8L,7L,7L,1L,5L,8L,0L,3L,3L,5L,6L,5L,2L,8L,3L,7L,8L,0L,5L,0L,0L,2L,4L,1L,1L,3L,3L,4L,5L,0L,3L,0L,1L,9L,4L,7L,9L,0L,9L,8L,6L,4L,5L,7L,0L,5L,6L,7L,0L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019862Inst : IEnumerable<long>
{
public static readonly long[] Value=A019862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019862.Bytes);
public long this[int i]=>Value[i];

public static A019862Inst Instance=new A019862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019861
{
public static readonly long[] Value={ 7L,8L,8L,0L,1L,0L,7L,5L,3L,6L,0L,6L,7L,2L,1L,9L,5L,6L,6L,9L,3L,9L,7L,7L,7L,8L,7L,8L,3L,5L,8L,5L,1L,6L,6L,6L,6L,4L,1L,6L,9L,6L,7L,8L,8L,4L,7L,5L,4L,2L,8L,7L,3L,8L,5L,4L,1L,3L,3L,4L,3L,0L,9L,3L,9L,1L,4L,2L,9L,7L,3L,7L,7L,0L,5L,7L,6L,8L,1L,3L,2L,5L,6L,1L,4L,4L,4L,4L,1L,9L,1L,7L,5L,2L,9L,7L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019861Inst : IEnumerable<long>
{
public static readonly long[] Value=A019861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019861.Bytes);
public long this[int i]=>Value[i];

public static A019861Inst Instance=new A019861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019860
{
public static readonly long[] Value={ 7L,7L,7L,1L,4L,5L,9L,6L,1L,4L,5L,6L,9L,7L,0L,8L,7L,9L,9L,7L,9L,9L,3L,7L,7L,4L,3L,6L,7L,2L,4L,0L,3L,8L,4L,9L,0L,9L,2L,0L,6L,5L,3L,7L,6L,4L,5L,1L,8L,0L,6L,0L,1L,6L,7L,9L,7L,0L,0L,8L,3L,3L,5L,0L,8L,1L,3L,9L,0L,7L,0L,4L,9L,3L,0L,3L,9L,8L,7L,3L,7L,0L,3L,1L,5L,4L,2L,1L,1L,0L,3L,9L,7L,5L,3L,7L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019860Inst : IEnumerable<long>
{
public static readonly long[] Value=A019860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019860.Bytes);
public long this[int i]=>Value[i];

public static A019860Inst Instance=new A019860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019859
{
public static readonly long[] Value={ 7L,6L,6L,0L,4L,4L,4L,4L,3L,1L,1L,8L,9L,7L,8L,0L,3L,5L,2L,0L,2L,3L,9L,2L,6L,5L,0L,5L,5L,5L,4L,1L,6L,6L,7L,3L,9L,3L,5L,8L,3L,2L,4L,5L,7L,0L,8L,0L,3L,9L,5L,2L,4L,5L,8L,5L,4L,0L,4L,5L,2L,8L,4L,6L,4L,2L,1L,5L,5L,3L,8L,8L,8L,5L,6L,8L,7L,4L,7L,2L,3L,5L,2L,8L,2L,2L,9L,2L,7L,6L,6L,8L,0L,5L,4L,8L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019859Inst : IEnumerable<long>
{
public static readonly long[] Value=A019859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019859.Bytes);
public long this[int i]=>Value[i];

public static A019859Inst Instance=new A019859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019858
{
public static readonly long[] Value={ 7L,5L,4L,7L,0L,9L,5L,8L,0L,2L,2L,2L,7L,7L,1L,9L,9L,7L,9L,4L,2L,9L,8L,4L,2L,1L,9L,5L,6L,1L,0L,1L,5L,5L,5L,8L,0L,4L,8L,5L,3L,7L,9L,7L,4L,6L,4L,4L,8L,9L,7L,4L,3L,6L,0L,4L,1L,3L,2L,2L,6L,8L,8L,3L,4L,9L,6L,1L,8L,4L,0L,1L,7L,2L,8L,5L,9L,5L,3L,1L,6L,7L,5L,3L,0L,6L,4L,3L,8L,3L,0L,4L,6L,9L,2L,4L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019858Inst : IEnumerable<long>
{
public static readonly long[] Value=A019858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019858.Bytes);
public long this[int i]=>Value[i];

public static A019858Inst Instance=new A019858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019857
{
public static readonly long[] Value={ 7L,4L,3L,1L,4L,4L,8L,2L,5L,4L,7L,7L,3L,9L,4L,2L,3L,5L,0L,1L,4L,6L,9L,7L,0L,4L,8L,9L,7L,4L,2L,5L,6L,9L,7L,7L,1L,8L,9L,1L,1L,3L,8L,7L,3L,4L,9L,8L,0L,2L,6L,3L,8L,6L,0L,4L,0L,1L,2L,3L,6L,7L,0L,5L,4L,7L,7L,7L,0L,3L,4L,4L,4L,2L,1L,1L,1L,9L,1L,2L,5L,4L,1L,4L,1L,6L,4L,0L,5L,4L,2L,4L,8L,0L,8L,3L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019857Inst : IEnumerable<long>
{
public static readonly long[] Value=A019857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019857.Bytes);
public long this[int i]=>Value[i];

public static A019857Inst Instance=new A019857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019856
{
public static readonly long[] Value={ 7L,3L,1L,3L,5L,3L,7L,0L,1L,6L,1L,9L,1L,7L,0L,4L,8L,3L,2L,8L,7L,5L,4L,3L,6L,0L,8L,2L,7L,5L,6L,2L,2L,4L,0L,3L,3L,7L,8L,3L,9L,6L,5L,4L,4L,7L,6L,2L,5L,3L,7L,8L,4L,4L,2L,2L,1L,1L,6L,8L,7L,9L,4L,4L,4L,6L,6L,5L,9L,3L,1L,3L,4L,7L,3L,2L,6L,9L,7L,1L,8L,4L,9L,0L,7L,6L,2L,1L,0L,8L,9L,2L,0L,6L,4L,4L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019856Inst : IEnumerable<long>
{
public static readonly long[] Value=A019856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019856.Bytes);
public long this[int i]=>Value[i];

public static A019856Inst Instance=new A019856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019855
{
public static readonly long[] Value={ 7L,1L,9L,3L,3L,9L,8L,0L,0L,3L,3L,8L,6L,5L,1L,1L,3L,9L,3L,5L,6L,0L,5L,4L,6L,7L,4L,4L,5L,6L,7L,1L,1L,9L,0L,8L,2L,3L,0L,6L,8L,4L,5L,5L,8L,9L,4L,1L,9L,6L,5L,7L,7L,1L,2L,8L,0L,2L,1L,4L,0L,3L,4L,3L,1L,5L,4L,8L,0L,6L,9L,1L,0L,7L,1L,5L,4L,3L,9L,4L,6L,0L,2L,0L,0L,4L,3L,9L,5L,5L,7L,7L,8L,0L,4L,2L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019855Inst : IEnumerable<long>
{
public static readonly long[] Value=A019855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019855.Bytes);
public long this[int i]=>Value[i];

public static A019855Inst Instance=new A019855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019854
{
public static readonly BigInteger[] Value={ 1L,22L,333L,4334L,52325L,606606L,6874477L,76908238L,854115189L,9445967630L,104219612861L,1148348383182L,12643672205893L,139152654913294L,1531118871452685L,16844976107996366L,185310900907951637L,2038517655246870798L,BigInteger.Parse("22424284493969261149"),BigInteger.Parse("246670690224670294990") };
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
public class A019854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019854Inst Instance=new A019854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019837
{
public static readonly long[] Value={ 4L,6L,9L,4L,7L,1L,5L,6L,2L,7L,8L,5L,8L,9L,0L,7L,7L,5L,9L,5L,9L,4L,6L,2L,2L,8L,8L,2L,2L,7L,8L,4L,3L,2L,9L,5L,7L,2L,3L,2L,1L,8L,7L,5L,6L,7L,1L,1L,1L,9L,6L,8L,0L,8L,3L,3L,6L,1L,0L,8L,2L,9L,9L,3L,9L,0L,8L,9L,9L,7L,9L,2L,1L,7L,4L,1L,5L,9L,3L,2L,2L,9L,9L,4L,1L,4L,7L,7L,2L,7L,9L,8L,0L,6L,9L,6L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019837Inst : IEnumerable<long>
{
public static readonly long[] Value=A019837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019837.Bytes);
public long this[int i]=>Value[i];

public static A019837Inst Instance=new A019837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019836
{
public static readonly long[] Value={ 4L,5L,3L,9L,9L,0L,4L,9L,9L,7L,3L,9L,5L,4L,6L,7L,9L,1L,5L,6L,0L,4L,0L,8L,3L,6L,6L,3L,5L,7L,8L,7L,1L,1L,9L,8L,9L,8L,3L,0L,4L,7L,7L,0L,3L,0L,4L,9L,0L,2L,1L,5L,5L,6L,9L,8L,5L,3L,1L,6L,0L,0L,5L,8L,2L,2L,0L,2L,6L,7L,8L,4L,1L,3L,1L,8L,5L,2L,4L,2L,8L,7L,5L,4L,4L,7L,3L,4L,3L,9L,2L,2L,1L,9L,4L,6L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019836Inst : IEnumerable<long>
{
public static readonly long[] Value=A019836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019836.Bytes);
public long this[int i]=>Value[i];

public static A019836Inst Instance=new A019836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019835
{
public static readonly long[] Value={ 4L,3L,8L,3L,7L,1L,1L,4L,6L,7L,8L,9L,0L,7L,7L,4L,1L,7L,4L,5L,2L,7L,3L,4L,5L,4L,0L,6L,5L,8L,2L,6L,5L,7L,3L,9L,0L,6L,2L,7L,5L,5L,7L,1L,9L,9L,8L,8L,5L,5L,2L,1L,1L,4L,4L,3L,1L,1L,2L,6L,2L,5L,6L,6L,5L,2L,8L,1L,6L,3L,3L,4L,0L,1L,3L,4L,3L,9L,0L,0L,3L,9L,0L,7L,7L,8L,0L,4L,0L,6L,3L,6L,4L,7L,4L,9L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019835Inst : IEnumerable<long>
{
public static readonly long[] Value=A019835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019835.Bytes);
public long this[int i]=>Value[i];

public static A019835Inst Instance=new A019835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019834
{
public static readonly long[] Value={ 4L,2L,2L,6L,1L,8L,2L,6L,1L,7L,4L,0L,6L,9L,9L,4L,3L,6L,1L,8L,6L,9L,7L,8L,4L,8L,9L,6L,4L,7L,7L,3L,0L,1L,8L,1L,5L,6L,3L,1L,2L,9L,3L,0L,1L,1L,9L,4L,8L,6L,4L,6L,2L,3L,4L,4L,4L,4L,1L,5L,1L,5L,9L,2L,1L,0L,6L,5L,9L,8L,4L,9L,9L,8L,5L,6L,8L,9L,9L,8L,9L,6L,1L,4L,4L,6L,4L,3L,7L,3L,6L,1L,9L,4L,3L,1L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019834Inst : IEnumerable<long>
{
public static readonly long[] Value=A019834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019834.Bytes);
public long this[int i]=>Value[i];

public static A019834Inst Instance=new A019834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019833
{
public static readonly long[] Value={ 4L,0L,6L,7L,3L,6L,6L,4L,3L,0L,7L,5L,8L,0L,0L,2L,0L,7L,7L,5L,3L,9L,8L,5L,9L,9L,0L,3L,4L,1L,4L,9L,7L,6L,1L,2L,9L,2L,3L,1L,3L,9L,6L,5L,1L,0L,6L,6L,1L,7L,3L,4L,3L,6L,2L,9L,4L,2L,8L,6L,3L,5L,2L,8L,1L,7L,0L,3L,7L,7L,7L,6L,5L,2L,4L,5L,4L,6L,4L,0L,5L,0L,7L,0L,8L,0L,2L,1L,7L,0L,5L,2L,0L,6L,1L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019833Inst : IEnumerable<long>
{
public static readonly long[] Value=A019833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019833.Bytes);
public long this[int i]=>Value[i];

public static A019833Inst Instance=new A019833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019832
{
public static readonly long[] Value={ 3L,9L,0L,7L,3L,1L,1L,2L,8L,4L,8L,9L,2L,7L,3L,7L,5L,5L,0L,6L,2L,0L,8L,4L,5L,8L,8L,8L,8L,9L,0L,9L,4L,2L,6L,7L,6L,1L,8L,0L,1L,5L,1L,6L,7L,5L,7L,6L,4L,3L,2L,0L,7L,5L,7L,4L,7L,1L,0L,6L,5L,4L,9L,4L,6L,4L,5L,5L,4L,6L,8L,2L,0L,7L,1L,8L,9L,2L,5L,5L,3L,2L,1L,6L,6L,2L,8L,2L,2L,9L,3L,8L,4L,0L,5L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019832Inst : IEnumerable<long>
{
public static readonly long[] Value=A019832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019832.Bytes);
public long this[int i]=>Value[i];

public static A019832Inst Instance=new A019832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019831
{
public static readonly long[] Value={ 3L,7L,4L,6L,0L,6L,5L,9L,3L,4L,1L,5L,9L,1L,2L,0L,3L,5L,4L,1L,4L,9L,6L,3L,7L,7L,4L,5L,0L,1L,1L,9L,5L,1L,3L,1L,0L,0L,0L,1L,5L,8L,9L,2L,2L,2L,5L,3L,6L,7L,6L,1L,7L,4L,1L,0L,3L,4L,4L,0L,3L,7L,1L,0L,3L,3L,3L,5L,8L,6L,1L,4L,3L,6L,6L,0L,8L,5L,2L,1L,8L,9L,5L,8L,6L,3L,5L,7L,3L,6L,2L,2L,2L,4L,8L,5L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019831Inst : IEnumerable<long>
{
public static readonly long[] Value=A019831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019831.Bytes);
public long this[int i]=>Value[i];

public static A019831Inst Instance=new A019831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019830
{
public static readonly long[] Value={ 3L,5L,8L,3L,6L,7L,9L,4L,9L,5L,4L,5L,3L,0L,0L,2L,7L,3L,4L,8L,4L,1L,3L,7L,7L,8L,9L,4L,1L,3L,4L,6L,6L,8L,3L,4L,1L,9L,1L,5L,4L,4L,4L,4L,9L,4L,6L,0L,0L,1L,3L,7L,9L,5L,4L,6L,3L,5L,7L,6L,7L,7L,5L,8L,5L,7L,3L,1L,9L,9L,2L,5L,9L,8L,2L,4L,9L,9L,0L,9L,8L,9L,8L,7L,3L,1L,6L,0L,9L,1L,3L,9L,2L,9L,8L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019830Inst : IEnumerable<long>
{
public static readonly long[] Value=A019830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019830.Bytes);
public long this[int i]=>Value[i];

public static A019830Inst Instance=new A019830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019829
{
public static readonly long[] Value={ 3L,4L,2L,0L,2L,0L,1L,4L,3L,3L,2L,5L,6L,6L,8L,7L,3L,3L,0L,4L,4L,0L,9L,9L,6L,1L,4L,6L,8L,2L,2L,5L,9L,5L,8L,0L,7L,6L,3L,0L,8L,3L,3L,6L,7L,5L,1L,4L,1L,6L,0L,6L,2L,8L,4L,6L,5L,0L,4L,8L,4L,9L,7L,6L,8L,4L,7L,1L,4L,7L,6L,3L,7L,0L,2L,0L,7L,7L,5L,9L,9L,5L,6L,4L,1L,9L,0L,1L,8L,2L,3L,3L,8L,5L,2L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019829Inst : IEnumerable<long>
{
public static readonly long[] Value=A019829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019829.Bytes);
public long this[int i]=>Value[i];

public static A019829Inst Instance=new A019829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019828
{
public static readonly long[] Value={ 3L,2L,5L,5L,6L,8L,1L,5L,4L,4L,5L,7L,1L,5L,6L,6L,6L,8L,7L,1L,4L,0L,0L,8L,9L,3L,5L,7L,9L,4L,7L,2L,1L,5L,7L,1L,7L,9L,8L,8L,5L,1L,6L,0L,6L,7L,5L,9L,1L,2L,3L,1L,0L,7L,2L,1L,5L,2L,2L,2L,7L,9L,4L,9L,4L,6L,6L,0L,1L,6L,8L,0L,5L,2L,8L,3L,8L,4L,1L,7L,9L,4L,2L,8L,1L,7L,6L,5L,9L,6L,7L,1L,3L,1L,2L,7L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019828Inst : IEnumerable<long>
{
public static readonly long[] Value=A019828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019828.Bytes);
public long this[int i]=>Value[i];

public static A019828Inst Instance=new A019828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019827
{
public static readonly long[] Value={ 3L,0L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019827Inst : IEnumerable<long>
{
public static readonly long[] Value=A019827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019827.Bytes);
public long this[int i]=>Value[i];

public static A019827Inst Instance=new A019827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019826
{
public static readonly long[] Value={ 2L,9L,2L,3L,7L,1L,7L,0L,4L,7L,2L,2L,7L,3L,6L,7L,2L,8L,0L,9L,7L,4L,6L,8L,6L,9L,5L,3L,7L,7L,1L,4L,3L,2L,5L,2L,6L,6L,4L,6L,8L,7L,1L,8L,6L,1L,8L,2L,6L,2L,4L,5L,4L,1L,7L,1L,9L,6L,6L,4L,3L,6L,9L,6L,0L,1L,0L,5L,0L,1L,0L,8L,1L,5L,7L,4L,7L,4L,7L,0L,5L,4L,0L,6L,5L,8L,5L,1L,0L,6L,5L,1L,2L,8L,9L,3L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019826Inst : IEnumerable<long>
{
public static readonly long[] Value=A019826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019826.Bytes);
public long this[int i]=>Value[i];

public static A019826Inst Instance=new A019826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019825
{
public static readonly long[] Value={ 2L,7L,5L,6L,3L,7L,3L,5L,5L,8L,1L,6L,9L,9L,9L,1L,8L,5L,6L,4L,9L,9L,7L,1L,5L,7L,4L,6L,1L,1L,3L,0L,4L,1L,4L,7L,7L,1L,2L,4L,4L,7L,3L,2L,6L,4L,5L,6L,8L,9L,6L,6L,8L,1L,8L,6L,6L,9L,6L,5L,0L,7L,2L,0L,1L,9L,7L,3L,8L,2L,5L,5L,1L,1L,7L,4L,8L,3L,6L,5L,7L,5L,2L,6L,6L,9L,3L,3L,5L,8L,9L,3L,6L,6L,9L,8L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019825Inst : IEnumerable<long>
{
public static readonly long[] Value=A019825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019825.Bytes);
public long this[int i]=>Value[i];

public static A019825Inst Instance=new A019825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019824
{
public static readonly long[] Value={ 2L,5L,8L,8L,1L,9L,0L,4L,5L,1L,0L,2L,5L,2L,0L,7L,6L,2L,3L,4L,8L,8L,9L,8L,8L,3L,7L,6L,2L,4L,0L,4L,8L,3L,2L,8L,3L,4L,9L,0L,6L,8L,9L,0L,1L,3L,1L,9L,9L,3L,0L,5L,1L,3L,8L,1L,4L,0L,0L,3L,2L,0L,7L,3L,1L,5L,0L,5L,6L,9L,7L,4L,7L,4L,8L,8L,0L,1L,9L,9L,6L,9L,2L,2L,3L,6L,7L,9L,7L,4L,6L,9L,4L,2L,4L,9L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019824Inst : IEnumerable<long>
{
public static readonly long[] Value=A019824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019824.Bytes);
public long this[int i]=>Value[i];

public static A019824Inst Instance=new A019824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019823
{
public static readonly long[] Value={ 2L,4L,1L,9L,2L,1L,8L,9L,5L,5L,9L,9L,6L,6L,7L,7L,2L,2L,5L,6L,0L,4L,4L,2L,3L,7L,4L,1L,0L,0L,3L,5L,2L,9L,6L,5L,2L,9L,5L,0L,0L,7L,9L,3L,0L,3L,9L,8L,7L,4L,2L,8L,9L,4L,5L,7L,6L,4L,7L,1L,2L,6L,5L,8L,3L,8L,8L,9L,0L,8L,2L,4L,6L,7L,6L,1L,3L,2L,5L,8L,4L,3L,3L,2L,3L,5L,2L,8L,5L,7L,8L,2L,7L,3L,1L,4L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019823Inst : IEnumerable<long>
{
public static readonly long[] Value=A019823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019823.Bytes);
public long this[int i]=>Value[i];

public static A019823Inst Instance=new A019823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019822
{
public static readonly long[] Value={ 2L,2L,4L,9L,5L,1L,0L,5L,4L,3L,4L,3L,8L,6L,4L,9L,9L,8L,0L,5L,1L,1L,0L,7L,2L,0L,8L,3L,4L,2L,7L,9L,6L,5L,5L,8L,6L,3L,1L,0L,1L,3L,7L,9L,9L,2L,2L,8L,6L,8L,5L,0L,2L,1L,5L,1L,2L,7L,7L,9L,5L,0L,7L,2L,5L,6L,4L,2L,5L,9L,9L,3L,0L,1L,6L,1L,3L,3L,1L,0L,4L,4L,1L,1L,9L,0L,8L,8L,7L,8L,4L,0L,0L,5L,6L,1L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019822Inst : IEnumerable<long>
{
public static readonly long[] Value=A019822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019822.Bytes);
public long this[int i]=>Value[i];

public static A019822Inst Instance=new A019822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019805
{
public static readonly long[] Value={ 1L,5L,5L,4L,4L,2L,9L,3L,2L,1L,0L,6L,4L,7L,4L,9L,4L,6L,8L,9L,0L,9L,0L,2L,4L,0L,4L,1L,4L,4L,5L,6L,0L,0L,5L,8L,4L,2L,5L,3L,4L,9L,0L,8L,6L,6L,1L,2L,5L,0L,5L,8L,9L,4L,8L,6L,7L,2L,0L,6L,4L,2L,9L,8L,5L,1L,7L,3L,4L,0L,0L,3L,2L,9L,4L,1L,7L,7L,1L,5L,6L,6L,3L,3L,5L,0L,8L,6L,6L,6L,1L,1L,9L,6L,9L,8L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019805Inst : IEnumerable<long>
{
public static readonly long[] Value=A019805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019805.Bytes);
public long this[int i]=>Value[i];

public static A019805Inst Instance=new A019805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019804
{
public static readonly long[] Value={ 1L,7L,9L,3L,5L,7L,2L,2L,9L,3L,5L,3L,6L,2L,4L,9L,3L,8L,7L,2L,0L,2L,7L,2L,0L,0L,4L,7L,8L,2L,1L,8L,4L,6L,8L,2L,7L,9L,8L,4L,7L,9L,7L,1L,5L,3L,2L,2L,1L,2L,2L,1L,8L,6L,3L,8L,5L,2L,3L,8L,1L,8L,8L,2L,9L,0L,4L,6L,2L,3L,1L,1L,4L,9L,3L,2L,8L,1L,3L,3L,4L,5L,7L,7L,1L,2L,5L,3L,8L,3L,9L,8L,4L,2L,6L,7L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019804Inst : IEnumerable<long>
{
public static readonly long[] Value=A019804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019804.Bytes);
public long this[int i]=>Value[i];

public static A019804Inst Instance=new A019804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019803
{
public static readonly long[] Value={ 2L,1L,1L,9L,6L,7L,6L,3L,4L,6L,9L,0L,6L,4L,7L,6L,5L,4L,8L,5L,1L,2L,3L,0L,5L,5L,1L,1L,0L,6L,2L,1L,8L,2L,6L,1L,4L,8L,9L,1L,1L,2L,3L,9L,0L,8L,3L,5L,2L,3L,5L,3L,1L,1L,1L,8L,2L,5L,5L,4L,2L,2L,2L,5L,2L,5L,0L,9L,1L,8L,2L,2L,6L,7L,3L,8L,7L,7L,9L,4L,0L,8L,6L,3L,8L,7L,5L,4L,5L,3L,7L,9L,9L,5L,8L,8L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019803Inst : IEnumerable<long>
{
public static readonly long[] Value=A019803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019803.Bytes);
public long this[int i]=>Value[i];

public static A019803Inst Instance=new A019803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019802
{
public static readonly long[] Value={ 2L,5L,9L,0L,7L,1L,5L,5L,3L,5L,1L,0L,7L,9L,1L,5L,7L,8L,1L,5L,1L,5L,0L,4L,0L,0L,6L,9L,0L,7L,6L,0L,0L,0L,9L,7L,3L,7L,5L,5L,8L,1L,8L,1L,1L,0L,2L,0L,8L,4L,3L,1L,5L,8L,1L,1L,2L,0L,1L,0L,7L,1L,6L,4L,1L,9L,5L,5L,6L,6L,7L,2L,1L,5L,6L,9L,6L,1L,9L,2L,7L,7L,2L,2L,5L,1L,4L,4L,4L,3L,5L,3L,2L,8L,3L,0L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019802Inst : IEnumerable<long>
{
public static readonly long[] Value=A019802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019802.Bytes);
public long this[int i]=>Value[i];

public static A019802Inst Instance=new A019802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019801
{
public static readonly long[] Value={ 3L,3L,3L,0L,9L,1L,9L,9L,7L,3L,7L,1L,0L,1L,7L,7L,4L,3L,3L,3L,7L,6L,4L,8L,0L,0L,8L,8L,8L,1L,2L,0L,0L,1L,2L,5L,1L,9L,7L,1L,7L,6L,6L,1L,4L,1L,6L,9L,6L,5L,5L,4L,8L,9L,0L,0L,1L,1L,5L,6L,6L,3L,5L,3L,9L,6L,5L,7L,2L,8L,6L,4L,2L,0L,1L,8L,0L,8L,1L,9L,2L,7L,8L,6L,0L,8L,9L,9L,9L,8L,8L,2L,7L,9L,2L,5L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019801Inst : IEnumerable<long>
{
public static readonly long[] Value=A019801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019801.Bytes);
public long this[int i]=>Value[i];

public static A019801Inst Instance=new A019801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019800
{
public static readonly long[] Value={ 4L,6L,6L,3L,2L,8L,7L,9L,6L,3L,1L,9L,4L,2L,4L,8L,4L,0L,6L,7L,2L,7L,0L,7L,2L,1L,2L,4L,3L,3L,6L,8L,0L,1L,7L,5L,2L,7L,6L,0L,4L,7L,2L,5L,9L,8L,3L,7L,5L,1L,7L,6L,8L,4L,6L,0L,1L,6L,1L,9L,2L,8L,9L,5L,5L,5L,2L,0L,2L,0L,0L,9L,8L,8L,2L,5L,3L,1L,4L,6L,9L,9L,0L,0L,5L,2L,5L,9L,9L,8L,3L,5L,9L,0L,9L,5L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019800Inst : IEnumerable<long>
{
public static readonly long[] Value=A019800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019800.Bytes);
public long this[int i]=>Value[i];

public static A019800Inst Instance=new A019800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019799
{
public static readonly long[] Value={ 7L,7L,7L,2L,1L,4L,6L,6L,0L,5L,3L,2L,3L,7L,4L,7L,3L,4L,4L,5L,4L,5L,1L,2L,0L,2L,0L,7L,2L,2L,8L,0L,0L,2L,9L,2L,1L,2L,6L,7L,4L,5L,4L,3L,3L,0L,6L,2L,5L,2L,9L,4L,7L,4L,3L,3L,6L,0L,3L,2L,1L,4L,9L,2L,5L,8L,6L,7L,0L,0L,1L,6L,4L,7L,0L,8L,8L,5L,7L,8L,3L,1L,6L,7L,5L,4L,3L,3L,3L,0L,5L,9L,8L,4L,9L,2L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019799Inst : IEnumerable<long>
{
public static readonly long[] Value=A019799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019799.Bytes);
public long this[int i]=>Value[i];

public static A019799Inst Instance=new A019799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019798
{
public static readonly long[] Value={ 2L,3L,3L,1L,6L,4L,3L,9L,8L,1L,5L,9L,7L,1L,2L,4L,2L,0L,3L,3L,6L,3L,5L,3L,6L,0L,6L,2L,1L,6L,8L,4L,0L,0L,8L,7L,6L,3L,8L,0L,2L,3L,6L,2L,9L,9L,1L,8L,7L,5L,8L,8L,4L,2L,3L,0L,0L,8L,0L,9L,6L,4L,4L,7L,7L,7L,6L,0L,1L,0L,0L,4L,9L,4L,1L,2L,6L,5L,7L,3L,4L,9L,5L,0L,2L,6L,2L,9L,9L,9L,1L,7L,9L,5L,4L,7L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019798Inst : IEnumerable<long>
{
public static readonly long[] Value=A019798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019798.Bytes);
public long this[int i]=>Value[i];

public static A019798Inst Instance=new A019798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019797
{
public static readonly long[] Value={ 6L,8L,6L,9L,6L,7L,1L,9L,6L,1L,2L,5L,0L,5L,3L,3L,9L,4L,5L,2L,0L,2L,7L,1L,1L,6L,1L,5L,8L,9L,2L,3L,4L,8L,2L,1L,5L,2L,2L,4L,0L,6L,7L,0L,8L,6L,2L,9L,2L,2L,8L,3L,3L,8L,1L,5L,6L,2L,8L,3L,0L,4L,6L,5L,1L,6L,9L,4L,2L,0L,9L,2L,1L,6L,4L,2L,5L,6L,5L,0L,3L,5L,9L,6L,9L,9L,0L,2L,1L,6L,6L,9L,0L,1L,5L,2L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019797Inst : IEnumerable<long>
{
public static readonly long[] Value=A019797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019797.Bytes);
public long this[int i]=>Value[i];

public static A019797Inst Instance=new A019797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019796
{
public static readonly long[] Value={ 7L,1L,6L,8L,3L,5L,3L,3L,5L,0L,8L,7L,0L,1L,2L,2L,3L,7L,7L,6L,0L,2L,8L,2L,9L,5L,1L,2L,2L,3L,5L,4L,9L,3L,7L,8L,9L,7L,9L,9L,0L,2L,6L,5L,2L,4L,8L,2L,6L,7L,3L,0L,4L,8L,5L,1L,0L,9L,0L,4L,0L,4L,8L,5L,3L,9L,4L,1L,7L,8L,3L,5L,3L,0L,1L,8L,3L,2L,8L,7L,3L,3L,1L,8L,5L,9L,8L,4L,8L,6L,9L,8L,1L,0L,2L,8L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019796Inst : IEnumerable<long>
{
public static readonly long[] Value=A019796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019796.Bytes);
public long this[int i]=>Value[i];

public static A019796Inst Instance=new A019796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019795
{
public static readonly long[] Value={ 7L,4L,9L,4L,1L,8L,7L,5L,9L,4L,0L,9L,1L,4L,9L,1L,5L,7L,6L,5L,8L,4L,7L,7L,6L,3L,0L,8L,2L,4L,6L,1L,9L,8L,0L,5L,2L,9L,7L,1L,7L,0L,9L,5L,4L,8L,6L,8L,2L,4L,9L,0L,9L,6L,1L,7L,0L,4L,9L,0L,5L,9L,6L,2L,0L,0L,3L,0L,0L,4L,6L,4L,1L,7L,9L,1L,8L,8L,9L,1L,3L,0L,1L,4L,8L,9L,8L,4L,1L,8L,2L,0L,7L,4L,3L,9L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019795Inst : IEnumerable<long>
{
public static readonly long[] Value=A019795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019795.Bytes);
public long this[int i]=>Value[i];

public static A019795Inst Instance=new A019795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019794
{
public static readonly long[] Value={ 7L,8L,5L,1L,0L,5L,3L,6L,7L,0L,0L,0L,0L,6L,1L,0L,2L,2L,3L,0L,8L,8L,8L,1L,3L,2L,7L,5L,3L,0L,5L,5L,4L,0L,8L,1L,7L,3L,9L,8L,9L,3L,3L,8L,1L,2L,9L,0L,5L,4L,6L,6L,7L,2L,1L,7L,8L,6L,0L,9L,1L,9L,6L,0L,1L,9L,3L,6L,2L,3L,9L,1L,0L,4L,4L,8L,6L,4L,5L,7L,5L,5L,3L,9L,4L,1L,7L,3L,9L,0L,5L,0L,3L,0L,3L,1L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019794Inst : IEnumerable<long>
{
public static readonly long[] Value=A019794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019794.Bytes);
public long this[int i]=>Value[i];

public static A019794Inst Instance=new A019794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019793
{
public static readonly long[] Value={ 1L,20L,271L,3110L,32641L,324800L,3125011L,29414090L,272851381L,2506362980L,22871235751L,207773763470L,1881803862121L,17008495407560L,153516126074491L,1384313656687250L,12474986630176861L,112372624930994540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019793Inst : IEnumerable<long>
{
public static readonly long[] Value=A019793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019793.Bytes);
public long this[int i]=>Value[i];

public static A019793Inst Instance=new A019793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019792
{
public static readonly long[] Value={ 8L,6L,7L,7L,4L,8L,0L,3L,7L,2L,1L,0L,5L,9L,3L,7L,6L,1L,4L,9L,9L,2L,8L,9L,8L,8L,8L,3L,2L,3L,2L,4L,3L,9L,8L,5L,0L,8L,0L,9L,3L,4L,7L,8L,9L,8L,4L,7L,4L,4L,6L,3L,2L,1L,8L,8L,1L,6L,2L,0L,6L,9L,0L,3L,3L,7L,1L,9L,0L,0L,1L,1L,1L,5L,4L,8L,5L,0L,3L,2L,0L,3L,3L,3L,0L,4L,0L,2L,7L,3L,7L,1L,3L,8L,7L,7L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019792Inst : IEnumerable<long>
{
public static readonly long[] Value=A019792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019792.Bytes);
public long this[int i]=>Value[i];

public static A019792Inst Instance=new A019792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019791
{
public static readonly long[] Value={ 9L,1L,5L,9L,5L,6L,2L,6L,1L,5L,0L,0L,0L,7L,1L,1L,9L,2L,6L,9L,3L,6L,9L,4L,8L,8L,2L,1L,1L,8L,9L,7L,9L,7L,6L,2L,0L,2L,9L,8L,7L,5L,6L,1L,1L,5L,0L,5L,6L,3L,7L,7L,8L,4L,2L,0L,8L,3L,7L,7L,3L,9L,5L,3L,5L,5L,9L,2L,2L,7L,8L,9L,5L,5L,2L,3L,4L,2L,0L,0L,4L,7L,9L,5L,9L,8L,6L,9L,5L,5L,5L,8L,6L,8L,7L,0L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019791Inst : IEnumerable<long>
{
public static readonly long[] Value=A019791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019791.Bytes);
public long this[int i]=>Value[i];

public static A019791Inst Instance=new A019791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019790
{
public static readonly long[] Value={ 9L,6L,9L,8L,3L,6L,0L,4L,1L,5L,8L,8L,3L,1L,0L,6L,7L,4L,6L,1L,6L,8L,5L,3L,4L,0L,4L,5L,9L,6L,5L,6L,6L,8L,0L,6L,8L,5L,5L,1L,6L,2L,4L,1L,2L,1L,8L,2L,4L,4L,0L,0L,0L,6L,8L,0L,8L,8L,7L,0L,1L,8L,3L,3L,1L,8L,0L,3L,5L,8L,9L,4L,8L,2L,0L,1L,2L,6L,8L,2L,8L,6L,0L,7L,5L,1L,5L,6L,0L,0L,0L,3L,3L,1L,5L,6L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019790Inst : IEnumerable<long>
{
public static readonly long[] Value=A019790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019790.Bytes);
public long this[int i]=>Value[i];

public static A019790Inst Instance=new A019790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019789
{
public static readonly long[] Value={ 1L,0L,3L,0L,4L,5L,0L,7L,9L,4L,1L,8L,7L,5L,8L,0L,0L,9L,1L,7L,8L,0L,4L,0L,6L,7L,4L,2L,3L,8L,3L,8L,5L,2L,2L,3L,2L,2L,8L,3L,6L,1L,0L,0L,6L,2L,9L,4L,3L,8L,4L,2L,5L,0L,7L,2L,3L,4L,4L,2L,4L,5L,6L,9L,7L,7L,5L,4L,1L,3L,1L,3L,8L,2L,4L,6L,3L,8L,4L,7L,5L,5L,3L,9L,5L,4L,8L,5L,3L,2L,5L,0L,3L,5L,2L,2L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019789Inst : IEnumerable<long>
{
public static readonly long[] Value=A019789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019789.Bytes);
public long this[int i]=>Value[i];

public static A019789Inst Instance=new A019789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019788
{
public static readonly long[] Value={ 1L,0L,9L,9L,1L,4L,7L,5L,1L,3L,8L,0L,0L,0L,8L,5L,4L,3L,1L,2L,3L,2L,4L,3L,3L,8L,5L,8L,5L,4L,2L,7L,7L,5L,7L,1L,4L,4L,3L,5L,8L,5L,0L,7L,3L,3L,8L,0L,6L,7L,6L,5L,3L,4L,1L,0L,5L,0L,0L,5L,2L,8L,7L,4L,4L,2L,7L,1L,0L,7L,3L,4L,7L,4L,6L,2L,8L,1L,0L,4L,0L,5L,7L,5L,5L,1L,8L,4L,3L,4L,6L,7L,0L,4L,2L,4L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019788Inst : IEnumerable<long>
{
public static readonly long[] Value=A019788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019788.Bytes);
public long this[int i]=>Value[i];

public static A019788Inst Instance=new A019788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019787
{
public static readonly long[] Value={ 1L,1L,7L,7L,6L,5L,8L,0L,5L,0L,5L,0L,0L,0L,9L,1L,5L,3L,3L,4L,6L,3L,3L,2L,1L,9L,9L,1L,2L,9L,5L,8L,3L,1L,1L,2L,2L,6L,0L,9L,8L,4L,0L,0L,7L,1L,9L,3L,5L,8L,2L,0L,0L,0L,8L,2L,6L,7L,9L,1L,3L,7L,9L,4L,0L,2L,9L,0L,4L,3L,5L,8L,6L,5L,6L,7L,2L,9L,6L,8L,6L,3L,3L,0L,9L,1L,2L,6L,0L,8L,5L,7L,5L,4L,5L,4L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019787Inst : IEnumerable<long>
{
public static readonly long[] Value=A019787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019787.Bytes);
public long this[int i]=>Value[i];

public static A019787Inst Instance=new A019787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019786
{
public static readonly long[] Value={ 1L,2L,6L,8L,2L,4L,7L,1L,3L,1L,3L,0L,7L,7L,9L,0L,8L,8L,2L,1L,9L,1L,2L,6L,9L,8L,3L,6L,7L,8L,0L,1L,2L,5L,8L,2L,4L,3L,4L,9L,0L,5L,8L,5L,3L,9L,0L,0L,7L,8L,0L,6L,1L,6L,2L,7L,5L,0L,0L,6L,1L,0L,0L,8L,9L,5L,4L,3L,5L,4L,6L,3L,1L,6L,8L,7L,8L,5L,8L,1L,6L,0L,4L,8L,6L,7L,5L,1L,1L,6L,9L,2L,7L,4L,1L,2L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019786Inst : IEnumerable<long>
{
public static readonly long[] Value=A019786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019786.Bytes);
public long this[int i]=>Value[i];

public static A019786Inst Instance=new A019786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019785
{
public static readonly long[] Value={ 1L,3L,7L,3L,9L,3L,4L,3L,9L,2L,2L,5L,0L,1L,0L,6L,7L,8L,9L,0L,4L,0L,5L,4L,2L,3L,2L,3L,1L,7L,8L,4L,6L,9L,6L,4L,3L,0L,4L,4L,8L,1L,3L,4L,1L,7L,2L,5L,8L,4L,5L,6L,6L,7L,6L,3L,1L,2L,5L,6L,6L,0L,9L,3L,0L,3L,3L,8L,8L,4L,1L,8L,4L,3L,2L,8L,5L,1L,3L,0L,0L,7L,1L,9L,3L,9L,8L,0L,4L,3L,3L,3L,8L,0L,3L,0L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019785Inst : IEnumerable<long>
{
public static readonly long[] Value=A019785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019785.Bytes);
public long this[int i]=>Value[i];

public static A019785Inst Instance=new A019785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019784
{
public static readonly long[] Value={ 1L,4L,9L,8L,8L,3L,7L,5L,1L,8L,8L,1L,8L,2L,9L,8L,3L,1L,5L,3L,1L,6L,9L,5L,5L,2L,6L,1L,6L,4L,9L,2L,3L,9L,6L,1L,0L,5L,9L,4L,3L,4L,1L,9L,0L,9L,7L,3L,6L,4L,9L,8L,1L,9L,2L,3L,4L,0L,9L,8L,1L,1L,9L,2L,4L,0L,0L,6L,0L,0L,9L,2L,8L,3L,5L,8L,3L,7L,7L,8L,2L,6L,0L,2L,9L,7L,9L,6L,8L,3L,6L,4L,1L,4L,8L,7L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019784Inst : IEnumerable<long>
{
public static readonly long[] Value=A019784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019784.Bytes);
public long this[int i]=>Value[i];

public static A019784Inst Instance=new A019784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019783
{
public static readonly long[] Value={ 1L,19L,243L,2615L,25571L,235599L,2086603L,17981815L,151979091L,1266533279L,10446235163L,85502523015L,695860175011L,5639142048559L,45552803794923L,367090952376215L,2952891339001331L,23720875971413439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019783Inst : IEnumerable<long>
{
public static readonly long[] Value=A019783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019783.Bytes);
public long this[int i]=>Value[i];

public static A019783Inst Instance=new A019783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019782
{
public static readonly long[] Value={ 1L,8L,3L,1L,9L,1L,2L,5L,2L,3L,0L,0L,0L,1L,4L,2L,3L,8L,5L,3L,8L,7L,3L,8L,9L,7L,6L,4L,2L,3L,7L,9L,5L,9L,5L,2L,4L,0L,5L,9L,7L,5L,1L,2L,2L,3L,0L,1L,1L,2L,7L,5L,5L,6L,8L,4L,1L,6L,7L,5L,4L,7L,9L,0L,7L,1L,1L,8L,4L,5L,5L,7L,9L,1L,0L,4L,6L,8L,4L,0L,0L,9L,5L,9L,1L,9L,7L,3L,9L,1L,1L,1L,7L,3L,7L,4L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019782Inst : IEnumerable<long>
{
public static readonly long[] Value=A019782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019782.Bytes);
public long this[int i]=>Value[i];

public static A019782Inst Instance=new A019782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019781
{
public static readonly long[] Value={ 2L,0L,6L,0L,9L,0L,1L,5L,8L,8L,3L,7L,5L,1L,6L,0L,1L,8L,3L,5L,6L,0L,8L,1L,3L,4L,8L,4L,7L,6L,7L,7L,0L,4L,4L,6L,4L,5L,6L,7L,2L,2L,0L,1L,2L,5L,8L,8L,7L,6L,8L,5L,0L,1L,4L,4L,6L,8L,8L,4L,9L,1L,3L,9L,5L,5L,0L,8L,2L,6L,2L,7L,6L,4L,9L,2L,7L,6L,9L,5L,1L,0L,7L,9L,0L,9L,7L,0L,6L,5L,0L,0L,7L,0L,4L,5L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019781Inst : IEnumerable<long>
{
public static readonly long[] Value=A019781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019781.Bytes);
public long this[int i]=>Value[i];

public static A019781Inst Instance=new A019781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019780
{
public static readonly long[] Value={ 2L,3L,5L,5L,3L,1L,6L,1L,0L,1L,0L,0L,0L,1L,8L,3L,0L,6L,6L,9L,2L,6L,6L,4L,3L,9L,8L,2L,5L,9L,1L,6L,6L,2L,2L,4L,5L,2L,1L,9L,6L,8L,0L,1L,4L,3L,8L,7L,1L,6L,4L,0L,0L,1L,6L,5L,3L,5L,8L,2L,7L,5L,8L,8L,0L,5L,8L,0L,8L,7L,1L,7L,3L,1L,3L,4L,5L,9L,3L,7L,2L,6L,6L,1L,8L,2L,5L,2L,1L,7L,1L,5L,0L,9L,0L,9L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019780Inst : IEnumerable<long>
{
public static readonly long[] Value=A019780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019780.Bytes);
public long this[int i]=>Value[i];

public static A019780Inst Instance=new A019780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019779
{
public static readonly long[] Value={ 2L,7L,4L,7L,8L,6L,8L,7L,8L,4L,5L,0L,0L,2L,1L,3L,5L,7L,8L,0L,8L,1L,0L,8L,4L,6L,4L,6L,3L,5L,6L,9L,3L,9L,2L,8L,6L,0L,8L,9L,6L,2L,6L,8L,3L,4L,5L,1L,6L,9L,1L,3L,3L,5L,2L,6L,2L,5L,1L,3L,2L,1L,8L,6L,0L,6L,7L,7L,6L,8L,3L,6L,8L,6L,5L,7L,0L,2L,6L,0L,1L,4L,3L,8L,7L,9L,6L,0L,8L,6L,6L,7L,6L,0L,6L,1L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019779Inst : IEnumerable<long>
{
public static readonly long[] Value=A019779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019779.Bytes);
public long this[int i]=>Value[i];

public static A019779Inst Instance=new A019779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019778
{
public static readonly long[] Value={ 3L,2L,9L,7L,4L,4L,2L,5L,4L,1L,4L,0L,0L,2L,5L,6L,2L,9L,3L,6L,9L,7L,3L,0L,1L,5L,7L,5L,6L,2L,8L,3L,2L,7L,1L,4L,3L,3L,0L,7L,5L,5L,2L,2L,0L,1L,4L,2L,0L,2L,9L,6L,0L,2L,3L,1L,5L,0L,1L,5L,8L,6L,2L,3L,2L,8L,1L,3L,2L,2L,0L,4L,2L,3L,8L,8L,4L,3L,1L,2L,1L,7L,2L,6L,5L,5L,5L,3L,0L,4L,0L,1L,1L,2L,7L,3L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019778Inst : IEnumerable<long>
{
public static readonly long[] Value=A019778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019778.Bytes);
public long this[int i]=>Value[i];

public static A019778Inst Instance=new A019778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019777
{
public static readonly long[] Value={ 4L,1L,2L,1L,8L,0L,3L,1L,7L,6L,7L,5L,0L,3L,2L,0L,3L,6L,7L,1L,2L,1L,6L,2L,6L,9L,6L,9L,5L,3L,5L,4L,0L,8L,9L,2L,9L,1L,3L,4L,4L,4L,0L,2L,5L,1L,7L,7L,5L,3L,7L,0L,0L,2L,8L,9L,3L,7L,6L,9L,8L,2L,7L,9L,1L,0L,1L,6L,5L,2L,5L,5L,2L,9L,8L,5L,5L,3L,9L,0L,2L,1L,5L,8L,1L,9L,4L,1L,3L,0L,0L,1L,4L,0L,9L,1L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019777Inst : IEnumerable<long>
{
public static readonly long[] Value=A019777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019777.Bytes);
public long this[int i]=>Value[i];

public static A019777Inst Instance=new A019777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019776
{
public static readonly long[] Value={ 5L,4L,9L,5L,7L,3L,7L,5L,6L,9L,0L,0L,0L,4L,2L,7L,1L,5L,6L,1L,6L,2L,1L,6L,9L,2L,9L,2L,7L,1L,3L,8L,7L,8L,5L,7L,2L,1L,7L,9L,2L,5L,3L,6L,6L,9L,0L,3L,3L,8L,2L,6L,7L,0L,5L,2L,5L,0L,2L,6L,4L,3L,7L,2L,1L,3L,5L,5L,3L,6L,7L,3L,7L,3L,1L,4L,0L,5L,2L,0L,2L,8L,7L,7L,5L,9L,2L,1L,7L,3L,3L,5L,2L,1L,2L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019776Inst : IEnumerable<long>
{
public static readonly long[] Value=A019776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019776.Bytes);
public long this[int i]=>Value[i];

public static A019776Inst Instance=new A019776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019775
{
public static readonly long[] Value={ 8L,2L,4L,3L,6L,0L,6L,3L,5L,3L,5L,0L,0L,6L,4L,0L,7L,3L,4L,2L,4L,3L,2L,5L,3L,9L,3L,9L,0L,7L,0L,8L,1L,7L,8L,5L,8L,2L,6L,8L,8L,8L,0L,5L,0L,3L,5L,5L,0L,7L,4L,0L,0L,5L,7L,8L,7L,5L,3L,9L,6L,5L,5L,8L,2L,0L,3L,3L,0L,5L,1L,0L,5L,9L,7L,1L,0L,7L,8L,0L,4L,3L,1L,6L,3L,8L,8L,2L,6L,0L,0L,2L,8L,1L,8L,3L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019775Inst : IEnumerable<long>
{
public static readonly long[] Value=A019775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019775.Bytes);
public long this[int i]=>Value[i];

public static A019775Inst Instance=new A019775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019774
{
public static readonly long[] Value={ 1L,6L,4L,8L,7L,2L,1L,2L,7L,0L,7L,0L,0L,1L,2L,8L,1L,4L,6L,8L,4L,8L,6L,5L,0L,7L,8L,7L,8L,1L,4L,1L,6L,3L,5L,7L,1L,6L,5L,3L,7L,7L,6L,1L,0L,0L,7L,1L,0L,1L,4L,8L,0L,1L,1L,5L,7L,5L,0L,7L,9L,3L,1L,1L,6L,4L,0L,6L,6L,1L,0L,2L,1L,1L,9L,4L,2L,1L,5L,6L,0L,8L,6L,3L,2L,7L,7L,6L,5L,2L,0L,0L,5L,6L,3L,6L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019774Inst : IEnumerable<long>
{
public static readonly long[] Value=A019774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019774.Bytes);
public long this[int i]=>Value[i];

public static A019774Inst Instance=new A019774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019757
{
public static readonly long[] Value={ 1L,18L,217L,2190L,19981L,170898L,1398097L,11075670L,85654261L,650280378L,4865931577L,35994162750L,263799130141L,1918854559458L,13871649322657L,99770067275430L,714554190919621L,5099624595840138L,36287658424563337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019757Inst : IEnumerable<long>
{
public static readonly long[] Value=A019757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019757.Bytes);
public long this[int i]=>Value[i];

public static A019757Inst Instance=new A019757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019756
{
public static readonly long[] Value={ 1L,4L,3L,0L,6L,7L,4L,6L,4L,6L,5L,5L,7L,3L,9L,2L,2L,2L,9L,1L,3L,6L,9L,9L,3L,4L,0L,5L,9L,7L,5L,0L,8L,5L,5L,2L,5L,1L,3L,5L,3L,9L,3L,2L,0L,7L,2L,1L,0L,5L,0L,5L,0L,3L,9L,4L,5L,6L,2L,9L,8L,7L,5L,1L,4L,3L,3L,7L,2L,4L,5L,4L,2L,2L,9L,1L,3L,4L,0L,8L,3L,9L,2L,4L,8L,0L,9L,5L,8L,8L,3L,4L,3L,4L,2L,9L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019756Inst : IEnumerable<long>
{
public static readonly long[] Value=A019756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019756.Bytes);
public long this[int i]=>Value[i];

public static A019756Inst Instance=new A019756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019755
{
public static readonly long[] Value={ 1L,5L,1L,0L,1L,5L,6L,5L,7L,1L,3L,6L,6L,1L,3L,6L,2L,4L,1L,8L,6L,6L,8L,2L,6L,3L,7L,2L,9L,7L,3L,7L,0L,1L,3L,8L,7L,6L,4L,2L,9L,1L,5L,0L,5L,2L,0L,5L,5L,5L,3L,3L,0L,9L,7L,2L,0L,3L,8L,7L,0L,9L,0L,4L,2L,9L,1L,1L,5L,3L,6L,8L,3L,5L,2L,9L,7L,4L,8L,6L,6L,3L,6L,5L,0L,7L,6L,7L,8L,7L,6L,9L,5L,8L,4L,2L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019755Inst : IEnumerable<long>
{
public static readonly long[] Value=A019755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019755.Bytes);
public long this[int i]=>Value[i];

public static A019755Inst Instance=new A019755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019754
{
public static readonly long[] Value={ 1L,5L,9L,8L,9L,8L,9L,3L,1L,0L,8L,5L,8L,2L,6L,1L,9L,0L,3L,1L,5L,3L,1L,1L,0L,2L,7L,7L,2L,6L,6L,2L,7L,2L,0L,5L,7L,5L,0L,4L,2L,6L,2L,9L,9L,6L,2L,9L,4L,0L,9L,3L,8L,6L,7L,6L,2L,7L,6L,2L,8L,0L,1L,6L,3L,0L,8L,2L,8L,0L,3L,7L,0L,7L,9L,6L,2L,0L,4L,4L,6L,7L,3L,9L,4L,9L,3L,0L,6L,9L,3L,2L,5L,0L,0L,9L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019754Inst : IEnumerable<long>
{
public static readonly long[] Value=A019754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019754.Bytes);
public long this[int i]=>Value[i];

public static A019754Inst Instance=new A019754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019753
{
public static readonly long[] Value={ 1L,6L,9L,8L,9L,2L,6L,1L,4L,2L,7L,8L,6L,9L,0L,3L,2L,7L,2L,1L,0L,0L,1L,7L,9L,6L,6L,9L,5L,9L,5L,4L,1L,4L,0L,6L,1L,0L,9L,8L,2L,7L,9L,4L,3L,3L,5L,6L,2L,4L,7L,4L,7L,3L,4L,3L,5L,4L,3L,5L,4L,7L,6L,7L,3L,2L,7L,5L,4L,7L,8L,9L,3L,9L,7L,0L,9L,6L,7L,2L,4L,6L,6L,0L,7L,1L,1L,3L,8L,6L,1L,5L,7L,8L,2L,2L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019753Inst : IEnumerable<long>
{
public static readonly long[] Value=A019753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019753.Bytes);
public long this[int i]=>Value[i];

public static A019753Inst Instance=new A019753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019752
{
public static readonly BigInteger[] Value={ 1L,27L,505L,8115L,120241L,1695387L,23126185L,308127555L,4034342881L,52117311147L,666165944665L,8442335850195L,106239836635921L,1329127977509307L,16546285315207945L,205119670292296035L,2533642759410327361L,BigInteger.Parse("31197987005034321867"),BigInteger.Parse("383112856942345668025") };
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
public class A019752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019752Inst Instance=new A019752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019751
{
public static readonly long[] Value={ 1L,9L,4L,1L,6L,2L,9L,8L,7L,7L,4L,7L,0L,7L,4L,6L,5L,9L,6L,6L,8L,5L,9L,1L,9L,6L,2L,2L,3L,9L,4L,7L,5L,8L,9L,2L,6L,9L,6L,9L,4L,6L,2L,2L,0L,9L,7L,8L,5L,6L,8L,5L,4L,1L,0L,6L,9L,0L,6L,9L,1L,1L,6L,2L,6L,6L,0L,0L,5L,4L,7L,3L,5L,9L,6L,6L,8L,1L,9L,7L,1L,0L,4L,0L,8L,1L,3L,0L,1L,2L,7L,5L,1L,7L,9L,7L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019751Inst : IEnumerable<long>
{
public static readonly long[] Value=A019751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019751.Bytes);
public long this[int i]=>Value[i];

public static A019751Inst Instance=new A019751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019750
{
public static readonly long[] Value={ 2L,0L,9L,0L,9L,8L,6L,0L,2L,1L,8L,9L,1L,5L,7L,3L,2L,5L,7L,9L,6L,9L,4L,5L,1L,9L,0L,1L,0L,4L,0L,5L,0L,9L,6L,1L,3L,6L,5L,9L,4L,2L,0L,8L,4L,1L,3L,0L,7L,6L,6L,1L,2L,1L,1L,5L,1L,3L,0L,5L,2L,0L,2L,1L,3L,2L,6L,2L,1L,2L,7L,9L,2L,5L,7L,9L,6L,5L,1L,9L,9L,5L,8L,2L,4L,1L,4L,0L,1L,3L,7L,3L,2L,7L,0L,5L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019750Inst : IEnumerable<long>
{
public static readonly long[] Value=A019750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019750.Bytes);
public long this[int i]=>Value[i];

public static A019750Inst Instance=new A019750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019749
{
public static readonly long[] Value={ 2L,2L,6L,5L,2L,3L,4L,8L,5L,7L,0L,4L,9L,2L,0L,4L,3L,6L,2L,8L,0L,0L,2L,3L,9L,5L,5L,9L,4L,6L,0L,5L,5L,2L,0L,8L,1L,4L,6L,4L,3L,7L,2L,5L,7L,8L,0L,8L,3L,2L,9L,9L,6L,4L,5L,8L,0L,5L,8L,0L,6L,3L,5L,6L,4L,3L,6L,7L,3L,0L,5L,2L,5L,2L,9L,4L,6L,2L,2L,9L,9L,5L,4L,7L,6L,1L,5L,1L,8L,1L,5L,4L,3L,7L,6L,3L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019749Inst : IEnumerable<long>
{
public static readonly long[] Value=A019749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019749.Bytes);
public long this[int i]=>Value[i];

public static A019749Inst Instance=new A019749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019748
{
public static readonly long[] Value={ 2L,4L,7L,1L,1L,6L,5L,2L,9L,8L,5L,9L,9L,1L,3L,2L,0L,3L,2L,1L,4L,5L,7L,1L,5L,8L,8L,3L,0L,4L,7L,8L,7L,4L,9L,9L,7L,9L,6L,1L,1L,3L,3L,7L,2L,1L,5L,4L,5L,4L,1L,7L,7L,9L,5L,4L,2L,4L,5L,1L,6L,0L,2L,5L,2L,0L,3L,7L,0L,6L,0L,2L,7L,5L,9L,4L,1L,3L,4L,1L,7L,6L,8L,8L,3L,0L,7L,4L,7L,0L,7L,7L,5L,0L,1L,5L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019748Inst : IEnumerable<long>
{
public static readonly long[] Value=A019748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019748.Bytes);
public long this[int i]=>Value[i];

public static A019748Inst Instance=new A019748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019747
{
public static readonly long[] Value={ 1L,26L,468L,7240L,103376L,1406496L,18541888L,239158400L,3036523776L,38104777216L,473923294208L,5853743400960L,71911576293376L,879605537447936L,10721932937084928L,130329861195857920L,1580624998153650176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019747Inst : IEnumerable<long>
{
public static readonly long[] Value=A019747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019747.Bytes);
public long this[int i]=>Value[i];

public static A019747Inst Instance=new A019747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019746
{
public static readonly long[] Value={ 3L,0L,2L,0L,3L,1L,3L,1L,4L,2L,7L,3L,2L,2L,7L,2L,4L,8L,3L,7L,3L,3L,6L,5L,2L,7L,4L,5L,9L,4L,7L,4L,0L,2L,7L,7L,5L,2L,8L,5L,8L,3L,0L,1L,0L,4L,1L,1L,1L,0L,6L,6L,1L,9L,4L,4L,0L,7L,7L,4L,1L,8L,0L,8L,5L,8L,2L,3L,0L,7L,3L,6L,7L,0L,5L,9L,4L,9L,7L,3L,2L,7L,3L,0L,1L,5L,3L,5L,7L,5L,3L,9L,1L,6L,8L,5L,1L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019746Inst : IEnumerable<long>
{
public static readonly long[] Value=A019746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019746.Bytes);
public long this[int i]=>Value[i];

public static A019746Inst Instance=new A019746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019745
{
public static readonly long[] Value={ 3L,3L,9L,7L,8L,5L,2L,2L,8L,5L,5L,7L,3L,8L,0L,6L,5L,4L,4L,2L,0L,0L,3L,5L,9L,3L,3L,9L,1L,9L,0L,8L,2L,8L,1L,2L,2L,1L,9L,6L,5L,5L,8L,8L,6L,7L,1L,2L,4L,9L,4L,9L,4L,6L,8L,7L,0L,8L,7L,0L,9L,5L,3L,4L,6L,5L,5L,0L,9L,5L,7L,8L,7L,9L,4L,1L,9L,3L,4L,4L,9L,3L,2L,1L,4L,2L,2L,7L,7L,2L,3L,1L,5L,6L,4L,5L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019745Inst : IEnumerable<long>
{
public static readonly long[] Value=A019745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019745.Bytes);
public long this[int i]=>Value[i];

public static A019745Inst Instance=new A019745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019744
{
public static readonly long[] Value={ 3L,8L,8L,3L,2L,5L,9L,7L,5L,4L,9L,4L,1L,4L,9L,3L,1L,9L,3L,3L,7L,1L,8L,3L,9L,2L,4L,4L,7L,8L,9L,5L,1L,7L,8L,5L,3L,9L,3L,8L,9L,2L,4L,4L,1L,9L,5L,7L,1L,3L,7L,0L,8L,2L,1L,3L,8L,1L,3L,8L,2L,3L,2L,5L,3L,2L,0L,1L,0L,9L,4L,7L,1L,9L,3L,3L,6L,3L,9L,4L,2L,0L,8L,1L,6L,2L,6L,0L,2L,5L,5L,0L,3L,5L,9L,5L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019744Inst : IEnumerable<long>
{
public static readonly long[] Value=A019744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019744.Bytes);
public long this[int i]=>Value[i];

public static A019744Inst Instance=new A019744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019743
{
public static readonly long[] Value={ 4L,5L,3L,0L,4L,6L,9L,7L,1L,4L,0L,9L,8L,4L,0L,8L,7L,2L,5L,6L,0L,0L,4L,7L,9L,1L,1L,8L,9L,2L,1L,1L,0L,4L,1L,6L,2L,9L,2L,8L,7L,4L,5L,1L,5L,6L,1L,6L,6L,5L,9L,9L,2L,9L,1L,6L,1L,1L,6L,1L,2L,7L,1L,2L,8L,7L,3L,4L,6L,1L,0L,5L,0L,5L,8L,9L,2L,4L,5L,9L,9L,0L,9L,5L,2L,3L,0L,3L,6L,3L,0L,8L,7L,5L,2L,7L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019743Inst : IEnumerable<long>
{
public static readonly long[] Value=A019743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019743.Bytes);
public long this[int i]=>Value[i];

public static A019743Inst Instance=new A019743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019742
{
public static readonly long[] Value={ 1L,25L,431L,6365L,86511L,1117605L,13957591L,170189245L,2038704671L,24092243285L,281680643751L,3265150951725L,37583315950831L,430083097386565L,4897580558961911L,55540052099419805L,627607236896972991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019742Inst : IEnumerable<long>
{
public static readonly long[] Value=A019742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019742.Bytes);
public long this[int i]=>Value[i];

public static A019742Inst Instance=new A019742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019725
{
public static readonly long[] Value={ 7L,7L,0L,6L,3L,2L,1L,0L,9L,0L,8L,9L,3L,5L,4L,7L,9L,4L,4L,7L,7L,4L,6L,4L,1L,2L,3L,1L,9L,1L,8L,0L,2L,2L,5L,3L,3L,9L,0L,2L,3L,8L,8L,9L,3L,9L,6L,6L,2L,5L,5L,2L,7L,3L,1L,3L,6L,4L,3L,8L,1L,6L,9L,5L,0L,1L,2L,6L,5L,7L,7L,5L,9L,0L,9L,1L,4L,4L,4L,2L,6L,6L,8L,4L,7L,6L,1L,1L,5L,5L,1L,0L,3L,7L,1L,5L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019725Inst : IEnumerable<long>
{
public static readonly long[] Value=A019725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019725.Bytes);
public long this[int i]=>Value[i];

public static A019725Inst Instance=new A019725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019724
{
public static readonly long[] Value={ 8L,0L,5L,6L,6L,0L,8L,4L,1L,3L,2L,0L,6L,8L,9L,1L,0L,3L,3L,1L,7L,3L,4L,8L,8L,5L,6L,0L,6L,4L,1L,5L,6L,9L,0L,1L,2L,7L,1L,6L,1L,3L,3L,8L,9L,1L,4L,6L,5L,3L,9L,6L,0L,3L,7L,3L,3L,5L,4L,8L,9L,9L,5L,3L,8L,7L,6L,8L,6L,9L,4L,7L,5L,4L,1L,3L,7L,8L,2L,6L,4L,2L,6L,1L,3L,4L,1L,2L,0L,7L,6L,0L,8L,4L,2L,9L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019724Inst : IEnumerable<long>
{
public static readonly long[] Value=A019724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019724.Bytes);
public long this[int i]=>Value[i];

public static A019724Inst Instance=new A019724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019723
{
public static readonly long[] Value={ 8L,4L,4L,0L,2L,5L,6L,4L,3L,2L,8L,8L,3L,4L,0L,9L,6L,5L,3L,8L,0L,0L,7L,9L,7L,5L,3L,9L,7L,1L,9L,7L,3L,8L,9L,6L,5L,7L,0L,2L,6L,1L,6L,4L,5L,7L,7L,2L,5L,6L,5L,2L,9L,9L,1L,4L,9L,4L,3L,2L,2L,8L,0L,8L,8L,2L,3L,3L,8L,7L,0L,6L,9L,4L,8L,1L,1L,0L,5L,6L,2L,5L,5L,9L,5L,0L,0L,3L,1L,2L,7L,3L,2L,6L,4L,0L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019723Inst : IEnumerable<long>
{
public static readonly long[] Value=A019723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019723.Bytes);
public long this[int i]=>Value[i];

public static A019723Inst Instance=new A019723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019722
{
public static readonly long[] Value={ 1L,25L,433L,6457L,89089L,1174537L,15047761L,189169369L,2347464097L,28866716329L,352675969009L,4288594179961L,51971489903425L,628233183645001L,7579976215410577L,91330317763703833L,1099299246068405473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019722Inst : IEnumerable<long>
{
public static readonly long[] Value=A019722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019722.Bytes);
public long this[int i]=>Value[i];

public static A019722Inst Instance=new A019722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019721
{
public static readonly long[] Value={ 9L,3L,2L,8L,7L,0L,4L,4L,7L,8L,4L,5L,0L,0L,8L,4L,3L,5L,4L,2L,0L,0L,8L,8L,1L,4L,9L,1L,2L,6L,9L,1L,8L,5L,1L,7L,2L,6L,1L,8L,6L,8L,1L,3L,4L,8L,0L,1L,2L,5L,6L,3L,8L,3L,2L,7L,0L,4L,2L,5L,1L,5L,2L,5L,5L,4L,1L,6L,3L,8L,3L,3L,9L,9L,5L,2L,8L,0L,0L,9L,5L,4L,6L,0L,5L,0L,0L,3L,4L,5L,6L,5L,1L,8L,6L,5L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019721Inst : IEnumerable<long>
{
public static readonly long[] Value=A019721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019721.Bytes);
public long this[int i]=>Value[i];

public static A019721Inst Instance=new A019721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019720
{
public static readonly long[] Value={ 9L,8L,4L,6L,9L,6L,5L,8L,3L,8L,3L,6L,3L,9L,7L,7L,9L,2L,9L,4L,3L,4L,2L,6L,3L,7L,9L,6L,3L,3L,9L,6L,9L,5L,4L,5L,9L,9L,8L,6L,3L,8L,5L,8L,6L,7L,3L,4L,6L,5L,9L,5L,1L,5L,6L,7L,4L,3L,3L,7L,6L,6L,1L,0L,2L,9L,3L,9L,5L,1L,5L,8L,1L,0L,6L,1L,2L,8L,9L,8L,9L,6L,5L,2L,7L,5L,0L,3L,6L,4L,8L,5L,4L,7L,4L,7L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019720Inst : IEnumerable<long>
{
public static readonly long[] Value=A019720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019720.Bytes);
public long this[int i]=>Value[i];

public static A019720Inst Instance=new A019720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019719
{
public static readonly long[] Value={ 1L,0L,4L,2L,6L,1L,9L,9L,1L,2L,2L,9L,7L,3L,6L,2L,3L,6L,8L,9L,9L,8L,9L,2L,2L,0L,4L,9L,0L,2L,4L,2L,0L,3L,0L,4L,8L,7L,0L,4L,4L,4L,0L,8L,5L,6L,5L,4L,2L,5L,8L,0L,6L,6L,3L,6L,5L,5L,1L,8L,1L,0L,5L,2L,8L,5L,4L,6L,5L,3L,6L,9L,6L,8L,1L,8L,2L,5L,4L,2L,2L,4L,3L,3L,8L,2L,0L,6L,2L,6L,8L,6L,6L,9L,7L,3L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019719Inst : IEnumerable<long>
{
public static readonly long[] Value=A019719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019719.Bytes);
public long this[int i]=>Value[i];

public static A019719Inst Instance=new A019719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019718
{
public static readonly long[] Value={ 1L,1L,0L,7L,7L,8L,3L,6L,5L,6L,8L,1L,5L,9L,4L,7L,5L,1L,7L,0L,6L,1L,3L,5L,4L,6L,7L,7L,0L,8L,8L,2L,1L,5L,7L,3L,9L,2L,4L,8L,4L,6L,8L,4L,1L,0L,0L,7L,6L,4L,9L,1L,9L,5L,5L,1L,3L,3L,6L,2L,9L,8L,6L,8L,6L,5L,8L,0L,6L,9L,5L,5L,2L,8L,6L,9L,3L,9L,5L,1L,1L,3L,3L,5L,9L,3L,4L,4L,1L,6L,0L,4L,6L,1L,5L,9L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019718Inst : IEnumerable<long>
{
public static readonly long[] Value=A019718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019718.Bytes);
public long this[int i]=>Value[i];

public static A019718Inst Instance=new A019718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019717
{
public static readonly long[] Value={ 1L,1L,8L,1L,6L,3L,5L,9L,0L,0L,6L,0L,3L,6L,7L,7L,3L,5L,1L,5L,3L,2L,1L,1L,1L,6L,5L,5L,5L,6L,0L,7L,6L,3L,4L,5L,5L,1L,9L,8L,3L,6L,6L,3L,0L,4L,0L,8L,1L,5L,9L,1L,4L,1L,8L,8L,0L,9L,2L,0L,5L,1L,9L,3L,2L,3L,5L,2L,7L,4L,1L,8L,9L,7L,2L,7L,3L,5L,4L,7L,8L,7L,5L,8L,3L,3L,0L,0L,4L,3L,7L,8L,2L,5L,6L,9L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019717Inst : IEnumerable<long>
{
public static readonly long[] Value=A019717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019717.Bytes);
public long this[int i]=>Value[i];

public static A019717Inst Instance=new A019717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019716
{
public static readonly long[] Value={ 1L,2L,6L,6L,0L,3L,8L,4L,6L,4L,9L,3L,2L,5L,1L,1L,4L,4L,8L,0L,7L,0L,1L,1L,9L,6L,3L,0L,9L,5L,7L,9L,6L,0L,8L,4L,4L,8L,5L,5L,3L,9L,2L,4L,6L,8L,6L,5L,8L,8L,4L,7L,9L,4L,8L,7L,2L,4L,1L,4L,8L,4L,2L,1L,3L,2L,3L,5L,0L,8L,0L,6L,0L,4L,2L,2L,1L,6L,5L,8L,4L,3L,8L,3L,9L,2L,5L,0L,4L,6L,9L,0L,9L,8L,9L,6L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019716Inst : IEnumerable<long>
{
public static readonly long[] Value=A019716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019716.Bytes);
public long this[int i]=>Value[i];

public static A019716Inst Instance=new A019716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019715
{
public static readonly long[] Value={ 1L,3L,6L,3L,4L,2L,6L,0L,3L,9L,1L,5L,8L,0L,8L,9L,2L,5L,1L,7L,6L,7L,8L,2L,1L,1L,4L,1L,0L,3L,1L,6L,5L,0L,1L,4L,0L,6L,1L,3L,4L,9L,9L,5L,8L,1L,6L,3L,2L,6L,0L,5L,4L,8L,3L,2L,4L,1L,3L,9L,0L,6L,0L,7L,5L,7L,9L,1L,6L,2L,5L,2L,6L,6L,0L,8L,4L,8L,6L,2L,9L,3L,3L,6L,5L,3L,4L,6L,6L,5L,9L,0L,2L,9L,6L,4L,9L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019715Inst : IEnumerable<long>
{
public static readonly long[] Value=A019715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019715.Bytes);
public long this[int i]=>Value[i];

public static A019715Inst Instance=new A019715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019714
{
public static readonly long[] Value={ 1L,4L,7L,7L,0L,4L,4L,8L,7L,5L,7L,5L,4L,5L,9L,6L,6L,8L,9L,4L,1L,5L,1L,3L,9L,5L,6L,9L,4L,5L,0L,9L,5L,4L,3L,1L,8L,9L,9L,7L,9L,5L,7L,8L,8L,0L,1L,0L,1L,9L,8L,9L,2L,7L,3L,5L,1L,1L,5L,0L,6L,4L,9L,1L,5L,4L,4L,0L,9L,2L,7L,3L,7L,1L,5L,9L,1L,9L,3L,4L,8L,4L,4L,7L,9L,1L,2L,5L,5L,4L,7L,2L,8L,2L,1L,2L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019714Inst : IEnumerable<long>
{
public static readonly long[] Value=A019714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019714.Bytes);
public long this[int i]=>Value[i];

public static A019714Inst Instance=new A019714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019713
{
public static readonly long[] Value={ 1L,6L,1L,1L,3L,2L,1L,6L,8L,2L,6L,4L,1L,3L,7L,8L,2L,0L,6L,6L,3L,4L,6L,9L,7L,7L,1L,2L,1L,2L,8L,3L,1L,3L,8L,0L,2L,5L,4L,3L,2L,2L,6L,7L,7L,8L,2L,9L,3L,0L,7L,9L,2L,0L,7L,4L,6L,7L,0L,9L,7L,9L,9L,0L,7L,7L,5L,3L,7L,3L,8L,9L,5L,0L,8L,2L,7L,5L,6L,5L,2L,8L,5L,2L,2L,6L,8L,2L,4L,1L,5L,2L,1L,6L,8L,5L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019713Inst : IEnumerable<long>
{
public static readonly long[] Value=A019713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019713.Bytes);
public long this[int i]=>Value[i];

public static A019713Inst Instance=new A019713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019712
{
public static readonly long[] Value={ 1L,1L,5L,4L,2L,305L,1L,8L,2L,1L,4L,6L,14L,3L,1L,13L,5L,1L,7L,23L,1L,16L,4L,1L,1L,1L,1L,1L,2L,17L,1L,3L,1L,1L,1L,29L,1L,6L,1L,3L,1L,1L,1L,1L,3L,2L,5L,1L,63L,2L,1L,2L,5L,1L,4L,11L,2L,2L,1L,1L,1L,1L,1L,2L,1L,9L,3L,3L,18L,1L,38L,2L,4L,1L,20L,3L,1L,1L,1L,5L,2L,2L,1L,1L,1L,44L,6L,3L,9L,1L,1L,1L,1L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019712Inst : IEnumerable<long>
{
public static readonly long[] Value=A019712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019712.Bytes);
public long this[int i]=>Value[i];

public static A019712Inst Instance=new A019712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019711
{
public static readonly long[] Value={ 1L,9L,6L,9L,3L,9L,3L,1L,6L,7L,6L,7L,2L,7L,9L,5L,5L,8L,5L,8L,8L,6L,8L,5L,2L,7L,5L,9L,2L,6L,7L,9L,3L,9L,0L,9L,1L,9L,9L,7L,2L,7L,7L,1L,7L,3L,4L,6L,9L,3L,1L,9L,0L,3L,1L,3L,4L,8L,6L,7L,5L,3L,2L,2L,0L,5L,8L,7L,9L,0L,3L,1L,6L,2L,1L,2L,2L,5L,7L,9L,7L,9L,3L,0L,5L,5L,0L,0L,7L,2L,9L,7L,0L,9L,4L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019711Inst : IEnumerable<long>
{
public static readonly long[] Value=A019711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019711.Bytes);
public long this[int i]=>Value[i];

public static A019711Inst Instance=new A019711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019710
{
public static readonly long[] Value={ 2L,2L,1L,5L,5L,6L,7L,3L,1L,3L,6L,3L,1L,8L,9L,5L,0L,3L,4L,1L,2L,2L,7L,0L,9L,3L,5L,4L,1L,7L,6L,4L,3L,1L,4L,7L,8L,4L,9L,6L,9L,3L,6L,8L,2L,0L,1L,5L,2L,9L,8L,3L,9L,1L,0L,2L,6L,7L,2L,5L,9L,7L,3L,7L,3L,1L,6L,1L,3L,9L,1L,0L,5L,7L,3L,8L,7L,9L,0L,2L,2L,6L,7L,1L,8L,6L,8L,8L,3L,2L,0L,9L,2L,3L,1L,8L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019710Inst : IEnumerable<long>
{
public static readonly long[] Value=A019710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019710.Bytes);
public long this[int i]=>Value[i];

public static A019710Inst Instance=new A019710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019693
{
public static readonly long[] Value={ 2L,0L,9L,4L,3L,9L,5L,1L,0L,2L,3L,9L,3L,1L,9L,5L,4L,9L,2L,3L,0L,8L,4L,2L,8L,9L,2L,2L,1L,8L,6L,3L,3L,5L,2L,5L,6L,1L,3L,1L,4L,4L,6L,2L,6L,6L,2L,5L,0L,0L,7L,0L,5L,4L,7L,3L,1L,6L,6L,2L,9L,7L,2L,8L,2L,0L,5L,2L,1L,0L,9L,3L,7L,5L,2L,4L,1L,3L,9L,3L,3L,2L,4L,1L,8L,6L,8L,9L,8L,8L,3L,5L,6L,1L,4L,1L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019693Inst : IEnumerable<long>
{
public static readonly long[] Value=A019693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019693.Bytes);
public long this[int i]=>Value[i];

public static A019693Inst Instance=new A019693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019692
{
public static readonly long[] Value={ 6L,2L,8L,3L,1L,8L,5L,3L,0L,7L,1L,7L,9L,5L,8L,6L,4L,7L,6L,9L,2L,5L,2L,8L,6L,7L,6L,6L,5L,5L,9L,0L,0L,5L,7L,6L,8L,3L,9L,4L,3L,3L,8L,7L,9L,8L,7L,5L,0L,2L,1L,1L,6L,4L,1L,9L,4L,9L,8L,8L,9L,1L,8L,4L,6L,1L,5L,6L,3L,2L,8L,1L,2L,5L,7L,2L,4L,1L,7L,9L,9L,7L,2L,5L,6L,0L,6L,9L,6L,5L,0L,6L,8L,4L,2L,3L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019692Inst : IEnumerable<long>
{
public static readonly long[] Value=A019692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019692.Bytes);
public long this[int i]=>Value[i];

public static A019692Inst Instance=new A019692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019691
{
public static readonly long[] Value={ 1L,3L,0L,8L,9L,9L,6L,9L,3L,8L,9L,9L,5L,7L,4L,7L,1L,8L,2L,6L,9L,2L,7L,6L,8L,0L,7L,6L,3L,6L,6L,4L,5L,9L,5L,3L,5L,0L,8L,2L,1L,5L,3L,9L,1L,6L,4L,0L,6L,2L,9L,4L,0L,9L,2L,0L,7L,2L,8L,9L,3L,5L,8L,0L,1L,2L,8L,2L,5L,6L,8L,3L,5L,9L,5L,2L,5L,8L,7L,0L,8L,2L,7L,6L,1L,6L,8L,1L,1L,7L,7L,2L,2L,5L,8L,8L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019691Inst : IEnumerable<long>
{
public static readonly long[] Value=A019691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019691.Bytes);
public long this[int i]=>Value[i];

public static A019691Inst Instance=new A019691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019690
{
public static readonly long[] Value={ 1L,3L,6L,5L,9L,0L,9L,8L,4L,9L,3L,8L,6L,8L,6L,6L,6L,2L,5L,4L,1L,8L,5L,4L,0L,6L,0L,1L,4L,2L,5L,8L,7L,0L,8L,1L,9L,2L,1L,6L,1L,6L,0L,6L,0L,8L,4L,2L,3L,9L,5L,9L,0L,5L,2L,5L,9L,7L,8L,0L,1L,9L,9L,6L,6L,5L,5L,5L,7L,2L,3L,5L,0L,5L,5L,9L,2L,2L,1L,3L,0L,3L,7L,5L,1L,3L,1L,9L,4L,8L,9L,2L,7L,9L,1L,8L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019690Inst : IEnumerable<long>
{
public static readonly long[] Value=A019690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019690.Bytes);
public long this[int i]=>Value[i];

public static A019690Inst Instance=new A019690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019689
{
public static readonly long[] Value={ 1L,4L,2L,7L,9L,9L,6L,6L,6L,0L,7L,2L,2L,6L,3L,3L,2L,9L,0L,2L,1L,0L,2L,9L,2L,4L,4L,6L,9L,4L,5L,2L,2L,8L,5L,8L,3L,7L,2L,5L,9L,8L,6L,0L,9L,0L,6L,2L,5L,0L,4L,8L,1L,0L,0L,4L,4L,3L,1L,5L,6L,6L,3L,2L,8L,6L,7L,1L,8L,9L,2L,7L,5L,5L,8L,4L,6L,4L,0L,4L,5L,3L,9L,2L,1L,8L,3L,4L,0L,1L,1L,5L,1L,9L,1L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019689Inst : IEnumerable<long>
{
public static readonly long[] Value=A019689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019689.Bytes);
public long this[int i]=>Value[i];

public static A019689Inst Instance=new A019689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019688
{
public static readonly long[] Value={ 1L,4L,9L,5L,9L,9L,6L,5L,0L,1L,7L,0L,9L,4L,2L,5L,3L,5L,1L,6L,4L,8L,8L,7L,7L,8L,0L,1L,5L,6L,1L,6L,6L,8L,0L,4L,0L,0L,9L,3L,8L,9L,0L,1L,9L,0L,1L,7L,8L,6L,2L,1L,8L,1L,9L,5L,1L,1L,8L,7L,8L,3L,7L,7L,2L,8L,9L,4L,3L,6L,3L,8L,3L,9L,4L,5L,8L,1L,3L,8L,0L,8L,8L,7L,0L,4L,9L,2L,7L,7L,3L,9L,7L,2L,4L,3L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019688Inst : IEnumerable<long>
{
public static readonly long[] Value=A019688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019688.Bytes);
public long this[int i]=>Value[i];

public static A019688Inst Instance=new A019688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019687
{
public static readonly BigInteger[] Value={ 1L,24L,397L,5628L,73513L,914112L,11008549L,129690276L,1504024705L,17241418920L,195930981181L,2211723344844L,24837316537177L,277785786712848L,3096821665511893L,34435641499407732L,382127489397444529L,4233421296687394296L,BigInteger.Parse("46837804552120354285") };
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
public class A019687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019687Inst Instance=new A019687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019686
{
public static readonly long[] Value={ 1L,6L,5L,3L,4L,6L,9L,8L,1L,7L,6L,7L,8L,8L,3L,8L,5L,4L,6L,5L,5L,9L,2L,8L,5L,9L,9L,1L,1L,9L,9L,7L,3L,8L,3L,6L,0L,1L,0L,3L,7L,7L,3L,3L,6L,8L,0L,9L,2L,1L,6L,0L,9L,5L,8L,4L,0L,7L,8L,6L,5L,5L,7L,4L,8L,9L,8L,8L,5L,0L,7L,4L,0L,1L,5L,0L,6L,3L,6L,3L,1L,5L,0L,6L,7L,3L,8L,6L,7L,5L,0L,1L,8L,0L,0L,6L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019686Inst : IEnumerable<long>
{
public static readonly long[] Value=A019686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019686.Bytes);
public long this[int i]=>Value[i];

public static A019686Inst Instance=new A019686Inst();

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