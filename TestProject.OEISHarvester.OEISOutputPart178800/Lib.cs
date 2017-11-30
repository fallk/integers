using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A209257
{
public static readonly long[] Value={ 4L,7L,10L,16L,28L,52L,97L,193L,301L,493L,1150L,1162L,3076L,2386L,3283L,10423L,5827L,20659L,9376L,37852L,15112L,18592L,83692L,27331L,133660L,38857L,45832L,251050L,62566L,367318L,83527L,523315L,109375L,124351L,852826L,158872L,1152508L,200140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209257Inst : IEnumerable<long>
{
public static readonly long[] Value=A209257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209257.Bytes);
public long this[int i]=>Value[i];

public static A209257Inst Instance=new A209257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209258
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,21L,24L,27L,30L,33L,36L,39L,1L,5L,10L,14L,19L,23L,28L,32L,37L,41L,7L,13L,20L,26L,34L,40L,8L,17L,29L,38L,11L,25L,2L,22L,4L,35L,16L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209258Inst : IEnumerable<long>
{
public static readonly long[] Value=A209258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209258.Bytes);
public long this[int i]=>Value[i];

public static A209258Inst Instance=new A209258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209259
{
public static readonly long[] Value={ 1L,2L,0L,3L,8L,5L,6L,7L,12L,11L,18L,13L,24L,17L,42L,19L,48L,23L,14L,29L,30L,31L,10L,37L,60L,41L,66L,43L,36L,47L,20L,53L,44L,59L,78L,61L,22L,67L,96L,71L,108L,73L,28L,79L,84L,83L,68L,89L,102L,97L,126L,101L,90L,103L,120L,107L,72L,109L,54L,113L,114L,127L,150L,131L,26L,137L,132L,139L,144L,149L,162L,151L,16L,157L,34L,163L,186L,167L,56L,173L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209259Inst : IEnumerable<long>
{
public static readonly long[] Value=A209259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209259.Bytes);
public long this[int i]=>Value[i];

public static A209259Inst Instance=new A209259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209260
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,7L,9L,10L,12L,14L,15L,11L,18L,20L,21L,13L,22L,25L,27L,28L,8L,26L,30L,33L,35L,36L,17L,24L,39L,42L,44L,45L,19L,34L,40L,49L,52L,54L,55L,38L,51L,56L,60L,63L,65L,66L,23L,50L,57L,68L,72L,75L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209260Inst : IEnumerable<long>
{
public static readonly long[] Value=A209260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209260.Bytes);
public long this[int i]=>Value[i];

public static A209260Inst Instance=new A209260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209261
{
public static readonly long[] Value={ 1L,27L,8387L,1596559L,67137477L,1221074483L,13065520903L,96951759015L,550571544713L,2552470327819L,10137858491979L,36314872538111L,130291290501709L,605750213184675L,4731091158953615L,53132088082450327L,669920208810550545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209261Inst : IEnumerable<long>
{
public static readonly long[] Value=A209261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209261.Bytes);
public long this[int i]=>Value[i];

public static A209261Inst Instance=new A209261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209262
{
public static readonly long[] Value={ 1L,10L,97L,424L,1249L,2926L,5905L,10732L,18049L,28594L,43201L,62800L,88417L,121174L,162289L,213076L,274945L,349402L,438049L,542584L,664801L,806590L,969937L,1156924L,1369729L,1610626L,1881985L,2186272L,2526049L,2903974L,3322801L,3785380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209262Inst : IEnumerable<long>
{
public static readonly long[] Value=A209262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209262.Bytes);
public long this[int i]=>Value[i];

public static A209262Inst Instance=new A209262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209263
{
public static readonly long[] Value={ 1L,15L,257L,1639L,6369L,18551L,44785L,94767L,181889L,323839L,543201L,868055L,1332577L,1977639L,2851409L,4009951L,5517825L,7448687L,9885889L,12923079L,16664801L,21227095L,26738097L,33338639L,41182849L,50438751L,61288865L,73930807L,88577889L,105459719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209263Inst : IEnumerable<long>
{
public static readonly long[] Value=A209263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209263.Bytes);
public long this[int i]=>Value[i];

public static A209263Inst Instance=new A209263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209264
{
public static readonly long[] Value={ 1L,21L,641L,6013L,30945L,112301L,324721L,800661L,1754753L,3512485L,6543201L,11497421L,19248481L,30938493L,48028625L,72353701L,106181121L,152274101L,213959233L,295198365L,400664801L,535823821L,707017521L,921553973L,1187800705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209264Inst : IEnumerable<long>
{
public static readonly long[] Value=A209264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209264.Bytes);
public long this[int i]=>Value[i];

public static A209264Inst Instance=new A209264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209265
{
public static readonly long[] Value={ 1L,28L,1537L,21322L,145633L,659176L,2284273L,6565462L,16434817L,36993268L,76543201L,147907618L,270071137L,470178112L,785923153L,1268369326L,1985229313L,3024644812L,4499499457L,6552300538L,9360664801L,13143443608L,18167522737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209265Inst : IEnumerable<long>
{
public static readonly long[] Value=A209265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209265.Bytes);
public long this[int i]=>Value[i];

public static A209265Inst Instance=new A209265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209266
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,1L,3L,3L,1L,3L,3L,4L,3L,5L,4L,2L,5L,4L,4L,4L,4L,3L,3L,6L,6L,4L,4L,3L,4L,5L,6L,3L,6L,5L,4L,5L,5L,6L,4L,3L,4L,5L,5L,2L,5L,4L,6L,4L,6L,6L,3L,7L,5L,7L,6L,4L,7L,6L,5L,5L,7L,5L,4L,5L,8L,6L,7L,6L,8L,6L,7L,9L,4L,6L,5L,5L,8L,3L,6L,6L,5L,4L,6L,5L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209266Inst : IEnumerable<long>
{
public static readonly long[] Value=A209266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209266.Bytes);
public long this[int i]=>Value[i];

public static A209266Inst Instance=new A209266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209267
{
public static readonly long[] Value={ 1L,36L,3585L,73810L,669921L,3784176L,15721201L,52683870L,150652545L,381367036L,876543201L,1862778666L,3709924705L,6996023880L,12592235601L,21771494326L,36344967681L,58830704340L,92659184065L,142420804866L,214160664801L,315726318496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209267Inst : IEnumerable<long>
{
public static readonly long[] Value=A209267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209267.Bytes);
public long this[int i]=>Value[i];

public static A209267Inst Instance=new A209267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209268
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,10L,7L,15L,9L,21L,8L,28L,14L,36L,11L,45L,20L,55L,13L,66L,27L,78L,12L,91L,35L,105L,19L,120L,44L,136L,16L,153L,54L,171L,26L,190L,65L,210L,18L,231L,77L,253L,34L,276L,90L,300L,17L,325L,104L,351L,43L,378L,119L,406L,25L,435L,135L,465L,53L,496L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209268Inst : IEnumerable<long>
{
public static readonly long[] Value=A209268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209268.Bytes);
public long this[int i]=>Value[i];

public static A209268Inst Instance=new A209268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209269
{
public static readonly long[] Value={ 1L,3L,2L,5L,43L,522L,1104509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209269Inst : IEnumerable<long>
{
public static readonly long[] Value=A209269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209269.Bytes);
public long this[int i]=>Value[i];

public static A209269Inst Instance=new A209269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209270
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,4L,6L,8L,4L,6L,38L,10L,14L,16L,6L,2L,12L,24L,100L,36L,74L,46L,44L,52L,18L,8L,46L,114L,20L,70L,6L,38L,190L,44L,76L,14L,118L,218L,34L,14L,82L,32L,28L,110L,76L,126L,230L,46L,578L,138L,192L,306L,424L,38L,148L,468L,218L,210L,174L,300L,244L,60L,744L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209270Inst : IEnumerable<long>
{
public static readonly long[] Value=A209270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209270.Bytes);
public long this[int i]=>Value[i];

public static A209270Inst Instance=new A209270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209271
{
public static readonly long[] Value={ 5L,13L,181L,613L,761L,1201L,8581L,9661L,21013L,26681L,34061L,59513L,68821L,101701L,156241L,584281L,637321L,718801L,782501L,787513L,1078981L,1193513L,1336613L,1470613L,1529501L,1639861L,1757813L,2103301L,2257813L,2287661L,2601481L,3540461L,4307113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209271Inst : IEnumerable<long>
{
public static readonly long[] Value=A209271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209271.Bytes);
public long this[int i]=>Value[i];

public static A209271Inst Instance=new A209271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209272
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,4L,2L,3L,1L,4L,3L,4L,1L,1L,4L,2L,1L,3L,1L,4L,2L,1L,2L,1L,4L,4L,2L,1L,2L,4L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,4L,2L,4L,2L,3L,4L,1L,2L,4L,1L,1L,3L,1L,1L,3L,1L,1L,4L,3L,1L,3L,1L,1L,4L,2L,1L,2L,1L,3L,1L,3L,2L,3L,1L,3L,1L,2L,4L,2L,3L,1L,3L,1L,2L,1L,6L,4L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,4L,2L,1L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209272Inst : IEnumerable<long>
{
public static readonly long[] Value=A209272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209272.Bytes);
public long this[int i]=>Value[i];

public static A209272Inst Instance=new A209272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209273
{
public static readonly long[] Value={ 1L,6L,4L,4L,9L,4L,8L,6L,5L,0L,1L,1L,5L,9L,5L,7L,5L,6L,0L,9L,6L,0L,7L,7L,9L,4L,5L,0L,9L,7L,8L,5L,8L,0L,9L,1L,5L,8L,6L,3L,2L,9L,5L,3L,4L,9L,6L,4L,6L,6L,4L,3L,8L,7L,5L,9L,3L,7L,0L,2L,7L,6L,9L,2L,1L,4L,9L,2L,3L,3L,6L,0L,1L,6L,3L,1L,8L,4L,4L,2L,4L,8L,4L,6L,0L,7L,0L,6L,8L,1L,1L,7L,9L,0L,0L,2L,8L,6L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209273Inst : IEnumerable<long>
{
public static readonly long[] Value=A209273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209273.Bytes);
public long this[int i]=>Value[i];

public static A209273Inst Instance=new A209273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209274
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,9L,10L,16L,17L,15L,14L,15L,32L,33L,27L,22L,20L,21L,64L,65L,51L,38L,30L,27L,28L,128L,129L,99L,70L,50L,39L,35L,36L,256L,257L,195L,134L,90L,63L,49L,44L,45L,512L,513L,387L,262L,170L,111L,77L,60L,54L,55L,1024L,1025L,771L,518L,330L,207L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209274Inst : IEnumerable<long>
{
public static readonly long[] Value=A209274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209274.Bytes);
public long this[int i]=>Value[i];

public static A209274Inst Instance=new A209274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209275
{
public static readonly long[] Value={ 1L,45L,8193L,250957L,3029217L,21362301L,106420465L,415866333L,1358612097L,3868151437L,9876543201L,23084307885L,50147947873L,102436518237L,198541656657L,367761728701L,654820258305L,1126121592813L,1877892797377L,3046610084877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209275Inst : IEnumerable<long>
{
public static readonly long[] Value=A209275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209275.Bytes);
public long this[int i]=>Value[i];

public static A209275Inst Instance=new A209275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209276
{
public static readonly BigInteger[] Value={ 1L,1L,6L,133L,9403L,2065969L,1400088539L,2908156231705L,18410003437367130L,BigInteger.Parse("353588715425938097698"),BigInteger.Parse("20534146782689861283550052"),BigInteger.Parse("3596867485365965032072729708845"),BigInteger.Parse("1897112888731795684931545113460297299"),BigInteger.Parse("3009299517165127420220975531888408947667944") };
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
public class A209276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209276Inst Instance=new A209276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209277
{
public static readonly BigInteger[] Value={ 1L,1L,8L,321L,57879L,45643415L,154158595175L,2190765237132015L,BigInteger.Parse("129241431881731600186"),BigInteger.Parse("31339180791153421540163500"),BigInteger.Parse("31011964321205837200260130287298"),BigInteger.Parse("124581202469689320858858825068619255535"),BigInteger.Parse("2023924731754579903607034623889070335771466703") };
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
public class A209277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209277Inst Instance=new A209277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209278
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,3L,2L,4L,1L,3L,4L,2L,5L,1L,4L,3L,5L,2L,6L,1L,4L,5L,3L,6L,2L,7L,1L,5L,4L,6L,3L,7L,2L,8L,1L,5L,6L,4L,7L,3L,8L,2L,9L,1L,6L,5L,7L,4L,8L,3L,9L,2L,10L,1L,6L,7L,5L,8L,4L,9L,3L,10L,2L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209278Inst : IEnumerable<long>
{
public static readonly long[] Value=A209278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209278.Bytes);
public long this[int i]=>Value[i];

public static A209278Inst Instance=new A209278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209279
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,2L,3L,1L,4L,3L,2L,4L,1L,5L,3L,4L,2L,5L,1L,6L,4L,3L,5L,2L,6L,1L,7L,4L,5L,3L,6L,2L,7L,1L,8L,5L,4L,6L,3L,7L,2L,8L,1L,9L,5L,6L,4L,7L,3L,8L,2L,9L,1L,10L,6L,5L,7L,4L,8L,3L,9L,2L,10L,1L,11L,12L,7L,6L,8L,5L,9L,4L,10L,3L,11L,2L,12L,1L,13L,7L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209279Inst : IEnumerable<long>
{
public static readonly long[] Value=A209279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209279.Bytes);
public long this[int i]=>Value[i];

public static A209279Inst Instance=new A209279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209280
{
public static readonly long[] Value={ 9L,81L,18L,81L,9L,702L,9L,171L,27L,72L,18L,693L,18L,72L,27L,171L,9L,702L,9L,81L,18L,81L,9L,5913L,9L,81L,18L,81L,9L,1602L,9L,261L,36L,63L,27L,594L,18L,162L,36L,162L,18L,603L,9L,171L,27L,72L,18L,5814L,9L,171L,27L,72L,18L,603L,9L,261L,36L,63L,27L,1584L,27L,63L,36L,261L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209280Inst : IEnumerable<long>
{
public static readonly long[] Value=A209280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209280.Bytes);
public long this[int i]=>Value[i];

public static A209280Inst Instance=new A209280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209281
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,1L,2L,4L,3L,2L,3L,1L,2L,3L,2L,5L,4L,3L,4L,2L,3L,4L,3L,1L,2L,3L,2L,4L,3L,2L,3L,6L,5L,4L,5L,3L,4L,5L,4L,2L,3L,4L,3L,5L,4L,3L,4L,1L,2L,3L,2L,4L,3L,2L,3L,5L,4L,3L,4L,2L,3L,4L,3L,7L,6L,5L,6L,4L,5L,6L,5L,3L,4L,5L,4L,6L,5L,4L,5L,2L,3L,4L,3L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209281Inst : IEnumerable<long>
{
public static readonly long[] Value=A209281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209281.Bytes);
public long this[int i]=>Value[i];

public static A209281Inst Instance=new A209281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209282
{
public static readonly long[] Value={ 161L,288L,1L,70L,90L,470L,89L,1L,70L,1L,89L,470L,90L,70L,1L,288L,161L,288L,1L,70L,90L,470L,89L,1L,70L,1L,89L,470L,90L,70L,1L,288L,161L,288L,1L,70L,90L,470L,89L,1L,70L,1L,89L,470L,90L,70L,1L,288L,161L,288L,1L,70L,90L,470L,89L,1L,70L,1L,89L,470L,90L,70L,1L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209282Inst : IEnumerable<long>
{
public static readonly long[] Value=A209282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209282.Bytes);
public long this[int i]=>Value[i];

public static A209282Inst Instance=new A209282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209283
{
public static readonly long[] Value={ 6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L,1L,1L,4L,6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L,1L,1L,4L,6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L,1L,1L,4L,6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L,1L,1L,4L,6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L,1L,1L,4L,6L,8L,5L,1L,4L,2L,4L,1L,5L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209283Inst : IEnumerable<long>
{
public static readonly long[] Value=A209283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209283.Bytes);
public long this[int i]=>Value[i];

public static A209283Inst Instance=new A209283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209284
{
public static readonly long[] Value={ 2L,2L,4L,4L,10L,14L,22L,32L,70L,122L,178L,286L,518L,898L,1610L,2666L,4702L,8506L,14982L,26668L,48022L,85904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209284Inst : IEnumerable<long>
{
public static readonly long[] Value=A209284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209284.Bytes);
public long this[int i]=>Value[i];

public static A209284Inst Instance=new A209284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209285
{
public static readonly long[] Value={ 6L,8L,5L,1L,6L,28L,1L,1L,4L,14L,10L,6L,1L,5L,8L,6L,6L,10L,13L,1L,4L,2L,5L,23L,1L,5L,6L,8L,6L,10L,6L,8L,6L,5L,1L,23L,5L,2L,4L,1L,13L,10L,6L,6L,8L,5L,1L,6L,10L,14L,4L,1L,1L,28L,6L,1L,5L,8L,6L,10L,6L,8L,5L,1L,6L,28L,1L,1L,4L,14L,10L,6L,1L,5L,8L,6L,6L,10L,13L,1L,4L,2L,5L,23L,1L,5L,6L,8L,6L,10L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209285Inst : IEnumerable<long>
{
public static readonly long[] Value=A209285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209285.Bytes);
public long this[int i]=>Value[i];

public static A209285Inst Instance=new A209285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209286
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,3L,5L,9L,27L,77L,329L,2435L,27845L,829289L,68634299L,23160214349L,56940830227049L,1589642017432217699L,BigInteger.Parse("1318763422910513770158149"),BigInteger.Parse("90515537555154997905172366725449"),BigInteger.Parse("2096361748201801549831377117539292825822299") };
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
public class A209286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209286Inst Instance=new A209286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209287
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,2L,1L,1L,0L,0L,0L,2L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,1L,1L,0L,0L,0L,2L,1L,0L,3L,2L,1L,1L,0L,2L,0L,3L,2L,2L,0L,0L,0L,1L,1L,2L,1L,0L,4L,2L,1L,0L,1L,4L,0L,2L,0L,0L,1L,2L,2L,0L,0L,1L,2L,2L,2L,1L,3L,2L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209287Inst : IEnumerable<long>
{
public static readonly long[] Value=A209287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209287.Bytes);
public long this[int i]=>Value[i];

public static A209287Inst Instance=new A209287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209288
{
public static readonly BigInteger[] Value={ 1L,4L,196L,22096L,3323092L,574346824L,107697153304L,21304602938056L,4376897152490644L,924871720044550888L,BigInteger.Parse("199731547307306769736"),BigInteger.Parse("43887077830441507774336"),BigInteger.Parse("9780481173520567895278600"),BigInteger.Parse("2205358814500087896152369104"),BigInteger.Parse("502225405515985555630557626848") };
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
public class A209288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209288Inst Instance=new A209288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209289
{
public static readonly BigInteger[] Value={ 1L,2L,40L,2256L,250496L,46063360L,12665422848L,4866544707584L,2490379333697536L,1637285952230719488L,BigInteger.Parse("1344814260872574402560"),BigInteger.Parse("1349528279475362368847872"),BigInteger.Parse("1624638302165034485761966080"),BigInteger.Parse("2310920106523435237448955723776"),BigInteger.Parse("3834278385523271302103123693142016") };
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
public class A209289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209289Inst Instance=new A209289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209290
{
public static readonly BigInteger[] Value={ 0L,0L,2L,24L,324L,5120L,93750L,1959552L,46118408L,1207959552L,34867844010L,1100000000000L,37661140520652L,1390911669927936L,55123269399790046L,2333521433367183360L,BigInteger.Parse("105094533691406250000"),BigInteger.Parse("5017514388048998039552"),BigInteger.Parse("253135520137219049838162"),BigInteger.Parse("13456471561751415850795008") };
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
public class A209290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209290Inst Instance=new A209290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209291
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,3L,3L,11L,20L,20L,20L,32L,32L,32L,32L,32L,32L,50L,50L,50L,50L,50L,50L,74L,74L,74L,74L,74L,74L,74L,74L,74L,74L,74L,74L,110L,110L,110L,110L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,150L,206L,206L,206L,206L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209291Inst : IEnumerable<long>
{
public static readonly long[] Value=A209291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209291.Bytes);
public long this[int i]=>Value[i];

public static A209291Inst Instance=new A209291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209292
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,13L,18L,20L,23L,29L,30L,31L,36L,37L,40L,41L,44L,48L,50L,52L,53L,54L,56L,63L,67L,68L,73L,75L,76L,78L,81L,83L,89L,90L,96L,97L,98L,99L,103L,105L,112L,113L,114L,116L,120L,125L,127L,128L,130L,131L,135L,136L,137L,138L,139L,140L,148L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209292Inst : IEnumerable<long>
{
public static readonly long[] Value=A209292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209292.Bytes);
public long this[int i]=>Value[i];

public static A209292Inst Instance=new A209292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209293
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,8L,9L,7L,10L,13L,12L,14L,11L,15L,18L,19L,17L,20L,16L,21L,25L,24L,26L,23L,27L,22L,28L,32L,33L,31L,34L,30L,35L,29L,36L,41L,40L,42L,39L,43L,38L,44L,37L,45L,50L,51L,49L,52L,48L,53L,47L,54L,46L,55L,61L,60L,62L,59L,63L,58L,64L,57L,65L,56L,66L,72L,73L,71L,74L,70L,75L,69L,76L,68L,77L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209293Inst : IEnumerable<long>
{
public static readonly long[] Value=A209293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209293.Bytes);
public long this[int i]=>Value[i];

public static A209293Inst Instance=new A209293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209294
{
public static readonly long[] Value={ 2L,9L,23L,44L,72L,107L,149L,198L,254L,317L,387L,464L,548L,639L,737L,842L,954L,1073L,1199L,1332L,1472L,1619L,1773L,1934L,2102L,2277L,2459L,2648L,2844L,3047L,3257L,3474L,3698L,3929L,4167L,4412L,4664L,4923L,5189L,5462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209294Inst : IEnumerable<long>
{
public static readonly long[] Value=A209294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209294.Bytes);
public long this[int i]=>Value[i];

public static A209294Inst Instance=new A209294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209295
{
public static readonly long[] Value={ 2L,5L,8L,12L,14L,21L,20L,28L,30L,37L,32L,52L,38L,53L,60L,64L,50L,81L,56L,92L,86L,85L,68L,124L,90L,101L,108L,132L,86L,165L,92L,144L,138L,133L,152L,204L,110L,149L,164L,220L,122L,237L,128L,212L,234L,181L,140L,288L,182L,245L,216L,252L,158L,297L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209295Inst : IEnumerable<long>
{
public static readonly long[] Value=A209295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209295.Bytes);
public long this[int i]=>Value[i];

public static A209295Inst Instance=new A209295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209296
{
public static readonly BigInteger[] Value={ 3L,13L,43L,33013L,10243213L,670302913L,207263519443L,BigInteger.Parse("119244359152460559009973"),BigInteger.Parse("565918396036931688582304453"),BigInteger.Parse("529942848372194145518502999686683108035251455827553") };
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
public class A209296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209296Inst Instance=new A209296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209297
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,9L,1L,6L,11L,16L,1L,7L,13L,19L,25L,1L,8L,15L,22L,29L,36L,1L,9L,17L,25L,33L,41L,49L,1L,10L,19L,28L,37L,46L,55L,64L,1L,11L,21L,31L,41L,51L,61L,71L,81L,1L,12L,23L,34L,45L,56L,67L,78L,89L,100L,1L,13L,25L,37L,49L,61L,73L,85L,97L,109L,121L,1L,14L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209297Inst : IEnumerable<long>
{
public static readonly long[] Value=A209297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209297.Bytes);
public long this[int i]=>Value[i];

public static A209297Inst Instance=new A209297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209298
{
public static readonly BigInteger[] Value={ 1L,1L,0L,4L,6L,30L,348L,1580L,12516L,114884L,1375776L,12239280L,160067160L,1966619512L,28104385008L,428735710000L,6769181533968L,110402248461840L,2070626881211136L,38342125010072384L,764180537501729376L,16185744192232110560UL,BigInteger.Parse("354756690964676468160") };
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
public class A209298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209298Inst Instance=new A209298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209299
{
public static readonly BigInteger[] Value={ 1L,1L,4L,16L,98L,650L,5492L,50468L,543252L,6375668L,83752144L,1191943168L,18563252968L,310499073352L,5598292885200L,107674197010960L,2208771882047120L,48025183073776016L,1105381958987588672L,BigInteger.Parse("26817991185065949440"),BigInteger.Parse("684717365565811694880"),BigInteger.Parse("18341702444087583851936") };
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
public class A209299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209299Inst Instance=new A209299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209300
{
public static readonly BigInteger[] Value={ 0L,1L,208L,302113L,12135038976L,53366922838224001L,BigInteger.Parse("60766008114261830429310976"),BigInteger.Parse("6922077673356416725162445396958387201"),BigInteger.Parse("84806450837637486354121195943915016945664000000000"),BigInteger.Parse("120401303109437699738873226784807398144004603135278868200044928001") };
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
public class A209300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209300Inst Instance=new A209300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209301
{
public static readonly long[] Value={ 1L,3L,1L,2L,4L,3L,1L,2L,3L,5L,4L,3L,1L,2L,3L,4L,6L,5L,4L,3L,1L,2L,3L,4L,5L,7L,6L,5L,4L,3L,1L,2L,3L,4L,5L,6L,8L,7L,6L,5L,4L,3L,1L,2L,3L,4L,5L,6L,7L,9L,8L,7L,6L,5L,4L,3L,1L,2L,3L,4L,5L,6L,7L,8L,10L,9L,8L,7L,6L,5L,4L,3L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209301Inst : IEnumerable<long>
{
public static readonly long[] Value=A209301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209301.Bytes);
public long this[int i]=>Value[i];

public static A209301Inst Instance=new A209301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209302
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,5L,6L,7L,6L,5L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L,9L,8L,7L,8L,9L,10L,11L,12L,13L,14L,15L,14L,13L,12L,11L,10L,9L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209302Inst : IEnumerable<long>
{
public static readonly long[] Value=A209302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209302.Bytes);
public long this[int i]=>Value[i];

public static A209302Inst Instance=new A209302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209303
{
public static readonly long[] Value={ 2L,8L,18L,32L,50L,72L,98L,101L,123L,128L,149L,162L,179L,213L,251L,293L,339L,389L,404L,443L,446L,492L,542L,596L,654L,716L,782L,852L,909L,926L,971L,1037L,1107L,1181L,1259L,1341L,1427L,1517L,1611L,1616L,1698L,1784L,1874L,1968L,2066L,2168L,2274L,2384L,2498L,2525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209303Inst : IEnumerable<long>
{
public static readonly long[] Value=A209303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209303.Bytes);
public long this[int i]=>Value[i];

public static A209303Inst Instance=new A209303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209304
{
public static readonly long[] Value={ 1L,5L,2L,9L,6L,3L,13L,10L,7L,4L,17L,14L,11L,8L,5L,21L,18L,15L,12L,9L,6L,25L,22L,19L,16L,13L,10L,7L,29L,26L,23L,20L,17L,14L,11L,8L,33L,30L,27L,24L,21L,18L,15L,12L,9L,37L,34L,31L,28L,25L,22L,19L,16L,13L,10L,41L,38L,35L,32L,29L,26L,23L,20L,17L,14L,11L,45L,42L,39L,36L,33L,30L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209304Inst : IEnumerable<long>
{
public static readonly long[] Value=A209304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209304.Bytes);
public long this[int i]=>Value[i];

public static A209304Inst Instance=new A209304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209305
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,151L,1821L,27675L,507177L,10879247L,267329317L,7403007507L,228096010961L,7739098803559L,286704779800173L,11514881722287051L,498352218891144249L,BigInteger.Parse("23120905868853862655"),BigInteger.Parse("1144719051552552433525"),BigInteger.Parse("60241163501500355522499") };
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
public class A209305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209305Inst Instance=new A209305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209306
{
public static readonly BigInteger[] Value={ 1L,6L,52L,608L,9000L,161320L,3395384L,82067848L,2239857464L,68123898696L,2284557569272L,83741888125064L,3330861429420984L,142875672420718024L,6574169480181294200L,BigInteger.Parse("322998830024467434760"),BigInteger.Parse("16876498518902786900792"),BigInteger.Parse("934400728689236533139016") };
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
public class A209306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209306Inst Instance=new A209306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209307
{
public static readonly BigInteger[] Value={ 1L,2L,8L,52L,492L,6172L,96572L,1810940L,39585980L,988367804L,27750071036L,865420762876L,29680685363772L,1110252095824444L,44984193111861116L,1962563143587356540L,BigInteger.Parse("91727727493033914044"),BigInteger.Parse("4572606297018521071292"),BigInteger.Parse("242169416254095528953852") };
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
public class A209307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209307Inst Instance=new A209307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209308
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,4L,4L,4L,8L,8L,1L,4L,8L,4L,16L,2L,2L,1L,8L,32L,32L,1L,2L,4L,4L,16L,32L,64L,8L,8L,16L,16L,64L,64L,128L,128L,1L,8L,16L,8L,32L,64L,128L,32L,256L,2L,2L,8L,16L,64L,64L,128L,64L,512L,512L,1L,2L,4L,8L,32L,64L,128L,16L,128L,512L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209308Inst : IEnumerable<long>
{
public static readonly long[] Value=A209308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209308.Bytes);
public long this[int i]=>Value[i];

public static A209308Inst Instance=new A209308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209309
{
public static readonly long[] Value={ 6L,12L,18L,24L,48L,54L,96L,102L,110L,114L,138L,162L,174L,186L,192L,204L,220L,222L,228L,246L,258L,282L,315L,318L,348L,354L,364L,366L,372L,384L,402L,414L,426L,438L,440L,444L,456L,474L,486L,492L,498L,516L,522L,534L,550L,558L,564L,582L,606L,618L,636L,642L,654L,678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209309Inst : IEnumerable<long>
{
public static readonly long[] Value=A209309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209309.Bytes);
public long this[int i]=>Value[i];

public static A209309Inst Instance=new A209309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209310
{
public static readonly long[] Value={ 6L,4186L,32131L,52975L,78210L,111628L,237016L,247456L,584821L,750925L,1464616L,3649051L,5791906L,11297881L,16082956L,24650731L,27243271L,38618866L,46585378L,51546781L,56026405L,76923406L,89880528L,96070591L,126906346L,164629585L,201854278L,228733966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209310Inst : IEnumerable<long>
{
public static readonly long[] Value=A209310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209310.Bytes);
public long this[int i]=>Value[i];

public static A209310Inst Instance=new A209310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209311
{
public static readonly long[] Value={ 285L,1302L,1425L,1820L,2508L,3640L,3720L,4845L,4956L,5016L,5415L,7125L,7280L,9100L,9114L,9912L,11685L,12255L,12740L,14508L,15105L,16815L,17385L,18200L,19095L,19824L,20235L,20805L,22134L,22515L,23655L,23660L,24021L,24738L,25365L,25480L,27075L,27588L,27645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209311Inst : IEnumerable<long>
{
public static readonly long[] Value=A209311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209311.Bytes);
public long this[int i]=>Value[i];

public static A209311Inst Instance=new A209311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209312
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,2L,1L,2L,3L,2L,4L,1L,2L,3L,3L,3L,4L,2L,4L,3L,4L,3L,6L,3L,2L,3L,4L,4L,6L,3L,5L,3L,4L,5L,8L,3L,2L,5L,5L,4L,7L,4L,7L,4L,2L,4L,11L,3L,1L,4L,7L,4L,7L,6L,7L,3L,4L,5L,12L,3L,2L,4L,8L,7L,8L,5L,9L,4L,2L,6L,14L,5L,2L,6L,7L,7L,9L,5L,9L,4L,4L,5L,14L,8L,2L,5L,8L,7L,10L,6L,9L,6L,2L,8L,15L,5L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209312Inst : IEnumerable<long>
{
public static readonly long[] Value=A209312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209312.Bytes);
public long this[int i]=>Value[i];

public static A209312Inst Instance=new A209312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209313
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,3L,23L,15L,45L,45L,135L,35L,283L,230L,387L,355L,1049L,487L,1900L,1026L,2503L,2797L,5697L,1626L,8659L,8008L,12095L,9634L,24992L,9501L,39505L,25265L,48822L,51978L,81526L,30795L,143678L,121430L,173479L,110091L,320795L,151247L,472371L,318324L,477480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209313Inst : IEnumerable<long>
{
public static readonly long[] Value=A209313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209313.Bytes);
public long this[int i]=>Value[i];

public static A209313Inst Instance=new A209313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209314
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,0L,0L,1L,1L,1L,2L,3L,1L,1L,0L,0L,0L,1L,1L,1L,2L,3L,5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,3L,5L,7L,1L,1L,2L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,3L,5L,7L,11L,0L,1L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209314Inst : IEnumerable<long>
{
public static readonly long[] Value=A209314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209314.Bytes);
public long this[int i]=>Value[i];

public static A209314Inst Instance=new A209314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209315
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,2L,2L,3L,1L,3L,4L,2L,2L,2L,3L,4L,3L,1L,3L,3L,1L,4L,5L,3L,3L,3L,2L,5L,4L,1L,3L,5L,2L,5L,4L,3L,4L,5L,2L,5L,5L,2L,4L,5L,3L,6L,5L,5L,5L,2L,3L,6L,5L,2L,3L,4L,3L,6L,5L,4L,4L,4L,5L,6L,6L,4L,5L,4L,3L,6L,8L,2L,2L,5L,6L,7L,6L,2L,6L,2L,4L,7L,6L,4L,3L,6L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209315Inst : IEnumerable<long>
{
public static readonly long[] Value=A209315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209315.Bytes);
public long this[int i]=>Value[i];

public static A209315Inst Instance=new A209315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209316
{
public static readonly BigInteger[] Value={ 1L,1L,4L,57L,2456L,240205L,44616096L,14030856525L,6897867308800L,4999592004999705L,5107861266649227520L,BigInteger.Parse("7098997630368216900833"),BigInteger.Parse("13040338287878632604362752"),BigInteger.Parse("30913685990004537377333201253"),BigInteger.Parse("92695803952674372198927320920064"),BigInteger.Parse("345599063527286969179932122231749365") };
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
public class A209316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209316Inst Instance=new A209316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209317
{
public static readonly BigInteger[] Value={ 1L,1L,4L,57L,2072L,147925L,17749536L,3240106485L,840395708928L,294739255397385L,134627422799345920L,BigInteger.Parse("77773271544276025553"),BigInteger.Parse("55500837134575871643648"),BigInteger.Parse("47990173549409999557055133"),BigInteger.Parse("49475217831781002832374386688"),BigInteger.Parse("59989657372751900405803761497805"),BigInteger.Parse("84553864714598468031554754299887616") };
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
public class A209317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209317.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209317Inst Instance=new A209317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209318
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,2L,0L,1L,3L,2L,1L,0L,1L,3L,4L,1L,0L,1L,4L,5L,3L,0L,1L,4L,6L,4L,1L,0L,1L,5L,8L,6L,2L,0L,1L,5L,10L,8L,3L,0L,1L,6L,11L,12L,5L,1L,0L,1L,6L,14L,14L,8L,1L,0L,1L,7L,16L,19L,11L,3L,0L,1L,7L,18L,23L,16L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209318Inst : IEnumerable<long>
{
public static readonly long[] Value=A209318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209318.Bytes);
public long this[int i]=>Value[i];

public static A209318Inst Instance=new A209318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209319
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,218L,2451L,33832L,554527L,10535100L,227790505L,5525843696L,148673435769L,4394818486456L,141611317636075L,4940870266568160L,185595910032346111L,7468517348971708688L,BigInteger.Parse("320562141349559055633"),BigInteger.Parse("14619577651630443611200"),BigInteger.Parse("706025600924216704982425") };
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
public class A209319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209319Inst Instance=new A209319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209320
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,2L,2L,2L,2L,3L,4L,5L,3L,2L,3L,3L,5L,7L,3L,3L,4L,4L,5L,8L,4L,3L,5L,2L,4L,8L,3L,4L,6L,2L,4L,7L,3L,4L,7L,2L,4L,9L,4L,4L,9L,5L,3L,9L,3L,5L,8L,3L,4L,10L,4L,6L,8L,5L,4L,14L,2L,4L,8L,2L,6L,10L,4L,4L,7L,4L,4L,10L,5L,4L,8L,3L,4L,9L,5L,5L,7L,3L,3L,13L,6L,5L,7L,4L,2L,11L,5L,5L,9L,4L,2L,9L,3L,6L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209320Inst : IEnumerable<long>
{
public static readonly long[] Value=A209320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209320.Bytes);
public long this[int i]=>Value[i];

public static A209320Inst Instance=new A209320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209321
{
public static readonly long[] Value={ 9L,11L,14L,17L,26L,31L,38L,46L,62L,70L,74L,86L,94L,118L,134L,194L,206L,278L,286L,566L,598L,778L,842L,934L,1006L,1082L,1214L,1238L,1546L,1574L,1726L,1858L,2018L,2278L,2474L,2774L,3142L,3686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209321Inst : IEnumerable<long>
{
public static readonly long[] Value=A209321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209321.Bytes);
public long this[int i]=>Value[i];

public static A209321Inst Instance=new A209321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209322
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,14L,102L,682L,5484L,49288L,492812L,5418154L,64993966L,844658714L,11822116868L,177292309424L,2836140479376L,48206588630826L,867597809813018L,16482372327022854L,329612875955466784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209322Inst : IEnumerable<long>
{
public static readonly long[] Value=A209322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209322.Bytes);
public long this[int i]=>Value[i];

public static A209322Inst Instance=new A209322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209323
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,2L,3L,3L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,2L,2L,2L,1L,3L,3L,2L,2L,2L,3L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,2L,3L,2L,2L,2L,3L,3L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,2L,2L,2L,2L,1L,3L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209323Inst : IEnumerable<long>
{
public static readonly long[] Value=A209323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209323.Bytes);
public long this[int i]=>Value[i];

public static A209323Inst Instance=new A209323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209324
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,17L,1L,45L,68L,142L,1L,165L,680L,710L,1569L,1L,855L,6290L,8520L,9414L,21576L,1L,3843L,47600L,134190L,131796L,151032L,355081L,1L,21819L,481712L,1838900L,2372328L,2416512L,2840648L,6805296L,1L,114075L,5025608L,21488292L,50609664L,48934368L,51131664L,61247664L,148869153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209324Inst : IEnumerable<long>
{
public static readonly long[] Value=A209324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209324.Bytes);
public long this[int i]=>Value[i];

public static A209324Inst Instance=new A209324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209325
{
public static readonly long[] Value={ 0L,0L,0L,2L,5L,30L,163L,1172L,9349L,84208L,842149L,9266416L,111220875L,1446134218L,20248984181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209325Inst : IEnumerable<long>
{
public static readonly long[] Value=A209325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209325.Bytes);
public long this[int i]=>Value[i];

public static A209325Inst Instance=new A209325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209326
{
public static readonly long[] Value={ 0L,1L,0L,3L,7L,39L,207L,1437L,11203L,99041L,975645L,10601377L,125905445L,1622349059L,22539777113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209326Inst : IEnumerable<long>
{
public static readonly long[] Value=A209326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209326.Bytes);
public long this[int i]=>Value[i];

public static A209326Inst Instance=new A209326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209327
{
public static readonly BigInteger[] Value={ 1L,7L,70L,863L,13056L,231187L,4737986L,109531991L,2835638008L,80950287311L,2533758258912L,86089196479255L,3161596017956936L,124590870125959343L,5251666647713483356L,BigInteger.Parse("235497961945975068767"),BigInteger.Parse("11205025852314462333408"),BigInteger.Parse("563351626162952600815087"),BigInteger.Parse("29864689571162209608920060"),BigInteger.Parse("1663796497123214306448307031") };
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
public class A209327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209327Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209327.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209327.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209327Inst Instance=new A209327Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209328
{
public static readonly long[] Value={ 1L,0L,7L,9L,8L,3L,9L,7L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209328Inst : IEnumerable<long>
{
public static readonly long[] Value=A209328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209328.Bytes);
public long this[int i]=>Value[i];

public static A209328Inst Instance=new A209328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209329
{
public static readonly long[] Value={ 1L,3L,4L,4L,2L,6L,5L,0L,9L,6L,9L,1L,7L,3L,3L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209329Inst : IEnumerable<long>
{
public static readonly long[] Value=A209329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209329.Bytes);
public long this[int i]=>Value[i];

public static A209329Inst Instance=new A209329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209330
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,84L,84L,1L,1L,1820L,12870L,1820L,1L,1L,53130L,3268760L,3268760L,53130L,1L,1L,1947792L,1251677700L,9075135300L,1251677700L,1947792L,1L,1L,85900584L,675248872536L,39049918716424L,39049918716424L,675248872536L,85900584L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209330Inst : IEnumerable<long>
{
public static readonly long[] Value=A209330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209330.Bytes);
public long this[int i]=>Value[i];

public static A209330Inst Instance=new A209330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209331
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,86L,1905L,66002L,5218373L,1340847046L,688750226335L,527838995308056L,707409447204872377L,BigInteger.Parse("2844096719471817175298"),BigInteger.Parse("30274246332924074325724393"),BigInteger.Parse("517646331335208169889265781259"),BigInteger.Parse("13363896516779950029547538703868509") };
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
public class A209331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209331Inst Instance=new A209331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209332
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,3L,5L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,0L,3L,1L,1L,1L,1L,2L,4L,0L,3L,2L,1L,0L,4L,1L,1L,1L,1L,1L,2L,1L,1L,0L,5L,0L,3L,2L,1L,0L,7L,2L,2L,1L,1L,2L,1L,0L,8L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,7L,1L,2L,1L,1L,3L,2L,1L,1L,0L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209332Inst : IEnumerable<long>
{
public static readonly long[] Value=A209332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209332.Bytes);
public long this[int i]=>Value[i];

public static A209332Inst Instance=new A209332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209333
{
public static readonly long[] Value={ 25L,33L,37L,47L,49L,53L,61L,73L,83L,85L,89L,97L,113L,115L,117L,131L,133L,139L,141L,145L,151L,153L,157L,167L,169L,173L,181L,193L,199L,201L,203L,205L,211L,213L,217L,229L,233L,257L,265L,271L,273L,277L,283L,287L,289L,293L,295L,297L,299L,301L,313L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209333Inst : IEnumerable<long>
{
public static readonly long[] Value=A209333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209333.Bytes);
public long this[int i]=>Value[i];

public static A209333Inst Instance=new A209333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209334
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,6L,4L,1L,3L,6L,10L,5L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209334Inst : IEnumerable<long>
{
public static readonly long[] Value=A209334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209334.Bytes);
public long this[int i]=>Value[i];

public static A209334Inst Instance=new A209334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209335
{
public static readonly long[] Value={ 1L,1L,3L,9L,31L,111L,415L,1591L,6229L,24773L,99793L,406197L,1667803L,6898183L,28710933L,120146889L,505161063L,2132805899L,9037954725L,38424844083L,163843435737L,700477124863L,3001906536983L,12892683275989L,55481600408439L,239188767723227L,1032889415516779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209335Inst : IEnumerable<long>
{
public static readonly long[] Value=A209335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209335.Bytes);
public long this[int i]=>Value[i];

public static A209335Inst Instance=new A209335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209336
{
public static readonly long[] Value={ 1L,3L,7L,72L,883L,16968L,409199L,12099880L,420661470L,16838275108L,762821788869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209336Inst : IEnumerable<long>
{
public static readonly long[] Value=A209336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209336.Bytes);
public long this[int i]=>Value[i];

public static A209336Inst Instance=new A209336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209337
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,14L,21L,51L,102L,249L,555L,1358L,3201L,7890L,19232L,47869L,118955L,298875L,752039L,1904621L,4835666L,12330144L,31521037L,80836979L,207803455L,535535393L,1383064966L,3579351724L,9280561947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209337Inst : IEnumerable<long>
{
public static readonly long[] Value=A209337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209337.Bytes);
public long this[int i]=>Value[i];

public static A209337Inst Instance=new A209337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209338
{
public static readonly long[] Value={ 1L,3L,4L,15L,40L,146L,514L,2032L,8076L,33310L,138966L,589618L,2525494L,10923868L,47599638L,208824200L,921391230L,4086463748L,18206487792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209338Inst : IEnumerable<long>
{
public static readonly long[] Value=A209338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209338.Bytes);
public long this[int i]=>Value[i];

public static A209338Inst Instance=new A209338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209339
{
public static readonly long[] Value={ 1L,4L,7L,35L,145L,770L,4029L,22739L,130282L,766177L,4566523L,27587850L,168340643L,1036444786L,6429150260L,40144480583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209339Inst : IEnumerable<long>
{
public static readonly long[] Value=A209339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209339.Bytes);
public long this[int i]=>Value[i];

public static A209339Inst Instance=new A209339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209340
{
public static readonly long[] Value={ 1L,5L,12L,72L,400L,2698L,18646L,136000L,1013342L,7713270L,59569974L,465894736L,3681136600L,29342106638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209340Inst : IEnumerable<long>
{
public static readonly long[] Value=A209340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209340.Bytes);
public long this[int i]=>Value[i];

public static A209340Inst Instance=new A209340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209341
{
public static readonly long[] Value={ 1L,6L,17L,128L,883L,7358L,62853L,563109L,5153746L,48127107L,456011561L,4374662802L,42398844001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209341Inst : IEnumerable<long>
{
public static readonly long[] Value=A209341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209341.Bytes);
public long this[int i]=>Value[i];

public static A209341Inst Instance=new A209341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209342
{
public static readonly long[] Value={ 1L,7L,24L,205L,1724L,16968L,172610L,1830872L,19860306L,219630346L,2464760150L,28002352120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209342Inst : IEnumerable<long>
{
public static readonly long[] Value=A209342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209342.Bytes);
public long this[int i]=>Value[i];

public static A209342Inst Instance=new A209342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209343
{
public static readonly long[] Value={ 1L,8L,31L,311L,3045L,34720L,409199L,5016681L,62896466L,803647811L,10420410009L,136780924152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209343Inst : IEnumerable<long>
{
public static readonly long[] Value=A209343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209343.Bytes);
public long this[int i]=>Value[i];

public static A209343Inst Instance=new A209343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209344
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,1L,4L,4L,4L,1L,5L,7L,15L,5L,1L,6L,12L,35L,40L,14L,1L,7L,17L,72L,145L,146L,21L,1L,8L,24L,128L,400L,770L,514L,51L,1L,9L,31L,205L,883L,2698L,4029L,2032L,102L,1L,10L,40L,311L,1724L,7358L,18646L,22739L,8076L,249L,1L,11L,49L,448L,3045L,16968L,62853L,136000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209344Inst : IEnumerable<long>
{
public static readonly long[] Value=A209344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209344.Bytes);
public long this[int i]=>Value[i];

public static A209344Inst Instance=new A209344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209345
{
public static readonly long[] Value={ 4L,15L,35L,72L,128L,205L,311L,448L,618L,829L,1083L,1382L,1734L,2141L,2605L,3134L,3730L,4395L,5137L,5958L,6860L,7851L,8933L,10108L,11384L,12763L,14247L,15844L,17556L,19385L,21339L,23420L,25630L,27977L,30463L,33090L,35866L,38793L,41873L,45114L,48518L,52087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209345Inst : IEnumerable<long>
{
public static readonly long[] Value=A209345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209345.Bytes);
public long this[int i]=>Value[i];

public static A209345Inst Instance=new A209345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209346
{
public static readonly long[] Value={ 5L,40L,145L,400L,883L,1724L,3045L,5026L,7827L,11684L,16795L,23446L,31879L,42430L,55379L,71118L,89965L,112362L,138671L,169384L,204901L,245770L,292429L,345476L,405393L,472828L,548301L,632516L,726031L,829600L,943825L,1069510L,1207295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209346Inst : IEnumerable<long>
{
public static readonly long[] Value=A209346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209346.Bytes);
public long this[int i]=>Value[i];

public static A209346Inst Instance=new A209346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209347
{
public static readonly long[] Value={ 14L,146L,770L,2698L,7358L,16968L,34720L,64942L,113288L,186906L,294616L,447084L,657006L,939270L,1311146L,1792454L,2405742L,3176460L,4133144L,5307578L,6734984L,8454190L,10507808L,12942408L,15808702L,19161706L,23060930L,27570546L,32759566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209347Inst : IEnumerable<long>
{
public static readonly long[] Value=A209347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209347.Bytes);
public long this[int i]=>Value[i];

public static A209347Inst Instance=new A209347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209348
{
public static readonly long[] Value={ 21L,514L,4029L,18646L,62853L,172610L,409199L,870122L,1699831L,3104474L,5365417L,8858142L,14068115L,21614144L,32266607L,46975088L,66888951L,93389664L,128113109L,172986976L,230254897L,302518564L,392763779L,504407780L,641326401L,807907094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209348Inst : IEnumerable<long>
{
public static readonly long[] Value=A209348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209348.Bytes);
public long this[int i]=>Value[i];

public static A209348Inst Instance=new A209348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209349
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,5L,1L,0L,1L,1L,1L,9L,29L,1L,0L,1L,1L,1L,11L,100L,182L,1L,0L,1L,1L,1L,16L,182L,1225L,1198L,1L,0L,1L,1L,1L,19L,484L,3542L,15876L,8142L,1L,0L,1L,1L,1L,25L,902L,17956L,76258L,213444L,56620L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209349Inst : IEnumerable<long>
{
public static readonly long[] Value=A209349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209349.Bytes);
public long this[int i]=>Value[i];

public static A209349Inst Instance=new A209349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209350
{
public static readonly long[] Value={ 1L,0L,1L,5L,9L,11L,16L,19L,25L,29L,36L,41L,49L,55L,64L,71L,81L,89L,100L,109L,121L,131L,144L,155L,169L,181L,196L,209L,225L,239L,256L,271L,289L,305L,324L,341L,361L,379L,400L,419L,441L,461L,484L,505L,529L,551L,576L,599L,625L,649L,676L,701L,729L,755L,784L,811L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209350Inst : IEnumerable<long>
{
public static readonly long[] Value=A209350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209350.Bytes);
public long this[int i]=>Value[i];

public static A209350Inst Instance=new A209350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209351
{
public static readonly BigInteger[] Value={ 1L,1L,11L,182L,3542L,76258L,1753522L,42269392L,1055518634L,27091380674L,710781384782L,18986685114964L,514838929566304L,14138508923416768L,392518929926801888L,11000540560168582016UL,BigInteger.Parse("310851652685562860378"),BigInteger.Parse("8848249504532000817058"),BigInteger.Parse("253498769515046174725606") };
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
public class A209351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209351Inst Instance=new A209351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209352
{
public static readonly BigInteger[] Value={ 1L,1L,16L,484L,17956L,749956L,33779344L,1603842304L,79171327876L,4026836863204L,209730177700096L,11135960392243600L,600800844868633600L,BigInteger.Parse("32853035097265158400"),BigInteger.Parse("1817225079550242841600"),BigInteger.Parse("101519847275313821814784"),BigInteger.Parse("5720749624907993103318916"),BigInteger.Parse("324836041052683988251601956") };
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
public class A209352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209352Inst Instance=new A209352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209353
{
public static readonly BigInteger[] Value={ 1L,1L,19L,902L,53636L,3771698L,292587922L,24422343208L,2150227555324L,197404215493922L,18735386882618558L,1827242795963079380L,BigInteger.Parse("182291530666463403220"),BigInteger.Parse("18537924237935355619360") };
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
public class A209353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209353Inst Instance=new A209353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209354
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,1L,3L,1L,1L,0L,1L,3L,2L,3L,1L,1L,0L,1L,1L,5L,3L,3L,1L,1L,0L,1L,3L,4L,6L,3L,3L,1L,1L,0L,1L,2L,6L,6L,7L,3L,3L,1L,1L,0L,1L,3L,6L,10L,7L,7L,3L,3L,1L,1L,0L,1L,1L,9L,10L,12L,8L,7L,3L,3L,1L,1L,0L,1L,5L,6L,15L,14L,13L,8L,7L,3L,3L,1L,1L,0L,1L,1L,11L,15L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209354Inst : IEnumerable<long>
{
public static readonly long[] Value=A209354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209354.Bytes);
public long this[int i]=>Value[i];

public static A209354Inst Instance=new A209354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209355
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209355Inst : IEnumerable<long>
{
public static readonly long[] Value=A209355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209355.Bytes);
public long this[int i]=>Value[i];

public static A209355Inst Instance=new A209355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209356
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209356Inst : IEnumerable<long>
{
public static readonly long[] Value=A209356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209356.Bytes);
public long this[int i]=>Value[i];

public static A209356Inst Instance=new A209356Inst();

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