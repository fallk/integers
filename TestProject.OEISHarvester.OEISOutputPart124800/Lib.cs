using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154105
{
public static readonly long[] Value={ 7L,37L,91L,169L,271L,397L,547L,721L,919L,1141L,1387L,1657L,1951L,2269L,2611L,2977L,3367L,3781L,4219L,4681L,5167L,5677L,6211L,6769L,7351L,7957L,8587L,9241L,9919L,10621L,11347L,12097L,12871L,13669L,14491L,15337L,16207L,17101L,18019L,18961L,19927L,20917L,21931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154105Inst : IEnumerable<long>
{
public static readonly long[] Value=A154105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154105.Bytes);
public long this[int i]=>Value[i];

public static A154105Inst Instance=new A154105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154106
{
public static readonly long[] Value={ 11L,45L,103L,185L,291L,421L,575L,753L,955L,1181L,1431L,1705L,2003L,2325L,2671L,3041L,3435L,3853L,4295L,4761L,5251L,5765L,6303L,6865L,7451L,8061L,8695L,9353L,10035L,10741L,11471L,12225L,13003L,13805L,14631L,15481L,16355L,17253L,18175L,19121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154106Inst : IEnumerable<long>
{
public static readonly long[] Value=A154106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154106.Bytes);
public long this[int i]=>Value[i];

public static A154106Inst Instance=new A154106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154107
{
public static readonly long[] Value={ 1L,1L,3L,5L,15L,61L,207L,881L,4491L,21493L,117543L,710021L,4166279L,28107745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154107Inst : IEnumerable<long>
{
public static readonly long[] Value=A154107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154107.Bytes);
public long this[int i]=>Value[i];

public static A154107Inst Instance=new A154107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154108
{
public static readonly long[] Value={ 1L,0L,2L,7L,27L,114L,523L,2589L,13744L,77821L,467767L,2972432L,19895813L,139824045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154108Inst : IEnumerable<long>
{
public static readonly long[] Value=A154108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154108.Bytes);
public long this[int i]=>Value[i];

public static A154108Inst Instance=new A154108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154109
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,2L,4L,0L,4L,7L,5L,0L,6L,14L,27L,6L,0L,8L,21L,54L,114L,7L,0L,10L,28L,81L,228L,523L,8L,0L,12L,35L,108L,342L,1046L,2589L,9L,0L,14L,42L,135L,456L,1569L,5178L,13744L,10L,0L,16L,49L,162L,570L,2092L,7767L,27488L,77821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154109Inst : IEnumerable<long>
{
public static readonly long[] Value=A154109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154109.Bytes);
public long this[int i]=>Value[i];

public static A154109Inst Instance=new A154109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154110
{
public static readonly long[] Value={ 9L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154110Inst : IEnumerable<long>
{
public static readonly long[] Value=A154110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154110.Bytes);
public long this[int i]=>Value[i];

public static A154110Inst Instance=new A154110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154111
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,11L,12L,15L,18L,20L,27L,33L,35L,39L,41L,45L,48L,50L,54L,65L,66L,68L,86L,87L,92L,96L,99L,107L,116L,122L,123L,126L,138L,140L,149L,150L,156L,159L,161L,164L,165L,167L,170L,177L,182L,185L,188L,191L,192L,198L,200L,207L,209L,219L,228L,237L,239L,240L,242L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154111Inst : IEnumerable<long>
{
public static readonly long[] Value=A154111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154111.Bytes);
public long this[int i]=>Value[i];

public static A154111Inst Instance=new A154111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154112
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,16L,19L,20L,32L,34L,37L,42L,44L,45L,49L,51L,52L,56L,60L,62L,70L,72L,74L,75L,77L,79L,81L,89L,90L,95L,96L,97L,100L,101L,104L,105L,111L,114L,115L,121L,126L,131L,136L,145L,151L,154L,156L,161L,171L,174L,175L,180L,182L,191L,199L,200L,202L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154112Inst : IEnumerable<long>
{
public static readonly long[] Value=A154112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154112.Bytes);
public long this[int i]=>Value[i];

public static A154112Inst Instance=new A154112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154113
{
public static readonly long[] Value={ 7L,23L,109L,191L,307L,463L,919L,1231L,1607L,2053L,4657L,7639L,8861L,34913L,41719L,53503L,77743L,89189L,95311L,122599L,138007L,146173L,182057L,223381L,246203L,353011L,383833L,416399L,433351L,468623L,505759L,544807L,721079L,745471L,875711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154113Inst : IEnumerable<long>
{
public static readonly long[] Value=A154113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154113.Bytes);
public long this[int i]=>Value[i];

public static A154113Inst Instance=new A154113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154114
{
public static readonly long[] Value={ 23L,37L,41L,43L,59L,73L,79L,83L,109L,113L,127L,137L,151L,163L,197L,199L,223L,227L,229L,233L,239L,251L,263L,269L,283L,313L,337L,349L,373L,383L,389L,409L,421L,449L,457L,463L,479L,523L,557L,599L,617L,647L,691L,727L,739L,743L,751L,757L,761L,773L,797L,811L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154114Inst : IEnumerable<long>
{
public static readonly long[] Value=A154114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154114.Bytes);
public long this[int i]=>Value[i];

public static A154114Inst Instance=new A154114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154115
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,14L,16L,20L,26L,28L,34L,38L,40L,44L,50L,56L,58L,64L,68L,70L,76L,80L,86L,94L,98L,100L,104L,106L,110L,124L,128L,134L,136L,146L,148L,154L,160L,164L,170L,176L,178L,188L,190L,194L,196L,208L,220L,224L,226L,230L,236L,238L,248L,254L,260L,266L,268L,274L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154115Inst : IEnumerable<long>
{
public static readonly long[] Value=A154115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154115.Bytes);
public long this[int i]=>Value[i];

public static A154115Inst Instance=new A154115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154116
{
public static readonly long[] Value={ 6L,9L,1L,3L,7L,4L,2L,4L,8L,0L,8L,6L,8L,1L,0L,6L,4L,4L,6L,2L,3L,9L,7L,3L,1L,6L,1L,3L,3L,9L,6L,6L,9L,6L,6L,8L,2L,3L,4L,0L,3L,7L,4L,4L,7L,0L,0L,3L,0L,0L,1L,3L,9L,4L,3L,1L,1L,5L,7L,1L,0L,6L,1L,2L,1L,4L,8L,9L,4L,5L,7L,1L,0L,9L,9L,4L,0L,4L,5L,8L,9L,4L,1L,2L,0L,4L,9L,3L,7L,1L,4L,8L,7L,0L,6L,6L,7L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154116Inst : IEnumerable<long>
{
public static readonly long[] Value=A154116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154116.Bytes);
public long this[int i]=>Value[i];

public static A154116Inst Instance=new A154116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154117
{
public static readonly long[] Value={ 1L,2L,7L,17L,37L,77L,157L,317L,637L,1277L,2557L,5117L,10237L,20477L,40957L,81917L,163837L,327677L,655357L,1310717L,2621437L,5242877L,10485757L,20971517L,41943037L,83886077L,167772157L,335544317L,671088637L,1342177277L,2684354557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154117Inst : IEnumerable<long>
{
public static readonly long[] Value=A154117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154117.Bytes);
public long this[int i]=>Value[i];

public static A154117Inst Instance=new A154117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154118
{
public static readonly long[] Value={ 1L,2L,9L,23L,51L,107L,219L,443L,891L,1787L,3579L,7163L,14331L,28667L,57339L,114683L,229371L,458747L,917499L,1835003L,3670011L,7340027L,14680059L,29360123L,58720251L,117440507L,234881019L,469762043L,939524091L,1879048187L,3758096379L,7516192763L,15032385531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154118Inst : IEnumerable<long>
{
public static readonly long[] Value=A154118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154118.Bytes);
public long this[int i]=>Value[i];

public static A154118Inst Instance=new A154118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154119
{
public static readonly long[] Value={ 0L,1L,5L,8L,16L,33L,40L,41L,65L,66L,80L,81L,128L,130L,133L,138L,165L,325L,328L,330L,640L,641L,650L,656L,658L,1025L,1026L,1028L,1033L,1040L,1041L,2065L,2066L,2080L,2081L,4128L,4130L,4133L,4138L,4165L,4688L,4690L,4753L,4756L,4776L,4778L,5125L,5128L,5130L,5138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154119Inst : IEnumerable<long>
{
public static readonly long[] Value=A154119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154119.Bytes);
public long this[int i]=>Value[i];

public static A154119Inst Instance=new A154119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154120
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,6L,24L,18L,6L,24L,192L,216L,96L,24L,120L,1920L,3240L,1920L,600L,120L,720L,23040L,58320L,46080L,18000L,4320L,720L,5040L,322560L,1224720L,1290240L,630000L,181440L,35280L,5040L,40320L,5160960L,29393280L,41287680L,25200000L,8709120L,1975680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154120Inst : IEnumerable<long>
{
public static readonly long[] Value=A154120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154120.Bytes);
public long this[int i]=>Value[i];

public static A154120Inst Instance=new A154120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154121
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,11L,12L,13L,9L,10L,15L,14L,16L,17L,18L,19L,20L,21L,22L,28L,29L,30L,31L,32L,33L,34L,35L,23L,24L,36L,25L,26L,27L,39L,40L,41L,37L,38L,43L,42L,44L,45L,46L,47L,48L,49L,50L,52L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154121Inst : IEnumerable<long>
{
public static readonly long[] Value=A154121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154121.Bytes);
public long this[int i]=>Value[i];

public static A154121Inst Instance=new A154121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154122
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,12L,13L,9L,10L,11L,15L,14L,16L,17L,18L,19L,20L,21L,22L,31L,32L,34L,35L,36L,23L,24L,25L,26L,27L,28L,29L,30L,33L,40L,41L,37L,38L,39L,43L,42L,44L,45L,46L,47L,48L,49L,50L,52L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,87L,88L,90L,91L,92L,96L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154122Inst : IEnumerable<long>
{
public static readonly long[] Value=A154122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154122.Bytes);
public long this[int i]=>Value[i];

public static A154122Inst Instance=new A154122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154123
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,4L,7L,8L,11L,12L,13L,16L,19L,15L,14L,9L,17L,18L,10L,20L,21L,22L,28L,29L,30L,31L,32L,33L,34L,35L,44L,47L,36L,53L,56L,60L,39L,40L,41L,42L,51L,43L,37L,23L,45L,46L,24L,48L,49L,50L,52L,38L,25L,54L,55L,26L,57L,58L,59L,27L,61L,62L,63L,64L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154123Inst : IEnumerable<long>
{
public static readonly long[] Value=A154123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154123.Bytes);
public long this[int i]=>Value[i];

public static A154123Inst Instance=new A154123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154124
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,5L,7L,8L,16L,19L,9L,10L,11L,15L,14L,12L,17L,18L,13L,20L,21L,22L,44L,47L,53L,56L,60L,23L,24L,25L,26L,27L,28L,29L,30L,33L,43L,52L,37L,38L,39L,40L,42L,31L,45L,46L,32L,48L,49L,50L,41L,51L,34L,54L,55L,35L,57L,58L,59L,36L,61L,62L,63L,64L,128L,131L,137L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154124Inst : IEnumerable<long>
{
public static readonly long[] Value=A154124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154124.Bytes);
public long this[int i]=>Value[i];

public static A154124Inst Instance=new A154124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154125
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,16L,19L,14L,17L,18L,15L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,44L,47L,53L,56L,60L,42L,51L,37L,45L,46L,38L,48L,49L,50L,43L,52L,39L,54L,55L,40L,57L,58L,59L,41L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154125Inst : IEnumerable<long>
{
public static readonly long[] Value=A154125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154125.Bytes);
public long this[int i]=>Value[i];

public static A154125Inst Instance=new A154125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154126
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,4L,5L,17L,18L,20L,21L,22L,14L,15L,16L,9L,10L,19L,11L,12L,13L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,37L,38L,39L,40L,41L,42L,43L,44L,23L,24L,47L,25L,26L,27L,51L,52L,53L,28L,29L,56L,30L,31L,32L,60L,33L,34L,35L,36L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154126Inst : IEnumerable<long>
{
public static readonly long[] Value=A154126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154126.Bytes);
public long this[int i]=>Value[i];

public static A154126Inst Instance=new A154126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154127
{
public static readonly long[] Value={ 1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L,5L,8L,7L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154127Inst : IEnumerable<long>
{
public static readonly long[] Value=A154127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154127.Bytes);
public long this[int i]=>Value[i];

public static A154127Inst Instance=new A154127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154128
{
public static readonly long[] Value={ 24L,600L,9000L,105000L,1050000L,9450000L,78750000L,618750000L,4640625000L,33515625000L,234609375000L,1599609375000L,10664062500000L,69726562500000L,448242187500000L,2838867187500000L,17742919921875000L,109588623046875000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154128Inst : IEnumerable<long>
{
public static readonly long[] Value=A154128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154128.Bytes);
public long this[int i]=>Value[i];

public static A154128Inst Instance=new A154128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154129
{
public static readonly long[] Value={ 0L,1L,2L,6L,3L,7L,4L,8L,5L,9L,10L,26L,11L,27L,12L,28L,13L,29L,14L,30L,15L,31L,16L,32L,17L,33L,18L,34L,19L,35L,20L,36L,21L,37L,22L,38L,23L,39L,24L,40L,25L,41L,42L,106L,43L,107L,44L,108L,45L,109L,46L,110L,47L,111L,48L,112L,49L,113L,50L,114L,51L,115L,52L,116L,53L,117L,54L,118L,55L,119L,56L,120L,57L,121L,58L,122L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154129Inst : IEnumerable<long>
{
public static readonly long[] Value=A154129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154129.Bytes);
public long this[int i]=>Value[i];

public static A154129Inst Instance=new A154129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154130
{
public static readonly long[] Value={ 1L,4L,13L,17L,128L,485L,692L,1738L,12863L,77042L,109705L,289047L,720429L,4475944L,75629223L,182575231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154130Inst : IEnumerable<long>
{
public static readonly long[] Value=A154130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154130.Bytes);
public long this[int i]=>Value[i];

public static A154130Inst Instance=new A154130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154131
{
public static readonly long[] Value={ 1L,4L,17L,1738L,1739L,12863L,15705L,109705L,174894L,289047L,720429L,2087694L,2087695L,4475944L,6968999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154131Inst : IEnumerable<long>
{
public static readonly long[] Value=A154131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154131.Bytes);
public long this[int i]=>Value[i];

public static A154131Inst Instance=new A154131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154132
{
public static readonly long[] Value={ 1L,2L,8L,39L,2495L,3895L,4714L,8592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154132Inst : IEnumerable<long>
{
public static readonly long[] Value=A154132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154132.Bytes);
public long this[int i]=>Value[i];

public static A154132Inst Instance=new A154132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154133
{
public static readonly long[] Value={ 1L,2L,8L,39L,113L,3895L,4714L,8592L,34289L,60097L,942859L,2759790L,6649343L,7937397L,14480816L,19338413L,19338414L,19338415L,23187701L,124679421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154133Inst : IEnumerable<long>
{
public static readonly long[] Value=A154133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154133.Bytes);
public long this[int i]=>Value[i];

public static A154133Inst Instance=new A154133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154134
{
public static readonly long[] Value={ 3L,6L,10L,30L,124L,238L,405L,6430L,22869L,32657L,224544L,2396968L,15229280L,28274047L,53458049L,134537968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154134Inst : IEnumerable<long>
{
public static readonly long[] Value=A154134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154134.Bytes);
public long this[int i]=>Value[i];

public static A154134Inst Instance=new A154134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154135
{
public static readonly long[] Value={ 3L,6L,30L,6430L,4822L,22869L,20551L,224544L,184762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154135Inst : IEnumerable<long>
{
public static readonly long[] Value=A154135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154135.Bytes);
public long this[int i]=>Value[i];

public static A154135Inst Instance=new A154135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154136
{
public static readonly long[] Value={ 1L,4L,88L,1228L,2253L,4562L,8183L,167378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154136Inst : IEnumerable<long>
{
public static readonly long[] Value=A154136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154136.Bytes);
public long this[int i]=>Value[i];

public static A154136Inst Instance=new A154136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154137
{
public static readonly long[] Value={ 1L,4L,88L,1228L,187L,4562L,8183L,167378L,35419L,77421L,5593723L,3306511L,83205705L,22413581L,24296709L,35457806L,26593355L,19945016L,80184972L,389460601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154137Inst : IEnumerable<long>
{
public static readonly long[] Value=A154137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154137.Bytes);
public long this[int i]=>Value[i];

public static A154137Inst Instance=new A154137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154138
{
public static readonly long[] Value={ 1L,3L,12L,22L,73L,131L,428L,766L,2497L,4467L,14556L,26038L,84841L,151763L,494492L,884542L,2882113L,5155491L,16798188L,30048406L,97907017L,175134947L,570643916L,1020761278L,3325956481L,5949432723L,19385094972L,34675835062L,112984613353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154138Inst : IEnumerable<long>
{
public static readonly long[] Value=A154138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154138.Bytes);
public long this[int i]=>Value[i];

public static A154138Inst Instance=new A154138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154139
{
public static readonly long[] Value={ 0L,6L,9L,39L,56L,230L,329L,1343L,1920L,7830L,11193L,45639L,65240L,266006L,380249L,1550399L,2216256L,9036390L,12917289L,52667943L,75287480L,306971270L,438807593L,1789159679L,2557558080L,10427986806L,14906540889L,60778761159L,86881687256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154139Inst : IEnumerable<long>
{
public static readonly long[] Value=A154139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154139.Bytes);
public long this[int i]=>Value[i];

public static A154139Inst Instance=new A154139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154140
{
public static readonly long[] Value={ 2L,4L,19L,29L,114L,172L,667L,1005L,3890L,5860L,22675L,34157L,132162L,199084L,770299L,1160349L,4489634L,6763012L,26167507L,39417725L,152515410L,229743340L,888924955L,1339042317L,5181034322L,7804510564L,30197280979L,45488021069L,176002651554L,265123615852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154140Inst : IEnumerable<long>
{
public static readonly long[] Value=A154140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154140.Bytes);
public long this[int i]=>Value[i];

public static A154140Inst Instance=new A154140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154141
{
public static readonly long[] Value={ 1L,7L,16L,46L,97L,271L,568L,1582L,3313L,9223L,19312L,53758L,112561L,313327L,656056L,1826206L,3823777L,10643911L,22286608L,62037262L,129895873L,361579663L,757088632L,2107440718L,4412635921L,12283064647L,25718726896L,71590947166L,149899725457L,417262618351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154141Inst : IEnumerable<long>
{
public static readonly long[] Value=A154141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154141.Bytes);
public long this[int i]=>Value[i];

public static A154141Inst Instance=new A154141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154142
{
public static readonly long[] Value={ 0L,10L,13L,63L,80L,370L,469L,2159L,2736L,12586L,15949L,73359L,92960L,427570L,541813L,2492063L,3157920L,14524810L,18405709L,84656799L,107276336L,493415986L,625252309L,2875839119L,3644237520L,16761618730L,21240172813L,97693873263L,123796799360L,569401620850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154142Inst : IEnumerable<long>
{
public static readonly long[] Value=A154142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154142.Bytes);
public long this[int i]=>Value[i];

public static A154142Inst Instance=new A154142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154143
{
public static readonly long[] Value={ 3L,5L,26L,36L,155L,213L,906L,1244L,5283L,7253L,30794L,42276L,179483L,246405L,1046106L,1436156L,6097155L,8370533L,35536826L,48787044L,207123803L,284351733L,1207205994L,1657323356L,7036112163L,9659588405L,41009466986L,56300207076L,239020689755L,328141654053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154143Inst : IEnumerable<long>
{
public static readonly long[] Value=A154143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154143.Bytes);
public long this[int i]=>Value[i];

public static A154143Inst Instance=new A154143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154144
{
public static readonly long[] Value={ 2L,8L,23L,53L,138L,312L,807L,1821L,4706L,10616L,27431L,61877L,159882L,360648L,931863L,2102013L,5431298L,12251432L,31655927L,71406581L,184504266L,416188056L,1075369671L,2425721757L,6267713762L,14138142488L,36530912903L,82403133173L,212917763658L,480280656552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154144Inst : IEnumerable<long>
{
public static readonly long[] Value=A154144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154144.Bytes);
public long this[int i]=>Value[i];

public static A154144Inst Instance=new A154144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154145
{
public static readonly long[] Value={ 1L,4L,6L,11L,20L,33L,43L,70L,121L,196L,254L,411L,708L,1145L,1483L,2398L,4129L,6676L,8646L,13979L,24068L,38913L,50395L,81478L,140281L,226804L,293726L,474891L,817620L,1321913L,1711963L,2767870L,4765441L,7704676L,9978054L,16132331L,27775028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154145Inst : IEnumerable<long>
{
public static readonly long[] Value=A154145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154145.Bytes);
public long this[int i]=>Value[i];

public static A154145Inst Instance=new A154145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154146
{
public static readonly long[] Value={ 0L,14L,17L,87L,104L,510L,609L,2975L,3552L,17342L,20705L,101079L,120680L,589134L,703377L,3433727L,4099584L,20013230L,23894129L,116645655L,139265192L,679860702L,811697025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154146Inst : IEnumerable<long>
{
public static readonly long[] Value=A154146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154146.Bytes);
public long this[int i]=>Value[i];

public static A154146Inst Instance=new A154146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154147
{
public static readonly long[] Value={ 3L,9L,30L,60L,179L,353L,1046L,2060L,6099L,12009L,35550L,69996L,207203L,407969L,1207670L,2377820L,7038819L,13858953L,41025246L,80775900L,239112659L,470796449L,1393650710L,2744002796L,8122791603L,15993220329L,47343098910L,93215319180L,275935801859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154147Inst : IEnumerable<long>
{
public static readonly long[] Value=A154147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154147.Bytes);
public long this[int i]=>Value[i];

public static A154147Inst Instance=new A154147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154148
{
public static readonly long[] Value={ 5L,7L,40L,50L,237L,295L,1384L,1722L,8069L,10039L,47032L,58514L,274125L,341047L,1597720L,1987770L,9312197L,11585575L,54275464L,67525682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154148Inst : IEnumerable<long>
{
public static readonly long[] Value=A154148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154148.Bytes);
public long this[int i]=>Value[i];

public static A154148Inst Instance=new A154148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154149
{
public static readonly long[] Value={ 2L,12L,27L,77L,162L,452L,947L,2637L,5522L,15372L,32187L,89597L,187602L,522212L,1093427L,3043677L,6372962L,17739852L,37144347L,103395437L,216493122L,602632772L,1261814387L,3512401197L,7354393202L,20471774412L,42864544827L,119318245277L,249832875762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154149Inst : IEnumerable<long>
{
public static readonly long[] Value=A154149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154149.Bytes);
public long this[int i]=>Value[i];

public static A154149Inst Instance=new A154149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154150
{
public static readonly long[] Value={ 1L,15L,24L,94L,145L,551L,848L,3214L,4945L,18735L,28824L,109198L,168001L,636455L,979184L,3709534L,5707105L,21620751L,33263448L,126014974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154150Inst : IEnumerable<long>
{
public static readonly long[] Value=A154150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154150.Bytes);
public long this[int i]=>Value[i];

public static A154150Inst Instance=new A154150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154151
{
public static readonly long[] Value={ 0L,18L,21L,111L,128L,650L,749L,3791L,4368L,22098L,25461L,128799L,148400L,750698L,864941L,4375391L,5041248L,25501650L,29382549L,148634511L,171254048L,866305418L,998141741L,5049197999L,5817596400L,29428882578L,33907436661L,171524097471L,197627023568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154151Inst : IEnumerable<long>
{
public static readonly long[] Value=A154151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154151.Bytes);
public long this[int i]=>Value[i];

public static A154151Inst Instance=new A154151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154152
{
public static readonly long[] Value={ 4L,10L,37L,67L,220L,394L,1285L,2299L,7492L,13402L,43669L,78115L,254524L,455290L,1483477L,2653627L,8646340L,15466474L,50394565L,90145219L,293721052L,525404842L,1711931749L,3062283835L,9977869444L,17848298170L,58155284917L,104027505187L,338953840060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154152Inst : IEnumerable<long>
{
public static readonly long[] Value=A154152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154152.Bytes);
public long this[int i]=>Value[i];

public static A154152Inst Instance=new A154152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154153
{
public static readonly long[] Value={ 6L,8L,47L,57L,278L,336L,1623L,1961L,9462L,11432L,55151L,66633L,321446L,388368L,1873527L,2263577L,10919718L,13193096L,63644783L,76895001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154153Inst : IEnumerable<long>
{
public static readonly long[] Value=A154153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154153.Bytes);
public long this[int i]=>Value[i];

public static A154153Inst Instance=new A154153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154154
{
public static readonly long[] Value={ 3L,13L,34L,84L,203L,493L,1186L,2876L,6915L,16765L,40306L,97716L,234923L,569533L,1369234L,3319484L,7980483L,19347373L,46513666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154154Inst : IEnumerable<long>
{
public static readonly long[] Value=A154154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154154.Bytes);
public long this[int i]=>Value[i];

public static A154154Inst Instance=new A154154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154155
{
public static readonly long[] Value={ 1L,6L,6L,0L,9L,6L,4L,0L,4L,7L,4L,4L,3L,6L,8L,1L,1L,7L,3L,9L,3L,5L,1L,5L,9L,7L,1L,4L,7L,4L,4L,6L,9L,5L,0L,8L,7L,9L,3L,2L,4L,1L,5L,6L,9L,6L,5L,1L,2L,2L,9L,0L,3L,0L,6L,0L,2L,7L,3L,7L,8L,1L,9L,7L,9L,0L,7L,9L,6L,7L,3L,8L,8L,3L,0L,4L,3L,1L,2L,6L,0L,7L,9L,2L,5L,0L,6L,9L,8L,7L,1L,6L,7L,9L,6L,8L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154155Inst : IEnumerable<long>
{
public static readonly long[] Value=A154155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154155.Bytes);
public long this[int i]=>Value[i];

public static A154155Inst Instance=new A154155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154156
{
public static readonly long[] Value={ 1L,4L,3L,0L,6L,7L,6L,5L,5L,8L,0L,7L,3L,3L,9L,3L,0L,5L,0L,6L,7L,0L,1L,0L,6L,5L,6L,8L,7L,6L,3L,9L,6L,5L,6L,3L,2L,0L,6L,9L,7L,9L,1L,9L,3L,2L,0L,7L,9L,7L,6L,0L,4L,4L,9L,3L,2L,1L,9L,7L,6L,0L,3L,7L,9L,6L,0L,6L,6L,2L,0L,8L,2L,5L,3L,7L,8L,8L,5L,5L,0L,6L,0L,8L,3L,6L,9L,8L,0L,9L,9L,4L,4L,5L,2L,6L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154156Inst : IEnumerable<long>
{
public static readonly long[] Value=A154156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154156.Bytes);
public long this[int i]=>Value[i];

public static A154156Inst Instance=new A154156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154157
{
public static readonly long[] Value={ 1L,2L,8L,5L,0L,9L,7L,2L,0L,8L,9L,3L,8L,4L,6L,8L,7L,5L,9L,9L,4L,3L,4L,7L,9L,0L,9L,6L,5L,5L,4L,2L,8L,9L,5L,4L,8L,7L,1L,5L,7L,3L,3L,2L,1L,3L,2L,8L,1L,7L,5L,1L,2L,2L,7L,8L,7L,0L,1L,9L,3L,9L,1L,8L,0L,6L,9L,9L,9L,3L,1L,9L,3L,6L,1L,6L,8L,6L,2L,4L,3L,4L,1L,4L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154157Inst : IEnumerable<long>
{
public static readonly long[] Value=A154157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154157.Bytes);
public long this[int i]=>Value[i];

public static A154157Inst Instance=new A154157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154158
{
public static readonly long[] Value={ 1L,1L,8L,3L,2L,9L,4L,6L,6L,2L,4L,5L,4L,9L,3L,8L,3L,2L,6L,8L,1L,7L,9L,2L,8L,5L,6L,1L,6L,4L,6L,8L,5L,9L,1L,4L,8L,1L,6L,5L,4L,4L,4L,5L,2L,2L,9L,4L,2L,3L,9L,4L,7L,2L,3L,3L,5L,6L,3L,4L,0L,9L,1L,0L,4L,5L,5L,9L,1L,1L,8L,7L,6L,5L,4L,8L,4L,6L,0L,1L,0L,1L,9L,7L,3L,4L,9L,8L,1L,6L,1L,8L,0L,2L,2L,8L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154158Inst : IEnumerable<long>
{
public static readonly long[] Value=A154158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154158.Bytes);
public long this[int i]=>Value[i];

public static A154158Inst Instance=new A154158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154159
{
public static readonly long[] Value={ 1L,1L,0L,7L,3L,0L,9L,3L,6L,4L,9L,6L,2L,4L,5L,4L,1L,1L,5L,9L,5L,6L,7L,7L,3L,1L,4L,3L,1L,6L,3L,1L,3L,0L,0L,5L,8L,6L,2L,1L,6L,1L,0L,4L,6L,4L,3L,4L,1L,5L,2L,6L,8L,7L,0L,6L,8L,4L,9L,1L,8L,7L,9L,8L,6L,0L,5L,3L,1L,1L,5L,9L,2L,2L,0L,2L,8L,7L,5L,0L,7L,1L,9L,5L,0L,0L,4L,6L,5L,8L,1L,1L,1L,9L,7L,9L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154159Inst : IEnumerable<long>
{
public static readonly long[] Value=A154159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154159.Bytes);
public long this[int i]=>Value[i];

public static A154159Inst Instance=new A154159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154160
{
public static readonly long[] Value={ 1L,0L,4L,7L,9L,5L,1L,6L,3L,7L,1L,4L,4L,6L,9L,2L,3L,0L,2L,1L,4L,8L,2L,8L,3L,7L,6L,1L,0L,1L,0L,7L,0L,0L,6L,2L,5L,3L,0L,3L,7L,5L,9L,0L,0L,3L,3L,9L,8L,9L,6L,5L,0L,5L,8L,4L,6L,1L,7L,7L,2L,6L,6L,9L,3L,1L,7L,0L,8L,8L,7L,3L,8L,7L,8L,5L,9L,7L,0L,3L,1L,4L,3L,5L,8L,3L,8L,2L,9L,0L,1L,1L,5L,4L,4L,9L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154160Inst : IEnumerable<long>
{
public static readonly long[] Value=A154160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154160.Bytes);
public long this[int i]=>Value[i];

public static A154160Inst Instance=new A154160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154161
{
public static readonly long[] Value={ 9L,6L,0L,2L,5L,2L,5L,6L,7L,7L,8L,9L,1L,2L,7L,4L,9L,7L,4L,0L,6L,1L,1L,1L,6L,4L,5L,0L,1L,9L,2L,6L,0L,3L,8L,9L,6L,7L,6L,2L,8L,0L,3L,1L,8L,3L,9L,8L,7L,0L,3L,8L,7L,3L,2L,2L,3L,2L,5L,1L,1L,8L,7L,6L,7L,2L,0L,7L,8L,4L,4L,9L,2L,0L,8L,4L,0L,4L,8L,0L,3L,1L,5L,2L,9L,0L,4L,2L,0L,6L,1L,6L,7L,6L,1L,3L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154161Inst : IEnumerable<long>
{
public static readonly long[] Value=A154161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154161.Bytes);
public long this[int i]=>Value[i];

public static A154161Inst Instance=new A154161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154162
{
public static readonly long[] Value={ 9L,2L,6L,6L,2L,8L,4L,0L,8L,0L,2L,9L,1L,2L,6L,8L,1L,6L,1L,1L,2L,9L,9L,3L,4L,2L,8L,1L,6L,7L,0L,9L,3L,0L,0L,4L,0L,0L,1L,5L,3L,5L,8L,6L,2L,5L,3L,3L,9L,8L,1L,5L,5L,9L,5L,3L,1L,3L,6L,1L,0L,4L,9L,2L,6L,2L,4L,8L,2L,4L,8L,5L,8L,0L,2L,6L,7L,4L,2L,7L,5L,2L,0L,9L,6L,1L,9L,7L,1L,8L,0L,3L,4L,8L,6L,2L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154162Inst : IEnumerable<long>
{
public static readonly long[] Value=A154162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154162.Bytes);
public long this[int i]=>Value[i];

public static A154162Inst Instance=new A154162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154163
{
public static readonly long[] Value={ 8L,9L,7L,7L,1L,1L,7L,1L,7L,5L,0L,2L,6L,2L,3L,0L,9L,2L,9L,2L,2L,4L,7L,7L,6L,9L,6L,2L,7L,4L,5L,6L,0L,7L,1L,2L,4L,8L,5L,0L,1L,0L,3L,2L,7L,3L,3L,3L,2L,2L,5L,0L,2L,5L,7L,2L,0L,3L,6L,8L,0L,7L,9L,5L,4L,0L,3L,1L,2L,1L,6L,2L,0L,4L,9L,6L,0L,6L,5L,1L,0L,6L,2L,1L,1L,5L,5L,3L,3L,1L,5L,6L,4L,4L,9L,8L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154163Inst : IEnumerable<long>
{
public static readonly long[] Value=A154163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154163.Bytes);
public long this[int i]=>Value[i];

public static A154163Inst Instance=new A154163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154164
{
public static readonly long[] Value={ 8L,7L,2L,5L,0L,2L,8L,6L,9L,5L,4L,9L,1L,5L,5L,8L,9L,0L,0L,2L,4L,3L,1L,9L,4L,3L,8L,6L,1L,2L,9L,5L,0L,9L,0L,3L,1L,0L,7L,5L,8L,7L,5L,3L,2L,0L,3L,1L,8L,9L,4L,6L,5L,5L,1L,6L,1L,5L,7L,5L,3L,9L,9L,7L,4L,6L,5L,9L,1L,5L,6L,4L,4L,0L,4L,6L,0L,3L,0L,7L,1L,1L,8L,2L,3L,2L,9L,2L,6L,0L,5L,1L,2L,5L,0L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154164Inst : IEnumerable<long>
{
public static readonly long[] Value=A154164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154164.Bytes);
public long this[int i]=>Value[i];

public static A154164Inst Instance=new A154164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154165
{
public static readonly long[] Value={ 8L,5L,0L,2L,7L,4L,1L,5L,3L,7L,2L,7L,6L,0L,2L,5L,9L,5L,0L,0L,4L,7L,7L,2L,6L,8L,2L,2L,6L,3L,4L,0L,9L,7L,4L,0L,9L,0L,5L,0L,7L,4L,1L,0L,1L,4L,9L,2L,6L,2L,0L,7L,1L,4L,8L,4L,2L,1L,6L,8L,4L,0L,4L,7L,4L,8L,4L,4L,8L,0L,4L,6L,4L,8L,3L,0L,9L,9L,6L,9L,8L,1L,3L,4L,1L,1L,2L,7L,9L,2L,7L,3L,9L,3L,9L,8L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154165Inst : IEnumerable<long>
{
public static readonly long[] Value=A154165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154165.Bytes);
public long this[int i]=>Value[i];

public static A154165Inst Instance=new A154165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154166
{
public static readonly long[] Value={ 8L,3L,0L,4L,8L,2L,0L,2L,3L,7L,2L,1L,8L,4L,0L,5L,8L,6L,9L,6L,7L,5L,7L,9L,8L,5L,7L,3L,7L,2L,3L,4L,7L,5L,4L,3L,9L,6L,6L,2L,0L,7L,8L,4L,8L,2L,5L,6L,1L,4L,5L,1L,5L,3L,0L,1L,3L,6L,8L,9L,0L,9L,8L,9L,5L,3L,9L,8L,3L,6L,9L,4L,1L,5L,2L,1L,5L,6L,3L,0L,3L,9L,6L,2L,5L,3L,4L,9L,3L,5L,8L,3L,9L,8L,4L,2L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154166Inst : IEnumerable<long>
{
public static readonly long[] Value=A154166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154166.Bytes);
public long this[int i]=>Value[i];

public static A154166Inst Instance=new A154166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154167
{
public static readonly long[] Value={ 8L,1L,2L,7L,1L,1L,5L,0L,9L,2L,9L,1L,9L,5L,8L,9L,9L,9L,2L,5L,5L,6L,2L,1L,9L,8L,9L,7L,2L,6L,5L,9L,8L,3L,3L,2L,2L,9L,1L,7L,6L,3L,0L,2L,9L,9L,8L,4L,8L,0L,4L,9L,0L,8L,7L,0L,8L,8L,8L,2L,3L,5L,6L,0L,8L,5L,4L,0L,0L,5L,9L,0L,8L,7L,9L,7L,6L,5L,8L,1L,4L,5L,6L,1L,4L,3L,8L,4L,4L,5L,6L,0L,3L,4L,8L,7L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154167Inst : IEnumerable<long>
{
public static readonly long[] Value=A154167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154167.Bytes);
public long this[int i]=>Value[i];

public static A154167Inst Instance=new A154167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154168
{
public static readonly long[] Value={ 7L,9L,6L,6L,3L,9L,7L,7L,0L,1L,9L,6L,9L,1L,2L,1L,6L,4L,7L,3L,4L,7L,4L,7L,2L,3L,5L,0L,2L,0L,3L,7L,2L,6L,6L,4L,1L,1L,6L,0L,0L,6L,9L,1L,5L,0L,2L,7L,5L,9L,8L,1L,6L,0L,1L,7L,2L,4L,3L,7L,1L,2L,8L,9L,8L,1L,6L,5L,9L,3L,2L,4L,0L,4L,2L,7L,6L,1L,6L,1L,6L,3L,9L,8L,1L,9L,6L,1L,5L,9L,6L,7L,0L,1L,8L,3L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154168Inst : IEnumerable<long>
{
public static readonly long[] Value=A154168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154168.Bytes);
public long this[int i]=>Value[i];

public static A154168Inst Instance=new A154168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154169
{
public static readonly long[] Value={ 7L,8L,2L,0L,1L,1L,4L,8L,3L,0L,9L,9L,5L,4L,0L,6L,8L,6L,0L,6L,2L,4L,1L,0L,0L,3L,0L,9L,1L,5L,5L,0L,9L,3L,0L,8L,0L,4L,3L,8L,4L,4L,0L,2L,9L,2L,2L,0L,8L,7L,3L,1L,0L,5L,1L,8L,5L,5L,5L,0L,8L,4L,9L,3L,3L,9L,4L,6L,5L,6L,9L,6L,9L,5L,0L,0L,2L,4L,3L,4L,3L,3L,6L,7L,5L,0L,4L,3L,4L,7L,4L,6L,3L,8L,6L,1L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154169Inst : IEnumerable<long>
{
public static readonly long[] Value=A154169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154169.Bytes);
public long this[int i]=>Value[i];

public static A154169Inst Instance=new A154169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154170
{
public static readonly long[] Value={ 7L,6L,8L,6L,2L,1L,7L,8L,6L,8L,4L,0L,2L,4L,0L,8L,2L,5L,7L,3L,6L,3L,0L,2L,2L,9L,8L,9L,0L,2L,3L,5L,9L,5L,0L,4L,1L,0L,9L,0L,3L,4L,4L,9L,2L,6L,2L,6L,4L,3L,4L,1L,3L,8L,1L,6L,0L,3L,8L,2L,2L,0L,5L,8L,8L,6L,4L,7L,5L,4L,4L,5L,9L,6L,9L,8L,4L,1L,6L,1L,5L,2L,8L,6L,0L,3L,4L,4L,1L,5L,9L,5L,5L,2L,4L,6L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154170Inst : IEnumerable<long>
{
public static readonly long[] Value=A154170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154170.Bytes);
public long this[int i]=>Value[i];

public static A154170Inst Instance=new A154170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154171
{
public static readonly long[] Value={ 7L,5L,6L,3L,0L,4L,1L,9L,5L,5L,1L,6L,4L,0L,1L,0L,6L,2L,6L,1L,8L,1L,3L,1L,2L,2L,5L,1L,6L,0L,0L,1L,0L,9L,0L,9L,6L,8L,0L,0L,3L,0L,7L,2L,2L,5L,7L,8L,0L,2L,3L,6L,8L,2L,6L,2L,6L,2L,5L,0L,6L,1L,7L,7L,8L,6L,0L,4L,6L,9L,6L,9L,3L,5L,8L,9L,7L,7L,2L,9L,3L,2L,6L,9L,8L,6L,4L,8L,8L,0L,4L,2L,8L,0L,9L,8L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154171Inst : IEnumerable<long>
{
public static readonly long[] Value=A154171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154171.Bytes);
public long this[int i]=>Value[i];

public static A154171Inst Instance=new A154171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154172
{
public static readonly long[] Value={ 7L,4L,4L,9L,2L,1L,8L,5L,9L,7L,7L,3L,3L,4L,6L,9L,4L,7L,3L,1L,8L,0L,3L,7L,9L,5L,2L,3L,6L,2L,7L,8L,2L,4L,0L,6L,9L,2L,1L,6L,2L,4L,5L,6L,7L,7L,2L,2L,0L,6L,6L,7L,8L,7L,9L,2L,2L,5L,6L,0L,1L,0L,1L,8L,0L,5L,1L,7L,7L,4L,5L,2L,0L,8L,4L,4L,6L,7L,4L,7L,1L,0L,6L,5L,8L,1L,3L,4L,4L,9L,1L,1L,7L,8L,6L,6L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154172Inst : IEnumerable<long>
{
public static readonly long[] Value=A154172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154172.Bytes);
public long this[int i]=>Value[i];

public static A154172Inst Instance=new A154172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154173
{
public static readonly long[] Value={ 7L,3L,4L,3L,6L,1L,1L,3L,5L,5L,7L,3L,5L,5L,5L,5L,9L,0L,8L,0L,7L,9L,7L,9L,3L,3L,4L,6L,3L,6L,4L,2L,0L,6L,3L,7L,1L,5L,3L,1L,8L,2L,1L,6L,0L,0L,9L,1L,9L,2L,4L,0L,7L,5L,2L,4L,9L,7L,3L,5L,6L,3L,7L,1L,0L,9L,6L,3L,1L,6L,4L,3L,5L,4L,1L,8L,4L,0L,4L,4L,2L,3L,9L,7L,9L,7L,2L,5L,0L,3L,7L,9L,8L,5L,4L,9L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154173Inst : IEnumerable<long>
{
public static readonly long[] Value=A154173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154173.Bytes);
public long this[int i]=>Value[i];

public static A154173Inst Instance=new A154173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154174
{
public static readonly long[] Value={ 7L,2L,4L,5L,2L,6L,7L,7L,5L,1L,6L,2L,2L,5L,3L,8L,6L,4L,7L,4L,4L,4L,3L,7L,2L,2L,5L,6L,5L,0L,9L,7L,6L,0L,1L,6L,6L,1L,8L,6L,8L,2L,9L,0L,1L,7L,7L,7L,6L,4L,9L,0L,5L,3L,9L,2L,3L,7L,7L,0L,1L,8L,5L,1L,8L,5L,0L,7L,5L,6L,9L,5L,3L,3L,9L,9L,0L,4L,7L,7L,3L,3L,5L,7L,2L,3L,7L,3L,1L,0L,6L,9L,5L,8L,6L,2L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154174Inst : IEnumerable<long>
{
public static readonly long[] Value=A154174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154174.Bytes);
public long this[int i]=>Value[i];

public static A154174Inst Instance=new A154174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154175
{
public static readonly long[] Value={ 2L,1L,8L,2L,6L,5L,8L,3L,3L,8L,6L,4L,4L,1L,3L,8L,0L,8L,1L,0L,4L,8L,9L,8L,0L,4L,1L,4L,7L,3L,1L,9L,2L,8L,9L,2L,3L,5L,4L,2L,9L,6L,1L,5L,2L,5L,2L,0L,0L,9L,4L,4L,3L,6L,0L,2L,3L,7L,2L,9L,3L,0L,1L,0L,1L,7L,1L,8L,0L,8L,6L,3L,3L,8L,9L,1L,4L,1L,2L,3L,6L,3L,3L,2L,5L,2L,6L,1L,0L,3L,0L,1L,6L,3L,9L,7L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154175Inst : IEnumerable<long>
{
public static readonly long[] Value=A154175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154175.Bytes);
public long this[int i]=>Value[i];

public static A154175Inst Instance=new A154175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154176
{
public static readonly long[] Value={ 1L,7L,2L,9L,7L,1L,5L,8L,0L,9L,3L,1L,8L,6L,4L,8L,6L,2L,8L,0L,9L,9L,6L,8L,1L,5L,2L,3L,3L,6L,2L,8L,9L,6L,4L,7L,9L,3L,5L,1L,6L,1L,5L,7L,6L,2L,8L,4L,0L,8L,8L,4L,0L,3L,5L,6L,5L,6L,4L,0L,0L,8L,2L,2L,8L,6L,3L,1L,6L,5L,3L,0L,9L,8L,6L,0L,0L,0L,9L,1L,7L,6L,3L,5L,4L,7L,4L,5L,6L,4L,9L,6L,4L,3L,4L,5L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154176Inst : IEnumerable<long>
{
public static readonly long[] Value=A154176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154176.Bytes);
public long this[int i]=>Value[i];

public static A154176Inst Instance=new A154176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154177
{
public static readonly long[] Value={ 1L,4L,8L,9L,8L,9L,6L,1L,0L,2L,4L,0L,4L,9L,7L,8L,0L,7L,2L,7L,9L,9L,2L,0L,1L,7L,7L,9L,9L,8L,3L,9L,7L,1L,3L,0L,7L,6L,1L,3L,4L,8L,0L,4L,4L,4L,5L,5L,9L,6L,3L,3L,7L,5L,0L,5L,2L,7L,3L,5L,2L,6L,0L,6L,5L,1L,1L,2L,9L,8L,8L,2L,2L,5L,3L,5L,4L,0L,6L,9L,1L,4L,8L,3L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154177Inst : IEnumerable<long>
{
public static readonly long[] Value=A154177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154177.Bytes);
public long this[int i]=>Value[i];

public static A154177Inst Instance=new A154177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154178
{
public static readonly long[] Value={ 1L,3L,3L,8L,2L,9L,0L,8L,3L,3L,1L,0L,5L,7L,7L,2L,5L,3L,9L,9L,5L,8L,4L,1L,7L,6L,1L,0L,8L,7L,2L,9L,8L,3L,1L,9L,8L,4L,1L,1L,6L,5L,6L,8L,1L,7L,2L,2L,1L,0L,3L,9L,8L,5L,6L,5L,7L,1L,6L,0L,4L,5L,6L,2L,2L,0L,8L,3L,3L,1L,6L,2L,0L,8L,7L,4L,8L,5L,7L,1L,3L,8L,4L,0L,9L,2L,3L,9L,4L,3L,5L,3L,9L,1L,0L,3L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154178Inst : IEnumerable<long>
{
public static readonly long[] Value=A154178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154178.Bytes);
public long this[int i]=>Value[i];

public static A154178Inst Instance=new A154178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154179
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,7L,4L,4L,0L,5L,8L,6L,7L,3L,4L,3L,7L,6L,1L,8L,6L,0L,7L,5L,6L,8L,6L,7L,6L,5L,5L,6L,2L,9L,2L,9L,9L,1L,5L,2L,8L,3L,9L,8L,9L,3L,2L,8L,6L,8L,1L,7L,5L,5L,5L,6L,2L,6L,3L,2L,3L,1L,3L,4L,7L,9L,6L,8L,2L,9L,5L,0L,4L,2L,4L,1L,7L,7L,0L,0L,9L,0L,8L,8L,8L,6L,7L,3L,7L,6L,0L,2L,9L,7L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154179Inst : IEnumerable<long>
{
public static readonly long[] Value=A154179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154179.Bytes);
public long this[int i]=>Value[i];

public static A154179Inst Instance=new A154179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154180
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,4L,3L,8L,7L,2L,8L,7L,9L,0L,9L,9L,0L,8L,5L,3L,9L,9L,7L,8L,7L,6L,8L,2L,2L,4L,1L,9L,3L,0L,9L,8L,6L,2L,3L,4L,4L,1L,0L,5L,0L,8L,5L,6L,0L,5L,8L,9L,3L,5L,7L,1L,0L,4L,2L,6L,7L,2L,1L,5L,2L,4L,2L,1L,1L,0L,2L,0L,6L,5L,7L,3L,3L,3L,9L,4L,5L,0L,9L,0L,3L,1L,6L,3L,7L,6L,6L,4L,2L,8L,9L,6L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154180Inst : IEnumerable<long>
{
public static readonly long[] Value=A154180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154180.Bytes);
public long this[int i]=>Value[i];

public static A154180Inst Instance=new A154180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154181
{
public static readonly long[] Value={ 1L,0L,9L,1L,3L,2L,9L,1L,6L,9L,3L,2L,2L,0L,6L,9L,0L,4L,0L,5L,2L,4L,4L,9L,0L,2L,0L,7L,3L,6L,5L,9L,6L,4L,4L,6L,1L,7L,7L,1L,4L,8L,0L,7L,6L,2L,6L,0L,0L,4L,7L,2L,1L,8L,0L,1L,1L,8L,6L,4L,6L,5L,0L,5L,0L,8L,5L,9L,0L,4L,3L,1L,6L,9L,4L,5L,7L,0L,6L,1L,8L,1L,6L,6L,2L,6L,3L,0L,5L,1L,5L,0L,8L,1L,9L,8L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154181Inst : IEnumerable<long>
{
public static readonly long[] Value=A154181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154181.Bytes);
public long this[int i]=>Value[i];

public static A154181Inst Instance=new A154181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154182
{
public static readonly long[] Value={ 1L,0L,4L,1L,3L,9L,2L,6L,8L,5L,1L,5L,8L,2L,2L,5L,0L,4L,0L,7L,5L,0L,1L,9L,9L,9L,7L,1L,2L,4L,3L,0L,2L,4L,2L,4L,1L,7L,0L,6L,7L,0L,2L,1L,9L,0L,4L,6L,6L,4L,5L,3L,0L,9L,4L,5L,9L,6L,5L,3L,9L,0L,1L,8L,6L,7L,9L,7L,5L,3L,0L,3L,2L,2L,3L,3L,2L,4L,9L,3L,4L,7L,5L,7L,1L,2L,9L,4L,7L,8L,6L,3L,8L,5L,7L,3L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154182Inst : IEnumerable<long>
{
public static readonly long[] Value=A154182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154182.Bytes);
public long this[int i]=>Value[i];

public static A154182Inst Instance=new A154182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154183
{
public static readonly long[] Value={ 9L,6L,4L,9L,8L,4L,0L,4L,5L,9L,8L,1L,3L,4L,3L,7L,5L,0L,8L,5L,8L,1L,1L,3L,0L,0L,6L,2L,4L,7L,2L,5L,4L,9L,1L,2L,5L,8L,1L,8L,0L,7L,7L,7L,1L,8L,6L,5L,2L,9L,3L,8L,7L,8L,0L,0L,7L,3L,0L,6L,4L,3L,4L,7L,5L,6L,3L,6L,6L,3L,0L,3L,6L,5L,5L,6L,3L,3L,3L,2L,7L,3L,9L,3L,7L,1L,2L,4L,5L,6L,7L,7L,4L,6L,9L,3L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154183Inst : IEnumerable<long>
{
public static readonly long[] Value=A154183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154183.Bytes);
public long this[int i]=>Value[i];

public static A154183Inst Instance=new A154183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154184
{
public static readonly long[] Value={ 9L,3L,4L,8L,7L,0L,4L,1L,5L,9L,8L,8L,0L,5L,8L,6L,3L,0L,3L,6L,5L,3L,2L,8L,0L,8L,8L,6L,1L,3L,5L,5L,5L,7L,7L,4L,1L,1L,4L,0L,9L,7L,4L,4L,9L,5L,7L,6L,0L,3L,0L,7L,0L,5L,4L,0L,4L,9L,4L,9L,5L,7L,6L,8L,3L,3L,8L,1L,6L,8L,7L,1L,3L,7L,8L,3L,9L,8L,8L,9L,5L,2L,5L,3L,2L,7L,5L,7L,2L,1L,8L,8L,4L,8L,2L,4L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154184Inst : IEnumerable<long>
{
public static readonly long[] Value=A154184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154184.Bytes);
public long this[int i]=>Value[i];

public static A154184Inst Instance=new A154184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154185
{
public static readonly long[] Value={ 9L,0L,8L,6L,1L,8L,1L,0L,6L,1L,2L,8L,0L,5L,1L,9L,9L,3L,8L,8L,5L,0L,7L,2L,3L,3L,5L,7L,8L,5L,4L,0L,0L,0L,4L,0L,9L,3L,7L,5L,2L,6L,0L,6L,8L,6L,2L,2L,1L,1L,8L,6L,3L,6L,6L,5L,8L,4L,5L,4L,2L,4L,5L,9L,8L,2L,6L,8L,5L,2L,5L,7L,1L,7L,8L,2L,0L,1L,0L,7L,0L,4L,8L,4L,0L,5L,5L,2L,4L,7L,1L,6L,3L,1L,7L,8L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154185Inst : IEnumerable<long>
{
public static readonly long[] Value=A154185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154185.Bytes);
public long this[int i]=>Value[i];

public static A154185Inst Instance=new A154185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154186
{
public static readonly long[] Value={ 8L,8L,5L,4L,6L,9L,2L,8L,4L,0L,7L,1L,0L,2L,5L,4L,8L,7L,6L,4L,7L,3L,7L,9L,5L,2L,6L,7L,7L,0L,8L,1L,2L,3L,4L,5L,3L,0L,2L,8L,8L,8L,5L,0L,4L,9L,0L,1L,0L,3L,1L,6L,8L,1L,9L,0L,1L,6L,9L,1L,9L,8L,5L,5L,2L,5L,5L,1L,3L,6L,6L,2L,7L,0L,8L,3L,8L,6L,0L,1L,2L,1L,2L,2L,0L,0L,9L,2L,8L,3L,0L,6L,2L,5L,7L,8L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154186Inst : IEnumerable<long>
{
public static readonly long[] Value=A154186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154186.Bytes);
public long this[int i]=>Value[i];

public static A154186Inst Instance=new A154186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154187
{
public static readonly long[] Value={ 8L,6L,4L,8L,5L,7L,9L,0L,4L,6L,5L,9L,3L,2L,4L,3L,1L,4L,0L,4L,9L,8L,4L,0L,7L,6L,1L,6L,8L,1L,4L,4L,8L,2L,3L,9L,6L,7L,5L,8L,0L,7L,8L,8L,1L,4L,2L,0L,4L,4L,2L,0L,1L,7L,8L,2L,8L,2L,0L,0L,4L,1L,1L,4L,3L,1L,5L,8L,2L,6L,5L,4L,9L,3L,0L,0L,0L,4L,5L,8L,8L,1L,7L,7L,3L,7L,2L,8L,2L,4L,8L,2L,1L,7L,2L,5L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154187Inst : IEnumerable<long>
{
public static readonly long[] Value=A154187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154187.Bytes);
public long this[int i]=>Value[i];

public static A154187Inst Instance=new A154187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154188
{
public static readonly long[] Value={ 8L,4L,6L,3L,5L,1L,8L,2L,0L,9L,2L,0L,5L,4L,6L,9L,4L,2L,8L,2L,0L,6L,0L,1L,9L,2L,0L,4L,6L,1L,7L,0L,7L,8L,8L,2L,7L,7L,7L,9L,5L,6L,3L,4L,0L,6L,8L,1L,4L,0L,7L,0L,2L,8L,7L,0L,9L,1L,4L,9L,7L,6L,2L,7L,7L,4L,7L,4L,4L,2L,6L,9L,8L,1L,9L,3L,7L,7L,0L,9L,4L,5L,9L,9L,5L,2L,0L,5L,1L,9L,8L,4L,4L,3L,4L,8L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154188Inst : IEnumerable<long>
{
public static readonly long[] Value=A154188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154188.Bytes);
public long this[int i]=>Value[i];

public static A154188Inst Instance=new A154188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154189
{
public static readonly long[] Value={ 8L,2L,9L,6L,1L,4L,8L,2L,9L,3L,8L,9L,1L,9L,3L,6L,9L,8L,0L,4L,4L,9L,1L,7L,1L,0L,3L,7L,0L,8L,6L,0L,6L,8L,3L,5L,3L,7L,4L,4L,2L,0L,1L,2L,6L,7L,0L,7L,6L,1L,1L,3L,7L,0L,1L,8L,2L,9L,6L,0L,5L,1L,4L,5L,9L,1L,1L,8L,8L,4L,5L,3L,4L,8L,9L,3L,1L,8L,8L,2L,3L,2L,5L,5L,4L,1L,7L,4L,2L,2L,8L,2L,0L,5L,6L,8L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154189Inst : IEnumerable<long>
{
public static readonly long[] Value=A154189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154189.Bytes);
public long this[int i]=>Value[i];

public static A154189Inst Instance=new A154189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154190
{
public static readonly long[] Value={ 8L,1L,4L,3L,8L,1L,0L,3L,8L,2L,0L,9L,5L,9L,6L,5L,9L,6L,1L,0L,5L,8L,2L,4L,4L,0L,0L,8L,3L,2L,8L,7L,7L,6L,7L,6L,5L,6L,7L,8L,1L,8L,0L,6L,8L,3L,3L,5L,3L,7L,8L,7L,7L,4L,2L,0L,5L,6L,6L,9L,5L,5L,1L,5L,0L,9L,5L,2L,7L,4L,3L,8L,1L,6L,9L,6L,1L,1L,5L,3L,4L,5L,0L,3L,7L,8L,1L,5L,2L,7L,9L,9L,5L,0L,1L,9L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154190Inst : IEnumerable<long>
{
public static readonly long[] Value=A154190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154190.Bytes);
public long this[int i]=>Value[i];

public static A154190Inst Instance=new A154190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154191
{
public static readonly long[] Value={ 8L,0L,0L,4L,3L,7L,1L,0L,6L,4L,6L,8L,6L,7L,1L,2L,7L,3L,1L,0L,4L,4L,3L,3L,5L,7L,3L,6L,7L,1L,6L,7L,0L,7L,5L,3L,5L,2L,1L,7L,8L,3L,8L,0L,5L,2L,8L,1L,6L,8L,6L,0L,4L,2L,9L,4L,4L,3L,7L,6L,6L,4L,1L,8L,4L,7L,4L,1L,7L,2L,3L,2L,3L,7L,8L,3L,9L,1L,4L,7L,9L,7L,0L,1L,8L,8L,7L,2L,1L,4L,3L,4L,9L,2L,8L,3L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154191Inst : IEnumerable<long>
{
public static readonly long[] Value=A154191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154191.Bytes);
public long this[int i]=>Value[i];

public static A154191Inst Instance=new A154191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154192
{
public static readonly long[] Value={ 7L,8L,7L,6L,0L,9L,6L,5L,6L,9L,6L,5L,2L,5L,6L,1L,2L,6L,2L,9L,1L,8L,7L,8L,5L,7L,0L,7L,6L,7L,9L,0L,2L,2L,9L,4L,5L,0L,2L,6L,3L,3L,4L,4L,9L,7L,6L,6L,5L,8L,6L,1L,6L,6L,0L,8L,4L,9L,6L,1L,7L,4L,1L,4L,2L,5L,2L,6L,9L,2L,7L,2L,9L,1L,0L,8L,5L,8L,3L,1L,4L,5L,8L,4L,7L,3L,0L,4L,7L,9L,5L,0L,1L,4L,9L,0L,1L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154192Inst : IEnumerable<long>
{
public static readonly long[] Value=A154192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154192.Bytes);
public long this[int i]=>Value[i];

public static A154192Inst Instance=new A154192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154193
{
public static readonly long[] Value={ 7L,7L,5L,7L,5L,6L,1L,7L,5L,7L,8L,2L,4L,2L,4L,5L,6L,0L,5L,2L,2L,4L,3L,7L,6L,6L,1L,5L,9L,6L,5L,1L,9L,5L,2L,9L,1L,0L,2L,0L,8L,7L,1L,1L,7L,5L,5L,7L,7L,7L,7L,9L,9L,0L,2L,7L,4L,2L,3L,8L,2L,8L,8L,9L,3L,4L,8L,8L,5L,4L,6L,9L,9L,9L,3L,5L,9L,8L,5L,7L,6L,0L,8L,2L,4L,2L,0L,5L,2L,3L,0L,6L,9L,2L,9L,6L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154193Inst : IEnumerable<long>
{
public static readonly long[] Value=A154193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154193.Bytes);
public long this[int i]=>Value[i];

public static A154193Inst Instance=new A154193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154194
{
public static readonly long[] Value={ 7L,6L,4L,7L,5L,8L,3L,1L,4L,8L,5L,0L,7L,8L,8L,3L,9L,2L,3L,0L,9L,7L,7L,1L,8L,7L,7L,8L,0L,8L,6L,2L,7L,7L,7L,9L,3L,5L,9L,0L,5L,4L,2L,0L,0L,4L,0L,6L,1L,3L,7L,8L,7L,1L,3L,7L,8L,5L,7L,1L,6L,5L,2L,8L,5L,9L,9L,8L,3L,8L,2L,7L,7L,1L,3L,6L,7L,8L,4L,2L,6L,4L,3L,5L,8L,6L,4L,4L,9L,3L,7L,7L,3L,5L,4L,7L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154194Inst : IEnumerable<long>
{
public static readonly long[] Value=A154194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154194.Bytes);
public long this[int i]=>Value[i];

public static A154194Inst Instance=new A154194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154195
{
public static readonly long[] Value={ 7L,5L,4L,5L,1L,6L,8L,8L,3L,8L,5L,5L,2L,4L,9L,1L,4L,1L,3L,8L,2L,4L,9L,4L,9L,1L,1L,3L,6L,5L,4L,8L,7L,8L,9L,6L,3L,7L,9L,1L,7L,3L,2L,9L,9L,9L,9L,6L,6L,2L,5L,3L,3L,5L,6L,0L,2L,8L,1L,6L,7L,5L,5L,8L,2L,6L,6L,9L,7L,0L,3L,5L,3L,9L,3L,6L,0L,6L,6L,5L,6L,4L,4L,3L,8L,5L,1L,0L,0L,3L,3L,2L,8L,7L,6L,5L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154195Inst : IEnumerable<long>
{
public static readonly long[] Value=A154195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154195.Bytes);
public long this[int i]=>Value[i];

public static A154195Inst Instance=new A154195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154196
{
public static readonly long[] Value={ 2L,2L,6L,1L,8L,5L,9L,5L,0L,7L,1L,4L,2L,9L,1L,4L,8L,7L,4L,1L,9L,9L,0L,5L,4L,2L,2L,8L,6L,8L,5L,5L,2L,1L,7L,0L,8L,5L,9L,9L,1L,7L,1L,2L,8L,0L,2L,6L,3L,7L,6L,0L,8L,5L,5L,7L,4L,1L,3L,0L,9L,8L,8L,7L,6L,7L,7L,3L,7L,0L,4L,0L,2L,7L,6L,1L,8L,2L,9L,6L,1L,0L,1L,2L,2L,3L,4L,5L,3L,7L,7L,0L,9L,8L,9L,0L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154196Inst : IEnumerable<long>
{
public static readonly long[] Value=A154196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154196.Bytes);
public long this[int i]=>Value[i];

public static A154196Inst Instance=new A154196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154197
{
public static readonly long[] Value={ 1L,7L,9L,2L,4L,8L,1L,2L,5L,0L,3L,6L,0L,5L,7L,8L,0L,9L,0L,7L,2L,6L,8L,6L,9L,4L,7L,1L,9L,7L,3L,9L,0L,8L,2L,5L,4L,3L,7L,9L,9L,0L,7L,2L,0L,3L,8L,4L,6L,2L,4L,0L,5L,3L,0L,2L,2L,7L,8L,7L,6L,3L,2L,7L,2L,7L,0L,5L,4L,9L,1L,1L,3L,8L,9L,7L,1L,7L,9L,2L,8L,1L,2L,6L,1L,1L,4L,0L,2L,3L,7L,4L,5L,9L,0L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154197Inst : IEnumerable<long>
{
public static readonly long[] Value=A154197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154197.Bytes);
public long this[int i]=>Value[i];

public static A154197Inst Instance=new A154197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154198
{
public static readonly long[] Value={ 1L,5L,4L,3L,9L,5L,9L,3L,1L,0L,6L,3L,2L,7L,7L,1L,3L,9L,6L,4L,7L,4L,7L,7L,9L,4L,9L,6L,7L,9L,8L,9L,8L,3L,5L,1L,7L,1L,6L,4L,2L,5L,3L,2L,6L,4L,0L,3L,2L,6L,8L,8L,1L,0L,8L,3L,0L,4L,0L,0L,8L,7L,6L,7L,4L,1L,5L,0L,7L,0L,3L,2L,8L,0L,0L,2L,6L,8L,4L,2L,8L,9L,5L,0L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154198Inst : IEnumerable<long>
{
public static readonly long[] Value=A154198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154198.Bytes);
public long this[int i]=>Value[i];

public static A154198Inst Instance=new A154198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154199
{
public static readonly long[] Value={ 1L,3L,8L,6L,8L,5L,2L,8L,0L,7L,2L,3L,4L,5L,4L,1L,5L,8L,6L,8L,7L,0L,2L,4L,6L,1L,3L,8L,4L,6L,7L,8L,2L,0L,8L,7L,6L,4L,6L,5L,1L,4L,1L,8L,5L,9L,4L,5L,7L,1L,0L,3L,4L,2L,8L,3L,8L,9L,4L,9L,4L,9L,2L,8L,8L,2L,6L,6L,4L,2L,0L,1L,8L,5L,4L,0L,7L,2L,2L,8L,0L,3L,8L,3L,1L,6L,5L,2L,3L,0L,0L,2L,9L,4L,8L,1L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154199Inst : IEnumerable<long>
{
public static readonly long[] Value=A154199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154199.Bytes);
public long this[int i]=>Value[i];

public static A154199Inst Instance=new A154199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154200
{
public static readonly long[] Value={ 1L,2L,7L,6L,9L,8L,9L,4L,0L,8L,2L,6L,9L,6L,2L,3L,9L,6L,6L,8L,3L,2L,9L,0L,4L,3L,2L,3L,1L,7L,7L,4L,8L,9L,5L,9L,4L,7L,3L,8L,7L,4L,2L,2L,3L,6L,7L,3L,2L,4L,1L,9L,9L,9L,5L,1L,2L,4L,5L,6L,2L,1L,7L,7L,8L,8L,9L,4L,8L,7L,4L,7L,4L,9L,1L,8L,9L,2L,8L,1L,8L,8L,3L,3L,8L,0L,2L,9L,6L,7L,5L,6L,8L,3L,9L,0L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154200Inst : IEnumerable<long>
{
public static readonly long[] Value=A154200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154200.Bytes);
public long this[int i]=>Value[i];

public static A154200Inst Instance=new A154200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154201
{
public static readonly long[] Value={ 1L,1L,9L,4L,9L,8L,7L,5L,0L,0L,2L,4L,0L,3L,8L,5L,3L,9L,3L,8L,1L,7L,9L,1L,2L,9L,8L,1L,3L,1L,5L,9L,3L,8L,8L,3L,6L,2L,5L,3L,2L,7L,1L,4L,6L,9L,2L,3L,0L,8L,2L,7L,0L,2L,0L,1L,5L,1L,9L,1L,7L,5L,5L,1L,5L,1L,3L,6L,9L,9L,4L,0L,9L,2L,6L,4L,7L,8L,6L,1L,8L,7L,5L,0L,7L,4L,2L,6L,8L,2L,4L,9L,7L,2L,6L,9L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154201Inst : IEnumerable<long>
{
public static readonly long[] Value=A154201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154201.Bytes);
public long this[int i]=>Value[i];

public static A154201Inst Instance=new A154201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154202
{
public static readonly long[] Value={ 1L,1L,3L,0L,9L,2L,9L,7L,5L,3L,5L,7L,1L,4L,5L,7L,4L,3L,7L,0L,9L,9L,5L,2L,7L,1L,1L,4L,3L,4L,2L,7L,6L,0L,8L,5L,4L,2L,9L,9L,5L,8L,5L,6L,4L,0L,1L,3L,1L,8L,8L,0L,4L,2L,7L,8L,7L,0L,6L,5L,4L,9L,4L,3L,8L,3L,8L,6L,8L,5L,2L,0L,1L,3L,8L,0L,9L,1L,4L,8L,0L,5L,0L,6L,1L,1L,7L,2L,6L,8L,8L,5L,4L,9L,4L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154202Inst : IEnumerable<long>
{
public static readonly long[] Value=A154202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154202.Bytes);
public long this[int i]=>Value[i];

public static A154202Inst Instance=new A154202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154203
{
public static readonly long[] Value={ 1L,0L,7L,9L,1L,8L,1L,2L,4L,6L,0L,4L,7L,6L,2L,4L,8L,2L,7L,7L,2L,2L,5L,0L,5L,6L,9L,2L,7L,0L,4L,1L,0L,1L,3L,6L,2L,7L,3L,6L,5L,0L,8L,6L,2L,7L,1L,1L,4L,9L,1L,2L,9L,4L,7L,4L,5L,0L,7L,2L,0L,5L,6L,2L,5L,5L,9L,4L,4L,5L,5L,3L,1L,3L,3L,2L,5L,1L,0L,1L,4L,2L,0L,1L,6L,8L,2L,2L,8L,5L,9L,8L,8L,3L,9L,8L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154203Inst : IEnumerable<long>
{
public static readonly long[] Value=A154203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154203.Bytes);
public long this[int i]=>Value[i];

public static A154203Inst Instance=new A154203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154204
{
public static readonly long[] Value={ 1L,0L,3L,6L,2L,8L,6L,5L,6L,2L,6L,2L,7L,1L,0L,1L,9L,4L,1L,0L,1L,4L,6L,4L,0L,2L,4L,9L,2L,9L,3L,2L,7L,9L,7L,5L,1L,3L,0L,7L,2L,0L,8L,6L,1L,7L,5L,9L,6L,2L,0L,9L,3L,3L,5L,9L,1L,5L,0L,0L,2L,6L,0L,7L,8L,2L,4L,3L,6L,1L,9L,6L,9L,7L,3L,8L,3L,4L,2L,8L,0L,8L,3L,1L,0L,4L,1L,0L,2L,3L,1L,5L,6L,2L,9L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154204Inst : IEnumerable<long>
{
public static readonly long[] Value=A154204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154204.Bytes);
public long this[int i]=>Value[i];

public static A154204Inst Instance=new A154204Inst();

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