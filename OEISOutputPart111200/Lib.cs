using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189339
{
public static readonly ulong[] Value={ 28L,784L,21952L,390721L,6814820L,109746642L,1857004061L,31177656076L,533269057178L,9053472938552L,154252966185542L,2618674812680579L,44520074517291894L,756141322418868556L,12851400623635035810UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189339Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189339.Bytes);
public ulong this[int i]=>Value[i];

public static A189339Inst Instance=new A189339Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189372
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,14L,16L,18L,20L,21L,24L,26L,28L,30L,33L,34L,37L,39L,40L,43L,44L,47L,49L,51L,53L,56L,57L,59L,61L,63L,66L,67L,70L,72L,74L,76L,78L,80L,82L,84L,86L,89L,90L,93L,95L,97L,99L,100L,103L,105L,107L,109L,112L,113L,116L,118L,119L,122L,123L,126L,128L,130L,132L,135L,136L,138L,141L,142L,145L,146L,149L,151L,153L,155L,157L,159L,161L,163L,165L,168L,169L,172L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189372Inst : IEnumerable<long>
{
public static readonly long[] Value=A189372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189372.Bytes);
public long this[int i]=>Value[i];

public static A189372Inst Instance=new A189372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189373
{
public static readonly long[] Value={ 6L,28L,33550336L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189373Inst : IEnumerable<long>
{
public static readonly long[] Value=A189373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189373.Bytes);
public long this[int i]=>Value[i];

public static A189373Inst Instance=new A189373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189374
{
public static readonly long[] Value={ 1L,2L,3L,7L,11L,15L,25L,35L,45L,65L,85L,105L,140L,175L,210L,266L,322L,378L,462L,546L,630L,750L,870L,990L,1155L,1320L,1485L,1705L,1925L,2145L,2431L,2717L,3003L,3367L,3731L,4095L,4550L,5005L,5460L,6020L,6580L,7140L,7820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189374Inst : IEnumerable<long>
{
public static readonly long[] Value=A189374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189374.Bytes);
public long this[int i]=>Value[i];

public static A189374Inst Instance=new A189374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189375
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,12L,16L,20L,30L,40L,50L,60L,80L,100L,120L,140L,175L,210L,245L,280L,336L,392L,448L,504L,588L,672L,756L,840L,960L,1080L,1200L,1320L,1485L,1650L,1815L,1980L,2200L,2420L,2640L,2860L,3146L,3432L,3718L,4004L,4368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189375Inst : IEnumerable<long>
{
public static readonly long[] Value=A189375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189375.Bytes);
public long this[int i]=>Value[i];

public static A189375Inst Instance=new A189375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189376
{
public static readonly long[] Value={ 1L,3L,6L,10L,17L,27L,40L,56L,78L,106L,140L,180L,230L,290L,360L,440L,535L,645L,770L,910L,1071L,1253L,1456L,1680L,1932L,2212L,2520L,2856L,3228L,3636L,4080L,4560L,5085L,5655L,6270L,6930L,7645L,8415L,9240L,10120L,11066L,12078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189376Inst : IEnumerable<long>
{
public static readonly long[] Value=A189376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189376.Bytes);
public long this[int i]=>Value[i];

public static A189376Inst Instance=new A189376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189377
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,11L,14L,16L,18L,21L,22L,24L,27L,29L,31L,32L,35L,37L,39L,42L,43L,45L,48L,50L,52L,55L,56L,58L,60L,63L,65L,66L,69L,71L,73L,76L,77L,79L,82L,84L,86L,87L,90L,92L,94L,97L,99L,100L,103L,105L,107L,110L,111L,113L,115L,118L,120L,121L,124L,126L,128L,131L,132L,134L,137L,139L,141L,144L,145L,147L,149L,152L,154L,155L,158L,160L,162L,165L,166L,168L,171L,173L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189377Inst : IEnumerable<long>
{
public static readonly long[] Value=A189377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189377.Bytes);
public long this[int i]=>Value[i];

public static A189377Inst Instance=new A189377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189378
{
public static readonly long[] Value={ 6L,13L,19L,26L,34L,40L,47L,53L,61L,68L,74L,81L,89L,95L,102L,108L,116L,123L,129L,136L,142L,150L,157L,163L,170L,178L,184L,191L,197L,205L,212L,218L,225L,233L,239L,246L,252L,259L,267L,273L,280L,286L,294L,301L,307L,314L,322L,328L,335L,341L,349L,356L,362L,369L,375L,383L,390L,396L,403L,411L,417L,424L,430L,438L,445L,451L,458L,466L,472L,479L,485L,492L,500L,506L,513L,519L,527L,534L,540L,547L,555L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189378Inst : IEnumerable<long>
{
public static readonly long[] Value=A189378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189378.Bytes);
public long this[int i]=>Value[i];

public static A189378Inst Instance=new A189378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189379
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,15L,17L,20L,23L,25L,28L,30L,33L,36L,38L,41L,44L,46L,49L,51L,54L,57L,59L,62L,64L,67L,70L,72L,75L,78L,80L,83L,85L,88L,91L,93L,96L,98L,101L,104L,106L,109L,112L,114L,117L,119L,122L,125L,127L,130L,133L,135L,138L,140L,143L,146L,148L,151L,153L,156L,159L,161L,164L,167L,169L,172L,174L,177L,180L,182L,185L,187L,190L,193L,195L,198L,201L,203L,206L,208L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189379Inst : IEnumerable<long>
{
public static readonly long[] Value=A189379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189379.Bytes);
public long this[int i]=>Value[i];

public static A189379Inst Instance=new A189379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189380
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,22L,25L,30L,33L,38L,41L,44L,49L,52L,57L,60L,65L,68L,71L,76L,79L,84L,87L,90L,95L,98L,103L,106L,111L,114L,117L,122L,125L,130L,133L,136L,141L,144L,149L,152L,155L,160L,163L,168L,171L,176L,179L,182L,187L,190L,195L,198L,201L,206L,209L,214L,217L,222L,225L,228L,233L,236L,241L,244L,247L,252L,255L,260L,263L,266L,271L,274L,279L,282L,287L,290L,293L,298L,301L,306L,309L,312L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189380Inst : IEnumerable<long>
{
public static readonly long[] Value=A189380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189380.Bytes);
public long this[int i]=>Value[i];

public static A189380Inst Instance=new A189380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189381
{
public static readonly long[] Value={ 8L,17L,27L,36L,46L,54L,63L,73L,82L,92L,101L,109L,119L,128L,138L,147L,157L,165L,174L,184L,193L,203L,212L,220L,230L,239L,249L,258L,268L,276L,285L,295L,304L,314L,322L,331L,341L,350L,360L,369L,377L,387L,396L,406L,415L,425L,433L,442L,452L,461L,471L,480L,488L,498L,507L,517L,526L,536L,544L,553L,563L,572L,582L,591L,599L,609L,618L,628L,637L,645L,655L,664L,674L,683L,693L,701L,710L,720L,729L,739L,748L,756L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189381Inst : IEnumerable<long>
{
public static readonly long[] Value=A189381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189381.Bytes);
public long this[int i]=>Value[i];

public static A189381Inst Instance=new A189381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189382
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,47L,48L,50L,51L,53L,55L,56L,58L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,93L,94L,96L,97L,99L,100L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,120L,121L,123L,124L,126L,127L,129L,131L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189382Inst : IEnumerable<long>
{
public static readonly long[] Value=A189382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189382.Bytes);
public long this[int i]=>Value[i];

public static A189382Inst Instance=new A189382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189383
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,13L,15L,17L,20L,22L,24L,26L,29L,31L,33L,36L,38L,40L,42L,45L,47L,49L,52L,53L,56L,59L,61L,63L,65L,68L,69L,72L,75L,77L,79L,81L,84L,85L,88L,91L,92L,95L,97L,100L,101L,104L,107L,108L,111L,113L,116L,118L,120L,123L,124L,127L,129L,132L,134L,136L,139L,140L,143L,145L,147L,150L,152L,155L,156L,159L,161L,163L,166L,168L,171L,172L,175L,178L,179L,182L,184L,186L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189383Inst : IEnumerable<long>
{
public static readonly long[] Value=A189383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189383.Bytes);
public long this[int i]=>Value[i];

public static A189383Inst Instance=new A189383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189384
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,18L,21L,25L,28L,32L,34L,37L,41L,44L,48L,51L,54L,57L,60L,64L,67L,70L,73L,76L,80L,83L,87L,89L,93L,96L,99L,103L,105L,109L,112L,115L,119L,122L,125L,128L,131L,135L,138L,141L,144L,148L,151L,154L,158L,160L,164L,167L,170L,174L,176L,180L,183L,187L,190L,192L,196L,199L,203L,206L,209L,212L,215L,219L,222L,225L,228L,231L,235L,238L,242L,245L,247L,251L,254L,258L,261L,263L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189384Inst : IEnumerable<long>
{
public static readonly long[] Value=A189384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189384.Bytes);
public long this[int i]=>Value[i];

public static A189384Inst Instance=new A189384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189385
{
public static readonly long[] Value={ 3L,7L,11L,14L,19L,23L,27L,30L,35L,39L,43L,46L,50L,55L,58L,62L,66L,71L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,117L,121L,126L,130L,133L,137L,142L,146L,149L,153L,157L,162L,165L,169L,173L,177L,181L,185L,189L,193L,197L,201L,205L,208L,213L,217L,220L,224L,229L,233L,236L,240L,244L,249L,252L,256L,260L,265L,268L,272L,276L,279L,284L,288L,292L,295L,300L,304L,308L,311L,315L,320L,324L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189385Inst : IEnumerable<long>
{
public static readonly long[] Value=A189385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189385.Bytes);
public long this[int i]=>Value[i];

public static A189385Inst Instance=new A189385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189386
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,29L,32L,34L,38L,41L,44L,47L,50L,53L,55L,59L,62L,65L,68L,70L,74L,77L,80L,83L,86L,89L,91L,95L,98L,101L,104L,106L,110L,112L,116L,119L,121L,125L,127L,131L,133L,137L,140L,142L,146L,148L,152L,155L,157L,161L,163L,167L,169L,173L,176L,178L,182L,184L,188L,190L,193L,197L,199L,203L,205L,208L,211L,214L,218L,220L,224L,226L,229L,233L,235L,239L,241L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189386Inst : IEnumerable<long>
{
public static readonly long[] Value=A189386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189386.Bytes);
public long this[int i]=>Value[i];

public static A189386Inst Instance=new A189386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189387
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,12L,13L,16L,18L,21L,22L,24L,27L,28L,31L,33L,35L,37L,39L,42L,43L,45L,48L,49L,52L,54L,57L,58L,60L,63L,64L,67L,69L,71L,73L,75L,78L,79L,81L,84L,85L,88L,90L,92L,94L,96L,99L,100L,103L,105L,107L,109L,111L,114L,115L,117L,120L,122L,124L,126L,128L,130L,132L,135L,136L,138L,141L,143L,145L,147L,149L,151L,153L,156L,158L,160L,162L,164L,166L,168L,171L,172L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189387Inst : IEnumerable<long>
{
public static readonly long[] Value=A189387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189387.Bytes);
public long this[int i]=>Value[i];

public static A189387Inst Instance=new A189387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189436
{
public static readonly long[] Value={ 1L,9L,31L,140L,571L,2413L,10069L,42205L,176624L,739573L,3096173L,12962845L,54270579L,227212636L,951259751L,3982596009L,16673747193L,69807202249L,292258553696L,1223585260409L,5122727328297L,21447083573633L,89791504401207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189436Inst : IEnumerable<long>
{
public static readonly long[] Value=A189436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189436.Bytes);
public long this[int i]=>Value[i];

public static A189436Inst Instance=new A189436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189437
{
public static readonly long[] Value={ 1L,20L,109L,841L,5680L,40065L,278105L,1940868L,13518605L,94223329L,656569824L,4575509121L,31884910129L,222195588532L,1548403370477L,10790295445561L,75193858910224L,524000231073025L,3651577819301001L,25446593414689700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189437Inst : IEnumerable<long>
{
public static readonly long[] Value=A189437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189437.Bytes);
public long this[int i]=>Value[i];

public static A189437Inst Instance=new A189437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189438
{
public static readonly long[] Value={ 1L,41L,367L,4653L,52241L,606201L,6944573L,79826592L,916320775L,10522129613L,120807652475L,1387081546065L,15925843986549L,182854110096077L,2099453348053203L,24105043866210197L,276763962980421232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189438Inst : IEnumerable<long>
{
public static readonly long[] Value=A189438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189438.Bytes);
public long this[int i]=>Value[i];

public static A189438Inst Instance=new A189438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189439
{
public static readonly BigInteger[] Value={ 1L,85L,1245L,26589L,493941L,9557077L,181540773L,3467525301L,66045131269L,1258981901653L,23988387057381L,457127606313333L,8710469146675973L,165979359956189589L,3162723963901817637L,BigInteger.Parse("60265641669988070325") };
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
public class A189439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189439Inst Instance=new A189439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189440
{
public static readonly BigInteger[] Value={ 1L,178L,4247L,151081L,4681376L,150278792L,4742833745L,150293731826L,4749894184013L,150188217692849L,4746661471100000L,150023910675120177L,4741289321059094672L,BigInteger.Parse("149841677173229096314"),BigInteger.Parse("4735456640427554680211") };
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
public class A189440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189440Inst Instance=new A189440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189441
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,41L,43L,59L,61L,71L,73L,101L,103L,109L,113L,131L,139L,151L,167L,181L,191L,193L,199L,211L,227L,229L,239L,241L,251L,263L,269L,271L,281L,283L,293L,311L,313L,331L,347L,349L,359L,383L,401L,419L,421L,431L,433L,439L,461L,463L,467L,479L,487L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189441Inst : IEnumerable<long>
{
public static readonly long[] Value=A189441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189441.Bytes);
public long this[int i]=>Value[i];

public static A189441Inst Instance=new A189441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189442
{
public static readonly long[] Value={ 1L,3L,1L,-3L,-5L,-7L,-1L,7L,9L,11L,1L,-11L,-13L,-15L,-1L,15L,17L,19L,1L,-19L,-21L,-23L,-1L,23L,25L,27L,1L,-27L,-29L,-31L,-1L,31L,33L,35L,1L,-35L,-37L,-39L,-1L,39L,41L,43L,1L,-43L,-45L,-47L,-1L,47L,49L,51L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189442Inst : IEnumerable<long>
{
public static readonly long[] Value=A189442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189442.Bytes);
public long this[int i]=>Value[i];

public static A189442Inst Instance=new A189442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189443
{
public static readonly BigInteger[] Value={ 1L,5L,80L,7300L,2735828L,4982424404L,40668908306516L,1544933702911323688L,BigInteger.Parse("268632319882770483171376"),BigInteger.Parse("215429706055786434110682479345"),BigInteger.Parse("794334848116480290212387125594468856") };
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
public class A189443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189443Inst Instance=new A189443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189444
{
public static readonly long[] Value={ 5L,61L,666L,7300L,80282L,883049L,9712873L,106834338L,1175098084L,12925203122L,142167601085L,1563737653381L,17199948722346L,189186616701220L,2080911781577162L,22888478678939969L,251756206521753553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189444Inst : IEnumerable<long>
{
public static readonly long[] Value=A189444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189444.Bytes);
public long this[int i]=>Value[i];

public static A189444Inst Instance=new A189444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189445
{
public static readonly BigInteger[] Value={ 8L,225L,5080L,118128L,2735828L,63367633L,1467726607L,33995627281L,787410049440L,18238068717816L,422431934648884L,9784409861152809L,226627459902104327L,5249167431711452449L,BigInteger.Parse("121581730378315708936"),BigInteger.Parse("2816087951868941718112") };
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
public class A189445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189445Inst Instance=new A189445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189446
{
public static readonly BigInteger[] Value={ 13L,841L,40106L,2008890L,100047288L,4982424404L,248187289625L,12362821462925L,615823316590381L,30675714678416140L,1528034812741010509L,BigInteger.Parse("76115272823689573050"),BigInteger.Parse("3791493955944999761482"),BigInteger.Parse("188863888740455537178552") };
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
public class A189446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189446Inst Instance=new A189446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189447
{
public static readonly BigInteger[] Value={ 21L,3136L,313136L,33735505L,3586575040L,381987110556L,40668908306516L,4329976369716644L,461007230769131204L,BigInteger.Parse("49082883213353553796"),BigInteger.Parse("5225795314666113134276"),BigInteger.Parse("556384119909347581932164") };
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
public class A189447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189447Inst Instance=new A189447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189448
{
public static readonly BigInteger[] Value={ 34L,11705L,2455013L,569476049L,129699382789L,29628810704689L,6765736745152657L,1544933702911323688L,BigInteger.Parse("352785827356726984192"),BigInteger.Parse("80558653487951364549221"),BigInteger.Parse("18395575161567635569195834"),BigInteger.Parse("4200631099715909550808300301") };
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
public class A189448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189448Inst Instance=new A189448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189449
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,5L,16L,13L,1L,8L,61L,80L,34L,1L,13L,225L,666L,400L,89L,1L,21L,841L,5080L,7300L,2000L,233L,1L,34L,3136L,40106L,118128L,80282L,10000L,610L,1L,55L,11705L,313136L,2008890L,2735828L,883049L,50000L,1597L,1L,89L,43681L,2455013L,33735505L,100047288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189449Inst : IEnumerable<long>
{
public static readonly long[] Value=A189449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189449.Bytes);
public long this[int i]=>Value[i];

public static A189449Inst Instance=new A189449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189450
{
public static readonly long[] Value={ 1L,5L,16L,61L,225L,841L,3136L,11705L,43681L,163021L,608400L,2270581L,8473921L,31625105L,118026496L,440480881L,1643897025L,6135107221L,22896531856L,85451020205L,318907548961L,1190179175641L,4441809153600L,16577057438761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189450Inst : IEnumerable<long>
{
public static readonly long[] Value=A189450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189450.Bytes);
public long this[int i]=>Value[i];

public static A189450Inst Instance=new A189450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189451
{
public static readonly long[] Value={ 1L,13L,80L,666L,5080L,40106L,313136L,2455013L,19221095L,150562121L,1179185280L,9235771513L,72336253737L,566554489205L,4437377818704L,34754532606346L,272205182385544L,2131971340412858L,16698071766102576L,130782997877002493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189451Inst : IEnumerable<long>
{
public static readonly long[] Value=A189451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189451.Bytes);
public long this[int i]=>Value[i];

public static A189451Inst Instance=new A189451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189468
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,16L,18L,22L,24L,27L,29L,33L,35L,38L,40L,44L,46L,49L,51L,55L,57L,60L,64L,66L,69L,71L,75L,77L,80L,82L,86L,88L,91L,93L,97L,99L,102L,104L,108L,110L,113L,115L,119L,121L,124L,128L,130L,133L,135L,139L,141L,144L,146L,150L,152L,155L,157L,161L,163L,166L,168L,172L,174L,177L,179L,183L,186L,188L,192L,194L,197L,199L,203L,205L,208L,210L,214L,216L,219L,221L,225L,227L,230L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189468Inst : IEnumerable<long>
{
public static readonly long[] Value=A189468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189468.Bytes);
public long this[int i]=>Value[i];

public static A189468Inst Instance=new A189468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189469
{
public static readonly long[] Value={ 5L,11L,18L,23L,30L,36L,42L,48L,54L,61L,67L,72L,79L,85L,91L,97L,104L,110L,115L,122L,128L,135L,140L,146L,153L,159L,165L,171L,178L,183L,189L,196L,202L,208L,214L,220L,227L,232L,239L,245L,251L,257L,263L,270L,275L,282L,288L,294L,300L,306L,313L,319L,324L,331L,337L,343L,349L,356L,362L,367L,374L,380L,387L,392L,398L,405L,411L,417L,423L,429L,435L,441L,448L,454L,460L,466L,472L,479L,484L,491L,497L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189469Inst : IEnumerable<long>
{
public static readonly long[] Value=A189469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189469.Bytes);
public long this[int i]=>Value[i];

public static A189469Inst Instance=new A189469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189470
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,14L,16L,20L,22L,25L,27L,29L,32L,34L,37L,40L,43L,45L,47L,50L,52L,55L,58L,60L,63L,65L,68L,70L,73L,75L,78L,81L,83L,86L,88L,90L,93L,96L,99L,101L,103L,106L,108L,111L,113L,117L,119L,121L,124L,126L,129L,131L,133L,137L,139L,142L,144L,147L,149L,151L,155L,157L,160L,162L,164L,167L,169L,172L,175L,177L,180L,182L,185L,187L,190L,193L,195L,198L,200L,203L,205L,207L,210L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189470Inst : IEnumerable<long>
{
public static readonly long[] Value=A189470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189470.Bytes);
public long this[int i]=>Value[i];

public static A189470Inst Instance=new A189470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189471
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,13L,15L,17L,19L,21L,24L,26L,28L,31L,33L,35L,38L,39L,41L,44L,46L,49L,51L,53L,56L,57L,59L,62L,64L,66L,69L,71L,74L,76L,77L,80L,82L,84L,87L,89L,92L,94L,95L,98L,100L,102L,105L,107L,109L,112L,114L,116L,118L,120L,123L,125L,127L,130L,132L,134L,136L,138L,141L,143L,145L,148L,150L,152L,154L,156L,158L,161L,163L,166L,168L,170L,173L,174L,176L,179L,181L,184L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189471Inst : IEnumerable<long>
{
public static readonly long[] Value=A189471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189471.Bytes);
public long this[int i]=>Value[i];

public static A189471Inst Instance=new A189471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189472
{
public static readonly long[] Value={ 2L,5L,9L,11L,14L,18L,21L,23L,27L,30L,33L,36L,39L,43L,46L,48L,52L,55L,57L,61L,64L,67L,70L,73L,76L,80L,82L,86L,89L,92L,95L,98L,101L,105L,107L,110L,114L,116L,120L,123L,126L,129L,132L,135L,139L,141L,144L,148L,151L,153L,157L,160L,163L,166L,169L,173L,175L,178L,182L,185L,187L,191L,194L,197L,200L,203L,207L,210L,212L,216L,219L,221L,225L,228L,231L,234L,237L,241L,244L,246L,250L,253L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189472Inst : IEnumerable<long>
{
public static readonly long[] Value=A189472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189472.Bytes);
public long this[int i]=>Value[i];

public static A189472Inst Instance=new A189472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189473
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,13L,15L,17L,19L,22L,24L,26L,29L,31L,34L,35L,38L,40L,42L,44L,47L,49L,51L,53L,56L,59L,60L,63L,65L,68L,69L,72L,74L,77L,78L,81L,84L,85L,88L,90L,93L,94L,97L,99L,102L,103L,106L,108L,111L,113L,115L,118L,119L,122L,124L,127L,128L,131L,133L,136L,138L,140L,143L,145L,147L,149L,152L,154L,156L,158L,161L,162L,165L,168L,170L,172L,174L,177L,179L,181L,183L,186L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189473Inst : IEnumerable<long>
{
public static readonly long[] Value=A189473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189473.Bytes);
public long this[int i]=>Value[i];

public static A189473Inst Instance=new A189473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189474
{
public static readonly long[] Value={ 3L,7L,12L,16L,20L,25L,28L,32L,37L,41L,45L,50L,54L,58L,62L,66L,71L,75L,79L,83L,87L,91L,96L,100L,104L,109L,112L,117L,121L,125L,130L,134L,137L,142L,146L,150L,155L,159L,164L,167L,171L,176L,180L,184L,189L,192L,196L,201L,205L,209L,214L,218L,222L,226L,230L,235L,239L,243L,247L,251L,255L,260L,264L,268L,273L,276L,281L,285L,289L,294L,298L,302L,306L,310L,314L,319L,323L,328L,331L,335L,340L,344L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189474Inst : IEnumerable<long>
{
public static readonly long[] Value=A189474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189474.Bytes);
public long this[int i]=>Value[i];

public static A189474Inst Instance=new A189474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189475
{
public static readonly long[] Value={ 1L,3L,21L,171L,1485L,435L,16653L,149331L,1342341L,12076155L,990528L,1279200L,263901L,169071L,446985L,133865703L,1180416L,1214185281L,2366400L,25045503L,247275441L,8923200L,19634511L,56525028L,229847520L,739374285L,224497455L,81939201L,24010841091L,1106357280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189475Inst : IEnumerable<long>
{
public static readonly long[] Value=A189475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189475.Bytes);
public long this[int i]=>Value[i];

public static A189475Inst Instance=new A189475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189476
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189476Inst : IEnumerable<long>
{
public static readonly long[] Value=A189476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189476.Bytes);
public long this[int i]=>Value[i];

public static A189476Inst Instance=new A189476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189477
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,9L,11L,14L,15L,16L,18L,20L,23L,24L,25L,28L,29L,31L,32L,33L,35L,37L,40L,41L,42L,45L,46L,47L,50L,51L,53L,54L,55L,57L,59L,62L,63L,65L,66L,67L,69L,72L,73L,74L,76L,78L,81L,82L,83L,86L,87L,88L,91L,92L,94L,95L,96L,98L,100L,103L,104L,106L,107L,108L,110L,112L,115L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189477Inst : IEnumerable<long>
{
public static readonly long[] Value=A189477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189477.Bytes);
public long this[int i]=>Value[i];

public static A189477Inst Instance=new A189477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189478
{
public static readonly long[] Value={ 2L,3L,6L,10L,12L,13L,17L,19L,21L,22L,26L,27L,30L,34L,36L,38L,39L,43L,44L,48L,49L,52L,56L,58L,60L,61L,64L,68L,70L,71L,75L,77L,79L,80L,84L,85L,89L,90L,93L,97L,99L,101L,102L,105L,109L,111L,113L,114L,117L,121L,123L,124L,128L,130L,132L,133L,137L,138L,142L,143L,146L,150L,152L,153L,157L,159L,161L,162L,166L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189478Inst : IEnumerable<long>
{
public static readonly long[] Value=A189478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189478.Bytes);
public long this[int i]=>Value[i];

public static A189478Inst Instance=new A189478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189479
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189479Inst : IEnumerable<long>
{
public static readonly long[] Value=A189479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189479.Bytes);
public long this[int i]=>Value[i];

public static A189479Inst Instance=new A189479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189480
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,2L,3L,0L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189480Inst : IEnumerable<long>
{
public static readonly long[] Value=A189480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189480.Bytes);
public long this[int i]=>Value[i];

public static A189480Inst Instance=new A189480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189481
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,13L,15L,19L,25L,27L,33L,41L,43L,49L,51L,59L,63L,69L,73L,77L,85L,95L,99L,105L,109L,113L,115L,121L,133L,135L,139L,141L,143L,153L,155L,159L,161L,169L,171L,175L,181L,187L,193L,201L,203L,225L,227L,229L,235L,239L,249L,251L,253L,259L,265L,267L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189481Inst : IEnumerable<long>
{
public static readonly long[] Value=A189481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189481.Bytes);
public long this[int i]=>Value[i];

public static A189481Inst Instance=new A189481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189482
{
public static readonly long[] Value={ 4L,6L,9L,10L,15L,14L,22L,26L,34L,46L,27L,62L,42L,82L,94L,63L,70L,122L,134L,142L,98L,166L,175L,194L,206L,214L,154L,226L,138L,262L,275L,274L,278L,190L,302L,325L,314L,186L,334L,230L,346L,358L,363L,382L,398L,539L,446L,310L,454L,466L,595L,198L,483L,502L,514L,526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189482Inst : IEnumerable<long>
{
public static readonly long[] Value=A189482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189482.Bytes);
public long this[int i]=>Value[i];

public static A189482Inst Instance=new A189482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189483
{
public static readonly long[] Value={ 2L,3L,11L,17L,23L,29L,37L,47L,53L,67L,79L,83L,89L,97L,107L,127L,137L,149L,157L,163L,173L,179L,197L,223L,233L,257L,277L,307L,317L,337L,353L,367L,373L,379L,389L,397L,409L,443L,449L,457L,499L,509L,547L,569L,577L,593L,613L,659L,673L,677L,683L,709L,733L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189483Inst : IEnumerable<long>
{
public static readonly long[] Value=A189483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189483.Bytes);
public long this[int i]=>Value[i];

public static A189483Inst Instance=new A189483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189516
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,13L,16L,17L,20L,22L,23L,26L,27L,30L,32L,33L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,61L,62L,64L,67L,68L,71L,72L,74L,77L,78L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,106L,107L,109L,112L,113L,116L,117L,119L,122L,123L,126L,128L,129L,132L,134L,136L,138L,139L,142L,144L,146L,148L,150L,152L,154L,157L,158L,161L,162L,164L,167L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189516Inst : IEnumerable<long>
{
public static readonly long[] Value=A189516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189516.Bytes);
public long this[int i]=>Value[i];

public static A189516Inst Instance=new A189516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189517
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,29L,34L,39L,45L,49L,55L,59L,65L,69L,75L,80L,84L,90L,94L,100L,104L,110L,115L,120L,125L,130L,135L,140L,145L,151L,155L,160L,165L,170L,175L,180L,186L,190L,196L,200L,206L,210L,216L,221L,226L,231L,235L,241L,245L,251L,256L,261L,266L,271L,276L,281L,286L,292L,296L,302L,306L,311L,316L,321L,327L,331L,337L,341L,347L,351L,357L,362L,367L,372L,377L,382L,386L,392L,397L,402L,407L,412L,417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189517Inst : IEnumerable<long>
{
public static readonly long[] Value=A189517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189517.Bytes);
public long this[int i]=>Value[i];

public static A189517Inst Instance=new A189517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189518
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,41L,43L,45L,46L,49L,50L,51L,53L,55L,56L,58L,59L,61L,63L,64L,67L,68L,69L,71L,73L,74L,76L,77L,80L,81L,82L,84L,86L,87L,89L,91L,92L,94L,95L,98L,99L,100L,102L,104L,105L,107L,109L,111L,112L,113L,116L,117L,118L,120L,122L,123L,125L,126L,129L,130L,131L,134L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189518Inst : IEnumerable<long>
{
public static readonly long[] Value=A189518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189518.Bytes);
public long this[int i]=>Value[i];

public static A189518Inst Instance=new A189518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189519
{
public static readonly long[] Value={ 3L,8L,13L,16L,21L,26L,31L,34L,39L,44L,48L,52L,57L,62L,65L,70L,75L,79L,83L,88L,93L,97L,101L,106L,110L,115L,119L,124L,128L,132L,137L,141L,146L,150L,155L,159L,164L,168L,173L,177L,181L,186L,190L,195L,199L,204L,208L,213L,217L,221L,226L,231L,235L,239L,244L,248L,252L,257L,262L,266L,270L,275L,280L,283L,288L,293L,297L,301L,306L,311L,314L,319L,324L,329L,332L,337L,342L,347L,350L,355L,360L,363L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189519Inst : IEnumerable<long>
{
public static readonly long[] Value=A189519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189519.Bytes);
public long this[int i]=>Value[i];

public static A189519Inst Instance=new A189519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189520
{
public static readonly long[] Value={ 5L,11L,18L,23L,29L,36L,42L,47L,54L,60L,66L,72L,78L,85L,90L,96L,103L,108L,114L,121L,127L,133L,139L,145L,151L,157L,163L,170L,175L,182L,188L,193L,200L,206L,212L,218L,224L,230L,237L,242L,249L,255L,260L,267L,273L,279L,285L,291L,298L,303L,309L,316L,322L,327L,334L,340L,345L,352L,358L,365L,370L,376L,383L,388L,394L,401L,407L,413L,419L,425L,431L,437L,443L,450L,455L,461L,468L,474L,480L,486L,492L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189520Inst : IEnumerable<long>
{
public static readonly long[] Value=A189520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189520.Bytes);
public long this[int i]=>Value[i];

public static A189520Inst Instance=new A189520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189521
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,14L,16L,17L,19L,21L,23L,25L,27L,29L,30L,32L,35L,36L,38L,39L,42L,43L,45L,47L,49L,51L,52L,55L,57L,58L,60L,62L,64L,65L,67L,70L,71L,73L,75L,77L,79L,80L,83L,84L,86L,87L,90L,92L,93L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,115L,118L,119L,121L,123L,125L,127L,128L,131L,132L,134L,136L,138L,140L,141L,143L,145L,147L,149L,151L,153L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189521Inst : IEnumerable<long>
{
public static readonly long[] Value=A189521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189521.Bytes);
public long this[int i]=>Value[i];

public static A189521Inst Instance=new A189521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189522
{
public static readonly long[] Value={ 2L,5L,9L,11L,15L,18L,22L,24L,28L,31L,34L,37L,41L,44L,46L,50L,53L,56L,59L,63L,66L,69L,72L,76L,78L,82L,85L,88L,91L,94L,98L,100L,104L,107L,111L,113L,117L,120L,124L,126L,129L,133L,135L,139L,142L,146L,148L,152L,155L,158L,161L,165L,168L,170L,174L,177L,180L,183L,187L,190L,193L,196L,200L,202L,206L,209L,212L,215L,218L,222L,224L,228L,231L,235L,237L,241L,244L,248L,250L,253L,257L,259L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189522Inst : IEnumerable<long>
{
public static readonly long[] Value=A189522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189522.Bytes);
public long this[int i]=>Value[i];

public static A189522Inst Instance=new A189522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189523
{
public static readonly long[] Value={ 6L,13L,20L,26L,33L,40L,48L,54L,61L,68L,74L,81L,89L,96L,102L,109L,116L,122L,130L,137L,144L,150L,157L,164L,171L,178L,185L,192L,198L,205L,213L,219L,226L,233L,240L,246L,254L,261L,268L,274L,281L,288L,295L,302L,309L,316L,322L,329L,337L,343L,350L,357L,364L,370L,378L,385L,391L,398L,405L,412L,419L,426L,433L,439L,446L,453L,460L,467L,474L,481L,487L,494L,501L,509L,515L,522L,529L,536L,542L,550L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189523Inst : IEnumerable<long>
{
public static readonly long[] Value=A189523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189523.Bytes);
public long this[int i]=>Value[i];

public static A189523Inst Instance=new A189523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189524
{
public static readonly long[] Value={ 3L,6L,10L,13L,17L,21L,24L,27L,31L,35L,39L,42L,45L,49L,53L,56L,60L,63L,66L,71L,74L,78L,81L,84L,89L,92L,95L,99L,103L,106L,110L,113L,117L,121L,124L,128L,131L,134L,139L,142L,146L,149L,152L,157L,160L,163L,167L,170L,174L,178L,181L,185L,188L,192L,196L,199L,202L,207L,210L,213L,217L,220L,225L,228L,231L,235L,238L,242L,246L,249L,252L,256L,260L,264L,267L,270L,274L,278L,281L,285L,288L,292L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189524Inst : IEnumerable<long>
{
public static readonly long[] Value=A189524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189524.Bytes);
public long this[int i]=>Value[i];

public static A189524Inst Instance=new A189524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189525
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,16L,19L,23L,26L,29L,32L,34L,37L,40L,43L,47L,50L,52L,55L,58L,61L,64L,68L,70L,73L,76L,79L,82L,85L,87L,91L,94L,97L,100L,102L,105L,108L,112L,115L,118L,120L,123L,126L,129L,132L,136L,138L,141L,144L,147L,150L,153L,155L,159L,162L,165L,168L,171L,173L,176L,180L,183L,186L,189L,191L,194L,197L,200L,204L,206L,209L,212L,215L,218L,221L,224L,227L,230L,233L,236L,239L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189525Inst : IEnumerable<long>
{
public static readonly long[] Value=A189525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189525.Bytes);
public long this[int i]=>Value[i];

public static A189525Inst Instance=new A189525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189526
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,15L,18L,20L,22L,25L,28L,30L,33L,36L,38L,41L,44L,46L,48L,51L,54L,57L,59L,62L,65L,67L,69L,72L,75L,77L,80L,83L,86L,88L,90L,93L,96L,98L,101L,104L,107L,109L,111L,114L,116L,119L,122L,125L,127L,130L,133L,135L,137L,140L,143L,145L,148L,151L,154L,156L,158L,161L,164L,166L,169L,172L,175L,177L,179L,182L,184L,187L,190L,193L,195L,198L,201L,203L,205L,208L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189526Inst : IEnumerable<long>
{
public static readonly long[] Value=A189526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189526.Bytes);
public long this[int i]=>Value[i];

public static A189526Inst Instance=new A189526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189527
{
public static readonly long[] Value={ 4L,8L,12L,17L,21L,25L,31L,35L,39L,44L,48L,52L,57L,62L,66L,71L,75L,79L,84L,88L,93L,97L,102L,106L,110L,115L,119L,124L,129L,133L,137L,142L,146L,150L,156L,160L,164L,169L,173L,177L,182L,187L,191L,195L,200L,204L,208L,214L,218L,222L,227L,231L,235L,240L,245L,249L,254L,258L,262L,267L,271L,276L,281L,285L,289L,293L,298L,302L,307L,312L,316L,320L,325L,329L,333L,339L,343L,347L,352L,356L,360L,365L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189527Inst : IEnumerable<long>
{
public static readonly long[] Value=A189527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189527.Bytes);
public long this[int i]=>Value[i];

public static A189527Inst Instance=new A189527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189528
{
public static readonly long[] Value={ 13L,27L,41L,55L,69L,83L,98L,112L,126L,139L,153L,167L,181L,196L,210L,224L,238L,252L,266L,279L,294L,308L,322L,336L,350L,364L,378L,393L,407L,420L,434L,448L,462L,476L,491L,505L,519L,533L,547L,560L,574L,589L,603L,617L,631L,645L,659L,674L,688L,701L,715L,729L,743L,757L,772L,786L,800L,814L,828L,841L,855L,870L,884L,898L,912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189528Inst : IEnumerable<long>
{
public static readonly long[] Value=A189528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189528.Bytes);
public long this[int i]=>Value[i];

public static A189528Inst Instance=new A189528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189529
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,28L,29L,30L,32L,33L,34L,36L,37L,38L,40L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,56L,58L,59L,60L,61L,63L,64L,65L,67L,68L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,85L,86L,87L,89L,90L,91L,92L,94L,95L,96L,99L,100L,101L,103L,104L,105L,107L,108L,109L,111L,113L,114L,116L,117L,118L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189529Inst : IEnumerable<long>
{
public static readonly long[] Value=A189529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189529.Bytes);
public long this[int i]=>Value[i];

public static A189529Inst Instance=new A189529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189530
{
public static readonly long[] Value={ 3L,7L,10L,15L,18L,22L,26L,30L,34L,37L,41L,46L,49L,53L,56L,61L,64L,68L,72L,76L,80L,83L,87L,92L,95L,99L,103L,107L,111L,114L,119L,122L,126L,129L,134L,138L,141L,145L,149L,153L,157L,160L,165L,168L,172L,176L,180L,184L,187L,191L,195L,199L,203L,207L,211L,214L,218L,223L,226L,230L,233L,238L,242L,245L,249L,253L,257L,260L,264L,269L,272L,276L,279L,284L,288L,291L,296L,299L,303L,306L,311L,315L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189530Inst : IEnumerable<long>
{
public static readonly long[] Value=A189530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189530.Bytes);
public long this[int i]=>Value[i];

public static A189530Inst Instance=new A189530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189531
{
public static readonly long[] Value={ 2L,5L,8L,12L,14L,17L,20L,24L,27L,29L,32L,36L,39L,42L,44L,48L,51L,54L,57L,60L,63L,66L,69L,73L,75L,78L,82L,85L,88L,90L,94L,97L,100L,102L,106L,109L,112L,115L,118L,121L,124L,127L,131L,133L,136L,139L,143L,146L,148L,151L,155L,158L,161L,164L,167L,170L,173L,177L,179L,182L,185L,189L,192L,194L,197L,201L,204L,206L,209L,213L,216L,219L,221L,225L,228L,231L,235L,237L,240L,243L,247L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189531Inst : IEnumerable<long>
{
public static readonly long[] Value=A189531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189531.Bytes);
public long this[int i]=>Value[i];

public static A189531Inst Instance=new A189531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189596
{
public static readonly long[] Value={ 1L,1L,1L,4L,10L,22L,63L,168L,398L,864L,1998L,4814L,11515L,27219L,64834L,155776L,370324L,875660L,2075443L,4937760L,11743610L,27890804L,66275841L,157582669L,374562749L,889810081L,2114058291L,5024124329L,11940009567L,28372771969L,67421703499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189596Inst : IEnumerable<long>
{
public static readonly long[] Value=A189596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189596.Bytes);
public long this[int i]=>Value[i];

public static A189596Inst Instance=new A189596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189597
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,35L,111L,293L,718L,1741L,4273L,10855L,27633L,71187L,182287L,465019L,1180545L,2992281L,7598016L,19309456L,49129136L,125000325L,318018255L,808823885L,2056605339L,5229131690L,13296028742L,33810904043L,85982027049L,218658167715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189597Inst : IEnumerable<long>
{
public static readonly long[] Value=A189597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189597.Bytes);
public long this[int i]=>Value[i];

public static A189597Inst Instance=new A189597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189598
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,35L,126L,368L,920L,2285L,5896L,15456L,41206L,111892L,304175L,816621L,2172175L,5772781L,15372397L,41000988L,109503212L,292725922L,782460503L,2090016819L,5579586307L,14894046299L,39762451293L,106166731292L,283495287002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189598Inst : IEnumerable<long>
{
public static readonly long[] Value=A189598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189598.Bytes);
public long this[int i]=>Value[i];

public static A189598Inst Instance=new A189598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189599
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,35L,144L,425L,1035L,2436L,6140L,16922L,49176L,144117L,410571L,1135249L,3089181L,8424096L,23191590L,64417192L,179639575L,500440977L,1389439997L,3846685210L,10639680698L,29446636078L,81589820105L,226250592841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189599Inst : IEnumerable<long>
{
public static readonly long[] Value=A189599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189599.Bytes);
public long this[int i]=>Value[i];

public static A189599Inst Instance=new A189599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189600
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,21L,37L,64L,111L,194L,339L,591L,1030L,1796L,3132L,5461L,9522L,16604L,28953L,50485L,88030L,153498L,267655L,466710L,813802L,1419027L,2474358L,4314538L,7523260L,13118310L,22874400L,39886095L,69549390L,121273283L,211464244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189600Inst : IEnumerable<long>
{
public static readonly long[] Value=A189600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189600.Bytes);
public long this[int i]=>Value[i];

public static A189600Inst Instance=new A189600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189601
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,51L,117L,250L,524L,1123L,2428L,5274L,11493L,24927L,54025L,117003L,253155L,548139L,1187354L,2572374L,5573514L,12074638L,26156163L,56658896L,122731402L,265858041L,575909407L,1247556710L,2702508126L,5854265152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189601Inst : IEnumerable<long>
{
public static readonly long[] Value=A189601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189601.Bytes);
public long this[int i]=>Value[i];

public static A189601Inst Instance=new A189601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189602
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,35L,89L,221L,499L,1146L,2755L,6750L,16570L,40293L,97355L,234629L,565632L,1365768L,3303221L,7992751L,19333657L,46743931L,112983171L,273083004L,660115058L,1595837810L,3858133501L,9327445000L,22549449187L,54512990509L,131783650621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189602Inst : IEnumerable<long>
{
public static readonly long[] Value=A189602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189602.Bytes);
public long this[int i]=>Value[i];

public static A189602Inst Instance=new A189602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189603
{
public static readonly BigInteger[] Value={ 1L,3L,20L,464L,30283L,5897476L,3394457868L,5778059258273L,29117129479453520L,BigInteger.Parse("434446215594380010575") };
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
public class A189603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189603Inst Instance=new A189603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189604
{
public static readonly long[] Value={ 1L,6L,20L,72L,256L,912L,3248L,11568L,41200L,146736L,522608L,1861296L,6629104L,23609904L,84087920L,299483568L,1066626544L,3798846768L,13529793392L,48187073712L,171620807920L,611236571184L,2176951329392L,7753327130544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189604Inst : IEnumerable<long>
{
public static readonly long[] Value=A189604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189604.Bytes);
public long this[int i]=>Value[i];

public static A189604Inst Instance=new A189604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189605
{
public static readonly long[] Value={ 1L,13L,72L,464L,2853L,17617L,108785L,671452L,4144996L,25586605L,157944449L,974979853L,6018479996L,37151644524L,229334423389L,1415664871777L,8738797243193L,53943965676260L,332992213004236L,2055536935944305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189605Inst : IEnumerable<long>
{
public static readonly long[] Value=A189605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189605.Bytes);
public long this[int i]=>Value[i];

public static A189605Inst Instance=new A189605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189606
{
public static readonly long[] Value={ 1L,28L,256L,2853L,30283L,321815L,3414588L,36212912L,383990913L,4071436782L,43168209556L,457694879893L,4852734814404L,51451313282657L,545514314383676L,5783833141059232L,61323273361025444L,650181923557415105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189606Inst : IEnumerable<long>
{
public static readonly long[] Value=A189606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189606.Bytes);
public long this[int i]=>Value[i];

public static A189606Inst Instance=new A189606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189607
{
public static readonly BigInteger[] Value={ 1L,60L,912L,17617L,321815L,5897476L,107793872L,1968061359L,35917517449L,655347656612L,11956214759290L,218119695889901L,3979116037755048L,72589531392230391L,1324217776135660990L,BigInteger.Parse("24157052394845982633") };
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
public class A189607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189607Inst Instance=new A189607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189608
{
public static readonly BigInteger[] Value={ 1L,129L,3248L,108785L,3414588L,107793872L,3394457868L,106717857552L,3352763054744L,105288130659056L,3305643786649888L,103772022994114688L,3257440136563770512L,BigInteger.Parse("102248757981895108688"),BigInteger.Parse("3209460671164514648880") };
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
public class A189608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189608Inst Instance=new A189608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189609
{
public static readonly BigInteger[] Value={ 1L,277L,11568L,671452L,36212912L,1968061359L,106717857552L,5778059258273L,312573095738121L,16898643737922425L,913264073225048477L,BigInteger.Parse("49345410349072594251"),BigInteger.Parse("2665888554266786412238"),BigInteger.Parse("144014204839657901069783") };
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
public class A189609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189609Inst Instance=new A189609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189610
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,6L,1L,1L,13L,20L,13L,1L,1L,28L,72L,72L,28L,1L,1L,60L,256L,464L,256L,60L,1L,1L,129L,912L,2853L,2853L,912L,129L,1L,1L,277L,3248L,17617L,30283L,17617L,3248L,277L,1L,1L,595L,11568L,108785L,321815L,321815L,108785L,11568L,595L,1L,1L,1278L,41200L,671452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189610Inst : IEnumerable<long>
{
public static readonly long[] Value=A189610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189610.Bytes);
public long this[int i]=>Value[i];

public static A189610Inst Instance=new A189610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189611
{
public static readonly BigInteger[] Value={ 2L,16L,292L,8496L,532565L,118571483L,61652076124L,52939317116118L,90112326418652948L,BigInteger.Parse("433430536108638364008"),BigInteger.Parse("5597804841379220076966699") };
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
public class A189611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189611Inst Instance=new A189611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189708
{
public static readonly long[] Value={ 2L,3L,6L,9L,11L,12L,14L,15L,18L,20L,21L,23L,24L,27L,29L,30L,33L,36L,38L,39L,42L,45L,47L,48L,50L,51L,54L,56L,57L,60L,63L,65L,66L,69L,72L,74L,75L,77L,78L,81L,83L,84L,87L,90L,92L,93L,95L,96L,99L,101L,102L,104L,105L,108L,110L,111L,114L,117L,119L,120L,122L,123L,126L,128L,129L,131L,132L,135L,137L,138L,141L,144L,146L,147L,150L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189708Inst : IEnumerable<long>
{
public static readonly long[] Value=A189708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189708.Bytes);
public long this[int i]=>Value[i];

public static A189708Inst Instance=new A189708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189709
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,13L,14L,14L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,20L,20L,20L,21L,21L,21L,22L,22L,23L,24L,24L,25L,26L,26L,26L,27L,27L,28L,29L,29L,29L,30L,30L,30L,31L,31L,32L,33L,33L,33L,34L,34L,34L,35L,35L,36L,37L,37L,38L,39L,39L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189709Inst : IEnumerable<long>
{
public static readonly long[] Value=A189709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189709.Bytes);
public long this[int i]=>Value[i];

public static A189709Inst Instance=new A189709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189710
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,185L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189710Inst : IEnumerable<long>
{
public static readonly long[] Value=A189710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189710.Bytes);
public long this[int i]=>Value[i];

public static A189710Inst Instance=new A189710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189711
{
public static readonly long[] Value={ 2L,10L,8L,28L,54L,22L,60L,190L,204L,52L,110L,490L,916L,676L,114L,182L,1050L,2878L,3932L,2118L,240L,280L,1988L,7278L,15210L,16148L,6474L,494L,408L,3444L,15890L,45738L,77470L,65210L,19576L,1004L,570L,5580L,31192L,115808L,278358L,389640L,261708L,58920L,2026L,770L,8580L,56484L,258720L,820118L,1677048L,1951700L,1048008L,176994L,4072L,1012L,12650L,96006L,525444L,2090296L,5758802L,10073698L,9763628L,4193580L,531262L,8166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189711Inst : IEnumerable<long>
{
public static readonly long[] Value=A189711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189711.Bytes);
public long this[int i]=>Value[i];

public static A189711Inst Instance=new A189711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189712
{
public static readonly long[] Value={ 30L,56L,60L,90L,105L,120L,132L,144L,168L,180L,210L,240L,252L,264L,280L,288L,306L,315L,336L,351L,360L,380L,396L,400L,420L,432L,480L,495L,504L,520L,525L,528L,540L,546L,552L,560L,576L,612L,616L,630L,660L,672L,702L,720L,735L,756L,760L,792L,800L,810L,840L,858L,864L,900L,918L,924L,960L,990L,992L,1008L,1040L,1050L,1053L,1056L,1080L,1092L,1100L,1104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189712Inst : IEnumerable<long>
{
public static readonly long[] Value=A189712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189712.Bytes);
public long this[int i]=>Value[i];

public static A189712Inst Instance=new A189712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189713
{
public static readonly long[] Value={ 1L,6L,23L,56L,168L,459L,1080L,2400L,5461L,12678L,28728L,63336L,138717L,303346L,663179L,1438098L,3062730L,6450121L,13583957L,28627773L,59954459L,124413466L,258510987L,543867101L,1152248068L,2428235533L,5069886692L,10511339217L,21696371682L,44710463120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189713Inst : IEnumerable<long>
{
public static readonly long[] Value=A189713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189713.Bytes);
public long this[int i]=>Value[i];

public static A189713Inst Instance=new A189713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189714
{
public static readonly long[] Value={ 1L,5L,19L,61L,146L,336L,757L,1711L,3868L,8752L,19680L,43869L,96695L,210638L,453863L,968875L,2053227L,4328457L,9093933L,19068574L,39943650L,83628355L,175018478L,366081158L,765102861L,1597315609L,3330380539L,6933810090L,14414812994L,29924339675L,62038821363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189714Inst : IEnumerable<long>
{
public static readonly long[] Value=A189714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189714.Bytes);
public long this[int i]=>Value[i];

public static A189714Inst Instance=new A189714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189715
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,10L,13L,15L,16L,19L,22L,24L,25L,28L,31L,33L,34L,36L,37L,40L,42L,43L,46L,49L,51L,52L,54L,55L,58L,60L,61L,63L,64L,67L,69L,70L,73L,76L,78L,79L,81L,82L,85L,87L,88L,90L,91L,94L,96L,97L,100L,103L,105L,106L,109L,112L,114L,115L,117L,118L,121L,123L,124L,127L,130L,132L,133L,135L,136L,139L,141L,142L,144L,145L,148L,150L,151L,154L,157L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189715Inst : IEnumerable<long>
{
public static readonly long[] Value=A189715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189715.Bytes);
public long this[int i]=>Value[i];

public static A189715Inst Instance=new A189715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189716
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,12L,14L,17L,18L,20L,21L,23L,26L,27L,29L,30L,32L,35L,38L,39L,41L,44L,45L,47L,48L,50L,53L,56L,57L,59L,62L,65L,66L,68L,71L,72L,74L,75L,77L,80L,83L,84L,86L,89L,92L,93L,95L,98L,99L,101L,102L,104L,107L,108L,110L,111L,113L,116L,119L,120L,122L,125L,126L,128L,129L,131L,134L,137L,138L,140L,143L,146L,147L,149L,152L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189716Inst : IEnumerable<long>
{
public static readonly long[] Value=A189716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189716.Bytes);
public long this[int i]=>Value[i];

public static A189716Inst Instance=new A189716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189717
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,6L,6L,7L,7L,7L,8L,9L,9L,10L,11L,11L,12L,12L,12L,13L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,18L,19L,20L,20L,21L,21L,21L,22L,23L,23L,24L,25L,25L,26L,26L,26L,27L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,31L,32L,33L,33L,34L,34L,34L,35L,36L,36L,37L,38L,38L,39L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189717Inst : IEnumerable<long>
{
public static readonly long[] Value=A189717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189717.Bytes);
public long this[int i]=>Value[i];

public static A189717Inst Instance=new A189717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189718
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189718Inst : IEnumerable<long>
{
public static readonly long[] Value=A189718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189718.Bytes);
public long this[int i]=>Value[i];

public static A189718Inst Instance=new A189718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189719
{
public static readonly long[] Value={ 1L,5L,6L,8L,9L,11L,12L,13L,16L,20L,21L,22L,25L,29L,30L,31L,34L,37L,41L,42L,44L,45L,46L,50L,51L,53L,54L,56L,57L,58L,61L,64L,68L,69L,71L,72L,73L,77L,78L,80L,81L,83L,84L,85L,88L,91L,95L,96L,98L,99L,100L,104L,105L,107L,108L,109L,113L,114L,116L,117L,119L,120L,121L,124L,128L,129L,130L,133L,136L,140L,141L,143L,144L,146L,147L,148L,151L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189719Inst : IEnumerable<long>
{
public static readonly long[] Value=A189719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189719.Bytes);
public long this[int i]=>Value[i];

public static A189719Inst Instance=new A189719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189720
{
public static readonly long[] Value={ 2L,3L,4L,7L,10L,14L,15L,17L,18L,19L,23L,24L,26L,27L,28L,32L,33L,35L,36L,38L,39L,40L,43L,47L,48L,49L,52L,55L,59L,60L,62L,63L,65L,66L,67L,70L,74L,75L,76L,79L,82L,86L,87L,89L,90L,92L,93L,94L,97L,101L,102L,103L,106L,110L,111L,112L,115L,118L,122L,123L,125L,126L,127L,131L,132L,134L,135L,137L,138L,139L,142L,145L,149L,150L,152L,153L,154L,158L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189720Inst : IEnumerable<long>
{
public static readonly long[] Value=A189720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189720.Bytes);
public long this[int i]=>Value[i];

public static A189720Inst Instance=new A189720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189721
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,7L,7L,8L,9L,10L,10L,10L,10L,11L,12L,12L,13L,14L,15L,15L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,22L,23L,23L,23L,23L,24L,25L,26L,26L,26L,27L,27L,27L,28L,28L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,35L,36L,36L,36L,36L,37L,38L,39L,39L,39L,40L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189721Inst : IEnumerable<long>
{
public static readonly long[] Value=A189721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189721.Bytes);
public long this[int i]=>Value[i];

public static A189721Inst Instance=new A189721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189722
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,141L,226L,362L,580L,921L,1468L,2344L,3740L,5922L,9413L,14978L,23829L,37686L,59770L,94882L,150606L,237947L,376784L,597063L,946086L,1493497L,2361970L,3737699L,5914635L,9330438L,14741315L,23301716L,36833270L,58071568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189722Inst : IEnumerable<long>
{
public static readonly long[] Value=A189722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189722.Bytes);
public long this[int i]=>Value[i];

public static A189722Inst Instance=new A189722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189723
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189723Inst : IEnumerable<long>
{
public static readonly long[] Value=A189723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189723.Bytes);
public long this[int i]=>Value[i];

public static A189723Inst Instance=new A189723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189756
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,15L,18L,20L,23L,25L,28L,30L,32L,35L,37L,40L,42L,44L,46L,49L,51L,54L,56L,59L,61L,63L,66L,68L,71L,73L,75L,77L,80L,82L,85L,87L,89L,92L,94L,97L,99L,102L,104L,106L,108L,111L,113L,116L,119L,120L,123L,125L,128L,130L,133L,134L,137L,139L,142L,144L,147L,150L,151L,154L,156L,159L,161L,164L,165L,168L,170L,173L,175L,178L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189756Inst : IEnumerable<long>
{
public static readonly long[] Value=A189756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189756.Bytes);
public long this[int i]=>Value[i];

public static A189756Inst Instance=new A189756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189757
{
public static readonly long[] Value={ 2L,5L,7L,10L,13L,16L,19L,22L,24L,27L,31L,33L,36L,38L,41L,45L,47L,50L,53L,55L,58L,62L,64L,67L,70L,72L,76L,78L,81L,84L,86L,90L,93L,95L,98L,101L,103L,107L,110L,112L,115L,117L,121L,124L,126L,129L,132L,135L,138L,141L,143L,146L,149L,152L,155L,157L,160L,163L,166L,169L,172L,174L,177L,181L,183L,186L,189L,191L,194L,197L,200L,203L,205L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189757Inst : IEnumerable<long>
{
public static readonly long[] Value=A189757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189757.Bytes);
public long this[int i]=>Value[i];

public static A189757Inst Instance=new A189757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189758
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,26L,29L,34L,39L,43L,48L,52L,57L,60L,65L,69L,74L,79L,83L,88L,91L,96L,100L,105L,109L,114L,118L,122L,127L,131L,136L,140L,145L,148L,153L,158L,162L,167L,171L,176L,179L,184L,188L,193L,198L,202L,206L,210L,215L,219L,224L,228L,233L,237L,241L,246L,250L,255L,259L,264L,268L,272L,277L,281L,286L,290L,295L,298L,303L,308L,312L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189758Inst : IEnumerable<long>
{
public static readonly long[] Value=A189758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189758.Bytes);
public long this[int i]=>Value[i];

public static A189758Inst Instance=new A189758Inst();

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