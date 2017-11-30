using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A072596
{
public static readonly long[] Value={ 70L,280L,630L,646L,1120L,1750L,1798L,2145L,2520L,2584L,3430L,3526L,4480L,5670L,5814L,5865L,6006L,7000L,7192L,8470L,8580L,9177L,10080L,10336L,11305L,11830L,13110L,13720L,14104L,15750L,16150L,16182L,16422L,17920L,19305L,20230L,20553L,20806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072596Inst : IEnumerable<long>
{
public static readonly long[] Value=A072596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072596.Bytes);
public long this[int i]=>Value[i];

public static A072596Inst Instance=new A072596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072579
{
public static readonly long[] Value={ 1L,7L,13L,26L,37L,41L,42L,45L,49L,50L,58L,59L,62L,69L,70L,74L,78L,79L,87L,103L,105L,107L,110L,114L,118L,121L,134L,139L,141L,142L,145L,147L,158L,161L,162L,164L,165L,168L,175L,185L,189L,198L,202L,203L,213L,214L,223L,227L,232L,234L,243L,267L,275L,282L,289L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072579Inst : IEnumerable<long>
{
public static readonly long[] Value=A072579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072579.Bytes);
public long this[int i]=>Value[i];

public static A072579Inst Instance=new A072579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072578
{
public static readonly long[] Value={ 8L,16L,34L,44L,64L,65L,80L,106L,116L,128L,138L,140L,174L,178L,184L,193L,196L,209L,258L,259L,260L,263L,264L,266L,272L,280L,288L,290L,314L,316L,325L,326L,327L,328L,330L,338L,344L,385L,391L,402L,449L,514L,520L,521L,528L,544L,566L,570L,574L,578L,587L,590L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072578Inst : IEnumerable<long>
{
public static readonly long[] Value=A072578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072578.Bytes);
public long this[int i]=>Value[i];

public static A072578Inst Instance=new A072578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072577
{
public static readonly long[] Value={ 5L,6L,20L,22L,24L,28L,31L,32L,34L,37L,41L,42L,49L,50L,67L,68L,81L,82L,84L,88L,89L,93L,94L,138L,139L,140L,141L,142L,143L,147L,151L,157L,165L,192L,194L,198L,200L,202L,206L,207L,232L,236L,241L,262L,265L,270L,271L,284L,285L,295L,301L,328L,329L,332L,333L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072577Inst : IEnumerable<long>
{
public static readonly long[] Value=A072577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072577.Bytes);
public long this[int i]=>Value[i];

public static A072577Inst Instance=new A072577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072576
{
public static readonly long[] Value={ 1L,2L,2L,8L,8L,14L,38L,44L,68L,98L,242L,272L,440L,590L,878L,1772L,2180L,3194L,4466L,6320L,8432L,16190L,19262L,28580L,38276L,54314L,70730L,99152L,163328L,204230L,286670L,386132L,527132L,695978L,941738L,1220984L,1950128L,2390294L,3321398L,4342148L,5929532L,7616642L,10284410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072576Inst : IEnumerable<long>
{
public static readonly long[] Value=A072576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072576.Bytes);
public long this[int i]=>Value[i];

public static A072576Inst Instance=new A072576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072575
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,0L,2L,1L,0L,0L,2L,2L,1L,0L,0L,6L,2L,2L,1L,0L,0L,0L,8L,2L,2L,1L,0L,0L,0L,6L,8L,2L,2L,1L,0L,0L,0L,6L,8L,8L,2L,2L,1L,0L,0L,0L,24L,12L,8L,8L,2L,2L,1L,0L,0L,0L,0L,30L,14L,8L,8L,2L,2L,1L,0L,0L,0L,0L,30L,36L,14L,8L,8L,2L,2L,1L,0L,0L,0L,0L,24L,36L,38L,14L,8L,8L,2L,2L,1L,0L,0L,0L,0L,24L,54L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072575Inst : IEnumerable<long>
{
public static readonly long[] Value=A072575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072575.Bytes);
public long this[int i]=>Value[i];

public static A072575Inst Instance=new A072575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072574
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,2L,0L,0L,1L,4L,0L,0L,0L,1L,4L,6L,0L,0L,0L,1L,6L,6L,0L,0L,0L,0L,1L,6L,12L,0L,0L,0L,0L,0L,1L,8L,18L,0L,0L,0L,0L,0L,0L,1L,8L,24L,24L,0L,0L,0L,0L,0L,0L,1L,10L,30L,24L,0L,0L,0L,0L,0L,0L,0L,1L,10L,42L,48L,0L,0L,0L,0L,0L,0L,0L,0L,1L,12L,48L,72L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,12L,60L,120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072574Inst : IEnumerable<long>
{
public static readonly long[] Value=A072574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072574.Bytes);
public long this[int i]=>Value[i];

public static A072574Inst Instance=new A072574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072573
{
public static readonly long[] Value={ 205L,217L,473L,515L,625L,667L,803L,1003L,1207L,1243L,1313L,1465L,1505L,1517L,1537L,1681L,1715L,1795L,1817L,1895L,2075L,2105L,2191L,2303L,2405L,2453L,2585L,2627L,2783L,2933L,3055L,3073L,3175L,3197L,3265L,3337L,3353L,3505L,3565L,3665L,3937L,3995L,4085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072573Inst : IEnumerable<long>
{
public static readonly long[] Value=A072573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072573.Bytes);
public long this[int i]=>Value[i];

public static A072573Inst Instance=new A072573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072572
{
public static readonly long[] Value={ 9L,15L,21L,39L,45L,69L,81L,93L,99L,105L,111L,129L,165L,195L,225L,231L,279L,309L,315L,351L,363L,381L,393L,399L,405L,441L,453L,459L,465L,483L,489L,495L,501L,615L,645L,675L,687L,705L,723L,741L,747L,759L,765L,771L,825L,855L,861L,879L,885L,897L,909L,915L,933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072572Inst : IEnumerable<long>
{
public static readonly long[] Value=A072572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072572.Bytes);
public long this[int i]=>Value[i];

public static A072572Inst Instance=new A072572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072571
{
public static readonly long[] Value={ 26L,34L,50L,56L,64L,76L,86L,134L,154L,160L,170L,176L,236L,254L,260L,266L,274L,334L,356L,370L,376L,386L,436L,446L,506L,532L,544L,560L,566L,574L,590L,596L,604L,610L,650L,656L,680L,730L,736L,754L,944L,950L,974L,980L,994L,1016L,1036L,1066L,1078L,1100L,1106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072571Inst : IEnumerable<long>
{
public static readonly long[] Value=A072571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072571.Bytes);
public long this[int i]=>Value[i];

public static A072571Inst Instance=new A072571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072570
{
public static readonly long[] Value={ 4L,6L,12L,18L,30L,42L,60L,72L,102L,108L,120L,138L,144L,150L,180L,186L,192L,198L,228L,240L,246L,270L,282L,288L,300L,312L,324L,342L,348L,414L,420L,426L,432L,462L,522L,552L,570L,582L,600L,618L,636L,642L,660L,696L,714L,780L,792L,810L,816L,822L,828L,834L,846L,858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072570Inst : IEnumerable<long>
{
public static readonly long[] Value=A072570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072570.Bytes);
public long this[int i]=>Value[i];

public static A072570Inst Instance=new A072570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072569
{
public static readonly long[] Value={ 9L,15L,21L,39L,45L,69L,81L,93L,99L,105L,111L,129L,165L,195L,205L,217L,225L,231L,279L,309L,315L,351L,363L,381L,393L,399L,405L,441L,453L,459L,465L,473L,483L,489L,495L,501L,515L,615L,625L,645L,667L,675L,687L,705L,723L,741L,747L,759L,765L,771L,803L,825L,855L,861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072569Inst : IEnumerable<long>
{
public static readonly long[] Value=A072569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072569.Bytes);
public long this[int i]=>Value[i];

public static A072569Inst Instance=new A072569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072568
{
public static readonly long[] Value={ 4L,6L,12L,18L,26L,30L,34L,42L,50L,56L,60L,64L,72L,76L,86L,102L,108L,120L,134L,138L,144L,150L,154L,160L,170L,176L,180L,186L,192L,198L,228L,236L,240L,246L,254L,260L,266L,270L,274L,282L,288L,300L,312L,324L,334L,342L,348L,356L,370L,376L,386L,414L,420L,426L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072568Inst : IEnumerable<long>
{
public static readonly long[] Value=A072568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072568.Bytes);
public long this[int i]=>Value[i];

public static A072568Inst Instance=new A072568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072567
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,16L,21L,24L,29L,34L,39L,45L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072567Inst : IEnumerable<long>
{
public static readonly long[] Value=A072567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072567.Bytes);
public long this[int i]=>Value[i];

public static A072567Inst Instance=new A072567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072566
{
public static readonly long[] Value={ 1L,14L,34L,40L,44L,74L,78L,81L,84L,94L,120L,124L,134L,138L,164L,190L,194L,198L,204L,214L,224L,244L,254L,258L,270L,274L,280L,284L,290L,294L,314L,318L,334L,360L,361L,364L,380L,394L,404L,438L,440L,441L,444L,454L,462L,498L,514L,520L,524L,528L,540L,544L,554L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072566Inst : IEnumerable<long>
{
public static readonly long[] Value=A072566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072566.Bytes);
public long this[int i]=>Value[i];

public static A072566Inst Instance=new A072566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072565
{
public static readonly long[] Value={ 0L,0L,3L,4L,2L,12L,13L,3L,3L,17L,30L,25L,13L,41L,26L,49L,17L,0L,25L,17L,61L,41L,2L,8L,25L,13L,25L,13L,73L,27L,41L,49L,25L,121L,17L,73L,61L,41L,73L,49L,25L,121L,13L,25L,29L,90L,193L,25L,13L,41L,49L,25L,161L,73L,73L,49L,17L,61L,25L,25L,241L,253L,25L,13L,73L,281L,97L,121L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072565Inst : IEnumerable<long>
{
public static readonly long[] Value=A072565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072565.Bytes);
public long this[int i]=>Value[i];

public static A072565Inst Instance=new A072565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072564
{
public static readonly long[] Value={ 4L,5L,6L,15L,22L,31L,38L,41L,57L,60L,70L,76L,78L,83L,85L,88L,95L,99L,104L,106L,119L,123L,124L,130L,134L,140L,158L,175L,177L,186L,197L,203L,205L,208L,212L,214L,221L,238L,240L,243L,250L,259L,260L,267L,270L,277L,279L,285L,287L,292L,295L,300L,302L,303L,305L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072564Inst : IEnumerable<long>
{
public static readonly long[] Value=A072564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072564.Bytes);
public long this[int i]=>Value[i];

public static A072564Inst Instance=new A072564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072563
{
public static readonly long[] Value={ 9L,9L,9L,15L,23L,51L,93L,225L,429L,1059L,2039L,5055L,9753L,24201L,46713L,115935L,223799L,555459L,1072269L,2661345L,5137533L,12751251L,24615383L,61094895L,117939369L,292723209L,565081449L,1402521135L,2707467863L,6719882451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072563Inst : IEnumerable<long>
{
public static readonly long[] Value=A072563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072563.Bytes);
public long this[int i]=>Value[i];

public static A072563Inst Instance=new A072563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072562
{
public static readonly BigInteger[] Value={ 4L,2L,8L,158L,3098L,788L,210998L,5316098L,34415168L,703693778L,194794490678L,5208806743928L,138782093170508L,5006786309605868L,253579251611336438L,12551374903381164638UL,BigInteger.Parse("142908008812141343558"),BigInteger.Parse("77053322014980646906358") };
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
public class A072562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072562Inst Instance=new A072562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072561
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,19L,21L,22L,24L,25L,27L,28L,30L,31L,33L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,55L,57L,58L,60L,61L,63L,64L,66L,67L,69L,73L,75L,76L,78L,79L,81L,82L,84L,85L,87L,91L,93L,94L,96L,97L,99L,100L,102L,103L,105L,109L,111L,112L,114L,115L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072561Inst : IEnumerable<long>
{
public static readonly long[] Value=A072561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072561.Bytes);
public long this[int i]=>Value[i];

public static A072561Inst Instance=new A072561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072560
{
public static readonly long[] Value={ 3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L,1L,1L,1L,3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L,1L,1L,1L,3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L,1L,1L,1L,3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L,1L,1L,1L,3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L,1L,1L,1L,3L,9L,3L,3L,1L,3L,3L,9L,3L,3L,1L,3L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072560Inst : IEnumerable<long>
{
public static readonly long[] Value=A072560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072560.Bytes);
public long this[int i]=>Value[i];

public static A072560Inst Instance=new A072560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072559
{
public static readonly long[] Value={ 0L,9L,3L,2L,5L,1L,2L,1L,3L,2L,1L,3L,1L,1L,1L,1L,11L,1L,1L,3L,1L,1L,8L,2L,3330L,1L,1L,5L,3L,7L,23L,1L,3L,3L,1L,1L,1L,1L,1L,4L,1L,5L,14L,4L,2L,2L,2L,1L,2L,1L,2L,2L,1L,1L,1L,1L,4L,4L,1L,2L,1L,1L,1L,76L,3L,1L,16L,2L,2L,1L,7L,1L,11L,1L,1L,1L,1L,1L,21L,1L,109L,2L,4L,1L,3L,6L,5L,7L,5L,5L,4L,1L,4L,2L,1L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072559Inst : IEnumerable<long>
{
public static readonly long[] Value=A072559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072559.Bytes);
public long this[int i]=>Value[i];

public static A072559Inst Instance=new A072559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072558
{
public static readonly long[] Value={ 1L,0L,7L,6L,5L,3L,9L,1L,9L,2L,2L,6L,4L,8L,4L,5L,7L,6L,6L,1L,5L,3L,2L,3L,4L,4L,5L,0L,9L,0L,9L,4L,7L,1L,9L,0L,5L,8L,7L,9L,7L,6L,5L,6L,3L,2L,9L,0L,1L,1L,5L,0L,8L,6L,6L,9L,8L,5L,6L,8L,1L,4L,6L,9L,8L,1L,9L,2L,4L,3L,4L,1L,4L,6L,2L,6L,4L,2L,6L,4L,3L,4L,1L,2L,7L,7L,6L,1L,9L,9L,0L,4L,0L,9L,1L,5L,8L,7L,3L,1L,9L,2L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072558Inst : IEnumerable<long>
{
public static readonly long[] Value=A072558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072558.Bytes);
public long this[int i]=>Value[i];

public static A072558Inst Instance=new A072558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072557
{
public static readonly long[] Value={ 5L,11L,16L,17L,18L,23L,29L,34L,35L,36L,41L,47L,52L,53L,54L,59L,65L,70L,71L,72L,77L,83L,88L,89L,90L,95L,101L,106L,107L,108L,113L,119L,124L,125L,126L,131L,137L,142L,143L,144L,149L,155L,160L,161L,162L,167L,173L,178L,179L,180L,185L,191L,196L,197L,198L,203L,209L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072557Inst : IEnumerable<long>
{
public static readonly long[] Value=A072557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072557.Bytes);
public long this[int i]=>Value[i];

public static A072557Inst Instance=new A072557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072556
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,10L,11L,12L,13L,14L,17L,22L,23L,26L,29L,34L,43L,47L,83L,94L,131L,137L,359L,431L,433L,449L,509L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072556Inst : IEnumerable<long>
{
public static readonly long[] Value=A072556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072556.Bytes);
public long this[int i]=>Value[i];

public static A072556Inst Instance=new A072556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072555
{
public static readonly long[] Value={ 158L,368L,578L,788L,789L,790L,998L,1208L,1418L,1628L,1838L,1944L,2048L,2258L,2468L,2678L,2888L,3098L,3099L,3308L,3518L,3728L,3938L,4148L,4254L,4358L,4367L,4568L,4778L,4988L,5198L,5408L,5409L,5618L,5795L,5828L,6038L,6248L,6458L,6564L,6668L,6797L,6878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072555Inst : IEnumerable<long>
{
public static readonly long[] Value=A072555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072555.Bytes);
public long this[int i]=>Value[i];

public static A072555Inst Instance=new A072555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072554
{
public static readonly long[] Value={ 10L,11L,12L,13L,15L,16L,18L,20L,22L,24L,27L,30L,33L,36L,39L,43L,47L,51L,56L,62L,68L,75L,82L,91L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072554Inst : IEnumerable<long>
{
public static readonly long[] Value=A072554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072554.Bytes);
public long this[int i]=>Value[i];

public static A072554Inst Instance=new A072554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072553
{
public static readonly long[] Value={ 0L,6L,8L,0L,10L,18L,14L,14L,0L,26L,28L,20L,24L,42L,0L,28L,27L,39L,51L,44L,32L,37L,32L,66L,42L,39L,65L,71L,60L,56L,51L,93L,40L,68L,51L,72L,89L,51L,89L,57L,65L,128L,71L,76L,0L,60L,109L,95L,71L,109L,150L,83L,93L,105L,71L,128L,143L,90L,95L,175L,79L,99L,89L,138L,182L,82L,128L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072553Inst : IEnumerable<long>
{
public static readonly long[] Value=A072553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072553.Bytes);
public long this[int i]=>Value[i];

public static A072553Inst Instance=new A072553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072552
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,13L,21L,68L,166L,543L,1605L,5413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072552Inst : IEnumerable<long>
{
public static readonly long[] Value=A072552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072552.Bytes);
public long this[int i]=>Value[i];

public static A072552Inst Instance=new A072552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072551
{
public static readonly long[] Value={ 1L,2L,0L,1L,9L,4L,3L,3L,6L,8L,4L,7L,0L,3L,1L,4L,4L,6L,7L,1L,9L,4L,2L,4L,1L,1L,3L,9L,3L,8L,1L,2L,9L,7L,0L,8L,0L,4L,4L,0L,1L,8L,7L,1L,5L,3L,9L,3L,5L,1L,6L,9L,0L,9L,5L,6L,3L,0L,9L,8L,9L,0L,1L,3L,8L,3L,1L,5L,7L,8L,4L,5L,1L,1L,2L,1L,6L,8L,1L,0L,7L,1L,8L,4L,9L,4L,4L,4L,1L,8L,1L,4L,3L,0L,2L,1L,6L,3L,8L,2L,4L,2L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072551Inst : IEnumerable<long>
{
public static readonly long[] Value=A072551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072551.Bytes);
public long this[int i]=>Value[i];

public static A072551Inst Instance=new A072551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072550
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,0L,2L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072550Inst : IEnumerable<long>
{
public static readonly long[] Value=A072550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072550.Bytes);
public long this[int i]=>Value[i];

public static A072550Inst Instance=new A072550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072549
{
public static readonly BigInteger[] Value={ 1L,2L,2L,1L,2L,3L,4L,5L,6L,7L,9L,9L,12L,10L,16L,9L,24L,2L,34L,23L,14L,34L,6L,48L,43L,18L,47L,19L,53L,28L,46L,8L,77L,97L,190L,941L,24503L,16226849L,6929227064868L,BigInteger.Parse("1231133018371774314868035") };
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
public class A072549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072549Inst Instance=new A072549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072548
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,3L,1L,2L,2L,3L,2L,0L,0L,1L,4L,4L,4L,2L,0L,4L,6L,6L,4L,6L,4L,2L,0L,2L,10L,8L,4L,10L,4L,3L,2L,0L,8L,6L,3L,5L,2L,0L,8L,2L,3L,4L,12L,3L,12L,8L,6L,8L,8L,8L,0L,10L,9L,15L,8L,6L,14L,1L,12L,0L,11L,12L,1L,11L,12L,15L,11L,9L,19L,14L,12L,0L,14L,10L,11L,16L,15L,17L,16L,17L,5L,19L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072548Inst : IEnumerable<long>
{
public static readonly long[] Value=A072548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072548.Bytes);
public long this[int i]=>Value[i];

public static A072548Inst Instance=new A072548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072435
{
public static readonly long[] Value={ 2552L,3333L,3432L,4224L,4653L,5764L,6116L,7876L,13123L,14883L,15235L,16346L,16775L,17567L,17666L,18447L,25052L,25252L,25452L,25652L,25852L,26052L,26252L,26452L,26652L,26852L,33033L,33132L,33233L,33332L,33433L,33532L,33633L,33732L,33833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072435Inst : IEnumerable<long>
{
public static readonly long[] Value=A072435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072435.Bytes);
public long this[int i]=>Value[i];

public static A072435Inst Instance=new A072435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072434
{
public static readonly long[] Value={ 1111L,1991L,2442L,3542L,5115L,6875L,11011L,14124L,15884L,17457L,18557L,19008L,19091L,19291L,19491L,19691L,19891L,20091L,20291L,20491L,20691L,20891L,24042L,24242L,24442L,24642L,24842L,25042L,25242L,25442L,25642L,25842L,34142L,34342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072434Inst : IEnumerable<long>
{
public static readonly long[] Value=A072434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072434.Bytes);
public long this[int i]=>Value[i];

public static A072434Inst Instance=new A072434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072433
{
public static readonly long[] Value={ 99L,110L,121L,909L,929L,949L,969L,989L,1009L,1010L,1029L,1030L,1049L,1050L,1069L,1070L,1089L,1090L,1110L,1130L,1150L,1170L,1190L,1881L,2101L,3223L,4763L,9009L,10010L,10989L,11990L,16236L,17776L,18081L,18281L,18481L,18681L,18881L,18898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072433Inst : IEnumerable<long>
{
public static readonly long[] Value=A072433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072433.Bytes);
public long this[int i]=>Value[i];

public static A072433Inst Instance=new A072433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072432
{
public static readonly long[] Value={ 88L,808L,828L,848L,868L,888L,908L,928L,948L,968L,988L,1131L,1151L,1171L,1191L,1211L,1231L,1251L,1271L,1291L,1771L,2211L,2332L,3652L,4114L,5874L,8008L,9988L,12991L,15125L,16885L,17071L,17271L,17347L,17471L,17671L,17871L,18071L,18271L,18471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072432Inst : IEnumerable<long>
{
public static readonly long[] Value=A072432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072432.Bytes);
public long this[int i]=>Value[i];

public static A072432Inst Instance=new A072432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072431
{
public static readonly long[] Value={ 77L,132L,707L,727L,747L,767L,787L,807L,827L,847L,867L,887L,1212L,1232L,1252L,1272L,1292L,1312L,1332L,1352L,1372L,1392L,1661L,2321L,7007L,8987L,12012L,13992L,16061L,16261L,16461L,16661L,16861L,17061L,17261L,17461L,17661L,17861L,18678L,19338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072431Inst : IEnumerable<long>
{
public static readonly long[] Value=A072431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072431.Bytes);
public long this[int i]=>Value[i];

public static A072431Inst Instance=new A072431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072430
{
public static readonly long[] Value={ 66L,143L,606L,626L,646L,666L,686L,706L,726L,746L,766L,786L,1313L,1333L,1353L,1373L,1393L,1413L,1433L,1453L,1473L,1493L,1551L,2222L,2431L,3113L,3762L,4873L,6006L,7986L,13013L,14993L,15051L,15251L,15451L,15651L,15851L,16051L,16126L,16251L,16451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072430Inst : IEnumerable<long>
{
public static readonly long[] Value=A072430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072430.Bytes);
public long this[int i]=>Value[i];

public static A072430Inst Instance=new A072430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072429
{
public static readonly long[] Value={ 55L,154L,505L,525L,545L,565L,585L,605L,625L,645L,665L,685L,1414L,1434L,1441L,1454L,1474L,1494L,1514L,1534L,1554L,1574L,1594L,2541L,5005L,6985L,14014L,14041L,14241L,14441L,14641L,14841L,15041L,15241L,15441L,15641L,15841L,15994L,18458L,19558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072429Inst : IEnumerable<long>
{
public static readonly long[] Value=A072429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072429.Bytes);
public long this[int i]=>Value[i];

public static A072429Inst Instance=new A072429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072428
{
public static readonly long[] Value={ 44L,165L,404L,424L,444L,464L,484L,504L,524L,544L,564L,584L,1331L,1515L,1535L,1555L,1575L,1595L,1615L,1635L,1655L,1675L,1695L,2112L,2651L,3872L,4004L,5984L,13031L,13231L,13431L,13631L,13831L,14031L,14231L,14431L,14631L,14831L,15015L,16995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072428Inst : IEnumerable<long>
{
public static readonly long[] Value=A072428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072428.Bytes);
public long this[int i]=>Value[i];

public static A072428Inst Instance=new A072428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072427
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,11L,12L,14L,16L,18L,101L,141L,161L,181L,198L,201L,221L,241L,261L,281L,1001L,1818L,1838L,1858L,1878L,1898L,1918L,1938L,1958L,1978L,1998L,2981L,10001L,10201L,10401L,10601L,10801L,11001L,11201L,11401L,11601L,11801L,18018L,19998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072427Inst : IEnumerable<long>
{
public static readonly long[] Value=A072427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072427.Bytes);
public long this[int i]=>Value[i];

public static A072427Inst Instance=new A072427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072426
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,12L,13L,16L,17L,18L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,300L,301L,302L,303L,304L,305L,306L,307L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072426Inst : IEnumerable<long>
{
public static readonly long[] Value=A072426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072426.Bytes);
public long this[int i]=>Value[i];

public static A072426Inst Instance=new A072426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072425
{
public static readonly long[] Value={ 4L,2L,3L,6L,2L,3L,7L,2L,3L,5L,4L,24L,8L,3L,2L,3L,6L,5L,2L,3L,5L,3L,2L,3L,6L,3L,2L,3L,5L,5L,2L,3L,5L,5L,2L,3L,7L,3L,2L,3L,6L,5L,2L,3L,5L,4L,2L,3L,5L,4L,2L,3L,8L,3L,2L,3L,7L,5L,2L,3L,10L,5L,2L,3L,10L,2L,3L,9L,5L,2L,3L,9L,3L,2L,3L,11L,4L,2L,3L,10L,3L,2L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072425Inst : IEnumerable<long>
{
public static readonly long[] Value=A072425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072425.Bytes);
public long this[int i]=>Value[i];

public static A072425Inst Instance=new A072425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072424
{
public static readonly long[] Value={ 5L,3L,6L,2L,3L,7L,2L,3L,5L,4L,2L,4L,8L,3L,2L,3L,6L,3L,2L,3L,5L,3L,2L,3L,6L,5L,2L,3L,5L,5L,2L,3L,5L,3L,2L,3L,7L,5L,2L,3L,6L,4L,2L,3L,5L,4L,2L,3L,5L,2L,2L,3L,8L,4L,23L,7L,5L,2L,3L,10L,5L,2L,3L,10L,2L,3L,9L,5L,2L,3L,9L,3L,2L,3L,11L,3L,2L,3L,10L,3L,2L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072424Inst : IEnumerable<long>
{
public static readonly long[] Value=A072424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072424.Bytes);
public long this[int i]=>Value[i];

public static A072424Inst Instance=new A072424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072423
{
public static readonly long[] Value={ 1L,4L,11L,16L,19L,29L,33L,42L,56L,70L,71L,74L,77L,87L,105L,109L,121L,128L,132L,142L,151L,161L,166L,171L,181L,185L,192L,202L,207L,212L,219L,227L,234L,251L,258L,261L,276L,283L,291L,313L,320L,343L,350L,366L,375L,382L,401L,408L,412L,427L,434L,443L,455L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072423Inst : IEnumerable<long>
{
public static readonly long[] Value=A072423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072423.Bytes);
public long this[int i]=>Value[i];

public static A072423Inst Instance=new A072423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072422
{
public static readonly long[] Value={ 1L,18L,24L,2753L,59L,62L,95L,98L,126L,132L,135L,149L,155L,170L,176L,184L,186L,191L,197L,212L,218L,221L,230L,251L,257L,260L,268L,271L,273L,289L,295L,298L,309L,311L,327L,333L,336L,356L,371L,377L,380L,389L,403L,418L,424L,427L,435L,449L,464L,470L,473L,478L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072422Inst : IEnumerable<long>
{
public static readonly long[] Value=A072422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072422.Bytes);
public long this[int i]=>Value[i];

public static A072422Inst Instance=new A072422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072421
{
public static readonly long[] Value={ 1L,5L,10L,25L,40L,63L,84L,110L,135L,159L,192L,230L,265L,294L,330L,366L,397L,434L,455L,483L,523L,557L,598L,634L,645L,679L,717L,753L,795L,810L,832L,842L,856L,868L,898L,911L,938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072421Inst : IEnumerable<long>
{
public static readonly long[] Value=A072421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072421.Bytes);
public long this[int i]=>Value[i];

public static A072421Inst Instance=new A072421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072420
{
public static readonly long[] Value={ 4L,4L,3L,5L,4L,3L,5L,4L,3L,4L,5L,4L,4L,4L,3L,7L,2L,2L,4L,4L,4L,6L,4L,3L,6L,5L,2L,7L,5L,3L,4L,4L,5L,5L,3L,3L,5L,5L,3L,5L,4L,3L,5L,5L,2L,6L,5L,6L,6L,4L,1L,6L,3L,2L,6L,5L,3L,6L,3L,3L,7L,5L,3L,6L,5L,5L,4L,4L,3L,5L,2L,2L,5L,5L,3L,4L,5L,4L,5L,4L,2L,7L,7L,6L,6L,4L,4L,5L,4L,3L,4L,5L,3L,6L,3L,3L,5L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072420Inst : IEnumerable<long>
{
public static readonly long[] Value=A072420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072420.Bytes);
public long this[int i]=>Value[i];

public static A072420Inst Instance=new A072420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072355
{
public static readonly long[] Value={ 2L,4L,22L,63L,4202L,4246L,444886L,1161238L,9362914L,26996486L,545614671L,1640386293L,2242930954L,2243031802L,2243065418L,2243115842L,18000691527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072355Inst : IEnumerable<long>
{
public static readonly long[] Value=A072355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072355.Bytes);
public long this[int i]=>Value[i];

public static A072355Inst Instance=new A072355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072354
{
public static readonly long[] Value={ 1L,7L,12L,17L,21L,26L,31L,36L,40L,45L,50L,55L,60L,64L,69L,74L,79L,84L,88L,93L,98L,103L,107L,112L,117L,122L,127L,131L,136L,141L,146L,151L,155L,160L,165L,170L,174L,179L,184L,189L,194L,198L,203L,208L,213L,217L,222L,227L,232L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072354Inst : IEnumerable<long>
{
public static readonly long[] Value=A072354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072354.Bytes);
public long this[int i]=>Value[i];

public static A072354Inst Instance=new A072354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072353
{
public static readonly long[] Value={ 6L,11L,16L,20L,25L,30L,35L,39L,44L,49L,54L,59L,63L,68L,73L,78L,83L,87L,92L,97L,102L,106L,111L,116L,121L,126L,130L,135L,140L,145L,150L,154L,159L,164L,169L,173L,178L,183L,188L,193L,197L,202L,207L,212L,216L,221L,226L,231L,236L,240L,245L,250L,255L,260L,264L,269L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072353Inst : IEnumerable<long>
{
public static readonly long[] Value=A072353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072353.Bytes);
public long this[int i]=>Value[i];

public static A072353Inst Instance=new A072353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072352
{
public static readonly BigInteger[] Value={ 8L,89L,987L,6765L,75025L,832040L,9227465L,63245986L,701408733L,7778742049L,86267571272L,956722026041L,6557470319842L,72723460248141L,806515533049393L,8944394323791464L,99194853094755497L,679891637638612258L,7540113804746346429L,BigInteger.Parse("83621143489848422977") };
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
public class A072352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072352Inst Instance=new A072352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072351
{
public static readonly ulong[] Value={ 1L,13L,144L,1597L,10946L,121393L,1346269L,14930352L,102334155L,1134903170L,12586269025L,139583862445L,1548008755920L,10610209857723L,117669030460994L,1304969544928657L,14472334024676221L,160500643816367088L,1100087778366101931L,12200160415121876738UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072351Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A072351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072351.Bytes);
public ulong this[int i]=>Value[i];

public static A072351Inst Instance=new A072351Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072350
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,225L,3613L,-42997L,8725357L,2116966081L,-549193907111L,-114757574954509L,117893333517545097L,14433599120070484321UL,BigInteger.Parse("-65568697910890921624715"),BigInteger.Parse("2968238619232726100394235"),BigInteger.Parse("86999609037195113208781248165") };
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
public class A072350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072350Inst Instance=new A072350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072349
{
public static readonly long[] Value={ 1L,4L,2L,934L,932L,3L,5L,16L,14L,12L,10L,8L,6L,31L,29L,27L,25L,23L,236L,7L,9L,11L,13L,15L,17L,64L,62L,60L,58L,56L,54L,52L,50L,48L,46L,44L,42L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072349Inst : IEnumerable<long>
{
public static readonly long[] Value=A072349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072349.Bytes);
public long this[int i]=>Value[i];

public static A072349Inst Instance=new A072349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072348
{
public static readonly long[] Value={ 15L,13L,13L,15L,14L,16L,15L,15L,13L,14L,11L,10L,12L,9L,5L,12L,10L,10L,8L,8L,12L,13L,13L,13L,9L,11L,8L,12L,12L,13L,11L,10L,11L,10L,11L,9L,9L,11L,10L,12L,5L,11L,11L,12L,12L,11L,12L,10L,11L,9L,7L,10L,14L,11L,14L,11L,9L,10L,10L,11L,11L,8L,12L,10L,12L,12L,11L,13L,11L,15L,11L,11L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072348Inst : IEnumerable<long>
{
public static readonly long[] Value=A072348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072348.Bytes);
public long this[int i]=>Value[i];

public static A072348Inst Instance=new A072348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072347
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,2L,3L,2L,5L,1L,2L,1L,3L,2L,3L,2L,5L,1L,3L,1L,4L,3L,5L,3L,8L,1L,2L,1L,3L,2L,3L,2L,5L,1L,3L,1L,4L,3L,5L,3L,8L,2L,3L,2L,5L,3L,4L,3L,7L,2L,5L,2L,7L,5L,8L,5L,13L,1L,2L,1L,3L,2L,3L,2L,5L,1L,3L,1L,4L,3L,5L,3L,8L,2L,3L,2L,5L,3L,4L,3L,7L,2L,5L,2L,7L,5L,8L,5L,13L,1L,3L,1L,4L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072347Inst : IEnumerable<long>
{
public static readonly long[] Value=A072347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072347.Bytes);
public long this[int i]=>Value[i];

public static A072347Inst Instance=new A072347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072346
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,15L,6L,105L,24L,945L,120L,10395L,720L,135135L,5040L,2027025L,40320L,34459425L,362880L,654729075L,3628800L,13749310575L,39916800L,316234143225L,479001600L,7905853580625L,6227020800L,213458046676875L,87178291200L,6190283353629375L,1307674368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072346Inst : IEnumerable<long>
{
public static readonly long[] Value=A072346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072346.Bytes);
public long this[int i]=>Value[i];

public static A072346Inst Instance=new A072346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072345
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,8L,1L,16L,1L,32L,1L,64L,1L,128L,1L,256L,1L,512L,1L,1024L,1L,2048L,1L,4096L,1L,8192L,1L,16384L,1L,32768L,1L,65536L,1L,131072L,1L,262144L,1L,524288L,1L,1048576L,1L,2097152L,1L,4194304L,1L,8388608L,1L,16777216L,1L,33554432L,1L,67108864L,1L,134217728L,1L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072345Inst : IEnumerable<long>
{
public static readonly long[] Value=A072345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072345.Bytes);
public long this[int i]=>Value[i];

public static A072345Inst Instance=new A072345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072344
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,2L,3L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,3L,2L,3L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072344Inst : IEnumerable<long>
{
public static readonly long[] Value=A072344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072344.Bytes);
public long this[int i]=>Value[i];

public static A072344Inst Instance=new A072344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072343
{
public static readonly BigInteger[] Value={ 3L,28L,320L,4272L,65632L,1149312L,22712832L,501216000L,12225264128L,326574262272L,9478749110272L,296914161754112L,9979741990993920L,358151267772203008L,13664955628675399680UL,BigInteger.Parse("552220995731872481280") };
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
public class A072343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072343Inst Instance=new A072343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072342
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,2L,2L,10L,2L,2L,6L,8L,2L,6L,1L,1L,1L,3L,1L,1L,5L,1L,1L,3L,2L,4L,2L,2L,4L,2L,2L,4L,2L,4L,1L,2L,3L,3L,2L,2L,3L,2L,4L,3L,2L,2L,4L,2L,4L,6L,2L,2L,12L,2L,1L,1L,2L,1L,1L,2L,1L,3L,2L,1L,4L,6L,4L,4L,6L,4L,4L,6L,4L,4L,2L,1L,1L,5L,2L,1L,2L,1L,1L,2L,2L,10L,2L,2L,4L,12L,2L,4L,2L,2L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072342Inst : IEnumerable<long>
{
public static readonly long[] Value=A072342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072342.Bytes);
public long this[int i]=>Value[i];

public static A072342Inst Instance=new A072342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072341
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,2L,2L,4L,1L,1L,1L,2L,3L,3L,10L,1L,2L,2L,1L,3L,1L,3L,1L,10L,1L,1L,2L,1L,1L,3L,2L,2L,2L,2L,6L,5L,1L,2L,2L,1L,1L,2L,4L,1L,1L,2L,3L,4L,4L,1L,2L,2L,2L,1L,2L,3L,2L,1L,2L,5L,1L,3L,4L,4L,3L,2L,1L,1L,3L,1L,6L,2L,2L,3L,2L,1L,2L,3L,2L,6L,1L,4L,2L,1L,3L,2L,1L,2L,4L,1L,2L,2L,3L,2L,3L,2L,12L,1L,6L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072341Inst : IEnumerable<long>
{
public static readonly long[] Value=A072341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072341.Bytes);
public long this[int i]=>Value[i];

public static A072341Inst Instance=new A072341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072340
{
public static readonly long[] Value={ 0L,2L,6L,0L,1L,1L,0L,5L,2L,0L,3L,2L,0L,1L,1L,0L,2L,4L,0L,3L,4L,0L,1L,1L,0L,22L,7L,0L,2L,5L,0L,1L,1L,0L,7L,2L,0L,4L,2L,0L,1L,1L,0L,2L,5L,0L,13L,9L,0L,1L,1L,0L,3L,3L,0L,2L,3L,0L,1L,1L,0L,3L,2L,0L,5L,2L,0L,1L,1L,0L,2L,3L,0L,8L,3L,0L,1L,1L,0L,5L,4L,0L,2L,4L,0L,1L,1L,0L,14L,2L,0L,3L,2L,0L,1L,1L,0L,2L,9L,0L,3L,9L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072340Inst : IEnumerable<long>
{
public static readonly long[] Value=A072340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072340.Bytes);
public long this[int i]=>Value[i];

public static A072340Inst Instance=new A072340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072339
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,3L,3L,4L,2L,3L,2L,2L,1L,3L,3L,4L,3L,5L,4L,4L,2L,3L,3L,4L,2L,3L,2L,2L,1L,3L,3L,4L,3L,5L,4L,4L,3L,5L,5L,6L,4L,5L,4L,4L,2L,3L,3L,4L,3L,5L,4L,4L,2L,3L,3L,4L,2L,3L,2L,2L,1L,3L,3L,4L,3L,5L,4L,4L,3L,5L,5L,6L,4L,5L,4L,4L,3L,5L,5L,6L,5L,7L,6L,6L,4L,5L,5L,6L,4L,5L,4L,4L,2L,3L,3L,4L,3L,5L,4L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072339Inst : IEnumerable<long>
{
public static readonly long[] Value=A072339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072339.Bytes);
public long this[int i]=>Value[i];

public static A072339Inst Instance=new A072339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072338
{
public static readonly long[] Value={ 1L,2L,7L,18L,48L,114L,273L,614L,1370L,2952L,6275L,13034L,26725L,53854L,107238L,210670L,409446L,786936L,1498147L,2825084L,5282409L,9795620L,18027645L,32935112L,59760481L,107724038L,192984835L,343676216L,608589028L,1071869694L,1878068324L,3274291480L,5681336242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072338Inst : IEnumerable<long>
{
public static readonly long[] Value=A072338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072338.Bytes);
public long this[int i]=>Value[i];

public static A072338Inst Instance=new A072338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072337
{
public static readonly long[] Value={ 1L,3L,3L,5L,10L,24L,50L,120L,270L,640L,1500L,3600L,8610L,20880L,50700L,124024L,304290L,750120L,1854400L,4600200L,11440548L,28527320L,71289000L,178526880L,447910470L,1125750120L,2833885800L,7144449920L,18036373140L,45591631800L,115381697740L,292329067800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072337Inst : IEnumerable<long>
{
public static readonly long[] Value=A072337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072337.Bytes);
public long this[int i]=>Value[i];

public static A072337Inst Instance=new A072337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072336
{
public static readonly long[] Value={ 1L,3L,15L,61L,250L,966L,3691L,13708L,50198L,180756L,642883L,2259194L,7859454L,27086808L,92579267L,314011481L,1057679231L,3539727315L,11776328715L,38963355007L,128255099092L,420155031109L,1370225125574L,4449779889260L,14393128980829L,46380744221539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072336Inst : IEnumerable<long>
{
public static readonly long[] Value=A072336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072336.Bytes);
public long this[int i]=>Value[i];

public static A072336Inst Instance=new A072336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072335
{
public static readonly long[] Value={ 1L,4L,16L,60L,225L,840L,3136L,11704L,43681L,163020L,608400L,2270580L,8473921L,31625104L,118026496L,440480880L,1643897025L,6135107220L,22896531856L,85451020204L,318907548961L,1190179175640L,4441809153600L,16577057438760L,61866420601441L,230888624967004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072335Inst : IEnumerable<long>
{
public static readonly long[] Value=A072335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072335.Bytes);
public long this[int i]=>Value[i];

public static A072335Inst Instance=new A072335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072334
{
public static readonly long[] Value={ 7L,3L,8L,9L,0L,5L,6L,0L,9L,8L,9L,3L,0L,6L,5L,0L,2L,2L,7L,2L,3L,0L,4L,2L,7L,4L,6L,0L,5L,7L,5L,0L,0L,7L,8L,1L,3L,1L,8L,0L,3L,1L,5L,5L,7L,0L,5L,5L,1L,8L,4L,7L,3L,2L,4L,0L,8L,7L,1L,2L,7L,8L,2L,2L,5L,2L,2L,5L,7L,3L,7L,9L,6L,0L,7L,9L,0L,5L,7L,7L,6L,3L,3L,8L,4L,3L,1L,2L,4L,8L,5L,0L,7L,9L,1L,2L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072334Inst : IEnumerable<long>
{
public static readonly long[] Value=A072334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072334.Bytes);
public long this[int i]=>Value[i];

public static A072334Inst Instance=new A072334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072333
{
public static readonly long[] Value={ 1L,5L,16L,36L,69L,116L,183L,270L,382L,521L,690L,893L,1132L,1411L,1731L,2097L,2512L,2978L,3498L,4075L,4713L,5414L,6182L,7018L,7927L,8912L,9975L,11119L,12347L,13663L,15069L,16569L,18164L,19859L,21657L,23560L,25571L,27693L,29930L,32284L,34759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072333Inst : IEnumerable<long>
{
public static readonly long[] Value=A072333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072333.Bytes);
public long this[int i]=>Value[i];

public static A072333Inst Instance=new A072333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072332
{
public static readonly long[] Value={ 1L,5L,17L,38L,73L,126L,199L,296L,420L,576L,765L,992L,1261L,1574L,1935L,2348L,2815L,3341L,3928L,4581L,5302L,6096L,6964L,7912L,8942L,10058L,11262L,12560L,13954L,15447L,17042L,18745L,20557L,22482L,24524L,26686L,28971L,31383L,33926L,36602L,39416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072332Inst : IEnumerable<long>
{
public static readonly long[] Value=A072332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072332.Bytes);
public long this[int i]=>Value[i];

public static A072332Inst Instance=new A072332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072331
{
public static readonly BigInteger[] Value={ 3L,38L,772L,21768L,786736L,34703456L,1807726656L,108602413184L,7392195003136L,562241229891072L,47257832090862592L,4349969517278922752L,BigInteger.Parse("435185983056255725568"),BigInteger.Parse("47017486048144734052352") };
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
public class A072331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072331Inst Instance=new A072331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072330
{
public static readonly long[] Value={ 1L,11L,13L,23L,37L,47L,59L,61L,71L,73L,83L,97L,107L,109L,121L,131L,143L,157L,167L,169L,179L,181L,191L,193L,227L,229L,239L,241L,251L,253L,263L,277L,299L,311L,313L,337L,347L,349L,359L,373L,383L,397L,407L,409L,419L,421L,431L,433L,443L,457L,467L,479L,481L,491L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072330Inst : IEnumerable<long>
{
public static readonly long[] Value=A072330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072330.Bytes);
public long this[int i]=>Value[i];

public static A072330Inst Instance=new A072330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072329
{
public static readonly long[] Value={ 3L,0L,4L,9L,8L,30L,43L,84L,176L,297L,604L,1122L,2099L,4056L,7564L,14409L,27296L,51510L,97819L,184908L,350168L,663273L,1255060L,2377050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072329Inst : IEnumerable<long>
{
public static readonly long[] Value=A072329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072329.Bytes);
public long this[int i]=>Value[i];

public static A072329Inst Instance=new A072329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072328
{
public static readonly long[] Value={ 3L,0L,2L,6L,2L,10L,14L,14L,34L,42L,62L,110L,146L,234L,366L,526L,834L,1258L,1886L,2926L,4402L,6698L,10254L,15502L,23650L,36010L,54654L,83310L,126674L,192618L,293294L,445966L,678530L,1032554L,1570462L,2389614L,3635570L,5530538L,8414798L,12801678L,19475874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072328Inst : IEnumerable<long>
{
public static readonly long[] Value=A072328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072328.Bytes);
public long this[int i]=>Value[i];

public static A072328Inst Instance=new A072328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072327
{
public static readonly long[] Value={ 1L,8L,12L,27L,32L,45L,63L,125L,175L,225L,243L,275L,325L,343L,425L,475L,539L,560L,575L,637L,720L,833L,931L,1127L,1225L,1331L,1421L,1519L,1573L,1813L,2009L,2057L,2107L,2197L,2240L,2299L,2303L,2783L,2816L,2873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072327Inst : IEnumerable<long>
{
public static readonly long[] Value=A072327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072327.Bytes);
public long this[int i]=>Value[i];

public static A072327Inst Instance=new A072327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072326
{
public static readonly long[] Value={ 42L,78L,84L,114L,126L,156L,168L,174L,186L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072326Inst : IEnumerable<long>
{
public static readonly long[] Value=A072326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072326.Bytes);
public long this[int i]=>Value[i];

public static A072326Inst Instance=new A072326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072325
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,2L,2L,2L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,2L,2L,2L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072325Inst : IEnumerable<long>
{
public static readonly long[] Value=A072325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072325.Bytes);
public long this[int i]=>Value[i];

public static A072325Inst Instance=new A072325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072324
{
public static readonly long[] Value={ 5L,25L,325L,27625L,801125L,29641625L,1215306625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072324Inst : IEnumerable<long>
{
public static readonly long[] Value=A072324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072324.Bytes);
public long this[int i]=>Value[i];

public static A072324Inst Instance=new A072324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072307
{
public static readonly long[] Value={ 4L,13L,43L,73L,117L,141L,113L,192L,185L,217L,264L,290L,427L,367L,517L,526L,519L,530L,692L,628L,684L,588L,720L,795L,786L,793L,736L,910L,1004L,1009L,946L,1054L,1330L,1087L,1135L,1134L,1172L,1253L,1299L,1193L,1406L,1502L,1552L,1321L,1377L,1829L,1683L,1731L,1582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072307Inst : IEnumerable<long>
{
public static readonly long[] Value=A072307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072307.Bytes);
public long this[int i]=>Value[i];

public static A072307Inst Instance=new A072307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072306
{
public static readonly long[] Value={ 3L,29L,50L,79L,104L,168L,174L,147L,190L,252L,243L,268L,448L,456L,492L,495L,442L,581L,496L,587L,535L,567L,728L,795L,707L,801L,770L,907L,857L,1053L,1062L,1061L,1146L,911L,1209L,1280L,1368L,1440L,1358L,1322L,1395L,1505L,1559L,1325L,1575L,1571L,1731L,1617L,1676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072306Inst : IEnumerable<long>
{
public static readonly long[] Value=A072306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072306.Bytes);
public long this[int i]=>Value[i];

public static A072306Inst Instance=new A072306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072305
{
public static readonly long[] Value={ 1L,19L,22L,71L,82L,118L,119L,200L,241L,218L,271L,350L,377L,362L,419L,473L,544L,578L,562L,753L,622L,682L,687L,844L,775L,746L,830L,745L,908L,1012L,922L,979L,1141L,1227L,1201L,1161L,1179L,1273L,1396L,1190L,1415L,1314L,1369L,1486L,1507L,1531L,1667L,1867L,1714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072305Inst : IEnumerable<long>
{
public static readonly long[] Value=A072305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072305.Bytes);
public long this[int i]=>Value[i];

public static A072305Inst Instance=new A072305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072304
{
public static readonly long[] Value={ 15L,30L,51L,84L,91L,129L,170L,187L,140L,210L,295L,315L,384L,308L,367L,534L,466L,517L,525L,655L,639L,675L,723L,766L,765L,894L,650L,792L,1009L,801L,1021L,942L,1107L,1126L,1355L,1144L,1433L,1375L,1350L,1259L,1491L,1383L,1666L,1689L,1738L,1679L,1808L,1725L,1786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072304Inst : IEnumerable<long>
{
public static readonly long[] Value=A072304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072304.Bytes);
public long this[int i]=>Value[i];

public static A072304Inst Instance=new A072304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072303
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,16L,17L,18L,19L,21L,23L,24L,25L,27L,28L,29L,31L,32L,36L,37L,41L,43L,47L,48L,49L,53L,54L,59L,61L,64L,67L,71L,72L,73L,79L,81L,83L,89L,96L,97L,101L,103L,107L,108L,109L,112L,113L,121L,125L,127L,128L,131L,137L,139L,144L,149L,151L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072303Inst : IEnumerable<long>
{
public static readonly long[] Value=A072303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072303.Bytes);
public long this[int i]=>Value[i];

public static A072303Inst Instance=new A072303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072302
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,4L,3L,5L,5L,6L,5L,5L,8L,8L,9L,6L,7L,10L,7L,9L,11L,12L,10L,9L,9L,9L,13L,15L,9L,16L,14L,17L,12L,12L,13L,13L,13L,20L,17L,14L,13L,18L,15L,21L,23L,24L,14L,20L,26L,17L,25L,18L,22L,19L,19L,25L,29L,30L,17L,17L,21L,32L,22L,26L,21L,34L,32L,23L,25L,24L,25L,25L,30L,25L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072302Inst : IEnumerable<long>
{
public static readonly long[] Value=A072302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072302.Bytes);
public long this[int i]=>Value[i];

public static A072302Inst Instance=new A072302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072301
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,4L,5L,9L,3L,4L,5L,6L,5L,5L,16L,6L,11L,8L,6L,11L,7L,8L,7L,25L,8L,11L,12L,8L,10L,16L,19L,11L,11L,12L,29L,18L,10L,17L,10L,12L,14L,20L,13L,14L,15L,16L,23L,31L,33L,17L,22L,18L,15L,19L,15L,23L,15L,16L,17L,30L,21L,30L,64L,19L,22L,32L,20L,23L,23L,24L,35L,36L,24L,37L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072301Inst : IEnumerable<long>
{
public static readonly long[] Value=A072301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072301.Bytes);
public long this[int i]=>Value[i];

public static A072301Inst Instance=new A072301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072300
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,6L,10L,10L,7L,13L,14L,10L,16L,17L,12L,16L,10L,7L,10L,12L,7L,12L,13L,9L,14L,14L,20L,29L,31L,20L,34L,35L,20L,37L,38L,25L,20L,18L,14L,21L,20L,15L,23L,23L,14L,24L,40L,27L,42L,37L,29L,40L,41L,30L,44L,45L,20L,31L,29L,21L,31L,28L,20L,32L,33L,23L,60L,67L,48L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072300Inst : IEnumerable<long>
{
public static readonly long[] Value=A072300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072300.Bytes);
public long this[int i]=>Value[i];

public static A072300Inst Instance=new A072300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072299
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,20L,30L,50L,70L,101L,110L,131L,151L,181L,191L,200L,300L,313L,353L,373L,383L,500L,700L,727L,757L,787L,797L,919L,929L,1010L,1100L,1310L,1510L,1810L,1910L,2000L,3000L,3130L,3530L,3730L,3830L,5000L,7000L,7270L,7570L,7870L,7970L,9190L,9290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072299Inst : IEnumerable<long>
{
public static readonly long[] Value=A072299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072299.Bytes);
public long this[int i]=>Value[i];

public static A072299Inst Instance=new A072299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072298
{
public static readonly long[] Value={ 2L,3L,6L,5L,3L,7L,4L,12L,5L,11L,7L,13L,7L,5L,62L,17L,12L,19L,5L,7L,11L,23L,4L,30L,13L,39L,7L,29L,5L,31L,37L,11L,17L,7L,12L,37L,19L,13L,5L,41L,7L,43L,11L,23L,23L,47L,62L,56L,30L,17L,13L,53L,39L,11L,7L,19L,29L,59L,5L,61L,31L,7L,84L,13L,11L,67L,17L,23L,7L,71L,12L,73L,37L,30L,19L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072298Inst : IEnumerable<long>
{
public static readonly long[] Value=A072298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072298.Bytes);
public long this[int i]=>Value[i];

public static A072298Inst Instance=new A072298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072297
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,6L,10L,23L,48L,99L,194L,392L,791L,1600L,3290L,6810L,13900L,28269L,57455L,116213L,234237L,470861L,945510L,1897007L,3802257L,7616206L,15244011L,30493702L,60965480L,121838430L,243409121L,486131077L,970680425L,1937876841L,3868346975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072297Inst : IEnumerable<long>
{
public static readonly long[] Value=A072297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072297.Bytes);
public long this[int i]=>Value[i];

public static A072297Inst Instance=new A072297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072296
{
public static readonly long[] Value={ 10L,50L,532L,2314L,4628L,22578L,115024L,221960L,478302L,3340304L,22527850L,117335136L,1118736102L,1564578508L,6121287812L,7515991946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072296Inst : IEnumerable<long>
{
public static readonly long[] Value=A072296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072296.Bytes);
public long this[int i]=>Value[i];

public static A072296Inst Instance=new A072296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072295
{
public static readonly BigInteger[] Value={ 1L,87178291200L,121645100408832000L,BigInteger.Parse("15511210043330985984000000"),BigInteger.Parse("263130836933693530167218012160000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000") };
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
public class A072295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072295Inst Instance=new A072295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072294
{
public static readonly long[] Value={ 6L,12L,12L,30L,60L,24L,84L,36L,60L,120L,66L,42L,84L,126L,60L,90L,84L,168L,36L,204L,210L,210L,60L,120L,132L,72L,84L,252L,360L,114L,156L,180L,210L,420L,120L,210L,420L,168L,420L,240L,468L,126L,180L,336L,360L,420L,264L,330L,252L,168L,504L,420L,780L,420L,306L,456L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072294Inst : IEnumerable<long>
{
public static readonly long[] Value=A072294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072294.Bytes);
public long this[int i]=>Value[i];

public static A072294Inst Instance=new A072294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072293
{
public static readonly BigInteger[] Value={ 2L,87178291200L,6227020800L,BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000"),BigInteger.Parse("258623241511168180642964355153611979969197632389120000000000") };
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
public class A072293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072293Inst Instance=new A072293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072292
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072292Inst : IEnumerable<long>
{
public static readonly long[] Value=A072292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072292.Bytes);
public long this[int i]=>Value[i];

public static A072292Inst Instance=new A072292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072275
{
public static readonly long[] Value={ 2L,3L,4L,7L,6L,0L,11L,12L,30L,0L,18L,0L,44L,79L,47L,0L,42L,0L,53L,106L,1581L,0L,82L,211L,1470L,595L,319L,0L,169L,0L,216L,2819L,177975L,279L,0L,62947L,41203L,326L,0L,647L,0L,1795L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072275Inst : IEnumerable<long>
{
public static readonly long[] Value=A072275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072275.Bytes);
public long this[int i]=>Value[i];

public static A072275Inst Instance=new A072275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072274
{
public static readonly long[] Value={ 1913L,1931L,18379L,18397L,19013L,19031L,25013L,25031L,34613L,34631L,35617L,35671L,35879L,35897L,36979L,36997L,37379L,37397L,37813L,37831L,40013L,40031L,40213L,40231L,40639L,40693L,45613L,45631L,48091L,48109L,49279L,49297L,51613L,51631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072274Inst : IEnumerable<long>
{
public static readonly long[] Value=A072274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072274.Bytes);
public long this[int i]=>Value[i];

public static A072274Inst Instance=new A072274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072273
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,3L,1L,2L,1L,2L,2L,1L,1L,3L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,3L,1L,1L,2L,2L,2L,2L,1L,3L,1L,1L,1L,3L,2L,1L,2L,3L,1L,2L,2L,2L,2L,1L,2L,3L,1L,1L,2L,2L,1L,2L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072273Inst : IEnumerable<long>
{
public static readonly long[] Value=A072273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072273.Bytes);
public long this[int i]=>Value[i];

public static A072273Inst Instance=new A072273Inst();

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