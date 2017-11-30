using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242779
{
public static readonly long[] Value={ 2L,1L,1L,3L,3L,1L,8L,3L,1L,1L,2L,2L,3L,2L,2L,4L,3L,1L,3L,1L,3L,11L,2L,4L,8L,25L,49L,14L,5L,1L,1L,1L,271L,1L,3L,4L,9L,1L,5L,14L,3L,1L,1L,1L,1L,47L,1L,21L,1L,7L,4L,1L,2L,1L,3L,2L,11L,3L,8L,1L,2L,1L,1L,4L,3L,1L,3L,2L,17L,1L,1L,3L,84L,4L,1L,1L,1L,1L,1L,1L,31L,1L,1L,1L,4L,7L,2L,2L,2L,1L,12L,3L,1L,2L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242779Inst : IEnumerable<long>
{
public static readonly long[] Value=A242779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242779.Bytes);
public long this[int i]=>Value[i];

public static A242779Inst Instance=new A242779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242778
{
public static readonly long[] Value={ 6L,8L,10L,24L,12L,16L,14L,48L,16L,30L,18L,24L,18L,80L,20L,48L,22L,120L,24L,32L,24L,70L,26L,168L,28L,96L,30L,40L,30L,72L,30L,224L,32L,60L,32L,126L,34L,288L,36L,48L,36L,160L,38L,360L,40L,42L,40L,96L,40L,198L,42L,56L,42L,144L,42L,440L,44L,240L,46L,528L,48L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242778Inst : IEnumerable<long>
{
public static readonly long[] Value=A242778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242778.Bytes);
public long this[int i]=>Value[i];

public static A242778Inst Instance=new A242778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242777
{
public static readonly long[] Value={ 31L,79L,151L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242777Inst : IEnumerable<long>
{
public static readonly long[] Value=A242777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242777.Bytes);
public long this[int i]=>Value[i];

public static A242777Inst Instance=new A242777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242776
{
public static readonly long[] Value={ 2L,11L,13L,29L,31L,47L,67L,83L,101L,103L,137L,139L,157L,173L,191L,193L,211L,227L,229L,263L,281L,283L,317L,337L,353L,373L,389L,397L,409L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242776Inst : IEnumerable<long>
{
public static readonly long[] Value=A242776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242776.Bytes);
public long this[int i]=>Value[i];

public static A242776Inst Instance=new A242776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242775
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,3L,2L,1L,2L,7L,3L,1L,3L,2L,2L,8L,1L,1L,7L,2L,1L,1L,5L,3L,2L,2L,2L,3L,1L,3L,8L,5L,1L,1L,4L,3L,1L,4L,5L,3L,6L,1L,2L,1L,2L,1L,3L,1L,2L,2L,1L,3L,1L,6L,3L,1L,3L,4L,2L,3L,8L,4L,1L,3L,34L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242775Inst : IEnumerable<long>
{
public static readonly long[] Value=A242775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242775.Bytes);
public long this[int i]=>Value[i];

public static A242775Inst Instance=new A242775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242774
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,5L,7L,7L,8L,9L,10L,10L,12L,12L,13L,14L,15L,15L,17L,17L,18L,19L,20L,20L,22L,22L,23L,24L,25L,25L,27L,27L,28L,29L,30L,30L,32L,32L,33L,34L,35L,35L,37L,37L,38L,39L,40L,40L,42L,42L,43L,44L,45L,45L,47L,47L,48L,49L,50L,50L,52L,52L,53L,54L,55L,55L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242774Inst : IEnumerable<long>
{
public static readonly long[] Value=A242774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242774.Bytes);
public long this[int i]=>Value[i];

public static A242774Inst Instance=new A242774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242773
{
public static readonly long[] Value={ 7L,11491L,32971L,33331L,33601L,42841L,58111L,93811L,96331L,114601L,180181L,273001L,309541L,334891L,401311L,540541L,633571L,717091L,784351L,820411L,870241L,879691L,907141L,948091L,989251L,991621L,994561L,1020961L,1028581L,1044751L,1185661L,1189651L,1245451L,1253911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242773Inst : IEnumerable<long>
{
public static readonly long[] Value=A242773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242773.Bytes);
public long this[int i]=>Value[i];

public static A242773Inst Instance=new A242773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242772
{
public static readonly long[] Value={ 5L,11489L,32969L,33329L,33599L,42839L,58109L,93809L,96329L,114599L,180179L,272999L,309539L,334889L,401309L,540539L,633569L,717089L,784349L,820409L,870239L,879689L,907139L,948089L,989249L,991619L,994559L,1020959L,1028579L,1044749L,1185659L,1189649L,1245449L,1253909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242772Inst : IEnumerable<long>
{
public static readonly long[] Value=A242772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242772.Bytes);
public long this[int i]=>Value[i];

public static A242772Inst Instance=new A242772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242771
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,9L,14L,19L,25L,32L,40L,48L,58L,68L,79L,91L,104L,117L,132L,147L,163L,180L,198L,216L,236L,256L,277L,299L,322L,345L,370L,395L,421L,448L,476L,504L,534L,564L,595L,627L,660L,693L,728L,763L,799L,836L,874L,912L,952L,992L,1033L,1075L,1118L,1161L,1206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242771Inst : IEnumerable<long>
{
public static readonly long[] Value=A242771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242771.Bytes);
public long this[int i]=>Value[i];

public static A242771Inst Instance=new A242771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242770
{
public static readonly long[] Value={ 4189L,12193L,641941L,8778073L,26822599L,11488195489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242770Inst : IEnumerable<long>
{
public static readonly long[] Value=A242770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242770.Bytes);
public long this[int i]=>Value[i];

public static A242770Inst Instance=new A242770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242769
{
public static readonly long[] Value={ 6L,8L,2L,1L,5L,5L,5L,6L,7L,1L,0L,0L,6L,2L,7L,3L,1L,6L,1L,6L,7L,1L,5L,5L,2L,6L,2L,3L,7L,9L,0L,5L,0L,8L,3L,3L,0L,0L,3L,8L,6L,8L,1L,0L,0L,0L,1L,6L,8L,8L,8L,5L,9L,9L,1L,0L,9L,0L,6L,5L,5L,1L,0L,1L,3L,4L,2L,2L,0L,8L,6L,2L,6L,5L,8L,2L,1L,7L,7L,1L,5L,9L,8L,1L,1L,4L,8L,8L,6L,8L,9L,0L,5L,4L,5L,3L,9L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242769Inst : IEnumerable<long>
{
public static readonly long[] Value=A242769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242769.Bytes);
public long this[int i]=>Value[i];

public static A242769Inst Instance=new A242769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242768
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,6L,6L,6L,6L,6L,6L,2L,2L,5L,5L,5L,5L,5L,2L,2L,6L,6L,6L,6L,6L,6L,2L,2L,2L,2L,4L,4L,4L,4L,3L,3L,3L,5L,5L,5L,5L,5L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242768Inst : IEnumerable<long>
{
public static readonly long[] Value=A242768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242768.Bytes);
public long this[int i]=>Value[i];

public static A242768Inst Instance=new A242768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242623
{
public static readonly long[] Value={ 1L,7L,5L,8L,7L,4L,3L,6L,2L,7L,9L,5L,1L,1L,8L,4L,8L,2L,4L,6L,9L,9L,8L,9L,6L,8L,4L,9L,6L,6L,1L,9L,3L,2L,0L,8L,5L,3L,4L,2L,8L,1L,0L,3L,9L,3L,3L,8L,2L,4L,6L,9L,0L,9L,8L,8L,7L,8L,4L,0L,0L,3L,9L,7L,7L,2L,0L,5L,1L,9L,5L,0L,2L,4L,9L,0L,3L,5L,3L,1L,9L,1L,1L,4L,3L,3L,6L,8L,9L,0L,2L,2L,6L,5L,2L,5L,6L,7L,5L,8L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242623Inst : IEnumerable<long>
{
public static readonly long[] Value=A242623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242623.Bytes);
public long this[int i]=>Value[i];

public static A242623Inst Instance=new A242623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242622
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,77L,287L,1079L,4082L,15522L,59271L,227131L,873051L,3364827L,12998867L,50321075L,195162350L,758156366L,2949614789L,11490869489L,44819531180L,175009397380L,684059403670L,2676260628574L,10479320689274L,41065736472890L,161043272100440L,631974335773536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242622Inst : IEnumerable<long>
{
public static readonly long[] Value=A242622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242622.Bytes);
public long this[int i]=>Value[i];

public static A242622Inst Instance=new A242622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242621
{
public static readonly long[] Value={ 2L,33L,1309L,27962L,3323705L,296602730L,41704979953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242621Inst : IEnumerable<long>
{
public static readonly long[] Value=A242621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242621.Bytes);
public long this[int i]=>Value[i];

public static A242621Inst Instance=new A242621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242620
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,62264L,4046803256L,16382350221535464479UL,BigInteger.Parse("339840244399005511779394711120340266111") };
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
public class A242620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242620Inst Instance=new A242620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242619
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,20449L,1438793759L,8479443857936402504L,BigInteger.Parse("17340632172455487023654788790090010704") };
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
public class A242619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242619Inst Instance=new A242619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242618
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,2L,2L,1L,1L,1L,4L,2L,1L,1L,2L,3L,3L,2L,1L,8L,3L,3L,2L,4L,6L,5L,5L,4L,13L,8L,4L,1L,5L,5L,11L,13L,7L,1L,11L,20L,14L,9L,2L,1L,6L,13L,17L,26L,11L,3L,1L,22L,31L,27L,15L,5L,2L,12L,18L,34L,44L,18L,7L,4L,40L,47L,51L,23L,11L,5L,16L,36L,56L,72L,34L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242618Inst : IEnumerable<long>
{
public static readonly long[] Value=A242618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242618.Bytes);
public long this[int i]=>Value[i];

public static A242618Inst Instance=new A242618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242617
{
public static readonly long[] Value={ 5L,5L,3L,0L,5L,1L,2L,9L,3L,3L,5L,7L,5L,9L,5L,1L,8L,6L,7L,7L,9L,9L,5L,1L,0L,3L,7L,0L,8L,7L,1L,2L,4L,7L,7L,4L,5L,5L,0L,8L,0L,2L,8L,5L,7L,6L,0L,1L,9L,6L,6L,1L,7L,7L,6L,3L,3L,0L,4L,0L,7L,0L,9L,7L,0L,5L,9L,5L,3L,8L,7L,8L,8L,4L,0L,7L,7L,1L,2L,5L,4L,1L,6L,8L,7L,0L,5L,3L,7L,3L,2L,6L,3L,1L,6L,8L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242617Inst : IEnumerable<long>
{
public static readonly long[] Value=A242617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242617.Bytes);
public long this[int i]=>Value[i];

public static A242617Inst Instance=new A242617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242616
{
public static readonly long[] Value={ 5L,3L,9L,6L,4L,5L,4L,9L,1L,1L,9L,0L,4L,1L,3L,1L,8L,7L,1L,1L,0L,5L,0L,0L,8L,4L,7L,4L,8L,4L,7L,0L,1L,9L,8L,7L,5L,3L,2L,7L,7L,0L,6L,6L,8L,9L,8L,7L,4L,1L,8L,5L,0L,9L,4L,5L,7L,1L,1L,3L,9L,1L,2L,1L,7L,4L,4L,6L,9L,4L,7L,0L,5L,2L,5L,4L,9L,9L,3L,7L,4L,7L,2L,3L,5L,8L,0L,6L,2L,4L,5L,3L,6L,6L,4L,3L,1L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242616Inst : IEnumerable<long>
{
public static readonly long[] Value=A242616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242616.Bytes);
public long this[int i]=>Value[i];

public static A242616Inst Instance=new A242616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242615
{
public static readonly long[] Value={ 100L,81L,56L,56L,37L,44L,30L,35L,29L,32L,27L,33L,29L,32L,31L,35L,34L,39L,38L,43L,44L,48L,50L,56L,58L,64L,67L,74L,77L,85L,90L,98L,104L,113L,119L,130L,137L,147L,156L,167L,176L,188L,197L,210L,220L,232L,243L,255L,265L,278L,288L,299L,309L,320L,328L,338L,345L,354L,360L,367L,371L,376L,378L,381L,382L,383L,381L,380L,377L,373L,368L,363L,356L,349L,341L,332L,322L,312L,302L,291L,279L,268L,256L,244L,232L,220L,208L,196L,184L,173L,161L,151L,140L,130L,120L,111L,102L,94L,86L,78L,71L,65L,59L,53L,48L,43L,38L,34L,31L,27L,24L,21L,19L,17L,15L,13L,11L,10L,8L,7L,6L,5L,5L,4L,3L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242615Inst : IEnumerable<long>
{
public static readonly long[] Value=A242615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242615.Bytes);
public long this[int i]=>Value[i];

public static A242615Inst Instance=new A242615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242614
{
public static readonly long[] Value={ 0L,1L,2L,11L,3L,12L,21L,30L,102L,111L,4L,13L,22L,31L,40L,103L,112L,121L,130L,202L,211L,220L,301L,310L,400L,1003L,1012L,1021L,1030L,1102L,1111L,5L,14L,23L,32L,41L,50L,104L,113L,122L,131L,140L,203L,212L,221L,230L,302L,311L,320L,401L,410L,500L,1004L,1013L,1022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242614Inst : IEnumerable<long>
{
public static readonly long[] Value=A242614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242614.Bytes);
public long this[int i]=>Value[i];

public static A242614Inst Instance=new A242614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242613
{
public static readonly long[] Value={ 0L,2L,4L,5L,1L,4L,9L,0L,7L,6L,5L,6L,4L,0L,9L,7L,8L,2L,9L,0L,7L,4L,2L,2L,8L,0L,0L,6L,8L,6L,1L,3L,7L,1L,1L,0L,2L,8L,7L,5L,7L,0L,7L,0L,9L,2L,3L,7L,9L,1L,5L,0L,3L,7L,4L,2L,9L,0L,5L,1L,1L,2L,7L,2L,9L,8L,3L,7L,8L,8L,0L,0L,9L,9L,7L,5L,5L,3L,3L,5L,8L,9L,1L,5L,4L,6L,6L,2L,9L,4L,6L,0L,6L,2L,9L,3L,7L,4L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242613Inst : IEnumerable<long>
{
public static readonly long[] Value=A242613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242613.Bytes);
public long this[int i]=>Value[i];

public static A242613Inst Instance=new A242613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242612
{
public static readonly long[] Value={ 0L,1L,7L,9L,9L,6L,9L,3L,8L,1L,0L,6L,8L,9L,1L,4L,0L,7L,7L,9L,5L,3L,6L,7L,8L,2L,1L,4L,3L,6L,1L,5L,2L,6L,2L,3L,8L,9L,8L,1L,1L,2L,3L,4L,5L,1L,3L,9L,0L,2L,3L,3L,4L,9L,2L,9L,4L,5L,0L,2L,4L,7L,9L,9L,9L,1L,3L,2L,2L,5L,6L,2L,4L,6L,3L,8L,0L,8L,5L,8L,4L,3L,0L,9L,4L,2L,9L,7L,0L,5L,9L,1L,9L,5L,1L,4L,2L,4L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242612Inst : IEnumerable<long>
{
public static readonly long[] Value=A242612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242612.Bytes);
public long this[int i]=>Value[i];

public static A242612Inst Instance=new A242612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242611
{
public static readonly long[] Value={ 0L,0L,9L,4L,1L,3L,9L,5L,0L,2L,3L,2L,4L,9L,3L,0L,8L,9L,7L,3L,5L,1L,7L,1L,9L,5L,5L,3L,6L,2L,3L,3L,3L,0L,2L,8L,9L,8L,1L,5L,8L,3L,1L,7L,3L,7L,9L,6L,6L,5L,4L,3L,0L,0L,3L,7L,1L,1L,4L,2L,3L,4L,0L,2L,8L,0L,2L,1L,6L,1L,8L,7L,3L,0L,0L,0L,8L,4L,5L,1L,3L,3L,5L,8L,7L,3L,0L,9L,0L,6L,2L,2L,8L,1L,1L,7L,2L,7L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242611Inst : IEnumerable<long>
{
public static readonly long[] Value=A242611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242611.Bytes);
public long this[int i]=>Value[i];

public static A242611Inst Instance=new A242611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242610
{
public static readonly long[] Value={ 4L,9L,5L,6L,0L,0L,1L,8L,0L,5L,8L,2L,1L,4L,3L,8L,6L,4L,2L,5L,4L,0L,7L,4L,2L,8L,5L,7L,9L,2L,4L,9L,8L,8L,8L,8L,0L,9L,5L,5L,7L,7L,0L,0L,2L,3L,9L,4L,4L,1L,4L,3L,5L,3L,7L,9L,3L,2L,3L,9L,3L,2L,4L,8L,5L,6L,5L,3L,3L,7L,0L,6L,7L,9L,3L,8L,4L,6L,8L,1L,3L,9L,4L,1L,1L,3L,9L,8L,6L,4L,9L,5L,3L,0L,9L,7L,2L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242610Inst : IEnumerable<long>
{
public static readonly long[] Value=A242610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242610.Bytes);
public long this[int i]=>Value[i];

public static A242610Inst Instance=new A242610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242609
{
public static readonly long[] Value={ 1L,-2L,0L,0L,2L,0L,0L,0L,2L,-6L,0L,0L,4L,0L,0L,0L,2L,-4L,0L,0L,0L,0L,0L,0L,4L,-2L,0L,0L,0L,0L,0L,0L,2L,-8L,0L,0L,6L,0L,0L,0L,0L,-4L,0L,0L,4L,0L,0L,0L,4L,-2L,0L,0L,0L,0L,0L,0L,0L,-8L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,6L,-4L,0L,0L,4L,0L,0L,0L,0L,-10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242609Inst : IEnumerable<long>
{
public static readonly long[] Value=A242609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242609.Bytes);
public long this[int i]=>Value[i];

public static A242609Inst Instance=new A242609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242608
{
public static readonly long[] Value={ 3323705L,3875934L,4393190L,4463822L,4929470L,5401626L,5654802L,6452535L,6465414L,6800934L,7427042L,7755890L,8233743L,8343906L,8406174L,8457942L,8593802L,8716323L,9186474L,9688382L,9812582L,9965415L,10364934L,10504074L,10870563L,10977834L,11460666L,11685894L,11993462L,12474602L,13151761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242608Inst : IEnumerable<long>
{
public static readonly long[] Value=A242608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242608.Bytes);
public long this[int i]=>Value[i];

public static A242608Inst Instance=new A242608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242575
{
public static readonly BigInteger[] Value={ 1L,3L,12L,65L,464L,4235L,48000L,658197L,10676571L,200994145L,4321369524L,104676808756L,2824120458186L,84038944594677L,2735391623889696L,96690702098948611L,3688764754855986702L,BigInteger.Parse("151064345601782722492"),BigInteger.Parse("6609564176073032406148"),BigInteger.Parse("307682727619722793499662") };
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
public class A242575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242575Inst Instance=new A242575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242574
{
public static readonly BigInteger[] Value={ 1L,2L,6L,26L,155L,1225L,12411L,156416L,2388060L,43159172L,905135396L,21655104900L,582527203011L,17404200037095L,571581950390602L,20454815744801708L,791762421402479311L,BigInteger.Parse("32941802599154381634"),BigInteger.Parse("1465274545936840236164"),BigInteger.Parse("69358520116965601147778") };
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
public class A242574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242574Inst Instance=new A242574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242573
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,702L,4445L,27812L,187911L,4154105L,226545132L,11811552612L,567839904255L,26530164469576L,1244353584654296L,59633342751369016L,2947881116272213508L,BigInteger.Parse("151083714566902161495"),BigInteger.Parse("8048911065786420441543"),BigInteger.Parse("446230730213409483222040") };
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
public class A242573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242573Inst Instance=new A242573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242572
{
public static readonly long[] Value={ 3L,7L,8L,16L,19L,36L,44L,151L,292L,448L,467L,896L,1148L,1607L,1711L,1956L,2020L,6635L,14228L,25519L,43140L,74984L,77696L,137975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242572Inst : IEnumerable<long>
{
public static readonly long[] Value=A242572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242572.Bytes);
public long this[int i]=>Value[i];

public static A242572Inst Instance=new A242572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242571
{
public static readonly long[] Value={ 3L,15L,28L,105L,120L,171L,210L,231L,406L,561L,741L,820L,990L,1081L,1275L,1378L,1485L,1540L,1596L,1953L,2211L,2485L,2775L,3003L,3240L,3321L,3741L,3916L,4005L,4371L,4560L,4851L,5460L,6105L,6903L,7381L,7750L,8001L,8128L,8515L,9316L,9591L,9730L,10153L,10440L,10878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242571Inst : IEnumerable<long>
{
public static readonly long[] Value=A242571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242571.Bytes);
public long this[int i]=>Value[i];

public static A242571Inst Instance=new A242571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242570
{
public static readonly long[] Value={ 0L,252L,504L,756L,1008L,1260L,1512L,1764L,2016L,2268L,2520L,2772L,3024L,3276L,3528L,3780L,4032L,4284L,4536L,4788L,5040L,5292L,5544L,5796L,6048L,6300L,6552L,6804L,7056L,7308L,7560L,7812L,8064L,8316L,8568L,8820L,9072L,9324L,9576L,9828L,10080L,10332L,10584L,10836L,11088L,11340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242570Inst : IEnumerable<long>
{
public static readonly long[] Value=A242570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242570.Bytes);
public long this[int i]=>Value[i];

public static A242570Inst Instance=new A242570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242569
{
public static readonly BigInteger[] Value={ -1L,-2L,0L,16L,110L,708L,5026L,40304L,362862L,3628780L,39916778L,479001576L,6227020774L,87178291172L,1307674367970L,20922789887968L,355687428095966L,6402373705727964L,121645100408831962L,2432902008176639960L,BigInteger.Parse("51090942171709439958"),BigInteger.Parse("1124000727777607679956"),BigInteger.Parse("25852016738884976639954"),BigInteger.Parse("620448401733239439359952") };
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
public class A242569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242569Inst Instance=new A242569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242568
{
public static readonly BigInteger[] Value={ 0L,1L,110L,1L,5026L,10070L,362862L,1L,39916778L,34L,6227020774L,25152407L,1307674367970L,50917L,355687428095966L,256443711659L,121645100408831962L,1286L,BigInteger.Parse("51090942171709439958"),111014413076599L,BigInteger.Parse("25852016738884976639954"),BigInteger.Parse("51704033477769953279974") };
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
public class A242568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242568Inst Instance=new A242568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242567
{
public static readonly BigInteger[] Value={ 1L,1L,0L,1L,18L,1L,712L,5031L,14L,1L,18L,1L,479001586L,1719L,87178291184L,1L,3024L,1L,40L,633L,124748L,1L,86L,51847L,625793187628L,123L,20404L,1L,210L,1L,BigInteger.Parse("265252859812191058636308479999968"),755L,BigInteger.Parse("263130836933693530167218012159999966") };
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
public class A242567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242567Inst Instance=new A242567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242566
{
public static readonly long[] Value={ 0L,1L,1L,3L,7L,22L,67L,225L,765L,2704L,9710L,35558L,131859L,494892L,1874901L,7162807L,27558511L,106695148L,415346144L,1624780952L,6383671910L,25179642120L,99670897534L,395810459602L,1576464630375L,6295827843098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242566Inst : IEnumerable<long>
{
public static readonly long[] Value=A242566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242566.Bytes);
public long this[int i]=>Value[i];

public static A242566Inst Instance=new A242566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242565
{
public static readonly long[] Value={ 4L,6L,10L,28L,772L,1320L,2620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242565Inst : IEnumerable<long>
{
public static readonly long[] Value=A242565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242565.Bytes);
public long this[int i]=>Value[i];

public static A242565Inst Instance=new A242565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242564
{
public static readonly long[] Value={ 19L,1657L,13L,9001L,283L,115201L,61507L,249439L,375127L,472831L,786823L,172489L,1237L,2359033L,163063L,961981L,1442017L,457L,1208833L,4845583L,1146877L,11550193L,436831L,1911031L,581047L,4504351L,215737L,3685051L,27805381L,1343791L,82491967L,15696349L,20446423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242564Inst : IEnumerable<long>
{
public static readonly long[] Value=A242564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242564.Bytes);
public long this[int i]=>Value[i];

public static A242564Inst Instance=new A242564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242563
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,10L,21L,42L,86L,171L,342L,682L,1365L,2730L,5462L,10923L,21846L,43690L,87381L,174762L,349526L,699051L,1398102L,2796202L,5592405L,11184810L,22369622L,44739243L,89478486L,178956970L,357913941L,715827882L,1431655766L,2863311531L,5726623062L,11453246122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242563Inst : IEnumerable<long>
{
public static readonly long[] Value=A242563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242563.Bytes);
public long this[int i]=>Value[i];

public static A242563Inst Instance=new A242563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242562
{
public static readonly long[] Value={ 13L,1447L,5527L,28201L,36217L,75079L,81157L,95911L,187423L,188677L,202327L,210643L,248077L,263323L,282589L,283267L,423043L,466897L,472597L,478189L,478603L,631273L,640261L,695749L,730111L,736279L,806929L,808021L,917641L,964303L,1018177L,1026547L,1064263L,1108489L,1150861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242562Inst : IEnumerable<long>
{
public static readonly long[] Value=A242562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242562.Bytes);
public long this[int i]=>Value[i];

public static A242562Inst Instance=new A242562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242561
{
public static readonly long[] Value={ 0L,2L,0L,6L,4L,5L,0L,14L,8L,9L,20L,11L,0L,26L,42L,15L,32L,17L,0L,38L,20L,21L,44L,23L,0L,50L,78L,27L,56L,87L,60L,31L,0L,66L,34L,105L,72L,37L,0L,78L,40L,41L,0L,86L,132L,45L,92L,141L,96L,49L,100L,51L,104L,53L,0L,110L,56L,171L,116L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242561Inst : IEnumerable<long>
{
public static readonly long[] Value=A242561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242561.Bytes);
public long this[int i]=>Value[i];

public static A242561Inst Instance=new A242561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242560
{
public static readonly long[] Value={ 2L,1L,2L,2L,4L,3L,6L,4L,6L,5L,10L,6L,12L,7L,10L,8L,16L,9L,18L,10L,14L,11L,22L,12L,24L,13L,18L,14L,28L,15L,30L,16L,22L,17L,28L,18L,36L,19L,26L,20L,40L,21L,42L,22L,30L,23L,46L,24L,42L,25L,34L,26L,52L,27L,44L,28L,38L,29L,58L,30L,60L,31L,42L,32L,52L,33L,66L,34L,46L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242560Inst : IEnumerable<long>
{
public static readonly long[] Value=A242560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242560.Bytes);
public long this[int i]=>Value[i];

public static A242560Inst Instance=new A242560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242159
{
public static readonly BigInteger[] Value={ 1L,7L,56L,420L,3360L,28182L,250404L,2354352L,23408385L,245710465L,2717803088L,31615680096L,386038045848L,4938320959740L,66064056802800L,922665034672080L,13431181585022355L,203477178533784540L,3203526845947149260L,BigInteger.Parse("52344335808818684400"),BigInteger.Parse("886527902050136045700") };
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
public class A242159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242159Inst Instance=new A242159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242158
{
public static readonly BigInteger[] Value={ 1L,6L,42L,280L,2016L,15372L,125202L,1086624L,10032165L,98284186L,1019176158L,11158475328L,128679348616L,1559469776760L,19819217040840L,263618581334880L,3663049523187915L,53081003095769880L,800881711486787315L,12562640594116484256UL,BigInteger.Parse("204583362011569856700") };
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
public class A242158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242158Inst Instance=new A242158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242157
{
public static readonly BigInteger[] Value={ 1L,5L,30L,175L,1120L,7686L,56910L,452760L,3858525L,35101495L,339725386L,3487023540L,37846867240L,433186049100L,5215583431800L,65904645333720L,872154648378075L,12063864339947700L,174104719888432025L,2617216790440934220L,BigInteger.Parse("40916672402313971340") };
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
public class A242157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242157Inst Instance=new A242157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242156
{
public static readonly BigInteger[] Value={ 1L,4L,20L,100L,560L,3416L,22764L,164640L,1286175L,10800460L,97064396L,929872944L,9461716810L,101926129200L,1159018540400L,13874662175520L,174430929675615L,2297878921894800L,31655403616078550L,455168137467988560L,6819445400385661890L,BigInteger.Parse("106288470495749772120") };
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
public class A242156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242156Inst Instance=new A242156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242155
{
public static readonly ulong[] Value={ 1L,3L,12L,50L,240L,1281L,7588L,49392L,350775L,2700115L,22399476L,199258488L,1892343362L,19111149225L,204532683600L,2312443695920L,27541725738255L,344681838284220L,4522200516582650L,62068382381998440L,889492878311173290L,13286058811968721515UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242155Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A242155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242155.Bytes);
public ulong this[int i]=>Value[i];

public static A242155Inst Instance=new A242155Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242154
{
public static readonly ulong[] Value={ 1L,2L,6L,20L,80L,366L,1897L,10976L,70155L,490930L,3733246L,30655152L,270334766L,2548153230L,25566585450L,272052199520L,3060191748695L,36282298766760L,452220051658265L,5911274512571280L,80862988937379390L,1155309461910323610L,17208404375488550100UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242154Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A242154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242154.Bytes);
public ulong this[int i]=>Value[i];

public static A242154Inst Instance=new A242154Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242153
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,2L,1L,0L,5L,6L,3L,1L,0L,16L,20L,12L,4L,1L,0L,61L,80L,50L,20L,5L,1L,0L,271L,366L,240L,100L,30L,6L,1L,0L,1372L,1897L,1281L,560L,175L,42L,7L,1L,0L,7795L,10976L,7588L,3416L,1120L,280L,56L,8L,1L,0L,49093L,70155L,49392L,22764L,7686L,2016L,420L,72L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242153Inst : IEnumerable<long>
{
public static readonly long[] Value=A242153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242153.Bytes);
public long this[int i]=>Value[i];

public static A242153Inst Instance=new A242153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242152
{
public static readonly long[] Value={ 15L,24L,28L,35L,40L,42L,54L,60L,66L,95L,96L,110L,114L,117L,119L,120L,132L,135L,140L,143L,147L,168L,195L,198L,209L,224L,240L,250L,252L,258L,280L,287L,290L,315L,319L,322L,323L,360L,375L,377L,380L,384L,408L,460L,468L,470L,476L,480L,486L,496L,506L,507L,510L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242152Inst : IEnumerable<long>
{
public static readonly long[] Value=A242152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242152.Bytes);
public long this[int i]=>Value[i];

public static A242152Inst Instance=new A242152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242151
{
public static readonly long[] Value={ 1314L,131950L,3708268L,50455611L,430518585L,2653766000L,12874102578L,51971761446L,181406955240L,562733770845L,1583267148775L,4103373431703L,9915409939254L,22554409881732L,48670945639576L,100272843914859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242151Inst : IEnumerable<long>
{
public static readonly long[] Value=A242151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242151.Bytes);
public long this[int i]=>Value[i];

public static A242151Inst Instance=new A242151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242150
{
public static readonly long[] Value={ 747L,51440L,1098260L,12043599L,86052208L,456215409L,1941492045L,6980495147L,21963123129L,62016006945L,160112849845L,383388390463L,860906165796L,1828944557550L,3702209669222L,7182352124565L,13418860449679L,24241936676342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242150Inst : IEnumerable<long>
{
public static readonly long[] Value=A242150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242150.Bytes);
public long this[int i]=>Value[i];

public static A242150Inst Instance=new A242150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242149
{
public static readonly long[] Value={ 421L,19834L,321320L,2837837L,16970962L,77357343L,288712815L,924335053L,2621131557L,6736000381L,15956886023L,35297721979L,73650614324L,146121877010L,277441759058L,506811766161L,894639234101L,1531707118508L,2551438684546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242149Inst : IEnumerable<long>
{
public static readonly long[] Value=A242149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242149.Bytes);
public long this[int i]=>Value[i];

public static A242149Inst Instance=new A242149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242148
{
public static readonly long[] Value={ 236L,7596L,93308L,663395L,3319500L,13006484L,42564898L,121330981L,310054250L,725133024L,1576001362L,3220436895L,6243597894L,11567739640L,20600804748L,35433429545L,59095358912L,95883815172L,151778022640L,234955848347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242148Inst : IEnumerable<long>
{
public static readonly long[] Value=A242148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242148.Bytes);
public long this[int i]=>Value[i];

public static A242148Inst Instance=new A242148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242147
{
public static readonly long[] Value={ 132L,2902L,27024L,154647L,647404L,2180310L,6256170L,15876783L,36560854L,77812152L,155155078L,292868433L,527561802L,912752596L,1524615420L,2469089061L,3890540016L,5982195106L,8998569348L,13270128883L,19220442384L,27386087994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242147Inst : IEnumerable<long>
{
public static readonly long[] Value=A242147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242147.Bytes);
public long this[int i]=>Value[i];

public static A242147Inst Instance=new A242147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242146
{
public static readonly long[] Value={ 74L,1113L,7862L,36224L,126894L,367358L,924300L,2088459L,4333978L,8394287L,15356562L,26776802L,44817566L,72410412L,113445080L,172987461L,257528394L,375265333L,536418926L,753586548L,1042134830L,1420633226L,1911330660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242146Inst : IEnumerable<long>
{
public static readonly long[] Value=A242146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242146.Bytes);
public long this[int i]=>Value[i];

public static A242146Inst Instance=new A242146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242145
{
public static readonly long[] Value={ 42L,435L,2338L,8688L,25494L,63490L,140148L,282051L,527626L,930237L,1561638L,2515786L,3913014L,5904564L,8677480L,12459861L,17526474L,24204727L,32881002L,44007348L,58108534L,75789462L,97742940L,124757815L,157727466L,197658657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242145Inst : IEnumerable<long>
{
public static readonly long[] Value=A242145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242145.Bytes);
public long this[int i]=>Value[i];

public static A242145Inst Instance=new A242145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242144
{
public static readonly long[] Value={ 42L,435L,74L,2338L,1113L,132L,8688L,7862L,2902L,236L,25494L,36224L,27024L,7596L,421L,63490L,126894L,154647L,93308L,19834L,747L,140148L,367358L,647404L,663395L,321320L,51440L,1314L,282051L,924300L,2180310L,3319500L,2837837L,1098260L,131950L,2318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242144Inst : IEnumerable<long>
{
public static readonly long[] Value=A242144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242144.Bytes);
public long this[int i]=>Value[i];

public static A242144Inst Instance=new A242144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242063
{
public static readonly long[] Value={ 0L,105L,211L,316L,422L,527L,633L,738L,844L,949L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242063Inst : IEnumerable<long>
{
public static readonly long[] Value=A242063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242063.Bytes);
public long this[int i]=>Value[i];

public static A242063Inst Instance=new A242063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242062
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,3L,2L,3L,4L,3L,3L,4L,4L,3L,4L,5L,4L,4L,5L,5L,4L,5L,6L,5L,5L,6L,6L,5L,6L,7L,6L,6L,7L,7L,6L,7L,8L,7L,7L,8L,8L,7L,8L,9L,8L,8L,9L,9L,8L,9L,10L,9L,9L,10L,10L,9L,10L,11L,10L,10L,11L,11L,10L,11L,12L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242062Inst : IEnumerable<long>
{
public static readonly long[] Value=A242062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242062.Bytes);
public long this[int i]=>Value[i];

public static A242062Inst Instance=new A242062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242061
{
public static readonly long[] Value={ 14L,2L,129L,52686L,29L,7L,9L,1274L,296125969L,12012350L,5L,1279281L,44L,302583265614L,780914L,90L,316L,2605L,106023820090609L,1754402265205275806L,7794L,72957466300254L,768323201L,40L,18505L,23L,6478321L,3966329L,326L,14280500082452241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242061Inst : IEnumerable<long>
{
public static readonly long[] Value=A242061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242061.Bytes);
public long this[int i]=>Value[i];

public static A242061Inst Instance=new A242061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242060
{
public static readonly long[] Value={ 1L,5L,1L,11L,5L,17L,7L,1L,29L,5L,13L,41L,5L,7L,17L,5L,19L,59L,5L,23L,71L,5L,7L,1L,5L,29L,7L,5L,11L,101L,5L,107L,37L,5L,7L,11L,5L,43L,5L,137L,5L,7L,149L,5L,7L,5L,13L,19L,5L,59L,179L,5L,7L,191L,5L,197L,5L,11L,5L,7L,13L,5L,227L,7L,5L,79L,239L,1L,5L,13L,83L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242060Inst : IEnumerable<long>
{
public static readonly long[] Value=A242060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242060.Bytes);
public long this[int i]=>Value[i];

public static A242060Inst Instance=new A242060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242059
{
public static readonly long[] Value={ 1L,5L,7L,5L,1L,11L,5L,13L,5L,7L,5L,7L,5L,23L,5L,1L,5L,7L,5L,11L,5L,37L,5L,7L,5L,43L,7L,5L,47L,11L,5L,17L,5L,53L,7L,5L,13L,5L,61L,5L,7L,5L,67L,7L,5L,11L,71L,5L,13L,5L,7L,5L,1L,11L,5L,7L,5L,7L,5L,31L,5L,5L,7L,5L,103L,5L,11L,17L,5L,7L,37L,5L,113L,11L,7L,5L,13L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242059Inst : IEnumerable<long>
{
public static readonly long[] Value=A242059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242059.Bytes);
public long this[int i]=>Value[i];

public static A242059Inst Instance=new A242059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242058
{
public static readonly long[] Value={ 6L,8L,12L,14L,18L,20L,24L,30L,32L,38L,42L,44L,48L,52L,54L,58L,60L,62L,68L,72L,74L,78L,80L,84L,88L,90L,94L,98L,102L,104L,108L,110L,114L,118L,122L,124L,128L,132L,138L,140L,148L,150L,152L,158L,164L,168L,172L,174L,178L,180L,182L,188L,192L,194L,198L,200L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242058Inst : IEnumerable<long>
{
public static readonly long[] Value=A242058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242058.Bytes);
public long this[int i]=>Value[i];

public static A242058Inst Instance=new A242058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242057
{
public static readonly long[] Value={ 10L,16L,22L,26L,28L,34L,36L,40L,46L,50L,56L,64L,66L,70L,76L,82L,86L,92L,96L,100L,106L,112L,116L,120L,126L,130L,134L,136L,142L,144L,146L,154L,156L,160L,162L,166L,170L,176L,184L,186L,190L,196L,202L,204L,206L,210L,214L,216L,222L,226L,232L,236L,244L,254L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242057Inst : IEnumerable<long>
{
public static readonly long[] Value=A242057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242057.Bytes);
public long this[int i]=>Value[i];

public static A242057Inst Instance=new A242057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242056
{
public static readonly long[] Value={ 2L,8L,0L,6L,6L,7L,9L,4L,0L,1L,7L,7L,7L,6L,9L,2L,1L,8L,3L,0L,5L,0L,9L,1L,4L,2L,7L,3L,8L,1L,8L,1L,5L,4L,5L,6L,4L,1L,5L,4L,9L,8L,0L,0L,2L,8L,5L,0L,2L,2L,5L,6L,3L,5L,5L,9L,4L,2L,4L,6L,9L,7L,1L,2L,7L,0L,6L,9L,9L,2L,2L,6L,5L,6L,0L,1L,3L,8L,3L,0L,2L,1L,8L,2L,2L,4L,4L,8L,9L,6L,6L,2L,3L,0L,3L,6L,2L,6L,6L,0L,9L,6L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242056Inst : IEnumerable<long>
{
public static readonly long[] Value=A242056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242056.Bytes);
public long this[int i]=>Value[i];

public static A242056Inst Instance=new A242056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242055
{
public static readonly long[] Value={ 1L,5L,6L,0L,2L,7L,7L,9L,4L,2L,0L,4L,1L,8L,7L,9L,7L,0L,2L,1L,0L,2L,0L,7L,7L,3L,8L,1L,5L,6L,8L,4L,6L,3L,7L,5L,6L,3L,7L,3L,9L,9L,5L,7L,4L,5L,9L,4L,9L,5L,4L,2L,5L,3L,8L,5L,3L,7L,1L,2L,3L,9L,2L,9L,7L,8L,0L,6L,8L,4L,9L,4L,8L,2L,7L,8L,5L,1L,8L,2L,4L,4L,4L,3L,6L,3L,3L,1L,6L,3L,4L,7L,1L,8L,5L,5L,8L,6L,3L,0L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242055Inst : IEnumerable<long>
{
public static readonly long[] Value=A242055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242055.Bytes);
public long this[int i]=>Value[i];

public static A242055Inst Instance=new A242055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242054
{
public static readonly long[] Value={ 1L,1L,5L,18L,75L,396L,2052L,11586L,71787L,458352L,3103668L,22202874L,164999826L,1281692088L,10371684312L,86973240204L,755908929603L,6794220017664L,63008287321788L,602270212069098L,5924679849081126L,59897824980579576L,621672797654084520L,6616610400436719588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242054Inst : IEnumerable<long>
{
public static readonly long[] Value=A242054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242054.Bytes);
public long this[int i]=>Value[i];

public static A242054Inst Instance=new A242054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242053
{
public static readonly long[] Value={ 4L,4L,2L,6L,9L,5L,0L,4L,0L,8L,8L,8L,9L,6L,3L,4L,0L,7L,3L,5L,9L,9L,2L,4L,6L,8L,1L,0L,0L,1L,8L,9L,2L,1L,3L,7L,4L,2L,6L,6L,4L,5L,9L,5L,4L,1L,5L,2L,9L,8L,5L,9L,3L,4L,1L,3L,5L,4L,4L,9L,4L,0L,6L,9L,3L,1L,1L,0L,9L,2L,1L,9L,1L,8L,1L,1L,8L,5L,0L,7L,9L,8L,8L,5L,5L,2L,6L,6L,2L,2L,8L,9L,3L,5L,0L,6L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242053Inst : IEnumerable<long>
{
public static readonly long[] Value=A242053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242053.Bytes);
public long this[int i]=>Value[i];

public static A242053Inst Instance=new A242053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242052
{
public static readonly long[] Value={ 2L,0L,2L,9L,1L,8L,9L,2L,1L,2L,8L,2L,8L,8L,9L,7L,4L,1L,2L,8L,2L,8L,4L,7L,7L,2L,0L,7L,6L,1L,4L,8L,7L,3L,5L,2L,4L,6L,8L,3L,2L,1L,7L,5L,1L,9L,2L,4L,4L,5L,5L,2L,6L,3L,1L,7L,8L,8L,1L,6L,2L,3L,8L,6L,9L,5L,5L,6L,2L,7L,3L,1L,4L,8L,5L,9L,5L,4L,2L,6L,7L,3L,5L,1L,3L,8L,9L,9L,8L,2L,4L,6L,7L,4L,6L,3L,0L,9L,5L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242052Inst : IEnumerable<long>
{
public static readonly long[] Value=A242052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242052.Bytes);
public long this[int i]=>Value[i];

public static A242052Inst Instance=new A242052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242051
{
public static readonly long[] Value={ 1L,8L,8L,7L,0L,2L,9L,9L,6L,5L,4L,3L,0L,8L,2L,5L,2L,7L,8L,2L,4L,8L,1L,3L,8L,1L,9L,6L,7L,9L,9L,5L,6L,9L,9L,1L,1L,5L,3L,7L,8L,6L,6L,2L,3L,8L,0L,8L,8L,4L,9L,9L,7L,8L,0L,3L,4L,8L,8L,3L,0L,4L,4L,7L,3L,8L,7L,0L,8L,9L,0L,9L,0L,5L,6L,0L,9L,1L,4L,2L,0L,5L,3L,2L,4L,6L,7L,2L,3L,9L,0L,5L,4L,9L,5L,6L,9L,0L,0L,2L,8L,9L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242051Inst : IEnumerable<long>
{
public static readonly long[] Value=A242051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242051.Bytes);
public long this[int i]=>Value[i];

public static A242051Inst Instance=new A242051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242050
{
public static readonly long[] Value={ 2L,2L,2L,2L,1L,7L,1L,2L,1L,1L,1L,5L,1L,1L,7L,10L,1L,7L,1L,1L,1L,1L,3L,7L,1L,5L,1L,1L,1L,1L,1L,2L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,5L,1L,1L,3L,1L,1L,1L,1L,62L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242050Inst : IEnumerable<long>
{
public static readonly long[] Value=A242050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242050.Bytes);
public long this[int i]=>Value[i];

public static A242050Inst Instance=new A242050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242049
{
public static readonly long[] Value={ 4L,2L,9L,9L,4L,7L,4L,3L,3L,3L,4L,2L,4L,5L,2L,7L,2L,0L,1L,1L,4L,6L,9L,7L,0L,3L,5L,5L,1L,9L,9L,2L,2L,3L,2L,3L,3L,2L,4L,0L,6L,5L,0L,1L,1L,5L,8L,9L,3L,0L,4L,6L,1L,7L,0L,4L,0L,2L,7L,6L,0L,7L,2L,5L,7L,4L,2L,8L,3L,3L,7L,2L,8L,3L,1L,3L,9L,8L,1L,0L,5L,6L,8L,4L,5L,6L,3L,4L,9L,0L,0L,7L,4L,8L,4L,7L,4L,2L,5L,3L,6L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242049Inst : IEnumerable<long>
{
public static readonly long[] Value=A242049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242049.Bytes);
public long this[int i]=>Value[i];

public static A242049Inst Instance=new A242049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242048
{
public static readonly long[] Value={ 8L,3L,1L,7L,9L,6L,3L,9L,6L,7L,3L,4L,4L,4L,0L,6L,8L,9L,9L,9L,3L,8L,9L,3L,1L,0L,7L,4L,5L,8L,6L,6L,8L,9L,5L,7L,3L,2L,5L,9L,2L,8L,5L,5L,8L,5L,0L,2L,1L,3L,7L,7L,2L,2L,0L,5L,5L,3L,5L,0L,0L,4L,2L,1L,6L,0L,7L,8L,0L,6L,2L,5L,8L,3L,6L,6L,4L,4L,6L,5L,7L,6L,3L,6L,4L,8L,7L,7L,5L,2L,3L,1L,9L,6L,9L,8L,8L,6L,0L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242048Inst : IEnumerable<long>
{
public static readonly long[] Value=A242048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242048.Bytes);
public long this[int i]=>Value[i];

public static A242048Inst Instance=new A242048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241999
{
public static readonly BigInteger[] Value={ 1L,1L,6L,135L,4811L,229670L,13511540L,936653101L,74430448182L,6655256746640L,660714896623941L,72089721075875610L,8574673889180457825L,BigInteger.Parse("1104434190128518376048"),BigInteger.Parse("153171642055215265173031"),BigInteger.Parse("22761836879580561483967360"),BigInteger.Parse("3608810191272206965533932200") };
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
public class A241999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241999Inst Instance=new A241999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241998
{
public static readonly BigInteger[] Value={ 1L,1L,5L,95L,2865L,115995L,5795546L,341588686L,23099712021L,1759081180848L,148827977847297L,13846375810530924L,1405013226803228823L,BigInteger.Parse("154447381376266478808"),BigInteger.Parse("18287299416725063983915"),BigInteger.Parse("2320814090889444342775833"),BigInteger.Parse("314320342934125785370051303") };
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
public class A241998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241998Inst Instance=new A241998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241997
{
public static readonly BigInteger[] Value={ 1L,1L,4L,62L,1530L,50849L,2089719L,101470053L,5660430287L,355970992756L,24894562936569L,1915987357589537L,160941576221849622L,14653841416756810665UL,BigInteger.Parse("1437868649635368258342"),BigInteger.Parse("151284341822917527109841"),BigInteger.Parse("16993002921809143802858179"),BigInteger.Parse("2029842747191877113876104045") };
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
public class A241997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241997Inst Instance=new A241997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241996
{
public static readonly BigInteger[] Value={ 1L,1L,3L,36L,691L,17953L,578590L,22086434L,970562211L,48162981790L,2661660956118L,162076663712956L,10782672104108188L,778258213420732537L,BigInteger.Parse("60580553895367923682"),BigInteger.Parse("5059770644086584978690"),BigInteger.Parse("451410973011659727975191"),BigInteger.Parse("42848908650336118172791330") };
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
public class A241996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241996Inst Instance=new A241996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241995
{
public static readonly long[] Value={ 2L,9L,5L,3L,8L,8L,6L,6L,3L,9L,3L,3L,0L,7L,1L,6L,9L,5L,8L,8L,7L,1L,4L,4L,9L,9L,8L,3L,2L,9L,5L,4L,4L,1L,5L,3L,0L,9L,4L,2L,7L,7L,2L,4L,7L,5L,1L,1L,7L,7L,3L,6L,3L,5L,1L,5L,1L,3L,7L,5L,5L,5L,2L,0L,4L,3L,6L,6L,3L,5L,4L,4L,1L,7L,8L,6L,2L,0L,3L,6L,0L,8L,4L,8L,2L,0L,7L,0L,5L,0L,5L,3L,9L,5L,5L,7L,0L,1L,2L,3L,1L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241995Inst : IEnumerable<long>
{
public static readonly long[] Value=A241995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241995.Bytes);
public long this[int i]=>Value[i];

public static A241995Inst Instance=new A241995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241994
{
public static readonly long[] Value={ 1L,0L,8L,6L,6L,7L,4L,1L,6L,6L,1L,6L,0L,7L,7L,3L,9L,5L,2L,1L,3L,5L,7L,0L,6L,7L,2L,0L,8L,2L,0L,9L,6L,5L,2L,3L,3L,2L,9L,5L,9L,8L,3L,3L,0L,8L,8L,7L,0L,3L,0L,2L,1L,0L,2L,0L,4L,9L,5L,1L,8L,4L,1L,0L,0L,1L,4L,5L,1L,5L,7L,7L,0L,8L,5L,1L,8L,8L,3L,0L,8L,0L,3L,5L,3L,7L,7L,3L,4L,2L,1L,7L,4L,4L,9L,7L,2L,5L,6L,8L,3L,4L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241994Inst : IEnumerable<long>
{
public static readonly long[] Value=A241994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241994.Bytes);
public long this[int i]=>Value[i];

public static A241994Inst Instance=new A241994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241993
{
public static readonly long[] Value={ 9L,6L,3L,8L,1L,0L,2L,8L,7L,8L,3L,4L,0L,7L,9L,9L,9L,7L,4L,9L,2L,1L,6L,1L,4L,3L,4L,0L,1L,1L,2L,2L,1L,3L,3L,4L,0L,4L,6L,3L,1L,1L,3L,7L,1L,8L,2L,0L,8L,0L,2L,6L,1L,3L,6L,5L,7L,9L,3L,2L,5L,1L,4L,9L,7L,8L,8L,2L,3L,6L,3L,2L,0L,1L,1L,7L,7L,7L,5L,4L,6L,2L,0L,5L,2L,2L,7L,6L,8L,0L,8L,7L,5L,1L,4L,4L,1L,2L,5L,6L,5L,1L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241993Inst : IEnumerable<long>
{
public static readonly long[] Value=A241993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241993.Bytes);
public long this[int i]=>Value[i];

public static A241993Inst Instance=new A241993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241992
{
public static readonly long[] Value={ 1L,5L,8L,9L,0L,5L,4L,5L,2L,2L,4L,7L,1L,6L,6L,0L,6L,3L,3L,4L,8L,1L,8L,1L,2L,3L,5L,8L,8L,6L,1L,6L,6L,1L,4L,0L,8L,0L,7L,9L,2L,3L,5L,8L,4L,4L,9L,3L,2L,3L,7L,7L,5L,3L,3L,3L,8L,3L,1L,0L,1L,7L,2L,3L,3L,5L,5L,7L,8L,2L,3L,5L,9L,4L,7L,5L,2L,2L,4L,1L,0L,2L,2L,5L,7L,4L,8L,9L,3L,1L,7L,5L,9L,2L,2L,5L,5L,0L,5L,7L,5L,8L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241992Inst : IEnumerable<long>
{
public static readonly long[] Value=A241992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241992.Bytes);
public long this[int i]=>Value[i];

public static A241992Inst Instance=new A241992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241991
{
public static readonly long[] Value={ 5L,4L,5L,7L,8L,1L,8L,3L,8L,8L,3L,3L,9L,8L,7L,0L,8L,2L,5L,2L,3L,4L,9L,0L,3L,9L,7L,2L,5L,5L,6L,5L,8L,7L,7L,4L,0L,3L,3L,6L,8L,7L,9L,1L,3L,2L,9L,8L,0L,4L,3L,9L,3L,2L,7L,6L,7L,5L,9L,5L,2L,6L,2L,3L,5L,0L,6L,1L,8L,4L,4L,6L,8L,7L,4L,1L,0L,8L,4L,0L,5L,2L,5L,1L,2L,7L,0L,3L,1L,0L,6L,0L,2L,6L,1L,0L,0L,3L,0L,6L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241991Inst : IEnumerable<long>
{
public static readonly long[] Value=A241991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241991.Bytes);
public long this[int i]=>Value[i];

public static A241991Inst Instance=new A241991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241990
{
public static readonly long[] Value={ 8L,9L,9L,2L,1L,2L,6L,8L,0L,7L,8L,5L,5L,0L,0L,8L,8L,6L,2L,5L,7L,6L,9L,8L,8L,3L,8L,7L,7L,5L,2L,8L,8L,1L,8L,2L,4L,3L,5L,0L,4L,5L,4L,1L,1L,7L,0L,6L,8L,4L,8L,4L,9L,8L,1L,7L,2L,6L,5L,6L,1L,5L,1L,4L,9L,4L,7L,5L,0L,8L,1L,8L,8L,1L,8L,6L,9L,7L,0L,9L,6L,1L,3L,2L,7L,1L,5L,9L,5L,5L,8L,3L,6L,8L,9L,3L,9L,9L,8L,3L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241990Inst : IEnumerable<long>
{
public static readonly long[] Value=A241990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241990.Bytes);
public long this[int i]=>Value[i];

public static A241990Inst Instance=new A241990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241989
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,30L,32L,33L,35L,36L,40L,45L,48L,50L,54L,60L,64L,65L,66L,70L,72L,75L,80L,90L,96L,99L,100L,105L,108L,112L,120L,126L,128L,130L,132L,135L,140L,144L,150L,160L,165L,175L,176L,180L,192L,195L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241989Inst : IEnumerable<long>
{
public static readonly long[] Value=A241989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241989.Bytes);
public long this[int i]=>Value[i];

public static A241989Inst Instance=new A241989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241988
{
public static readonly long[] Value={ 1L,6L,15L,28L,41L,64L,93L,122L,151L,190L,229L,276L,337L,394L,445L,508L,581L,660L,741L,820L,903L,996L,1083L,1170L,1275L,1372L,1467L,1590L,1711L,1848L,1977L,2088L,2213L,2358L,2489L,2648L,2801L,2972L,3133L,3306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241988Inst : IEnumerable<long>
{
public static readonly long[] Value=A241988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241988.Bytes);
public long this[int i]=>Value[i];

public static A241988Inst Instance=new A241988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241987
{
public static readonly long[] Value={ 1L,5L,9L,13L,13L,23L,29L,29L,29L,39L,39L,47L,61L,57L,51L,63L,73L,79L,81L,79L,83L,93L,87L,87L,105L,97L,95L,123L,121L,137L,129L,111L,125L,145L,131L,159L,153L,171L,161L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241987Inst : IEnumerable<long>
{
public static readonly long[] Value=A241987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241987.Bytes);
public long this[int i]=>Value[i];

public static A241987Inst Instance=new A241987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241986
{
public static readonly long[] Value={ 1L,8L,21L,34L,59L,96L,133L,176L,213L,256L,311L,360L,433L,512L,591L,700L,797L,912L,997L,1094L,1191L,1336L,1457L,1566L,1729L,1880L,2031L,2146L,2267L,2448L,2623L,2834L,3027L,3220L,3431L,3600L,3811L,4082L,4269L,4450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241986Inst : IEnumerable<long>
{
public static readonly long[] Value=A241986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241986.Bytes);
public long this[int i]=>Value[i];

public static A241986Inst Instance=new A241986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241985
{
public static readonly long[] Value={ 1L,7L,13L,13L,25L,37L,37L,43L,37L,43L,55L,49L,73L,79L,79L,109L,97L,115L,85L,97L,97L,145L,121L,109L,163L,151L,151L,115L,121L,181L,175L,211L,193L,193L,211L,169L,211L,271L,187L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241985Inst : IEnumerable<long>
{
public static readonly long[] Value=A241985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241985.Bytes);
public long this[int i]=>Value[i];

public static A241985Inst Instance=new A241985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241984
{
public static readonly long[] Value={ 1L,7L,19L,37L,55L,82L,127L,166L,232L,316L,385L,463L,547L,634L,706L,805L,922L,1036L,1165L,1294L,1429L,1597L,1735L,1888L,2041L,2203L,2395L,2596L,2749L,2911L,3133L,3337L,3559L,3772L,4009L,4261L,4489L,4723L,4987L,5242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241984Inst : IEnumerable<long>
{
public static readonly long[] Value=A241984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241984.Bytes);
public long this[int i]=>Value[i];

public static A241984Inst Instance=new A241984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241967
{
public static readonly long[] Value={ 57L,775L,5211L,23320L,80132L,228826L,569874L,1277427L,2634115L,5075433L,9244885L,16061058L,26797798L,43178660L,67486804L,102691509L,152592477L,221983099L,316833855L,444497020L,613933848L,835965406L,1123548230L,1492075975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241967Inst : IEnumerable<long>
{
public static readonly long[] Value=A241967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241967.Bytes);
public long this[int i]=>Value[i];

public static A241967Inst Instance=new A241967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241966
{
public static readonly long[] Value={ 33L,311L,1597L,5778L,16660L,40978L,89622L,179079L,333091L,584529L,977483L,1569568L,2434446L,3664564L,5374108L,7702173L,10816149L,14915323L,20234697L,27049022L,35677048L,46485990L,59896210L,76386115L,96497271L,120839733L,150097591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241966Inst : IEnumerable<long>
{
public static readonly long[] Value=A241966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241966.Bytes);
public long this[int i]=>Value[i];

public static A241966Inst Instance=new A241966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241965
{
public static readonly long[] Value={ 19L,124L,486L,1421L,3437L,7280L,13980L,24897L,41767L,66748L,102466L,152061L,219233L,308288L,424184L,572577L,759867L,993244L,1280734L,1631245L,2054613L,2561648L,3164180L,3875105L,4708431L,5679324L,6804154L,8100541L,9587401L,11284992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241965Inst : IEnumerable<long>
{
public static readonly long[] Value=A241965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241965.Bytes);
public long this[int i]=>Value[i];

public static A241965Inst Instance=new A241965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241964
{
public static readonly long[] Value={ 11L,50L,19L,150L,124L,33L,355L,486L,311L,57L,721L,1421L,1597L,775L,97L,1316L,3437L,5778L,5211L,1895L,166L,2220L,7280L,16660L,23320L,16649L,4663L,285L,3525L,13980L,40978L,80132L,92037L,53553L,11518L,489L,5335L,24897L,89622L,228826L,376559L,365810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241964Inst : IEnumerable<long>
{
public static readonly long[] Value=A241964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241964.Bytes);
public long this[int i]=>Value[i];

public static A241964Inst Instance=new A241964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241963
{
public static readonly long[] Value={ 2220L,13980L,89622L,569874L,3536286L,22111157L,138925925L,873035589L,5475318946L,34331845408L,215383294448L,1351453881412L,8478796110164L,53190349676453L,333690439881015L,2093470677473842L,13133749568417338L,82396056288048569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241963Inst : IEnumerable<long>
{
public static readonly long[] Value=A241963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241963.Bytes);
public long this[int i]=>Value[i];

public static A241963Inst Instance=new A241963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241962
{
public static readonly long[] Value={ 1316L,7280L,40978L,228826L,1247602L,6853011L,37822419L,208778442L,1150195313L,6335359100L,34913522464L,192436464511L,1060537739121L,5844288421834L,32206928983867L,177491988769402L,978153244754765L,5390524419041649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241962Inst : IEnumerable<long>
{
public static readonly long[] Value=A241962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241962.Bytes);
public long this[int i]=>Value[i];

public static A241962Inst Instance=new A241962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241961
{
public static readonly long[] Value={ 721L,3437L,16660L,80132L,376559L,1782453L,8476317L,40313706L,191370192L,908268343L,4312922647L,20483132941L,97267496309L,461856616822L,2193101268453L,10414092378458L,49451882143389L,234822848509532L,1115058584108581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241961Inst : IEnumerable<long>
{
public static readonly long[] Value=A241961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241961.Bytes);
public long this[int i]=>Value[i];

public static A241961Inst Instance=new A241961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241960
{
public static readonly long[] Value={ 355L,1421L,5778L,23320L,92037L,365810L,1460409L,5830838L,23237977L,92595629L,369142639L,1471836335L,5867774115L,23391443650L,93250841634L,371756884287L,1482053418845L,5908333573340L,23554074220207L,93900552089203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241960Inst : IEnumerable<long>
{
public static readonly long[] Value=A241960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241960.Bytes);
public long this[int i]=>Value[i];

public static A241960Inst Instance=new A241960Inst();

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