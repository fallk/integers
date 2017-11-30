using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195357
{
public static readonly long[] Value={ 1L,9L,7L,2L,0L,4L,8L,2L,9L,8L,2L,7L,2L,6L,9L,0L,4L,1L,3L,9L,8L,0L,2L,1L,9L,5L,1L,2L,0L,2L,5L,7L,0L,8L,4L,0L,3L,2L,8L,4L,5L,8L,8L,4L,3L,0L,7L,8L,5L,1L,4L,3L,9L,5L,8L,2L,9L,8L,4L,2L,7L,8L,8L,5L,5L,2L,7L,7L,2L,8L,7L,6L,0L,2L,4L,8L,3L,1L,0L,9L,9L,8L,6L,6L,3L,5L,8L,8L,8L,2L,0L,5L,4L,4L,2L,7L,5L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195357Inst : IEnumerable<long>
{
public static readonly long[] Value=A195357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195357.Bytes);
public long this[int i]=>Value[i];

public static A195357Inst Instance=new A195357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195358
{
public static readonly long[] Value={ 5L,8L,2L,2L,5L,2L,4L,7L,5L,0L,6L,1L,6L,5L,6L,9L,9L,2L,6L,4L,7L,3L,2L,2L,5L,5L,2L,4L,7L,7L,4L,9L,0L,5L,1L,0L,4L,8L,9L,8L,0L,6L,4L,4L,4L,1L,1L,5L,6L,7L,0L,1L,2L,1L,2L,4L,4L,8L,2L,9L,2L,1L,7L,2L,0L,3L,2L,9L,1L,2L,3L,8L,5L,6L,7L,8L,0L,4L,2L,1L,2L,2L,1L,4L,0L,2L,4L,9L,7L,8L,8L,3L,7L,7L,0L,7L,4L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195358Inst : IEnumerable<long>
{
public static readonly long[] Value=A195358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195358.Bytes);
public long this[int i]=>Value[i];

public static A195358Inst Instance=new A195358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195359
{
public static readonly long[] Value={ 1L,6L,4L,4L,5L,0L,8L,0L,6L,0L,3L,2L,3L,0L,2L,4L,2L,4L,9L,0L,0L,0L,2L,9L,9L,7L,3L,1L,4L,3L,0L,5L,1L,3L,3L,1L,4L,8L,7L,5L,9L,6L,6L,3L,2L,9L,1L,3L,1L,4L,2L,8L,2L,3L,4L,6L,5L,7L,9L,9L,0L,2L,4L,0L,2L,4L,4L,3L,1L,7L,7L,8L,7L,2L,2L,0L,2L,2L,3L,8L,3L,8L,8L,5L,5L,0L,3L,6L,2L,6L,4L,9L,3L,8L,6L,0L,2L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195359Inst : IEnumerable<long>
{
public static readonly long[] Value=A195359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195359.Bytes);
public long this[int i]=>Value[i];

public static A195359Inst Instance=new A195359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195360
{
public static readonly long[] Value={ 1L,9L,5L,0L,1L,2L,5L,7L,0L,6L,5L,2L,0L,6L,5L,8L,8L,2L,5L,3L,3L,8L,5L,5L,7L,6L,0L,7L,8L,2L,0L,1L,4L,3L,3L,9L,3L,1L,7L,9L,7L,7L,3L,5L,4L,4L,7L,5L,9L,4L,8L,0L,2L,4L,4L,4L,6L,7L,9L,8L,6L,5L,9L,9L,3L,8L,6L,1L,6L,8L,3L,7L,6L,0L,9L,3L,5L,9L,2L,7L,8L,1L,2L,8L,2L,9L,0L,9L,3L,6L,5L,9L,7L,8L,7L,0L,2L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195360Inst : IEnumerable<long>
{
public static readonly long[] Value=A195360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195360.Bytes);
public long this[int i]=>Value[i];

public static A195360Inst Instance=new A195360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195361
{
public static readonly long[] Value={ 2L,2L,8L,3L,7L,2L,1L,8L,3L,0L,7L,4L,7L,7L,5L,7L,0L,5L,5L,9L,5L,0L,4L,1L,0L,0L,4L,2L,3L,0L,9L,5L,6L,3L,5L,4L,4L,6L,2L,6L,9L,9L,7L,5L,3L,5L,0L,9L,2L,0L,3L,8L,0L,4L,3L,2L,8L,6L,2L,7L,3L,9L,2L,5L,4L,1L,4L,7L,7L,5L,1L,9L,1L,8L,6L,1L,7L,4L,8L,0L,2L,7L,3L,1L,0L,4L,4L,3L,0L,2L,5L,9L,0L,6L,3L,3L,9L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195361Inst : IEnumerable<long>
{
public static readonly long[] Value=A195361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195361.Bytes);
public long this[int i]=>Value[i];

public static A195361Inst Instance=new A195361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195362
{
public static readonly long[] Value={ 4L,7L,4L,6L,2L,8L,7L,7L,4L,7L,5L,8L,4L,2L,7L,0L,5L,1L,6L,4L,7L,1L,1L,9L,3L,1L,1L,3L,9L,9L,5L,1L,6L,6L,8L,0L,4L,8L,7L,6L,6L,6L,3L,6L,8L,5L,9L,7L,0L,9L,3L,2L,6L,8L,8L,7L,1L,3L,8L,9L,6L,7L,5L,8L,4L,3L,8L,6L,6L,8L,5L,9L,6L,5L,5L,7L,5L,2L,0L,7L,3L,2L,7L,5L,7L,2L,8L,8L,3L,5L,4L,7L,1L,9L,8L,2L,9L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195362Inst : IEnumerable<long>
{
public static readonly long[] Value=A195362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195362.Bytes);
public long this[int i]=>Value[i];

public static A195362Inst Instance=new A195362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195363
{
public static readonly long[] Value={ 147718L,151522L,154477L,176777L,177147L,184488L,188148L,188188L,191992L,204232L,222222L,222252L,222652L,222722L,222777L,222992L,225522L,225592L,266627L,350303L,353222L,363313L,369638L,379292L,413313L,416118L,418418L,441103L,447577L,477227L,484448L,488488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195363Inst : IEnumerable<long>
{
public static readonly long[] Value=A195363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195363.Bytes);
public long this[int i]=>Value[i];

public static A195363Inst Instance=new A195363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195364
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,15L,17L,26L,33L,46L,58L,83L,103L,139L,180L,236L,299L,391L,492L,633L,796L,1006L,1257L,1583L,1961L,2440L,3014L,3724L,4567L,5612L,6844L,8355L,10147L,12314L,14887L,17986L,21639L,26019L,31189L,37346L,44585L,53182L,63263L,75181L,89140L,105562L,124756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195364Inst : IEnumerable<long>
{
public static readonly long[] Value=A195364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195364.Bytes);
public long this[int i]=>Value[i];

public static A195364Inst Instance=new A195364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195365
{
public static readonly long[] Value={ 9L,6L,6L,2L,7L,3L,9L,6L,1L,5L,7L,6L,7L,1L,2L,9L,5L,7L,2L,0L,9L,3L,8L,8L,6L,4L,9L,0L,0L,9L,2L,1L,2L,4L,8L,1L,6L,3L,4L,4L,4L,6L,9L,2L,6L,1L,3L,1L,5L,3L,9L,1L,4L,2L,4L,2L,6L,3L,4L,9L,7L,1L,5L,7L,5L,1L,3L,2L,2L,7L,8L,5L,0L,7L,6L,4L,4L,7L,6L,0L,1L,3L,2L,0L,4L,7L,0L,9L,0L,0L,1L,3L,2L,9L,1L,2L,4L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195365Inst : IEnumerable<long>
{
public static readonly long[] Value=A195365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195365.Bytes);
public long this[int i]=>Value[i];

public static A195365Inst Instance=new A195365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195366
{
public static readonly long[] Value={ 1L,0L,0L,7L,4L,6L,3L,7L,4L,8L,0L,3L,0L,0L,5L,1L,5L,9L,4L,2L,9L,2L,1L,1L,8L,8L,4L,0L,2L,6L,7L,0L,6L,6L,1L,8L,1L,5L,8L,0L,2L,2L,0L,5L,4L,3L,3L,8L,2L,5L,6L,7L,3L,4L,0L,1L,3L,7L,1L,2L,8L,8L,4L,0L,9L,4L,8L,0L,1L,7L,9L,2L,9L,6L,1L,7L,9L,3L,4L,2L,6L,5L,0L,5L,1L,2L,8L,2L,9L,8L,5L,7L,3L,6L,4L,7L,6L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195366Inst : IEnumerable<long>
{
public static readonly long[] Value=A195366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195366.Bytes);
public long this[int i]=>Value[i];

public static A195366Inst Instance=new A195366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195367
{
public static readonly long[] Value={ 1L,2L,8L,7L,2L,1L,2L,0L,8L,2L,6L,1L,4L,7L,9L,8L,7L,6L,6L,1L,9L,8L,3L,9L,0L,5L,3L,0L,2L,7L,3L,1L,7L,2L,8L,5L,8L,2L,4L,6L,3L,9L,2L,3L,4L,1L,3L,3L,1L,4L,5L,3L,3L,0L,1L,5L,7L,5L,1L,8L,7L,7L,1L,4L,4L,5L,8L,3L,6L,5L,9L,3L,8L,8L,1L,8L,0L,7L,6L,8L,0L,5L,1L,9L,5L,6L,1L,1L,3L,2L,4L,7L,2L,5L,3L,3L,9L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195367Inst : IEnumerable<long>
{
public static readonly long[] Value=A195367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195367.Bytes);
public long this[int i]=>Value[i];

public static A195367Inst Instance=new A195367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195368
{
public static readonly long[] Value={ 6L,0L,5L,8L,6L,1L,8L,4L,2L,3L,6L,1L,2L,3L,9L,9L,3L,3L,8L,5L,6L,6L,2L,4L,1L,9L,1L,1L,1L,8L,2L,7L,5L,0L,7L,5L,0L,6L,7L,8L,1L,8L,6L,5L,3L,3L,5L,1L,4L,6L,6L,2L,8L,3L,1L,7L,5L,5L,5L,7L,8L,8L,3L,5L,9L,2L,6L,5L,2L,2L,7L,9L,1L,0L,0L,9L,3L,2L,5L,7L,1L,0L,0L,5L,4L,5L,1L,7L,1L,6L,1L,1L,5L,9L,4L,0L,2L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195368Inst : IEnumerable<long>
{
public static readonly long[] Value=A195368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195368.Bytes);
public long this[int i]=>Value[i];

public static A195368Inst Instance=new A195368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195369
{
public static readonly long[] Value={ 7L,1L,5L,7L,9L,0L,1L,3L,5L,9L,8L,9L,9L,1L,4L,9L,5L,4L,5L,9L,5L,4L,9L,2L,6L,7L,2L,3L,3L,3L,4L,3L,2L,4L,9L,4L,5L,6L,6L,3L,6L,8L,3L,0L,6L,5L,6L,7L,0L,5L,1L,1L,4L,4L,1L,8L,8L,8L,6L,9L,2L,2L,0L,1L,8L,3L,4L,5L,3L,8L,4L,6L,2L,9L,2L,9L,5L,3L,1L,9L,3L,5L,2L,3L,4L,0L,5L,2L,5L,0L,1L,4L,2L,2L,0L,5L,7L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195369Inst : IEnumerable<long>
{
public static readonly long[] Value=A195369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195369.Bytes);
public long this[int i]=>Value[i];

public static A195369Inst Instance=new A195369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195370
{
public static readonly long[] Value={ 7L,6L,8L,1L,3L,7L,4L,3L,2L,6L,1L,5L,5L,3L,6L,7L,6L,0L,7L,0L,1L,5L,3L,4L,5L,2L,1L,1L,1L,9L,2L,8L,7L,9L,5L,5L,0L,9L,2L,6L,7L,1L,9L,8L,8L,4L,5L,0L,7L,8L,6L,7L,6L,3L,0L,3L,4L,0L,7L,8L,5L,3L,7L,8L,0L,6L,5L,4L,5L,6L,6L,3L,0L,0L,7L,0L,5L,7L,3L,9L,6L,9L,0L,4L,7L,0L,2L,3L,1L,0L,7L,9L,2L,1L,7L,7L,0L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195370Inst : IEnumerable<long>
{
public static readonly long[] Value=A195370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195370.Bytes);
public long this[int i]=>Value[i];

public static A195370Inst Instance=new A195370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195371
{
public static readonly long[] Value={ 9L,6L,4L,7L,2L,3L,8L,1L,9L,5L,8L,9L,9L,1L,6L,9L,5L,0L,6L,0L,4L,4L,0L,4L,6L,4L,9L,5L,0L,3L,8L,0L,6L,6L,8L,6L,6L,0L,3L,7L,2L,4L,3L,9L,4L,7L,2L,0L,2L,7L,7L,9L,4L,4L,7L,4L,3L,9L,8L,7L,1L,7L,0L,7L,3L,9L,7L,7L,2L,1L,0L,1L,0L,0L,4L,7L,9L,2L,0L,1L,2L,3L,1L,0L,5L,2L,8L,1L,0L,1L,2L,2L,3L,0L,0L,1L,3L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195371Inst : IEnumerable<long>
{
public static readonly long[] Value=A195371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195371.Bytes);
public long this[int i]=>Value[i];

public static A195371Inst Instance=new A195371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195372
{
public static readonly long[] Value={ 5L,9L,0L,5L,6L,8L,0L,8L,0L,0L,1L,5L,9L,9L,7L,1L,3L,4L,3L,7L,4L,7L,0L,4L,6L,4L,4L,1L,6L,4L,6L,5L,0L,5L,6L,6L,9L,4L,4L,1L,0L,3L,2L,9L,4L,1L,9L,3L,4L,2L,2L,8L,8L,8L,7L,8L,2L,6L,1L,4L,8L,0L,1L,3L,7L,9L,5L,6L,6L,0L,0L,7L,2L,4L,2L,4L,6L,8L,5L,7L,1L,9L,9L,1L,0L,8L,4L,5L,3L,9L,5L,3L,6L,8L,5L,5L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195372Inst : IEnumerable<long>
{
public static readonly long[] Value=A195372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195372.Bytes);
public long this[int i]=>Value[i];

public static A195372Inst Instance=new A195372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195373
{
public static readonly long[] Value={ 4L,88L,6969L,19899699L,399996663L,990999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195373Inst : IEnumerable<long>
{
public static readonly long[] Value=A195373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195373.Bytes);
public long this[int i]=>Value[i];

public static A195373Inst Instance=new A195373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195374
{
public static readonly BigInteger[] Value={ 27L,3375L,BigInteger.Parse("2775577757352755375573357273") };
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
public class A195374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195374Inst Instance=new A195374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195375
{
public static readonly long[] Value={ 13L,21L,27L,693L,3587L,75285L,435365L,437155L,929509L,1731765L,1902599L,1926903L,104916853L,605497891L,1914409189L,4634485093L,12882557131L,112438392323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195375Inst : IEnumerable<long>
{
public static readonly long[] Value=A195375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195375.Bytes);
public long this[int i]=>Value[i];

public static A195375Inst Instance=new A195375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195376
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195376Inst : IEnumerable<long>
{
public static readonly long[] Value=A195376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195376.Bytes);
public long this[int i]=>Value[i];

public static A195376Inst Instance=new A195376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195377
{
public static readonly long[] Value={ 127L,197L,281L,311L,347L,431L,613L,659L,673L,739L,877L,991L,1049L,1229L,1277L,1289L,1367L,1481L,1579L,1613L,1667L,1721L,1787L,1877L,1907L,2027L,2081L,2087L,2141L,2203L,2213L,2237L,2239L,2269L,2287L,2309L,2377L,2383L,2473L,2657L,2689L,2707L,2749L,2767L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195377Inst : IEnumerable<long>
{
public static readonly long[] Value=A195377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195377.Bytes);
public long this[int i]=>Value[i];

public static A195377Inst Instance=new A195377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195378
{
public static readonly long[] Value={ 61L,63L,74L,92L,98L,100L,105L,107L,109L,113L,118L,119L,120L,121L,122L,126L,127L,128L,130L,131L,132L,134L,136L,138L,139L,140L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,162L,163L,165L,167L,168L,169L,170L,171L,172L,173L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195378Inst : IEnumerable<long>
{
public static readonly long[] Value=A195378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195378.Bytes);
public long this[int i]=>Value[i];

public static A195378Inst Instance=new A195378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195379
{
public static readonly long[] Value={ 2L,137L,281L,521L,641L,883L,937L,1087L,1151L,1229L,1277L,1301L,1489L,1567L,1607L,1697L,2027L,2081L,2237L,2381L,2543L,2591L,2657L,2687L,2729L,2801L,2851L,2969L,3119L,3257L,3301L,3359L,3463L,3467L,3529L,3673L,3733L,3793L,3821L,3851L,4073L,4217L,4229L,4241L,4259L,4283L,4337L,4421L,4481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195379Inst : IEnumerable<long>
{
public static readonly long[] Value=A195379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195379.Bytes);
public long this[int i]=>Value[i];

public static A195379Inst Instance=new A195379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195380
{
public static readonly long[] Value={ 5L,5L,7L,5L,7L,0L,1L,7L,6L,9L,1L,7L,0L,9L,3L,8L,0L,3L,7L,2L,1L,1L,2L,9L,1L,4L,6L,0L,4L,2L,9L,2L,3L,1L,8L,7L,2L,1L,1L,5L,2L,6L,1L,0L,0L,8L,9L,0L,3L,0L,5L,5L,9L,9L,2L,1L,6L,7L,9L,5L,5L,8L,9L,0L,9L,5L,8L,8L,2L,5L,6L,8L,1L,9L,4L,3L,6L,5L,6L,9L,3L,1L,0L,6L,8L,1L,8L,1L,7L,7L,7L,1L,2L,4L,7L,7L,1L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195380Inst : IEnumerable<long>
{
public static readonly long[] Value=A195380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195380.Bytes);
public long this[int i]=>Value[i];

public static A195380Inst Instance=new A195380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195381
{
public static readonly long[] Value={ 1L,3L,2L,3L,1L,6L,9L,0L,7L,6L,4L,9L,9L,2L,1L,4L,9L,9L,5L,4L,0L,3L,0L,7L,3L,6L,2L,4L,7L,3L,5L,2L,1L,7L,4L,8L,9L,9L,9L,5L,4L,9L,4L,0L,5L,6L,1L,3L,9L,5L,5L,1L,0L,5L,7L,5L,7L,9L,8L,4L,7L,1L,7L,2L,2L,4L,2L,3L,1L,5L,9L,5L,8L,7L,8L,9L,4L,2L,1L,0L,7L,7L,7L,2L,4L,1L,5L,1L,1L,8L,3L,4L,1L,3L,0L,7L,2L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195381Inst : IEnumerable<long>
{
public static readonly long[] Value=A195381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195381.Bytes);
public long this[int i]=>Value[i];

public static A195381Inst Instance=new A195381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195382
{
public static readonly long[] Value={ 4L,8L,16L,18L,32L,50L,256L,512L,578L,1458L,2048L,3362L,4802L,6962L,8192L,10082L,15842L,20402L,31250L,34322L,55778L,57122L,59858L,167042L,171698L,293378L,524288L,559682L,916658L,982802L,1062882L,1104098L,1158242L,1195058L,1367858L,1407842L,1414562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195382Inst : IEnumerable<long>
{
public static readonly long[] Value=A195382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195382.Bytes);
public long this[int i]=>Value[i];

public static A195382Inst Instance=new A195382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195383
{
public static readonly long[] Value={ 1L,3L,5L,4L,0L,4L,4L,6L,2L,7L,7L,7L,2L,8L,4L,5L,8L,7L,1L,2L,8L,3L,3L,4L,4L,5L,0L,9L,1L,0L,4L,2L,8L,7L,1L,2L,4L,0L,6L,0L,4L,5L,8L,0L,9L,0L,6L,6L,0L,7L,0L,3L,6L,1L,9L,9L,7L,8L,9L,0L,3L,6L,6L,7L,7L,8L,5L,9L,7L,3L,8L,2L,3L,2L,1L,1L,8L,6L,9L,5L,5L,8L,9L,3L,8L,1L,4L,2L,5L,6L,0L,7L,7L,6L,8L,9L,8L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195383Inst : IEnumerable<long>
{
public static readonly long[] Value=A195383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195383.Bytes);
public long this[int i]=>Value[i];

public static A195383Inst Instance=new A195383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195384
{
public static readonly long[] Value={ 1L,7L,4L,8L,0L,6L,4L,0L,9L,7L,7L,9L,5L,2L,8L,4L,2L,8L,3L,1L,9L,7L,2L,0L,4L,8L,2L,0L,2L,2L,3L,0L,2L,0L,4L,5L,5L,1L,4L,9L,8L,8L,3L,2L,6L,3L,9L,4L,8L,2L,6L,8L,7L,5L,3L,6L,8L,0L,8L,2L,5L,1L,1L,4L,8L,0L,1L,8L,6L,1L,9L,6L,0L,1L,7L,7L,1L,3L,1L,1L,8L,2L,4L,9L,3L,8L,6L,0L,5L,7L,4L,0L,5L,1L,6L,5L,8L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195384Inst : IEnumerable<long>
{
public static readonly long[] Value=A195384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195384.Bytes);
public long this[int i]=>Value[i];

public static A195384Inst Instance=new A195384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195385
{
public static readonly long[] Value={ 6L,1L,1L,5L,5L,8L,3L,5L,1L,2L,7L,9L,6L,6L,4L,1L,3L,0L,6L,5L,6L,7L,7L,9L,3L,2L,2L,4L,2L,8L,8L,4L,4L,3L,2L,7L,0L,7L,7L,7L,0L,6L,7L,2L,5L,0L,0L,1L,8L,5L,3L,0L,9L,3L,1L,9L,2L,6L,0L,2L,3L,8L,0L,2L,9L,1L,7L,4L,6L,7L,0L,8L,6L,0L,9L,1L,9L,8L,1L,4L,4L,8L,1L,2L,6L,1L,1L,2L,9L,5L,1L,3L,1L,2L,6L,9L,9L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195385Inst : IEnumerable<long>
{
public static readonly long[] Value=A195385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195385.Bytes);
public long this[int i]=>Value[i];

public static A195385Inst Instance=new A195385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195386
{
public static readonly long[] Value={ 1L,0L,4L,5L,8L,3L,1L,3L,7L,9L,9L,7L,9L,9L,5L,5L,8L,7L,4L,9L,4L,8L,7L,2L,0L,5L,7L,5L,7L,0L,3L,4L,1L,1L,6L,8L,1L,4L,2L,4L,8L,5L,2L,0L,4L,7L,4L,4L,8L,0L,2L,4L,4L,0L,9L,4L,4L,5L,3L,8L,9L,4L,5L,8L,9L,0L,4L,0L,7L,2L,1L,2L,7L,2L,0L,5L,8L,6L,7L,2L,9L,0L,3L,5L,6L,3L,1L,8L,0L,3L,1L,7L,9L,4L,4L,5L,7L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195386Inst : IEnumerable<long>
{
public static readonly long[] Value=A195386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195386.Bytes);
public long this[int i]=>Value[i];

public static A195386Inst Instance=new A195386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195387
{
public static readonly long[] Value={ 1L,1L,4L,6L,8L,0L,9L,7L,5L,9L,1L,5L,8L,1L,9L,1L,6L,3L,0L,9L,5L,3L,7L,7L,6L,0L,0L,6L,5L,1L,9L,6L,8L,1L,6L,0L,7L,5L,5L,6L,7L,6L,8L,2L,9L,7L,3L,5L,9L,7L,5L,1L,3L,7L,2L,7L,2L,9L,8L,2L,4L,8L,5L,3L,3L,1L,7L,8L,9L,4L,6L,4L,4L,3L,9L,9L,1L,8L,6L,0L,9L,3L,6L,7L,6L,2L,0L,5L,1L,5L,2L,1L,5L,4L,4L,9L,5L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195387Inst : IEnumerable<long>
{
public static readonly long[] Value=A195387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195387.Bytes);
public long this[int i]=>Value[i];

public static A195387Inst Instance=new A195387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195388
{
public static readonly long[] Value={ 1L,4L,2L,0L,6L,2L,0L,2L,7L,3L,3L,9L,4L,4L,3L,7L,9L,4L,6L,4L,1L,5L,1L,4L,4L,8L,1L,2L,1L,1L,6L,1L,6L,9L,2L,3L,1L,9L,6L,3L,5L,3L,5L,3L,3L,1L,5L,4L,6L,4L,8L,9L,8L,8L,0L,5L,5L,3L,7L,5L,9L,3L,8L,5L,4L,7L,2L,5L,5L,9L,2L,8L,2L,3L,3L,2L,2L,9L,9L,1L,9L,3L,3L,6L,7L,4L,3L,8L,2L,1L,3L,1L,8L,4L,9L,2L,0L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195388Inst : IEnumerable<long>
{
public static readonly long[] Value=A195388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195388.Bytes);
public long this[int i]=>Value[i];

public static A195388Inst Instance=new A195388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195389
{
public static readonly long[] Value={ 5L,7L,3L,8L,9L,4L,9L,4L,2L,7L,4L,8L,6L,8L,2L,3L,0L,6L,8L,5L,9L,4L,1L,0L,2L,1L,1L,4L,2L,6L,4L,4L,0L,2L,2L,8L,6L,9L,3L,9L,8L,0L,8L,1L,9L,5L,3L,5L,4L,9L,9L,1L,1L,5L,0L,5L,7L,5L,2L,0L,9L,5L,2L,0L,9L,2L,4L,5L,4L,7L,0L,8L,0L,9L,5L,1L,8L,9L,1L,7L,5L,0L,5L,0L,8L,1L,2L,7L,6L,3L,1L,2L,8L,9L,1L,0L,5L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195389Inst : IEnumerable<long>
{
public static readonly long[] Value=A195389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195389.Bytes);
public long this[int i]=>Value[i];

public static A195389Inst Instance=new A195389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195390
{
public static readonly BigInteger[] Value={ 1L,720L,479001600L,6402373705728000L,BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("371993326789901217467999448150835200000000"),BigInteger.Parse("1405006117752879898543142606244511569936384000000000"),BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000") };
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
public class A195390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195390Inst Instance=new A195390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195391
{
public static readonly BigInteger[] Value={ 1L,5040L,87178291200L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("10333147966386144929666651337523200000000"),BigInteger.Parse("1405006117752879898543142606244511569936384000000000") };
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
public class A195391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195391Inst Instance=new A195391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195392
{
public static readonly BigInteger[] Value={ 1L,40320L,20922789888000L,BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("263130836933693530167218012160000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000"),BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000") };
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
public class A195392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195392Inst Instance=new A195392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195393
{
public static readonly BigInteger[] Value={ 1L,362880L,6402373705728000L,BigInteger.Parse("10888869450418352160768000000"),BigInteger.Parse("371993326789901217467999448150835200000000"),BigInteger.Parse("119622220865480194561963161495657715064383733760000000000") };
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
public class A195393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195393Inst Instance=new A195393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195394
{
public static readonly BigInteger[] Value={ 1L,3628800L,2432902008176640000L,BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000"),BigInteger.Parse("30414093201713378043612608166064768844377641568960512000000000000") };
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
public class A195394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195394Inst Instance=new A195394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195395
{
public static readonly long[] Value={ 1L,2L,0L,4L,4L,9L,9L,9L,5L,2L,4L,3L,8L,3L,0L,0L,4L,2L,2L,9L,6L,2L,6L,7L,7L,2L,0L,4L,9L,5L,5L,8L,8L,0L,4L,2L,5L,3L,7L,2L,4L,9L,9L,8L,3L,8L,1L,4L,3L,2L,7L,9L,8L,3L,2L,8L,9L,2L,3L,7L,3L,3L,6L,2L,4L,6L,2L,0L,5L,8L,0L,7L,9L,0L,1L,7L,0L,6L,1L,9L,5L,8L,9L,3L,3L,1L,3L,9L,8L,9L,3L,0L,0L,9L,4L,1L,9L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195395Inst : IEnumerable<long>
{
public static readonly long[] Value=A195395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195395.Bytes);
public long this[int i]=>Value[i];

public static A195395Inst Instance=new A195395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195396
{
public static readonly long[] Value={ 1L,2L,6L,9L,3L,1L,5L,7L,9L,8L,8L,6L,2L,5L,6L,0L,6L,6L,9L,2L,8L,7L,2L,7L,6L,7L,3L,2L,7L,3L,8L,9L,4L,5L,3L,9L,8L,4L,5L,1L,4L,1L,2L,8L,2L,1L,3L,5L,8L,1L,0L,2L,7L,4L,6L,3L,2L,9L,7L,6L,8L,8L,0L,1L,3L,5L,3L,3L,3L,4L,3L,2L,3L,8L,8L,1L,6L,1L,5L,3L,8L,4L,7L,1L,0L,3L,8L,3L,9L,2L,5L,9L,5L,2L,6L,3L,5L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195396Inst : IEnumerable<long>
{
public static readonly long[] Value=A195396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195396.Bytes);
public long this[int i]=>Value[i];

public static A195396Inst Instance=new A195396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195397
{
public static readonly long[] Value={ 1L,6L,1L,1L,7L,6L,7L,4L,0L,2L,9L,5L,1L,5L,5L,7L,4L,3L,0L,1L,9L,6L,1L,7L,7L,6L,1L,9L,1L,3L,8L,6L,0L,9L,9L,2L,5L,6L,8L,5L,5L,0L,2L,6L,1L,9L,9L,8L,1L,8L,8L,6L,9L,5L,5L,2L,9L,0L,1L,9L,7L,4L,2L,0L,0L,4L,3L,5L,5L,4L,8L,1L,6L,0L,9L,6L,5L,5L,3L,2L,4L,7L,8L,8L,4L,1L,0L,7L,5L,4L,1L,4L,8L,3L,9L,4L,0L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195397Inst : IEnumerable<long>
{
public static readonly long[] Value=A195397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195397.Bytes);
public long this[int i]=>Value[i];

public static A195397Inst Instance=new A195397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195398
{
public static readonly long[] Value={ 6L,0L,1L,1L,2L,6L,3L,9L,6L,9L,1L,7L,6L,5L,3L,2L,5L,1L,6L,5L,4L,1L,2L,6L,3L,7L,8L,7L,7L,7L,2L,6L,1L,0L,8L,0L,6L,6L,8L,6L,4L,0L,3L,9L,9L,9L,2L,3L,8L,7L,2L,4L,8L,9L,7L,2L,4L,2L,0L,2L,9L,3L,6L,6L,1L,0L,0L,0L,5L,1L,7L,6L,6L,5L,0L,8L,6L,4L,9L,9L,1L,2L,4L,1L,5L,6L,1L,6L,4L,8L,7L,5L,9L,2L,4L,6L,1L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195398Inst : IEnumerable<long>
{
public static readonly long[] Value=A195398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195398.Bytes);
public long this[int i]=>Value[i];

public static A195398Inst Instance=new A195398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195399
{
public static readonly long[] Value={ 1L,7L,5L,9L,3L,8L,2L,1L,5L,7L,0L,9L,6L,4L,9L,2L,5L,5L,8L,8L,6L,5L,1L,6L,3L,5L,2L,4L,9L,0L,0L,3L,8L,2L,0L,7L,0L,9L,2L,3L,3L,3L,8L,0L,9L,1L,3L,8L,8L,5L,4L,5L,5L,9L,0L,2L,6L,6L,5L,7L,5L,0L,5L,6L,7L,4L,7L,1L,6L,9L,1L,9L,7L,9L,7L,9L,3L,7L,4L,3L,5L,5L,4L,2L,1L,6L,8L,6L,5L,2L,7L,1L,7L,1L,1L,7L,4L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195399Inst : IEnumerable<long>
{
public static readonly long[] Value=A195399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195399.Bytes);
public long this[int i]=>Value[i];

public static A195399Inst Instance=new A195399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195400
{
public static readonly long[] Value={ 1L,8L,0L,5L,6L,6L,4L,9L,1L,8L,5L,8L,0L,5L,4L,5L,8L,7L,9L,3L,3L,1L,1L,7L,8L,9L,9L,5L,1L,4L,7L,6L,5L,2L,7L,6L,5L,7L,1L,9L,6L,5L,4L,4L,2L,2L,5L,5L,6L,7L,3L,3L,0L,9L,2L,8L,4L,2L,2L,2L,0L,7L,2L,1L,0L,6L,5L,2L,4L,1L,5L,6L,9L,0L,2L,6L,2L,8L,8L,4L,9L,6L,3L,1L,9L,4L,7L,6L,1L,5L,1L,3L,6L,7L,2L,7L,5L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195400Inst : IEnumerable<long>
{
public static readonly long[] Value=A195400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195400.Bytes);
public long this[int i]=>Value[i];

public static A195400Inst Instance=new A195400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195401
{
public static readonly long[] Value={ 2L,3L,2L,7L,4L,4L,3L,8L,2L,4L,4L,0L,0L,8L,4L,6L,3L,3L,6L,7L,8L,2L,0L,6L,0L,0L,0L,8L,1L,0L,6L,8L,5L,1L,2L,2L,3L,1L,8L,6L,3L,4L,7L,9L,3L,2L,4L,0L,1L,7L,7L,8L,8L,7L,3L,1L,2L,7L,0L,6L,5L,7L,2L,9L,3L,2L,9L,3L,0L,2L,6L,7L,7L,8L,4L,4L,8L,3L,1L,9L,8L,9L,1L,2L,6L,4L,2L,2L,3L,6L,0L,8L,6L,6L,7L,3L,7L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195401Inst : IEnumerable<long>
{
public static readonly long[] Value=A195401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195401.Bytes);
public long this[int i]=>Value[i];

public static A195401Inst Instance=new A195401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195402
{
public static readonly long[] Value={ 6L,1L,0L,8L,8L,9L,7L,8L,0L,3L,8L,6L,3L,8L,0L,0L,0L,7L,4L,4L,2L,4L,1L,2L,8L,8L,8L,6L,7L,4L,0L,4L,2L,2L,3L,3L,0L,2L,5L,7L,0L,5L,2L,7L,6L,9L,0L,4L,5L,9L,2L,0L,9L,4L,1L,1L,5L,0L,6L,5L,9L,3L,5L,1L,6L,6L,1L,7L,2L,9L,2L,4L,7L,9L,6L,2L,1L,7L,7L,0L,5L,9L,3L,1L,4L,8L,2L,1L,9L,7L,9L,6L,3L,6L,3L,8L,7L,7L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195402Inst : IEnumerable<long>
{
public static readonly long[] Value=A195402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195402.Bytes);
public long this[int i]=>Value[i];

public static A195402Inst Instance=new A195402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195403
{
public static readonly long[] Value={ 6L,9L,2L,0L,2L,8L,6L,7L,8L,4L,7L,1L,6L,5L,1L,7L,6L,7L,9L,0L,4L,3L,2L,8L,7L,4L,5L,2L,5L,6L,2L,9L,3L,2L,5L,2L,0L,0L,9L,4L,0L,2L,2L,7L,5L,9L,3L,1L,3L,3L,3L,2L,2L,7L,0L,3L,7L,6L,1L,6L,4L,8L,0L,3L,3L,1L,9L,2L,5L,7L,7L,4L,5L,6L,5L,6L,6L,8L,8L,7L,5L,7L,5L,3L,6L,4L,5L,9L,7L,8L,4L,0L,1L,8L,6L,1L,7L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195403Inst : IEnumerable<long>
{
public static readonly long[] Value=A195403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195403.Bytes);
public long this[int i]=>Value[i];

public static A195403Inst Instance=new A195403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195404
{
public static readonly long[] Value={ 7L,2L,7L,0L,9L,2L,0L,6L,2L,9L,2L,8L,0L,7L,0L,1L,2L,0L,5L,2L,4L,5L,5L,7L,2L,3L,6L,3L,8L,0L,5L,8L,0L,9L,4L,1L,6L,2L,4L,2L,4L,2L,5L,2L,1L,7L,4L,5L,8L,0L,8L,3L,2L,5L,7L,3L,6L,5L,7L,5L,7L,6L,7L,7L,6L,9L,1L,4L,1L,5L,2L,5L,3L,8L,2L,8L,6L,6L,1L,4L,9L,5L,9L,7L,1L,7L,4L,1L,8L,1L,0L,0L,0L,1L,3L,4L,3L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195404Inst : IEnumerable<long>
{
public static readonly long[] Value=A195404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195404.Bytes);
public long this[int i]=>Value[i];

public static A195404Inst Instance=new A195404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195405
{
public static readonly long[] Value={ 9L,2L,4L,8L,7L,5L,3L,9L,1L,0L,5L,0L,2L,2L,5L,1L,3L,0L,6L,6L,2L,6L,2L,5L,1L,7L,3L,5L,1L,2L,7L,4L,5L,4L,1L,0L,7L,5L,2L,6L,0L,3L,3L,5L,1L,6L,5L,1L,0L,7L,9L,4L,9L,3L,7L,5L,4L,9L,9L,2L,8L,7L,4L,8L,9L,5L,6L,7L,6L,4L,5L,9L,7L,1L,1L,9L,6L,7L,4L,8L,8L,3L,6L,5L,6L,5L,2L,1L,1L,4L,4L,1L,6L,1L,0L,2L,5L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195405Inst : IEnumerable<long>
{
public static readonly long[] Value=A195405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195405.Bytes);
public long this[int i]=>Value[i];

public static A195405Inst Instance=new A195405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195406
{
public static readonly long[] Value={ 6L,0L,2L,5L,6L,1L,3L,9L,1L,2L,8L,6L,1L,1L,4L,8L,6L,1L,7L,9L,4L,1L,5L,7L,2L,2L,9L,1L,1L,6L,8L,4L,7L,1L,7L,8L,6L,3L,8L,5L,7L,4L,5L,3L,6L,2L,9L,6L,6L,4L,0L,6L,1L,3L,7L,0L,4L,5L,5L,2L,3L,8L,4L,6L,2L,3L,4L,6L,6L,8L,3L,6L,1L,2L,1L,4L,7L,7L,2L,7L,4L,9L,7L,8L,2L,7L,2L,9L,9L,9L,0L,1L,8L,7L,3L,1L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195406Inst : IEnumerable<long>
{
public static readonly long[] Value=A195406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195406.Bytes);
public long this[int i]=>Value[i];

public static A195406Inst Instance=new A195406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195407
{
public static readonly long[] Value={ 5L,1L,2L,5L,2L,2L,2L,7L,2L,3L,6L,2L,2L,2L,5L,3L,7L,9L,2L,6L,3L,5L,4L,9L,4L,5L,5L,8L,1L,0L,7L,3L,5L,5L,1L,6L,9L,4L,7L,8L,2L,1L,9L,0L,8L,2L,6L,1L,4L,2L,4L,2L,5L,7L,4L,2L,0L,1L,3L,0L,4L,2L,4L,3L,2L,2L,0L,8L,9L,6L,5L,5L,7L,2L,5L,0L,5L,7L,7L,4L,0L,5L,1L,8L,9L,2L,2L,1L,3L,7L,8L,5L,6L,1L,3L,0L,7L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195407Inst : IEnumerable<long>
{
public static readonly long[] Value=A195407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195407.Bytes);
public long this[int i]=>Value[i];

public static A195407Inst Instance=new A195407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195408
{
public static readonly long[] Value={ 6L,1L,1L,9L,2L,5L,9L,5L,8L,1L,2L,5L,9L,0L,9L,7L,6L,8L,1L,1L,4L,8L,3L,8L,0L,1L,4L,4L,0L,1L,1L,7L,0L,7L,3L,8L,9L,1L,9L,7L,3L,5L,9L,3L,3L,2L,2L,6L,3L,5L,9L,0L,0L,3L,8L,0L,1L,2L,5L,7L,4L,9L,5L,7L,9L,0L,0L,8L,0L,7L,8L,3L,8L,6L,7L,6L,4L,6L,9L,8L,7L,4L,1L,9L,9L,1L,3L,8L,6L,4L,4L,5L,1L,1L,6L,1L,9L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195408Inst : IEnumerable<long>
{
public static readonly long[] Value=A195408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195408.Bytes);
public long this[int i]=>Value[i];

public static A195408Inst Instance=new A195408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195409
{
public static readonly long[] Value={ 7L,1L,2L,7L,8L,7L,9L,1L,7L,3L,8L,5L,2L,0L,1L,2L,3L,3L,8L,0L,1L,6L,0L,9L,4L,6L,9L,7L,2L,6L,8L,2L,7L,1L,4L,1L,7L,5L,3L,6L,0L,7L,6L,5L,8L,6L,6L,8L,5L,4L,6L,6L,9L,8L,4L,2L,4L,8L,1L,2L,2L,8L,5L,5L,4L,1L,6L,3L,4L,0L,6L,1L,1L,8L,1L,9L,2L,3L,1L,9L,4L,8L,0L,4L,3L,8L,8L,6L,7L,5L,2L,7L,4L,6L,6L,0L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195409Inst : IEnumerable<long>
{
public static readonly long[] Value=A195409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195409.Bytes);
public long this[int i]=>Value[i];

public static A195409Inst Instance=new A195409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195410
{
public static readonly long[] Value={ 4L,6L,2L,9L,9L,9L,2L,8L,1L,8L,7L,2L,9L,4L,5L,1L,4L,5L,2L,5L,2L,4L,9L,1L,5L,0L,8L,8L,0L,0L,5L,4L,7L,8L,7L,1L,6L,2L,5L,0L,7L,4L,6L,2L,2L,4L,2L,6L,4L,0L,6L,4L,3L,1L,7L,5L,1L,9L,0L,9L,4L,4L,8L,2L,9L,9L,3L,2L,7L,6L,6L,5L,8L,4L,3L,7L,5L,6L,1L,8L,7L,5L,0L,9L,0L,4L,1L,7L,1L,3L,4L,1L,1L,0L,7L,0L,4L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195410Inst : IEnumerable<long>
{
public static readonly long[] Value=A195410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195410.Bytes);
public long this[int i]=>Value[i];

public static A195410Inst Instance=new A195410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195411
{
public static readonly long[] Value={ 6L,2L,9L,7L,8L,7L,2L,0L,2L,2L,0L,0L,9L,1L,5L,1L,1L,5L,5L,8L,4L,3L,1L,7L,8L,2L,0L,2L,0L,7L,6L,2L,4L,2L,9L,0L,1L,2L,4L,9L,2L,0L,7L,0L,2L,7L,5L,8L,5L,4L,9L,3L,4L,3L,9L,5L,9L,7L,0L,0L,0L,9L,8L,1L,3L,7L,7L,3L,1L,1L,3L,4L,1L,0L,7L,7L,9L,5L,2L,1L,2L,0L,6L,7L,3L,6L,7L,6L,7L,3L,0L,7L,0L,5L,6L,2L,8L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195411Inst : IEnumerable<long>
{
public static readonly long[] Value=A195411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195411.Bytes);
public long this[int i]=>Value[i];

public static A195411Inst Instance=new A195411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195412
{
public static readonly long[] Value={ 3L,2L,6L,8L,5L,0L,5L,3L,9L,8L,0L,7L,1L,2L,0L,6L,3L,7L,7L,1L,0L,0L,2L,1L,3L,3L,3L,6L,8L,5L,3L,8L,6L,5L,8L,9L,3L,3L,0L,4L,0L,5L,7L,8L,5L,6L,4L,9L,3L,4L,6L,0L,1L,3L,3L,6L,0L,9L,8L,0L,3L,4L,6L,4L,6L,2L,9L,0L,5L,1L,3L,6L,7L,8L,6L,1L,7L,0L,4L,5L,2L,8L,9L,0L,5L,2L,8L,9L,7L,5L,7L,9L,2L,6L,9L,2L,9L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195412Inst : IEnumerable<long>
{
public static readonly long[] Value=A195412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195412.Bytes);
public long this[int i]=>Value[i];

public static A195412Inst Instance=new A195412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195413
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,3L,1L,7L,7L,7L,5L,1L,2L,1L,1L,5L,6L,6L,8L,6L,8L,4L,0L,3L,3L,8L,9L,2L,2L,1L,5L,4L,7L,4L,5L,8L,6L,3L,0L,2L,5L,5L,4L,4L,9L,2L,3L,1L,4L,4L,4L,0L,4L,7L,4L,0L,9L,4L,4L,8L,6L,0L,5L,7L,1L,5L,7L,9L,1L,1L,4L,8L,5L,8L,4L,2L,2L,6L,3L,9L,6L,6L,9L,8L,1L,4L,7L,1L,6L,1L,7L,5L,0L,7L,0L,6L,0L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195413Inst : IEnumerable<long>
{
public static readonly long[] Value=A195413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195413.Bytes);
public long this[int i]=>Value[i];

public static A195413Inst Instance=new A195413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195414
{
public static readonly long[] Value={ 6L,4L,9L,5L,1L,6L,0L,5L,0L,2L,9L,2L,0L,9L,4L,5L,3L,2L,4L,4L,9L,9L,3L,9L,5L,2L,6L,3L,7L,4L,2L,5L,2L,4L,7L,5L,8L,1L,4L,1L,8L,7L,5L,7L,5L,9L,9L,5L,3L,5L,1L,0L,7L,5L,6L,6L,3L,8L,3L,8L,5L,2L,2L,9L,2L,8L,8L,4L,5L,4L,9L,7L,1L,6L,2L,6L,9L,8L,8L,7L,3L,3L,6L,7L,7L,6L,6L,2L,9L,4L,8L,0L,8L,7L,6L,3L,4L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195414Inst : IEnumerable<long>
{
public static readonly long[] Value=A195414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195414.Bytes);
public long this[int i]=>Value[i];

public static A195414Inst Instance=new A195414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195415
{
public static readonly BigInteger[] Value={ 1L,2L,10L,92L,1351L,28982L,855100L,33214232L,1642999501L,100843185962L,7520379392890L,669760178257172L,70211429619908851L,8558006664633638942L,BigInteger.Parse("1200128210993564085880"),BigInteger.Parse("191861070874818576596912"),BigInteger.Parse("34685967730611200643509401"),BigInteger.Parse("7041037426518318365605795922") };
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
public class A195415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195415Inst Instance=new A195415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195416
{
public static readonly long[] Value={ 2L,3L,19L,29L,31L,59L,73L,149L,179L,199L,211L,271L,281L,311L,337L,347L,349L,359L,433L,449L,479L,523L,547L,659L,661L,683L,727L,733L,809L,821L,823L,829L,857L,877L,947L,977L,983L,1049L,1129L,1181L,1201L,1213L,1291L,1297L,1301L,1307L,1321L,1367L,1429L,1433L,1439L,1451L,1489L,1493L,1511L,1553L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195416Inst : IEnumerable<long>
{
public static readonly long[] Value=A195416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195416.Bytes);
public long this[int i]=>Value[i];

public static A195416Inst Instance=new A195416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195417
{
public static readonly long[] Value={ 1L,3L,9L,25L,63L,171L,471L,1193L,3209L,8841L,22537L,60393L,165489L,424451L,1134849L,3093893L,7987289L,21288933L,57973543L,150409931L,399788279L,1085870421L,2831439537L,7501994181L,20330726077L,53274740933L,140615421393L,380366331549L,1002078031627L,2634444052559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195417Inst : IEnumerable<long>
{
public static readonly long[] Value=A195417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195417.Bytes);
public long this[int i]=>Value[i];

public static A195417Inst Instance=new A195417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195418
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,33L,5L,33L,341L,1045L,189L,1299L,891L,4437L,9477L,581L,3855L,105525L,27825L,23751L,173043L,10531345L,56511L,2386125L,380955L,256861L,24926139L,5108467L,32397379L,930343095L,930291L,36512775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195418Inst : IEnumerable<long>
{
public static readonly long[] Value=A195418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195418.Bytes);
public long this[int i]=>Value[i];

public static A195418Inst Instance=new A195418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195419
{
public static readonly long[] Value={ 8L,18L,27L,28L,33L,34L,36L,37L,38L,44L,46L,47L,48L,49L,57L,58L,68L,75L,76L,77L,78L,81L,82L,83L,85L,86L,87L,88L,89L,94L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195419Inst : IEnumerable<long>
{
public static readonly long[] Value=A195419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195419.Bytes);
public long this[int i]=>Value[i];

public static A195419Inst Instance=new A195419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195420
{
public static readonly long[] Value={ 125L,126L,127L,2500L,2501L,2502L,2503L,2504L,2505L,2506L,2507L,2508L,6144L,11663L,11664L,12100L,12101L,12102L,12103L,12104L,12105L,12106L,12107L,12108L,12768L,13822L,13823L,13824L,13825L,15378L,15567L,15585L,15612L,15617L,15620L,15621L,15622L,15623L,15624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195420Inst : IEnumerable<long>
{
public static readonly long[] Value=A195420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195420.Bytes);
public long this[int i]=>Value[i];

public static A195420Inst Instance=new A195420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195421
{
public static readonly BigInteger[] Value={ 3L,17L,3L,253124999L,4076863487L,578415690713087L,139967L,BigInteger.Parse("14097567309074239886172287"),BigInteger.Parse("73099303486215558911"),BigInteger.Parse("8954942912818222989311"),BigInteger.Parse("213770812332484473348458269897727733773465812991"),578415690713087L,BigInteger.Parse("66266428660760838427050496741110705203446361497484562431") };
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
public class A195421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195421Inst Instance=new A195421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195422
{
public static readonly long[] Value={ -3L,2L,2L,-8L,16L,-16L,80L,384L,4160L,43008L,494336L,6136832L,82118656L,1178294272L,18053433344L,294241402880L,5083946115072L,92835116318720L,1786595439869952L,36144509314138112L,766933328068345856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195422Inst : IEnumerable<long>
{
public static readonly long[] Value=A195422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195422.Bytes);
public long this[int i]=>Value[i];

public static A195422Inst Instance=new A195422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195423
{
public static readonly long[] Value={ 0L,4L,6L,1L,9L,1L,4L,1L,7L,9L,3L,2L,2L,4L,2L,0L,6L,7L,6L,2L,8L,6L,2L,0L,4L,9L,5L,8L,1L,2L,9L,9L,0L,5L,8L,3L,2L,4L,3L,8L,6L,4L,2L,5L,4L,3L,0L,4L,1L,0L,1L,5L,1L,9L,0L,5L,0L,7L,8L,4L,1L,4L,4L,4L,2L,5L,9L,4L,2L,7L,1L,2L,9L,5L,3L,4L,4L,9L,1L,5L,9L,9L,4L,1L,5L,9L,7L,1L,3L,9L,0L,2L,3L,4L,1L,9L,6L,6L,6L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195423Inst : IEnumerable<long>
{
public static readonly long[] Value=A195423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195423.Bytes);
public long this[int i]=>Value[i];

public static A195423Inst Instance=new A195423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195424
{
public static readonly long[] Value={ 5L,8L,4L,7L,1L,3L,2L,5L,5L,9L,5L,0L,1L,4L,2L,2L,4L,5L,6L,7L,6L,1L,2L,1L,4L,1L,6L,4L,2L,7L,0L,6L,2L,1L,7L,4L,5L,9L,1L,6L,1L,6L,2L,7L,0L,2L,9L,2L,0L,4L,7L,0L,4L,5L,4L,7L,8L,0L,8L,9L,1L,5L,8L,3L,6L,9L,1L,8L,0L,5L,9L,4L,1L,7L,7L,6L,9L,8L,5L,7L,4L,3L,1L,8L,8L,1L,4L,1L,4L,4L,1L,1L,7L,3L,8L,7L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195424Inst : IEnumerable<long>
{
public static readonly long[] Value=A195424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195424.Bytes);
public long this[int i]=>Value[i];

public static A195424Inst Instance=new A195424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195425
{
public static readonly long[] Value={ 4L,6L,1L,9L,7L,4L,5L,4L,3L,9L,8L,3L,9L,2L,0L,2L,0L,4L,1L,2L,3L,3L,4L,1L,3L,5L,5L,1L,1L,2L,8L,8L,7L,5L,1L,3L,2L,9L,8L,3L,3L,3L,9L,2L,9L,7L,2L,3L,9L,9L,1L,7L,2L,4L,3L,7L,1L,4L,5L,8L,3L,1L,5L,5L,8L,0L,6L,0L,9L,4L,1L,2L,3L,1L,3L,1L,7L,1L,1L,6L,7L,7L,8L,1L,2L,3L,0L,2L,3L,2L,0L,7L,4L,5L,6L,0L,8L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195425Inst : IEnumerable<long>
{
public static readonly long[] Value=A195425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195425.Bytes);
public long this[int i]=>Value[i];

public static A195425Inst Instance=new A195425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195426
{
public static readonly long[] Value={ 1L,3L,8L,2L,1L,1L,5L,8L,6L,0L,2L,8L,3L,0L,9L,9L,8L,8L,2L,6L,2L,0L,7L,5L,3L,9L,9L,1L,3L,0L,7L,2L,8L,0L,2L,7L,9L,6L,5L,1L,8L,4L,5L,0L,4L,8L,2L,3L,5L,7L,9L,5L,9L,2L,6L,9L,4L,3L,5L,8L,5L,0L,5L,0L,6L,0L,8L,5L,3L,2L,2L,1L,3L,5L,1L,9L,2L,4L,4L,8L,4L,5L,0L,1L,0L,0L,3L,8L,2L,2L,7L,4L,4L,9L,2L,4L,2L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195426Inst : IEnumerable<long>
{
public static readonly long[] Value=A195426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195426.Bytes);
public long this[int i]=>Value[i];

public static A195426Inst Instance=new A195426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195427
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,4L,4L,2L,3L,2L,2L,5L,9L,6L,9L,8L,0L,5L,1L,3L,3L,2L,5L,9L,6L,3L,6L,3L,2L,5L,9L,7L,9L,7L,9L,3L,1L,2L,0L,8L,2L,0L,5L,9L,2L,3L,8L,6L,3L,6L,7L,9L,5L,7L,6L,4L,6L,8L,9L,2L,4L,2L,6L,6L,4L,9L,6L,6L,3L,4L,6L,2L,0L,7L,7L,2L,0L,8L,7L,9L,0L,4L,1L,4L,8L,0L,4L,8L,3L,2L,3L,8L,8L,1L,7L,7L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195427Inst : IEnumerable<long>
{
public static readonly long[] Value=A195427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195427.Bytes);
public long this[int i]=>Value[i];

public static A195427Inst Instance=new A195427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195428
{
public static readonly long[] Value={ 5L,4L,7L,5L,5L,9L,7L,9L,0L,6L,2L,3L,7L,4L,8L,1L,9L,4L,9L,7L,8L,0L,9L,9L,1L,0L,4L,0L,6L,1L,8L,1L,2L,0L,6L,8L,9L,4L,1L,2L,4L,9L,9L,2L,3L,2L,7L,6L,0L,9L,9L,2L,1L,5L,8L,8L,6L,0L,5L,9L,9L,6L,3L,0L,0L,6L,9L,2L,9L,4L,7L,9L,9L,8L,3L,8L,6L,1L,5L,7L,2L,0L,0L,1L,0L,8L,4L,5L,1L,6L,4L,1L,2L,8L,5L,3L,7L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195428Inst : IEnumerable<long>
{
public static readonly long[] Value=A195428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195428.Bytes);
public long this[int i]=>Value[i];

public static A195428Inst Instance=new A195428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195429
{
public static readonly long[] Value={ 5L,1L,7L,3L,5L,3L,1L,7L,6L,9L,8L,3L,7L,2L,5L,8L,2L,9L,8L,7L,7L,0L,6L,2L,9L,5L,8L,5L,1L,6L,9L,4L,5L,9L,7L,3L,6L,9L,1L,8L,7L,6L,6L,2L,8L,8L,3L,4L,7L,7L,9L,1L,4L,5L,8L,0L,7L,8L,6L,2L,8L,2L,2L,6L,5L,2L,8L,7L,0L,9L,0L,5L,8L,2L,6L,1L,4L,0L,1L,9L,2L,3L,8L,7L,1L,8L,8L,0L,3L,9L,1L,8L,1L,3L,2L,8L,6L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195429Inst : IEnumerable<long>
{
public static readonly long[] Value=A195429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195429.Bytes);
public long this[int i]=>Value[i];

public static A195429Inst Instance=new A195429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195430
{
public static readonly long[] Value={ 1L,0L,6L,7L,1L,1L,6L,5L,0L,3L,6L,7L,1L,3L,5L,9L,4L,3L,5L,0L,4L,0L,6L,6L,1L,9L,1L,8L,2L,1L,2L,5L,9L,6L,0L,2L,6L,8L,7L,8L,6L,6L,7L,0L,4L,4L,8L,6L,1L,3L,2L,0L,4L,4L,4L,6L,5L,3L,9L,1L,7L,8L,9L,4L,6L,0L,7L,8L,6L,0L,5L,1L,2L,1L,4L,6L,9L,3L,4L,5L,5L,7L,5L,6L,2L,3L,1L,7L,9L,8L,4L,7L,6L,0L,2L,9L,4L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195430Inst : IEnumerable<long>
{
public static readonly long[] Value=A195430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195430.Bytes);
public long this[int i]=>Value[i];

public static A195430Inst Instance=new A195430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195431
{
public static readonly long[] Value={ 8L,4L,5L,5L,7L,1L,8L,1L,7L,5L,1L,2L,6L,5L,2L,7L,6L,2L,6L,9L,2L,1L,0L,8L,8L,0L,8L,0L,5L,4L,2L,1L,9L,2L,0L,8L,2L,2L,4L,0L,4L,3L,6L,0L,1L,4L,3L,4L,1L,9L,9L,2L,7L,6L,2L,8L,4L,5L,8L,1L,0L,0L,3L,1L,4L,5L,7L,9L,6L,3L,5L,7L,2L,1L,3L,9L,1L,2L,0L,9L,7L,2L,3L,0L,7L,6L,9L,8L,2L,9L,1L,1L,1L,6L,1L,9L,2L,3L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195431Inst : IEnumerable<long>
{
public static readonly long[] Value=A195431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195431.Bytes);
public long this[int i]=>Value[i];

public static A195431Inst Instance=new A195431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195432
{
public static readonly long[] Value={ 6L,0L,7L,5L,1L,0L,3L,7L,4L,5L,4L,1L,9L,3L,4L,5L,0L,6L,9L,0L,2L,4L,5L,8L,4L,2L,1L,1L,9L,5L,9L,4L,0L,3L,0L,2L,1L,9L,8L,6L,4L,6L,8L,1L,8L,7L,8L,2L,5L,7L,4L,7L,1L,6L,6L,8L,6L,5L,9L,0L,4L,3L,0L,1L,0L,1L,6L,3L,1L,9L,4L,3L,7L,9L,6L,7L,4L,6L,7L,1L,1L,7L,9L,5L,0L,6L,8L,9L,6L,3L,2L,6L,3L,3L,1L,0L,6L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195432Inst : IEnumerable<long>
{
public static readonly long[] Value=A195432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195432.Bytes);
public long this[int i]=>Value[i];

public static A195432Inst Instance=new A195432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195433
{
public static readonly long[] Value={ 6L,1L,4L,7L,5L,7L,2L,2L,7L,2L,3L,3L,3L,9L,0L,6L,2L,1L,5L,9L,3L,3L,1L,9L,2L,4L,8L,0L,9L,1L,1L,9L,0L,0L,9L,9L,4L,7L,1L,1L,6L,2L,5L,4L,4L,6L,2L,5L,6L,9L,8L,3L,6L,3L,8L,5L,8L,2L,6L,4L,6L,7L,2L,6L,2L,1L,6L,2L,5L,6L,1L,1L,4L,6L,1L,7L,9L,6L,2L,0L,4L,1L,6L,1L,6L,8L,8L,1L,5L,6L,9L,9L,9L,1L,9L,3L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195433Inst : IEnumerable<long>
{
public static readonly long[] Value=A195433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195433.Bytes);
public long this[int i]=>Value[i];

public static A195433Inst Instance=new A195433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195434
{
public static readonly long[] Value={ 6L,4L,8L,7L,8L,2L,1L,3L,4L,1L,2L,6L,1L,6L,1L,2L,8L,5L,3L,8L,8L,8L,0L,3L,0L,3L,8L,0L,7L,6L,6L,9L,3L,5L,6L,0L,6L,1L,9L,4L,0L,3L,5L,5L,7L,0L,5L,8L,6L,7L,9L,5L,2L,3L,3L,9L,6L,4L,1L,2L,8L,3L,6L,3L,6L,8L,3L,3L,2L,9L,8L,5L,3L,3L,9L,6L,2L,2L,6L,7L,3L,0L,3L,5L,9L,1L,4L,7L,7L,3L,5L,6L,8L,8L,4L,0L,8L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195434Inst : IEnumerable<long>
{
public static readonly long[] Value=A195434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195434.Bytes);
public long this[int i]=>Value[i];

public static A195434Inst Instance=new A195434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195435
{
public static readonly long[] Value={ 1L,3L,8L,7L,3L,1L,2L,7L,2L,8L,3L,1L,3L,8L,2L,0L,9L,1L,7L,4L,6L,3L,3L,6L,0L,2L,4L,0L,9L,8L,2L,2L,3L,3L,2L,1L,2L,5L,9L,6L,4L,4L,1L,8L,6L,2L,5L,1L,6L,9L,7L,6L,7L,6L,7L,4L,7L,6L,5L,4L,1L,2L,8L,4L,2L,3L,5L,6L,2L,8L,3L,4L,5L,5L,0L,0L,9L,7L,1L,9L,7L,9L,4L,1L,5L,3L,7L,9L,6L,0L,7L,3L,5L,5L,9L,4L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195435Inst : IEnumerable<long>
{
public static readonly long[] Value=A195435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195435.Bytes);
public long this[int i]=>Value[i];

public static A195435Inst Instance=new A195435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195436
{
public static readonly long[] Value={ 6L,3L,6L,2L,5L,8L,8L,2L,1L,0L,6L,1L,8L,3L,8L,3L,0L,8L,3L,9L,1L,0L,4L,9L,4L,6L,4L,7L,1L,0L,4L,3L,7L,5L,9L,8L,2L,9L,4L,2L,4L,3L,3L,0L,0L,8L,7L,6L,1L,6L,2L,8L,8L,5L,0L,0L,2L,6L,7L,6L,5L,8L,5L,1L,0L,8L,4L,8L,1L,3L,7L,7L,6L,0L,3L,6L,0L,0L,4L,4L,4L,8L,7L,7L,2L,6L,6L,5L,6L,5L,0L,1L,9L,9L,7L,7L,4L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195436Inst : IEnumerable<long>
{
public static readonly long[] Value=A195436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195436.Bytes);
public long this[int i]=>Value[i];

public static A195436Inst Instance=new A195436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195437
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,14L,17L,19L,21L,23L,26L,28L,30L,32L,34L,37L,39L,41L,43L,45L,47L,50L,52L,54L,56L,58L,60L,62L,65L,67L,69L,71L,73L,75L,77L,79L,82L,84L,86L,88L,90L,92L,94L,96L,98L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,122L,124L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195437Inst : IEnumerable<long>
{
public static readonly long[] Value=A195437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195437.Bytes);
public long this[int i]=>Value[i];

public static A195437Inst Instance=new A195437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195438
{
public static readonly long[] Value={ 141494L,143413L,144113L,144417L,144453L,144533L,144544L,144744L,148334L,150908L,150918L,151153L,151157L,151688L,151767L,151787L,151898L,154144L,155113L,155133L,155138L,155158L,155577L,155707L,155757L,155788L,155813L,157157L,157557L,157753L,157813L,158113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195438Inst : IEnumerable<long>
{
public static readonly long[] Value=A195438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195438.Bytes);
public long this[int i]=>Value[i];

public static A195438Inst Instance=new A195438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195439
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,16L,23L,26L,32L,37L,64L,89L,149L,173L,251L,307L,317L,956L,30197L,46058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195439Inst : IEnumerable<long>
{
public static readonly long[] Value=A195439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195439.Bytes);
public long this[int i]=>Value[i];

public static A195439Inst Instance=new A195439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195440
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,134L,968L,7662L,65135L,587040L,5559342L,54965230L,564651110L,6004908296L,65920345700L,745289233564L,8661959227407L,103330815828292L,1263608418272768L,15823268263301680L,202712359166886406L,2654710188935753950L,BigInteger.Parse("35514167158635839770") };
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
public class A195440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195440Inst Instance=new A195440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195441
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,2L,6L,3L,10L,2L,6L,2L,210L,30L,6L,3L,30L,10L,210L,42L,330L,30L,30L,30L,546L,42L,14L,2L,30L,2L,462L,231L,3570L,210L,6L,2L,51870L,2730L,210L,42L,2310L,330L,2310L,210L,4830L,210L,210L,210L,6630L,1326L,858L,66L,330L,110L,798L,114L,870L,30L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195441Inst : IEnumerable<long>
{
public static readonly long[] Value=A195441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195441.Bytes);
public long this[int i]=>Value[i];

public static A195441Inst Instance=new A195441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195442
{
public static readonly BigInteger[] Value={ 1L,4L,38L,604L,13797L,416168L,15711490L,715565508L,38278167466L,2356801113088L,164391501446500L,12826066272723832L,1107734575497955773L,BigInteger.Parse("104985517080964044744"),BigInteger.Parse("10838759916371136482170"),BigInteger.Parse("1211294776167588947134004"),BigInteger.Parse("145737426974188872882131694") };
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
public class A195442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195442Inst Instance=new A195442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195443
{
public static readonly BigInteger[] Value={ 1L,2L,17L,268L,6218L,191092L,7331943L,338203880L,18267488524L,1132962942756L,79464790795184L,6226443470442668L,539554771302358998L,BigInteger.Parse("51273487668881045852"),BigInteger.Parse("5305090125544931178395"),BigInteger.Parse("593952571797108683880684"),BigInteger.Parse("71571203087218842477715328"),BigInteger.Parse("9238664328667537859230164188") };
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
public class A195443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195443Inst Instance=new A195443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195444
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,6L,4L,8L,6L,9L,4L,3L,5L,2L,7L,6L,7L,1L,8L,6L,7L,5L,9L,0L,8L,9L,5L,5L,5L,1L,8L,7L,7L,7L,3L,5L,1L,2L,3L,8L,9L,1L,0L,5L,1L,4L,0L,2L,3L,5L,9L,5L,2L,4L,1L,1L,9L,9L,6L,4L,0L,3L,7L,9L,6L,8L,4L,1L,2L,6L,3L,7L,5L,2L,0L,3L,6L,5L,0L,4L,8L,6L,0L,7L,9L,5L,8L,1L,1L,3L,9L,7L,2L,3L,4L,1L,9L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195444Inst : IEnumerable<long>
{
public static readonly long[] Value=A195444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195444.Bytes);
public long this[int i]=>Value[i];

public static A195444Inst Instance=new A195444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195445
{
public static readonly long[] Value={ 6L,0L,1L,9L,5L,1L,6L,4L,4L,9L,0L,2L,1L,0L,9L,2L,7L,8L,2L,6L,3L,3L,7L,5L,8L,2L,4L,3L,3L,0L,3L,7L,4L,1L,6L,3L,5L,4L,2L,6L,3L,8L,1L,1L,4L,9L,5L,6L,4L,2L,9L,1L,5L,9L,5L,5L,0L,8L,2L,4L,1L,1L,2L,1L,3L,9L,3L,7L,1L,4L,5L,5L,3L,6L,4L,4L,0L,6L,2L,4L,0L,7L,4L,7L,6L,8L,6L,1L,9L,7L,6L,4L,4L,6L,6L,2L,0L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195445Inst : IEnumerable<long>
{
public static readonly long[] Value=A195445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195445.Bytes);
public long this[int i]=>Value[i];

public static A195445Inst Instance=new A195445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195446
{
public static readonly long[] Value={ 6L,5L,8L,0L,5L,2L,5L,9L,6L,8L,2L,3L,1L,4L,3L,9L,7L,9L,5L,9L,1L,2L,2L,6L,4L,9L,3L,8L,8L,7L,8L,9L,4L,3L,8L,6L,6L,6L,0L,8L,2L,7L,9L,8L,0L,7L,1L,5L,6L,3L,6L,8L,4L,9L,1L,7L,5L,2L,8L,9L,9L,0L,2L,6L,1L,5L,7L,1L,6L,3L,0L,5L,6L,9L,9L,4L,8L,4L,7L,7L,6L,5L,9L,2L,8L,5L,4L,3L,4L,9L,0L,5L,1L,8L,7L,7L,6L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195446Inst : IEnumerable<long>
{
public static readonly long[] Value=A195446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195446.Bytes);
public long this[int i]=>Value[i];

public static A195446Inst Instance=new A195446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195447
{
public static readonly long[] Value={ 1L,8L,0L,1L,8L,6L,6L,2L,4L,2L,4L,7L,4L,4L,9L,4L,6L,0L,8L,4L,7L,6L,8L,6L,9L,5L,5L,0L,8L,9L,8L,5L,4L,1L,3L,2L,7L,3L,2L,0L,1L,3L,0L,8L,1L,3L,4L,9L,9L,3L,3L,7L,6L,7L,8L,8L,7L,9L,9L,2L,0L,1L,0L,7L,7L,9L,9L,5L,3L,6L,2L,0L,2L,8L,4L,4L,8L,8L,8L,3L,8L,7L,8L,2L,5L,1L,0L,5L,9L,0L,6L,4L,2L,0L,4L,3L,1L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195447Inst : IEnumerable<long>
{
public static readonly long[] Value=A195447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195447.Bytes);
public long this[int i]=>Value[i];

public static A195447Inst Instance=new A195447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195448
{
public static readonly long[] Value={ 1L,5L,6L,3L,1L,9L,1L,0L,3L,6L,6L,7L,5L,6L,7L,7L,4L,9L,2L,4L,7L,0L,0L,3L,6L,7L,4L,1L,2L,9L,7L,1L,4L,5L,4L,0L,4L,7L,4L,4L,9L,8L,0L,7L,0L,3L,8L,3L,7L,4L,3L,2L,0L,7L,6L,5L,2L,1L,0L,8L,7L,5L,3L,3L,7L,0L,4L,0L,4L,6L,2L,7L,2L,9L,1L,3L,4L,7L,9L,3L,3L,8L,8L,2L,5L,8L,0L,1L,4L,2L,1L,0L,5L,6L,0L,3L,3L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195448Inst : IEnumerable<long>
{
public static readonly long[] Value=A195448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195448.Bytes);
public long this[int i]=>Value[i];

public static A195448Inst Instance=new A195448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195449
{
public static readonly long[] Value={ 5L,6L,1L,7L,0L,8L,1L,6L,9L,7L,8L,3L,3L,4L,4L,5L,9L,5L,1L,7L,8L,9L,1L,5L,7L,7L,2L,9L,4L,0L,4L,7L,3L,9L,5L,6L,0L,3L,4L,0L,3L,8L,8L,0L,0L,2L,4L,5L,9L,2L,5L,6L,8L,4L,0L,2L,5L,6L,5L,9L,8L,4L,3L,8L,4L,8L,9L,1L,0L,8L,5L,4L,3L,8L,7L,7L,7L,9L,4L,2L,7L,1L,9L,7L,7L,1L,3L,4L,8L,3L,9L,8L,9L,9L,0L,9L,4L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195449Inst : IEnumerable<long>
{
public static readonly long[] Value=A195449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195449.Bytes);
public long this[int i]=>Value[i];

public static A195449Inst Instance=new A195449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195450
{
public static readonly long[] Value={ 1L,2L,7L,5L,7L,0L,6L,9L,9L,4L,4L,4L,0L,0L,5L,5L,2L,7L,6L,4L,5L,0L,3L,7L,8L,5L,5L,6L,2L,9L,1L,5L,3L,5L,2L,8L,7L,5L,2L,2L,8L,4L,4L,7L,8L,4L,4L,9L,8L,3L,3L,3L,9L,8L,7L,9L,3L,6L,7L,0L,3L,0L,2L,3L,1L,4L,9L,2L,5L,0L,0L,7L,8L,6L,0L,5L,6L,3L,7L,3L,4L,3L,6L,0L,6L,4L,1L,4L,5L,3L,9L,6L,2L,7L,5L,9L,0L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195450Inst : IEnumerable<long>
{
public static readonly long[] Value=A195450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195450.Bytes);
public long this[int i]=>Value[i];

public static A195450Inst Instance=new A195450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195451
{
public static readonly long[] Value={ 2L,3L,4L,1L,1L,6L,0L,7L,9L,3L,0L,7L,3L,3L,2L,1L,9L,7L,5L,6L,1L,4L,8L,5L,3L,3L,8L,1L,3L,7L,6L,3L,8L,3L,4L,9L,3L,4L,2L,4L,4L,2L,5L,3L,8L,8L,6L,7L,8L,4L,4L,6L,8L,7L,5L,5L,7L,4L,6L,5L,0L,5L,2L,2L,5L,5L,1L,8L,6L,1L,7L,6L,4L,9L,3L,5L,2L,2L,3L,4L,7L,9L,6L,5L,6L,5L,8L,7L,1L,7L,9L,4L,6L,1L,0L,5L,3L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195451Inst : IEnumerable<long>
{
public static readonly long[] Value=A195451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195451.Bytes);
public long this[int i]=>Value[i];

public static A195451Inst Instance=new A195451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195452
{
public static readonly long[] Value={ 1L,7L,4L,9L,9L,9L,1L,1L,3L,2L,9L,1L,2L,7L,8L,8L,9L,6L,8L,3L,6L,6L,2L,7L,9L,5L,8L,7L,7L,9L,2L,2L,9L,5L,9L,7L,1L,0L,5L,1L,7L,8L,7L,3L,1L,6L,4L,8L,6L,5L,0L,4L,1L,1L,6L,0L,4L,8L,8L,9L,1L,7L,8L,9L,6L,4L,1L,7L,7L,5L,9L,5L,4L,0L,7L,2L,3L,8L,6L,3L,2L,5L,0L,1L,6L,9L,8L,0L,5L,3L,2L,4L,3L,0L,6L,8L,2L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195452Inst : IEnumerable<long>
{
public static readonly long[] Value=A195452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195452.Bytes);
public long this[int i]=>Value[i];

public static A195452Inst Instance=new A195452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195453
{
public static readonly long[] Value={ 6L,2L,3L,6L,5L,0L,7L,9L,8L,0L,2L,9L,4L,1L,4L,9L,0L,5L,4L,9L,6L,6L,3L,8L,8L,6L,2L,5L,2L,9L,4L,7L,9L,7L,6L,9L,0L,5L,1L,3L,3L,9L,4L,3L,5L,5L,3L,4L,5L,7L,7L,0L,7L,0L,5L,1L,6L,0L,9L,6L,5L,2L,8L,9L,6L,5L,5L,7L,5L,9L,6L,2L,1L,5L,8L,4L,9L,4L,6L,8L,1L,8L,4L,6L,7L,2L,5L,6L,4L,1L,9L,5L,2L,3L,2L,9L,4L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195453Inst : IEnumerable<long>
{
public static readonly long[] Value=A195453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195453.Bytes);
public long this[int i]=>Value[i];

public static A195453Inst Instance=new A195453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195454
{
public static readonly long[] Value={ 8L,8L,7L,3L,6L,6L,3L,8L,9L,6L,4L,8L,5L,9L,1L,6L,1L,8L,6L,2L,7L,9L,8L,1L,8L,0L,5L,9L,7L,3L,8L,0L,8L,7L,5L,8L,1L,3L,5L,9L,3L,9L,8L,5L,0L,2L,4L,3L,8L,6L,0L,9L,1L,1L,2L,1L,6L,9L,3L,1L,1L,7L,8L,6L,5L,9L,7L,8L,4L,4L,4L,6L,5L,3L,6L,2L,5L,9L,2L,1L,0L,0L,7L,0L,0L,8L,7L,0L,0L,3L,9L,6L,5L,8L,9L,1L,5L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195454Inst : IEnumerable<long>
{
public static readonly long[] Value=A195454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195454.Bytes);
public long this[int i]=>Value[i];

public static A195454Inst Instance=new A195454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195455
{
public static readonly long[] Value={ 1L,4L,8L,0L,6L,3L,4L,6L,1L,0L,1L,1L,1L,7L,3L,9L,3L,2L,9L,2L,8L,0L,6L,7L,8L,6L,5L,6L,4L,1L,5L,6L,3L,5L,3L,1L,5L,8L,9L,4L,1L,0L,1L,5L,1L,8L,3L,5L,9L,9L,8L,2L,3L,8L,2L,1L,5L,1L,7L,7L,4L,5L,3L,3L,9L,2L,3L,8L,6L,3L,2L,4L,5L,6L,4L,3L,9L,1L,0L,6L,4L,8L,7L,8L,7L,2L,9L,1L,2L,1L,5L,7L,7L,3L,5L,5L,9L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195455Inst : IEnumerable<long>
{
public static readonly long[] Value=A195455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195455.Bytes);
public long this[int i]=>Value[i];

public static A195455Inst Instance=new A195455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195456
{
public static readonly long[] Value={ 1L,0L,3L,9L,0L,8L,1L,4L,7L,6L,5L,9L,6L,9L,8L,9L,2L,3L,0L,5L,5L,0L,3L,1L,1L,6L,2L,1L,1L,2L,9L,7L,8L,9L,1L,0L,3L,0L,4L,1L,8L,7L,9L,6L,3L,9L,5L,4L,0L,3L,7L,6L,8L,1L,8L,9L,3L,8L,7L,8L,7L,0L,8L,0L,5L,9L,7L,8L,5L,4L,1L,3L,5L,3L,1L,5L,9L,9L,7L,9L,0L,3L,1L,4L,5L,6L,9L,5L,2L,5L,5L,6L,5L,2L,3L,6L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195456Inst : IEnumerable<long>
{
public static readonly long[] Value=A195456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195456.Bytes);
public long this[int i]=>Value[i];

public static A195456Inst Instance=new A195456Inst();

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