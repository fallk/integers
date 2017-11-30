using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136858
{
public static readonly long[] Value={ 0L,1L,10L,100L,951L,1000L,1049L,9510L,10000L,10490L,95100L,99499L,99501L,100000L,100499L,100501L,100549L,100951L,104451L,104900L,105549L,951000L,951549L,994990L,995010L,1000000L,1004990L,1005010L,1005490L,1009510L,1044510L,1049000L,1055490L,9510000L,9515490L,9949900L,9950100L,9994999L,9995001L,10000000L,10004999L,10005001L,10005951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136858Inst : IEnumerable<long>
{
public static readonly long[] Value=A136858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136858.Bytes);
public long this[int i]=>Value[i];

public static A136858Inst Instance=new A136858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136859
{
public static readonly long[] Value={ 0L,1L,4L,10L,40L,100L,400L,1000L,4000L,10000L,40000L,100000L,400000L,1000000L,4000000L,10000000L,40000000L,100000000L,400000000L,1000000000L,4000000000L,10000000000L,40000000000L,100000000000L,400000000000L,1000000000000L,4000000000000L,10000000000000L,40000000000000L,100000000000000L,400000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136859Inst : IEnumerable<long>
{
public static readonly long[] Value=A136859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136859.Bytes);
public long this[int i]=>Value[i];

public static A136859Inst Instance=new A136859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136860
{
public static readonly long[] Value={ 0L,1L,4L,10L,40L,100L,400L,1000L,1071L,4000L,7776L,10000L,10710L,10771L,40000L,77760L,100000L,106771L,106776L,107100L,107710L,400000L,777600L,1000000L,1007046L,1067710L,1067760L,1071000L,1077100L,1077776L,4000000L,6406771L,7771774L,7776000L,10000000L,10070460L,10677100L,10677600L,10710000L,10771000L,10777760L,40000000L,64067710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136860Inst : IEnumerable<long>
{
public static readonly long[] Value=A136860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136860.Bytes);
public long this[int i]=>Value[i];

public static A136860Inst Instance=new A136860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136861
{
public static readonly long[] Value={ 0L,1L,4L,8L,10L,40L,41L,80L,100L,104L,108L,400L,401L,408L,410L,641L,800L,801L,804L,1000L,1004L,1008L,1040L,1080L,4000L,4001L,4008L,4010L,4080L,4100L,6410L,6441L,8000L,8001L,8004L,8010L,8040L,10000L,10004L,10008L,10040L,10080L,10400L,10401L,10800L,10801L,40000L,40001L,40008L,40010L,40080L,40100L,40604L,40800L,41000L,64100L,64410L,66441L,80000L,80001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136861Inst : IEnumerable<long>
{
public static readonly long[] Value=A136861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136861.Bytes);
public long this[int i]=>Value[i];

public static A136861Inst Instance=new A136861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136862
{
public static readonly long[] Value={ 0L,1L,4L,10L,14L,40L,64L,100L,119L,140L,400L,640L,949L,1000L,1046L,1049L,1190L,1400L,4000L,4119L,6400L,9490L,10000L,10199L,10460L,10490L,10496L,10696L,11900L,14000L,40000L,40499L,40614L,41190L,44114L,64000L,64064L,64114L,94900L,94969L,100000L,100449L,100469L,100496L,100499L,100946L,101990L,104496L,104600L,104900L,104960L,106960L,119000L,140000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136862Inst : IEnumerable<long>
{
public static readonly long[] Value=A136862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136862.Bytes);
public long this[int i]=>Value[i];

public static A136862Inst Instance=new A136862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136863
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,1071L,10000L,10710L,100000L,107100L,1000000L,1071000L,10000000L,10710000L,100000000L,107100000L,1000000000L,1071000000L,10000000000L,10710000000L,100000000000L,107100000000L,1000000000000L,1071000000000L,10000000000000L,10710000000000L,100000000000000L,107100000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136863Inst : IEnumerable<long>
{
public static readonly long[] Value=A136863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136863.Bytes);
public long this[int i]=>Value[i];

public static A136863Inst Instance=new A136863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136864
{
public static readonly long[] Value={ 0L,1L,10L,88L,100L,878L,880L,1000L,1071L,4141L,8780L,8800L,8878L,10000L,10401L,10710L,41410L,87800L,88000L,88780L,100000L,104010L,107100L,108848L,414100L,878000L,880000L,887800L,1000000L,1004001L,1008701L,1040100L,1071000L,1088480L,1187478L,4141000L,8418441L,8478448L,8780000L,8784878L,8800000L,8878000L,10000000L,10007401L,10040010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136864Inst : IEnumerable<long>
{
public static readonly long[] Value=A136864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136864.Bytes);
public long this[int i]=>Value[i];

public static A136864Inst Instance=new A136864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136865
{
public static readonly long[] Value={ 0L,1L,7L,10L,70L,97L,100L,107L,700L,701L,970L,997L,1000L,1007L,1049L,1070L,1071L,7000L,7001L,7010L,7071L,9700L,9701L,9970L,9997L,10000L,10007L,10070L,10097L,10490L,10700L,10710L,14107L,70000L,70001L,70010L,70100L,70107L,70499L,70710L,97000L,97001L,97010L,99700L,99970L,99997L,100000L,100007L,100070L,100097L,100499L,100700L,100970L,104900L,107000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136865Inst : IEnumerable<long>
{
public static readonly long[] Value=A136865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136865.Bytes);
public long this[int i]=>Value[i];

public static A136865Inst Instance=new A136865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136866
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,10401L,100000L,104010L,1000000L,1004001L,1040100L,10000000L,10040010L,10401000L,100000000L,100040001L,100400100L,104010000L,1000000000L,1000400010L,1004001000L,1040100000L,10000000000L,10000400001L,10004000100L,10040010000L,10401000000L,100000000000L,100004000010L,100040001000L,100400100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136866Inst : IEnumerable<long>
{
public static readonly long[] Value=A136866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136866.Bytes);
public long this[int i]=>Value[i];

public static A136866Inst Instance=new A136866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136867
{
public static readonly long[] Value={ 0L,1L,9L,10L,90L,99L,100L,109L,141L,441L,900L,901L,990L,999L,1000L,1009L,1049L,1090L,1191L,1410L,4410L,9000L,9001L,9010L,9049L,9900L,9990L,9999L,10000L,10009L,10090L,10099L,10401L,10441L,10488L,10490L,10900L,11910L,14100L,44100L,90000L,90001L,90010L,90100L,90490L,90498L,99000L,99001L,99900L,99990L,99999L,100000L,100009L,100090L,100099L,100491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136867Inst : IEnumerable<long>
{
public static readonly long[] Value=A136867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136867.Bytes);
public long this[int i]=>Value[i];

public static A136867Inst Instance=new A136867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136868
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,2L,4L,1L,0L,1L,2L,6L,7L,1L,0L,1L,2L,6L,14L,12L,1L,0L,1L,2L,6L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136868Inst : IEnumerable<long>
{
public static readonly long[] Value=A136868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136868.Bytes);
public long this[int i]=>Value[i];

public static A136868Inst Instance=new A136868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136869
{
public static readonly long[] Value={ 0L,1L,10L,76L,100L,760L,1000L,1076L,7551L,7600L,10000L,10760L,75510L,76000L,100000L,107600L,107776L,707501L,751666L,755100L,760000L,1000000L,1005076L,1076000L,1077551L,1077760L,1077776L,7075010L,7177051L,7516660L,7551000L,7557551L,7600000L,10000000L,10007551L,10050760L,10760000L,10775510L,10777551L,10777600L,10777760L,70750100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136869Inst : IEnumerable<long>
{
public static readonly long[] Value=A136869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136869.Bytes);
public long this[int i]=>Value[i];

public static A136869Inst Instance=new A136869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136870
{
public static readonly long[] Value={ 0L,1L,10L,81L,100L,810L,816L,1000L,1081L,8100L,8160L,10000L,10801L,10810L,81000L,81551L,81600L,81651L,100000L,108010L,108100L,810000L,815510L,815881L,816000L,816510L,1000000L,1008001L,1008051L,1080100L,1081000L,8100000L,8155100L,8158810L,8160000L,8165100L,10000000L,10080010L,10080510L,10568151L,10801000L,10810000L,81000000L,81551000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136870Inst : IEnumerable<long>
{
public static readonly long[] Value=A136870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136870.Bytes);
public long this[int i]=>Value[i];

public static A136870Inst Instance=new A136870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136871
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,10916L,100000L,109119L,109160L,956619L,1000000L,1091190L,1091600L,9566190L,9569199L,9959501L,10000000L,10911900L,10916000L,95661699L,95661900L,95691990L,99595010L,100000000L,109091666L,109119000L,109160000L,956616990L,956619000L,956919900L,995950100L,1000000000L,1056690916L,1090916660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136871Inst : IEnumerable<long>
{
public static readonly long[] Value=A136871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136871.Bytes);
public long this[int i]=>Value[i];

public static A136871Inst Instance=new A136871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136920
{
public static readonly long[] Value={ 0L,5L,50L,95L,500L,505L,950L,995L,5000L,5005L,5050L,5095L,9500L,9950L,9995L,50000L,50005L,50050L,50095L,50500L,50950L,95000L,95005L,99500L,99950L,99995L,500000L,500005L,500050L,500095L,500500L,500505L,500950L,500995L,502005L,505000L,509500L,950000L,950005L,950050L,995000L,999500L,999950L,999995L,5000000L,5000005L,5000050L,5000095L,5000500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136920Inst : IEnumerable<long>
{
public static readonly long[] Value=A136920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136920.Bytes);
public long this[int i]=>Value[i];

public static A136920Inst Instance=new A136920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136921
{
public static readonly long[] Value={ 0L,26L,260L,2600L,26000L,260000L,2600000L,26000000L,260000000L,2600000000L,26000000000L,260000000000L,2600000000000L,26000000000000L,260000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136921Inst : IEnumerable<long>
{
public static readonly long[] Value=A136921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136921.Bytes);
public long this[int i]=>Value[i];

public static A136921Inst Instance=new A136921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136922
{
public static readonly long[] Value={ 0L,26L,260L,826L,2600L,8226L,8260L,26000L,82260L,82600L,260000L,280726L,822600L,826000L,2600000L,2767826L,2807260L,7786026L,8226000L,8260000L,26000000L,27678260L,28072600L,28686026L,77860260L,82260000L,82600000L,88672826L,260000000L,276782600L,277288226L,280726000L,286860260L,778602600L,787786026L,820260826L,822600000L,826000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136922Inst : IEnumerable<long>
{
public static readonly long[] Value=A136922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136922.Bytes);
public long this[int i]=>Value[i];

public static A136922Inst Instance=new A136922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136923
{
public static readonly long[] Value={ 0L,26L,27L,260L,270L,277L,2600L,2700L,2770L,26000L,27000L,27700L,96026L,96277L,260000L,266077L,269777L,270000L,277000L,960260L,962770L,996026L,2600000L,2660770L,2696277L,2697770L,2700000L,2770000L,9602600L,9627700L,9960260L,26000000L,26607700L,26962770L,26977700L,27000000L,27700000L,27706077L,96026000L,96276726L,96277000L,99602600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136923Inst : IEnumerable<long>
{
public static readonly long[] Value=A136923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136923.Bytes);
public long this[int i]=>Value[i];

public static A136923Inst Instance=new A136923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136924
{
public static readonly long[] Value={ 0L,928886L,9288860L,92888600L,896096886L,909296886L,928886000L,990292886L,996096886L,8960968860L,9088982886L,9092968860L,9288860000L,9902928860L,9960968860L,89609688600L,90889828860L,90929688600L,92888600000L,99029288600L,99609688600L,896096886000L,898999982886L,908898288600L,909296886000L,928886000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136924Inst : IEnumerable<long>
{
public static readonly long[] Value=A136924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136924.Bytes);
public long this[int i]=>Value[i];

public static A136924Inst Instance=new A136924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136925
{
public static readonly long[] Value={ 0L,27L,270L,297L,2700L,2970L,2997L,27000L,28297L,29700L,29970L,29997L,88277L,270000L,282970L,297000L,298027L,299700L,299970L,299997L,882770L,2700000L,2787997L,2829700L,2970000L,2980270L,2997000L,2999700L,2999970L,2999997L,8827700L,9888277L,27000000L,27879970L,27980297L,28297000L,28299827L,29700000L,29802700L,29970000L,29997000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136925Inst : IEnumerable<long>
{
public static readonly long[] Value=A136925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136925.Bytes);
public long this[int i]=>Value[i];

public static A136925Inst Instance=new A136925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136926
{
public static readonly long[] Value={ 0L,27L,270L,2700L,27000L,270000L,2700000L,27000000L,270000000L,2700000000L,27000000000L,270000000000L,2700000000000L,27000000000000L,270000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136926Inst : IEnumerable<long>
{
public static readonly long[] Value=A136926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136926.Bytes);
public long this[int i]=>Value[i];

public static A136926Inst Instance=new A136926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136927
{
public static readonly long[] Value={ 0L,6L,60L,66L,600L,656L,660L,666L,6000L,6560L,6600L,6660L,6666L,60000L,63566L,65600L,66000L,66600L,66660L,66666L,600000L,603656L,604434L,635660L,656000L,660000L,660656L,666000L,666600L,666660L,666666L,6000000L,6036560L,6044340L,6356600L,6560000L,6600000L,6606560L,6660000L,6666000L,6666600L,6666660L,6666666L,60000000L,60054434L,60365600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136927Inst : IEnumerable<long>
{
public static readonly long[] Value=A136927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136927.Bytes);
public long this[int i]=>Value[i];

public static A136927Inst Instance=new A136927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136928
{
public static readonly long[] Value={ 0L,548L,5480L,54800L,55548L,548000L,555388L,555480L,588048L,5480000L,5553880L,5554548L,5554800L,5834388L,5880480L,54800000L,55538800L,55545480L,55548000L,58343880L,58804800L,548000000L,550500548L,555388000L,555454800L,555480000L,583438800L,588048000L,5480000000L,5505005480L,5553880000L,5554548000L,5554800000L,5834388000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136928Inst : IEnumerable<long>
{
public static readonly long[] Value=A136928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136928.Bytes);
public long this[int i]=>Value[i];

public static A136928Inst Instance=new A136928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136929
{
public static readonly long[] Value={ 0L,3L,30L,300L,3000L,30000L,30503L,30903L,300000L,305030L,309030L,550503L,950503L,953903L,3000000L,3005003L,3009003L,3050300L,3055003L,3090300L,5505030L,9505030L,9539030L,30000000L,30050030L,30090030L,30503000L,30550030L,30903000L,55050300L,95050300L,95055003L,95390300L,300000000L,300050003L,300050503L,300090003L,300500300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136929Inst : IEnumerable<long>
{
public static readonly long[] Value=A136929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136929.Bytes);
public long this[int i]=>Value[i];

public static A136929Inst Instance=new A136929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136930
{
public static readonly long[] Value={ 0L,6L,60L,600L,6000L,60000L,66076L,600000L,660760L,6000000L,6607600L,60000000L,60003706L,60036706L,66036076L,66066376L,66076000L,600000000L,600037060L,600306344L,600367060L,600373006L,606336074L,660360760L,660663760L,660760000L,660760474L,6000000000L,6000036706L,6000370600L,6000637006L,6003063440L,6003670600L,6003730060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136930Inst : IEnumerable<long>
{
public static readonly long[] Value=A136930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136930.Bytes);
public long this[int i]=>Value[i];

public static A136930Inst Instance=new A136930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136931
{
public static readonly long[] Value={ 0L,6L,8L,60L,80L,600L,800L,6000L,6638L,6808L,6844L,8000L,60000L,60406L,60688L,66380L,66808L,68080L,68440L,80000L,600000L,604060L,606880L,663800L,668080L,680800L,684400L,800000L,6000000L,6003406L,6004006L,6040600L,6068800L,6638000L,6680800L,6808000L,6844000L,8000000L,60000000L,60034060L,60040060L,60406000L,60688000L,66363008L,66380000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136931Inst : IEnumerable<long>
{
public static readonly long[] Value=A136931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136931.Bytes);
public long this[int i]=>Value[i];

public static A136931Inst Instance=new A136931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136932
{
public static readonly long[] Value={ 0L,3L,6L,30L,60L,63L,64L,300L,306L,600L,603L,630L,636L,640L,3000L,3006L,3060L,6000L,6003L,6030L,6300L,6360L,6400L,6636L,30000L,30006L,30060L,30600L,60000L,60003L,60030L,60300L,63000L,63600L,64000L,66360L,300000L,300006L,300060L,300600L,306000L,600000L,600003L,600030L,600300L,603000L,630000L,636000L,640000L,663600L,949003L,3000000L,3000006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136932Inst : IEnumerable<long>
{
public static readonly long[] Value=A136932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136932.Bytes);
public long this[int i]=>Value[i];

public static A136932Inst Instance=new A136932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136933
{
public static readonly long[] Value={ 0L,88L,878L,880L,8780L,8800L,87800L,88000L,878000L,880000L,8387078L,8780000L,8800000L,83870780L,87800000L,88000000L,838707800L,878000000L,880000000L,8387078000L,8780000000L,8800000000L,8833878448L,83870780000L,87774340088L,87800000000L,88000000000L,88004400088L,88338784480L,838707800000L,877743400880L,878000000000L,880000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136933Inst : IEnumerable<long>
{
public static readonly long[] Value=A136933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136933.Bytes);
public long this[int i]=>Value[i];

public static A136933Inst Instance=new A136933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136934
{
public static readonly long[] Value={ 0L,3L,7L,30L,70L,97L,300L,700L,970L,997L,3000L,7000L,9700L,9970L,9997L,30000L,70000L,97000L,99700L,99970L,99997L,300000L,700000L,970000L,997000L,999700L,999970L,999997L,3000000L,3074003L,7000000L,9700000L,9970000L,9997000L,9999700L,9999970L,9999997L,30000000L,30740030L,70000000L,97000000L,99700000L,99970000L,99997000L,99999700L,99999970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136934Inst : IEnumerable<long>
{
public static readonly long[] Value=A136934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136934.Bytes);
public long this[int i]=>Value[i];

public static A136934Inst Instance=new A136934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136935
{
public static readonly long[] Value={ 0L,3L,30L,300L,3000L,30000L,89938L,300000L,308043L,899380L,899938L,939938L,940393L,940398L,943043L,943898L,3000000L,3080430L,8993333L,8993800L,8993933L,8999083L,8999380L,8999938L,9399380L,9403930L,9403980L,9430430L,9438980L,30000000L,30080393L,30080398L,30803903L,30804300L,89908003L,89933330L,89933333L,89938000L,89939330L,89990830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136935Inst : IEnumerable<long>
{
public static readonly long[] Value=A136935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136935.Bytes);
public long this[int i]=>Value[i];

public static A136935Inst Instance=new A136935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137240
{
public static readonly long[] Value={ 5L,4L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137240Inst : IEnumerable<long>
{
public static readonly long[] Value=A137240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137240.Bytes);
public long this[int i]=>Value[i];

public static A137240Inst Instance=new A137240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137241
{
public static readonly long[] Value={ 0L,3L,2L,1L,2L,0L,2L,1L,-2L,3L,0L,-4L,4L,-1L,-6L,5L,-2L,-8L,6L,-3L,-10L,7L,-4L,-12L,8L,-5L,-14L,9L,-6L,-16L,10L,-7L,-18L,11L,-8L,-20L,12L,-9L,-22L,13L,-10L,-24L,14L,-11L,-26L,15L,-12L,-28L,16L,-13L,-30L,17L,-14L,-32L,18L,-15L,-34L,19L,-16L,-36L,20L,-17L,-38L,21L,-18L,-40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137241Inst : IEnumerable<long>
{
public static readonly long[] Value=A137241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137241.Bytes);
public long this[int i]=>Value[i];

public static A137241Inst Instance=new A137241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137242
{
public static readonly long[] Value={ 4L,6L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,24L,25L,27L,29L,31L,32L,36L,37L,38L,39L,40L,44L,48L,50L,51L,54L,55L,56L,58L,59L,63L,65L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,84L,85L,86L,87L,88L,90L,92L,93L,94L,95L,96L,100L,102L,103L,105L,107L,108L,110L,111L,112L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137242Inst : IEnumerable<long>
{
public static readonly long[] Value=A137242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137242.Bytes);
public long this[int i]=>Value[i];

public static A137242Inst Instance=new A137242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137243
{
public static readonly long[] Value={ 8L,16L,32L,48L,80L,96L,144L,176L,224L,256L,336L,368L,464L,512L,576L,640L,768L,816L,960L,1024L,1120L,1200L,1376L,1440L,1600L,1696L,1840L,1936L,2160L,2224L,2464L,2592L,2752L,2880L,3072L,3168L,3456L,3600L,3792L,3920L,4240L,4336L,4672L,4832L,5024L,5200L,5568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137243Inst : IEnumerable<long>
{
public static readonly long[] Value=A137243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137243.Bytes);
public long this[int i]=>Value[i];

public static A137243Inst Instance=new A137243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137244
{
public static readonly BigInteger[] Value={ 2L,2L,6L,42L,1050L,127050L,13086150L,65967282150L,2659866783570150L,13594579130827036650UL,BigInteger.Parse("4484729304047661947505150"),BigInteger.Parse("179016047168539016473835519025150"),BigInteger.Parse("85748973198421705721932588223712809265150"),BigInteger.Parse("533960639770963461900374948788827304744234574385150") };
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
public class A137244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A137244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137244Inst Instance=new A137244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137245
{
public static readonly long[] Value={ 1L,6L,3L,6L,6L,1L,6L,3L,2L,3L,3L,5L,1L,2L,6L,0L,8L,6L,8L,5L,6L,9L,6L,5L,8L,0L,0L,3L,9L,2L,1L,8L,6L,3L,6L,7L,1L,1L,8L,1L,5L,9L,7L,0L,7L,6L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137245Inst : IEnumerable<long>
{
public static readonly long[] Value=A137245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137245.Bytes);
public long this[int i]=>Value[i];

public static A137245Inst Instance=new A137245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137246
{
public static readonly BigInteger[] Value={ 1L,17L,339L,6729L,133563L,2651073L,52620771L,1044462201L,20731381707L,411494247537L,8167690805619L,162119333369769L,3217883594978523L,63871313899461153L,1267772627204287491L,BigInteger.Parse("25163838602387366361"),BigInteger.Parse("499473454166134464747"),BigInteger.Parse("9913977567515527195857") };
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
public class A137246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A137246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137246Inst Instance=new A137246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137247
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,10L,22L,49L,112L,256L,580L,1309L,2956L,6682L,15106L,34141L,77152L,174352L,394024L,890473L,2012404L,4547866L,10277806L,23227033L,52491280L,118626160L,268085740L,605852581L,1369179004L,3094236490L,6992730202L,15803018149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137247Inst : IEnumerable<long>
{
public static readonly long[] Value=A137247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137247.Bytes);
public long this[int i]=>Value[i];

public static A137247Inst Instance=new A137247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137248
{
public static readonly long[] Value={ 2L,3L,13L,23L,0L,43L,233L,0L,433L,2333L,0L,3343L,23333L,0L,33343L,323333L,0L,333433L,3233333L,0L,3333433L,32333333L,0L,34333333L,333233333L,0L,333334333L,3233333333L,0L,3334333333L,23333333333L,0L,33333333343L,333332333333L,0L,333333343333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137248Inst : IEnumerable<long>
{
public static readonly long[] Value=A137248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137248.Bytes);
public long this[int i]=>Value[i];

public static A137248Inst Instance=new A137248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137249
{
public static readonly long[] Value={ 2L,2L,7L,15L,37L,84L,197L,456L,1062L,2467L,5737L,13335L,31002L,72069L,167542L,389486L,905447L,2104907L,4893317L,11375580L,26445017L,61477204L,142917162L,332242091L,772369157L,1795540447L,4174125122L,9703663625L,22558281082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137249Inst : IEnumerable<long>
{
public static readonly long[] Value=A137249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137249.Bytes);
public long this[int i]=>Value[i];

public static A137249Inst Instance=new A137249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137250
{
public static readonly long[] Value={ 2L,0L,0L,6L,6L,6L,6L,4L,5L,2L,8L,3L,1L,0L,6L,8L,7L,5L,6L,4L,3L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137250Inst : IEnumerable<long>
{
public static readonly long[] Value=A137250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137250.Bytes);
public long this[int i]=>Value[i];

public static A137250Inst Instance=new A137250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137251
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,7L,1L,1L,10L,26L,15L,1L,1L,15L,71L,98L,31L,1L,1L,21L,161L,425L,342L,63L,1L,1L,28L,322L,1433L,2285L,1138L,127L,1L,1L,36L,588L,4066L,11210L,11413L,3670L,255L,1L,1L,45L,1002L,10165L,44443L,79781L,54073L,11586L,511L,1L,1L,55L,1617L,23056L,150546L,434638L,528690L,246409L,36038L,1023L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137251Inst : IEnumerable<long>
{
public static readonly long[] Value=A137251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137251.Bytes);
public long this[int i]=>Value[i];

public static A137251Inst Instance=new A137251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137252
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,4L,1L,0L,0L,0L,4L,11L,1L,0L,0L,0L,1L,33L,26L,1L,0L,0L,0L,0L,42L,171L,57L,1L,0L,0L,0L,0L,26L,507L,718L,120L,1L,0L,0L,0L,0L,8L,840L,4017L,2682L,247L,1L,0L,0L,0L,0L,1L,865L,12866L,25531L,9327L,502L,1L,0L,0L,0L,0L,0L,584L,26831L,138080L,141904L,30973L,1013L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137252Inst : IEnumerable<long>
{
public static readonly long[] Value=A137252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137252.Bytes);
public long this[int i]=>Value[i];

public static A137252Inst Instance=new A137252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137253
{
public static readonly long[] Value={ 4L,6L,9L,22L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137253Inst : IEnumerable<long>
{
public static readonly long[] Value=A137253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137253.Bytes);
public long this[int i]=>Value[i];

public static A137253Inst Instance=new A137253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137254
{
public static readonly long[] Value={ 5L,6L,39L,43L,45L,46L,51L,53L,54L,57L,58L,60L,287L,303L,311L,315L,317L,318L,335L,343L,347L,349L,350L,359L,363L,365L,366L,371L,373L,374L,377L,378L,380L,399L,407L,411L,413L,414L,423L,427L,429L,430L,435L,437L,438L,441L,442L,444L,455L,459L,461L,462L,467L,469L,470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137254Inst : IEnumerable<long>
{
public static readonly long[] Value=A137254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137254.Bytes);
public long this[int i]=>Value[i];

public static A137254Inst Instance=new A137254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137255
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,36L,80L,178L,409L,942L,2212L,5204L,12377L,29472L,70592L,169198L,406801L,978426L,2357092L,5679488L,13696385L,33032892L,79703120L,192321034L,464168041L,1120302822L,2704242244L,6527724428L,15758096777L,38040729336L,91834772480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137255Inst : IEnumerable<long>
{
public static readonly long[] Value=A137255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137255.Bytes);
public long this[int i]=>Value[i];

public static A137255Inst Instance=new A137255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137352
{
public static readonly BigInteger[] Value={ 1L,19L,317L,5592L,108839L,2356175L,56590729L,1499304898L,43532688017L,1376491137807L,47122376352941L,1737338689842008L,68657874376063231L,2896049933653455241L,BigInteger.Parse("129892644397271578571"),BigInteger.Parse("6173717934189145195530"),BigInteger.Parse("309998781844881257871161"),BigInteger.Parse("16399060640250318161199785") };
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
public class A137352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A137352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A137352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A137352Inst Instance=new A137352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137353
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137353Inst : IEnumerable<long>
{
public static readonly long[] Value=A137353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137353.Bytes);
public long this[int i]=>Value[i];

public static A137353Inst Instance=new A137353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137354
{
public static readonly long[] Value={ 1L,4L,9L,16L,27L,64L,125L,196L,12167L,28224L,68921L,115600L,177147L,244036L,421875L,614656L,970299L,1378276L,2460375L,3556996L,4657463L,5760000L,9129329L,12531600L,16974593L,21436900L,26730899L,32035600L,39135393L,46240000L,53582633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137354Inst : IEnumerable<long>
{
public static readonly long[] Value=A137354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137354.Bytes);
public long this[int i]=>Value[i];

public static A137354Inst Instance=new A137354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137355
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,37L,61L,71L,11971L,16057L,40697L,46679L,61547L,66889L,177839L,192781L,355643L,407977L,1082099L,1096621L,1100467L,1102537L,3369329L,3402271L,4442993L,4462307L,5293999L,5304701L,7099793L,7104607L,7342633L,7413467L,9448897L,9657503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137355Inst : IEnumerable<long>
{
public static readonly long[] Value=A137355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137355.Bytes);
public long this[int i]=>Value[i];

public static A137355Inst Instance=new A137355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137356
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,5L,11L,21L,36L,58L,92L,149L,250L,431L,750L,1299L,2227L,3784L,6401L,10828L,18364L,31236L,53228L,90741L,154603L,263178L,447702L,761403L,1295022L,2203162L,3749001L,6380241L,10858285L,18478155L,31443013L,53501860L,91034937L,154900529L,263576791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137356Inst : IEnumerable<long>
{
public static readonly long[] Value=A137356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137356.Bytes);
public long this[int i]=>Value[i];

public static A137356Inst Instance=new A137356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137357
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,12L,23L,44L,80L,138L,230L,379L,629L,1060L,1810L,3109L,5336L,9120L,15521L,26349L,44713L,75949L,129177L,219918L,374521L,637699L,1085401L,1846804L,3141826L,5344988L,9093989L,15474230L,26332515L,44810670L,76253683L,129755543L,220790480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137357Inst : IEnumerable<long>
{
public static readonly long[] Value=A137357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137357.Bytes);
public long this[int i]=>Value[i];

public static A137357Inst Instance=new A137357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137358
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,10L,15L,22L,34L,57L,101L,181L,319L,549L,928L,1557L,2617L,4427L,7536L,12872L,21992L,37513L,63862L,108575L,184524L,313701L,533619L,908140L,1545839L,2631240L,4478044L,7619870L,12964858L,22058847L,37533077L,63865592L,108676262L,184929945L,314685488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137358Inst : IEnumerable<long>
{
public static readonly long[] Value=A137358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137358.Bytes);
public long this[int i]=>Value[i];

public static A137358Inst Instance=new A137358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137359
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,4L,10L,20L,35L,58L,98L,176L,333L,640L,1213L,2242L,4052L,7226L,12835L,22842L,40788L,72952L,130344L,232200L,412190L,729466L,1288216L,2272012L,4003795L,7050358L,12404345L,21801674L,38275760L,67125420L,117604174L,205865368L,360090917L,629414866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137359Inst : IEnumerable<long>
{
public static readonly long[] Value=A137359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137359.Bytes);
public long this[int i]=>Value[i];

public static A137359Inst Instance=new A137359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137360
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,5L,15L,35L,70L,128L,226L,402L,735L,1375L,2588L,4830L,8882L,16108L,28943L,51785L,92573L,165525L,295869L,528069L,940259L,1669725L,2957941L,5229953L,9233748L,16284106L,28688451L,50490125L,88765885L,155891305L,273495479L,479360847L,839451764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137360Inst : IEnumerable<long>
{
public static readonly long[] Value=A137360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137360.Bytes);
public long this[int i]=>Value[i];

public static A137360Inst Instance=new A137360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137361
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,6L,21L,56L,126L,254L,480L,882L,1617L,2992L,5580L,10410L,19292L,35400L,64343L,116128L,208701L,374226L,670095L,1198164L,2138423L,3808148L,6766089L,11996042L,21229790L,37513896L,66202347L,116692472L,205458357L,361349662L,634845141L,1114205988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137361Inst : IEnumerable<long>
{
public static readonly long[] Value=A137361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137361.Bytes);
public long this[int i]=>Value[i];

public static A137361Inst Instance=new A137361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137362
{
public static readonly long[] Value={ 4L,7L,8L,11L,14L,17L,18L,21L,24L,25L,28L,31L,34L,35L,38L,41L,42L,45L,48L,49L,52L,55L,58L,59L,62L,65L,66L,69L,72L,75L,76L,79L,82L,83L,86L,89L,92L,93L,96L,99L,100L,103L,106L,107L,110L,113L,116L,117L,120L,123L,124L,127L,130L,133L,134L,137L,140L,141L,144L,147L,148L,151L,154L,157L,158L,161L,164L,165L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137362Inst : IEnumerable<long>
{
public static readonly long[] Value=A137362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137362.Bytes);
public long this[int i]=>Value[i];

public static A137362Inst Instance=new A137362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137363
{
public static readonly long[] Value={ 1L,0L,1L,-1L,-1L,2L,4L,-3L,-3L,4L,1L,6L,-8L,-9L,8L,7L,5L,15L,-20L,-20L,16L,-1L,-3L,18L,37L,-48L,-46L,32L,26L,-6L,-19L,57L,95L,-112L,-99L,64L,1L,16L,-32L,-80L,160L,233L,-256L,-213L,128L,86L,9L,54L,-120L,-254L,432L,566L,-576L,-450L,256L,-1L,14L,50L,174L,-400L,-746L,1120L,1344L,-1280L,-947L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137363Inst : IEnumerable<long>
{
public static readonly long[] Value=A137363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137363.Bytes);
public long this[int i]=>Value[i];

public static A137363Inst Instance=new A137363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137364
{
public static readonly long[] Value={ 83L,179L,227L,347L,419L,419L,467L,491L,563L,587L,659L,659L,827L,971L,1019L,1019L,1091L,1259L,1427L,1499L,1499L,1667L,1811L,1811L,1907L,1907L,1979L,1979L,2027L,2243L,2267L,2339L,2339L,2531L,2579L,2699L,2819L,2843L,2939L,3347L,3539L,3539L,3659L,3659L,3779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137364Inst : IEnumerable<long>
{
public static readonly long[] Value=A137364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137364.Bytes);
public long this[int i]=>Value[i];

public static A137364Inst Instance=new A137364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137365
{
public static readonly long[] Value={ 1483L,5381L,6271L,7229L,9181L,11897L,13103L,13841L,14489L,17107L,20357L,25747L,26711L,27917L,30161L,30259L,31247L,32579L,36161L,36583L,36677L,36899L,36901L,42083L,48817L,54181L,55511L,55691L,56377L,56897L,57637L,59093L,64151L,66347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137365Inst : IEnumerable<long>
{
public static readonly long[] Value=A137365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137365.Bytes);
public long this[int i]=>Value[i];

public static A137365Inst Instance=new A137365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137366
{
public static readonly long[] Value={ 1483L,5381L,6271L,7229L,9181L,11897L,13103L,13841L,14489L,17107L,20357L,25747L,26711L,27917L,30161L,30259L,31247L,32579L,36677L,36899L,36901L,42083L,48817L,54181L,55511L,55691L,56377L,57637L,64151L,66347L,69389L,75167L,76031L,76123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137366Inst : IEnumerable<long>
{
public static readonly long[] Value=A137366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137366.Bytes);
public long this[int i]=>Value[i];

public static A137366Inst Instance=new A137366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137367
{
public static readonly long[] Value={ 7L,23L,119L,287L,839L,1679L,3479L,5039L,10199L,11447L,18767L,22199L,32039L,36479L,38807L,51527L,57119L,72359L,78959L,96719L,120407L,175559L,185759L,212519L,271439L,323759L,358799L,380687L,410879L,434279L,654479L,674039L,683927L,734447L,776159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137367Inst : IEnumerable<long>
{
public static readonly long[] Value=A137367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137367.Bytes);
public long this[int i]=>Value[i];

public static A137367Inst Instance=new A137367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137448
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,-2L,0L,-3L,0L,-20L,1L,0L,8L,0L,-88L,0L,5L,0L,100L,0L,-304L,-1L,0L,-18L,0L,528L,0L,-928L,0L,-7L,0L,-280L,0L,2128L,0L,-2624L,1L,0L,32L,0L,-1760L,0L,7424L,0L,-7040L,0L,9L,0L,600L,0L,-8208L,0L,23616L,0L,-18176L,-1L,0L,-50L,0L,4400L,0L,-32480L,0L,70400L,0L,-45568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137448Inst : IEnumerable<long>
{
public static readonly long[] Value=A137448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137448.Bytes);
public long this[int i]=>Value[i];

public static A137448Inst Instance=new A137448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137449
{
public static readonly long[] Value={ 1L,1L,1L,-2L,0L,-4L,0L,-12L,0L,-40L,12L,0L,48L,0L,-176L,0L,120L,0L,800L,0L,-608L,-120L,0L,-720L,0L,5280L,0L,-1856L,0L,-1680L,0L,-16800L,0L,25536L,0L,-5248L,1680L,0L,13440L,0L,-147840L,0L,103936L,0L,-14080L,0L,30240L,0L,403200L,0L,-919296L,0L,377856L,0L,-36352L,-30240L,0L,-302400L,0L,4435200L,0L,-4677120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137449Inst : IEnumerable<long>
{
public static readonly long[] Value=A137449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137449.Bytes);
public long this[int i]=>Value[i];

public static A137449Inst Instance=new A137449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137450
{
public static readonly long[] Value={ 1L,1L,2L,2L,10L,2L,52L,53L,187L,26L,2291L,129L,25588L,2758L,4271L,22523L,678325L,28362L,11607386L,1163963L,2111498L,601221L,222671145L,12394049L,856676621L,59403427L,1983047734L,307321811L,77544004469L,57508385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137450Inst : IEnumerable<long>
{
public static readonly long[] Value=A137450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137450.Bytes);
public long this[int i]=>Value[i];

public static A137450Inst Instance=new A137450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137451
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,10L,12L,13L,16L,18L,19L,22L,24L,25L,28L,31L,33L,34L,37L,39L,40L,43L,46L,51L,55L,57L,61L,63L,67L,70L,74L,76L,78L,79L,81L,83L,84L,86L,87L,92L,94L,97L,99L,100L,102L,109L,114L,118L,120L,124L,125L,127L,131L,132L,136L,137L,139L,140L,141L,142L,151L,156L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137451Inst : IEnumerable<long>
{
public static readonly long[] Value=A137451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137451.Bytes);
public long this[int i]=>Value[i];

public static A137451Inst Instance=new A137451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137452
{
public static readonly long[] Value={ 1L,0L,1L,0L,-2L,1L,0L,9L,-6L,1L,0L,-64L,48L,-12L,1L,0L,625L,-500L,150L,-20L,1L,0L,-7776L,6480L,-2160L,360L,-30L,1L,0L,117649L,-100842L,36015L,-6860L,735L,-42L,1L,0L,-2097152L,1835008L,-688128L,143360L,-17920L,1344L,-56L,1L,0L,43046721L,-38263752L,14880348L,-3306744L,459270L,-40824L,2268L,-72L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137452Inst : IEnumerable<long>
{
public static readonly long[] Value=A137452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137452.Bytes);
public long this[int i]=>Value[i];

public static A137452Inst Instance=new A137452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137453
{
public static readonly long[] Value={ 2L,9L,7L,15L,17L,31L,47L,53L,91L,71L,143L,95L,19L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137453Inst : IEnumerable<long>
{
public static readonly long[] Value=A137453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137453.Bytes);
public long this[int i]=>Value[i];

public static A137453Inst Instance=new A137453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137454
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,2L,2L,-1L,-2L,-1L,-1L,1L,0L,1L,5L,4L,-1L,-3L,-1L,-1L,1L,-3L,-5L,-2L,3L,9L,6L,-1L,-4L,-1L,-1L,1L,2L,1L,-10L,-16L,-6L,6L,14L,8L,-1L,-5L,-1L,-1L,1L,3L,9L,14L,4L,-23L,-34L,-12L,10L,20L,10L,-1L,-6L,-1L,-1L,1L,-5L,-8L,10L,38L,45L,10L,-44L,-60L,-20L,15L,27L,12L,-1L,-7L,-1L,-1L,1L,-1L,-11L,-38L,-42L,23L,101L,105L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137454Inst : IEnumerable<long>
{
public static readonly long[] Value=A137454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137454.Bytes);
public long this[int i]=>Value[i];

public static A137454Inst Instance=new A137454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137455
{
public static readonly long[] Value={ 0L,1L,-3L,2L,5L,-15L,3L,-14L,56L,-42L,4L,54L,-170L,290L,-90L,5L,-264L,744L,-1350L,1000L,-165L,6L,1560L,-4116L,6174L,-7210L,2695L,-273L,7L,-10800L,27264L,-37296L,41664L,-28420L,6160L,-420L,8L,85680L,-209520L,270864L,-260064L,223524L,-89964L,12516L,-612L,9L,-766080L,1828800L,-2274480L,2021760L,-1587600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137455Inst : IEnumerable<long>
{
public static readonly long[] Value=A137455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137455.Bytes);
public long this[int i]=>Value[i];

public static A137455Inst Instance=new A137455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137456
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,0L,-8L,0L,8L,0L,0L,36L,0L,-72L,0L,32L,12L,0L,-144L,0L,496L,0L,-512L,0L,128L,0L,0L,600L,0L,-3200L,0L,5280L,0L,-3200L,0L,512L,120L,0L,-2880L,0L,19200L,0L,-47104L,0L,47232L,0L,-18432L,0L,2048L,0L,0L,11760L,0L,-117600L,0L,385728L,0L,-560000L,0L,372736L,0L,-100352L,0L,8192L,1680L,0L,-67200L,0L,712320L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137456Inst : IEnumerable<long>
{
public static readonly long[] Value=A137456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137456.Bytes);
public long this[int i]=>Value[i];

public static A137456Inst Instance=new A137456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137457
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,5L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,5L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137457Inst : IEnumerable<long>
{
public static readonly long[] Value=A137457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137457.Bytes);
public long this[int i]=>Value[i];

public static A137457Inst Instance=new A137457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137458
{
public static readonly long[] Value={ 2L,3L,5L,2L,11L,13L,17L,3L,2L,29L,31L,5L,41L,43L,47L,2L,59L,3L,67L,11L,73L,79L,83L,13L,2L,101L,5L,17L,109L,113L,127L,3L,137L,139L,149L,2L,157L,163L,167L,29L,179L,181L,191L,31L,11L,199L,211L,5L,2L,3L,233L,41L,241L,13L,257L,43L,269L,271L,277L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137458Inst : IEnumerable<long>
{
public static readonly long[] Value=A137458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137458.Bytes);
public long this[int i]=>Value[i];

public static A137458Inst Instance=new A137458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137459
{
public static readonly long[] Value={ 2L,3L,13L,163L,193L,349L,541L,769L,1093L,1231L,1423L,1549L,1621L,1693L,1801L,2011L,3049L,3511L,4003L,4111L,4159L,5839L,6091L,6421L,6703L,6883L,7573L,7753L,8929L,9043L,9601L,9769L,9781L,12781L,13633L,14821L,15091L,15439L,16141L,16759L,17863L,18493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137459Inst : IEnumerable<long>
{
public static readonly long[] Value=A137459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137459.Bytes);
public long this[int i]=>Value[i];

public static A137459Inst Instance=new A137459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137460
{
public static readonly long[] Value={ 3L,5L,17L,71L,101L,131L,677L,839L,857L,1091L,1217L,2129L,2309L,2339L,2957L,3137L,3449L,3989L,4409L,6569L,6719L,6761L,7229L,8501L,8627L,8807L,9521L,9689L,9749L,10589L,10631L,11621L,11777L,11927L,12641L,13487L,13931L,14519L,15527L,15797L,16007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137460Inst : IEnumerable<long>
{
public static readonly long[] Value=A137460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137460.Bytes);
public long this[int i]=>Value[i];

public static A137460Inst Instance=new A137460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137461
{
public static readonly long[] Value={ 4L,7L,10L,15L,21L,25L,39L,52L,87L,120L,129L,139L,189L,202L,259L,286L,316L,376L,391L,466L,472L,486L,510L,532L,574L,631L,642L,684L,685L,739L,750L,769L,882L,972L,987L,991L,1029L,1074L,1092L,1201L,1212L,1231L,1320L,1326L,1456L,1506L,1522L,1524L,1539L,1575L,1632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137461Inst : IEnumerable<long>
{
public static readonly long[] Value=A137461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137461.Bytes);
public long this[int i]=>Value[i];

public static A137461Inst Instance=new A137461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137462
{
public static readonly long[] Value={ 1L,3L,3L,6L,4L,10L,5L,16L,6L,19L,7L,26L,8L,27L,11L,28L,18L,31L,20L,35L,22L,36L,26L,39L,30L,44L,33L,49L,36L,50L,37L,54L,39L,55L,40L,66L,45L,70L,48L,71L,50L,72L,51L,78L,55L,79L,62L,80L,63L,82L,64L,91L,67L,92L,69L,97L,72L,105L,73L,110L,75L,112L,82L,119L,83L,120L,85L,121L,88L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137462Inst : IEnumerable<long>
{
public static readonly long[] Value=A137462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137462.Bytes);
public long this[int i]=>Value[i];

public static A137462Inst Instance=new A137462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137463
{
public static readonly long[] Value={ 7L,139L,631L,739L,769L,991L,1201L,1231L,2677L,3499L,3931L,4261L,4441L,4861L,6247L,7411L,7699L,8377L,9391L,10711L,10837L,14389L,15139L,15679L,16057L,16561L,18541L,20479L,22861L,28111L,28837L,29917L,30169L,30367L,32089L,33589L,35311L,35677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137463Inst : IEnumerable<long>
{
public static readonly long[] Value=A137463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137463.Bytes);
public long this[int i]=>Value[i];

public static A137463Inst Instance=new A137463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137496
{
public static readonly long[] Value={ 0L,0L,0L,2L,-12L,24L,40L,-240L,240L,0L,1200L,-3600L,2400L,-840L,0L,25200L,-50400L,25200L,0L,-47040L,0L,470400L,-705600L,282240L,80640L,0L,-1693440L,0L,8467200L,-10160640L,3386880L,0L,7257600L,0L,-50803200L,0L,152409600L,-152409600L,43545600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137496Inst : IEnumerable<long>
{
public static readonly long[] Value=A137496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137496.Bytes);
public long this[int i]=>Value[i];

public static A137496Inst Instance=new A137496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137497
{
public static readonly long[] Value={ 0L,0L,1L,-3L,6L,6L,-36L,36L,0L,120L,-360L,240L,-60L,0L,1800L,-3600L,1800L,0L,-2520L,0L,25200L,-37800L,15120L,3360L,0L,-70560L,0L,352800L,-423360L,141120L,0L,241920L,0L,-1693440L,0L,5080320L,-5080320L,1451520L,-544320L,0L,10886400L,0L,-38102400L,0L,76204800L,-65318400L,16329600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137497Inst : IEnumerable<long>
{
public static readonly long[] Value=A137497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137497.Bytes);
public long this[int i]=>Value[i];

public static A137497Inst Instance=new A137497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137498
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,-60L,120L,300L,-1800L,1800L,0L,12600L,-37800L,25200L,-11760L,0L,352800L,-705600L,352800L,0L,-846720L,0L,8467200L,-12700800L,5080320L,1814400L,0L,-38102400L,0L,190512000L,-228614400L,76204800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137498Inst : IEnumerable<long>
{
public static readonly long[] Value=A137498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137498.Bytes);
public long this[int i]=>Value[i];

public static A137498Inst Instance=new A137498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137499
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,24L,-360L,720L,2520L,-15120L,15120L,0L,141120L,-423360L,282240L,-169344L,0L,5080320L,-10160640L,5080320L,0L,-15240960L,0L,152409600L,-228614400L,91445760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137499Inst : IEnumerable<long>
{
public static readonly long[] Value=A137499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137499.Bytes);
public long this[int i]=>Value[i];

public static A137499Inst Instance=new A137499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137500
{
public static readonly long[] Value={ 0L,0L,1L,5L,17L,51L,149L,439L,1309L,3927L,11797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137500Inst : IEnumerable<long>
{
public static readonly long[] Value=A137500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137500.Bytes);
public long this[int i]=>Value[i];

public static A137500Inst Instance=new A137500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137501
{
public static readonly long[] Value={ 0L,0L,2L,-2L,4L,-4L,6L,-6L,8L,-8L,10L,-10L,12L,-12L,14L,-14L,16L,-16L,18L,-18L,20L,-20L,22L,-22L,24L,-24L,26L,-26L,28L,-28L,30L,-30L,32L,-32L,34L,-34L,36L,-36L,38L,-38L,40L,-40L,42L,-42L,44L,-44L,46L,-46L,48L,-48L,50L,-50L,52L,-52L,54L,-54L,56L,-56L,58L,-58L,60L,-60L,62L,-62L,64L,-64L,66L,-66L,68L,-68L,70L,-70L,72L,-72L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137501Inst : IEnumerable<long>
{
public static readonly long[] Value=A137501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137501.Bytes);
public long this[int i]=>Value[i];

public static A137501Inst Instance=new A137501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137502
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,10L,2L,18L,2L,14L,6L,16L,2L,12L,2L,50L,10L,22L,2L,54L,4L,26L,8L,98L,2L,30L,2L,32L,14L,34L,6L,36L,2L,38L,22L,250L,2L,70L,2L,242L,18L,46L,2L,162L,4L,20L,26L,338L,2L,24L,10L,686L,34L,58L,2L,150L,2L,62L,50L,64L,14L,154L,2L,578L,38L,42L,2L,108L,2L,74L,12L,722L,6L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137502Inst : IEnumerable<long>
{
public static readonly long[] Value=A137502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137502.Bytes);
public long this[int i]=>Value[i];

public static A137502Inst Instance=new A137502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137503
{
public static readonly long[] Value={ 1L,0L,1L,4L,3L,8L,16L,28L,45L,96L,167L,308L,579L,1100L,2018L,3852L,7280L,13776L,26133L,49996L,95223L,182248L,349474L,671176L,1289925L,2485644L,4793355L,9255700L,17894421L,34638296L,67105714L,130148812L,252644985L,490852972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137503Inst : IEnumerable<long>
{
public static readonly long[] Value=A137503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137503.Bytes);
public long this[int i]=>Value[i];

public static A137503Inst Instance=new A137503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137504
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,11L,21L,28L,47L,64L,100L,135L,205L,273L,398L,530L,749L,989L,1373L,1796L,2446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137504Inst : IEnumerable<long>
{
public static readonly long[] Value=A137504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137504.Bytes);
public long this[int i]=>Value[i];

public static A137504Inst Instance=new A137504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137505
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,4L,-4L,4L,4L,-12L,20L,-12L,-12L,52L,-76L,52L,52L,-204L,308L,-204L,-204L,820L,-1228L,820L,820L,-3276L,4916L,-3276L,-3276L,13108L,-19660L,13108L,13108L,-52428L,78644L,-52428L,-52428L,209716L,-314572L,209716L,209716L,-838860L,1258292L,-838860L,-838860L,3355444L,-5033164L,3355444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137505Inst : IEnumerable<long>
{
public static readonly long[] Value=A137505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137505.Bytes);
public long this[int i]=>Value[i];

public static A137505Inst Instance=new A137505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137506
{
public static readonly long[] Value={ 141L,59L,265L,35L,389L,11L,513L,13L,637L,11L,761L,13L,885L,11L,1009L,13L,1133L,11L,1257L,13L,1381L,11L,1505L,13L,1629L,11L,1753L,13L,1877L,11L,2001L,13L,2125L,11L,2249L,13L,2373L,11L,2497L,13L,2621L,11L,2745L,13L,2869L,11L,2993L,13L,3117L,11L,3241L,13L,3365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137506Inst : IEnumerable<long>
{
public static readonly long[] Value=A137506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137506.Bytes);
public long this[int i]=>Value[i];

public static A137506Inst Instance=new A137506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137507
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,300L,320L,340L,360L,380L,400L,420L,440L,460L,480L,14000L,14200L,14400L,14600L,14800L,15000L,15200L,15400L,15600L,15800L,1060000L,1062000L,1064000L,1066000L,1068000L,1070000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137507Inst : IEnumerable<long>
{
public static readonly long[] Value=A137507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137507.Bytes);
public long this[int i]=>Value[i];

public static A137507Inst Instance=new A137507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137508
{
public static readonly long[] Value={ 2L,2L,2L,8L,2L,2L,8L,8L,2L,2L,8L,18L,8L,2L,2L,8L,18L,18L,8L,2L,2L,8L,18L,32L,18L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137508Inst : IEnumerable<long>
{
public static readonly long[] Value=A137508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137508.Bytes);
public long this[int i]=>Value[i];

public static A137508Inst Instance=new A137508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137509
{
public static readonly long[] Value={ 2L,3L,5L,9L,11L,14L,17L,27L,49L,51L,53L,63L,67L,69L,74L,81L,83L,92L,97L,98L,106L,111L,113L,135L,169L,177L,343L,356L,359L,366L,367L,3125L,3127L,3131L,3133L,3249L,3251L,3254L,3261L,3272L,3299L,3302L,3307L,3308L,3316L,3317L,3319L,3321L,3481L,3501L,3503L,3508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137509Inst : IEnumerable<long>
{
public static readonly long[] Value=A137509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137509.Bytes);
public long this[int i]=>Value[i];

public static A137509Inst Instance=new A137509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137510
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,2L,3L,0L,2L,4L,3L,2L,5L,0L,2L,3L,4L,6L,0L,2L,7L,3L,5L,2L,4L,8L,0L,2L,3L,6L,9L,0L,2L,4L,5L,10L,3L,7L,2L,11L,0L,2L,3L,4L,6L,8L,12L,5L,2L,13L,3L,9L,2L,4L,7L,14L,0L,2L,3L,5L,6L,10L,15L,0L,2L,4L,8L,16L,3L,11L,2L,17L,5L,7L,2L,3L,4L,6L,9L,12L,18L,0L,2L,19L,3L,13L,2L,4L,5L,8L,10L,20L,0L,2L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137510Inst : IEnumerable<long>
{
public static readonly long[] Value=A137510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137510.Bytes);
public long this[int i]=>Value[i];

public static A137510Inst Instance=new A137510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137511
{
public static readonly long[] Value={ -1L,0L,-2L,4L,0L,-8L,0L,36L,0L,-48L,-48L,0L,384L,0L,-384L,0L,-1200L,0L,4800L,0L,-3840L,1440L,0L,-25920L,0L,69120L,0L,-46080L,0L,70560L,0L,-564480L,0L,1128960L,0L,-645120L,-80640L,0L,2580480L,0L,-12902400L,0L,20643840L,0L,-10321920L,0L,-6531840L,0L,87091200L,0L,-313528320L,0L,418037760L,0L,-185794560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137511Inst : IEnumerable<long>
{
public static readonly long[] Value=A137511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137511.Bytes);
public long this[int i]=>Value[i];

public static A137511Inst Instance=new A137511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137544
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,534L,3064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137544Inst : IEnumerable<long>
{
public static readonly long[] Value=A137544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137544.Bytes);
public long this[int i]=>Value[i];

public static A137544Inst Instance=new A137544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137545
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,535L,3081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137545Inst : IEnumerable<long>
{
public static readonly long[] Value=A137545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137545.Bytes);
public long this[int i]=>Value[i];

public static A137545Inst Instance=new A137545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137546
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,535L,3082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137546Inst : IEnumerable<long>
{
public static readonly long[] Value=A137546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137546.Bytes);
public long this[int i]=>Value[i];

public static A137546Inst Instance=new A137546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137547
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,535L,3085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137547Inst : IEnumerable<long>
{
public static readonly long[] Value=A137547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137547.Bytes);
public long this[int i]=>Value[i];

public static A137547Inst Instance=new A137547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137548
{
public static readonly long[] Value={ 1L,2L,6L,23L,104L,535L,3088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137548Inst : IEnumerable<long>
{
public static readonly long[] Value=A137548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137548.Bytes);
public long this[int i]=>Value[i];

public static A137548Inst Instance=new A137548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137549
{
public static readonly long[] Value={ 1L,2L,5L,14L,43L,143L,511L,1950L,7903L,33848L,152529L,720466L,3555715L,18285538L,97752779L,542107657L,3112916651L,18477588573L,113203102619L,714836382820L,4646688247467L,31057662848411L,213217403924667L,1502038027665181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137549Inst : IEnumerable<long>
{
public static readonly long[] Value=A137549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137549.Bytes);
public long this[int i]=>Value[i];

public static A137549Inst Instance=new A137549Inst();

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