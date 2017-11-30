using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021865
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L,1L,8L,5L,8L,3L,0L,4L,2L,9L,7L,3L,2L,8L,6L,8L,7L,5L,7L,2L,5L,9L,0L,0L,1L,1L,6L,1L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021865Inst : IEnumerable<long>
{
public static readonly long[] Value=A021865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021865.Bytes);
public long this[int i]=>Value[i];

public static A021865Inst Instance=new A021865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021864
{
public static readonly long[] Value={ 1L,21L,294L,3466L,37275L,379407L,3727648L,35761572L,337430709L,3146261833L,29083452762L,267126341118L,2441786303503L,22239710844099L,202003194298836L,1830950757258904L,16569016601938857L,149754390830203005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021864Inst : IEnumerable<long>
{
public static readonly long[] Value=A021864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021864.Bytes);
public long this[int i]=>Value[i];

public static A021864Inst Instance=new A021864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021863
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L,5L,6L,4L,6L,1L,0L,0L,1L,1L,6L,4L,1L,4L,4L,3L,5L,3L,8L,9L,9L,8L,8L,3L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021863Inst : IEnumerable<long>
{
public static readonly long[] Value=A021863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021863.Bytes);
public long this[int i]=>Value[i];

public static A021863Inst Instance=new A021863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021862
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L,1L,6L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021862Inst : IEnumerable<long>
{
public static readonly long[] Value=A021862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021862.Bytes);
public long this[int i]=>Value[i];

public static A021862Inst Instance=new A021862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021861
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,6L,8L,6L,1L,1L,4L,3L,5L,2L,3L,9L,2L,0L,6L,5L,3L,4L,4L,2L,2L,4L,0L,3L,7L,3L,3L,9L,5L,5L,6L,5L,9L,2L,7L,6L,5L,4L,6L,0L,9L,1L,0L,1L,5L,1L,6L,9L,1L,9L,4L,8L,6L,5L,8L,1L,0L,9L,6L,8L,4L,9L,4L,7L,4L,9L,1L,2L,4L,8L,5L,4L,1L,4L,2L,3L,5L,7L,0L,5L,9L,5L,0L,9L,9L,1L,8L,3L,1L,9L,7L,1L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021861Inst : IEnumerable<long>
{
public static readonly long[] Value=A021861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021861.Bytes);
public long this[int i]=>Value[i];

public static A021861Inst Instance=new A021861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021860
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021860Inst : IEnumerable<long>
{
public static readonly long[] Value=A021860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021860.Bytes);
public long this[int i]=>Value[i];

public static A021860Inst Instance=new A021860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021859
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L,6L,4L,3L,2L,7L,4L,8L,5L,3L,8L,0L,1L,1L,6L,9L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021859Inst : IEnumerable<long>
{
public static readonly long[] Value=A021859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021859.Bytes);
public long this[int i]=>Value[i];

public static A021859Inst Instance=new A021859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021858
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,0L,9L,6L,0L,1L,8L,7L,3L,5L,3L,6L,2L,9L,9L,7L,6L,5L,8L,0L,7L,9L,6L,2L,5L,2L,9L,2L,7L,4L,0L,0L,4L,6L,8L,3L,8L,4L,0L,7L,4L,9L,4L,1L,4L,5L,1L,9L,9L,0L,6L,3L,2L,3L,1L,8L,5L,0L,1L,1L,7L,0L,9L,6L,0L,1L,8L,7L,3L,5L,3L,6L,2L,9L,9L,7L,6L,5L,8L,0L,7L,9L,6L,2L,5L,2L,9L,2L,7L,4L,0L,0L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021858Inst : IEnumerable<long>
{
public static readonly long[] Value=A021858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021858.Bytes);
public long this[int i]=>Value[i];

public static A021858Inst Instance=new A021858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021857
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,2L,3L,3L,2L,9L,4L,2L,5L,5L,5L,6L,8L,5L,8L,1L,4L,7L,7L,1L,3L,9L,5L,0L,7L,6L,2L,0L,1L,6L,4L,1L,2L,6L,6L,1L,1L,9L,5L,7L,7L,9L,6L,0L,1L,4L,0L,6L,7L,9L,9L,5L,3L,1L,0L,6L,6L,8L,2L,2L,9L,7L,7L,7L,2L,5L,6L,7L,4L,0L,9L,1L,4L,4L,1L,9L,6L,9L,5L,1L,9L,3L,4L,3L,4L,9L,3L,5L,5L,2L,1L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021857Inst : IEnumerable<long>
{
public static readonly long[] Value=A021857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021857.Bytes);
public long this[int i]=>Value[i];

public static A021857Inst Instance=new A021857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021856
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L,8L,3L,5L,6L,8L,0L,7L,5L,1L,1L,7L,3L,7L,0L,8L,9L,2L,0L,1L,8L,7L,7L,9L,3L,4L,2L,7L,2L,3L,0L,0L,4L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021856Inst : IEnumerable<long>
{
public static readonly long[] Value=A021856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021856.Bytes);
public long this[int i]=>Value[i];

public static A021856Inst Instance=new A021856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021855
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,5L,0L,8L,8L,1L,3L,1L,6L,0L,9L,8L,7L,0L,7L,4L,0L,3L,0L,5L,5L,2L,2L,9L,1L,4L,2L,1L,8L,5L,6L,6L,3L,9L,2L,4L,7L,9L,4L,3L,5L,9L,5L,7L,6L,9L,6L,8L,2L,7L,2L,6L,2L,0L,4L,4L,6L,5L,3L,3L,4L,9L,0L,0L,1L,1L,7L,5L,0L,8L,8L,1L,3L,1L,6L,0L,9L,8L,7L,0L,7L,4L,0L,3L,0L,5L,5L,2L,2L,9L,1L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021855Inst : IEnumerable<long>
{
public static readonly long[] Value=A021855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021855.Bytes);
public long this[int i]=>Value[i];

public static A021855Inst Instance=new A021855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021854
{
public static readonly long[] Value={ 1L,20L,265L,2940L,29601L,280740L,2558905L,22683980L,197048401L,1685772660L,14253277545L,119401486620L,992861126401L,8206523123780L,67497981692185L,552905862106860L,4513706683463601L,36742894880462100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021854Inst : IEnumerable<long>
{
public static readonly long[] Value=A021854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021854.Bytes);
public long this[int i]=>Value[i];

public static A021854Inst Instance=new A021854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021837
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,0L,4L,8L,0L,1L,9L,2L,0L,7L,6L,8L,3L,0L,7L,3L,2L,2L,9L,2L,9L,1L,7L,1L,6L,6L,8L,6L,6L,7L,4L,6L,6L,9L,8L,6L,7L,9L,4L,7L,1L,7L,8L,8L,7L,1L,5L,4L,8L,6L,1L,9L,4L,4L,7L,7L,7L,9L,1L,1L,1L,6L,4L,4L,6L,5L,7L,8L,6L,3L,1L,4L,5L,2L,5L,8L,1L,0L,3L,2L,4L,1L,2L,9L,6L,5L,1L,8L,6L,0L,7L,4L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021837Inst : IEnumerable<long>
{
public static readonly long[] Value=A021837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021837.Bytes);
public long this[int i]=>Value[i];

public static A021837Inst Instance=new A021837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021836
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021836Inst : IEnumerable<long>
{
public static readonly long[] Value=A021836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021836.Bytes);
public long this[int i]=>Value[i];

public static A021836Inst Instance=new A021836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021835
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,3L,6L,9L,4L,3L,4L,4L,1L,6L,3L,6L,5L,8L,2L,4L,3L,0L,8L,0L,6L,2L,5L,7L,5L,2L,1L,0L,5L,8L,9L,6L,5L,1L,0L,2L,2L,8L,6L,4L,0L,1L,9L,2L,5L,3L,9L,1L,0L,9L,5L,0L,6L,6L,1L,8L,5L,3L,1L,8L,8L,9L,2L,9L,0L,0L,1L,2L,0L,3L,3L,6L,9L,4L,3L,4L,4L,1L,6L,3L,6L,5L,8L,2L,4L,3L,0L,8L,0L,6L,2L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021835Inst : IEnumerable<long>
{
public static readonly long[] Value=A021835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021835.Bytes);
public long this[int i]=>Value[i];

public static A021835Inst Instance=new A021835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021834
{
public static readonly long[] Value={ 1L,22L,329L,4226L,50469L,580422L,6541681L,72922570L,808020125L,8923802030L,98376704361L,1083438632562L,11925616635349L,131228622530326L,1443796242996449L,15883448475593882L,174728077773953421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021834Inst : IEnumerable<long>
{
public static readonly long[] Value=A021834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021834.Bytes);
public long this[int i]=>Value[i];

public static A021834Inst Instance=new A021834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021833
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,6L,2L,7L,2L,6L,1L,7L,6L,1L,1L,5L,8L,0L,2L,1L,7L,1L,2L,9L,0L,7L,1L,1L,7L,0L,0L,8L,4L,4L,3L,9L,0L,8L,3L,2L,3L,2L,8L,1L,0L,6L,1L,5L,1L,9L,9L,0L,3L,4L,9L,8L,1L,9L,0L,5L,9L,1L,0L,7L,3L,5L,8L,2L,6L,2L,9L,6L,7L,4L,3L,0L,6L,3L,9L,3L,2L,4L,4L,8L,7L,3L,3L,4L,1L,3L,7L,5L,1L,5L,0L,7L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021833Inst : IEnumerable<long>
{
public static readonly long[] Value=A021833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021833.Bytes);
public long this[int i]=>Value[i];

public static A021833Inst Instance=new A021833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021832
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L,8L,5L,9L,9L,0L,3L,3L,8L,1L,6L,4L,2L,5L,1L,2L,0L,7L,7L,2L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021832Inst : IEnumerable<long>
{
public static readonly long[] Value=A021832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021832.Bytes);
public long this[int i]=>Value[i];

public static A021832Inst Instance=new A021832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021831
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,9L,1L,8L,9L,8L,4L,2L,8L,0L,5L,3L,2L,0L,4L,3L,5L,3L,0L,8L,3L,4L,3L,4L,0L,9L,9L,1L,5L,3L,5L,6L,7L,1L,1L,0L,0L,3L,6L,2L,7L,5L,6L,9L,5L,2L,8L,4L,1L,5L,9L,6L,1L,3L,0L,5L,9L,2L,5L,0L,3L,0L,2L,2L,9L,7L,4L,6L,0L,7L,0L,1L,3L,3L,0L,1L,0L,8L,8L,2L,7L,0L,8L,5L,8L,5L,2L,4L,7L,8L,8L,3L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021831Inst : IEnumerable<long>
{
public static readonly long[] Value=A021831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021831.Bytes);
public long this[int i]=>Value[i];

public static A021831Inst Instance=new A021831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021830
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,0L,6L,5L,3L,7L,5L,3L,0L,2L,6L,6L,3L,4L,3L,8L,2L,5L,6L,6L,5L,8L,5L,9L,5L,6L,4L,1L,6L,4L,6L,4L,8L,9L,1L,0L,4L,1L,1L,6L,2L,2L,2L,7L,6L,0L,2L,9L,0L,5L,5L,6L,9L,0L,0L,7L,2L,6L,3L,9L,2L,2L,5L,1L,8L,1L,5L,9L,8L,0L,6L,2L,9L,5L,3L,9L,9L,5L,1L,5L,7L,3L,8L,4L,9L,8L,7L,8L,9L,3L,4L,6L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021830Inst : IEnumerable<long>
{
public static readonly long[] Value=A021830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021830.Bytes);
public long this[int i]=>Value[i];

public static A021830Inst Instance=new A021830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021829
{
public static readonly long[] Value={ 1L,21L,297L,3577L,39753L,422793L,4384969L,44813769L,454009545L,4575676105L,45971643081L,461011315401L,4617904831177L,46225887853257L,462540273695433L,4627092539587273L,46281069938293449L,462871589543951049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021829Inst : IEnumerable<long>
{
public static readonly long[] Value=A021829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021829.Bytes);
public long this[int i]=>Value[i];

public static A021829Inst Instance=new A021829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021828
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021828Inst : IEnumerable<long>
{
public static readonly long[] Value=A021828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021828.Bytes);
public long this[int i]=>Value[i];

public static A021828Inst Instance=new A021828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021827
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,5L,0L,6L,6L,8L,2L,8L,6L,7L,5L,5L,7L,7L,1L,5L,6L,7L,4L,3L,6L,2L,0L,8L,9L,9L,1L,4L,9L,4L,5L,3L,2L,1L,9L,9L,2L,7L,0L,9L,5L,9L,9L,0L,2L,7L,9L,4L,6L,5L,3L,7L,0L,5L,9L,5L,3L,8L,2L,7L,4L,6L,0L,5L,1L,0L,3L,2L,8L,0L,6L,8L,0L,4L,3L,7L,4L,2L,4L,0L,5L,8L,3L,2L,3L,2L,0L,7L,7L,7L,6L,4L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021827Inst : IEnumerable<long>
{
public static readonly long[] Value=A021827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021827.Bytes);
public long this[int i]=>Value[i];

public static A021827Inst Instance=new A021827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021826
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021826Inst : IEnumerable<long>
{
public static readonly long[] Value=A021826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021826.Bytes);
public long this[int i]=>Value[i];

public static A021826Inst Instance=new A021826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021825
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,8L,0L,2L,6L,7L,9L,6L,5L,8L,9L,5L,2L,4L,9L,6L,9L,5L,4L,9L,3L,3L,0L,0L,8L,5L,2L,6L,1L,8L,7L,5L,7L,6L,1L,2L,6L,6L,7L,4L,7L,8L,6L,8L,4L,5L,3L,1L,0L,5L,9L,6L,8L,3L,3L,1L,3L,0L,3L,2L,8L,8L,6L,7L,2L,3L,5L,0L,7L,9L,1L,7L,1L,7L,4L,1L,7L,7L,8L,3L,1L,9L,1L,2L,3L,0L,2L,0L,7L,0L,6L,4L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021825Inst : IEnumerable<long>
{
public static readonly long[] Value=A021825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021825.Bytes);
public long this[int i]=>Value[i];

public static A021825Inst Instance=new A021825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021824
{
public static readonly long[] Value={ 1L,20L,267L,3010L,31073L,304920L,2901319L,27075950L,249555405L,2281579300L,20749095731L,188036746170L,1700122392697L,15347941075760L,138412864844703L,1247405586235270L,11236794818538149L,101192043527859900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021824Inst : IEnumerable<long>
{
public static readonly long[] Value=A021824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021824.Bytes);
public long this[int i]=>Value[i];

public static A021824Inst Instance=new A021824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021823
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021823Inst : IEnumerable<long>
{
public static readonly long[] Value=A021823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021823.Bytes);
public long this[int i]=>Value[i];

public static A021823Inst Instance=new A021823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021822
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,9L,3L,8L,8L,7L,5L,3L,0L,5L,6L,2L,3L,4L,7L,1L,8L,8L,2L,6L,4L,0L,5L,8L,6L,7L,9L,7L,0L,6L,6L,0L,1L,4L,6L,6L,9L,9L,2L,6L,6L,5L,0L,3L,6L,6L,7L,4L,8L,1L,6L,6L,2L,5L,9L,1L,6L,8L,7L,0L,4L,1L,5L,6L,4L,7L,9L,2L,1L,7L,6L,0L,3L,9L,1L,1L,9L,8L,0L,4L,4L,0L,0L,9L,7L,7L,9L,9L,5L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021822Inst : IEnumerable<long>
{
public static readonly long[] Value=A021822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021822.Bytes);
public long this[int i]=>Value[i];

public static A021822Inst Instance=new A021822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021805
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L,0L,6L,8L,6L,6L,4L,1L,6L,9L,7L,8L,7L,7L,6L,5L,2L,9L,3L,3L,8L,3L,2L,7L,0L,9L,1L,1L,3L,6L,0L,7L,9L,9L,0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L,0L,6L,8L,6L,6L,4L,1L,6L,9L,7L,8L,7L,7L,6L,5L,2L,9L,3L,3L,8L,3L,2L,7L,0L,9L,1L,1L,3L,6L,0L,7L,9L,9L,0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021805Inst : IEnumerable<long>
{
public static readonly long[] Value=A021805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021805.Bytes);
public long this[int i]=>Value[i];

public static A021805Inst Instance=new A021805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021804
{
public static readonly long[] Value={ 1L,18L,213L,2098L,18669L,155946L,1248661L,9704706L,73804797L,552214234L,4080381669L,29857556274L,216794571085L,1564401539082L,11232205936437L,80315244188002L,572351251736733L,4067348923173690L,28836875054284165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021804Inst : IEnumerable<long>
{
public static readonly long[] Value=A021804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021804.Bytes);
public long this[int i]=>Value[i];

public static A021804Inst Instance=new A021804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021803
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,1L,5L,6L,4L,4L,5L,5L,5L,6L,9L,4L,6L,1L,8L,2L,7L,2L,8L,4L,1L,0L,5L,1L,3L,1L,4L,1L,4L,2L,6L,7L,8L,3L,4L,7L,9L,3L,4L,9L,1L,8L,6L,4L,8L,3L,1L,0L,3L,8L,7L,9L,8L,4L,9L,8L,1L,2L,2L,6L,5L,3L,3L,1L,6L,6L,4L,5L,8L,0L,7L,2L,5L,9L,0L,7L,3L,8L,4L,2L,3L,0L,2L,8L,7L,8L,5L,9L,8L,2L,4L,7L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021803Inst : IEnumerable<long>
{
public static readonly long[] Value=A021803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021803.Bytes);
public long this[int i]=>Value[i];

public static A021803Inst Instance=new A021803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021802
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021802Inst : IEnumerable<long>
{
public static readonly long[] Value=A021802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021802.Bytes);
public long this[int i]=>Value[i];

public static A021802Inst Instance=new A021802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021801
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,4L,7L,0L,5L,1L,4L,4L,2L,9L,1L,0L,9L,1L,5L,9L,3L,4L,7L,5L,5L,3L,3L,2L,4L,9L,6L,8L,6L,3L,2L,3L,7L,1L,3L,9L,2L,7L,2L,2L,7L,1L,0L,1L,6L,3L,1L,1L,1L,6L,6L,8L,7L,5L,7L,8L,4L,1L,9L,0L,7L,1L,5L,1L,8L,1L,9L,3L,2L,2L,4L,5L,9L,2L,2L,2L,0L,8L,2L,8L,1L,0L,5L,3L,9L,5L,2L,3L,2L,1L,2L,0L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021801Inst : IEnumerable<long>
{
public static readonly long[] Value=A021801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021801.Bytes);
public long this[int i]=>Value[i];

public static A021801Inst Instance=new A021801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021800
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L,2L,0L,1L,0L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021800Inst : IEnumerable<long>
{
public static readonly long[] Value=A021800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021800.Bytes);
public long this[int i]=>Value[i];

public static A021800Inst Instance=new A021800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021799
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021799Inst : IEnumerable<long>
{
public static readonly long[] Value=A021799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021799.Bytes);
public long this[int i]=>Value[i];

public static A021799Inst Instance=new A021799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021798
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,9L,4L,4L,5L,8L,4L,3L,8L,2L,8L,7L,1L,5L,3L,6L,5L,2L,3L,9L,2L,9L,4L,7L,1L,0L,3L,2L,7L,4L,5L,5L,9L,1L,9L,3L,9L,5L,4L,6L,5L,9L,9L,4L,9L,6L,2L,2L,1L,6L,6L,2L,4L,6L,8L,5L,1L,3L,8L,5L,3L,9L,0L,4L,2L,8L,2L,1L,1L,5L,8L,6L,9L,0L,1L,7L,6L,3L,2L,2L,4L,1L,8L,1L,3L,6L,0L,2L,0L,1L,5L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021798Inst : IEnumerable<long>
{
public static readonly long[] Value=A021798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021798.Bytes);
public long this[int i]=>Value[i];

public static A021798Inst Instance=new A021798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021797
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,1L,0L,3L,4L,0L,4L,7L,9L,1L,9L,2L,9L,3L,8L,2L,0L,9L,3L,3L,1L,6L,5L,1L,9L,5L,4L,6L,0L,2L,7L,7L,4L,2L,7L,4L,9L,0L,5L,4L,2L,2L,4L,4L,6L,4L,0L,6L,0L,5L,2L,9L,6L,3L,4L,3L,0L,0L,1L,2L,6L,1L,0L,3L,4L,0L,4L,7L,9L,1L,9L,2L,9L,3L,8L,2L,0L,9L,3L,3L,1L,6L,5L,1L,9L,5L,4L,6L,0L,2L,7L,7L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021797Inst : IEnumerable<long>
{
public static readonly long[] Value=A021797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021797.Bytes);
public long this[int i]=>Value[i];

public static A021797Inst Instance=new A021797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021796
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021796Inst : IEnumerable<long>
{
public static readonly long[] Value=A021796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021796.Bytes);
public long this[int i]=>Value[i];

public static A021796Inst Instance=new A021796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021795
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,4L,2L,2L,2L,5L,0L,3L,1L,6L,0L,5L,5L,6L,2L,5L,7L,9L,0L,1L,3L,9L,0L,6L,4L,4L,7L,5L,3L,4L,7L,6L,6L,1L,1L,8L,8L,3L,6L,9L,1L,5L,2L,9L,7L,0L,9L,2L,2L,8L,8L,2L,4L,2L,7L,3L,0L,7L,2L,0L,6L,0L,6L,8L,2L,6L,8L,0L,1L,5L,1L,7L,0L,6L,7L,0L,0L,3L,7L,9L,2L,6L,6L,7L,5L,0L,9L,4L,8L,1L,6L,6L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021795Inst : IEnumerable<long>
{
public static readonly long[] Value=A021795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021795.Bytes);
public long this[int i]=>Value[i];

public static A021795Inst Instance=new A021795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021794
{
public static readonly long[] Value={ 1L,22L,335L,4460L,56061L,686802L,8317435L,100210120L,1204613321L,14466168782L,173649468135L,2084076423780L,25010353485781L,300131513309962L,3601614875036435L,43219563508677440L,518635692871953441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021794Inst : IEnumerable<long>
{
public static readonly long[] Value=A021794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021794.Bytes);
public long this[int i]=>Value[i];

public static A021794Inst Instance=new A021794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021793
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,7L,4L,2L,7L,1L,2L,2L,9L,4L,0L,4L,3L,0L,9L,2L,5L,2L,2L,1L,7L,9L,9L,7L,4L,6L,5L,1L,4L,5L,7L,5L,4L,1L,1L,9L,1L,3L,8L,1L,4L,9L,5L,5L,6L,4L,0L,0L,5L,0L,6L,9L,7L,0L,8L,4L,9L,1L,7L,6L,1L,7L,2L,3L,7L,0L,0L,8L,8L,7L,1L,9L,8L,9L,8L,6L,0L,5L,8L,3L,0L,1L,6L,4L,7L,6L,5L,5L,2L,5L,9L,8L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021793Inst : IEnumerable<long>
{
public static readonly long[] Value=A021793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021793.Bytes);
public long this[int i]=>Value[i];

public static A021793Inst Instance=new A021793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021792
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,9L,0L,3L,5L,5L,3L,2L,9L,9L,4L,9L,2L,3L,8L,5L,7L,8L,6L,8L,0L,2L,0L,3L,0L,4L,5L,6L,8L,5L,2L,7L,9L,1L,8L,7L,8L,1L,7L,2L,5L,8L,8L,8L,3L,2L,4L,8L,7L,3L,0L,9L,6L,4L,4L,6L,7L,0L,0L,5L,0L,7L,6L,1L,4L,2L,1L,3L,1L,9L,7L,9L,6L,9L,5L,4L,3L,1L,4L,7L,2L,0L,8L,1L,2L,1L,8L,2L,7L,4L,1L,1L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021792Inst : IEnumerable<long>
{
public static readonly long[] Value=A021792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021792.Bytes);
public long this[int i]=>Value[i];

public static A021792Inst Instance=new A021792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021791
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,0L,6L,4L,8L,0L,3L,0L,4L,9L,5L,5L,5L,2L,7L,3L,1L,8L,9L,3L,2L,6L,5L,5L,6L,5L,4L,3L,8L,3L,7L,3L,5L,7L,0L,5L,2L,0L,9L,6L,5L,6L,9L,2L,5L,0L,3L,1L,7L,6L,6L,2L,0L,0L,7L,6L,2L,3L,8L,8L,8L,1L,8L,2L,9L,7L,3L,3L,1L,6L,3L,9L,1L,3L,5L,9L,5L,9L,3L,3L,9L,2L,6L,3L,0L,2L,4L,1L,4L,2L,3L,1L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021791Inst : IEnumerable<long>
{
public static readonly long[] Value=A021791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021791.Bytes);
public long this[int i]=>Value[i];

public static A021791Inst Instance=new A021791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021790
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,2L,2L,6L,4L,6L,3L,1L,0L,4L,3L,2L,5L,6L,9L,9L,7L,4L,5L,5L,4L,7L,0L,7L,3L,7L,9L,1L,3L,4L,8L,6L,0L,0L,5L,0L,8L,9L,0L,5L,8L,5L,2L,4L,1L,7L,3L,0L,2L,7L,9L,8L,9L,8L,2L,1L,8L,8L,2L,9L,5L,1L,6L,5L,3L,9L,4L,4L,0L,2L,0L,3L,5L,6L,2L,3L,4L,0L,9L,6L,6L,9L,2L,1L,1L,1L,9L,5L,9L,2L,8L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021790Inst : IEnumerable<long>
{
public static readonly long[] Value=A021790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021790.Bytes);
public long this[int i]=>Value[i];

public static A021790Inst Instance=new A021790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021789
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,3L,8L,8L,5L,3L,5L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L,5L,7L,9L,6L,1L,7L,8L,3L,4L,3L,9L,4L,9L,0L,4L,4L,5L,8L,5L,9L,8L,7L,2L,6L,1L,1L,4L,6L,4L,9L,6L,8L,1L,5L,2L,8L,6L,6L,2L,4L,2L,0L,3L,8L,2L,1L,6L,5L,6L,0L,5L,0L,9L,5L,5L,4L,1L,4L,0L,1L,2L,7L,3L,8L,8L,5L,3L,5L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021789Inst : IEnumerable<long>
{
public static readonly long[] Value=A021789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021789.Bytes);
public long this[int i]=>Value[i];

public static A021789Inst Instance=new A021789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021788
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021788Inst : IEnumerable<long>
{
public static readonly long[] Value=A021788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021788.Bytes);
public long this[int i]=>Value[i];

public static A021788Inst Instance=new A021788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021787
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,7L,1L,3L,9L,2L,0L,8L,1L,7L,3L,6L,9L,0L,9L,3L,2L,3L,1L,1L,6L,2L,1L,9L,6L,6L,7L,9L,4L,3L,8L,0L,5L,8L,7L,4L,8L,4L,0L,3L,5L,7L,5L,9L,8L,9L,7L,8L,2L,8L,8L,6L,3L,3L,4L,6L,1L,0L,4L,7L,2L,5L,4L,1L,5L,0L,7L,0L,2L,4L,2L,6L,5L,6L,4L,4L,9L,5L,5L,3L,0L,0L,1L,2L,7L,7L,1L,3L,9L,2L,0L,8L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021787Inst : IEnumerable<long>
{
public static readonly long[] Value=A021787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021787.Bytes);
public long this[int i]=>Value[i];

public static A021787Inst Instance=new A021787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021786
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,8L,7L,7L,2L,3L,7L,8L,5L,1L,6L,6L,2L,4L,0L,4L,0L,9L,2L,0L,7L,1L,6L,1L,1L,2L,5L,3L,1L,9L,6L,9L,3L,0L,9L,4L,6L,2L,9L,1L,5L,6L,0L,1L,0L,2L,3L,0L,1L,7L,9L,0L,2L,8L,1L,3L,2L,9L,9L,2L,3L,2L,7L,3L,6L,5L,7L,2L,8L,9L,0L,0L,2L,5L,5L,7L,5L,4L,4L,7L,5L,7L,0L,3L,3L,2L,4L,8L,0L,8L,1L,8L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021786Inst : IEnumerable<long>
{
public static readonly long[] Value=A021786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021786.Bytes);
public long this[int i]=>Value[i];

public static A021786Inst Instance=new A021786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021785
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,0L,4L,0L,9L,7L,3L,1L,1L,1L,3L,9L,5L,6L,4L,6L,6L,0L,6L,9L,1L,4L,2L,1L,2L,5L,4L,8L,0L,1L,5L,3L,6L,4L,9L,1L,6L,7L,7L,3L,3L,6L,7L,4L,7L,7L,5L,9L,2L,8L,2L,9L,7L,0L,5L,5L,0L,5L,7L,6L,1L,8L,4L,3L,7L,9L,0L,0L,1L,2L,8L,0L,4L,0L,9L,7L,3L,1L,1L,1L,3L,9L,5L,6L,4L,6L,6L,0L,6L,9L,1L,4L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021785Inst : IEnumerable<long>
{
public static readonly long[] Value=A021785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021785.Bytes);
public long this[int i]=>Value[i];

public static A021785Inst Instance=new A021785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021784
{
public static readonly long[] Value={ 1L,21L,302L,3762L,43923L,497223L,5545264L,61398804L,677478725L,7463074905L,82149266706L,903924739926L,9944608539607L,109397965416267L,1203414334895828L,13237742692094328L,145616100380861769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021784Inst : IEnumerable<long>
{
public static readonly long[] Value=A021784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021784.Bytes);
public long this[int i]=>Value[i];

public static A021784Inst Instance=new A021784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021783
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,3L,6L,9L,7L,0L,4L,7L,4L,9L,6L,7L,9L,0L,7L,5L,7L,3L,8L,1L,2L,5L,8L,0L,2L,3L,1L,0L,6L,5L,4L,6L,8L,5L,4L,9L,4L,2L,2L,3L,3L,6L,3L,2L,8L,6L,2L,6L,4L,4L,4L,1L,5L,9L,1L,7L,8L,4L,3L,3L,8L,8L,9L,6L,0L,2L,0L,5L,3L,9L,1L,5L,2L,7L,5L,9L,9L,4L,8L,6L,5L,2L,1L,1L,8L,1L,0L,0L,1L,2L,8L,3L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021783Inst : IEnumerable<long>
{
public static readonly long[] Value=A021783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021783.Bytes);
public long this[int i]=>Value[i];

public static A021783Inst Instance=new A021783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021782
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,5L,3L,4L,7L,0L,4L,3L,7L,0L,1L,7L,9L,9L,4L,8L,5L,8L,6L,1L,1L,8L,2L,5L,1L,9L,2L,8L,0L,2L,0L,5L,6L,5L,5L,5L,2L,6L,9L,9L,2L,2L,8L,7L,9L,1L,7L,7L,3L,7L,7L,8L,9L,2L,0L,3L,0L,8L,4L,8L,3L,2L,9L,0L,4L,8L,8L,4L,3L,1L,8L,7L,6L,6L,0L,6L,6L,8L,3L,8L,0L,4L,6L,2L,7L,2L,4L,9L,3L,5L,7L,3L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021782Inst : IEnumerable<long>
{
public static readonly long[] Value=A021782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021782.Bytes);
public long this[int i]=>Value[i];

public static A021782Inst Instance=new A021782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021781
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L,2L,8L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021781Inst : IEnumerable<long>
{
public static readonly long[] Value=A021781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021781.Bytes);
public long this[int i]=>Value[i];

public static A021781Inst Instance=new A021781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021780
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021780Inst : IEnumerable<long>
{
public static readonly long[] Value=A021780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021780.Bytes);
public long this[int i]=>Value[i];

public static A021780Inst Instance=new A021780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021779
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021779Inst : IEnumerable<long>
{
public static readonly long[] Value=A021779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021779.Bytes);
public long this[int i]=>Value[i];

public static A021779Inst Instance=new A021779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021778
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L,6L,8L,7L,3L,3L,8L,5L,0L,1L,2L,9L,1L,9L,8L,9L,6L,6L,4L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021778Inst : IEnumerable<long>
{
public static readonly long[] Value=A021778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021778.Bytes);
public long this[int i]=>Value[i];

public static A021778Inst Instance=new A021778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021777
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,3L,6L,6L,1L,0L,6L,0L,8L,0L,2L,0L,6L,9L,8L,5L,7L,6L,9L,7L,2L,8L,3L,3L,1L,1L,7L,7L,2L,3L,1L,5L,6L,5L,3L,2L,9L,8L,8L,3L,5L,7L,0L,5L,0L,4L,5L,2L,7L,8L,1L,3L,7L,1L,2L,8L,0L,7L,2L,4L,4L,5L,0L,1L,9L,4L,0L,4L,9L,1L,5L,9L,1L,2L,0L,3L,1L,0L,4L,7L,8L,6L,5L,4L,5L,9L,2L,4L,9L,6L,7L,6L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021777Inst : IEnumerable<long>
{
public static readonly long[] Value=A021777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021777.Bytes);
public long this[int i]=>Value[i];

public static A021777Inst Instance=new A021777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021776
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L,9L,6L,3L,7L,3L,0L,5L,6L,9L,9L,4L,8L,1L,8L,6L,5L,2L,8L,4L,9L,7L,4L,0L,9L,3L,2L,6L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021776Inst : IEnumerable<long>
{
public static readonly long[] Value=A021776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021776.Bytes);
public long this[int i]=>Value[i];

public static A021776Inst Instance=new A021776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021775
{
public static readonly long[] Value={ 0L,0L,1L,2L,9L,7L,0L,1L,6L,8L,6L,1L,2L,1L,9L,1L,9L,5L,8L,4L,9L,5L,4L,6L,0L,4L,4L,0L,9L,8L,5L,7L,3L,2L,8L,1L,4L,5L,2L,6L,5L,8L,8L,8L,4L,5L,6L,5L,4L,9L,9L,3L,5L,1L,4L,9L,1L,5L,6L,9L,3L,9L,0L,4L,0L,2L,0L,7L,5L,2L,2L,6L,9L,7L,7L,9L,5L,0L,7L,1L,3L,3L,5L,9L,2L,7L,3L,6L,7L,0L,5L,5L,7L,7L,1L,7L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021775Inst : IEnumerable<long>
{
public static readonly long[] Value=A021775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021775.Bytes);
public long this[int i]=>Value[i];

public static A021775Inst Instance=new A021775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021774
{
public static readonly long[] Value={ 1L,20L,271L,3150L,34041L,354480L,3620611L,36607010L,368161981L,3692428740L,36979730151L,370080107670L,3702237477121L,37029646251800L,370333177834891L,3703516786589130L,37036098633715461L,370365663082767660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021774Inst : IEnumerable<long>
{
public static readonly long[] Value=A021774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021774.Bytes);
public long this[int i]=>Value[i];

public static A021774Inst Instance=new A021774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021773
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,0L,3L,9L,0L,1L,1L,7L,0L,3L,5L,1L,1L,0L,5L,3L,3L,1L,5L,9L,9L,4L,7L,9L,8L,4L,3L,9L,5L,3L,1L,8L,5L,9L,5L,5L,7L,8L,6L,7L,3L,6L,0L,2L,0L,8L,0L,6L,2L,4L,1L,8L,7L,2L,5L,6L,1L,7L,6L,8L,5L,3L,0L,5L,5L,9L,1L,6L,7L,7L,5L,0L,3L,2L,5L,0L,9L,7L,5L,2L,9L,2L,5L,8L,7L,7L,7L,6L,3L,3L,2L,8L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021773Inst : IEnumerable<long>
{
public static readonly long[] Value=A021773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021773.Bytes);
public long this[int i]=>Value[i];

public static A021773Inst Instance=new A021773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021772
{
public static readonly long[] Value={ 1L,19L,242L,2618L,26103L,248997L,2316784L,21251956L,193359485L,1751044295L,15814841406L,142616378814L,1284983809747L,11572125768313L,104185847231708L,937857633325592L,8441649467754489L,75979521955403451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021772Inst : IEnumerable<long>
{
public static readonly long[] Value=A021772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021772.Bytes);
public long this[int i]=>Value[i];

public static A021772Inst Instance=new A021772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021771
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,3L,7L,8L,0L,9L,6L,4L,7L,9L,7L,9L,1L,3L,9L,5L,0L,4L,5L,6L,3L,2L,3L,3L,3L,7L,6L,7L,9L,2L,6L,9L,8L,8L,2L,6L,5L,9L,7L,1L,3L,1L,6L,8L,1L,8L,7L,7L,4L,4L,4L,5L,8L,9L,3L,0L,8L,9L,9L,6L,0L,8L,8L,6L,5L,7L,1L,0L,5L,6L,0L,6L,2L,5L,8L,1L,4L,8L,6L,3L,1L,0L,2L,9L,9L,8L,6L,9L,6L,2L,1L,9L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021771Inst : IEnumerable<long>
{
public static readonly long[] Value=A021771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021771.Bytes);
public long this[int i]=>Value[i];

public static A021771Inst Instance=new A021771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021770
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,5L,4L,8L,3L,0L,2L,8L,7L,2L,0L,6L,2L,6L,6L,3L,1L,8L,5L,3L,7L,8L,5L,9L,0L,0L,7L,8L,3L,2L,8L,9L,8L,1L,7L,2L,3L,2L,3L,7L,5L,9L,7L,9L,1L,1L,2L,2L,7L,1L,5L,4L,0L,4L,6L,9L,9L,7L,3L,8L,9L,0L,3L,3L,9L,4L,2L,5L,5L,8L,7L,4L,6L,7L,3L,6L,2L,9L,2L,4L,2L,8L,1L,9L,8L,4L,3L,3L,4L,2L,0L,3L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021770Inst : IEnumerable<long>
{
public static readonly long[] Value=A021770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021770.Bytes);
public long this[int i]=>Value[i];

public static A021770Inst Instance=new A021770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021769
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L,3L,0L,7L,1L,8L,9L,5L,4L,2L,4L,8L,3L,6L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021769Inst : IEnumerable<long>
{
public static readonly long[] Value=A021769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021769.Bytes);
public long this[int i]=>Value[i];

public static A021769Inst Instance=new A021769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021768
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L,1L,7L,8L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021768Inst : IEnumerable<long>
{
public static readonly long[] Value=A021768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021768.Bytes);
public long this[int i]=>Value[i];

public static A021768Inst Instance=new A021768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021767
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,0L,6L,1L,5L,9L,8L,9L,5L,1L,5L,0L,7L,2L,0L,8L,3L,8L,7L,9L,4L,2L,3L,3L,2L,8L,9L,6L,4L,6L,1L,3L,3L,6L,8L,2L,8L,3L,0L,9L,3L,0L,5L,3L,7L,3L,5L,2L,5L,5L,5L,7L,0L,1L,1L,7L,9L,5L,5L,4L,3L,9L,0L,5L,6L,3L,5L,6L,4L,8L,7L,5L,4L,9L,1L,4L,8L,0L,9L,9L,6L,0L,6L,8L,1L,5L,2L,0L,3L,1L,4L,5L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021767Inst : IEnumerable<long>
{
public static readonly long[] Value=A021767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021767.Bytes);
public long this[int i]=>Value[i];

public static A021767Inst Instance=new A021767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021766
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L,2L,4L,9L,3L,4L,3L,8L,3L,2L,0L,2L,0L,9L,9L,7L,3L,7L,5L,3L,2L,8L,0L,8L,3L,9L,8L,9L,5L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L,2L,4L,9L,3L,4L,3L,8L,3L,2L,0L,2L,0L,9L,9L,7L,3L,7L,5L,3L,2L,8L,0L,8L,3L,9L,8L,9L,5L,0L,1L,3L,1L,2L,3L,3L,5L,9L,5L,8L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021766Inst : IEnumerable<long>
{
public static readonly long[] Value=A021766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021766.Bytes);
public long this[int i]=>Value[i];

public static A021766Inst Instance=new A021766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021765
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,4L,0L,6L,0L,4L,4L,6L,7L,8L,0L,5L,5L,1L,9L,0L,5L,3L,8L,7L,6L,4L,7L,8L,3L,1L,8L,0L,0L,2L,6L,2L,8L,1L,2L,0L,8L,9L,3L,5L,6L,1L,1L,0L,3L,8L,1L,0L,7L,7L,5L,2L,9L,5L,6L,6L,3L,6L,0L,0L,5L,2L,5L,6L,2L,4L,1L,7L,8L,7L,1L,2L,2L,2L,0L,7L,6L,2L,1L,5L,5L,0L,5L,9L,1L,3L,2L,7L,2L,0L,1L,0L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021765Inst : IEnumerable<long>
{
public static readonly long[] Value=A021765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021765.Bytes);
public long this[int i]=>Value[i];

public static A021765Inst Instance=new A021765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021764
{
public static readonly long[] Value={ 1L,18L,215L,2160L,19821L,172638L,1456915L,12056220L,98541641L,799142058L,6448579215L,51871439880L,416407919461L,3338534836278L,26744994007115L,214144960297140L,1714090450201281L,13717400347223298L,109762678131820615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021764Inst : IEnumerable<long>
{
public static readonly long[] Value=A021764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021764.Bytes);
public long this[int i]=>Value[i];

public static A021764Inst Instance=new A021764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021763
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L,6L,6L,5L,3L,4L,9L,1L,4L,3L,6L,1L,0L,0L,1L,3L,1L,7L,5L,2L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021763Inst : IEnumerable<long>
{
public static readonly long[] Value=A021763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021763.Bytes);
public long this[int i]=>Value[i];

public static A021763Inst Instance=new A021763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021762
{
public static readonly long[] Value={ 0L,0L,1L,3L,1L,9L,2L,6L,1L,2L,1L,3L,7L,2L,0L,3L,1L,6L,6L,2L,2L,6L,9L,1L,2L,9L,2L,8L,7L,5L,9L,8L,9L,4L,4L,5L,9L,1L,0L,2L,9L,0L,2L,3L,7L,4L,6L,7L,0L,1L,8L,4L,6L,9L,6L,5L,6L,9L,9L,2L,0L,8L,4L,4L,3L,2L,7L,1L,7L,6L,7L,8L,1L,0L,0L,2L,6L,3L,8L,5L,2L,2L,4L,2L,7L,4L,4L,0L,6L,3L,3L,2L,4L,5L,3L,8L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021762Inst : IEnumerable<long>
{
public static readonly long[] Value=A021762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021762.Bytes);
public long this[int i]=>Value[i];

public static A021762Inst Instance=new A021762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021761
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L,0L,3L,5L,6L,6L,7L,1L,0L,7L,0L,0L,1L,3L,2L,1L,0L,0L,3L,9L,6L,3L,0L,1L,1L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021761Inst : IEnumerable<long>
{
public static readonly long[] Value=A021761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021761.Bytes);
public long this[int i]=>Value[i];

public static A021761Inst Instance=new A021761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021760
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L,3L,2L,2L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021760Inst : IEnumerable<long>
{
public static readonly long[] Value=A021760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021760.Bytes);
public long this[int i]=>Value[i];

public static A021760Inst Instance=new A021760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021759
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021759Inst : IEnumerable<long>
{
public static readonly long[] Value=A021759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021759.Bytes);
public long this[int i]=>Value[i];

public static A021759Inst Instance=new A021759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021758
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,6L,2L,5L,9L,9L,4L,6L,9L,4L,9L,6L,0L,2L,1L,2L,2L,0L,1L,5L,9L,1L,5L,1L,1L,9L,3L,6L,3L,3L,9L,5L,2L,2L,5L,4L,6L,4L,1L,9L,0L,9L,8L,1L,4L,3L,2L,3L,6L,0L,7L,4L,2L,7L,0L,5L,5L,7L,0L,2L,9L,1L,7L,7L,7L,1L,8L,8L,3L,2L,8L,9L,1L,2L,4L,6L,6L,8L,4L,3L,5L,0L,1L,3L,2L,6L,2L,5L,9L,9L,4L,6L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021758Inst : IEnumerable<long>
{
public static readonly long[] Value=A021758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021758.Bytes);
public long this[int i]=>Value[i];

public static A021758Inst Instance=new A021758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021757
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,8L,0L,2L,1L,2L,4L,8L,3L,3L,9L,9L,7L,3L,4L,3L,9L,5L,7L,5L,0L,3L,3L,2L,0L,0L,5L,3L,1L,2L,0L,8L,4L,9L,9L,3L,3L,5L,9L,8L,9L,3L,7L,5L,8L,3L,0L,0L,1L,3L,2L,8L,0L,2L,1L,2L,4L,8L,3L,3L,9L,9L,7L,3L,4L,3L,9L,5L,7L,5L,0L,3L,3L,2L,0L,0L,5L,3L,1L,2L,0L,8L,4L,9L,9L,3L,3L,5L,9L,8L,9L,3L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021757Inst : IEnumerable<long>
{
public static readonly long[] Value=A021757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021757.Bytes);
public long this[int i]=>Value[i];

public static A021757Inst Instance=new A021757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021756
{
public static readonly long[] Value={ 0L,0L,1L,3L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021756Inst : IEnumerable<long>
{
public static readonly long[] Value=A021756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021756.Bytes);
public long this[int i]=>Value[i];

public static A021756Inst Instance=new A021756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021755
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,1L,5L,5L,7L,9L,2L,2L,7L,6L,9L,6L,4L,0L,4L,7L,9L,3L,6L,0L,8L,5L,2L,1L,9L,7L,0L,7L,0L,5L,7L,2L,5L,6L,9L,9L,0L,6L,7L,9L,0L,9L,4L,5L,4L,0L,6L,1L,2L,5L,1L,6L,6L,4L,4L,4L,7L,4L,0L,3L,4L,6L,2L,0L,5L,0L,5L,9L,9L,2L,0L,1L,0L,6L,5L,2L,4L,6L,3L,3L,8L,2L,1L,5L,7L,1L,2L,3L,8L,3L,4L,8L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021755Inst : IEnumerable<long>
{
public static readonly long[] Value=A021755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021755.Bytes);
public long this[int i]=>Value[i];

public static A021755Inst Instance=new A021755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021754
{
public static readonly long[] Value={ 1L,17L,190L,1770L,14931L,118587L,905920L,6742340L,49288261L,355826757L,2546230050L,18106416510L,128181315991L,904540692527L,6368500164580L,44764509392280L,314282333570121L,2204653080603897L,15456046918261510L,108310071701877650L,758760684298882651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021754Inst : IEnumerable<long>
{
public static readonly long[] Value=A021754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021754.Bytes);
public long this[int i]=>Value[i];

public static A021754Inst Instance=new A021754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021753
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,5L,1L,1L,3L,4L,8L,4L,6L,4L,6L,1L,9L,4L,9L,2L,6L,5L,6L,8L,7L,5L,8L,3L,4L,4L,4L,5L,9L,2L,7L,9L,0L,3L,8L,7L,1L,8L,2L,9L,1L,0L,5L,4L,7L,3L,9L,6L,5L,2L,8L,7L,0L,4L,9L,3L,9L,9L,1L,9L,8L,9L,3L,1L,9L,0L,9L,2L,1L,2L,2L,8L,3L,0L,4L,4L,0L,5L,8L,7L,4L,4L,9L,9L,3L,3L,2L,4L,4L,3L,2L,5L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021753Inst : IEnumerable<long>
{
public static readonly long[] Value=A021753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021753.Bytes);
public long this[int i]=>Value[i];

public static A021753Inst Instance=new A021753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021752
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L,3L,3L,6L,8L,9L,8L,3L,9L,5L,7L,2L,1L,9L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021752Inst : IEnumerable<long>
{
public static readonly long[] Value=A021752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021752.Bytes);
public long this[int i]=>Value[i];

public static A021752Inst Instance=new A021752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021751
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L,7L,4L,8L,3L,2L,6L,6L,3L,9L,8L,9L,2L,9L,0L,4L,9L,5L,3L,1L,4L,5L,9L,1L,7L,0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L,7L,4L,8L,3L,2L,6L,6L,3L,9L,8L,9L,2L,9L,0L,4L,9L,5L,3L,1L,4L,5L,9L,1L,7L,0L,0L,1L,3L,3L,8L,6L,8L,8L,0L,8L,5L,6L,7L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021751Inst : IEnumerable<long>
{
public static readonly long[] Value=A021751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021751.Bytes);
public long this[int i]=>Value[i];

public static A021751Inst Instance=new A021751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021750
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,0L,4L,8L,2L,5L,7L,3L,7L,2L,6L,5L,4L,1L,5L,5L,4L,9L,5L,9L,7L,8L,5L,5L,2L,2L,7L,8L,8L,2L,0L,3L,7L,5L,3L,3L,5L,1L,2L,0L,6L,4L,3L,4L,3L,1L,6L,3L,5L,3L,8L,8L,7L,3L,9L,9L,4L,6L,3L,8L,0L,6L,9L,7L,0L,5L,0L,9L,3L,8L,3L,3L,7L,8L,0L,1L,6L,0L,8L,5L,7L,9L,0L,8L,8L,4L,7L,1L,8L,4L,9L,8L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021750Inst : IEnumerable<long>
{
public static readonly long[] Value=A021750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021750.Bytes);
public long this[int i]=>Value[i];

public static A021750Inst Instance=new A021750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021749
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,2L,2L,8L,1L,8L,7L,9L,1L,9L,4L,6L,3L,0L,8L,7L,2L,4L,8L,3L,2L,2L,1L,4L,7L,6L,5L,1L,0L,0L,6L,7L,1L,1L,4L,0L,9L,3L,9L,5L,9L,7L,3L,1L,5L,4L,3L,6L,2L,4L,1L,6L,1L,0L,7L,3L,8L,2L,5L,5L,0L,3L,3L,5L,5L,7L,0L,4L,6L,9L,7L,9L,8L,6L,5L,7L,7L,1L,8L,1L,2L,0L,8L,0L,5L,3L,6L,9L,1L,2L,7L,5L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021749Inst : IEnumerable<long>
{
public static readonly long[] Value=A021749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021749.Bytes);
public long this[int i]=>Value[i];

public static A021749Inst Instance=new A021749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021748
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021748Inst : IEnumerable<long>
{
public static readonly long[] Value=A021748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021748.Bytes);
public long this[int i]=>Value[i];

public static A021748Inst Instance=new A021748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021747
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,5L,8L,9L,5L,0L,2L,0L,1L,8L,8L,4L,2L,5L,3L,0L,2L,8L,2L,6L,3L,7L,9L,5L,4L,2L,3L,9L,5L,6L,9L,3L,1L,3L,5L,9L,3L,5L,3L,9L,7L,0L,3L,9L,0L,3L,0L,9L,5L,5L,5L,8L,5L,4L,6L,4L,3L,3L,3L,7L,8L,1L,9L,6L,5L,0L,0L,6L,7L,2L,9L,4L,7L,5L,1L,0L,0L,9L,4L,2L,1L,2L,6L,5L,1L,4L,1L,3L,1L,8L,9L,7L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021747Inst : IEnumerable<long>
{
public static readonly long[] Value=A021747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021747.Bytes);
public long this[int i]=>Value[i];

public static A021747Inst Instance=new A021747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021746
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,7L,7L,0L,8L,8L,9L,4L,8L,7L,8L,7L,0L,6L,1L,9L,9L,4L,6L,0L,9L,1L,6L,4L,4L,2L,0L,4L,8L,5L,1L,7L,5L,2L,0L,2L,1L,5L,6L,3L,3L,4L,2L,3L,1L,8L,0L,5L,9L,2L,9L,9L,1L,9L,1L,3L,7L,4L,6L,6L,3L,0L,7L,2L,7L,7L,6L,2L,8L,0L,3L,2L,3L,4L,5L,0L,1L,3L,4L,7L,7L,0L,8L,8L,9L,4L,8L,7L,8L,7L,0L,6L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021746Inst : IEnumerable<long>
{
public static readonly long[] Value=A021746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021746.Bytes);
public long this[int i]=>Value[i];

public static A021746Inst Instance=new A021746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021745
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L,6L,6L,5L,3L,1L,7L,1L,3L,9L,0L,0L,1L,3L,4L,9L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021745Inst : IEnumerable<long>
{
public static readonly long[] Value=A021745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021745.Bytes);
public long this[int i]=>Value[i];

public static A021745Inst Instance=new A021745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021744
{
public static readonly long[] Value={ 1L,16L,167L,1442L,11193L,81228L,563179L,3779974L,24771725L,159439280L,1012078431L,6355276746L,39568060897L,244679845972L,1504794392723L,9213774596558L,56213415403509L,341957238034104L,2075218782238855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021744Inst : IEnumerable<long>
{
public static readonly long[] Value=A021744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021744.Bytes);
public long this[int i]=>Value[i];

public static A021744Inst Instance=new A021744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021743
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,3L,1L,7L,9L,9L,7L,2L,9L,3L,6L,4L,0L,0L,5L,4L,1L,2L,7L,1L,9L,8L,9L,1L,7L,4L,5L,6L,0L,2L,1L,6L,5L,0L,8L,7L,9L,5L,6L,6L,9L,8L,2L,4L,0L,8L,6L,6L,0L,3L,5L,1L,8L,2L,6L,7L,9L,2L,9L,6L,3L,4L,6L,4L,1L,4L,0L,7L,3L,0L,7L,1L,7L,1L,8L,5L,3L,8L,5L,6L,5L,6L,2L,9L,2L,2L,8L,6L,8L,7L,4L,1L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021743Inst : IEnumerable<long>
{
public static readonly long[] Value=A021743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021743.Bytes);
public long this[int i]=>Value[i];

public static A021743Inst Instance=new A021743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021742
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L,5L,5L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021742Inst : IEnumerable<long>
{
public static readonly long[] Value=A021742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021742.Bytes);
public long this[int i]=>Value[i];

public static A021742Inst Instance=new A021742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021741
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,6L,8L,5L,2L,1L,0L,3L,1L,2L,0L,7L,5L,9L,8L,3L,7L,1L,7L,7L,7L,4L,7L,6L,2L,5L,5L,0L,8L,8L,1L,9L,5L,3L,8L,6L,7L,0L,2L,8L,4L,9L,3L,8L,9L,4L,1L,6L,5L,5L,3L,5L,9L,5L,6L,5L,8L,0L,7L,3L,2L,7L,0L,0L,1L,3L,5L,6L,8L,5L,2L,1L,0L,3L,1L,2L,0L,7L,5L,9L,8L,3L,7L,1L,7L,7L,7L,4L,7L,6L,2L,5L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021741Inst : IEnumerable<long>
{
public static readonly long[] Value=A021741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021741.Bytes);
public long this[int i]=>Value[i];

public static A021741Inst Instance=new A021741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021740
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021740Inst : IEnumerable<long>
{
public static readonly long[] Value=A021740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021740.Bytes);
public long this[int i]=>Value[i];

public static A021740Inst Instance=new A021740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021739
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021739Inst : IEnumerable<long>
{
public static readonly long[] Value=A021739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021739.Bytes);
public long this[int i]=>Value[i];

public static A021739Inst Instance=new A021739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021738
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,2L,3L,9L,7L,8L,2L,0L,1L,6L,3L,4L,8L,7L,7L,3L,8L,4L,1L,9L,6L,1L,8L,5L,2L,8L,6L,1L,0L,3L,5L,4L,2L,2L,3L,4L,3L,3L,2L,4L,2L,5L,0L,6L,8L,1L,1L,9L,8L,9L,1L,0L,0L,8L,1L,7L,4L,3L,8L,6L,9L,2L,0L,9L,8L,0L,9L,2L,6L,4L,3L,0L,5L,1L,7L,7L,1L,1L,1L,7L,1L,6L,6L,2L,1L,2L,5L,3L,4L,0L,5L,9L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021738Inst : IEnumerable<long>
{
public static readonly long[] Value=A021738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021738.Bytes);
public long this[int i]=>Value[i];

public static A021738Inst Instance=new A021738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021737
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,4L,2L,5L,6L,4L,8L,0L,2L,1L,8L,2L,8L,1L,0L,3L,6L,8L,3L,4L,9L,2L,4L,9L,6L,5L,8L,9L,3L,5L,8L,7L,9L,9L,4L,5L,4L,2L,9L,7L,4L,0L,7L,9L,1L,2L,6L,8L,7L,5L,8L,5L,2L,6L,6L,0L,3L,0L,0L,1L,3L,6L,4L,2L,5L,6L,4L,8L,0L,2L,1L,8L,2L,8L,1L,0L,3L,6L,8L,3L,4L,9L,2L,4L,9L,6L,5L,8L,9L,3L,5L,8L,7L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021737Inst : IEnumerable<long>
{
public static readonly long[] Value=A021737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021737.Bytes);
public long this[int i]=>Value[i];

public static A021737Inst Instance=new A021737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021736
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L,7L,9L,2L,3L,4L,9L,7L,2L,6L,7L,7L,5L,9L,5L,6L,2L,8L,4L,1L,5L,3L,0L,0L,5L,4L,6L,4L,4L,8L,0L,8L,7L,4L,3L,1L,6L,9L,3L,9L,8L,9L,0L,7L,1L,0L,3L,8L,2L,5L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L,7L,9L,2L,3L,4L,9L,7L,2L,6L,7L,7L,5L,9L,5L,6L,2L,8L,4L,1L,5L,3L,0L,0L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021736Inst : IEnumerable<long>
{
public static readonly long[] Value=A021736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021736.Bytes);
public long this[int i]=>Value[i];

public static A021736Inst Instance=new A021736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021735
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,7L,9L,8L,9L,0L,5L,6L,0L,8L,7L,5L,5L,1L,2L,9L,9L,5L,8L,9L,6L,0L,3L,2L,8L,3L,1L,7L,3L,7L,3L,4L,6L,1L,0L,1L,2L,3L,1L,1L,9L,0L,1L,5L,0L,4L,7L,8L,7L,9L,6L,1L,6L,9L,6L,3L,0L,6L,4L,2L,9L,5L,4L,8L,5L,6L,3L,6L,1L,1L,4L,9L,1L,1L,0L,8L,0L,7L,1L,1L,3L,5L,4L,3L,0L,9L,1L,6L,5L,5L,2L,6L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021735Inst : IEnumerable<long>
{
public static readonly long[] Value=A021735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021735.Bytes);
public long this[int i]=>Value[i];

public static A021735Inst Instance=new A021735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021734
{
public static readonly long[] Value={ 1L,27L,502L,8022L,118363L,1663809L,22644784L,301210524L,3938740405L,50831269671L,649205557546L,8222000492706L,103410878533327L,1293146143620813L,16092125344053988L,199423591976817768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021734Inst : IEnumerable<long>
{
public static readonly long[] Value=A021734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021734.Bytes);
public long this[int i]=>Value[i];

public static A021734Inst Instance=new A021734Inst();

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